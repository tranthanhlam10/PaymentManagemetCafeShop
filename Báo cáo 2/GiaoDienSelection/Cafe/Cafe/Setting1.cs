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
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        return;
                    }
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
        }
    }
}
