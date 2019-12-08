using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Globalization;

namespace Cafe
{
    public partial class paymentcafe : Form
    {
        public paymentcafe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Table f = new Table();

            this.Hide();

            MessageBox.Show("Bạn đã vào phần booking của ứng dụng");

            f.ShowDialog();

            this.Close();

           // MessageBox.Show("Bạn đã vào phần booking của ứng dụng");
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainLogin g = new MainLogin();


            this.Hide();

            MessageBox.Show("Bạn đã vào phần setting của ứng dụng");

            g.ShowDialog();

            this.Close();

        }
    }
}
