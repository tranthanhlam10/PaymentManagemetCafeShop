using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text=System.IO.File.ReadAllLines(@"D:\btOOP\WindowsFormsApp1\data.txt");
            int n = text.Length;
            int flag = 0;
            for(int i=0;i<n;i+=2)
            {
                if(text[i]==textBox1.Text)
                {
                    MessageBox.Show("That username is taken. Try another.");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\btOOP\WindowsFormsApp1\data.txt", true))
                    {
                        file.WriteLine(textBox1.Text);
                        using (MD5 md5hash = MD5.Create())
                        {
                            string hash = GetMd5Hash(md5hash, textBox2.Text);
                            file.WriteLine(hash);
                        }


                    }
                    MessageBox.Show("Successfull sign in");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password and Re-Password are not the same.");
                }
            }
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
