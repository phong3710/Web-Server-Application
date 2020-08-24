using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace WebServerApplication
{
    public partial class FormMain : Form
    {
        public OpenFileDialog op;
        public webserver ws;
        public string server;
        public static String file;

        public FormMain()
        {
            InitializeComponent();
            btnDel.Hide();
            txtPort.Enabled = false;
            btnStop.Hide();
            btnStart.Enabled = false;
            lbserver.Hide();
            btnOpenBrowser.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (op.FileName != null)
            {
                op.Reset();
                lbFile.Text = "(Chưa có Tập tin nào được chọn)";
                btnOpenFile.Show();
                btnDel.Hide();
                txtPort.Enabled = false;
                file = null;
                btnStart.Enabled = false;
            }
        }

        public class webserver
        {
            private readonly HttpListener listener = new HttpListener();
            private readonly Func<HttpListenerRequest, string> resp;

            public webserver(string[] prefix, Func<HttpListenerRequest, string> method)
            {
                if (prefix == null || prefix.Length == 0)
                {
                    throw new ArgumentException("prefix");

                }
                if (method == null)
                {
                    throw new ArgumentException("method");

                }
                foreach (string s in prefix)
                {
                    listener.Prefixes.Add(s);

                }
                resp = method;
                listener.Start();
            }
            public webserver(Func<HttpListenerRequest, string> method, params string[] prefix) : this(prefix, method) { }
            public void run()
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    try
                    {
                        while (listener.IsListening)
                        {
                            ThreadPool.QueueUserWorkItem((c) =>
                            {
                                var ctx = c as HttpListenerContext;
                                try
                                {
                                    string rstr = resp(ctx.Request);
                                    byte[] buff = Encoding.UTF8.GetBytes(rstr);
                                    ctx.Response.ContentLength64 = buff.Length;
                                    ctx.Response.OutputStream.Write(buff, 0, buff.Length);
                                }
                                catch
                                {

                                }
                                finally
                                {
                                    ctx.Response.OutputStream.Close();

                                }

                            }, listener.GetContext());
                        }
                    }
                    catch
                    {

                    }


                });
            }
            public void Stop()
            {
                listener.Stop();
                listener.Close();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Duyệt tập tin HTML",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "html",
                Filter = "HTML files (*.html)|*.html",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = false
            };
            if (op.ShowDialog() == DialogResult.OK)
            {
                lbFile.Text = Path.GetFileName(op.FileName).ToUpper();
                btnOpenFile.Hide();
                btnDel.Show();
                txtPort.Enabled = true;
                file = File.ReadAllText(op.FileName);
                btnStart.Enabled = true;
            }
        }
       
        private static string SendResponse(HttpListenerRequest request)
        {
            return file;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (txtPort.Text.ToString() != "")
                port = int.Parse(txtPort.Text.ToString());
            else
            {
                DialogResult kq = new DialogResult();
                kq = MessageBox.Show("Chưa nhập PORT", "ERROR", MessageBoxButtons.OK);
                if (kq == DialogResult.OK) return;
            }

            server = "http://localhost:" + port + "/";
            ws = new webserver(SendResponse, server);
            ws.run();
            btnStop.Show();
            btnStart.Hide();
            btnDel.Enabled = false;
            txtPort.Enabled = false;
            lbStatus.Text = "ĐANG HOẠT ĐỘNG";
            lbStatus.ForeColor = Color.LimeGreen;
            lbserver.Text = "Server: " + server;
            lbserver.Show();
            btnOpenBrowser.Show();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbStatus.ForeColor == Color.Green)
                lbStatus.ForeColor = Color.LimeGreen;
            else
                lbStatus.ForeColor = Color.Green;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Truy cập " + server, "Are you sure?", MessageBoxButtons.OKCancel);
            if (kq == DialogResult.OK)
                Process.Start(server);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Dừng WEB SERVER " + server, "Are you sure?", MessageBoxButtons.OKCancel);
            if (kq == DialogResult.OK)
            {
                ws.Stop();
                btnStart.Show();
                btnStop.Hide();
                lbStatus.Text = "KHÔNG HOẠT ĐỘNG";
                lbStatus.ForeColor = Color.Red;
                txtPort.Enabled = true;
                btnDel.Enabled = true;
                lbserver.Hide();
                btnOpenBrowser.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
