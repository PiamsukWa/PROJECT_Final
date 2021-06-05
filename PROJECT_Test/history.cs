﻿using System;
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
    public partial class history : UserControl
    {
        private List<Forprinthis> allhisstock = new List<Forprinthis>(); /*listประวัติ*/
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
            cmd.CommandText = "SELECT * FROM history";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datahistory.DataSource = ds.Tables[0].DefaultView;
        }
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            Showdataproduct();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (searchbox.Text != "")
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM history WHERE sale_date between @date1 and @date2 and name=@data";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.Date); //เอาค่าจาก dateTimePicker ไปเก็บที่ parameters @date1
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@data", searchbox.Text);
                da.Fill(ds);
                conn.Close();
                datahistory.DataSource = ds.Tables[0].DefaultView;
                sum = 0; //ตัวแปรจำนวนสินค้า
                total = 0; //ตัวแปรยอดรวมจำนวนเงิน
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(3));
                    total = total + int.Parse(read.GetString(2));
                }
                textBoxTotal.Text = $"{sum}";
                totalpro.Text = $"{total}";
                conn.Close();
            }
            else
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM history WHERE sale_date between @date1 and @date2";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);
                da.Fill(ds);
                conn.Close();
                datahistory.DataSource = ds.Tables[0].DefaultView;
                sum = 0; //ตัวแปรจำนวนสินค้า
                total = 0; //ตัวแปรยอดรวมจำนวนเงิน
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(3));
                    total = total + int.Parse(read.GetString(2));
                }
                textBoxTotal.Text = $"{sum}";
                totalpro.Text = $"{total}";
                conn.Close();
            }
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
                cmd.CommandText = "SELECT * FROM history";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                conn.Close();

                datahistory.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Showdataproduct();
            searchbox.Text = "";
        }

        int sum = 0;
        int total = 0;
           
        // ปริ้นประวัติการขายสินค้า
        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image logo = Image.FromFile(@"C:\Users\ACER\Desktop\ED COM\C#\Project example\pro\logo bbcare.png");
            e.Graphics.DrawImage(logo, new PointF(50, 50));
            e.Graphics.DrawString("ประวัติการจำหน่ายสินค้า", new Font("TH SarabunPSK", 26, FontStyle.Bold), Brushes.Black, new PointF(370, 120));
            e.Graphics.DrawString("BB Care Shop", new Font("TH SarabunPSK", 26, FontStyle.Bold), Brushes.Black, new PointF(650, 120));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 160));
            e.Graphics.DrawString("ประวัติการจำหน่ายสินค้า", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 195));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("พิมพ์โดย BB Care Shop ", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(400, 215));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 240));
            e.Graphics.DrawString("รหัสสินค้า", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 255));
            e.Graphics.DrawString("รายการ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(160, 255));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(370, 255));
            e.Graphics.DrawString("จำนวน", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(470, 255));
            e.Graphics.DrawString("วันที่", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(670, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            int y = 290;
            allhisstock.Clear();
            loaddata();
            foreach (var i in allhisstock)
            {
                e.Graphics.DrawString(i.IDhis, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.producthis, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(160, y));
                e.Graphics.DrawString(i.pricehis, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(370, y));
                e.Graphics.DrawString(i.amounthis, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(470, y));
                e.Graphics.DrawString(i.datehis, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(670, y));
                y = y + 20;
            }
            e.Graphics.DrawString("จำนวนสินค้า", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(520, y+20));
            e.Graphics.DrawString("ยอดรวม", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(520, y + 20+20));
            e.Graphics.DrawString(totalpro.Text, new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(650, y+20));
            e.Graphics.DrawString(textBoxTotal.Text, new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(650, y + 20+20));
            e.Graphics.DrawString("ชิ้น", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(750, y + 20));
            e.Graphics.DrawString("บาท", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(750, y + 20 + 20));
        }
        private void loaddata()
        {
            if(searchbox.Text != "")
            {
                MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=bbcare_shop;");
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM history WHERE sale_date between @date1 and @date2 and name=@data";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@data", searchbox.Text);

                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.IDhis = adapter.GetString("ID");
                    Program.producthis = adapter.GetString("name");
                    Program.pricehis = adapter.GetString("sum");
                    Program.amounthis = adapter.GetString("amount");
                    Program.datehis = adapter.GetString("sale_date");
                    Forprinthis item = new Forprinthis()
                    {
                        IDhis = Program.IDhis,
                        producthis = Program.producthis,
                        pricehis = Program.pricehis,
                        amounthis = Program.amounthis,
                        datehis = Program.datehis

                    };
                    allhisstock.Add(item);
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=bbcare_shop;");
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM history WHERE sale_date between @date1 and @date2";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);

                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.IDhis = adapter.GetString("ID");
                    Program.producthis = adapter.GetString("name");
                    Program.pricehis = adapter.GetString("sum");
                    Program.amounthis = adapter.GetString("amount");
                    Program.datehis = adapter.GetString("sale_date");
                    Forprinthis item = new Forprinthis()
                    {
                        IDhis = Program.IDhis,
                        producthis = Program.producthis,
                        pricehis = Program.pricehis,
                        amounthis = Program.amounthis,
                        datehis = Program.datehis

                    };
                    allhisstock.Add(item);
                }
            }
        }
    }
}