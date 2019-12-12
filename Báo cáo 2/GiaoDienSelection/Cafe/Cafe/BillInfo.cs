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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                String sqlQuerry = "select Gia from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Black cafe' and Size = '" + row.Cells[3].Value + "'";
                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                command.ExecuteNonQuery();
                
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
