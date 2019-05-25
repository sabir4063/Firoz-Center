namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class NewSalesMotorCycle : Form
    {
        private Button button1;
        private Button buttonChalan;
        private Button buttonInvoice;
        private Button buttonSave;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxChassisNo;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private ComboBox comboBoxParty;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
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
        private List<string>[] Party = new List<string>[7];
        private int tag = 0;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxDue;
        private TextBox textBoxEngineNo;
        private TextBox textBoxFName;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxPaid;
        private TextBox textBoxPrice;
        private List<string>[] Vehicle = new List<string>[6];

        public NewSalesMotorCycle()
        {
            this.InitializeComponent();
            this.load_party();
            this.load_brand();
            string query = "SELECT max(memo_no) FROM firoz_center.tbl_sales_motorcycle t;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxMemoNo.Text = "10000001";
            }
            else
            {
                string str2 = "SELECT max(memo_no) FROM firoz_center.tbl_sales_motorcycle t;";
                this.textBoxMemoNo.Text = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }
            this.comboBoxBrand.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
                MessageBox.Show("Please save sale");
            }
            else if (MessageBox.Show("Do you want to print Chalan?", "Print Chalan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_chalan();
                this.buttonChalan.BackColor = Color.Yellow;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            base.Dispose();
            new NewSalesMotorCycle().Show();
        }

        private void buttonAddNewParty_Click(object sender, EventArgs e)
        {
            new AddNewCustomer().Show();
            base.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.load_brand();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (((this.textBoxName.Text.Equals("") || this.textBoxFName.Text.Equals("")) || (this.textBoxAddress.Text.Equals("") || this.textBoxDue.Text.Equals(""))) || this.textBoxPaid.Text.Equals(""))
            {
                MessageBox.Show("Please Check All Required Field!");
            }
            else if (long.Parse(this.textBoxDue.Text) < 0L)
            {
                MessageBox.Show("Please Check Paid Amount!");
            }
            else
            {
                this.print_preview_invoice();
                if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.save_sales();
                    this.tag = 1;
                    this.buttonSave.BackColor = Color.Yellow;
                    this.buttonSave.Enabled = false;
                }
            }
        }

        private void buttonPrlong_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
                MessageBox.Show("Please save sale");
            }
            else if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_invoice();
                this.buttonInvoice.BackColor = Color.Yellow;
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
        }

        private void comboBoxChassisNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_engine_no();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_chassis_no();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string str = textInfo.ToTitleCase(this.textBoxName.Text);
            this.textBoxName.Text = str;
            string str2 = textInfo.ToTitleCase(this.textBoxFName.Text);
            this.textBoxFName.Text = str2;
            string str3 = textInfo.ToTitleCase(this.textBoxAddress.Text);
            this.textBoxAddress.Text = str3;
            this.load_cc();
            this.comboBoxCC.SelectedIndex = 0;
            this.load_price();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Party[1].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxFName.Text = this.Party[6].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxAddress.Text = this.Party[2].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxContact.Text = this.Party[3].ElementAt<string>(this.comboBoxParty.SelectedIndex);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Doc_PrintPreview_Chalan(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Serpentine-Bold", 14f);
            SolidBrush brush = new SolidBrush(Color.Black);
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string s = this.dateTimePicker1.Value.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
            string text = this.textBoxName.Text;
            string str4 = this.textBoxFName.Text;
            string str5 = this.textBoxAddress.Text;
            string str6 = this.textBoxContact.Text;
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 140f, (float) 160f);
            e.Graphics.DrawString(s, font, brush, (float) 530f, (float) 160f);
            e.Graphics.DrawString(text, font, brush, (float) 140f, (float) 205f);
            e.Graphics.DrawString(str6, font, brush, (float) 530f, (float) 205f);
            e.Graphics.DrawString(str4, font, brush, (float) 140f, (float) 240f);
            if (str5.Length >= 50)
            {
                int index = str5.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str5.Length;
                }
                e.Graphics.DrawString(str5.Substring(0, index), font, brush, (float) 140f, (float) 280f);
                if (index != str5.Length)
                {
                    e.Graphics.DrawString(str5.Substring(index + 1), font, brush, (float) 140f, (float) 315f);
                }
            }
            else
            {
                e.Graphics.DrawString(str5, font, brush, (float) 140f, (float) 280f);
            }
            e.Graphics.DrawString(this.comboBoxBrand.SelectedItem.ToString() + " " + this.comboBoxModel.SelectedItem.ToString() + " " + this.comboBoxCC.SelectedItem.ToString() + " CC", font, brush, (float) 140f, (float) 380f);
            e.Graphics.DrawString(this.comboBoxChassisNo.SelectedItem.ToString(), font, brush, (float) 140f, (float) 460f);
            e.Graphics.DrawString(this.textBoxEngineNo.Text, font, brush, (float) 140f, (float) 540f);
            e.Graphics.DrawString(this.comboBoxColor.SelectedItem.ToString(), font, brush, (float) 140f, (float) 620f);
        }

        private void Doc_PrintPreview_Invoice(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Serpentine-Bold", 14f);
            SolidBrush brush = new SolidBrush(Color.Black);
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string s = this.dateTimePicker1.Value.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
            string text = this.textBoxName.Text;
            string str4 = this.textBoxFName.Text;
            string str5 = this.textBoxAddress.Text;
            string str6 = this.textBoxContact.Text;
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 140f, (float) 120f);
            e.Graphics.DrawString(s, font, brush, (float) 530f, (float) 120f);
            e.Graphics.DrawString(text, font, brush, (float) 140f, (float) 165f);
            e.Graphics.DrawString(str6, font, brush, (float) 530f, (float) 165f);
            e.Graphics.DrawString(str4, font, brush, (float) 140f, (float) 205f);
            if (str5.Length >= 50)
            {
                int index = str5.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str5.Length;
                }
                e.Graphics.DrawString(str5.Substring(0, index), font, brush, (float) 140f, (float) 245f);
                if (index != str5.Length)
                {
                    e.Graphics.DrawString(str5.Substring(index + 1), font, brush, (float) 140f, (float) 285f);
                }
            }
            else
            {
                e.Graphics.DrawString(str5, font, brush, (float) 140f, (float) 245f);
            }
            e.Graphics.DrawString(this.comboBoxBrand.SelectedItem.ToString() + " " + this.comboBoxModel.SelectedItem.ToString(), font, brush, (float) 140f, (float) 450f);
            e.Graphics.DrawString(this.textBoxEngineNo.Text, font, brush, (float) 140f, (float) 535f);
            e.Graphics.DrawString(this.comboBoxChassisNo.SelectedItem.ToString(), font, brush, (float) 140f, (float) 585f);
            e.Graphics.DrawString(this.comboBoxColor.SelectedItem.ToString(), font, brush, (float) 140f, (float) 640f);
            e.Graphics.DrawString(this.comboBoxCC.SelectedItem.ToString(), font, brush, (float) 380f, (float) 640f);
            e.Graphics.DrawString(this.comboBoxModel.SelectedItem.ToString(), font, brush, (float) 380f, (float) 700f);
            e.Graphics.DrawString(this.textBoxPrice.Text, font, brush, (float) 570f, (float) 700f);
            e.Graphics.DrawString(this.dbc.NumberToText(this.textBoxPrice.Text), font, brush, (float) 140f, (float) 725f);
        }

        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMemoNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxParty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.buttonChalan = new System.Windows.Forms.Button();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxEngineNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxChassisNo = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxCC = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 41);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date";
            // 
            // textBoxMemoNo
            // 
            this.textBoxMemoNo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMemoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemoNo.Location = new System.Drawing.Point(120, 17);
            this.textBoxMemoNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.ReadOnly = true;
            this.textBoxMemoNo.Size = new System.Drawing.Size(105, 22);
            this.textBoxMemoNo.TabIndex = 1;
            this.textBoxMemoNo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Memo No";
            // 
            // textBoxContact
            // 
            this.textBoxContact.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(120, 256);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(300, 22);
            this.textBoxContact.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(120, 139);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(300, 115);
            this.textBoxAddress.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(120, 91);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.comboBoxParty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(430, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 20;
            this.button1.TabStop = false;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxFName
            // 
            this.textBoxFName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.Location = new System.Drawing.Point(120, 115);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(300, 22);
            this.textBoxFName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Father\'s Name";
            // 
            // comboBoxParty
            // 
            this.comboBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(120, 65);
            this.comboBoxParty.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(300, 24);
            this.comboBoxParty.TabIndex = 3;
            this.comboBoxParty.SelectedIndexChanged += new System.EventHandler(this.comboBoxParty_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxDue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxPaid);
            this.groupBox2.Controls.Add(this.buttonChalan);
            this.groupBox2.Controls.Add(this.buttonInvoice);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.textBoxEngineNo);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.comboBoxChassisNo);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.comboBoxCC);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(440, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(416, 285);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Due";
            // 
            // textBoxDue
            // 
            this.textBoxDue.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDue.Location = new System.Drawing.Point(105, 217);
            this.textBoxDue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new System.Drawing.Size(300, 22);
            this.textBoxDue.TabIndex = 16;
            this.textBoxDue.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Paid";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaid.Location = new System.Drawing.Point(105, 193);
            this.textBoxPaid.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(300, 22);
            this.textBoxPaid.TabIndex = 15;
            this.textBoxPaid.TextChanged += new System.EventHandler(this.textBoxPaid_TextChanged);
            // 
            // buttonChalan
            // 
            this.buttonChalan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonChalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChalan.Location = new System.Drawing.Point(285, 243);
            this.buttonChalan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChalan.Name = "buttonChalan";
            this.buttonChalan.Size = new System.Drawing.Size(120, 30);
            this.buttonChalan.TabIndex = 19;
            this.buttonChalan.TabStop = false;
            this.buttonChalan.Text = "Chalan";
            this.buttonChalan.UseVisualStyleBackColor = false;
            this.buttonChalan.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoice.Location = new System.Drawing.Point(147, 243);
            this.buttonInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(120, 30);
            this.buttonInvoice.TabIndex = 18;
            this.buttonInvoice.TabStop = false;
            this.buttonInvoice.Text = "Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = false;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonPrlong_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 175);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(105, 169);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(300, 22);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.TabStop = false;
            // 
            // textBoxEngineNo
            // 
            this.textBoxEngineNo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEngineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngineNo.Location = new System.Drawing.Point(105, 145);
            this.textBoxEngineNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEngineNo.Name = "textBoxEngineNo";
            this.textBoxEngineNo.ReadOnly = true;
            this.textBoxEngineNo.Size = new System.Drawing.Size(300, 22);
            this.textBoxEngineNo.TabIndex = 13;
            this.textBoxEngineNo.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 149);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Engine No";
            // 
            // comboBoxChassisNo
            // 
            this.comboBoxChassisNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxChassisNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxChassisNo.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxChassisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChassisNo.FormattingEnabled = true;
            this.comboBoxChassisNo.Location = new System.Drawing.Point(105, 119);
            this.comboBoxChassisNo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChassisNo.Name = "comboBoxChassisNo";
            this.comboBoxChassisNo.Size = new System.Drawing.Size(300, 24);
            this.comboBoxChassisNo.TabIndex = 12;
            this.comboBoxChassisNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxChassisNo_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(7, 243);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chassis No";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(105, 93);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(300, 24);
            this.comboBoxColor.TabIndex = 11;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // comboBoxCC
            // 
            this.comboBoxCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new System.Drawing.Point(105, 67);
            this.comboBoxCC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new System.Drawing.Size(300, 24);
            this.comboBoxCC.TabIndex = 10;
            this.comboBoxCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCC_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(105, 41);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(300, 24);
            this.comboBoxModel.TabIndex = 9;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(105, 15);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(300, 24);
            this.comboBoxBrand.TabIndex = 8;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "CC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Brand";
            // 
            // NewSalesMotorCycle
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(861, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewSalesMotorCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleSalesNew";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
            this.textBoxPrice.Text = "";
            string query = "SELECT brand FROM firoz_center.tbl_vehicle_info t group by brand;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxBrand.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_cc()
        {
            int num;
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
            this.textBoxPrice.Text = "";
            string query = "SELECT cc FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' group by cc;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxCC.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_chassis_no()
        {
            int num;
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT chasis_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and status='stock';";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, str3);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxChassisNo.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_color()
        {
            int num;
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
            this.textBoxPrice.Text = "";
            string query = "SELECT color FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' group by color;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxColor.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_engine_no()
        {
            this.textBoxEngineNo.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT engine_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';";
            string str4 = this.dbc.SelectSingle(str3);
            this.textBoxEngineNo.Text = str4;
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
            this.textBoxPrice.Text = "";
            string query = "SELECT model FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' group by model;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxModel.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            string query = "SELECT * FROM firoz_center.tbl_customer t where type='1' order by customer_id;";
            for (num = 0; num < 7; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(7L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_price()
        {
            string query = "Select sale_price from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxPrice.Text = str2;
        }

        private void print_preview_chalan()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_Chalan);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void print_preview_invoice()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_Invoice);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void save_sales()
        {
            string text = this.textBoxName.Text;
            string str2 = this.textBoxFName.Text;
            string str3 = this.textBoxAddress.Text;
            string str4 = this.textBoxContact.Text;
            string str5 = this.comboBoxBrand.SelectedItem.ToString();
            string str6 = this.comboBoxModel.SelectedItem.ToString();
            string str7 = this.comboBoxCC.SelectedItem.ToString();
            string str8 = this.comboBoxColor.SelectedItem.ToString();
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where brand='" + str5 + "' and model='" + str6 + "' and cc='" + str7 + "' and color='" + str8 + "'; ";
            string str10 = this.dbc.SelectSingle(query);
            string str11 = this.comboBoxChassisNo.SelectedItem.ToString();
            string str12 = this.textBoxEngineNo.Text;
            string str13 = this.textBoxPrice.Text;
            string str14 = this.textBoxMemoNo.Text;
            string str15 = this.textBoxPaid.Text;
            string str16 = this.textBoxDue.Text;
            string str17 = "Select id from firoz_center.tbl_vehicle where vehicleid = '" + str10 + "' and chasis_no='" + str11 + "' and engine_no='" + str12 + "' and status='stock';";
            string str18 = this.dbc.SelectSingle(str17);
            string str19 = "update firoz_center.tbl_vehicle set `sale_rate`='" + str13 + "',`status`='sold',memo_no='" + str14 + "',`comments`='sold' where id ='" + str18 + "'; ";
            this.dbc.Update(str19);
            string str20 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str21 = "insert into firoz_center.tbl_customer (`name`,`fathers_name`,`address`,`contact`,`email`,`comments`,`type`) values ('" + text + "','" + str2 + "','" + str3 + "','" + str4 + "','','','1');";
            this.dbc.Insert(str21);
            str21 = "SELECT customer_id FROM firoz_center.tbl_customer where name='" + text + "' and address='" + str3 + "' and contact='" + str4 + "' and fathers_name='" + str2 + "';";
            string str22 = this.dbc.SelectSingle(str21);
            string str23 = "insert into firoz_center.tbl_sales_motorcycle (`memo_no`,`date`,`net_amount`,`discount`,`grand_total`,`user_id`,`customer_id`,`type`,`paid_amount`,`due_amount`) values ('" + str14 + "','" + str20 + "','" + str13 + "','0','" + str13 + "','1','" + str22 + "','Sales Motor Cycle','" + str15 + "','" + str16 + "');";
            this.dbc.Insert(str23);
            string str24 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + str14 + "','" + str15 + "','1','Sales Motor Cycle','" + str20 + "');";
            this.dbc.Insert(str24);
            string str25 = "insert into firoz_center.tbl_payment (`memo_no`,`date`,`customer_id`,`amount`,`user_id`,`comments`) values ('" + str14 + "','" + str20 + "','" + str22 + "','" + str15 + "','1','');";
            this.dbc.Insert(str25);
            MessageBox.Show("Sale Completed");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxPrice.Text.Equals("") && !this.textBoxPaid.Text.Equals(""))
            {
                if (this.textBoxPaid.Text.Equals(""))
                {
                    this.textBoxDue.Text = this.textBoxPrice.Text;
                }
                else
                {
                    double num = double.Parse(this.textBoxPrice.Text);
                    double num2 = double.Parse(this.textBoxPaid.Text);
                    this.textBoxDue.Text = (num - num2).ToString();
                    if (num2 < num)
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

