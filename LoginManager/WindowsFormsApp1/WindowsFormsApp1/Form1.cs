﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button2;
            textBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            int flag = 0;
            try
            {
                connection.Open();
                String sqlQuerry = "select username,MatKhau from pass";
                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.HasRows)
                {
                    if (reader.Read() == false) return;
                    String SampleUsername = reader.GetString(0);
                    String SamplePass = reader.GetString(1);
                    if(textBox1.Text==SampleUsername)
                    {
                        using (MD5 md5hash = MD5.Create())
                        {
                            if (VerifyMd5Hash(md5hash, textBox2.Text, SamplePass))
                            {
                                MessageBox.Show("Welcome " + SampleUsername);
                                AfterLogin AfterLogin = new AfterLogin();
                                AfterLogin.FormClosed += new FormClosedEventHandler(afterlogin_closed);
                                this.Hide();
                                AfterLogin.Show();
                                flag = 1;
                            }
                            else
                            {
                                flag = 0;
                            }
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
                connection.Close();
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string[] text = System.IO.File.ReadAllLines(@"D:\btOOP\WindowsFormsApp1\data.txt");
        //    int n = text.Length;
        //    string user = textBox1.Text;
        //    string pass = textBox2.Text;
        //    int flag = 0; 
        //    for (int i = 0; i < n; i += 2)
        //    {
        //        if (user == text[i])
        //        {
        //            using (MD5 md5hash = MD5.Create())
        //            {
        //                if (VerifyMd5Hash(md5hash, pass, text[i + 1]))
        //                {
        //                    MessageBox.Show("Welcome " + user);
        //                    AfterLogin AfterLogin = new AfterLogin();
        //                    AfterLogin.FormClosed += new FormClosedEventHandler(afterlogin_closed);
        //                    this.Hide();
        //                    AfterLogin.Show();
        //                    flag = 1;
        //                    break;
        //                }
        //                else
        //                {
        //                    flag = 0;
        //                    break;

        //                }
        //            }
        //        }
        //    }
        //    if(flag==0)
        //    {
        //         MessageBox.Show("Username or Password is incorrect");
        //    }
        //}


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        

       
     
        void afterlogin_closed(object sender,FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
