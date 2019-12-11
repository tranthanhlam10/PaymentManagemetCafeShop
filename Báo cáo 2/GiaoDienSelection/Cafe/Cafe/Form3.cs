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
            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();
        }

        void booking4_closed(object sender,FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        // thêm số bàn

        private void button1_Click(object sender, EventArgs e)
        {
            // số bàn đã chọn
            txtTable.Text =  "1";

            // màu bàn đã chọn 
            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();

            // số hóa đơn bất kì khi chọn bàn


            // thêm mã hóa đơn khi chọn bàn vào màn hình





        }



        private void button2_Click(object sender, EventArgs e)
        {
            txtTable.Text = "2";


            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();



            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button3_Click(object sender, EventArgs e)
        {
            txtTable.Text = "3";


            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();



            // thêm mã hóa đơn khi chọn bàn vào màn hình


        }



        private void button4_Click(object sender, EventArgs e)
        {
            txtTable.Text = "4";


            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();



            // thêm mã hóa đơn khi chọn bàn vào màn hình


        }



        private void button5_Click(object sender, EventArgs e)
        {
            txtTable.Text = "5";


            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();



            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button6_Click(object sender, EventArgs e)
        {
            txtTable.Text = "6";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();


            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button7_Click(object sender, EventArgs e)
        {
            txtTable.Text = "7";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();


            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button8_Click(object sender, EventArgs e)
        {
            txtTable.Text = "8";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();

            // thêm mã hóa đơn khi chọn bàn vào màn hình



        }



        private void button9_Click(object sender, EventArgs e)
        {
            txtTable.Text = "9";


            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();
            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button10_Click(object sender, EventArgs e)
        {
            txtTable.Text = "10";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();


            // thêm mã hóa đơn khi chọn bàn vào màn hình


        }



        private void button11_Click(object sender, EventArgs e)
        {
            txtTable.Text = "11";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();
            // thêm mã hóa đơn khi chọn bàn vào màn hình


        }



        private void button12_Click(object sender, EventArgs e)
        {
            txtTable.Text = "12";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();


            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button13_Click(object sender, EventArgs e)
        {
            txtTable.Text = "13";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();

            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button14_Click(object sender, EventArgs e)
        {

            txtTable.Text = "14";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();

            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }




        private void button15_Click(object sender, EventArgs e)
        {
            txtTable.Text =  "15";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();
            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }



        private void button16_Click(object sender, EventArgs e)
        {
            txtTable.Text = "16";

            Class1.Billnumber = Int32.Parse(txtTable.Text);

            booking4 f = new booking4();
            f.FormClosed += new FormClosedEventHandler(booking4_closed);
            this.Hide();
            f.Show();

            // thêm mã hóa đơn khi chọn bàn vào màn hình

        }


        // trở về khi nhấn nút back
        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát phiên làm việc", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();  //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
