namespace DoAnCK_TDN
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.NghiaLabel = new System.Windows.Forms.Label();
            this.DongNghiaLabel = new System.Windows.Forms.Label();
            this.TraiNghiaLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Từ Đã Tra";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 349);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 40);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dịch Nghĩa Chi Tiết:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Từ Trái Nghĩa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Từ Đồng Nghĩa:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ Cần Tra:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::DoAnCK_TDN.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Sound_on;
            this.button2.Location = new System.Drawing.Point(417, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 40);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(583, 252);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(183, 120);
            this.axWindowsMediaPlayer1.TabIndex = 18;
            // 
            // NghiaLabel
            // 
            this.NghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NghiaLabel.Location = new System.Drawing.Point(483, 64);
            this.NghiaLabel.Name = "NghiaLabel";
            this.NghiaLabel.Size = new System.Drawing.Size(389, 352);
            this.NghiaLabel.TabIndex = 19;
            // 
            // DongNghiaLabel
            // 
            this.DongNghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DongNghiaLabel.Location = new System.Drawing.Point(264, 158);
            this.DongNghiaLabel.Name = "DongNghiaLabel";
            this.DongNghiaLabel.Size = new System.Drawing.Size(168, 97);
            this.DongNghiaLabel.TabIndex = 19;
            // 
            // TraiNghiaLabel
            // 
            this.TraiNghiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TraiNghiaLabel.Location = new System.Drawing.Point(264, 289);
            this.TraiNghiaLabel.Name = "TraiNghiaLabel";
            this.TraiNghiaLabel.Size = new System.Drawing.Size(168, 97);
            this.TraiNghiaLabel.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.adminToolStripMenuItem.Text = "Adminator";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // MainApp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 436);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.TraiNghiaLabel);
            this.Controls.Add(this.DongNghiaLabel);
            this.Controls.Add(this.NghiaLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label NghiaLabel;
        private System.Windows.Forms.Label DongNghiaLabel;
        private System.Windows.Forms.Label TraiNghiaLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
    }
}