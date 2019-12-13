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
using System.Security.Cryptography;

namespace Cafe
{
    public partial class boking2 : Form
    {
        public boking2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            textBox1.KeyPress += new KeyPressEventHandler(number_textbox1_press);
        }

        private void number_textbox1_press(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                int flag = 0;
                try
                {
                    connection.Open();
                    String sqlQuerry = "select MatKhau from Nhanvien where MaNV=" + textBox1.Text;
                    SqlCommand command = new SqlCommand(sqlQuerry, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        if (reader.Read() == false)
                        {
                            return;
                        }
                        String SamplePass = reader.GetString(0);

                        using (MD5 md5hash = MD5.Create())
                        {
                            if (VerifyMd5Hash(md5hash, textBox2.Text, SamplePass))
                            {
                                Table setting1 = new Table();
                                setting1.FormClosed += new FormClosedEventHandler(setting1_closed);
                                this.Hide();
                                setting1.Show();
                                flag = 1;
                            }
                            else
                            {
                                flag = 0;
                            }
                        }
                        if (flag == 0)
                            MessageBox.Show("Username or password is wrong");
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
                    textBox2.Clear();
                    textBox1.Clear();
                    connection.Close();
                }
            }
        }

        void setting1_closed(object sender,FormClosedEventArgs e)
        {
            this.Show();
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
