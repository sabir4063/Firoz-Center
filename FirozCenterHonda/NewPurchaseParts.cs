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

    public class NewPurchaseParts : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonAddInvoice;
        private Button buttonPreview;
        private Button buttonPrlong;
        private Button buttonSave;
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
        private ComboBox comboBoxParty;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private static DBConnect dbc = new DBConnect();
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
        private List<string>[] Parts_details = new List<string>[2];
        private List<string>[] Party = new List<string>[6];
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private int tag = 0;
        private TextBox textBoxAvailable;
        private TextBox textBoxInvoiceNo;
        private TextBox textBoxNetAmount;
        private TextBox textBoxNetAmountWords;
        private TextBox textBoxPricePerUnit;
        private CheckBox checkBox1;
        private TextBox textBoxQuantity;

        public NewPurchaseParts()
        {
            this.InitializeComponent();
            this.load_party();
        }

        public void AutoNumberRowsForGridView(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                for (int i = 0; i <= (dataGridView.Rows.Count - 2); i++)
                {
                    dataGridView.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
            }
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            this.load_parts_current();
            this.load_net_amount();
            checkBox1.Checked = false;
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            new AddNewParts().Show();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (this.textBoxInvoiceNo.Text.Equals(""))
            {
                MessageBox.Show("Give Invoice No");
            }
            else if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_purchase();
                this.buttonPreview.Enabled = false;
                this.buttonPreview.BackColor = Color.Red;
                this.dataGridView1.Enabled = false;
                this.textBoxInvoiceNo.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.textBoxQuantity.Enabled = false;
                this.tag = 1;
            }
        }

        private void buttonPrlong_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
                MessageBox.Show("Save Invoice");
            }
            else if (MessageBox.Show("Do you want to print invoice?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
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

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_price();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            double num = 0.0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
                long num3 = long.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                double num4 = double.Parse(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                double num5 = num3 * num4;
                num += num5;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.textBoxPricePerUnit = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDescip = new System.Windows.Forms.ComboBox();
            this.comboBoxPartsNo = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxNetAmountWords = new System.Windows.Forms.TextBox();
            this.buttonPrlong = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxParty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAvailable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(371, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 445);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(9, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(719, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "S/N";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Model";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Parts No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "P";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "A";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 10;
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInvoice.Location = new System.Drawing.Point(226, 147);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(120, 30);
            this.buttonAddInvoice.TabIndex = 14;
            this.buttonAddInvoice.Text = "Add Item";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new System.EventHandler(this.buttonAddInvoice_Click);
            // 
            // textBoxPricePerUnit
            // 
            this.textBoxPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPricePerUnit.Location = new System.Drawing.Point(99, 120);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.ReadOnly = true;
            this.textBoxPricePerUnit.Size = new System.Drawing.Size(117, 22);
            this.textBoxPricePerUnit.TabIndex = 13;
            this.textBoxPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(99, 96);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(75, 22);
            this.textBoxQuantity.TabIndex = 9;
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantity_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity";
            // 
            // comboBoxDescip
            // 
            this.comboBoxDescip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxDescip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new System.Drawing.Point(99, 70);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new System.Drawing.Size(250, 24);
            this.comboBoxDescip.TabIndex = 19;
            this.comboBoxDescip.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            // 
            // comboBoxPartsNo
            // 
            this.comboBoxPartsNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new System.Drawing.Point(99, 44);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new System.Drawing.Size(250, 24);
            this.comboBoxPartsNo.TabIndex = 8;
            this.comboBoxPartsNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(99, 18);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(250, 24);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmount.Location = new System.Drawing.Point(96, 17);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(250, 22);
            this.textBoxNetAmount.TabIndex = 22;
            this.textBoxNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Net Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.textBoxNetAmountWords);
            this.groupBox4.Controls.Add(this.buttonPrlong);
            this.groupBox4.Controls.Add(this.buttonPreview);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 106);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // textBoxNetAmountWords
            // 
            this.textBoxNetAmountWords.Enabled = false;
            this.textBoxNetAmountWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmountWords.Location = new System.Drawing.Point(13, 42);
            this.textBoxNetAmountWords.Name = "textBoxNetAmountWords";
            this.textBoxNetAmountWords.ReadOnly = true;
            this.textBoxNetAmountWords.Size = new System.Drawing.Size(333, 22);
            this.textBoxNetAmountWords.TabIndex = 32;
            this.textBoxNetAmountWords.Visible = false;
            // 
            // buttonPrlong
            // 
            this.buttonPrlong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrlong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrlong.Location = new System.Drawing.Point(229, 70);
            this.buttonPrlong.Name = "buttonPrlong";
            this.buttonPrlong.Size = new System.Drawing.Size(120, 30);
            this.buttonPrlong.TabIndex = 31;
            this.buttonPrlong.Text = "Print";
            this.buttonPrlong.UseVisualStyleBackColor = false;
            this.buttonPrlong.Click += new System.EventHandler(this.buttonPrlong_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreview.Location = new System.Drawing.Point(96, 70);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(120, 30);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.Text = "Save";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(99, 202);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxParty);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(218, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Date";
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(99, 47);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(117, 22);
            this.textBoxInvoiceNo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Invoice No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select Party";
            // 
            // comboBoxParty
            // 
            this.comboBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(99, 19);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(250, 24);
            this.comboBoxParty.TabIndex = 5;
            this.comboBoxParty.SelectedIndexChanged += new System.EventHandler(this.comboBoxParty_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBoxAvailable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonAddInvoice);
            this.groupBox2.Controls.Add(this.textBoxPricePerUnit);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 186);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // textBoxAvailable
            // 
            this.textBoxAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailable.Location = new System.Drawing.Point(260, 96);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.ReadOnly = true;
            this.textBoxAvailable.Size = new System.Drawing.Size(89, 22);
            this.textBoxAvailable.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(235, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 20);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Urgent Order";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewPurchaseParts
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1123, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "NewPurchaseParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Purchase Parts";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void load_description_Parts()
        {
            int num;
            this.comboBoxDescip.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            string query = "SELECT description,partsNo FROM firoz_center.tbl_parts_info where model='" + this.comboBoxModel.SelectedItem.ToString() + "'  and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' group by description,partsNo;";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(2L, query);
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
            string str = this.comboBoxParty.SelectedItem.ToString();
            string query = "SELECT model FROM firoz_center.tbl_parts_info t where `group` = '" + str + "' group by model;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(1L, query);
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
                this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count + 1, this.comboBoxModel.SelectedItem.ToString(), this.comboBoxPartsNo.SelectedItem.ToString(), this.comboBoxDescip.SelectedItem.ToString(), this.textBoxQuantity.Text, this.textBoxPricePerUnit.Text, num3.ToString() });
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
                    this.textBoxNetAmountWords.Text = dbc.NumberToText(strArray[0]) + "Taka " + dbc.NumberToText(strArray[1]) + "Paisa";
                }
                else
                {
                    this.textBoxNetAmountWords.Text = dbc.NumberToText(this.textBoxNetAmount.Text) + "Taka ";
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

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string query = "SELECT * FROM firoz_center.tbl_party t order by customer_id;";
            for (num = 0; num < 6; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = dbc.Select(6L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_price()
        {
            string date = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string query = "Select purchase_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and `date`<='"+date+"' ORDER BY DATE DESC LIMIT 1;";
            string str2 = dbc.SelectSingle(query);
            query = "Select partsId from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ;";
            string str3 = dbc.SelectSingle(query);
            query = "Select count(*) from firoz_center.tbl_parts where partsId='" + str3 + "' and status like 'stock' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ;";
            string str4 = "0";
            str4 = dbc.SelectSingle(query);
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
                        e.Graphics.DrawString("Print Date:" + str, this.fontDate, this.drawBrush, new Rectangle(15, 10, 150, this.fontDate.Height), this.sfMiddle);
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iHeaderHeight), this.sfMiddle);
                            num4++;
                            if (num4 > 4)
                            {
                                break;
                            }
                        }
                        this.bNewPage = false;
                        y += this.iHeaderHeight;
                    }
                    num4 = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (num4 <= 2)
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if (num4 == 3)
                            {
                                this.sf = this.sfMiddle;
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
                        if (num4 > 4)
                        {
                            break;
                        }
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
                e.Graphics.DrawString("Net Amount: " + this.textBoxNetAmount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(15, y, 700, this.fontSubHeading.Height), this.sfRight);
                y += 20;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void save_purchase()
        {
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            long num = long.Parse(this.Party[0].ElementAt<string>(this.comboBoxParty.SelectedIndex).ToString());
            string query = string.Concat(new object[] { "insert into firoz_center.tbl_purchase (`invoice_no`,`purchase_date`,`grand_total`,`carring_cost`,`discount`,`exclusive_discount`,`net_amount`,`user_id`,`party_id`,`type`) values ('", this.textBoxInvoiceNo.Text, "','", str, "','", this.textBoxNetAmount.Text, "','0','0','0','", this.textBoxNetAmount.Text, "','1','", num, "','parts');" });
            dbc.Insert(query);
            query = "insert into firoz_center.tbl_transcation (`invoice_no`,`credit`,`user_id`,`date`,`description`) values ('" + this.textBoxInvoiceNo.Text + "','" + this.textBoxNetAmount.Text + "','1','" + str + "','Purchase Parts');";
            dbc.Insert(query);
            query = string.Concat(new object[] { "insert into firoz_center.tbl_party_transcation (`invoice_no`,`party_id`,`date`,`amount`,`description`,`type`,`details`) values ('", this.textBoxInvoiceNo.Text, "','", num, "','", str, "','", this.textBoxNetAmount.Text, "','Received Parts','Debit','Purchase');" });
            dbc.Insert(query);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str3 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str4 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str5 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                long num3 = long.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                double num4 = double.Parse(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                for (int j = 0; j < num3; j++)
                {
                    string str6 = "SELECT partsid FROM firoz_center.tbl_parts_info where partsNo='" + str4 + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ;";
                    string str7 = dbc.SelectSingle(str6);
                    string str8 = this.comboBoxParty.SelectedItem.ToString();
                    query = string.Concat(new object[] { "insert into firoz_center.tbl_parts (`invoice_no`,`partsid`,`purchase_rate`,`status`,`group`) values ('", this.textBoxInvoiceNo.Text, "','", str7, "','", num4, "','stock','", str8, "');" });
                    dbc.Insert(query);
                }
            }
        }

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_parts_current();
                this.load_net_amount();
                this.comboBoxPartsNo.Focus();
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked.Equals(true))
            {
                textBoxPricePerUnit.ReadOnly = false;
            }
            else
            {
                textBoxPricePerUnit.ReadOnly = true;
                this.load_price();
            }
        }
    }
}

