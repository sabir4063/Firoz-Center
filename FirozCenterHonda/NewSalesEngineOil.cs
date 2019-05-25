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

    public class NewSalesEngineOil : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonAdd;
        private Button buttonNew;
        private Button buttonPreview;
        private Button buttonSave;
        private CheckBox checkBoxNew;
        private ComboBox comboBoxParty;
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
        private List<string>[] Parts = new List<string>[6];
        private List<string>[] Party = new List<string>[7];
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
        private ComboBox comboBox1;
        private TextBox textBoxTotal;

        public NewSalesEngineOil()
        {
            this.InitializeComponent();
            this.checkBoxNew.Checked = true;
            this.load_party();
            this.load_quantity();
            string query = "SELECT max(memo_no) FROM firoz_center.tbl_sales_parts t ;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxMemoNo.Text = "10001";
            }
            else
            {
                string str2 = "SELECT max(memo_no) FROM firoz_center.tbl_sales_parts t ;";
                this.textBoxMemoNo.Text = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }
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

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            base.Dispose();
            new NewSalesEngineOil().Show();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
                MessageBox.Show("Please save sale");
            }
            else if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
                this.buttonPreview.BackColor = Color.Yellow;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
                    this.buttonSave.BackColor = Color.Yellow;
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = false;
                    this.buttonSave.Enabled = false;
                    this.buttonNew.Enabled = true;
                    this.textBoxPaid.Enabled = false;
                }
            }
        }

        private void checkBoxNew_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxNew.Checked.Equals(true))
            {
                this.textBoxName.Enabled = true;
                this.textBoxAddress.Enabled = true;
                this.textBoxContact.Enabled = true;
                this.comboBoxParty.Enabled = false;
            }
            else
            {
                this.textBoxName.Enabled = false;
                this.textBoxAddress.Enabled = false;
                this.textBoxContact.Enabled = false;
                this.comboBoxParty.Enabled = true;
            }
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Party[1].ElementAt<string>(this.comboBoxParty.SelectedIndex);
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

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMemoNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxParty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonW = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAvailable = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBoxNew);
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
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 182);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.AutoSize = true;
            this.checkBoxNew.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNew.Location = new System.Drawing.Point(199, 19);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(55, 20);
            this.checkBoxNew.TabIndex = 1;
            this.checkBoxNew.Text = "New";
            this.checkBoxNew.UseVisualStyleBackColor = true;
            this.checkBoxNew.CheckedChanged += new System.EventHandler(this.checkBoxNew_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(254, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date";
            // 
            // textBoxMemoNo
            // 
            this.textBoxMemoNo.Enabled = false;
            this.textBoxMemoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemoNo.Location = new System.Drawing.Point(83, 19);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.ReadOnly = true;
            this.textBoxMemoNo.Size = new System.Drawing.Size(113, 22);
            this.textBoxMemoNo.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Memo No";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(83, 149);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(145, 22);
            this.textBoxContact.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(83, 93);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(318, 54);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(83, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(318, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // comboBoxParty
            // 
            this.comboBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(83, 43);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(318, 24);
            this.comboBoxParty.TabIndex = 3;
            this.comboBoxParty.SelectedIndexChanged += new System.EventHandler(this.comboBoxParty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 149);
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
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 137);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(149, 101);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 30);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(272, 75);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(129, 22);
            this.textBoxTotal.TabIndex = 101;
            this.textBoxTotal.TabStop = false;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonW);
            this.panel1.Controls.Add(this.radioButtonD);
            this.panel1.Controls.Add(this.radioButtonR);
            this.panel1.Location = new System.Drawing.Point(83, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 25);
            this.panel1.TabIndex = 10;
            this.panel1.TabStop = true;
            // 
            // radioButtonW
            // 
            this.radioButtonW.AutoSize = true;
            this.radioButtonW.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonW.Location = new System.Drawing.Point(193, 2);
            this.radioButtonW.Name = "radioButtonW";
            this.radioButtonW.Size = new System.Drawing.Size(92, 20);
            this.radioButtonW.TabIndex = 4;
            this.radioButtonW.TabStop = true;
            this.radioButtonW.Text = "Wholesale";
            this.radioButtonW.UseVisualStyleBackColor = true;
            this.radioButtonW.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonD.Location = new System.Drawing.Point(76, 1);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(94, 20);
            this.radioButtonD.TabIndex = 3;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Distributor";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonR.Location = new System.Drawing.Point(3, 1);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(62, 20);
            this.radioButtonR.TabIndex = 2;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "Retail";
            this.radioButtonR.UseVisualStyleBackColor = true;
            this.radioButtonR.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Price";
            // 
            // textBoxSell
            // 
            this.textBoxSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSell.Location = new System.Drawing.Point(272, 22);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.Size = new System.Drawing.Size(129, 22);
            this.textBoxSell.TabIndex = 9;
            this.textBoxSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sell";
            // 
            // textBoxAvailable
            // 
            this.textBoxAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailable.Location = new System.Drawing.Point(83, 22);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.ReadOnly = true;
            this.textBoxAvailable.Size = new System.Drawing.Size(129, 22);
            this.textBoxAvailable.TabIndex = 20;
            this.textBoxAvailable.TabStop = false;
            this.textBoxAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCurrentPrice
            // 
            this.textBoxCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPrice.Location = new System.Drawing.Point(83, 75);
            this.textBoxCurrentPrice.Name = "textBoxCurrentPrice";
            this.textBoxCurrentPrice.ReadOnly = true;
            this.textBoxCurrentPrice.Size = new System.Drawing.Size(129, 22);
            this.textBoxCurrentPrice.TabIndex = 97;
            this.textBoxCurrentPrice.TabStop = false;
            this.textBoxCurrentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Available";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.buttonNew);
            this.groupBox3.Controls.Add(this.buttonPreview);
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.textBoxDue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxPaid);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 90);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sale";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(274, 52);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(120, 30);
            this.buttonNew.TabIndex = 14;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreview.Location = new System.Drawing.Point(151, 52);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(120, 30);
            this.buttonPreview.TabIndex = 109;
            this.buttonPreview.TabStop = false;
            this.buttonPreview.Text = "Print";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(27, 52);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDue
            // 
            this.textBoxDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDue.Location = new System.Drawing.Point(286, 21);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new System.Drawing.Size(115, 22);
            this.textBoxDue.TabIndex = 106;
            this.textBoxDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Due";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaid.Location = new System.Drawing.Point(83, 22);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(129, 22);
            this.textBoxPaid.TabIndex = 12;
            this.textBoxPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPaid.TextChanged += new System.EventHandler(this.textBoxPaid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 105;
            this.label5.Text = "Paid";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 102;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NewSalesEngineOil
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(424, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewSalesEngineOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSalesEngineOil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.textBoxAvailable.Text = "";
            this.textBoxCurrentPrice.Text = "";
            this.textBoxSell.Text = "";
            string query = "SELECT * FROM firoz_center.tbl_customer t where type='1' order by name;";
            for (num = 0; num < 7; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(7L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
                this.comboBox1.Items.Add(this.Party[3].ElementAt<string>(num).ToString());
            }
        }

        private void load_price()
        {
            string query = "";
            query = "SELECT sale_price FROM firoz_center.tbl_parts_info t where partsId='2347' ORDER BY DATE DESC LIMIT 1;";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("R");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("D");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("W");
        }

        private void save_transcation()
        {
            string text = this.textBoxMemoNo.Text;
            string str2 = this.textBoxName.Text;
            string str3 = "";
            string str4 = this.textBoxAddress.Text;
            string str5 = this.textBoxContact.Text;
            if (this.checkBoxNew.Checked.Equals(true))
            {
                string str6 = "insert into firoz_center.tbl_customer (`name`,`fathers_name`,`address`,`contact`,`email`,`comments`,`type`) values ('" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','','','2');";
                this.dbc.Insert(str6);
            }
            string query = "SELECT customer_id FROM firoz_center.tbl_customer where name='" + str2 + "' and address='" + str4 + "' and contact='" + str5 + "';";
            string str8 = this.dbc.SelectSingle(query);
            string str9 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str10 = this.textBoxTotal.Text;
            string str11 = "0";
            string str12 = str10;
            string str13 = "insert into firoz_center.tbl_sales_parts (`memo_no`,`date`,`net_amount`,`discount`,`grand_total`,`user_id`,`customer_id`,`type`,`comments`,`paid_amount`,`due_amount`) values ('" + text + "','" + str9 + "','" + str12 + "','" + str11 + "','" + str10 + "','1','" + str8 + "','Sales Engine Oil','','" + this.textBoxPaid.Text + "','" + this.textBoxDue.Text + "');";
            this.dbc.Insert(str13);
            string str14 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + text + "','" + this.textBoxPaid.Text + "','1','Sales Parts','" + str9 + "');";
            this.dbc.Insert(str14);
            string str15 = "insert into firoz_center.tbl_payment (`memo_no`,`date`,`customer_id`,`amount`,`user_id`,`comments`) values ('" + text + "','" + str9 + "','" + str8 + "','" + this.textBoxPaid.Text + "','1','');";
            this.dbc.Insert(str15);
            string s = this.textBoxSell.Text;
            string str17 = this.textBoxCurrentPrice.Text;
            for (int i = 0; i < int.Parse(s); i++)
            {
                string str18 = "update firoz_center.tbl_parts set `sale_rate`='" + str17 + "',`status`='sold',memo_no='" + text + "' where partsid ='2347' and status like '%stock%' limit 1; ";
                this.dbc.Update(str18);
            }
            MessageBox.Show("Sale Completed");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Party[1].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.textBoxAddress.Text = this.Party[2].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.textBoxContact.Text = this.Party[3].ElementAt<string>(this.comboBox1.SelectedIndex);
        }
    }
}

