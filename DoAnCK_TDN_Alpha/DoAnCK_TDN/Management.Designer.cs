namespace DoAnCK_TDN
{
    partial class Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Tiếng Anh:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nghĩa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(220, 213);
            this.textBox2.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(379, 172);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 44);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(379, 225);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 44);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Sửa ";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(554, 172);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 44);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(554, 225);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(113, 44);
            this.ShowAllButton.TabIndex = 9;
            this.ShowAllButton.Text = "Hiện Từ Đã Có";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 166);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ Đã Thêm Gần Đây";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ Đồng Nghĩa:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ Trái Nghĩa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 41);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 115);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(537, 41);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 115);
            this.textBox4.TabIndex = 4;
            // 
            // Management
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Management";
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}