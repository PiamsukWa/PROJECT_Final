
namespace PROJECT_Test
{
    partial class UserControladmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridViewadmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newaccount = new System.Windows.Forms.Button();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.saveaccount = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewadmin
            // 
            this.GridViewadmin.AllowUserToAddRows = false;
            this.GridViewadmin.AllowUserToDeleteRows = false;
            this.GridViewadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridViewadmin.BackgroundColor = System.Drawing.Color.Lavender;
            this.GridViewadmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewadmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewadmin.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewadmin.Location = new System.Drawing.Point(54, 145);
            this.GridViewadmin.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewadmin.Name = "GridViewadmin";
            this.GridViewadmin.ReadOnly = true;
            this.GridViewadmin.RowHeadersWidth = 35;
            this.GridViewadmin.RowTemplate.Height = 24;
            this.GridViewadmin.Size = new System.Drawing.Size(497, 538);
            this.GridViewadmin.TabIndex = 0;
            this.GridViewadmin.TabStop = false;
            this.GridViewadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewadmin_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "บัญชีผู้ใช้";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ชื่อ";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(717, 222);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(452, 40);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(717, 375);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(454, 40);
            this.fname.TabIndex = 6;
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(717, 450);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(454, 40);
            this.lname.TabIndex = 7;
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lname_KeyPress);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("FC Iconic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(148, 82);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(373, 44);
            this.searchbox.TabIndex = 9;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FC Iconic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(812, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "บัญชีของฉัน";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(717, 302);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(454, 40);
            this.password.TabIndex = 14;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "รหัสผ่าน";
            // 
            // newaccount
            // 
            this.newaccount.BackColor = System.Drawing.Color.MediumPurple;
            this.newaccount.FlatAppearance.BorderSize = 0;
            this.newaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newaccount.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccount.ForeColor = System.Drawing.SystemColors.Window;
            this.newaccount.Location = new System.Drawing.Point(248, 703);
            this.newaccount.Name = "newaccount";
            this.newaccount.Size = new System.Drawing.Size(188, 48);
            this.newaccount.TabIndex = 25;
            this.newaccount.Text = "สร้างบัญชีผู้ใช้";
            this.newaccount.UseVisualStyleBackColor = false;
            this.newaccount.Click += new System.EventHandler(this.newaccount_Click_1);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxemail.Location = new System.Drawing.Point(717, 525);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(312, 40);
            this.textBoxemail.TabIndex = 27;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            this.textBoxemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxemail_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FC Iconic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "email\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(803, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 31);
            this.label8.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(721, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 26);
            this.label9.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_Test.Properties.Resources.user4;
            this.pictureBox1.Location = new System.Drawing.Point(903, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.LightCoral;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.searchbutton.Image = global::PROJECT_Test.Properties.Resources.pngtree_vector_find_icon_png_image_516019_removebg_preview__1_1;
            this.searchbutton.Location = new System.Drawing.Point(537, 82);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(143, 45);
            this.searchbutton.TabIndex = 20;
            this.searchbutton.Text = "ค้นหา";
            this.searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // saveaccount
            // 
            this.saveaccount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveaccount.FlatAppearance.BorderSize = 0;
            this.saveaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveaccount.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveaccount.ForeColor = System.Drawing.SystemColors.Window;
            this.saveaccount.Location = new System.Drawing.Point(443, 703);
            this.saveaccount.Name = "saveaccount";
            this.saveaccount.Size = new System.Drawing.Size(188, 48);
            this.saveaccount.TabIndex = 50;
            this.saveaccount.Text = "เพิ่มบัญชี";
            this.saveaccount.UseVisualStyleBackColor = false;
            this.saveaccount.Click += new System.EventHandler(this.saveaccount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 32);
            this.label10.TabIndex = 51;
            this.label10.Text = "บัญชีผู้ใช้";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 52;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnupdate.Location = new System.Drawing.Point(985, 692);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(188, 48);
            this.btnupdate.TabIndex = 53;
            this.btnupdate.Text = "อัปเดตข้อมูล";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("FC Iconic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(1046, 532);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 28);
            this.label11.TabIndex = 54;
            this.label11.Text = "@gmail.com";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(54, 703);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(188, 48);
            this.btndelete.TabIndex = 55;
            this.btndelete.Text = "ลบบัญชี";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // UserControladmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saveaccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.newaccount);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewadmin);
            this.Name = "UserControladmin";
            this.Size = new System.Drawing.Size(1189, 773);
            this.Load += new System.EventHandler(this.UserControladmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button newaccount;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveaccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btndelete;
    }
}
