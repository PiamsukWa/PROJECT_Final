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
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bbcare_shop;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void nameaccount_Enter(object sender, EventArgs e)
        {
            if (nameaccount.Text == "ชื่อผู้ใช้")
            {
                nameaccount.Text = "";
                nameaccount.ForeColor = Color.Black;
            }
        }

        private void nameaccount_Leave(object sender, EventArgs e)
        {
            if (nameaccount.Text == "")
            {
                nameaccount.Text = "ชื่อผู้ใช้";
                nameaccount.ForeColor = Color.Silver;
            }
        }

        private void Boxpassword1_Enter(object sender, EventArgs e)
        {
            if (Boxpassword1.Text == "รหัสผ่าน")
            {
                Boxpassword1.Text = "";
                Boxpassword1.ForeColor = Color.Black;
            }
        }

        private void Boxpassword1_Leave(object sender, EventArgs e)
        {
            if (Boxpassword1.Text == "")
            {
                Boxpassword1.Text = "รหัสผ่าน";
                Boxpassword1.ForeColor = Color.Silver;
            }
        }

        private void Boxpassword2_Enter(object sender, EventArgs e)
        {
            if (Boxpassword2.Text == "ยืนยันรหัสผ่าน")
            {
                Boxpassword2.Text = "";
                Boxpassword2.ForeColor = Color.Black;
            }
        }

        private void Boxpassword2_Leave(object sender, EventArgs e)
        {
            if (Boxpassword2.Text == "")
            {
                Boxpassword2.Text = "ยืนยันรหัสผ่าน";
                Boxpassword2.ForeColor = Color.Silver;
            }
        }
        private void Boxemail_leave(object sender, EventArgs e)
        {
            if (Boxemail.Text == "")
            {
                Boxemail.Text = "ที่อยู่ E-mail";
                Boxemail.ForeColor = Color.Silver;
            }
        }

        private void Boxemail_Enter(object sender, EventArgs e)
        {
            if (Boxemail.Text == "ที่อยู่ E-mail")
            {
                Boxemail.Text = "";
                Boxemail.ForeColor = Color.Black;
            }

        }

        private void createnew_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlConnection conn2 = databaseConnection();
            conn2.Open();

            MySqlCommand cmd;
            MySqlCommand cmd2;
            cmd = conn.CreateCommand();
            cmd2 = conn2.CreateCommand();
            string email = Boxemail.Text;
            string username = nameaccount.Text;
            cmd.CommandText = $"SELECT * FROM admin WHERE email =\"{email}\"" ;
            cmd2.CommandText = $"SELECT * FROM admin WHERE  username =\"{username}\"";
            MySqlDataReader adapter = cmd.ExecuteReader();
            MySqlDataReader adapter2 = cmd2.ExecuteReader();

            if (adapter.HasRows)
            {
                conn.Close();
                labelcheckmail.Text = "* E-mail มีบัญชีผู้ใช้งานแล้ว";
            }
            else if(adapter2.HasRows)
            {
                conn2.Close();
                label5.Text = "*ชื่อผู้ใช้มีบัญชีผู้ใช้งานแล้ว";
            }
            else
            {
                MySqlConnection condata = databaseConnection();
                string sql = "INSERT INTO admin (username, password,email) VALUES('" + nameaccount.Text + "' , '" + Boxpassword1.Text + "','" + Boxemail.Text + "')";
                MySqlCommand dt = new MySqlCommand(sql, condata);
                condata.Open();
                dt.ExecuteNonQuery();
                condata.Close();
                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน");
                labelcheckmail.ResetText();
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void buttonhome_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Boxpassword2_TextChanged(object sender, EventArgs e)
        {
            if (Boxpassword1.Text != "" && Boxpassword2.Text == Boxpassword1.Text && Boxpassword2.Text != ""&& Boxemail.Text != "" && nameaccount.Text != "")
            {
                createnew.Enabled = true;
                errorProvider1.SetError(Boxpassword2, "");
                label3.ResetText();
            }
            else
            {
                createnew.Enabled = false;
                errorProvider1.SetError(Boxpassword2, "รหัสผ่านไม่ตรง");
                label3.Text = "โปรดตรวจสอบรหัสผ่านอีกครั้ง";
            }
        }
        private void Boxpassword1_TextChangrd(object sender, EventArgs e)
        {
            if (Boxpassword1.Text == "")
            {
                errorProvider1.SetError(Boxpassword2, "");
                label3.ResetText();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            createnew.Enabled = false;
        }

        private void createemail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/signup/v2/webcreateaccount?flowName=GlifWebSignIn&flowEntry=SignUp");
        }
        private void Boxemail_TextChanged(object sender, EventArgs e)
        {
            if (Boxemail.Text == "")
            {
                labelcheckmail.ResetText();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameaccount_TextChanged(object sender, EventArgs e)
        {
            if (nameaccount.Text == "")
            {
                label5.ResetText();
            }
        }
    }
}
