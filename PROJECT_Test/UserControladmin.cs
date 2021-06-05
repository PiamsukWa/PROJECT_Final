using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJECT_Test
{
    public partial class UserControladmin : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bbcare_shop;");
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bbcare_shop;";

            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void ShowGridViewadmin()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM admin";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            GridViewadmin.DataSource = ds.Tables[0].DefaultView;
        }
        public UserControladmin()
        {
            InitializeComponent();
        }
        private void GridViewadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridViewadmin.CurrentRow.Selected = true;
            username.Text = GridViewadmin.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
            password.Text = GridViewadmin.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString();
            fname.Text = GridViewadmin.Rows[e.RowIndex].Cells["fname"].FormattedValue.ToString();
            lname.Text = GridViewadmin.Rows[e.RowIndex].Cells["lname"].FormattedValue.ToString();
            position.Text = GridViewadmin.Rows[e.RowIndex].Cells["position"].FormattedValue.ToString();
            textBoxemail.Text = GridViewadmin.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
        }
        private void UserControladmin_Load(object sender, EventArgs e)
        {
            ShowGridViewadmin();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int chek_u = 0, chek_m = 0; //u=username m=email
            string[] data_t = { " ", " ", " ", " ", " ", " ", " " }; //ที่สำหรับเก็บข้อมูลทิพย์ไว้ก่อน 5555
            int selectedRow = GridViewadmin.CurrentCell.RowIndex;  
            int useredit = Convert.ToInt32(GridViewadmin.Rows[selectedRow].Cells["ID"].Value);

            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlConnection conn2 = databaseConnection();
            conn2.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string email = textBoxemail.Text;
            string usename = username.Text;
            cmd.CommandText = $"SELECT * FROM admin WHERE  ID =\"{useredit}\""; //ตัวค้นหาว่ามีไอดีนั้นมั้ย
            MySqlDataReader adapter = cmd.ExecuteReader();
            if (adapter.HasRows)
            {
                while (adapter.Read()) //แนวตั้ง
                {
                    for (int i = 0; i <= 6; i++) //แนวนอน
                    {
                        data_t[i] = adapter.GetString(i);
                    }
                    MySqlConnection connuse = databaseConnection();
                    string sql = "UPDATE admin SET username ='" + username.Text + "' ,password ='" + password.Text + "' ,  fname = '" + fname.Text + "' , lname = '" + lname.Text + "', email = '" + textBoxemail.Text + "', position = '" + position.Text + "' WHERE ID = '" + useredit + "' ";
                    MySqlCommand cmduse = new MySqlCommand(sql, connuse);

                    connuse.Open();
                    int rows = cmduse.ExecuteNonQuery();
                    connuse.Close();
                }
                conn.Close();
                cmd = new MySqlCommand("SELECT * FROM admin", conn);
                conn.Open();
                MySqlDataReader chek = cmd.ExecuteReader();
                while (chek.Read())
                {
                    if (usename == chek.GetString(1))
                    {
                        chek_u += 1;
                    }
                    if (email == chek.GetString(5))
                    {
                        chek_m += 1;
                    }
                }
                if (chek_u >= 2)
                {
                    conn.Close();
                    label8.Text = "*ชื่อผู้ใช้มีบัญชีผู้ใช้งานแล้ว";
                    MySqlConnection connuse = databaseConnection();
                    string sql = "UPDATE admin SET username ='" + data_t[1] + "' ,password ='" + data_t[2] + "' ,  fname = '" + data_t[3] + "' , lname = '" + data_t[4] + "', email = '" + data_t[5] + "', position = '" + data_t[6] + "' WHERE ID = '" + data_t[0] + "' ";
                    MySqlCommand cmduse = new MySqlCommand(sql, connuse);

                    connuse.Open();
                    int rows = cmduse.ExecuteNonQuery();
                    connuse.Close();
                    ShowGridViewadmin();
                }
                else if (chek_m >= 2)
                {
                    conn2.Close();
                    label9.Text = "* E-mail มีบัญชีผู้ใช้งานแล้ว";
                    MySqlConnection connuse = databaseConnection();
                    string sql = "UPDATE admin SET username ='" + data_t[1] + "' ,password ='" + data_t[2] + "' ,  fname = '" + data_t[3] + "' , lname = '" + data_t[4] + "', email = '" + data_t[5] + "', position = '" + data_t[6] + "' WHERE ID = '" + data_t[0] + "' ";
                    MySqlCommand cmduse = new MySqlCommand(sql, connuse);

                    connuse.Open();
                    int rows = cmduse.ExecuteNonQuery();
                    connuse.Close();
                    ShowGridViewadmin();
                }
                else
                {
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "แจ้งเตือน");
                    ShowGridViewadmin();
                    label9.ResetText();
                    label8.ResetText();
                }
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM admin WHERE username like \"%{searchbox.Text}%\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            GridViewadmin.DataSource = ds.Tables[0].DefaultView;
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            int selectedRow = GridViewadmin.CurrentCell.RowIndex;
            int deleteuser = Convert.ToInt32(GridViewadmin.Rows[selectedRow].Cells["ID"].Value);

            MySqlConnection conn = databaseConnection();
            string sql = "DELETE FROM admin WHERE ID = '" + deleteuser + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ", "แจ้งเตือน");
                ShowGridViewadmin();
            }
        }

        private void searchbox_TextChanged_1(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM admin";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                conn.Close();

                GridViewadmin.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void newaccount_Click_1(object sender, EventArgs e)
        {
            username.ResetText();
            password.ResetText();
            fname.ResetText();
            lname.ResetText();
            position.ResetText();
            textBoxemail.ResetText();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "") 
            {
                label8.ResetText();
            }
        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxemail.Text == "")
            {
                label9.ResetText();
            }
        }

        private void saveaccount_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlConnection conn2 = databaseConnection();
            conn2.Open();

            MySqlCommand cmd;
            MySqlCommand cmd2;
            cmd = conn.CreateCommand();
            cmd2 = conn2.CreateCommand();
            string email = textBoxemail.Text;
            string usename = username.Text;
            cmd.CommandText = $"SELECT * FROM admin WHERE username =\"{usename}\"";
            cmd2.CommandText = $"SELECT * FROM admin WHERE  email =\"{email}\"";
            MySqlDataReader adapter = cmd.ExecuteReader();
            MySqlDataReader adapter2 = cmd2.ExecuteReader();
            label8.ResetText();
            label9.ResetText();
            if (adapter.HasRows)
            {
                conn.Close();
                label8.Text = "*ชื่อผู้ใช้มีบัญชีผู้ใช้งานแล้ว";
            }
            else if (adapter2.HasRows)
            {
                conn2.Close();
                label9.Text = "* E-mail มีบัญชีผู้ใช้งานแล้ว";
            }
            else
            {
                MySqlConnection condata = databaseConnection();
                string sql = "INSERT INTO admin (username, password, fname, lname, email, position) VALUES('" + username.Text + "' ,'" + password.Text + "' , '" + fname.Text + "','" + lname.Text + "','" + textBoxemail.Text + "','" + position.Text + "')";
                MySqlCommand dt = new MySqlCommand(sql, condata);
                condata.Open();
                dt.ExecuteNonQuery();
                condata.Close();
                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน");
                label8.ResetText();
                label9.ResetText();
                ShowGridViewadmin();
            }
        }
    }
}
