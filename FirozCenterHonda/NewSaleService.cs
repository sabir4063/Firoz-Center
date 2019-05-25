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

    public class NewSaleService : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonAddInvoice;
        private Button buttonNew;
        private Button buttonPreview;
        private Button buttonSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private ComboBox comboBoxParty;
        public ComboBox comboBoxService;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
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
        private List<string>[] Party = new List<string>[7];
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
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxNetAmount;
        private TextBox textBoxPaid;

        public NewSaleService()
        {
            this.InitializeComponent();
            this.load_party();
            this.load_service();
            string query = "SELECT max(memo_no) FROM firoz_center.tbl_sales_service t;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxMemoNo.Text = "60000001";
            }
            else
            {
                string str2 = "SELECT max(memo_no) FROM firoz_center.tbl_sales_service t;";
                this.textBoxMemoNo.Text = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }
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

        private void buttonAddNewParty_Click(object sender, EventArgs e)
        {
            new AddNewCustomer().Show();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            base.Dispose();
            new NewSaleService().Show();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            this.print_preview();
        }

        private void buttonPreview_Click_1(object sender, EventArgs e)
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (((this.textBoxName.Text.Equals("") || this.textBoxAddress.Text.Equals("")) || this.textBoxDue.Text.Equals("")) || this.textBoxPaid.Text.Equals(""))
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
                    this.groupBox1.Enabled = true;
                    this.groupBox3.Enabled = false;
                    this.groupBox2.Enabled = false;
                    this.buttonSave.Enabled = false;
                    this.buttonNew.Enabled = true;
                    this.textBoxPaid.Enabled = false;
                }
            }
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Party[1].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxAddress.Text = this.Party[2].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxContact.Text = this.Party[3].ElementAt<string>(this.comboBoxParty.SelectedIndex);
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string str = textInfo.ToTitleCase(this.textBoxName.Text);
            this.textBoxName.Text = str;
            string str2 = textInfo.ToTitleCase(this.textBoxAddress.Text);
            this.textBoxAddress.Text = str2;
            this.textBoxCurrentPrice.Text = this.Service[1].ElementAt<string>(this.comboBoxService.SelectedIndex);
            this.labelId.Text = this.Service[2].ElementAt<string>(this.comboBoxService.SelectedIndex);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            long num = 0L;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
                num += long.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNew = new System.Windows.Forms.Button();
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
            this.labelId = new System.Windows.Forms.Label();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.textBoxCurrentPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDue = new System.Windows.Forms.TextBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonNew);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 230);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(237, 18);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(120, 30);
            this.buttonNew.TabIndex = 21;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date";
            // 
            // textBoxMemoNo
            // 
            this.textBoxMemoNo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMemoNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemoNo.Location = new System.Drawing.Point(78, 18);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.ReadOnly = true;
            this.textBoxMemoNo.Size = new System.Drawing.Size(117, 23);
            this.textBoxMemoNo.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Memo No";
            // 
            // textBoxContact
            // 
            this.textBoxContact.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(77, 201);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(280, 23);
            this.textBoxContact.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(77, 118);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(280, 81);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(77, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(280, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // comboBoxParty
            // 
            this.comboBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxParty.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(77, 67);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(280, 24);
            this.comboBoxParty.TabIndex = 5;
            this.comboBoxParty.SelectedIndexChanged += new System.EventHandler(this.comboBoxParty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 201);
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
            this.label2.Location = new System.Drawing.Point(11, 118);
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
            this.label19.Location = new System.Drawing.Point(11, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.labelId);
            this.groupBox2.Controls.Add(this.buttonAddInvoice);
            this.groupBox2.Controls.Add(this.textBoxCurrentPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 114);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(307, 76);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(52, 16);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "Charge";
            this.labelId.Visible = false;
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddInvoice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInvoice.Location = new System.Drawing.Point(130, 76);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(120, 30);
            this.buttonAddInvoice.TabIndex = 14;
            this.buttonAddInvoice.Text = "Add Item";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new System.EventHandler(this.buttonAddInvoice_Click);
            // 
            // textBoxCurrentPrice
            // 
            this.textBoxCurrentPrice.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCurrentPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPrice.Location = new System.Drawing.Point(78, 47);
            this.textBoxCurrentPrice.Name = "textBoxCurrentPrice";
            this.textBoxCurrentPrice.Size = new System.Drawing.Size(281, 23);
            this.textBoxCurrentPrice.TabIndex = 13;
            this.textBoxCurrentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Charge";
            // 
            // comboBoxService
            // 
            this.comboBoxService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxService.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxService.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(78, 21);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(281, 24);
            this.comboBoxService.TabIndex = 6;
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Service";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(379, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 459);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column7,
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(9, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "S/N";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 40;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Service";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "Charge";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "S";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.textBoxDue);
            this.groupBox4.Controls.Add(this.buttonPreview);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPaid);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 103);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // textBoxDue
            // 
            this.textBoxDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDue.Location = new System.Drawing.Point(240, 41);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new System.Drawing.Size(118, 22);
            this.textBoxDue.TabIndex = 35;
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreview.Location = new System.Drawing.Point(237, 69);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(120, 30);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.Text = "Print";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Due";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaid.Location = new System.Drawing.Point(86, 41);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(110, 22);
            this.textBoxPaid.TabIndex = 31;
            this.textBoxPaid.TextChanged += new System.EventHandler(this.textBoxPaid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Paid";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(86, 69);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmount.Location = new System.Drawing.Point(86, 17);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(272, 22);
            this.textBoxNetAmount.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Net Amount";
            // 
            // NewSaleService
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(824, 467);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "NewSaleService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sale Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.comboBoxService.Items.Clear();
            string query = "SELECT * FROM firoz_center.tbl_customer t order by customer_id;";
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
                        string str2 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, this.drawBrush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", this.fontSubHeading, this.drawBrush, new Rectangle(15, y, 800, this.fontSubHeading.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Memo :: " + this.textBoxMemoNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
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
            string text = this.textBoxMemoNo.Text;
            string str2 = this.textBoxName.Text;
            string str3 = "";
            string str4 = this.textBoxAddress.Text;
            string str5 = this.textBoxContact.Text;
            string query = "insert into firoz_center.tbl_customer (`name`,`fathers_name`,`address`,`contact`,`email`,`comments`,`type`) values ('" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','','','2');";
            this.dbc.Insert(query);
            query = "SELECT customer_id FROM firoz_center.tbl_customer where name='" + str2 + "' and address='" + str4 + "' and contact='" + str5 + "' and fathers_name='" + str3 + "';";
            string str7 = this.dbc.SelectSingle(query);
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                string str8 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str9 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str10 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                string str11 = "Insert into firoz_center.tbl_service (`service_id`,`memo_no`,`charge`) values ('" + str10 + "','" + text + "','" + str9 + "');";
                this.dbc.Insert(str11);
            }
            string str12 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str13 = this.textBoxNetAmount.Text;
            string str14 = "insert into firoz_center.tbl_sales_service (`memo_no`,`date`,`net_amount`,`discount`,`grand_total`,`user_id`,`customer_id`,`type`,`comments`,`paid_amount`,`due_amount`) values ('" + text + "','" + str12 + "','" + str13 + "','0','" + str13 + "','1','" + str7 + "','Service','','" + this.textBoxPaid.Text + "','" + this.textBoxDue.Text + "');";
            this.dbc.Insert(str14);
            string str15 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + text + "','" + this.textBoxPaid.Text + "','1','Sales Service','" + str12 + "');";
            this.dbc.Insert(str15);
            string str16 = "insert into firoz_center.tbl_payment (`memo_no`,`date`,`customer_id`,`amount`,`user_id`,`comments`) values ('" + text + "','" + str12 + "','" + str7 + "','" + this.textBoxPaid.Text + "','1','');";
            this.dbc.Insert(str16);
            this.buttonSave.Enabled = false;
            this.buttonSave.BackColor = Color.Red;
            MessageBox.Show("Saved");
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

