namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class NewOrder : Form
    {
        private Button buttonOpen;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label11;
        private Label label12;
        private TextBox textBoxInvoiceNo;

        public NewOrder()
        {
            this.InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            new AddOrder(this.textBoxInvoiceNo.Text).Show();
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
            this.groupBox1 = new GroupBox();
            this.buttonOpen = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.textBoxInvoiceNo = new TextBox();
            this.label11 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(360, 0x51);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            this.buttonOpen.BackColor = Color.MediumSeaGreen;
            this.buttonOpen.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonOpen.Location = new Point(120, 0x2d);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new Size(120, 30);
            this.buttonOpen.TabIndex = 0x1b;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new EventHandler(this.buttonOpen_Click);
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(260, 0x12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x59, 0x16);
            this.dateTimePicker1.TabIndex = 0x18;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xda, 0x16);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x1a;
            this.label12.Text = "Date";
            this.textBoxInvoiceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxInvoiceNo.Location = new Point(0x63, 0x13);
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
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(370, 0x5b);
            base.Controls.Add(this.groupBox1);
            base.Name = "NewOrder";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_data()
        {
            if (this.load_status() == 1)
            {
                base.Dispose();
            }
            else
            {
                string str2;
                string str3;
                string query = "SELECT max(order_id) FROM firoz_center.tbl_purchase_order t;";
                if (this.dbc.Count(query) == -1L)
                {
                    this.textBoxInvoiceNo.Text = "990001";
                    str2 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    str3 = "Insert into firoz_center.tbl_purchase_order(`order_id`,`opening_date`,`status`) values ('" + this.textBoxInvoiceNo.Text + "','" + str2 + "','1')";
                    this.dbc.Insert(str3);
                    this.buttonOpen.Enabled = true;
                }
                else
                {
                    string str4 = "SELECT max(order_id) FROM firoz_center.tbl_purchase_order t;";
                    this.textBoxInvoiceNo.Text = (long.Parse(this.dbc.SelectSingle(str4)) + 1L).ToString();
                    str2 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    str3 = "Insert into firoz_center.tbl_purchase_order(`order_id`,`opening_date`,`status`) values ('" + this.textBoxInvoiceNo.Text + "','" + str2 + "','1')";
                    this.dbc.Insert(str3);
                    this.buttonOpen.Enabled = true;
                }
            }
        }

        private int load_status()
        {
            string query = "SELECT status FROM firoz_center.tbl_purchase_order t where status='1';";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Open a new order");
                this.buttonOpen.Enabled = true;
                return 0;
            }
            MessageBox.Show("An order is already open");
            return 1;
        }
    }
}

