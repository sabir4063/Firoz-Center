namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class AddOrder : Form
    {
        private Button buttonSubmit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private IContainer components;
        public DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DateTimePicker dateTimePicker1;
        private static DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label2;
        public static int qty = 0;
        private TextBox textBoxInvoiceNo;
        private TextBox textBoxQty;
        private TextBox textBoxSearch;

        public AddOrder()
        {
            this.components = null;
            this.InitializeComponent();
            this.load_parts();
            this.load_order_id();
        }

        public AddOrder(string order_id)
        {
            this.components = null;
            this.InitializeComponent();
            this.textBoxInvoiceNo.Text = order_id.ToString();
            this.load_parts();
            this.load_order_id();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int num;
            string str;
            for (num = 0; num < this.dataGridView1.RowCount; num++)
            {
                this.dataGridView1.Rows[num].DefaultCellStyle.BackColor = Color.White;
                str = this.dataGridView1.Rows[num].Cells[1].Value.ToString();
                if (this.dataGridView1.Rows[num].Cells[2].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Give Quantity: ");
                    this.dataGridView1.Rows[num].DefaultCellStyle.BackColor = Color.Blue;
                    return;
                }
            }
            string query = "DELETE FROM firoz_center.tbl_temp_order";
            dbc.Delete(query);
            for (num = 0; num < this.dataGridView1.RowCount; num++)
            {
                str = this.dataGridView1.Rows[num].Cells[1].Value.ToString();
                string str2 = this.dataGridView1.Rows[num].Cells[2].Value.ToString();
                string str4 = "Insert into firoz_center.tbl_temp_order(`order_id`,`parts_no`,`quantity`) values ('" + this.textBoxInvoiceNo.Text + "','" + str + "', '" + str2 + "');";
                dbc.Insert(str4);
            }
            MessageBox.Show("Order Added");
            base.Dispose();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string str = this.dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str2 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                if (str.Equals(str2))
                {
                    MessageBox.Show("Already Order Added");
                    this.dataGridView1.Rows[i].Cells[2].Selected = true;
                    this.dataGridView1.BeginEdit(true);
                    this.dataGridView1.MultiSelect = false;
                    return;
                }
            }
            this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.RowCount + 1, str, "" });
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
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.groupBox3 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.buttonSubmit = new Button();
            this.groupBox1 = new GroupBox();
            this.label1 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.textBoxInvoiceNo = new TextBox();
            this.label11 = new Label();
            this.groupBox2 = new GroupBox();
            this.dataGridView2 = new DataGridView();
            this.textBoxQty = new TextBox();
            this.textBoxSearch = new TextBox();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewCheckBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.label2 = new Label();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize) this.dataGridView2).BeginInit();
            base.SuspendLayout();
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.buttonSubmit);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(690, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(370, 0x1f7);
            this.groupBox3.TabIndex = 0x13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column2, this.Column3, this.Column5 });
            this.dataGridView1.Location = new Point(10, 0x11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(0x169, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.buttonSubmit.BackColor = Color.MediumSeaGreen;
            this.buttonSubmit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSubmit.Location = new Point(0x74, 0x1ce);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new Size(120, 30);
            this.buttonSubmit.TabIndex = 20;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new EventHandler(this.buttonSubmit_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.textBoxQty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2a7, 0x31);
            this.groupBox1.TabIndex = 0x11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0x132, 0x13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x38, 0x10);
            this.label1.TabIndex = 0x1b;
            this.label1.Text = "Quantity";
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0xd5, 0x11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x59, 0x16);
            this.dateTimePicker1.TabIndex = 0x18;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xab, 0x15);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x1a;
            this.label12.Text = "Date";
            this.textBoxInvoiceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxInvoiceNo.Location = new Point(0x4e, 0x11);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new Size(0x58, 0x16);
            this.textBoxInvoiceNo.TabIndex = 0x17;
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(13, 0x13);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x3f, 0x10);
            this.label11.TabIndex = 0x19;
            this.label11.Text = "Order No";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x2a7, 0x1c0);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView2.BorderStyle = BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.Column4, this.Column1 });
            this.dataGridView2.Location = new Point(7, 0x11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new Size(0x298, 420);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            this.textBoxQty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxQty.Location = new Point(0x170, 0x13);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new Size(0x2c, 0x16);
            this.textBoxQty.TabIndex = 0x1c;
            this.textBoxQty.TextAlign = HorizontalAlignment.Right;
            this.textBoxQty.KeyDown += new KeyEventHandler(this.textBoxQty_KeyDown);
            this.textBoxQty.KeyPress += new KeyPressEventHandler(this.textBoxQty_KeyPress);
            this.textBoxSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSearch.Location = new Point(0x1db, 0x13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new Size(0xc4, 0x16);
            this.textBoxSearch.TabIndex = 0x1d;
            this.textBoxSearch.TextAlign = HorizontalAlignment.Right;
            this.textBoxSearch.TextChanged += new EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyDown += new KeyEventHandler(this.textBoxSearch_KeyDown);
            this.Column2.HeaderText = "S/N";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            this.Column3.FillWeight = 150f;
            this.Column3.HeaderText = "Parts No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = style;
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = style2;
            this.dataGridViewTextBoxColumn1.HeaderText = "S/N";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            style3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = style3;
            this.dataGridViewTextBoxColumn2.FillWeight = 150f;
            this.dataGridViewTextBoxColumn2.HeaderText = "Parts No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = style4;
            this.dataGridViewTextBoxColumn3.FillWeight = 80f;
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            this.Column4.HeaderText = "Available";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = DataGridViewTriState.True;
            this.Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 70;
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x1a2, 0x17);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x33, 0x10);
            this.label2.TabIndex = 30;
            this.label2.Text = "Search";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x429, 0x200);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox1);
            base.Name = "AddOrder";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView2).EndInit();
            base.ResumeLayout(false);
        }

        private void load_order()
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string query = "SELECT parts_No,quantity FROM firoz_center.tbl_temp_order where order_id='" + this.textBoxInvoiceNo.Text + "';";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(2L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.dataGridView1.Rows.Add(new object[] { num + 1, listArray[0].ElementAt<string>(num), listArray[1].ElementAt<string>(num) });
            }
        }

        public void load_order_id()
        {
            string query = "SELECT order_id FROM firoz_center.tbl_purchase_order t where status='1';";
            if (dbc.Count(query) == -1L)
            {
                MessageBox.Show("Open a new order");
                base.Dispose();
            }
            else
            {
                this.textBoxInvoiceNo.Text = dbc.SelectSingle(query);
                this.load_order();
            }
        }

        private void load_parts()
        {
            int num;
            this.dataGridView2.Rows.Clear();
            string query = "SELECT partsid,partsNo,status,description FROM firoz_center.tbl_parts_info t;";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(4L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + listArray[0].ElementAt<string>(num) + "' and status like 'stock';";
                string str3 = dbc.SelectSingle(str2);
                if (listArray[2].ElementAt<string>(num).Equals("1"))
                {
                    this.dataGridView2.Rows.Add(new object[] { num + 1, listArray[1].ElementAt<string>(num), str3, true, listArray[3].ElementAt<string>(num) });
                }
                else
                {
                    this.dataGridView2.Rows.Add(new object[] { num + 1, listArray[1].ElementAt<string>(num), str3, false, listArray[3].ElementAt<string>(num) });
                }
            }
        }

        private void load_parts_qty()
        {
            int num;
            this.dataGridView2.Rows.Clear();
            string query = "SELECT partsid,partsNo,status FROM firoz_center.tbl_parts_info t;";
            List<string>[] listArray = new List<string>[3];
            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(3L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + listArray[0].ElementAt<string>(num) + "' and status like 'stock';";
                int num2 = int.Parse(dbc.SelectSingle(str2));
                int num3 = int.Parse(this.textBoxQty.Text);
                if (num2 <= num3)
                {
                    if (listArray[2].ElementAt<string>(num).Equals("1"))
                    {
                        this.dataGridView2.Rows.Add(new object[] { num + 1, listArray[1].ElementAt<string>(num), num2, true });
                    }
                    else
                    {
                        this.dataGridView2.Rows.Add(new object[] { num + 1, listArray[1].ElementAt<string>(num), num2, false });
                    }
                }
            }
        }

        private void search_by_item(string search_item)
        {
            int num;
            this.dataGridView2.Rows.Clear();
            string query = "SELECT partsid,partsNo,status,description FROM firoz_center.tbl_parts_info t where partsNo like '%" + search_item + "%' or description like '%" + search_item + "%';";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(4L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + listArray[0].ElementAt<string>(num) + "' and status like 'stock';";
                string str3 = dbc.SelectSingle(str2);
                if (listArray[2].ElementAt<string>(num).Equals("1"))
                {
                    this.dataGridView2.Rows.Add(new object[] { num + 1, listArray[1].ElementAt<string>(num), str3, true, listArray[3].ElementAt<string>(num) });
                }
                else
                {
                    this.dataGridView2.Rows.Add(new object[] { num + 1, listArray[1].ElementAt<string>(num), str3, false, listArray[3].ElementAt<string>(num) });
                }
            }
        }

        private void textBoxQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_parts_qty();
            }
        }

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = this.textBoxSearch.Text;
                this.search_by_item(text);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

