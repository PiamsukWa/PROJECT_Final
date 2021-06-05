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
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bbcare_shop;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxusername_Enter(object sender, EventArgs e)
        {
            if (textBoxusername.Text == "บัญชีผู้ใช้")
            {
                textBoxusername.Text = "";
                textBoxusername.ForeColor = Color.Black;
            }

        }

        private void textBoxusername_Leave(object sender, EventArgs e)
        {
            if (textBoxusername.Text == "")
            {
                textBoxusername.Text = "บัญชีผู้ใช้";
                textBoxusername.ForeColor = Color.Silver;
            }

        }

        private void textBoxpass_Enter(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "รหัสผ่าน")
            {
                textBoxpass.Text = "";
                textBoxpass.PasswordChar = '*';
                textBoxpass.ForeColor = Color.Black;
            }

        }

        private void textBoxpass_Leave(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "")
            {
                textBoxpass.Text = "รหัสผ่าน";
                textBoxpass.PasswordChar = '\0';
                textBoxpass.ForeColor = Color.Silver;
            }
        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked)
            {
                textBoxpass.PasswordChar = '\0';
            }
            else
            {
                textBoxpass.PasswordChar = '*';
            }
        }

        private void buttonnewacount_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void buttonclose1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            String user = textBoxusername.Text;
            string password = textBoxpass.Text;

            cmd.CommandText = $"SELECT * FROM admin WHERE username=\"{user}\" AND password=\"{password}\"";
            if (cmd.ExecuteReader().HasRows)
            {
                Form4 form = new Form4();
                form.txt = textBoxusername.Text;
                form.Show();
                this.Close();

                textBoxusername.ResetText();
                textBoxpass.ResetText();
                labelcheckpass.ResetText();

            }
            else
            {
                labelcheckpass.Text = " บัญชีผู้ใช้หรือรหัสผ่านไม่ถูกต้อง";
            }
            conn.Close();
            
        }
        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "" && textBoxusername.Text != "")
            {
               buttonlogin.Enabled = false;
               labelcheckpass.ResetText();
            }
            else
            {
                buttonlogin.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttonlogin.Enabled = false;
        }

        private void forgetpass_Click(object sender, EventArgs e)
        {
            sendindcode sc = new sendindcode();
            this.Hide();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void textBoxpass_KeyDown(object sender, KeyEventArgs e) /*\\ กดปุ่ม enter*/
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    buttonlogin_Click(buttonlogin, e);
                }
            }
        }
    }
}
