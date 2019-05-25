namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class DuePaymentParts : Form
    {
        private Button buttonPreview;
        private Button buttonSave;
        private IContainer components;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxNetAmount;
        private TextBox textBoxPaid;
        private TextBox textBoxPay;

        public DuePaymentParts()
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
        }

        public DuePaymentParts(string memo_no)
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
            this.textBoxMemoNo.Text = memo_no;
            this.textBoxMemoNo.Enabled = false;
            this.load_transcation();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string text = this.textBoxPay.Text;
            string s = this.textBoxPaid.Text;
            string str3 = this.textBoxDue.Text;
            double num = double.Parse(text) + double.Parse(s);
            string str4 = this.textBoxMemoNo.Text;
            string str5 = DateTime.Today.ToString("yyyy-MM-dd");
            string query = "Select customer_id from firoz_center.tbl_sales_parts where memo_no='" + str4 + "';";
            string str7 = this.dbc.SelectSingle(query);
            string str8 = "insert into firoz_center.tbl_payment (`memo_no`,`date`,`customer_id`,`amount`,`user_id`,`comments`) values ('" + str4 + "','" + str5 + "','" + str7 + "','" + text + "','1','');";
            this.dbc.Insert(str8);
            string str9 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + str4 + "','" + text + "','1','Due Parts','" + str5 + "');";
            this.dbc.Insert(str9);
            str8 = string.Concat(new object[] { "UPDATE firoz_center.tbl_sales_parts set paid_amount='", num, "',due_amount='", str3, "' where memo_no='", str4, "';" });
            this.dbc.Update(str8);
            MessageBox.Show("Due Payment Completed");
            this.buttonSave.Enabled = false;
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
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.textBoxMemoNo = new TextBox();
            this.label11 = new Label();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label19 = new Label();
            this.groupBox4 = new GroupBox();
            this.textBoxPaid = new TextBox();
            this.label1 = new Label();
            this.textBoxDue = new TextBox();
            this.label7 = new Label();
            this.textBoxPay = new TextBox();
            this.label4 = new Label();
            this.buttonPreview = new Button();
            this.buttonSave = new Button();
            this.textBoxNetAmount = new TextBox();
            this.label14 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(360, 0xb3);
            this.groupBox1.TabIndex = 0x1f;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0xf3, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x6b, 0x16);
            this.dateTimePicker1.TabIndex = 9;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xc9, 0x15);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(0x53, 20);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x70, 0x16);
            this.textBoxMemoNo.TabIndex = 1;
            this.textBoxMemoNo.KeyDown += new KeyEventHandler(this.textBoxMemoNo_KeyDown);
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x43, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Memo No";
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.Location = new Point(0x53, 0x97);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new Size(0x10b, 0x16);
            this.textBoxContact.TabIndex = 3;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x53, 0x44);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new Size(0x10b, 0x51);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x53, 0x2c);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x10b, 0x16);
            this.textBoxName.TabIndex = 1;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x97);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x44);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0x30);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x2d, 0x10);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            this.groupBox4.BackColor = Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.textBoxPaid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxDue);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPay);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonPreview);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox4.Location = new Point(5, 0xbd);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(360, 0x67);
            this.groupBox4.TabIndex = 0x15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            this.textBoxPaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPaid.Location = new Point(240, 0x11);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.ReadOnly = true;
            this.textBoxPaid.Size = new Size(110, 0x16);
            this.textBoxPaid.TabIndex = 0x25;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0xc7, 0x15);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x24, 0x10);
            this.label1.TabIndex = 0x26;
            this.label1.Text = "Paid";
            this.textBoxDue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDue.Location = new Point(240, 0x29);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new Size(110, 0x16);
            this.textBoxDue.TabIndex = 0x23;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0xca, 0x2c);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x21, 0x10);
            this.label7.TabIndex = 0x24;
            this.label7.Text = "Due";
            this.textBoxPay.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPay.Location = new Point(0x56, 0x29);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new Size(110, 0x16);
            this.textBoxPay.TabIndex = 0x1f;
            this.textBoxPay.TextChanged += new EventHandler(this.textBoxPay_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0x2d, 0x2d);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x20, 0x10);
            this.label4.TabIndex = 0x20;
            this.label4.Text = "Pay";
            this.buttonPreview.BackColor = Color.MediumSeaGreen;
            this.buttonPreview.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPreview.Location = new Point(240, 0x45);
            this.buttonPreview.MaximumSize = new Size(110, 30);
            this.buttonPreview.MinimumSize = new Size(110, 30);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new Size(110, 30);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.Text = "Print";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new EventHandler(this.buttonPreview_Click);
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x56, 0x45);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(110, 30);
            this.buttonSave.TabIndex = 0x1d;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(0x56, 0x11);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(110, 0x16);
            this.textBoxNetAmount.TabIndex = 0x16;
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x4d, 0x10);
            this.label14.TabIndex = 0x15;
            this.label14.Text = "Net Amount";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x173, 0x128);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "DuePaymentParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DuePaymentParts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_transcation()
        {
            int num;
            string text = this.textBoxMemoNo.Text;
            string query = "Select net_amount,customer_id,type,paid_amount,due_amount from firoz_center.tbl_sales_parts where memo_no='" + text + "';";
            List<string>[] listArray = new List<string>[5];
            for (num = 0; num < 5; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(5L, query);
            if (listArray[0].Count == 0)
            {
                MessageBox.Show("Search Again!");
            }
            else
            {
                query = "Select name,fathers_name,address,contact from firoz_center.tbl_customer where customer_id='" + listArray[1].ElementAt<string>(0) + "';";
                List<string>[] listArray2 = new List<string>[4];
                for (num = 0; num < 4; num++)
                {
                    listArray2[num] = new List<string>();
                }
                listArray2 = this.dbc.Select(4L, query);
                this.textBoxName.Text = listArray2[0].ElementAt<string>(0);
                this.textBoxAddress.Text = listArray2[2].ElementAt<string>(0);
                this.textBoxContact.Text = listArray2[3].ElementAt<string>(0);
                this.textBoxPaid.Text = listArray[3].ElementAt<string>(0);
                this.textBoxDue.Text = listArray[4].ElementAt<string>(0);
                this.textBoxNetAmount.Text = listArray[0].ElementAt<string>(0);
                double num2 = double.Parse(this.textBoxNetAmount.Text) - double.Parse(this.textBoxPaid.Text);
                this.textBoxDue.Text = num2.ToString();
                if (num2 == 0.0)
                {
                    this.buttonPreview.Enabled = false;
                    this.buttonSave.Enabled = false;
                }
                else
                {
                    this.buttonPreview.Enabled = true;
                    this.buttonSave.Enabled = true;
                }
            }
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_transcation();
            }
        }

        private void textBoxPay_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxPay.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxNetAmount.Text);
                double num2 = double.Parse(this.textBoxPaid.Text);
                double num3 = double.Parse(this.textBoxPay.Text);
                this.textBoxDue.Text = ((num - num2) - num3).ToString();
                if (double.Parse(this.textBoxDue.Text) > 0.0)
                {
                    this.textBoxDue.BackColor = Color.Red;
                }
                else
                {
                    this.textBoxDue.BackColor = Color.White;
                }
            }
        }
    }
}

