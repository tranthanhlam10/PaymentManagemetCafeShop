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
    public partial class setting_option : Form
    {
        public setting_option()
        {
            InitializeComponent();
        }

        private void setting_option_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainLogin main = new MainLogin();
            main.FormClosed += new FormClosedEventHandler(main_closed);

            this.Hide();
            main.Show();
        }

        private void main_closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting1 setting1 = new Setting1();

            setting1.FormClosed += new FormClosedEventHandler(setting1_closed);
            this.Hide();
            setting1.Show();
        }

        private void setting1_closed(object sender,FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
