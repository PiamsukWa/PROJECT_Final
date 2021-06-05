
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridViewadmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newaccount = new System.Windows.Forms.Button();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insertimage = new System.Windows.Forms.Button();
            this.saveaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewadmin
            // 
            this.GridViewadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridViewadmin.BackgroundColor = System.Drawing.Color.Lavender;
            this.GridViewadmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewadmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridViewadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewadmin.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridViewadmin.Location = new System.Drawing.Point(54, 145);
            this.GridViewadmin.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewadmin.Name = "GridViewadmin";
            this.GridViewadmin.RowHeadersWidth = 35;
            this.GridViewadmin.RowTemplate.Height = 24;
            this.GridViewadmin.Size = new System.Drawing.Size(574, 538);
            this.GridViewadmin.TabIndex = 0;
            this.GridViewadmin.TabStop = false;
            this.GridViewadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewadmin_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "บัญชีผู้ใช้";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FC Iconic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "ตำแหน่งงาน";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(797, 192);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(374, 40);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(797, 353);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(374, 40);
            this.fname.TabIndex = 6;
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(797, 428);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(374, 40);
            this.lname.TabIndex = 7;
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(797, 595);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(376, 40);
            this.position.TabIndex = 8;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("FC Iconic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(54, 82);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(443, 44);
            this.searchbox.TabIndex = 9;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged_1);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Window;
            this.delete.Location = new System.Drawing.Point(54, 709);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(169, 48);
            this.delete.TabIndex = 11;
            this.delete.Text = "ลบบัญชี";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FC Iconic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(885, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "บัญชีของฉัน";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkCyan;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(942, 657);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(229, 51);
            this.update.TabIndex = 13;
            this.update.Text = "อัปเดตข้อมูล";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(797, 280);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(374, 40);
            this.password.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(676, 288);
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
            this.newaccount.Location = new System.Drawing.Point(237, 709);
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
            this.textBoxemail.Location = new System.Drawing.Point(797, 503);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(376, 40);
            this.textBoxemail.TabIndex = 27;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FC Iconic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "ที่อยู่ email\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(803, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 31);
            this.label8.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(803, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_Test.Properties.Resources.user4;
            this.pictureBox1.Location = new System.Drawing.Point(924, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // insertimage
            // 
            this.insertimage.BackColor = System.Drawing.Color.LightCoral;
            this.insertimage.FlatAppearance.BorderSize = 0;
            this.insertimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertimage.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertimage.ForeColor = System.Drawing.SystemColors.InfoText;
            this.insertimage.Image = global::PROJECT_Test.Properties.Resources.pngtree_vector_find_icon_png_image_516019_removebg_preview__1_1;
            this.insertimage.Location = new System.Drawing.Point(507, 82);
            this.insertimage.Name = "insertimage";
            this.insertimage.Size = new System.Drawing.Size(161, 45);
            this.insertimage.TabIndex = 20;
            this.insertimage.Text = "ค้นหา";
            this.insertimage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertimage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.insertimage.UseVisualStyleBackColor = false;
            this.insertimage.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // saveaccount
            // 
            this.saveaccount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveaccount.FlatAppearance.BorderSize = 0;
            this.saveaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveaccount.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveaccount.ForeColor = System.Drawing.SystemColors.Window;
            this.saveaccount.Location = new System.Drawing.Point(440, 709);
            this.saveaccount.Name = "saveaccount";
            this.saveaccount.Size = new System.Drawing.Size(188, 48);
            this.saveaccount.TabIndex = 50;
            this.saveaccount.Text = "เพิ่มบัญชี";
            this.saveaccount.UseVisualStyleBackColor = false;
            this.saveaccount.Click += new System.EventHandler(this.saveaccount_Click);
            // 
            // UserControladmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.saveaccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.newaccount);
            this.Controls.Add(this.insertimage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.position);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertimage;
        private System.Windows.Forms.Button newaccount;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveaccount;
    }
}
