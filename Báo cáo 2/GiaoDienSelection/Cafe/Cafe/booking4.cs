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

            dgv.CellClick += new DataGridViewCellEventHandler(delete_click);

            dgv.RowsAdded += new DataGridViewRowsAddedEventHandler(DataGridView1_RowsAdded);
            dgv.RowsRemoved += new DataGridViewRowsRemovedEventHandler(DataGridView1_RowsRemoved);
        }
        static int asd = 0;
        private void DataGridView1_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            Class1.trigia = 0;
            for(int i=0;i<dgv.Rows.Count-1;i++)
            {
                Class1.trigia += Convert.ToInt32(dgv.Rows[i].Cells[4].Value)/1000* Convert.ToInt32(dgv.Rows[i].Cells[2].Value);
            }
            textBox32.Text = Class1.trigia.ToString();
        }

        private void DataGridView1_RowsRemoved(object sender, System.Windows.Forms.DataGridViewRowsRemovedEventArgs e)
        {
            Class1.trigia = 0;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                Class1.trigia += Convert.ToInt32(dgv.Rows[i].Cells[4].Value) / 1000 * Convert.ToInt32(dgv.Rows[i].Cells[2].Value);
            }
            textBox32.Text = Class1.trigia.ToString();
        }


        void delete_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgv.Columns["Xoa"].Index)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);

            }
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
            //String connString = @"Data Source=HOME-PC;Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            String connString = @"Data Source=192.168.43.158, 9999 ; Network Library=DBMSSOCN; Initial Catalog=PaymentCoffeeShop;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            if (tabControl1.SelectedTab == tabControl1.TabPages["Cafe"])
            {
                if (tabControl2.SelectedTab == tabControl2.TabPages["CafeDen"])
                {
                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Cafe đen";
                    row.Cells[2].Value = textBox22.Text;
             
                    if (radioButton1.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        row.Cells[3].Value = "M";
         
                    }
                    else if (radioButton3.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }
                    
                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Black cafe' and Size = '"+row.Cells[3].Value+"'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Cafe sữa";
                    row.Cells[2].Value = textBox24.Text;

                    if (radioButton6.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton4.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton5.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Milk cafe' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl2.SelectedTab == tabControl2.TabPages["CafeDenPhaMay"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Americano";
                    row.Cells[2].Value = textBox26.Text;

                    if (radioButton9.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton7.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton8.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Americano' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl2.SelectedTab == tabControl2.TabPages["Cappuchino"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Cappuchino";
                    row.Cells[2].Value = textBox28.Text;

                    if (radioButton12.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton10.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton11.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Cappuchino' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl2.SelectedTab == tabControl2.TabPages["CafeDacBiet"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Espresso";
                    row.Cells[2].Value = textBox30.Text;

                    if (radioButton15.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton13.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton14.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Espresso' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
            
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["Smoothie"])
            {

                if (tabControl3.SelectedTab == tabControl3.TabPages["Rasberry"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Rasberry";
                    row.Cells[2].Value = textBox16.Text;

                    if (radioButton16.Checked == true)
                    {
                        row.Cells[3].Value = "M";
                    }
                    else if (radioButton17.Checked == true)
                    {
                        row.Cells[3].Value = "L";

                    }
                    

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Rasberry' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl3.SelectedTab == tabControl3.TabPages["ChocolateMint"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Chocolate Mint";
                    row.Cells[2].Value = textBox18.Text;

                    if (radioButton19.Checked == true)
                    {
                        row.Cells[3].Value = "M";
                    }
                    else if (radioButton20.Checked == true)
                    {
                        row.Cells[3].Value = "L";

                    }
                    

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'ChocolateMint' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl3.SelectedTab == tabControl3.TabPages["Oreoiceblended"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Oreo";
                    row.Cells[2].Value = textBox20.Text;

                    if (radioButton22.Checked == true)
                    {
                        row.Cells[3].Value = "M";
                    }
                    else if (radioButton23.Checked == true)
                    {
                        row.Cells[3].Value = "L";

                    }
                    

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Oreo' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
             
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["Tea"])
            {

                if (tabControl4.SelectedTab == tabControl4.TabPages["TraDao"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Trà đào";
                    row.Cells[2].Value = textBox8.Text;

                    if (radioButton27.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton25.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton26.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Peach tea' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl4.SelectedTab == tabControl4.TabPages["TraOolong"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Trà Oolong";
                    row.Cells[2].Value = textBox10.Text;

                    if (radioButton30.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton28.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton29.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Oolong tea' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl4.SelectedTab == tabControl4.TabPages["TraSua"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Trà sữa";
                    row.Cells[2].Value = textBox12.Text;

                    if (radioButton33.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton31.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton32.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Milk tea' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl4.SelectedTab == tabControl4.TabPages["TraDa"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Trà vải";
                    row.Cells[2].Value = textBox14.Text;

                    if (radioButton36.Checked == true)
                    {
                        row.Cells[3].Value = "S";
                    }
                    else if (radioButton34.Checked == true)
                    {
                        row.Cells[3].Value = "M";

                    }
                    else if (radioButton35.Checked == true)
                    {
                        row.Cells[3].Value = "L";
                    }

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Lynch tea' and Size = '" + row.Cells[3].Value + "'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
             
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["Food"])
            {

                if (tabControl5.SelectedTab == tabControl5.TabPages["BanhMiQue"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Bánh mì que";
                    row.Cells[2].Value = textBox3.Text;

                    

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Banh mi que' and Size = 'M'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl5.SelectedTab == tabControl5.TabPages["PuddingDao"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Pudding đào";
                    row.Cells[2].Value = textBox4.Text;

                   

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Peach pudding' and Size = 'M'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                else if (tabControl5.SelectedTab == tabControl5.TabPages["BanhMiChaBongPhoMai"])
                {

                    DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                    row.Cells[1].Value = "Bánh mì chà bông phô mai";
                    row.Cells[2].Value = textBox6.Text;

                  

                    try
                    {
                        connection.Open();
                        String sqlQuerry = "select Gia,SanPham.MaSP from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Banh mi cha bong pho mai' and Size = 'M'";
                        SqlCommand command = new SqlCommand(sqlQuerry, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.HasRows)
                        {
                            if (reader.Read() == false)
                            {
                                return;
                            }
                            row.Cells[4].Value = reader.GetInt32(0);
                            row.Cells[5].Value = reader.GetInt32(1);
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
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillInfo billinfo = new BillInfo(dgv);
            billinfo.FormClosed += new FormClosedEventHandler(billinfo_closed);
            this.Hide();
            billinfo.ShowDialog();
            
            
        }

        private void billinfo_closed(object sender,FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
