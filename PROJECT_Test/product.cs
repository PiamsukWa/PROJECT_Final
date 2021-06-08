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
using System.IO;
using System.Drawing.Imaging;

namespace PROJECT_Test
{
    public partial class product : UserControl
    {
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
        public product()
        {
            InitializeComponent();
        }

        private void dataproduct_CellClik(object sender, DataGridViewCellEventArgs e)
        {
            dataproduct.CurrentRow.Selected = true;
            txtid.Text = dataproduct.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            txtkind.Text = dataproduct.Rows[e.RowIndex].Cells["kind"].FormattedValue.ToString();
            txtname.Text = dataproduct.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            textamount.Text = dataproduct.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            txtprice.Text = dataproduct.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();

        }

        private void product_Load(object sender, EventArgs e)
        {
            Showdataproduct();
            if (Program.status_login == "admin")
            {
                txtkind.Enabled = true;
                txtname.Enabled = true;
                textamount.Enabled = true;
                txtprice.Enabled = true;
                delete.Enabled = true;
                insert.Enabled = true;
                update.Enabled = true;

            }
            else if (Program.status_login == "sales")
            {
                txtkind.Enabled = false;
                txtname.Enabled = false;
                textamount.Enabled = false;
                txtprice.Enabled = false;
                delete.Enabled = false;
                insert.Enabled = false;
                update.Enabled = false;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int selectedRow = dataproduct.CurrentCell.RowIndex;
            int productupdate = Convert.ToInt32(dataproduct.Rows[selectedRow].Cells["ID"].Value);

            MySqlConnection conn = databaseConnection();
            string sql = "UPDATE stockproduct SET kind ='" + txtkind.Text + "' ,name ='" + txtname.Text + "' ,  amount = '" + textamount.Text + "' , price = '" + txtprice.Text + "' WHERE ID = '" + productupdate + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "แจ้งเตือน");
                Showdataproduct();
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO stockproduct (kind, name, amount, price) VALUES('" + txtkind.Text + "' , '" + txtname.Text + "','" + textamount.Text + "', '" + txtprice.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "แจ้งเตือน");
                Showdataproduct();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataproduct.CurrentCell.RowIndex;
            int deleteuser = Convert.ToInt32(dataproduct.Rows[selectedRow].Cells["ID"].Value);

            MySqlConnection conn = databaseConnection();
            string sql = "DELETE FROM stockproduct WHERE ID = '" + deleteuser + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ", "แจ้งเตือน");
                Showdataproduct();
            }
        }
        public void combokind()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE kind =\"{comboBox1.SelectedItem.ToString()}\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataproduct.DataSource = ds.Tables[0].DefaultView; 
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combokind();

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

        private void btnreset_Click(object sender, EventArgs e)
        {
            Showdataproduct();
            txtid.ResetText();
            txtkind.ResetText();
            txtname.ResetText();
            textamount.ResetText();
            txtprice.ResetText();
            searchbox.Text = "";
            comboBox1.Text = "ประเภทสินค้า";
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("กรุณาตรวจสอบอักขระ", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtkind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("กรุณาตรวจสอบอักขระ", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
