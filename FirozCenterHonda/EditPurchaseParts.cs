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

    public class EditPurchaseParts : Form
    {
        private string address;
        private ArrayList arrColumnLefts;
        private ArrayList arrColumnWidths;
        private bool bFirstPage;
        private bool bNewPage;
        private Button button3;
        private Button buttonAddInvoice;
        private Button buttonDeleteInvoice;
        private Button buttonPrint;
        private Button buttonPrlong;
        private Button buttonSave;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        public ComboBox comboBoxDescip;
        public ComboBox comboBoxModel;
        public ComboBox comboBoxPartsNo;
        private IContainer components;
        private string contact;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc;
        private SolidBrush drawBrush;
        private Font fontSubHeading;
        private Font fontTitle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private int iCellHeight;
        private int iHeaderHeight;
        private int iRow;
        private int iTotalWidth;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private DataGridViewTextBoxColumn Model;
        private List<string>[] Parts_details;
        private StringFormat sf;
        private StringFormat sfLeft;
        private StringFormat sfMiddle;
        private StringFormat sfRight;
        private StringFormat strFormat;
        private int tag;
        private TextBox textBoxAvailable;
        private TextBox textBoxInvoiceNo;
        private TextBox textBoxNetAmount;
        private TextBox textBoxNetAmountText;
        private TextBox textBoxParty;
        private TextBox textBoxPricePerUnit;
        private TextBox textBoxQuantity;

        public EditPurchaseParts()
        {
            this.dbc = new DBConnect();
            this.Parts_details = new List<string>[2];
            this.tag = 0;
            this.arrColumnLefts = new ArrayList();
            this.arrColumnWidths = new ArrayList();
            this.iCellHeight = 0;
            this.iTotalWidth = 0;
            this.iRow = 0;
            this.bFirstPage = false;
            this.bNewPage = false;
            this.iHeaderHeight = 0;
            this.sf = new StringFormat();
            this.sfMiddle = new StringFormat();
            this.sfLeft = new StringFormat();
            this.sfRight = new StringFormat();
            this.fontSubHeading = new Font("Serpentine-Bold", 14f);
            this.drawBrush = new SolidBrush(Color.Black);
            this.fontTitle = new Font("Serpentine-Bold", 10f);
            this.components = null;
            this.InitializeComponent();
            this.load_model();
        }

        public EditPurchaseParts(string invoice_no)
        {
            this.dbc = new DBConnect();
            this.Parts_details = new List<string>[2];
            this.tag = 0;
            this.arrColumnLefts = new ArrayList();
            this.arrColumnWidths = new ArrayList();
            this.iCellHeight = 0;
            this.iTotalWidth = 0;
            this.iRow = 0;
            this.bFirstPage = false;
            this.bNewPage = false;
            this.iHeaderHeight = 0;
            this.sf = new StringFormat();
            this.sfMiddle = new StringFormat();
            this.sfLeft = new StringFormat();
            this.sfRight = new StringFormat();
            this.fontSubHeading = new Font("Serpentine-Bold", 14f);
            this.drawBrush = new SolidBrush(Color.Black);
            this.fontTitle = new Font("Serpentine-Bold", 10f);
            this.components = null;
            this.InitializeComponent();
            if (invoice_no.Equals(""))
            {
                this.groupBox2.Visible = false;
                this.buttonSave.Visible = false;
            }
            else if (invoice_no.Equals("Delete"))
            {
                this.textBoxQuantity.Enabled = false;
                this.buttonAddInvoice.Visible = false;
                this.buttonPrint.Visible = false;
                this.buttonSave.Visible = false;
                this.groupBox5.Visible = true;
            }
            else
            {
                this.textBoxInvoiceNo.Text = invoice_no;
                this.do_it();
            }
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            this.load_parts_current();
            this.load_net_amount();
        }

        private void buttonDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete all including Invoice No?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "delete FROM firoz_center.tbl_parts where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
                query = "delete FROM firoz_center.tbl_transcation where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
                query = "delete FROM firoz_center.tbl_purchase where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
                query = "delete FROM firoz_center.tbl_party_transcation where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
                MessageBox.Show("Save Invoice");
            }
            if (MessageBox.Show("Do you want to print invoice?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void buttonPrlong_Click(object sender, EventArgs e)
        {
            if (this.textBoxInvoiceNo.Text.Equals(""))
            {
                MessageBox.Show("Give Invoice No");
            }
            else if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
                this.tag = 1;
                this.buttonPrlong.Enabled = false;
                this.buttonPrlong.BackColor = Color.Red;
                this.dataGridView1.Enabled = false;
                this.textBoxInvoiceNo.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.textBoxQuantity.Enabled = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.do_it();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxDescip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxPartsNo.SelectedIndex = this.comboBoxDescip.SelectedIndex;
            this.load_price();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_description_Parts();
        }

        private void comboBoxModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.load_description_Parts();
        }

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_price();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string partsNo = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string description = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string quantity = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string text = this.textBoxInvoiceNo.Text;
            string price = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string group = this.textBoxParty.Text;
            new UpdatePurchaseParts(partsNo, description, quantity, text, price, group).Show();
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void do_it()
        {
            this.dataGridView1.Rows.Clear();
            if (this.dbc.Count("Select purchase_date from firoz_center.tbl_purchase where invoice_no='" + this.textBoxInvoiceNo.Text + "';") == -1L)
            {
                MessageBox.Show("Check Again!!!");
            }
            else
            {
                string query = "Select purchase_date from firoz_center.tbl_purchase where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
                if (this.dbc.Select_Date(query).Equals(""))
                {
                    MessageBox.Show("Check Again!!!");
                }
                else
                {
                    int num2;
                    string str3 = this.dbc.Select_Date_Format_2(query);
                    string[] strArray = new string[5];
                    strArray = str3.Split(new char[] { '-' });
                    this.dateTimePicker1.Value = new DateTime(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]));
                    query = "Select party_id from firoz_center.tbl_purchase where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
                    string str4 = this.dbc.SelectSingle(query);
                    string str5 = "select name from firoz_center.tbl_party where customer_id = '" + str4 + "';";
                    this.textBoxParty.Text = this.dbc.SelectSingle(str5);
                    str5 = "select address from firoz_center.tbl_party where customer_id = '" + str4 + "';";
                    this.address = this.dbc.SelectSingle(str5);
                    str5 = "select contact from firoz_center.tbl_party where customer_id = '" + str4 + "';";
                    this.contact = this.dbc.SelectSingle(str5);
                    query = "select partsId,count(*),purchase_rate,status from firoz_center.tbl_parts where invoice_no='" + this.textBoxInvoiceNo.Text + "' group by partsId;";
                    List<string>[] listArray = new List<string>[4];
                    for (num2 = 0; num2 < 4; num2++)
                    {
                        listArray[num2] = new List<string>();
                    }
                    listArray = this.dbc.Select(4L, query);
                    double num3 = 0.0;
                    for (num2 = 0; num2 < listArray[0].Count; num2++)
                    {
                        string str6 = "select model,partsNo,description from firoz_center.tbl_parts_info where partsId='" + listArray[0].ElementAt<string>(num2).ToString() + "'";
                        List<string>[] listArray2 = new List<string>[3];
                        for (int i = 0; i < 3; i++)
                        {
                            listArray2[i] = new List<string>();
                        }
                        listArray2 = this.dbc.Select(3L, str6);
                        string str7 = listArray2[0].ElementAt<string>(0);
                        string str8 = listArray2[1].ElementAt<string>(0);
                        string str9 = listArray2[2].ElementAt<string>(0);
                        double num5 = long.Parse(listArray[1].ElementAt<string>(num2)) * double.Parse(listArray[2].ElementAt<string>(num2));
                        num3 += num5;
                        this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.RowCount + 1, str7, str8, str9, listArray[1].ElementAt<string>(num2), listArray[2].ElementAt<string>(num2), num5, "Old" });
                    }
                    string[] strArray2 = new string[2];
                    this.textBoxNetAmount.Text = num3.ToString();
                    this.textBoxNetAmountText.Text = double.Parse(num3.ToString()).ToString("n2");

                    load_model();
                }
            }
        }

        private void InitializeComponent()
        {
            this.label5 = new Label();
            this.label6 = new Label();
            this.groupBox2 = new GroupBox();
            this.comboBoxModel = new ComboBox();
            this.label7 = new Label();
            this.buttonAddInvoice = new Button();
            this.textBoxPricePerUnit = new TextBox();
            this.textBoxQuantity = new TextBox();
            this.label10 = new Label();
            this.label9 = new Label();
            this.comboBoxDescip = new ComboBox();
            this.comboBoxPartsNo = new ComboBox();
            this.label1 = new Label();
            this.label12 = new Label();
            this.textBoxInvoiceNo = new TextBox();
            this.label11 = new Label();
            this.groupBox1 = new GroupBox();
            this.dateTimePicker1 = new DateTimePicker();
            this.buttonSearch = new Button();
            this.textBoxParty = new TextBox();
            this.groupBox4 = new GroupBox();
            this.buttonPrlong = new Button();
            this.textBoxNetAmountText = new TextBox();
            this.buttonPrint = new Button();
            this.buttonSave = new Button();
            this.textBoxNetAmount = new TextBox();
            this.label14 = new Label();
            this.groupBox3 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.groupBox5 = new GroupBox();
            this.buttonDeleteInvoice = new Button();
            this.button3 = new Button();
            this.textBoxAvailable = new TextBox();
            this.label2 = new Label();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Model = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox5.SuspendLayout();
            base.SuspendLayout();
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(14, 0x49);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x4c, 0x10);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(14, 50);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 0x10);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxAvailable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonAddInvoice);
            this.groupBox2.Controls.Add(this.textBoxPricePerUnit);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 0x6f);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(360, 0xb9);
            this.groupBox2.TabIndex = 0x12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.ControlLight;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x68, 0x15);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(250, 0x18);
            this.comboBoxModel.TabIndex = 0x10;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged_1);
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(14, 0x18);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 15;
            this.label7.Text = "Model";
            this.buttonAddInvoice.BackColor = Color.MediumSeaGreen;
            this.buttonAddInvoice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonAddInvoice.Location = new Point(230, 0x95);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new Size(120, 30);
            this.buttonAddInvoice.TabIndex = 14;
            this.buttonAddInvoice.Text = "Add New";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new EventHandler(this.buttonAddInvoice_Click);
            this.textBoxPricePerUnit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPricePerUnit.Location = new Point(0x68, 0x7b);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.ReadOnly = true;
            this.textBoxPricePerUnit.Size = new Size(250, 0x16);
            this.textBoxPricePerUnit.TabIndex = 13;
            this.textBoxQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxQuantity.Location = new Point(0x68, 0x63);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new Size(0x51, 0x16);
            this.textBoxQuantity.TabIndex = 12;
            this.textBoxQuantity.TextAlign = HorizontalAlignment.Right;
            this.textBoxQuantity.KeyDown += new KeyEventHandler(this.textBoxQuantity_KeyDown);
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(14, 0x7b);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x2a, 0x10);
            this.label10.TabIndex = 11;
            this.label10.Text = "Price ";
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(14, 0x63);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x38, 0x10);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity";
            this.comboBoxDescip.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = SystemColors.ControlLight;
            this.comboBoxDescip.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new Point(0x68, 0x49);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new Size(250, 0x18);
            this.comboBoxDescip.TabIndex = 9;
            this.comboBoxDescip.SelectedIndexChanged += new EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            this.comboBoxPartsNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new Point(0x68, 0x2f);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new Size(250, 0x18);
            this.comboBoxPartsNo.TabIndex = 8;
            this.comboBoxPartsNo.SelectedIndexChanged += new EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0x2a);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x27, 0x10);
            this.label1.TabIndex = 0x16;
            this.label1.Text = "Party";
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xcf, 0x12);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxInvoiceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxInvoiceNo.Location = new Point(100, 0x10);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new Size(0x65, 0x16);
            this.textBoxInvoiceNo.TabIndex = 0x12;
            this.textBoxInvoiceNo.KeyDown += new KeyEventHandler(this.textBoxInvoiceNo_KeyDown);
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x48, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Invoice No";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxParty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(360, 100);
            this.groupBox1.TabIndex = 0x11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new Point(0xfd, 0x10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x61, 0x16);
            this.dateTimePicker1.TabIndex = 0x22;
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0x98, 0x43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(0x4b, 0x1b);
            this.buttonSearch.TabIndex = 0x18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.textBoxParty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxParty.Location = new Point(100, 0x2a);
            this.textBoxParty.Name = "textBoxParty";
            this.textBoxParty.ReadOnly = true;
            this.textBoxParty.Size = new Size(250, 0x16);
            this.textBoxParty.TabIndex = 0x17;
            this.groupBox4.BackColor = Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.buttonPrlong);
            this.groupBox4.Controls.Add(this.textBoxNetAmountText);
            this.groupBox4.Controls.Add(this.buttonPrint);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox4.Location = new Point(5, 0x12e);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(360, 0x63);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            this.buttonPrlong.BackColor = Color.MediumSeaGreen;
            this.buttonPrlong.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrlong.Location = new Point(0x68, 0x3f);
            this.buttonPrlong.Name = "buttonPrlong";
            this.buttonPrlong.Size = new Size(120, 30);
            this.buttonPrlong.TabIndex = 0x1f;
            this.buttonPrlong.Text = "Save";
            this.buttonPrlong.UseVisualStyleBackColor = false;
            this.buttonPrlong.Click += new EventHandler(this.buttonPrlong_Click);
            this.textBoxNetAmountText.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmountText.Location = new Point(13, 0x26);
            this.textBoxNetAmountText.Name = "textBoxNetAmountText";
            this.textBoxNetAmountText.ReadOnly = true;
            this.textBoxNetAmountText.Size = new Size(0x151, 0x16);
            this.textBoxNetAmountText.TabIndex = 0x17;
            this.buttonPrint.BackColor = Color.MediumSeaGreen;
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(230, 0x3f);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(120, 30);
            this.buttonPrint.TabIndex = 30;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new EventHandler(this.buttonPreview_Click);
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x63, 0xca);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x17);
            this.buttonSave.TabIndex = 0x1d;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(100, 14);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(250, 0x16);
            this.textBoxNetAmount.TabIndex = 0x16;
            this.textBoxNetAmount.TextAlign = HorizontalAlignment.Right;
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x4d, 0x10);
            this.label14.TabIndex = 0x15;
            this.label14.Text = "Net Amount";
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(0x173, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x2f6, 0x204);
            this.groupBox3.TabIndex = 0x13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column7, this.Model, this.Column3, this.Column4, this.Column5, this.Column6, this.Column1, this.Column2 });
            this.dataGridView1.Location = new Point(7, 0x11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x2ea, 0x1ec);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.groupBox5.BackColor = Color.DarkSeaGreen;
            this.groupBox5.Controls.Add(this.buttonDeleteInvoice);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox5.Location = new Point(5, 0x197);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(360, 0x41);
            this.groupBox5.TabIndex = 0x22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete";
            this.groupBox5.Visible = false;
            this.buttonDeleteInvoice.BackColor = Color.MediumSeaGreen;
            this.buttonDeleteInvoice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonDeleteInvoice.Location = new Point(0x38, 0x18);
            this.buttonDeleteInvoice.Name = "buttonDeleteInvoice";
            this.buttonDeleteInvoice.Size = new Size(250, 30);
            this.buttonDeleteInvoice.TabIndex = 0x1f;
            this.buttonDeleteInvoice.Text = "Delete Invoice";
            this.buttonDeleteInvoice.UseVisualStyleBackColor = false;
            this.buttonDeleteInvoice.Click += new EventHandler(this.buttonDeleteInvoice_Click);
            this.button3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(0x63, 0xca);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x4b, 0x17);
            this.button3.TabIndex = 0x1d;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.textBoxAvailable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAvailable.Location = new Point(0x109, 0x63);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.ReadOnly = true;
            this.textBoxAvailable.Size = new Size(0x59, 0x16);
            this.textBoxAvailable.TabIndex = 0x16;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0xbf, 0x66);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x41, 0x10);
            this.label2.TabIndex = 0x17;
            this.label2.Text = "Available";
            this.Column7.FillWeight = 80f;
            this.Column7.HeaderText = "S/N";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
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
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 10;
            this.Column1.HeaderText = "Total Price";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 10;
            this.Column2.HeaderText = "S";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 20;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x46c, 0x20e);
            base.Controls.Add(this.groupBox5);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox3);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditPurchaseParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Purchase Parts";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox5.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void load_description_Parts()
        {
            int num;
            this.comboBoxDescip.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            string query = "SELECT description,partsNo FROM firoz_center.tbl_parts_info where model='" + this.comboBoxModel.SelectedItem.ToString() + "' group by description,partsNo;";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(2L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxDescip.Items.Add(listArray[0].ElementAt<string>(num).ToString());
                this.comboBoxPartsNo.Items.Add(listArray[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string query = "SELECT model FROM firoz_center.tbl_parts_info t group by model;";
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

        private void load_net_amount()
        {
            if (this.textBoxQuantity.Text.Equals(""))
            {
                MessageBox.Show("Give Quantity");
            }
            else
            {
                int num4;
                long num = long.Parse(this.textBoxQuantity.Text);
                double num2 = double.Parse(this.textBoxPricePerUnit.Text);
                double num3 = num * num2;
                for (num4 = 0; num4 < this.Parts_details[0].Count; num4++)
                {
                    if (this.Parts_details[0].ElementAt<string>(num4).Equals(this.comboBoxPartsNo.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Duplicate Parts No!");
                        return;
                    }
                }
                this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count + 1, this.comboBoxModel.SelectedItem.ToString(), this.comboBoxPartsNo.SelectedItem.ToString(), this.comboBoxDescip.SelectedItem.ToString(), this.textBoxQuantity.Text, this.textBoxPricePerUnit.Text, num3.ToString(), "New" });
                double num5 = 0.0;
                for (num4 = 0; num4 < this.dataGridView1.Rows.Count; num4++)
                {
                    num = long.Parse(this.dataGridView1.Rows[num4].Cells[4].Value.ToString());
                    num2 = double.Parse(this.dataGridView1.Rows[num4].Cells[5].Value.ToString());
                    num3 = num * num2;
                    num5 += num3;
                }
                string[] strArray = new string[2];
                this.textBoxNetAmount.Text = num5.ToString();
                if (this.textBoxNetAmount.Text.Contains("."))
                {
                    strArray = this.textBoxNetAmount.Text.ToString().Split(new char[] { '.' });
                    this.textBoxNetAmountText.Text = this.dbc.NumberToText(strArray[0]) + "Taka " + this.dbc.NumberToText(strArray[1]) + "Paisa";
                }
                else
                {
                    this.textBoxNetAmountText.Text = this.dbc.NumberToText(this.textBoxNetAmount.Text) + "Taka ";
                }
                this.textBoxQuantity.Text = "";
            }
        }

        private void load_parts_current()
        {
            int num;
            for (num = 0; num < 2; num++)
            {
                this.Parts_details[num] = new List<string>();
            }
            for (num = 0; num < this.dataGridView1.RowCount; num++)
            {
                this.Parts_details[0].Add(this.dataGridView1.Rows[num].Cells[2].Value.ToString());
            }
        }

        private void load_price()
        {
            DateTime now = new DateTime();
            now = DateTime.Now;
            string date = string.Format("{0:yyyy-MM-dd}", now);

            string query = "Select purchase_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.textBoxParty.Text + "' and `date`<='" + date + "' ORDER BY DATE DESC LIMIT 1;";
            string str2 = this.dbc.SelectSingle(query);
            query = "Select partsId from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "';";
            string str3 = this.dbc.SelectSingle(query);
            query = "Select count(*) from firoz_center.tbl_parts where partsId='" + str3 + "' and `status` like 'stock';";
            string str4 = "0";
            str4 = this.dbc.SelectSingle(query);
            this.textBoxPricePerUnit.Text = str2;
            this.textBoxAvailable.Text = str4;
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
                foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                {
                    this.iTotalWidth += column.Width;
                }
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
                int num = 20;
                int y = 10;
                bool flag = false;
                int width = 0;
                if (this.bFirstPage)
                {
                    foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                    {
                        width = (int) (Math.Floor((double) ((((column.Width - 5.0) / ((double) this.iTotalWidth)) * this.iTotalWidth) * (((double) e.MarginBounds.Width) / ((double) this.iTotalWidth)))) * 1.25);
                        this.iHeaderHeight = ((int) e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, width).Height) + 11;
                        this.arrColumnLefts.Add(num);
                        this.arrColumnWidths.Add(width);
                        num += width;
                    }
                }
                while (this.iRow <= (this.dataGridView1.Rows.Count - 1))
                {
                    DataGridViewRow row = this.dataGridView1.Rows[this.iRow];
                    this.iCellHeight = row.Height + 5;
                    int num4 = 0;
                    if ((y + this.iCellHeight) >= (e.MarginBounds.Height + e.MarginBounds.Top))
                    {
                        this.bNewPage = true;
                        this.bFirstPage = false;
                        flag = true;
                        break;
                    }
                    if (this.bNewPage)
                    {
                        Font font = new Font("Serpentine-Bold", 18f, FontStyle.Bold);
                        Font font2 = new Font("Serpentine-Bold", 8f);
                        this.sfMiddle.Alignment = StringAlignment.Center;
                        this.sfMiddle.LineAlignment = StringAlignment.Center;
                        this.sfLeft.Alignment = StringAlignment.Near;
                        this.sfLeft.LineAlignment = StringAlignment.Center;
                        this.sfRight.Alignment = StringAlignment.Far;
                        this.sfRight.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        string str2 = this.dateTimePicker1.Value.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, this.drawBrush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", this.fontSubHeading, this.drawBrush, new Rectangle(15, y, 800, this.fontSubHeading.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Purchase Parts Invoice No :: " + this.textBoxInvoiceNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                        y += 15;
                        e.Graphics.DrawString("Date :: " + str2, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Print Date:" + str, font2, this.drawBrush, new Rectangle(15, 10, 150, font2.Height), this.sfMiddle);
                        y = e.MarginBounds.Top;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            if (num4 > 4)
                            {
                                break;
                            }
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iHeaderHeight), this.sfMiddle);
                            num4++;
                        }
                        this.bNewPage = false;
                        y += this.iHeaderHeight;
                    }
                    num4 = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (num4 > 4)
                            {
                                break;
                            }
                            if (num4 == 0)
                            {
                                this.sf = this.sfMiddle;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if ((num4 >= 1) && (num4 <= 3))
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else
                            {
                                this.sf = this.sfRight;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) - 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                        }
                        if (num4 > 4)
                        {
                            break;
                        }
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iCellHeight));
                        num4++;
                    }
                    this.iRow++;
                    y += this.iCellHeight;
                }
                if (flag)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }
                e.Graphics.DrawString("Net Amount: " + this.textBoxNetAmountText.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 700, this.fontTitle.Height), this.sfRight);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void save_transcation()
        {
            double num = 0.0;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str2 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str3 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                long num3 = long.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                double num4 = double.Parse(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                if (this.dataGridView1.Rows[i].Cells[7].Value.ToString().Equals("New"))
                {
                    for (int j = 0; j < num3; j++)
                    {
                        string str4 = "SELECT partsid FROM firoz_center.tbl_parts_info where description = '" + str3 + "' and partsNo='" + str2 + "';";
                        string str5 = this.dbc.SelectSingle(str4);
                        string group = textBoxParty.Text;
                        string str6 = string.Concat(new object[] { "insert into firoz_center.tbl_parts (`invoice_no`,`partsid`,`purchase_rate`,`status`,`group`) values ('", this.textBoxInvoiceNo.Text, "','", str5, "','", num4, "','stock','" + group + "');" });
                        this.dbc.Insert(str6);
                    }
                }
                num += num3 * num4;
            }
            string[] strArray = new string[2];
            this.textBoxNetAmount.Text = num.ToString();
            this.textBoxNetAmountText.Text = double.Parse(num.ToString()).ToString("n2");
            string query = "Update firoz_center.tbl_purchase set grand_total='" + this.textBoxNetAmount.Text + "' and net_amount='" + this.textBoxNetAmount.Text + "' where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
            this.dbc.Update(query);
            query = "update firoz_center.tbl_transcation set credit='" + this.textBoxNetAmount.Text + "' where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
            this.dbc.Update(query);
            MessageBox.Show("Update Completed");
        }

        private void textBoxInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.do_it();
            }
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBoxQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Please insert quantity!");
                }
                else
                {
                    e.SuppressKeyPress = true;
                    this.load_parts_current();
                    this.load_net_amount();
                }
            }
        }
    }
}

