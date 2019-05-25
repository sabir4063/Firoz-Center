namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class PostOrder : Form
    {
        private Button buttonPost;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label1;
        private Label label11;
        private Label label12;
        private TextBox textBoxInvoiceNo;

        public PostOrder()
        {
            this.InitializeComponent();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "UPDATE firoz_center.tbl_purchase_order set closing_date='" + str + "',order_date='" + str + "',status='0';";
            this.dbc.Update(query);
            string str3 = "DELETE FROM firoz_center.tbl_temp_order";
            this.dbc.Delete(str3);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string text = this.textBoxInvoiceNo.Text;
                string str5 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str7 = "Insert into firoz_center.tbl_order(`order_id`,`parts_no`,`quantity`) values ('" + this.textBoxInvoiceNo.Text + "','" + str5 + "', '" + str6 + "');";
                this.dbc.Insert(str7);
            }
            MessageBox.Show("Order Pposted");
            base.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            this.groupBox1 = new GroupBox();
            this.buttonPost = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.textBoxInvoiceNo = new TextBox();
            this.label11 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.label1 = new Label();
            this.groupBox3 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x267, 0x37);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            this.buttonPost.BackColor = Color.MediumSeaGreen;
            this.buttonPost.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPost.Location = new Point(0x272, 0x13);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new Size(120, 30);
            this.buttonPost.TabIndex = 0x1b;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new EventHandler(this.buttonPost_Click);
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x13d, 0x13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x59, 0x16);
            this.dateTimePicker1.TabIndex = 0x18;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xdd, 0x15);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x5b, 0x10);
            this.label12.TabIndex = 0x1a;
            this.label12.Text = "Opening Date";
            this.textBoxInvoiceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxInvoiceNo.Location = new Point(0x4f, 0x13);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new Size(0x75, 0x16);
            this.textBoxInvoiceNo.TabIndex = 0x17;
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(13, 0x15);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x3f, 0x10);
            this.label11.TabIndex = 0x19;
            this.label11.Text = "Order No";
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0x202, 0x15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x59, 0x16);
            this.dateTimePicker2.TabIndex = 0x1c;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0x1a5, 0x17);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x55, 0x10);
            this.label1.TabIndex = 0x1d;
            this.label1.Text = "Closing Date";
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(5, 0x41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x2ec, 0x1bd);
            this.groupBox3.TabIndex = 0x1c;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column2, this.Column7, this.Column3, this.Column4, this.Column5, this.Column6, this.Column1 });
            this.dataGridView1.Location = new Point(9, 0x11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x2cf, 420);
            this.dataGridView1.TabIndex = 0;
            this.Column2.HeaderText = "S/N";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            this.Column7.HeaderText = "Model";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column3.FillWeight = 150f;
            this.Column3.HeaderText = "Parts No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            this.Column4.FillWeight = 150f;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = style;
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            style2.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style2;
            this.Column6.HeaderText = "P";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 10;
            this.Column1.HeaderText = "A";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 10;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x2f6, 0x203);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.buttonPost);
            base.Name = "PostOrder";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PostOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        private void load_order()
        {
            int num;
            string query = "SELECT * FROM firoz_center.tbl_temp_order t where order_id='" + this.textBoxInvoiceNo.Text + "';";
            List<string>[] listArray = new List<string>[3];
            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = "Select model from firoz_center.tbl_parts_info where partsNo='" + listArray[1].ElementAt<string>(num) + "';";
                string str3 = this.dbc.SelectSingle(str2);
                string str4 = "Select description from firoz_center.tbl_parts_info where partsNo='" + listArray[1].ElementAt<string>(num) + "';";
                string str5 = this.dbc.SelectSingle(str4);
                this.dataGridView1.Rows.Add(new object[] { num + 1, str3, listArray[1].ElementAt<string>(num), str5, listArray[2].ElementAt<string>(num) });
            }
        }

        public void load_status()
        {
            string query = "SELECT status FROM firoz_center.tbl_purchase_order t where status='1';";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Open a new order");
                base.Dispose();
            }
            else
            {
                string str2 = "SELECT order_id FROM firoz_center.tbl_purchase_order t where status='1';";
                string str3 = this.dbc.SelectSingle(str2);
                this.textBoxInvoiceNo.Text = str3;
                this.load_order();
            }
        }
    }
}

