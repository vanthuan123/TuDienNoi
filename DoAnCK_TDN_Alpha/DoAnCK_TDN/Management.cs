using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using System.Globalization;


namespace DoAnCK_TDN
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refresh();

        }

        private void Refresh()
        {
            dataGridView1.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_Chon").Tables[0];
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == textBox1.Text)
            {
                MessageBox.Show("Không thể thêm vì từ đã tồn tại !", "Error!!!");
            }
            else try
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Chưa có từ mà thêm cc !");
                }
                else
                {
                    string Eng = textBox1.Text.Trim();
                    string Detail = textBox2.Text.Trim();
                    string Synonym = textBox3.Text.Trim();
                    string Antonym = textBox4.Text.Trim();

                    SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuVung_Them", Eng, Detail, Synonym, Antonym);
                    MessageBox.Show("Thêm Thành Công !");
                    Refresh();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int index;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    string Eng = textBox1.Text.Trim();
                    SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuVung_Xoa", Eng);
                    MessageBox.Show("Xóa Thành Công !");
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Eng = textBox1.Text.Trim();
                string Detail = textBox2.Text.Trim();
                string Synonym = textBox3.Text.Trim();
                string Antonym = textBox4.Text.Trim();

                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuVung_Sua", Eng, Detail, Synonym, Antonym);
                MessageBox.Show("Sửa Thành Công !");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            Vocabulary Voca = new Vocabulary();
            Voca.Show();            
        }

        private void Voca_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textBox1.Text = textInfo.ToTitleCase(textBox1.Text);
            textBox1.SelectionStart = textBox1.Text.Length;
        }                    


        //private void Management_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
