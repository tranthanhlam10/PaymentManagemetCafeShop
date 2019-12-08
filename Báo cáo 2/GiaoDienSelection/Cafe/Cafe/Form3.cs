using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

       

        private void button18_Click(object sender, EventArgs e)
        {
            Booking f = new Booking();

            this.Hide();
            f.ShowDialog();
            this.Close();

           
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        // thêm số bàn

        private void button1_Click(object sender, EventArgs e)
        {
            // số bàn đã chọn
            txtTable.Text = txtTable.Text + 1;

            // màu bàn đã chọn 
            button1.BackColor = Color.Green;

            // số hóa đơn bất kì khi chọn bàn
            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;

         

            

        }



        private void button2_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 2;


            button2.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 3;


            button3.BackColor = Color.Green;


            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;

        }



        private void button4_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 4;


            button4.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;

        }



        private void button5_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 5;


            button5.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 6;


            button6.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button7_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 7;


            button7.BackColor = Color.Green;


            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button8_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 8;


            button8.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;


        }



        private void button9_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 9;



            button9.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button10_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 10;


            button10.BackColor = Color.Green;


            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;

        }



        private void button11_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 11;


            button11.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;

        }



        private void button12_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 12;


            button12.BackColor = Color.Green;


            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button13_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 13;


            button13.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button14_Click(object sender, EventArgs e)
        {

            txtTable.Text = txtTable.Text + 14;


            button14.BackColor = Color.Green;


            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }




        private void button15_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 15;


            button15.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }



        private void button16_Click(object sender, EventArgs e)
        {
            txtTable.Text = txtTable.Text + 16;


            button16.BackColor = Color.Green;

            Random r = new Random();
            int n = r.Next(1000, 9999);

            // thêm mã hóa đơn khi chọn bàn vào màn hình
            txtBill.Text = txtBill.Text + n;
        }


        // trở về khi nhấn nút back
        private void button17_Click(object sender, EventArgs e)
        {
            paymentcafe f = new paymentcafe();
            this.Hide();
            f.ShowDialog();
            this.Close();

            
        }
    }
}
