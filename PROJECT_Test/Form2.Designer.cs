
namespace PROJECT_Test
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.labelcheckpass = new System.Windows.Forms.Label();
            this.buttonclose1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgetpass = new System.Windows.Forms.Label();
            this.buttonnewacount = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxusername
            // 
            this.textBoxusername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxusername.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxusername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxusername.Font = new System.Drawing.Font("FC Iconic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxusername.Location = new System.Drawing.Point(181, 367);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(497, 42);
            this.textBoxusername.TabIndex = 3;
            this.textBoxusername.TabStop = false;
            this.textBoxusername.Text = "บัญชีผู้ใช้";
            this.textBoxusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxusername.Enter += new System.EventHandler(this.textBoxusername_Enter);
            this.textBoxusername.Leave += new System.EventHandler(this.textBoxusername_Leave);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Crimson;
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.FlatAppearance.BorderSize = 0;
            this.buttonlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Font = new System.Drawing.Font("FC Daisy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonlogin.Location = new System.Drawing.Point(285, 613);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(307, 70);
            this.buttonlogin.TabIndex = 7;
            this.buttonlogin.Text = "เข้าสู่ระบบ";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxpass.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxpass.Font = new System.Drawing.Font("FC Iconic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxpass.Location = new System.Drawing.Point(181, 442);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(497, 42);
            this.textBoxpass.TabIndex = 8;
            this.textBoxpass.TabStop = false;
            this.textBoxpass.Text = "รหัสผ่าน";
            this.textBoxpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            this.textBoxpass.Enter += new System.EventHandler(this.textBoxpass_Enter);
            this.textBoxpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxpass_KeyDown);
            this.textBoxpass.Leave += new System.EventHandler(this.textBoxpass_Leave);
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxpass.Font = new System.Drawing.Font("FC Home", 14F);
            this.checkBoxpass.Location = new System.Drawing.Point(684, 454);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(148, 30);
            this.checkBoxpass.TabIndex = 11;
            this.checkBoxpass.Text = "แสดงรหัสผ่าน";
            this.checkBoxpass.UseVisualStyleBackColor = false;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // labelcheckpass
            // 
            this.labelcheckpass.AutoSize = true;
            this.labelcheckpass.BackColor = System.Drawing.SystemColors.Window;
            this.labelcheckpass.Font = new System.Drawing.Font("FC Iconic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcheckpass.ForeColor = System.Drawing.Color.Crimson;
            this.labelcheckpass.Location = new System.Drawing.Point(280, 505);
            this.labelcheckpass.Name = "labelcheckpass";
            this.labelcheckpass.Size = new System.Drawing.Size(0, 28);
            this.labelcheckpass.TabIndex = 14;
            this.labelcheckpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonclose1
            // 
            this.buttonclose1.BackColor = System.Drawing.Color.Crimson;
            this.buttonclose1.FlatAppearance.BorderSize = 0;
            this.buttonclose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonclose1.Location = new System.Drawing.Point(814, -56);
            this.buttonclose1.Name = "buttonclose1";
            this.buttonclose1.Size = new System.Drawing.Size(63, 30);
            this.buttonclose1.TabIndex = 15;
            this.buttonclose1.Text = "X";
            this.buttonclose1.UseVisualStyleBackColor = false;
            this.buttonclose1.Click += new System.EventHandler(this.buttonclose1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.forgetpass);
            this.panel2.Controls.Add(this.buttonnewacount);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.labelcheckpass);
            this.panel2.Controls.Add(this.checkBoxpass);
            this.panel2.Controls.Add(this.textBoxpass);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonlogin);
            this.panel2.Controls.Add(this.textBoxusername);
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 801);
            this.panel2.TabIndex = 2;
            // 
            // forgetpass
            // 
            this.forgetpass.AutoSize = true;
            this.forgetpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetpass.Font = new System.Drawing.Font("FC Iconic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpass.Location = new System.Drawing.Point(604, 643);
            this.forgetpass.Name = "forgetpass";
            this.forgetpass.Size = new System.Drawing.Size(124, 28);
            this.forgetpass.TabIndex = 15;
            this.forgetpass.Text = "ลืมรหัสผ่าน ?";
            this.forgetpass.Click += new System.EventHandler(this.forgetpass_Click);
            // 
            // buttonnewacount
            // 
            this.buttonnewacount.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonnewacount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonnewacount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonnewacount.FlatAppearance.BorderSize = 0;
            this.buttonnewacount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonnewacount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnewacount.Font = new System.Drawing.Font("FC Daisy", 22.8F);
            this.buttonnewacount.Image = global::PROJECT_Test.Properties.Resources._4601f773e41c094849e10288a7aec5e8__1_;
            this.buttonnewacount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonnewacount.Location = new System.Drawing.Point(531, 725);
            this.buttonnewacount.Name = "buttonnewacount";
            this.buttonnewacount.Size = new System.Drawing.Size(319, 57);
            this.buttonnewacount.TabIndex = 9;
            this.buttonnewacount.Text = "สมัครสมาชิกที่นี่";
            this.buttonnewacount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonnewacount.UseVisualStyleBackColor = false;
            this.buttonnewacount.Click += new System.EventHandler(this.buttonnewacount_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = global::PROJECT_Test.Properties.Resources.lock_password_protect_safety_security_icon_1320086045132546966;
            this.pictureBox4.Location = new System.Drawing.Point(117, 442);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = global::PROJECT_Test.Properties.Resources.Sample_User_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(117, 367);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_Test.Properties.Resources.slide1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(801, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(889, 921);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonclose1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button buttonnewacount;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelcheckpass;
        private System.Windows.Forms.Button buttonclose1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label forgetpass;
        private System.Windows.Forms.Button button2;
    }
}