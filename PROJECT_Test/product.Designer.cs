
namespace PROJECT_Test
{
    partial class product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.txtkind = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.textamount = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dataproduct = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(763, 550);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(376, 40);
            this.txtprice.TabIndex = 60;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.SystemColors.Window;
            this.insert.Location = new System.Drawing.Point(290, 702);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(210, 51);
            this.insert.TabIndex = 58;
            this.insert.Text = "เพิ่มข้อมูล";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // txtkind
            // 
            this.txtkind.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkind.Location = new System.Drawing.Point(765, 361);
            this.txtkind.Name = "txtkind";
            this.txtkind.Size = new System.Drawing.Size(374, 40);
            this.txtkind.TabIndex = 57;
            this.txtkind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkind_KeyPress);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkCyan;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(529, 702);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(229, 51);
            this.update.TabIndex = 56;
            this.update.Text = "อัปเดตข้อมูล";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FC Iconic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(895, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 42);
            this.label5.TabIndex = 55;
            this.label5.Text = "ข้อมูลสินค้า";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Window;
            this.delete.Location = new System.Drawing.Point(42, 703);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(219, 50);
            this.delete.TabIndex = 54;
            this.delete.Text = "ลบสินค้า";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("FC Iconic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(100, 187);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(520, 44);
            this.searchbox.TabIndex = 53;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // textamount
            // 
            this.textamount.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textamount.Location = new System.Drawing.Point(765, 484);
            this.textamount.Name = "textamount";
            this.textamount.Size = new System.Drawing.Size(374, 40);
            this.textamount.TabIndex = 51;
            this.textamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textamount_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(765, 421);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(374, 42);
            this.txtname.TabIndex = 50;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(765, 304);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(374, 40);
            this.txtid.TabIndex = 49;
            this.txtid.TabStop = false;
            // 
            // dataproduct
            // 
            this.dataproduct.AllowUserToAddRows = false;
            this.dataproduct.AllowUserToDeleteRows = false;
            this.dataproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataproduct.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataproduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataproduct.Location = new System.Drawing.Point(56, 257);
            this.dataproduct.Margin = new System.Windows.Forms.Padding(4);
            this.dataproduct.Name = "dataproduct";
            this.dataproduct.ReadOnly = true;
            this.dataproduct.RowHeadersWidth = 35;
            this.dataproduct.RowTemplate.Height = 24;
            this.dataproduct.Size = new System.Drawing.Size(564, 407);
            this.dataproduct.TabIndex = 48;
            this.dataproduct.TabStop = false;
            this.dataproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduct_CellClik);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT_Test.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(912, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Gold;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnsearch.Image = global::PROJECT_Test.Properties.Resources.pngtree_vector_find_icon_png_image_516019_removebg_preview__1_1;
            this.btnsearch.Location = new System.Drawing.Point(638, 186);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(161, 45);
            this.btnsearch.TabIndex = 59;
            this.btnsearch.Text = "search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FC Iconic", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 32);
            this.label6.TabIndex = 67;
            this.label6.Text = "ราคา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 32);
            this.label7.TabIndex = 66;
            this.label7.Text = "ประเภท";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(706, 420);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 32);
            this.name.TabIndex = 64;
            this.name.Text = "ชื่อ";
            // 
            // txtamount
            // 
            this.txtamount.AutoSize = true;
            this.txtamount.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(666, 484);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(84, 32);
            this.txtamount.TabIndex = 63;
            this.txtamount.Text = "จำนวน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID สินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FC Iconic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 42);
            this.label4.TabIndex = 70;
            this.label4.Text = "ประเภท";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreset.Location = new System.Drawing.Point(638, 114);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(161, 45);
            this.btnreset.TabIndex = 71;
            this.btnreset.Text = "Reset";
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.Font = new System.Drawing.Font("FC Iconic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "ผิวกาย",
            "วิตามินและอาหารเสริม",
            "สกินแคร์"});
            this.comboBox1.Location = new System.Drawing.Point(177, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 38);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "ประเภทสินค้า";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FC Iconic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 72;
            this.label2.Text = "ชื่อ";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.txtkind);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.textamount);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataproduct);
            this.Name = "product";
            this.Size = new System.Drawing.Size(1189, 773);
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox txtkind;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.TextBox textamount;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dataproduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}
