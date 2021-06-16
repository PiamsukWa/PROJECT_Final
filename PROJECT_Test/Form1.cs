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
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM cart ";
            MySqlDataReader row = cmd.ExecuteReader();
            
            while (row.Read()) //sum_old ไว้คำนวณราคารวม
            {
                MySqlConnection conn2 = databaseConnection();
                conn2.Open();
                MySqlCommand cmd2;
                cmd2 = conn2.CreateCommand();
                cmd2.CommandText = $"SELECT * FROM stockproduct WHERE ID = \"{row.GetString(0)}\"";
                MySqlDataReader row2 = cmd2.ExecuteReader();
                while (row2.Read())
                {
                    amountnew = $"{int.Parse(row.GetString(3)) + int.Parse(row2.GetString(3))}";
                }
                conn2.Close();

                conn2.Open();
                string sql3 = "UPDATE stockproduct SET amount = '" + amountnew + "' WHERE ID = '" + row.GetString(0) + "'";
                MySqlCommand command = new MySqlCommand(sql3, conn2);
                command.ExecuteReader();
                conn2.Close();
            }
            conn.Close();

            MySqlConnection conn1 = databaseConnection();
            string sql = "DELETE FROM cart";
            MySqlCommand cmd1 = new MySqlCommand(sql, conn1);

            conn1.Open();
            int rows = cmd1.ExecuteNonQuery();
            conn1.Close();
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
                    sum = sumFormcart,
                };
                movedata.Add(item2);
            }
            conn.Close(); 
            foreach (var z in movedata)
            {
                conn.Open();
                string sql2 = "INSERT INTO history(ID, name, amount, sum ,sales) VALUES ('" + z.ID + "','" + z.name + "','" + z.amount + "','" + z.sum + "','" + txtpersonnel.Text+ "')";

                MySqlCommand command1 = new MySqlCommand(sql2, conn);
                command1.ExecuteReader();
                conn.Close();
            }
            printPreviewDialog1.Document = printDocument1; //ปริิ้นใบเสร็จ
            printPreviewDialog1.ShowDialog();
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
        private void Showdatacart() //ตะกร้าสินค้า
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
        int check, amountold;
        private void btninsert_Click(object sender, EventArgs e) //เพิ่มลงตะกร้า
        {
            if (dtstock == true)
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM stockproduct WHERE ID='{id.Text}'";
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read()) //sum_old ไว้คำนวณราคารวม
                    {
                        check = int.Parse(row.GetString(3)); //จำนวนในสต๊อก
                        sum_old = int.Parse(row.GetString(4));
                    }
                }
                conn.Close();
                if (check >= int.Parse(comboamount.Text))
                {
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT *FROM cart WHERE ID='{id.Text}'";
                    row = cmd.ExecuteReader();

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            amountold = int.Parse(row.GetString(3)); //จำนวนในตะกร้า
                            
                        }
                        amountnew = (amountold + int.Parse(comboamount.Text)).ToString();
                        MySqlConnection conn1 = databaseConnection();
                        conn1.Open();
                        string sql = "UPDATE cart SET amount = '" + amountnew + "',sum = '" + int.Parse(amountnew) * sum_old +"' WHERE ID = '" + id.Text + "'";
                        MySqlCommand command1 = new MySqlCommand(sql, conn1);
                        command1.ExecuteReader();
                        conn1.Close();

                        conn1.Open();
                        sql = "UPDATE stockproduct SET amount = '" + (check - int.Parse(amountnew)) + "' WHERE ID = '" + id.Text + "'";
                        command1 = new MySqlCommand(sql, conn1);
                        command1.ExecuteReader();
                        conn1.Close();
                        MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "ระบบ");
                        Showdataproduct();
                        Showdatacart();
                        showprice();
                    }
                    else
                    {
                        MySqlConnection conn1 = databaseConnection();
                        string sql = "INSERT INTO cart (ID, product, price, amount,sum) VALUES('" + id.Text + "' ,'" + product.Text + "' , '" + priceproduct.Text + "','" + comboamount.Text + "','" + (int.Parse(comboamount.Text) * int.Parse(priceproduct.Text)).ToString() + "')";
                        conn1.Open();
                        cmd = new MySqlCommand(sql, conn1);
                        cmd.ExecuteReader();
                        conn1.Close();


                        conn1.Open();
                        sql = "SELECT * FROM stockproduct WHERE ID = '" + id.Text + "'";
                        MySqlCommand command = new MySqlCommand(sql, conn1);
                        MySqlDataReader readdata = command.ExecuteReader();
                        while (readdata.Read())
                        {
                            amountfromDB = readdata.GetString("amount").ToString();
                        }
                        conn1.Close();

                        amountnew = (int.Parse(amountfromDB) - int.Parse(comboamount.Text)).ToString();

                        conn1.Open();
                        MessageBox.Show("เพิ่มสินค้าสำเร็จ", "แจ้งเตือน");

                        sql = "UPDATE stockproduct SET amount = '" + amountnew + "' WHERE ID = '" + id.Text + "'";
                        MySqlCommand command1 = new MySqlCommand(sql, conn1);
                        command1.ExecuteReader();
                        conn1.Close();

                        Showdataproduct();
                        Showdatacart();
                        showprice();
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("ขออภัยค่ะ จำนวนสินค้าในคลังไม่เพียงพอ", "แจ้งเตือน");
                }
            }     
        }
        int sum = 0;
        private void showprice() //ยอดรวม
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
        Boolean dtstock;
        private void dataproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataproduct.CurrentRow.Selected = true;
            id.Text = dataproduct.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            product.Text = dataproduct.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            priceproduct.Text = dataproduct.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            dtstock = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image logo = Image.FromFile(@"C:\Users\ACER\Desktop\ED COM\C#\Project example\pro\logo bbcare.png");
            e.Graphics.DrawImage(logo, new PointF(50, 50));
            e.Graphics.DrawString("BB Care Shop", new Font("TH SarabunPSK", 26, FontStyle.Bold), Brushes.Black, new PointF(650, 140));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 160));
            e.Graphics.DrawString("รายการจำหน่ายสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 195));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("พิมพ์โดย   " + txtpersonnel.Text, new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(400, 215));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 240));
            e.Graphics.DrawString("รหัสสินค้า", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 255));
            e.Graphics.DrawString("รายการ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(160, 255));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(470, 255));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(670, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            int y = 290;

            allbook.Clear();
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

        int dltamount;
        private void btndelete_Click(object sender, EventArgs e)  /*ลบรายการ*/
        {
            if(dtstock == false)
            {
                int selectedRow = datacart.CurrentCell.RowIndex;
                int deleteuser = Convert.ToInt32(datacart.Rows[selectedRow].Cells["ID"].Value);
                dltamount = Convert.ToInt32(datacart.Rows[selectedRow].Cells["amount"].Value);

                MySqlConnection conn = databaseConnection();
                string sql = "DELETE FROM cart WHERE ID = '" + deleteuser + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    conn.Open();
                    string sqlcom = "SELECT * FROM stockproduct WHERE ID = '" + deleteuser + "'";
                    MySqlCommand command = new MySqlCommand(sqlcom, conn);
                    MySqlDataReader readdata = command.ExecuteReader();
                    while (readdata.Read())
                    {
                        amountfromDB = readdata.GetString("amount").ToString();
                    }
                    dltamount = dltamount + int.Parse(amountfromDB);
                    conn.Close();
                    conn.Open();
                    sql = "UPDATE stockproduct SET amount = '" + dltamount + "' WHERE ID = '" + deleteuser + "'";
                    command = new MySqlCommand(sql, conn);
                    command.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "แจ้งเตือน");
                    Showdataproduct();
                    Showdatacart();
                    showprice();
                }
            }
        }

        private void totalmoney_Click(object sender, EventArgs e) /*คิดเงิน*/
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            String user = txtpersonnel.Text; 

            cmd.CommandText = $"SELECT * FROM admin WHERE username=\"{user}\"";
            double givemoney = double.Parse(txtmoney.Text);
            if (cmd.ExecuteReader().HasRows)
            {
                if (givemoney >= sum)
                {
                    txtchangemoney.Text = Convert.ToString(givemoney - sum);
                }
                else if (givemoney < sum)
                {
                    MessageBox.Show("จำนวนเงินไม่พียงพอ", "ระบบ" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("ไม่มีชื่อพนักงาน", "ระบบ" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
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

        private void txtpersonnel_Leave(object sender, EventArgs e)
        {
            if (txtpersonnel.Text == "")
            {
                txtpersonnel.Text = "ป้อนชื่อพนักงานขาย";
                txtpersonnel.ForeColor = Color.Silver;
            }
        }

        private void txtpersonnel_Enter(object sender, EventArgs e)
        {
            if (txtpersonnel.Text == "ป้อนชื่อพนักงานขาย")
            {
                txtpersonnel.Text = "";
                txtpersonnel.ForeColor = Color.Black;
            }
        }
        private void comboamount_TextChanged(object sender, EventArgs e)
        {
            if (comboamount.Text == "0")
            {
                MessageBox.Show("กรุณาใส่จำนวนสินค้า", "ระบบแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dtstock == false)
                {
                    MySqlConnection conn = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT *FROM cart WHERE ID='{id.Text}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            amountold = int.Parse(row.GetString(3)); //จำนวนในสต๊อก
                        }
                    }
                    comboamount.Text = $"{amountold}";
                    conn.Close();
                }
                else
                {
                    MySqlConnection conn = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT *FROM stockproduct WHERE ID='{id.Text}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            amountold = int.Parse(row.GetString(3)); //จำนวนในสต๊อก
                        }
                    }
                    comboamount.Text = "1";
                    conn.Close();
                }
            }
        }

        private void comboamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "ระบบแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int check_1, check_2, sum_old;
        private void btnedit_Click(object sender, EventArgs e)
        {
            if(dtstock == false)
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM stockproduct WHERE ID='{id.Text}'";
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        check_1 = int.Parse(row.GetString(3)); //จำนวนในสต๊อก
                        sum_old = int.Parse(row.GetString(4));
                    }
                }
                conn.Close();

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM cart WHERE ID='{id.Text}'";
                row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        check_2 = int.Parse(row.GetString(3)); //จำนวนในสต๊อก
                    }
                }
                conn.Close();

                if (check_1 >= int.Parse(comboamount.Text))
                {
                    if (int.Parse(comboamount.Text) > check_2)
                    {
                        conn.Open();
                        string sql = "UPDATE cart SET amount = '" + comboamount.Text + "', sum = '" + sum_old * int.Parse(comboamount.Text) + "' WHERE ID = '" + id.Text + "'";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();
                        string amountstock = (check_1 - (int.Parse(comboamount.Text) - check_2)).ToString();
                        conn.Open();
                        sql = "UPDATE stockproduct SET amount = '" + amountstock + "' WHERE ID = '" + id.Text + "'";
                        command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();
                    }
                    else
                    {
                        conn.Open();
                        string sql = "UPDATE cart SET amount = '" + comboamount.Text + "', sum = '" + sum_old * int.Parse(comboamount.Text) + "' WHERE ID = '" + id.Text + "'";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();
                        string amountstock = ((check_2 - int.Parse(comboamount.Text)) + check_1).ToString();
                        conn.Open();
                        sql = "UPDATE stockproduct SET amount = '" + amountstock + "' WHERE ID = '" + id.Text + "'";
                        command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();
                    }
                    MessageBox.Show("แก้ข้อมูลสำเร็จ", "แจ้งเตือน");
                    Showdataproduct();
                    Showdatacart();
                    showprice();
                }
                else
                {
                    MessageBox.Show("โปรดตรวจสอบจำนวนสินค้า", "แจ้งเตือน");
                }
            }
        }

        private void datacart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtstock = false;
            datacart.CurrentRow.Selected = true;
            id.Text = datacart.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            product.Text = datacart.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
            priceproduct.Text = datacart.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            comboamount.Text = datacart.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
        }
    }
}
