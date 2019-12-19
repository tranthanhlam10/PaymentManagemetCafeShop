using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Setting1 : Form
    {
        public Setting1()
        {
            InitializeComponent();
            dataGridView2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting1_Load(object sender, EventArgs e)
        {
            String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);

            try
            {
                connection.Open();
                String sqlQuerry = "select	SoHd,NgHD,TriGia from HoaDon where day(NgHD)=day(GETDATE())";
                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    //DateTime dt = (DateTime)reader.GetSqlDateTime(1);
                    row.Cells[1].Value = reader.GetDateTime(1).ToString();
                    row.Cells[2].Value = reader.GetSqlMoney(2);
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("khong the mo ket noi hoac ket noi da duoc mo tu truoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi xay ra loi");
            }
            finally
            {
                connection.Close();
            }


            

            try
            {
                connection.Open();
                String sqlQuerry = "select	Ten,sum(SoLuong) from CTHD, SanPham, HoaDon where cthd.MaSP = SanPham.MaSP and HoaDon.SoHd = CTHD.SoHD and NgHD>= '11/19/2019' and NgHD<= '12/19/2019' group by CTHD.MaSP,Ten order by sum(SoLuong)desc";

                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        return;
                    }
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetString(0);
                    //DateTime dt = (DateTime)reader.GetSqlDateTime(1);
                    row.Cells[1].Value = reader.GetInt32(1);
                    dataGridView2.Rows.Add(row);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("khong the mo ket noi hoac ket noi da duoc mo tu truoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi xay ra loi");
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Best seller")
            {
                dataGridView1.Hide();
                dataGridView2.Show();
            }
            else if(comboBox1.Text=="Hóa đơn")
            {
                dataGridView1.Show();
                dataGridView2.Hide();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);

            try
            {
                connection.Open();
                String sqlQuerry = "select	SoHd,NgHD,TriGia from HoaDon where (NgHD)='"+dateTimePicker1.Value.ToShortDateString()+"'";
                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    //DateTime dt = (DateTime)reader.GetSqlDateTime(1);
                    row.Cells[1].Value = reader.GetDateTime(1).ToString();
                    row.Cells[2].Value = reader.GetSqlMoney(2);
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("khong the mo ket noi hoac ket noi da duoc mo tu truoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi xay ra loi");
            }
            finally
            {
                connection.Close();
            }




            try
            {
                connection.Open();
                String sqlQuerry = "select	Ten,sum(SoLuong) from CTHD, SanPham, HoaDon where cthd.MaSP = SanPham.MaSP and HoaDon.SoHd = CTHD.SoHD and NgHD>= '11/19/2019' and NgHD<= '" + dateTimePicker1.Value.ToShortDateString() + "' group by CTHD.MaSP,Ten order by sum(SoLuong)desc";

                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        return;
                    }
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetString(0);
                    //DateTime dt = (DateTime)reader.GetSqlDateTime(1);
                    row.Cells[1].Value = reader.GetInt32(1);
                    dataGridView2.Rows.Add(row);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("khong the mo ket noi hoac ket noi da duoc mo tu truoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi xay ra loi");
            }
            finally
            {
                connection.Close();
            }







        }
    }
}
