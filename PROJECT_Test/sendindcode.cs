using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace PROJECT_Test
{
    public partial class sendindcode : Form
    {
        string OTPCode;
        public static string to;
        public sendindcode()
        {
            InitializeComponent();
        }

        private void buttonclose1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if(txtemail.Text == "")
            {
                labelcheck1.Text = "* กรุณากรอกที่อยู่ E-mail";
            }
            else
            {
                labelcheck1.Text = "";
            }
        }

        private void txtotp_TextChanged(object sender, EventArgs e)
        {
            if (txtotp.Text == "")
            {
                labelcheck2.Text = "* กรุณากรอกรหัสผ่านยืนยัน";
            }
            else
            {
                labelcheck2.Text = "";
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            OTPCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (txtemail.Text).ToString();
            from = "BeeBcare.Shop@gmail.com";
            pass = "Bam11032544";
            messageBody = "Your Reset OTP code is " + OTPCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "รหัสยืนยันความปลอดภัย";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntverify_Click(object sender, EventArgs e)
        {
            if (OTPCode == (txtotp.Text).ToString())
            {
                to = txtemail.Text;
                newpassword np = new newpassword();
                this.Hide();
                np.Show();
            }
            else
            {
                MessageBox.Show("รหัสไม่ถูกต้อง");
            }
        }
    }
}
