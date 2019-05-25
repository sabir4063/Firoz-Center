namespace FirozCenterHonda
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Linq;
    using System.Windows.Forms;

    public class EditSaleService : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonAddInvoice;
        private Button buttonPreview;
        private Button buttonSave;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        public ComboBox comboBoxService;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DBConnect dbc = new DBConnect();
        private SolidBrush drawBrush = new SolidBrush(Color.Black);
        private Font fontDate = new Font("Serpentine-Bold", 8f);
        private Font fontSubHeading = new Font("Serpentine-Bold", 14f);
        private Font fontTitle = new Font("Serpentine-Bold", 10f);
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label labelId;
        private List<string>[] Service = new List<string>[3];
        private List<string>[] Service_details = new List<string>[1];
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private int tag = 0;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxCurrentPrice;
        private TextBox textBoxDate;
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxNetAmount;
        private TextBox textBoxPaid;

        public EditSaleService()
        {
            this.InitializeComponent();
            this.load_service();
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            int num;
            this.load_parts_current();
            for (num = 0; num < this.Service_details[0].Count; num++)
            {
                if (this.Service_details[0].ElementAt<string>(num).Equals(this.comboBoxService.SelectedItem.ToString()))
                {
                    MessageBox.Show("Duplicate Service!");
                    return;
                }
            }
            this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count + 1, this.comboBoxService.SelectedItem.ToString(), this.textBoxCurrentPrice.Text, this.labelId.Text });
            long num2 = 0L;
            for (num = 0; num < this.dataGridView1.Rows.Count; num++)
            {
                num2 += long.Parse(this.dataGridView1.Rows[num].Cells[2].Value.ToString());
            }
            this.textBoxNetAmount.Text = num2.ToString();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
                this.buttonPreview.BackColor = Color.Yellow;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo);
            if (((this.textBoxName.Text.Equals("") || this.textBoxAddress.Text.Equals("")) || this.textBoxDue.Text.Equals("")) || this.textBoxPaid.Text.Equals(""))
            {
                MessageBox.Show("Please Check All Required Field!");
            }
            else if (long.Parse(this.textBoxDue.Text) < 0L)
            {
                MessageBox.Show("Please Check Paid Amount!");
            }
            else if (result == DialogResult.Yes)
            {
                this.save_transcation();
                this.tag = 1;
                this.buttonSave.BackColor = Color.Yellow;
                this.groupBox1.Enabled = false;
                this.groupBox3.Enabled = false;
                this.groupBox2.Enabled = false;
                this.buttonSave.Enabled = false;
                this.textBoxPaid.Enabled = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.do_it();
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxCurrentPrice.Text = this.Service[1].ElementAt<string>(this.comboBoxService.SelectedIndex);
            this.labelId.Text = this.Service[2].ElementAt<string>(this.comboBoxService.SelectedIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            long num = 0L;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
                long num3 = long.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                num += num3;
            }
            this.textBoxNetAmount.Text = num.ToString();
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
            string query = "Select date from firoz_center.tbl_sales_service where memo_no='" + this.textBoxMemoNo.Text + "';";
            string str2 = this.dbc.Select_Date(query);
            if (str2.Equals(""))
            {
                MessageBox.Show("Check Again!!!");
            }
            else
            {
                int num;
                this.textBoxDate.Text = str2;
                query = "Select grand_total from firoz_center.tbl_sales_service where memo_no='" + this.textBoxMemoNo.Text + "';";
                string str3 = this.dbc.SelectSingle(query);
                this.textBoxNetAmount.Text = str3;
                query = "Select paid_amount from firoz_center.tbl_sales_service where memo_no='" + this.textBoxMemoNo.Text + "';";
                string str4 = this.dbc.SelectSingle(query);
                this.textBoxPaid.Text = str4;
                query = "Select due_amount from firoz_center.tbl_sales_service where memo_no='" + this.textBoxMemoNo.Text + "';";
                string str5 = this.dbc.SelectSingle(query);
                this.textBoxDue.Text = str5;
                query = "Select customer_id from firoz_center.tbl_sales_service where memo_no='" + this.textBoxMemoNo.Text + "';";
                string str6 = this.dbc.SelectSingle(query);
                string str7 = "select name from firoz_center.tbl_customer where customer_id = '" + str6 + "';";
                this.textBoxName.Text = this.dbc.SelectSingle(str7);
                string str8 = "select address from firoz_center.tbl_customer where customer_id = '" + str6 + "';";
                this.textBoxAddress.Text = this.dbc.SelectSingle(str8);
                string str9 = "select contact from firoz_center.tbl_customer where customer_id = '" + str6 + "';";
                this.textBoxContact.Text = this.dbc.SelectSingle(str9);
                query = "select service_id,charge from firoz_center.tbl_service where memo_no='" + this.textBoxMemoNo.Text + "';";
                List<string>[] listArray = new List<string>[2];
                for (num = 0; num < 2; num++)
                {
                    listArray[num] = new List<string>();
                }
                listArray = this.dbc.Select(2L, query);
                long num2 = 0L;
                for (num = 0; num < listArray[0].Count; num++)
                {
                    string str10 = this.dbc.SelectSingle("SELECT name FROM firoz_center.tbl_service_charge where service_id='" + listArray[0].ElementAt<string>(num) + "';");
                    long num3 = long.Parse(listArray[1].ElementAt<string>(num));
                    this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count + 1, str10, num3, listArray[0].ElementAt<string>(num) });
                    num2 += num3;
                }
                this.textBoxNetAmount.Text = num2.ToString();
            }
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            this.label12 = new Label();
            this.textBoxMemoNo = new TextBox();
            this.label11 = new Label();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label2 = new Label();
            this.dataGridView1 = new DataGridView();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.label3 = new Label();
            this.label19 = new Label();
            this.groupBox1 = new GroupBox();
            this.textBoxDate = new TextBox();
            this.buttonSearch = new Button();
            this.groupBox3 = new GroupBox();
            this.groupBox4 = new GroupBox();
            this.textBoxDue = new TextBox();
            this.buttonPreview = new Button();
            this.label7 = new Label();
            this.textBoxPaid = new TextBox();
            this.label4 = new Label();
            this.buttonSave = new Button();
            this.textBoxNetAmount = new TextBox();
            this.label14 = new Label();
            this.groupBox2 = new GroupBox();
            this.labelId = new Label();
            this.buttonAddInvoice = new Button();
            this.textBoxCurrentPrice = new TextBox();
            this.label10 = new Label();
            this.comboBoxService = new ComboBox();
            this.label8 = new Label();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(9, 0x2b);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(0x55, 0x12);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x83, 0x16);
            this.textBoxMemoNo.TabIndex = 0x12;
            this.textBoxMemoNo.KeyDown += new KeyEventHandler(this.textBoxMemoNo_KeyDown);
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(9, 0x13);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x43, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Memo No";
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.Location = new Point(0x55, 0xaf);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new Size(0x111, 0x16);
            this.textBoxContact.TabIndex = 8;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x55, 0x5c);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new Size(0x111, 0x51);
            this.textBoxAddress.TabIndex = 7;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x55, 0x44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x111, 0x16);
            this.textBoxName.TabIndex = 6;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(11, 0x5c);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column3, this.Column1, this.Column7, this.Column2 });
            this.dataGridView1.GridColor = Color.DarkSeaGreen;
            this.dataGridView1.Location = new Point(6, 0x12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x1a9, 0x19c);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.Column3.HeaderText = "S/N";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 40;
            this.Column1.FillWeight = 120f;
            this.Column1.HeaderText = "Service";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            style2.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = style2;
            this.Column7.FillWeight = 80f;
            this.Column7.HeaderText = "Charge";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            this.Column2.HeaderText = "I";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 10;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(9, 0xaf);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(11, 0x43);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x2d, 0x10);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x173, 0xcb);
            this.groupBox1.TabIndex = 0x2a;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.textBoxDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDate.Location = new Point(0x55, 0x2b);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new Size(0x83, 0x16);
            this.textBoxDate.TabIndex = 0x16;
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0xee, 0x13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(120, 30);
            this.buttonSearch.TabIndex = 0x15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(0x17e, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x1c6, 0x1b4);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.groupBox4.BackColor = Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.textBoxDue);
            this.groupBox4.Controls.Add(this.buttonPreview);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPaid);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox4.Location = new Point(5, 0x14e);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0x173, 0x6c);
            this.groupBox4.TabIndex = 0x17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            this.textBoxDue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDue.Location = new Point(240, 0x29);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new Size(0x76, 0x16);
            this.textBoxDue.TabIndex = 0x23;
            this.buttonPreview.BackColor = Color.MediumSeaGreen;
            this.buttonPreview.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPreview.Location = new Point(0xee, 0x45);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new Size(120, 30);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.Text = "Print";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new EventHandler(this.buttonPreview_Click);
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0xca, 0x2c);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x21, 0x10);
            this.label7.TabIndex = 0x24;
            this.label7.Text = "Due";
            this.textBoxPaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPaid.Location = new Point(0x55, 0x29);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new Size(0x6f, 0x16);
            this.textBoxPaid.TabIndex = 0x1f;
            this.textBoxPaid.TextChanged += new EventHandler(this.textBoxPaid_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0x2d, 0x2d);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x24, 0x10);
            this.label4.TabIndex = 0x20;
            this.label4.Text = "Paid";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x55, 0x45);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x1d;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(0x55, 0x11);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(0x111, 0x16);
            this.textBoxNetAmount.TabIndex = 0x16;
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x4d, 0x10);
            this.label14.TabIndex = 0x15;
            this.label14.Text = "Net Amount";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.labelId);
            this.groupBox2.Controls.Add(this.buttonAddInvoice);
            this.groupBox2.Controls.Add(this.textBoxCurrentPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 0xd6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x173, 0x72);
            this.groupBox2.TabIndex = 0x2b;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            this.labelId.AutoSize = true;
            this.labelId.BackColor = Color.DarkSeaGreen;
            this.labelId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelId.Location = new Point(0x133, 0x4c);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(0x34, 0x10);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "Charge";
            this.labelId.Visible = false;
            this.buttonAddInvoice.BackColor = Color.MediumSeaGreen;
            this.buttonAddInvoice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonAddInvoice.Location = new Point(130, 0x4c);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new Size(120, 30);
            this.buttonAddInvoice.TabIndex = 14;
            this.buttonAddInvoice.Text = "Add Item";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new EventHandler(this.buttonAddInvoice_Click);
            this.textBoxCurrentPrice.BackColor = SystemColors.Window;
            this.textBoxCurrentPrice.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCurrentPrice.Location = new Point(0x55, 0x2f);
            this.textBoxCurrentPrice.Name = "textBoxCurrentPrice";
            this.textBoxCurrentPrice.ReadOnly = true;
            this.textBoxCurrentPrice.Size = new Size(0x112, 0x17);
            this.textBoxCurrentPrice.TabIndex = 13;
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(12, 0x2f);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x34, 0x10);
            this.label10.TabIndex = 11;
            this.label10.Text = "Charge";
            this.comboBoxService.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxService.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxService.BackColor = SystemColors.Window;
            this.comboBoxService.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new Point(0x55, 0x15);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new Size(0x112, 0x18);
            this.comboBoxService.TabIndex = 6;
            this.comboBoxService.SelectedIndexChanged += new EventHandler(this.comboBoxService_SelectedIndexChanged);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(12, 0x15);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x36, 0x10);
            this.label8.TabIndex = 0;
            this.label8.Text = "Service";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x350, 0x1bf);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox3);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditSaleService";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Sale Service";
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_parts_current()
        {
            int num;
            for (num = 0; num < 1; num++)
            {
                this.Service_details[num] = new List<string>();
            }
            for (num = 0; num < this.dataGridView1.RowCount; num++)
            {
                this.Service_details[0].Add(this.dataGridView1.Rows[num].Cells[1].Value.ToString());
            }
        }

        public void load_service()
        {
            int num;
            this.comboBoxService.Items.Clear();
            string query = "SELECT name,charge,service_id FROM firoz_center.tbl_service_charge;";
            for (num = 0; num < 3; num++)
            {
                this.Service[num] = new List<string>();
            }
            this.Service = this.dbc.Select(3L, query);
            for (num = 0; num < this.Service[0].Count; num++)
            {
                this.comboBoxService.Items.Add(this.Service[0].ElementAt<string>(num).ToString());
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
                        this.sfMiddle.Alignment = StringAlignment.Center;
                        this.sfMiddle.LineAlignment = StringAlignment.Center;
                        this.sfLeft.Alignment = StringAlignment.Near;
                        this.sfLeft.LineAlignment = StringAlignment.Center;
                        this.sfRight.Alignment = StringAlignment.Far;
                        this.sfRight.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        string text = this.textBoxDate.Text;
                        e.Graphics.DrawString("Firoz Motors", font, this.drawBrush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", this.fontSubHeading, this.drawBrush, new Rectangle(15, y, 800, this.fontSubHeading.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Invoice No :: " + this.textBoxMemoNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                        y += 15;
                        e.Graphics.DrawString("Date :: " + text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Print Date:" + str, this.fontDate, this.drawBrush, new Rectangle(15, 10, 150, this.fontDate.Height), this.sfMiddle);
                        e.Graphics.DrawString("Name: " + this.textBoxName.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        e.Graphics.DrawString("Address: " + this.textBoxAddress.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        e.Graphics.DrawString("Contact: " + this.textBoxContact.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        y = e.MarginBounds.Top + 100;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            if (num4 > 2)
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
                            if (num4 > 2)
                            {
                                break;
                            }
                            if (num4 == 0)
                            {
                                this.sf = this.sfMiddle;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if (num4 == 1)
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 5), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else
                            {
                                this.sf = this.sfRight;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) - 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                        }
                        if (num4 > 2)
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
                e.Graphics.DrawString("Net Amount (In words): " + this.dbc.NumberToText(this.textBoxNetAmount.Text) + "Taka", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 800, this.fontSubHeading.Height), this.sfLeft);
                e.Graphics.DrawString("Net Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxNetAmount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Paid Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxPaid.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Due Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 650, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxDue.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(650, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 150;
                e.Graphics.DrawString("Signature:\nCustomer", this.fontTitle, this.drawBrush, new Rectangle(50, y, 750, this.fontTitle.Height * 3), this.sfLeft);
                e.Graphics.DrawString("Signature:\nFiroz Motors", this.fontTitle, this.drawBrush, new Rectangle(50, y, 750, this.fontTitle.Height * 3), this.sfRight);
                y += 50;
                e.Graphics.DrawString("** Sold product will not be taken back **", this.fontDate, this.drawBrush, new Rectangle(0x19, y, 750, this.fontDate.Height), this.sfMiddle);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void save_transcation()
        {
            string text = this.textBoxNetAmount.Text;
            string s = this.textBoxPaid.Text;
            string str3 = this.textBoxDue.Text;
            string str4 = this.textBoxMemoNo.Text;
            string str5 = this.textBoxDate.Text;
            double num = double.Parse(s);
            double num2 = double.Parse(text);
            double num3 = double.Parse(str3);
            if (((num > num2) || (num3 < 0.0)) || (num2 != (num + num3)))
            {
                MessageBox.Show("Check Paid Amount");
            }
            else
            {
                string query = "UPDATE firoz_center.tbl_sales_service set grand_total='" + text + "',net_amount='" + text + "',paid_amount='" + s + "',due_amount='" + str3 + "' where memo_no='" + str4 + "';";
                this.dbc.Update(query);
                string str7 = "UPDATE firoz_center.tbl_payment set amount='" + s + "' where memo_no='" + str4 + "' and date='" + str5 + "';";
                this.dbc.Update(str7);
                string str8 = "UPDATE firoz_center.tbl_transcation set debit='" + s + "' where memo_no='" + str4 + "' and date='" + str5 + "';";
                this.dbc.Update(str7);
                string str9 = "Delete FROM firoz_center.tbl_service where memo_no='" + str4 + "';";
                this.dbc.Delete(str9);
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    string str10 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string str11 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string str12 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string str13 = "Insert into firoz_center.tbl_service (`service_id`,`memo_no`,`charge`) values ('" + str12 + "','" + str4 + "','" + str11 + "');";
                    this.dbc.Insert(str13);
                }
            }
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.do_it();
            }
        }

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxNetAmount.Text.Equals("") && !this.textBoxPaid.Text.Equals(""))
            {
                if (this.textBoxPaid.Text.Equals(""))
                {
                    this.textBoxDue.Text = this.textBoxNetAmount.Text;
                }
                else
                {
                    double num = double.Parse(this.textBoxNetAmount.Text);
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

