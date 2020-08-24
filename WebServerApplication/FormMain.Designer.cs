namespace WebServerApplication
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.lbserver = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.BackColor = System.Drawing.Color.Honeydew;
            this.btnOpenBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBrowser.Location = new System.Drawing.Point(839, 438);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(213, 41);
            this.btnOpenBrowser.TabIndex = 27;
            this.btnOpenBrowser.Text = "Mở trình duyệt ⤴";
            this.btnOpenBrowser.UseVisualStyleBackColor = false;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // lbserver
            // 
            this.lbserver.AutoSize = true;
            this.lbserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbserver.ForeColor = System.Drawing.Color.Blue;
            this.lbserver.Location = new System.Drawing.Point(350, 448);
            this.lbserver.Name = "lbserver";
            this.lbserver.Size = new System.Drawing.Size(141, 29);
            this.lbserver.TabIndex = 26;
            this.lbserver.Text = "ServerText";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(452, 572);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(294, 69);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Hủy Kích Hoạt";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 24;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Window;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(503, 406);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 74);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Kích Hoạt";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(605, 502);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(372, 39);
            this.lbStatus.TabIndex = 22;
            this.lbStatus.Text = "KHÔNG HOẠT ĐỘNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trạng thái SERVER:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(612, 302);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(153, 29);
            this.txtPort.TabIndex = 20;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cổng giao tiếp (PORT):";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(617, 126);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 62);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "XÓA";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tập tin đã chọn:";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.ForeColor = System.Drawing.Color.Red;
            this.lbFile.Location = new System.Drawing.Point(607, 225);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(299, 25);
            this.lbFile.TabIndex = 16;
            this.lbFile.Text = "(Chưa có Tập tin nào được chọn)";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOpenFile.Location = new System.Drawing.Point(623, 133);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(191, 49);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "Chọn tệp";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chọn tập tin HTML của bạn:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 775);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.lbserver);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEB SERVER APPLICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.Label lbserver;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

