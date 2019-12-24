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
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Cafe
{
    public partial class BillInfo : Form
    {
        protected DataGridView dgv2;
        public BillInfo(DataGridView dgv)
        {
            InitializeComponent();

            label6.Visible = false;
            dgv2 = dgv;
            Point x = new Point(9, 50) ;
            dgv2.Location = x;
            this.Controls.Add(dgv2);
            textBox32.Text = Class1.trigia.ToString();
            dgv2.RowsRemoved += new DataGridViewRowsRemovedEventHandler(DataGridView1_RowsRemoved);
        }

        private void DataGridView1_RowsRemoved(object sender, System.Windows.Forms.DataGridViewRowsRemovedEventArgs e)
        {
            Class1.trigia = 0;
            for (int i = 0; i < dgv2.Rows.Count - 1; i++)
            {
                Class1.trigia += Convert.ToInt32(dgv2.Rows[i].Cells[4].Value) / 1000 * Convert.ToInt32(dgv2.Rows[i].Cells[2].Value);
            }
            textBox32.Text = Class1.trigia.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dau < duoi)
            {
                label6.Visible = true; 
            }
            else
            {
                String sohd="" ;
                String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                try
                {
                    connection.Open();
                    String sqlQuerry = "insert into HoaDon (NgHD, ThoigianHD, TriGia, TienKhachDua) values(GETDATE(), GETDATE(), " + textBox32.Text + ", " + textBox1.Text + ")";
                    SqlCommand command = new SqlCommand(sqlQuerry, connection);
                    command.ExecuteNonQuery();
                    
                    for (int i = 0; i < dgv2.Rows.Count - 1; i++)
                    {
                        sqlQuerry = "insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1 SoHd  from HoaDon order by SoHd desc)," + dgv2.Rows[i].Cells[5].Value.ToString() + ",'" + dgv2.Rows[i].Cells[3].Value.ToString() + "'," + dgv2.Rows[0].Cells[2].Value.ToString() + ")";
                        command.Dispose();
                        command = new SqlCommand(sqlQuerry, connection);
                        command.ExecuteNonQuery();
                    }
                    command.Dispose();
                    sqlQuerry = "select top 1 sohd from hoadon order by sohd desc";
                    command = new SqlCommand(sqlQuerry, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        if (reader.Read() == false) break;
                        sohd = reader.GetInt32(0).ToString();

                    }

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Không thể mở kết nối hoặc kết nối được mở từ trước");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối xảy ra lỗi");
                }
                finally
                {

                    connection.Close();
                }

                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("C:/Users/HOME/Desktop/Bill/" + sohd + ".pdf", FileMode.Create));
                document.Open();


                PdfContentByte cb = writer.DirectContent;
                cb.BeginText();
         
                BaseFont f_cn = BaseFont.CreateFont("C:\\windows\\fonts\\Arial.ttf",BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetFontAndSize(f_cn, 25);
                cb.SetTextMatrix(200, 800);
                cb.ShowText("The Coffee School");
                cb.SetFontAndSize(f_cn, 12);
                cb.SetTextMatrix(30, 700);
                cb.ShowText("So hoa don: " + sohd);
                cb.SetTextMatrix(400, 700);
                cb.ShowText(DateTime.Now.ToString());
                cb.SetTextMatrix(30, 650);
                cb.ShowText("So ban: " + Class1.ban);
                cb.SetTextMatrix(400, 650);
                if (radioButton4.Checked)
                    cb.ShowText("Take Away");
                else
                    cb.ShowText("At shop");


                cb.SetTextMatrix(30, 625);
                cb.ShowText("__________________________________________________________________________________");

                cb.SetTextMatrix(50, 600);
                cb.ShowText("Ten");
                cb.SetTextMatrix(200, 600);
                cb.ShowText("SL");
                cb.SetTextMatrix(250, 600);
                cb.ShowText("Size");
                cb.SetTextMatrix(300, 600);
                cb.ShowText("Don gia");
                cb.SetTextMatrix(400, 600);
                cb.ShowText("Thanh tien");
                int y = 570;
                for(int i=0;i<dgv2.Rows.Count-1;i++)
                {
                    cb.SetTextMatrix(50, y);
                    cb.ShowText(dgv2.Rows[i].Cells[1].Value.ToString());
                    cb.SetTextMatrix(200, y  );
                    cb.ShowText(dgv2.Rows[i].Cells[2].Value.ToString());
                    cb.SetTextMatrix(250, y  );
                    cb.ShowText(dgv2.Rows[i].Cells[3].Value.ToString());
                    cb.SetTextMatrix(300, y );
                    cb.ShowText(dgv2.Rows[i].Cells[4].Value.ToString());
                    cb.SetTextMatrix(400, y );
                    cb.ShowText((Convert.ToInt32(dgv2.Rows[i].Cells[2].Value.ToString())*Convert.ToInt32(dgv2.Rows[i].Cells[4].Value.ToString())).ToString());
                    y -= 30;
                }
                y -= 20;
                cb.SetTextMatrix(30, y+25);
                cb.ShowText("__________________________________________________________________________________");


                cb.SetTextMatrix(30, y);
                cb.ShowText("Tong Tien");
                cb.SetTextMatrix(400, y);
                cb.ShowText(textBox32.Text+"000");
                y -= 30;
                cb.SetTextMatrix(30, y);
                cb.ShowText("Khach dua");
                cb.SetTextMatrix(400, y);
                cb.ShowText(textBox1.Text + "000");
                y -= 30;
                cb.SetTextMatrix(30, y);
                cb.ShowText("Tien thoi");
                cb.SetTextMatrix(400, y);
                cb.ShowText(textBox2.Text + "000");

                cb.EndText();


                document.Close();
                writer.Close();
                Class1.dem = 1;
                this.Close();
            }
        }
        static int dau=0;
        static int duoi=0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                 dau = Convert.ToInt32(textBox1.Text);
                 duoi = Convert.ToInt32(textBox32.Text);
                textBox2.Text = (dau - duoi).ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
