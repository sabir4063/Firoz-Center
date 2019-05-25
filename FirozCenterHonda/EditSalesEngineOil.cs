namespace FirozCenterHonda
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EditSalesEngineOil : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonAdd;
        private Button buttonUpdate;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private SolidBrush drawBrush = new SolidBrush(Color.Black);
        private Font fontDate = new Font("Serpentine-Bold", 8f);
        private Font fontSubHeading = new Font("Serpentine-Bold", 14f);
        private Font fontTitle = new Font("Serpentine-Bold", 10f);
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private RadioButton radioButtonD;
        private RadioButton radioButtonR;
        private RadioButton radioButtonW;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private int tag = 0;
        private TextBox textBoxAddress;
        private TextBox textBoxAvailable;
        private TextBox textBoxContact;
        private TextBox textBoxCurrentPrice;
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxPaid;
        private TextBox textBoxSell;
        private TextBox textBoxTotal;

        public EditSalesEngineOil()
        {
            this.InitializeComponent();
        }

        private void add_item()
        {
            string text = this.textBoxSell.Text;
            string s = this.textBoxCurrentPrice.Text;
            if (text.Equals(""))
            {
                MessageBox.Show("Check Quantity");
            }
            else
            {
                long num = long.Parse(this.textBoxSell.Text);
                long num2 = long.Parse(this.textBoxAvailable.Text);
                if (num > num2)
                {
                    MessageBox.Show("Check Quantity");
                }
                else if (s.Equals(""))
                {
                    MessageBox.Show("Check Price");
                }
                else
                {
                    string str3 = (long.Parse(text) * long.Parse(s)).ToString();
                    this.textBoxTotal.Text = str3.ToString();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.add_item();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if ((this.textBoxName.Text.Equals("") || this.textBoxDue.Text.Equals("")) || this.textBoxPaid.Text.Equals(""))
            {
                MessageBox.Show("Please Check All Required Field!");
            }
            else if (long.Parse(this.textBoxDue.Text) < 0L)
            {
                MessageBox.Show("Please Check Paid Amount!");
            }
            else
            {
                this.print_preview();
                if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.save_transcation();
                    this.tag = 1;
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = false;
                    this.textBoxPaid.Enabled = false;
                }
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
            this.buttonUpdate = new Button();
            this.textBoxDue = new TextBox();
            this.label7 = new Label();
            this.label5 = new Label();
            this.groupBox3 = new GroupBox();
            this.textBoxPaid = new TextBox();
            this.radioButtonW = new RadioButton();
            this.radioButtonD = new RadioButton();
            this.radioButtonR = new RadioButton();
            this.buttonAdd = new Button();
            this.label8 = new Label();
            this.textBoxTotal = new TextBox();
            this.label6 = new Label();
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
            this.panel1 = new Panel();
            this.label4 = new Label();
            this.textBoxSell = new TextBox();
            this.label1 = new Label();
            this.textBoxAvailable = new TextBox();
            this.label9 = new Label();
            this.groupBox2 = new GroupBox();
            this.textBoxCurrentPrice = new TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.buttonUpdate.BackColor = Color.FromArgb(0xff, 0x80, 0);
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0x95, 0x34);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(120, 30);
            this.buttonUpdate.TabIndex = 0x6d;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            this.textBoxDue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDue.Location = new Point(0x11e, 0x15);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new Size(0x73, 0x16);
            this.textBoxDue.TabIndex = 0x6a;
            this.textBoxDue.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0xdf, 0x19);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x21, 0x10);
            this.label7.TabIndex = 0x6b;
            this.label7.Text = "Due";
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(11, 0x19);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x24, 0x10);
            this.label5.TabIndex = 0x69;
            this.label5.Text = "Paid";
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.textBoxDue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxPaid);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(5, 0x138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x19d, 90);
            this.groupBox3.TabIndex = 0x24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sale";
            this.textBoxPaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPaid.Location = new Point(0x53, 0x16);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new Size(0x81, 0x16);
            this.textBoxPaid.TabIndex = 0x68;
            this.textBoxPaid.TextAlign = HorizontalAlignment.Right;
            this.textBoxPaid.TextChanged += new EventHandler(this.textBoxPaid_TextChanged);
            this.radioButtonW.AutoSize = true;
            this.radioButtonW.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.radioButtonW.Location = new Point(0xc1, 2);
            this.radioButtonW.Name = "radioButtonW";
            this.radioButtonW.Size = new Size(0x5c, 20);
            this.radioButtonW.TabIndex = 4;
            this.radioButtonW.TabStop = true;
            this.radioButtonW.Text = "Wholesale";
            this.radioButtonW.UseVisualStyleBackColor = true;
            this.radioButtonW.CheckedChanged += new EventHandler(this.radioButtonW_CheckedChanged);
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.radioButtonD.Location = new Point(0x4c, 1);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new Size(0x5e, 20);
            this.radioButtonD.TabIndex = 3;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Distributor";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new EventHandler(this.radioButtonD_CheckedChanged);
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.radioButtonR.Location = new Point(3, 1);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new Size(0x3e, 20);
            this.radioButtonR.TabIndex = 2;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "Retail";
            this.radioButtonR.UseVisualStyleBackColor = true;
            this.radioButtonR.CheckedChanged += new EventHandler(this.radioButtonR_CheckedChanged);
            this.buttonAdd.BackColor = Color.FromArgb(0xff, 0x80, 0);
            this.buttonAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonAdd.Location = new Point(0x95, 0x65);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(120, 30);
            this.buttonAdd.TabIndex = 0x6f;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(0xdf, 0x4e);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x27, 0x10);
            this.label8.TabIndex = 0x66;
            this.label8.Text = "Total";
            this.textBoxTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTotal.Location = new Point(0x110, 0x4b);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new Size(0x81, 0x16);
            this.textBoxTotal.TabIndex = 0x65;
            this.textBoxTotal.TextAlign = HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(0xe4, 0x4e);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0, 0x10);
            this.label6.TabIndex = 100;
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
            this.groupBox1.Size = new Size(0x19d, 0x9e);
            this.groupBox1.TabIndex = 0x22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x129, 0x13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x68, 0x16);
            this.dateTimePicker1.TabIndex = 2;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xfe, 20);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(0x53, 0x13);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x71, 0x16);
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
            this.textBoxContact.Location = new Point(0x53, 0x7f);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x13e, 0x16);
            this.textBoxContact.TabIndex = 6;
            this.textBoxContact.TabStop = false;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x53, 0x47);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x13e, 0x36);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x53, 0x2f);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x13e, 0x16);
            this.textBoxName.TabIndex = 4;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x7f);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x47);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0x33);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x2d, 0x10);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            this.panel1.Controls.Add(this.radioButtonW);
            this.panel1.Controls.Add(this.radioButtonD);
            this.panel1.Controls.Add(this.radioButtonR);
            this.panel1.Location = new Point(0x53, 0x2f);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x139, 0x19);
            this.panel1.TabIndex = 0x63;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0x31);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x27, 0x10);
            this.label4.TabIndex = 0x62;
            this.label4.Text = "Price";
            this.textBoxSell.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSell.Location = new Point(0x110, 0x16);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.Size = new Size(0x81, 0x16);
            this.textBoxSell.TabIndex = 9;
            this.textBoxSell.TextAlign = HorizontalAlignment.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0xdf, 0x19);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x1f, 0x10);
            this.label1.TabIndex = 0x15;
            this.label1.Text = "Sell";
            this.textBoxAvailable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAvailable.Location = new Point(0x53, 0x16);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.ReadOnly = true;
            this.textBoxAvailable.Size = new Size(0x81, 0x16);
            this.textBoxAvailable.TabIndex = 20;
            this.textBoxAvailable.TextAlign = HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x16);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x41, 0x10);
            this.label9.TabIndex = 10;
            this.label9.Text = "Available";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxSell);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxAvailable);
            this.groupBox2.Controls.Add(this.textBoxCurrentPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 0xa9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x19d, 0x89);
            this.groupBox2.TabIndex = 0x23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            this.textBoxCurrentPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCurrentPrice.Location = new Point(0x53, 0x4b);
            this.textBoxCurrentPrice.Name = "textBoxCurrentPrice";
            this.textBoxCurrentPrice.ReadOnly = true;
            this.textBoxCurrentPrice.Size = new Size(0x81, 0x16);
            this.textBoxCurrentPrice.TabIndex = 0x61;
            this.textBoxCurrentPrice.TextAlign = HorizontalAlignment.Right;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1a8, 0x197);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox2);
            base.Name = "EditSalesEngineOil";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Edit Sales Engine Oil";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_price()
        {
            string query = "";
            query = "SELECT sale_price FROM firoz_center.tbl_parts_info t where partsId='2347' and ORDER BY DATE DESC LIMIT 1;";
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxCurrentPrice.Text = str2;
        }

        private void load_price(string type)
        {
            string query = "";
            if (type.Equals("R"))
            {
                query = "SELECT sale_price FROM firoz_center.tbl_parts_info t where partsId='2347' ORDER BY DATE DESC LIMIT 1;";
            }
            else if (type.Equals("W"))
            {
                query = "SELECT wholesale_price FROM firoz_center.tbl_parts_info t where partsId='2347' ORDER BY DATE DESC LIMIT 1;";
            }
            else if (type.Equals("D"))
            {
                query = "SELECT distributor_price FROM firoz_center.tbl_parts_info t where partsId='2347' ORDER BY DATE DESC LIMIT 1;";
            }
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxCurrentPrice.Text = str2;
        }

        private void load_quantity()
        {
            this.textBoxAvailable.Text = "";
            string str = "2347";
            string query = "Select count(*) FROM firoz_center.tbl_parts where partsId='" + str + "' and status ='stock'";
            this.textBoxAvailable.Text = long.Parse(this.dbc.SelectSingle(query)).ToString();
        }

        private void load_transcation()
        {
            string text = this.textBoxMemoNo.Text;
            string query = "Select net_amount,customer_id,type,paid_amount,due_amount,comments,grand_total,discount from firoz_center.tbl_sales_parts where memo_no='" + text + "' and type='Sales Engine Oil';";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Invalid Memo No");
            }
            else
            {
                int num2;
                List<string>[] listArray = new List<string>[8];
                for (num2 = 0; num2 < 8; num2++)
                {
                    listArray[num2] = new List<string>();
                }
                listArray = this.dbc.Select(8L, query);
                this.textBoxPaid.Text = listArray[3].ElementAt<string>(0);
                this.textBoxDue.Text = listArray[4].ElementAt<string>(0);
                this.textBoxTotal.Text = listArray[6].ElementAt<string>(0);
                query = "Select name,address,contact from firoz_center.tbl_customer where customer_id='" + listArray[1].ElementAt<string>(0) + "';";
                List<string>[] listArray2 = new List<string>[3];
                for (num2 = 0; num2 < 3; num2++)
                {
                    listArray2[num2] = new List<string>();
                }
                listArray2 = this.dbc.Select(3L, query);
                this.textBoxName.Text = listArray2[0].ElementAt<string>(0);
                this.textBoxAddress.Text = listArray2[1].ElementAt<string>(0);
                this.textBoxContact.Text = listArray2[2].ElementAt<string>(0);
                string s = this.dbc.SelectSingle("Select DATE_FORMAT(date, '%Y-%m-%d') from firoz_center.tbl_sales_parts where memo_no='" + text + "';");
                this.dateTimePicker1.Value = DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                this.load_quantity();
            }
        }

        private void print_preview()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            document.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                this.strFormat = new StringFormat();
                this.strFormat.Alignment = StringAlignment.Near;
                this.strFormat.LineAlignment = StringAlignment.Center;
                this.strFormat.Trimming = StringTrimming.EllipsisCharacter;
                this.arrColumnLefts.Clear();
                this.arrColumnWidths.Clear();
                this.iCellHeight = 0;
                this.iRow = 0;
                this.bFirstPage = true;
                this.bNewPage = true;
                this.iTotalWidth = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int y = 10;
                Font font = new Font("Serpentine-Bold", 18f, FontStyle.Bold);
                this.sfMiddle.Alignment = StringAlignment.Center;
                this.sfMiddle.LineAlignment = StringAlignment.Center;
                this.sfLeft.Alignment = StringAlignment.Near;
                this.sfLeft.LineAlignment = StringAlignment.Center;
                this.sfRight.Alignment = StringAlignment.Far;
                this.sfRight.LineAlignment = StringAlignment.Center;
                DateTime now = new DateTime();
                now = DateTime.Now;
                string str = string.Format("{0:dd-MMM-yyyy}", now);
                string str2 = this.dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                e.Graphics.DrawString("Firoz Motors", font, this.drawBrush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                y += 30;
                e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", this.fontSubHeading, this.drawBrush, new Rectangle(15, y, 800, this.fontSubHeading.Height), this.sfMiddle);
                y += 0x19;
                e.Graphics.DrawString("Invoice No :: " + this.textBoxMemoNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                y += 15;
                e.Graphics.DrawString("Date :: " + str2, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                y += 30;
                e.Graphics.DrawString("Print Date:" + str, this.fontDate, this.drawBrush, new Rectangle(15, 10, 150, this.fontDate.Height), this.sfMiddle);
                e.Graphics.DrawString("Name: " + this.textBoxName.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontTitle.Height), this.sfLeft);
                y += 20;
                e.Graphics.DrawString("Address: " + this.textBoxAddress.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontTitle.Height), this.sfLeft);
                y += 20;
                e.Graphics.DrawString("Contact: " + this.textBoxContact.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontTitle.Height), this.sfLeft);
                y += 20;
                e.Graphics.DrawString("Total Amount (In words): " + this.dbc.NumberToText(this.textBoxTotal.Text) + "Taka", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontSubHeading.Height), this.sfLeft);
                e.Graphics.DrawString("Net Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxTotal.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Discount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxTotal.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Total Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxTotal.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Paid Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxPaid.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Due Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxDue.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 150;
                e.Graphics.DrawString("Signature\nCustomer", this.fontTitle, this.drawBrush, new Rectangle(50, y, 650, this.fontTitle.Height * 3), this.sfLeft);
                e.Graphics.DrawString("Signature\nFiroz Motors", this.fontTitle, this.drawBrush, new Rectangle(50, y, 700, this.fontTitle.Height * 3), this.sfRight);
                y += 50;
                e.Graphics.DrawString("** Sold product will not be taken back **", this.fontDate, this.drawBrush, new Rectangle(0x19, y, 700, this.fontDate.Height), this.sfMiddle);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("D");
        }

        private void radioButtonR_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("R");
        }

        private void radioButtonW_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("W");
        }

        private void save_transcation()
        {
            string text = this.textBoxMemoNo.Text;
            string query = "UPDATE firoz_center.tbl_parts set status='stock',memo_no=null where memo_no='" + text + "';";
            this.dbc.Update(query);
            string str3 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str4 = "2347";
            string s = this.textBoxSell.Text;
            string str6 = this.textBoxCurrentPrice.Text;
            for (int i = 0; i < int.Parse(s); i++)
            {
                string str7 = "update firoz_center.tbl_parts set `sale_rate`='" + str6 + "',`status`='sold',memo_no='" + text + "' where partsid ='" + str4 + "' and status like '%stock%' limit 1; ";
                this.dbc.Update(str7);
            }
            string str8 = "Update firoz_center.tbl_sales_parts set `comments`='Updated', `date`='" + str3 + "', grand_total='" + this.textBoxTotal.Text + "',net_amount='" + this.textBoxTotal.Text + "',paid_amount='" + this.textBoxPaid.Text + "',due_amount='" + this.textBoxDue.Text + "', discount='0' where memo_no='" + this.textBoxMemoNo.Text + "';";
            this.dbc.Update(str8);
            str8 = "update firoz_center.tbl_transcation set `date`='" + str3 + "', debit='" + this.textBoxPaid.Text + "' where memo_no='" + this.textBoxMemoNo.Text + "';";
            this.dbc.Update(str8);
            str8 = "update firoz_center.tbl_payment set `date`='" + str3 + "', amount='" + this.textBoxPaid.Text + "' where memo_no='" + this.textBoxMemoNo.Text + "';";
            this.dbc.Update(str8);
            MessageBox.Show("Update Completed");
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBoxMemoNo.Text.Equals(""))
                {
                    MessageBox.Show("Please Search Again!");
                }
                else
                {
                    e.SuppressKeyPress = true;
                    this.load_transcation();
                }
            }
        }

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxTotal.Text.Equals("") && !this.textBoxPaid.Text.Equals(""))
            {
                if (this.textBoxPaid.Text.Equals(""))
                {
                    this.textBoxDue.Text = this.textBoxTotal.Text;
                }
                else
                {
                    double num = double.Parse(this.textBoxTotal.Text);
                    double num2 = double.Parse(this.textBoxPaid.Text);
                    this.textBoxDue.Text = (num - num2).ToString();
                    if (num2 > num)
                    {
                        MessageBox.Show("Check Paid Amount");
                    }
                    else if (num2 < num)
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
}

