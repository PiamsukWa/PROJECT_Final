using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_Test
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) // ออกจากระบบ
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void buttonadmin_Click(object sender, EventArgs e)
        {
            panelslide.Height = panelslide.Height;
            UserControladmin hc = new UserControladmin();
            showControl(hc);
        }

        public void showControl(Control control)
        {
            content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            content.Controls.Add(control);
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            panelslide.Height = panelslide.Height;
            product hc = new product();
            showControl(hc);
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            panelslide.Height = panelslide.Height;
            history hc = new history();
            showControl(hc);
        }
        public string txt; //รับค่ามาจากฟอร์ม log in
        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Text = txt;
        }
    }
}
