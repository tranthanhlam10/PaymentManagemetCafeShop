using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // thư viện hỗ trợ kết nối sql sever

namespace Cafe
{
    public partial class Booking : Form
    {
        SqlConnection connection;

        SqlCommand command;


        string str = "Data Source=DESKTOP-9OUV00A;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";


        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();


        void loaddata() // hàm để load dữ liệu lên dgv
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from BILL "; // câu truy vấn lấy dữ liệu từ bill lên
            adapter.SelectCommand = command;
            table.Clear();

            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);

            connection.Open();
            loaddata();
        }

        public Booking()
        {
            InitializeComponent();
            txtTable2.Text = Class1.Billnumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BillInfo f = new BillInfo();
            //this.Hide();
            //f.ShowDialog();
            //f.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;

            // cb lựa chọn món ăn
            cbCafe.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbSmoothie.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbFood.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbTea.Text = dgv.Rows[i].Cells[0].Value.ToString();

            // tb số lượng
            tbSLCafe.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbSLSmoothie.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbSLFood.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbSLTea.Text = dgv.Rows[i].Cells[2].Value.ToString();

            // cb size
            cbSizeCafe.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cbSizeSmoothie.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cbSizeCafe.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }


        // khi click vào button add
        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            // câu lệnh thêm giá trj vào SQL
            command.CommandText = " insert into BILL values('" + cbCafe.Text + "', '" + cbSmoothie.Text + "', '" + cbFood.Text + "' , '" + cbTea.Text + "', '" + tbSLCafe.Text + "', '" + tbSLSmoothie.Text + "' , '"+ tbSLFood.Text+"' , '"+tbSLTea.Text+"', '"+cbSizeCafe.Text+"', '"+cbSizeSmoothie+"', '"+cbSizeTea+"' )";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
