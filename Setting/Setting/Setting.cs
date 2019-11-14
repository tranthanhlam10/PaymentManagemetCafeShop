using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setting
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginScreen LoginScreen = new LoginScreen();
            LoginScreen.FormClosed += new FormClosedEventHandler(LoginScreen_closed);
            this.Hide();
            LoginScreen.Show();
        }

        void LoginScreen_closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void CheckBill_Click(object sender, EventArgs e)
        {
            BillShow BillShow = new BillShow();
            BillShow.Show();
            BillShow.FormClosed += new FormClosedEventHandler(BillShow_closed);
            this.Hide();
        }
        void BillShow_closed(object sender,FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
