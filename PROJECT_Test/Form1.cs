using PROJECT_Test.Properties;
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
    public partial class Form1 : Form
    {
        List<stock> allstock = new List<stock>();
        List<stockmain> movedata = new List<stockmain>();
        string idFormcart;
        string nameFormcart;
        string sumFormcart;
        string amountFormcart;
        string amountfromDB;
        string amountnew;
        private List<ForPrint> allbook = new List<ForPrint>(); /*listใบเสร็จ*/

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bbcare_shop;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        private void Showdataproduct()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stockproduct";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }
        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if(pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if(pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else if(pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox5.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Showdataproduct();
            timer1.Start();
        }

        private void facebookBox_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bamz.piamsukwathiroiram");
        }

        private void lineBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://line.me/ti/p/FZjf4fewnT");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/beebcareshop/");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                buttonkind.Image = Resources.uparrow;
                panelkind.Height += 20;
                if (panelkind.Size == panelkind.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                buttonkind.Image = Resources.arrow;
                panelkind.Height -= 20;
                if (panelkind.Size == panelkind.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void buttonkind_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "DELETE FROM cart";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            Application.Exit();
        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void buttonskin_Click(object sender, EventArgs e)
        {
            searchbox.ResetText();
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE kind =\"{buttonskin.Text}\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            searchbox.ResetText();
            Showdataproduct();
        }

        private void buttonbody_Click(object sender, EventArgs e)
        {
            searchbox.ResetText();
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE kind =\"{buttonbody.Text}\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }

        private void buttonvitamin_Click(object sender, EventArgs e)
        {
            searchbox.ResetText();
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE kind =\"{buttonvitamin.Text}\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();


            conn.Open();

            string sql = "SELECT * FROM cart";

            MySqlCommand cmd = new MySqlCommand(sql,conn);
            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                idFormcart = read.GetString("ID").ToString();
                amountFormcart = read.GetString("amount").ToString();
                stock item = new stock()
                {
                    IDold = idFormcart,
                    amountold = amountFormcart
                };
                allstock.Add(item);
            }
            conn.Close();

            foreach(var i in allstock)
            {
                conn.Open();
                string sqlcom = "SELECT * FROM stockproduct WHERE ID = '" + i.IDold + "'";
                MySqlCommand command = new MySqlCommand(sqlcom, conn);
                MySqlDataReader readdata = command.ExecuteReader();
                while (readdata.Read())
                {
                    amountfromDB = readdata.GetString("amount").ToString();
                }
                conn.Close();

                amountnew = (int.Parse(amountfromDB) - int.Parse(amountFormcart)).ToString();
                
                conn.Open();
                string sqlcom1 = "UPDATE stockproduct SET amount = '"+ amountnew +"' WHERE ID = '"+ i.IDold +"'";
                MySqlCommand command1 = new MySqlCommand(sqlcom1, conn);
                command1.ExecuteReader();
                conn.Close();   
            }
            allstock.Clear();

            //ย้าย
            conn.Open();
            string sql1 = "SELECT * FROM cart";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            MySqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                idFormcart = read1.GetString("ID").ToString();
                nameFormcart = read1.GetString("product").ToString();
                amountFormcart = read1.GetString("amount").ToString();
                sumFormcart = read1.GetString("sum").ToString();
                stockmain item2 = new stockmain()
                {
                    ID= idFormcart,
                    name = nameFormcart,
                    amount = amountFormcart,
                    sum = sumFormcart
                };
                movedata.Add(item2);
            }
            conn.Close();
            foreach (var z in movedata)
            {
                conn.Open();
                string sql2 = "INSERT INTO history(ID, name, amount, sum) VALUES ('"+ z.ID + "','" + z.name + "','" + z.amount + "','" + z.sum + "')";

                MySqlCommand command1 = new MySqlCommand(sql2, conn);
                command1.ExecuteReader();
                conn.Close();
            }
            conn.Open();
            string sqlDelete = "DELETE FROM cart";

            MySqlCommand commandDelete = new MySqlCommand(sqlDelete, conn);
            commandDelete.ExecuteReader();
            conn.Close();
            movedata.Clear();
            Showdatacart();
            textBoxtotal.Text = "0";
            txtchangemoney.Text = "0";
            txtmoney.Text = "0";
            Showdataproduct();
            MessageBox.Show("ขอบคุณที่ใช้บริการค่ะ ", "แจ้งเตือน");


        }
        private void Showdatacart()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM cart";
            

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datacart.DataSource = ds.Tables[0].DefaultView;
        }
        int chek;
        private void btninsert_Click(object sender, EventArgs e) //เพิ่มลงตะกร้า
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT *FROM stockproduct WHERE name='{product.Text}'";
            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    chek = int.Parse(row.GetString(3));
                }
            }
            conn.Close();
            if (chek >= int.Parse(comboamount.Text))
            {
                string sql = "INSERT INTO cart (ID, product, price, amount,sum) VALUES('" + id.Text + "' ,'" + product.Text + "' , '" + priceproduct.Text + "','" + comboamount.Text + "','" + (int.Parse(comboamount.Text) * int.Parse(priceproduct.Text)).ToString() + "')";
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "แจ้งเตือน");
                Showdatacart();
                showprice();
            }
            else
            {
                MessageBox.Show("ขออภัยค่ะ จำนวนสินค้าในคลังไม่เพียงพอ", "แจ้งเตือน");
            }
        }
        int sum = 0;
        private void showprice()
        {
            sum = 0;
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT * FROM cart";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                sum = sum + int.Parse(read.GetString("sum").ToString());
            }
            textBoxtotal.Text = sum.ToString();
            conn.Close();


        }
        private void dataproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataproduct.CurrentRow.Selected = true;
            id.Text = dataproduct.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            product.Text = dataproduct.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            priceproduct.Text = dataproduct.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();

        }

        private void btnprint_Click(object sender, EventArgs e) //ปุ่มสั่งพิมพ์
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image logo = Image.FromFile(@"C:\Users\ACER\Desktop\ED COM\C#\Project example\pro\logo bbcare.png");
            e.Graphics.DrawImage(logo, new PointF(50, 50));
            e.Graphics.DrawString("BB Care Shop", new Font("TH SarabunPSK", 26, FontStyle.Bold), Brushes.Black, new PointF(650, 140));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 160));
            e.Graphics.DrawString("รายการจำหน่ายสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 195));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("พิมพ์โดย BB Care Shop ", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(400, 215));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 240));
            e.Graphics.DrawString("รหัสสินค้า", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 255));
            e.Graphics.DrawString("รายการ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(160, 255));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(470, 255));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(670, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            int y = 290;
            loaddata();
            foreach (var i in allbook)
            {
                e.Graphics.DrawString(i.ID, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.product, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(160, y));
                e.Graphics.DrawString(i.price, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(470, y));
                e.Graphics.DrawString(i.amount, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(670, y));
                y = y + 20;
            }
            e.Graphics.DrawString("ราคารวม", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(570, y));
            e.Graphics.DrawString("เงินที่ได้รับ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(570, y+20));
            e.Graphics.DrawString("เงินทอน", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(570, y+20+20));
            e.Graphics.DrawString(textBoxtotal.Text + " บาท", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(650, y));
            e.Graphics.DrawString(txtmoney.Text + " บาท", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(650, y + 20));
            e.Graphics.DrawString(txtchangemoney.Text + " บาท", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(650, y + 20 + 20));

        }
        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=bbcare_shop;");

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cart", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();

            while (adapter.Read())
            {
                Program.ID = adapter.GetString("ID");
                Program.product = adapter.GetString("product");
                Program.price = adapter.GetString("price");
                Program.amount = adapter.GetString("amount");
                ForPrint item = new ForPrint()
                {
                    ID = Program.ID,
                    product = Program.product,
                    price = Program.price,
                    amount = Program.amount

                };
                allbook.Add(item);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)  /*ลบรายการ*/
        {
            int selectedRow = datacart.CurrentCell.RowIndex;
            int deleteuser = Convert.ToInt32(datacart.Rows[selectedRow].Cells["ID"].Value);

            MySqlConnection conn = databaseConnection();
            string sql = "DELETE FROM cart WHERE ID = '" + deleteuser + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ", "แจ้งเตือน");
                Showdatacart();
                showprice();
            }
        }

        private void totalmoney_Click(object sender, EventArgs e) /*คิดเงิน*/
        {
            double givemoney = double.Parse(txtmoney.Text);
            if (givemoney >= sum)
            {
                txtchangemoney.Text = Convert.ToString(givemoney - sum);
            }
            else if (givemoney < sum)
            {
                MessageBox.Show("จำนวนเงินไม่พียงพอ", "ระบบ");
            }
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmoney_Leave(object sender, EventArgs e)
        {
            if (txtmoney.Text == "")
            {
                txtmoney.Text = "0";
                txtmoney.ForeColor = Color.Silver;
            }
        }

        private void txtmoney_Enter(object sender, EventArgs e)
        {
            if (txtmoney.Text == "0")
            {
                txtmoney.Text = "";
                txtmoney.ForeColor = Color.Black;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE name like \"%{searchbox.Text}%\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

            if (searchbox.Text == "")
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM stockproduct";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                conn.Close();

                dataproduct.DataSource = ds.Tables[0].DefaultView;
            }
        }
    }
}
