using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe
{
    public partial class BillInfo : Form
    {
        protected DataGridView dgv2;
        public BillInfo(DataGridView dgv)
        {
            InitializeComponent();

            
            dgv2 = dgv;
            Point x = new Point(9, 50) ;
            dgv2.Location = x;
            this.Controls.Add(dgv2);
            textBox32.Text = Class1.trigia.ToString();
            dgv2.RowsRemoved += new DataGridViewRowsRemovedEventHandler(DataGridView1_RowsRemoved);
        }

        private void DataGridView1_RowsRemoved(object sender, System.Windows.Forms.DataGridViewRowsRemovedEventArgs e)
        {
            Class1.trigia = 0;
            for (int i = 0; i < dgv2.Rows.Count - 1; i++)
            {
                Class1.trigia += Convert.ToInt32(dgv2.Rows[i].Cells[4].Value) / 1000 * Convert.ToInt32(dgv2.Rows[i].Cells[2].Value);
            }
            textBox32.Text = Class1.trigia.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connString);
            //try
            //{
            //    connection.Open();
            //    String sqlQuerry = "select Gia from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Bl";
            //    SqlCommand command = new SqlCommand(sqlQuerry, connection);
            //    command.ExecuteNonQuery();

            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show("khong the mo ket noi hoac ket noi da duoc mo tu truoc");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ket noi xay ra loi");
            //}
            //finally
            //{

            //    connection.Close();
            //}




            if (dgv2.Rows[1].Cells[1].Value != null)
            {
    
                MessageBox.Show("insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1 SoHd  from HoaDon order by SoHd desc),"+ dgv2.Rows[0].Cells[0].Value.ToString() + ",'"+dgv2.Rows[0].Cells[3].Value.ToString()+"',"+ dgv2.Rows[0].Cells[2].Value.ToString() + ")");
            }


        }
    }
}
