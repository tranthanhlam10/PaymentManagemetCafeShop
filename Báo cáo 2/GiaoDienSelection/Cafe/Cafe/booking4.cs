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
    public partial class booking4 : Form
    {
        public booking4()
        {
            InitializeComponent();
            textBox1.Text = Class1.Billnumber.ToString();

            textBox3.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox4.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox6.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox8.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox10.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox12.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox14.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox16.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox18.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox20.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox22.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox24.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox26.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox28.KeyPress += new KeyPressEventHandler(number_textbox1_press);
            textBox30.KeyPress += new KeyPressEventHandler(number_textbox1_press);
        }

        private void number_textbox1_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["Cafe"])
            {

                if (tabControl2.SelectedTab == tabControl2.TabPages["CafeDen"])
                {
                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[0].Value = "Cafe đen";
                    row.Cells[1].Value = textBox22.Text;
                    String asd="S";
                    if (radioButton1.Checked == true)
                    {
                        row.Cells[2].Value = "S";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        row.Cells[2].Value = "M";
                        asd = "M";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        row.Cells[2].Value = "L";
                    }
                    String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connString);
                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Black cafe' and Size = '"+asd+"'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[3].Value = reader.GetSqlMoney(0);
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
                        dgv.Rows.Add(row);
                        connection.Close();
                    }

                }
                else if (tabControl2.SelectedTab == tabControl2.TabPages["CafeSua"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl2.SelectedTab == tabControl2.TabPages["CafeDenPhaMay"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl2.SelectedTab == tabControl2.TabPages["Cappuchino"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl2.SelectedTab == tabControl2.TabPages["CafeDacBiet"])
                {

                    MessageBox.Show("cafe den");
                }
            
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["Smoothie"])
            {

                if (tabControl3.SelectedTab == tabControl3.TabPages["Rasberry"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl3.SelectedTab == tabControl3.TabPages["ChocolateMint"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl3.SelectedTab == tabControl3.TabPages["Oreoiceblended"])
                {

                    MessageBox.Show("cafe den");
                }
             
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["Tea"])
            {

                if (tabControl4.SelectedTab == tabControl4.TabPages["TraDao"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl4.SelectedTab == tabControl4.TabPages["TraOolong"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl4.SelectedTab == tabControl4.TabPages["TraSua"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl4.SelectedTab == tabControl4.TabPages["TraDa"])
                {

                    MessageBox.Show("cafe den");
                }
             
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["Food"])
            {

                if (tabControl5.SelectedTab == tabControl5.TabPages["BanhMiQue"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl5.SelectedTab == tabControl5.TabPages["PuddingDao"])
                {

                    MessageBox.Show("cafe den");
                }
                else if (tabControl5.SelectedTab == tabControl5.TabPages["BanhMiChaBongPhoMai"])
                {

                    MessageBox.Show("cafe den");
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
