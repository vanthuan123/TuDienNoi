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

namespace DoAnCK_TDN
{
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {            
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refresh();
        }

        private void Refresh()
        {
            dataGridView1.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_Chon").Tables[0];
        }

        private void EditVoca_Click(object sender, EventArgs e)
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

        
        
        private void DeleteVoca_Click(object sender, EventArgs e)
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
        int index;
        private void dataGridView1_Click_1(object sender, EventArgs e)
        {

            index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        
       
    }
}
