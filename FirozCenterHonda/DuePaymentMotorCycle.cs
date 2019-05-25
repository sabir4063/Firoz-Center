namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class DuePaymentMotorCycle : Form
    {
        private Button button1;
        private Button buttonSave;
        private IContainer components;
        private DBConnect dbc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private TextBox textBoxBrand;
        private TextBox textBoxCC;
        private TextBox textBoxChassis;
        private TextBox textBoxColor;
        private TextBox textBoxContact;
        private TextBox textBoxDate;
        private TextBox textBoxdue;
        private TextBox textBoxEngine;
        private TextBox textBoxFName;
        private TextBox textBoxMemoNo;
        private TextBox textBoxModel;
        private TextBox textBoxName;
        private TextBox textBoxpaid;
        private TextBox textBoxpay;
        private TextBox textBoxPrice;

        public DuePaymentMotorCycle()
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
        }

        public DuePaymentMotorCycle(string memo_no)
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
            this.textBoxMemoNo.Text = memo_no;
            this.textBoxMemoNo.Enabled = false;
            this.load_transcation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.load_transcation();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
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
            this.textBoxDate = new TextBox();
            this.textBoxChassis = new TextBox();
            this.textBoxColor = new TextBox();
            this.textBoxCC = new TextBox();
            this.textBoxFName = new TextBox();
            this.label5 = new Label();
            this.label12 = new Label();
            this.textBoxMemoNo = new TextBox();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1 = new GroupBox();
            this.button1 = new Button();
            this.label11 = new Label();
            this.textBoxName = new TextBox();
            this.textBoxModel = new TextBox();
            this.textBoxBrand = new TextBox();
            this.groupBox2 = new GroupBox();
            this.label14 = new Label();
            this.textBoxpay = new TextBox();
            this.label10 = new Label();
            this.textBoxdue = new TextBox();
            this.label4 = new Label();
            this.textBoxpaid = new TextBox();
            this.label19 = new Label();
            this.textBoxPrice = new TextBox();
            this.textBoxEngine = new TextBox();
            this.label18 = new Label();
            this.buttonSave = new Button();
            this.label9 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label13 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.textBoxDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDate.Location = new Point(120, 40);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new Size(0x87, 0x16);
            this.textBoxDate.TabIndex = 0x17;
            this.textBoxChassis.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxChassis.Location = new Point(120, 0x73);
            this.textBoxChassis.Name = "textBoxChassis";
            this.textBoxChassis.ReadOnly = true;
            this.textBoxChassis.Size = new Size(0x11c, 0x16);
            this.textBoxChassis.TabIndex = 0x20;
            this.textBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxColor.Location = new Point(120, 0x5b);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new Size(0x11c, 0x16);
            this.textBoxColor.TabIndex = 0x1f;
            this.textBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCC.Location = new Point(120, 0x43);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ReadOnly = true;
            this.textBoxCC.Size = new Size(0x11c, 0x16);
            this.textBoxCC.TabIndex = 30;
            this.textBoxFName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxFName.Location = new Point(120, 0x58);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.ReadOnly = true;
            this.textBoxFName.Size = new Size(0x11a, 0x16);
            this.textBoxFName.TabIndex = 0x16;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 0x58);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x60, 0x10);
            this.label5.TabIndex = 0x15;
            this.label5.Text = "Father's Name";
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(10, 40);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(120, 0x10);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x87, 0x16);
            this.textBoxMemoNo.TabIndex = 1;
            this.textBoxMemoNo.KeyDown += new KeyEventHandler(this.textBoxMemoNo_KeyDown);
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.Location = new Point(120, 0xf2);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new Size(0x11a, 0x16);
            this.textBoxContact.TabIndex = 8;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(120, 0x70);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new Size(0x11a, 0x80);
            this.textBoxAddress.TabIndex = 7;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0xf2);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x70);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0x40);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(420, 0x12e);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.button1.BackColor = Color.MediumSeaGreen;
            this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(270, 0x15);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 30);
            this.button1.TabIndex = 0x1c;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x43, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Memo No";
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(120, 0x40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x11a, 0x16);
            this.textBoxName.TabIndex = 6;
            this.textBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxModel.Location = new Point(120, 0x2b);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new Size(0x11c, 0x16);
            this.textBoxModel.TabIndex = 0x1d;
            this.textBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBrand.Location = new Point(120, 0x13);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.ReadOnly = true;
            this.textBoxBrand.Size = new Size(0x11c, 0x16);
            this.textBoxBrand.TabIndex = 0x1c;
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxpay);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxdue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxpaid);
            this.groupBox2.Controls.Add(this.textBoxChassis);
            this.groupBox2.Controls.Add(this.textBoxColor);
            this.groupBox2.Controls.Add(this.textBoxCC);
            this.groupBox2.Controls.Add(this.textBoxModel);
            this.groupBox2.Controls.Add(this.textBoxBrand);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.textBoxEngine);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(0x1af, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(420, 0x12e);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 0xd6);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x20, 0x10);
            this.label14.TabIndex = 0x27;
            this.label14.Text = "Pay";
            this.textBoxpay.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxpay.Location = new Point(120, 0xd3);
            this.textBoxpay.Name = "textBoxpay";
            this.textBoxpay.Size = new Size(0x11c, 0x16);
            this.textBoxpay.TabIndex = 0x26;
            this.textBoxpay.TextChanged += new EventHandler(this.textBoxpay_TextChanged);
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(10, 0xee);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x21, 0x10);
            this.label10.TabIndex = 0x25;
            this.label10.Text = "Due";
            this.textBoxdue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxdue.Location = new Point(120, 0xeb);
            this.textBoxdue.Name = "textBoxdue";
            this.textBoxdue.ReadOnly = true;
            this.textBoxdue.Size = new Size(0x11c, 0x16);
            this.textBoxdue.TabIndex = 0x24;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 190);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x24, 0x10);
            this.label4.TabIndex = 0x23;
            this.label4.Text = "Paid";
            this.textBoxpaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxpaid.Location = new Point(120, 0xbb);
            this.textBoxpaid.Name = "textBoxpaid";
            this.textBoxpaid.ReadOnly = true;
            this.textBoxpaid.Size = new Size(0x11c, 0x16);
            this.textBoxpaid.TabIndex = 0x22;
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0xa6);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x27, 0x10);
            this.label19.TabIndex = 0x1a;
            this.label19.Text = "Price";
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(120, 0xa3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new Size(0x11c, 0x16);
            this.textBoxPrice.TabIndex = 0x19;
            this.textBoxEngine.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEngine.Location = new Point(120, 0x8b);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.ReadOnly = true;
            this.textBoxEngine.Size = new Size(0x11c, 0x16);
            this.textBoxEngine.TabIndex = 0x18;
            this.label18.AutoSize = true;
            this.label18.BackColor = Color.DarkSeaGreen;
            this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label18.Location = new Point(10, 0x8e);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x47, 0x10);
            this.label18.TabIndex = 0x17;
            this.label18.Text = "Engine No";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x9a, 0x107);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x76);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x4d, 0x10);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chassis No";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x5e);
            this.label6.Name = "label6";
            this.label6.Size = new Size(40, 0x10);
            this.label6.TabIndex = 4;
            this.label6.Text = "Color";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x1a, 0x10);
            this.label7.TabIndex = 3;
            this.label7.Text = "CC";
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0x2e);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2e, 0x10);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(10, 0x16);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x2c, 0x10);
            this.label13.TabIndex = 0;
            this.label13.Text = "Brand";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x357, 0x137);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox2);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new Size(0x367, 0x15d);
            this.MinimumSize = new Size(0x367, 0x15d);
            base.Name = "DuePaymentMotorCycle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DuePayment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_transcation()
        {
            string text = this.textBoxMemoNo.Text;
            string query = "Select net_amount,customer_id,type from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Search Again!");
            }
            else
            {
                int num2;
                List<string>[] listArray = new List<string>[3];
                for (num2 = 0; num2 < 3; num2++)
                {
                    listArray[num2] = new List<string>();
                }
                listArray = this.dbc.Select(3L, query);
                if (listArray[0].Count == -1)
                {
                    MessageBox.Show("Search Again!");
                }
                else
                {
                    query = "Select name,fathers_name,address,contact from firoz_center.tbl_customer where customer_id='" + listArray[1].ElementAt<string>(0) + "';";
                    List<string>[] listArray2 = new List<string>[4];
                    for (num2 = 0; num2 < 4; num2++)
                    {
                        listArray2[num2] = new List<string>();
                    }
                    listArray2 = this.dbc.Select(4L, query);
                    this.textBoxName.Text = listArray2[0].ElementAt<string>(0);
                    this.textBoxFName.Text = listArray2[1].ElementAt<string>(0);
                    this.textBoxAddress.Text = listArray2[2].ElementAt<string>(0);
                    this.textBoxContact.Text = listArray2[3].ElementAt<string>(0);
                    query = "Select vehicleid,chasis_no,engine_no,sale_rate from firoz_center.tbl_vehicle where memo_no='" + text + "';";
                    List<string>[] listArray3 = new List<string>[4];
                    for (num2 = 0; num2 < 4; num2++)
                    {
                        listArray3[num2] = new List<string>();
                    }
                    listArray3 = this.dbc.Select(4L, query);
                    this.textBoxChassis.Text = listArray3[1].ElementAt<string>(0);
                    this.textBoxEngine.Text = listArray3[2].ElementAt<string>(0);
                    this.textBoxPrice.Text = listArray3[3].ElementAt<string>(0);
                    query = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray3[0].ElementAt<string>(0) + "';";
                    List<string>[] listArray4 = new List<string>[4];
                    for (num2 = 0; num2 < 4; num2++)
                    {
                        listArray4[num2] = new List<string>();
                    }
                    listArray4 = this.dbc.Select(4L, query);
                    this.textBoxBrand.Text = listArray4[0].ElementAt<string>(0);
                    this.textBoxModel.Text = listArray4[1].ElementAt<string>(0);
                    this.textBoxCC.Text = listArray4[2].ElementAt<string>(0);
                    this.textBoxColor.Text = listArray4[3].ElementAt<string>(0);
                    this.textBoxDate.Text = this.dbc.Select_Date("Select date from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';");
                    string str3 = "SELECT sum(amount) FROM firoz_center.tbl_payment where memo_no='" + text + "';";
                    string str4 = this.dbc.SelectSingle(str3);
                    this.textBoxpaid.Text = str4;
                    double num3 = double.Parse(this.textBoxPrice.Text) - double.Parse(this.textBoxpaid.Text);
                    this.textBoxdue.Text = num3.ToString();
                    if (num3 == 0.0)
                    {
                        this.buttonSave.Enabled = false;
                    }
                    else
                    {
                        this.buttonSave.Enabled = true;
                    }
                }
            }
        }

        private void save_transcation()
        {
            string text = this.textBoxpay.Text;
            string s = this.textBoxpaid.Text;
            string str3 = this.textBoxdue.Text;
            double num = double.Parse(text) + double.Parse(s);
            string str4 = this.textBoxMemoNo.Text;
            string str5 = DateTime.Today.ToString("yyyy-MM-dd");
            string query = "Select customer_id from firoz_center.tbl_sales_motorcycle where memo_no='" + str4 + "';";
            string str7 = this.dbc.SelectSingle(query);
            string str8 = "insert into firoz_center.tbl_payment (`memo_no`,`date`,`customer_id`,`amount`,`user_id`,`comments`) values ('" + str4 + "','" + str5 + "','" + str7 + "','" + text + "','1','');";
            this.dbc.Insert(str8);
            string str9 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + str4 + "','" + text + "','1','Due Motor Cycle','" + str5 + "');";
            this.dbc.Insert(str9);
            str8 = string.Concat(new object[] { "UPDATE firoz_center.tbl_sales_motorcycle set paid_amount='", num, "',due_amount='", str3, "' where memo_no='", str4, "';" });
            this.dbc.Update(str8);
            MessageBox.Show("Due Payment Completed");
            this.buttonSave.Enabled = false;
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_transcation();
            }
        }

        private void textBoxpay_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxpay.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPrice.Text);
                double num2 = double.Parse(this.textBoxpaid.Text) + double.Parse(this.textBoxpay.Text);
                this.textBoxdue.Text = (num - num2).ToString();
                if (num2 < num)
                {
                    this.textBoxdue.BackColor = Color.Red;
                }
                else
                {
                    this.textBoxdue.BackColor = Color.White;
                }
            }
        }
    }
}

