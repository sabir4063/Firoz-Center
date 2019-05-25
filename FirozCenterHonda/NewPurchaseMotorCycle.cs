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

    public class NewPurchaseMotorCycle : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonAddInvoice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private ComboBox comboBoxParty;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DateTimePicker dateTimePicker1;
        private static DBConnect dbc = new DBConnect();
        private SolidBrush drawBrush = new SolidBrush(Color.Black);
        private Font fontSubHeading = new Font("Serpentine-Bold", 14f);
        private Font fontTitle = new Font("Serpentine-Bold", 10f);
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private List<string>[] Invoice_list = new List<string>[1];
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private List<string>[] MotorCycle_details = new List<string>[2];
        private List<string>[] Party = new List<string>[6];
        private long q = 0L;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private int tag = 0;
        private TextBox textBox1;
        private TextBox textBoxChassisNo;
        private TextBox textBoxEngineNo;
        private TextBox textBoxInvoiceNo;
        private TextBox textBoxNetAmount;
        private TextBox textBoxNetAmountWords;
        private TextBox textBoxPricePerUnit;
        private TextBox textBoxQuantity;
        private List<string>[] Vehicle = new List<string>[6];

        public NewPurchaseMotorCycle()
        {
            this.InitializeComponent();
            this.reset_all();
            this.reset_party();
            this.reset_textbox();
            this.load_party();
            this.load_brand();
            this.load_invoice();
            this.comboBoxParty.SelectedIndex = 0;
            this.comboBoxBrand.SelectedIndex = 0;
            this.dateTimePicker1.Value = DateTime.Today;
        }

        private void add_quantity()
        {
            this.q += 1L;
            this.textBox1.Text = this.q.ToString();
            long num = long.Parse(this.textBoxQuantity.Text);
            if (this.q >= num)
            {
                MessageBox.Show("Check Quantity");
                this.comboBoxModel.Focus();
                this.textBox1.Text = "";
                this.textBoxQuantity.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddNewParty().Show();
            base.Close();
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            if (this.textBoxChassisNo.Text.Equals("") || this.textBoxEngineNo.Text.Equals(""))
            {
                MessageBox.Show("Please insert ENgine No & Chassis No!");
            }
            else
            {
                this.load_motorcycle_current();
                for (int i = 0; i < this.MotorCycle_details[0].Count; i++)
                {
                    if (this.MotorCycle_details[0].ElementAt<string>(i).Equals(this.textBoxEngineNo.Text))
                    {
                        MessageBox.Show("Duplicate Engine No!");
                        return;
                    }
                    if (this.MotorCycle_details[1].ElementAt<string>(i).Equals(this.textBoxChassisNo.Text))
                    {
                        MessageBox.Show("Duplicate Chassis No!");
                        return;
                    }
                }
                this.load_net_amount();
                this.textBoxChassisNo.Focus();
                this.add_quantity();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.load_brand();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Invoice_list[0].Count; i++)
            {
                if (this.textBoxInvoiceNo.Text.Equals(this.Invoice_list[0].ElementAt<string>(i)))
                {
                    MessageBox.Show("Duplicate Invoice No");
                    return;
                }
            }
            if (this.textBoxInvoiceNo.Text.Equals(""))
            {
                MessageBox.Show("Give Invoice No");
            }
            else if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
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

        private void comboBoxBrand_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
            this.load_price();
            this.comboBoxColor.SelectedIndex = 0;
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.q = 0L;
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_cc();
            this.comboBoxCC.SelectedIndex = 0;
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            long num = 0L;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                num += long.Parse(this.dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            this.textBoxNetAmount.Text = num.ToString();
            this.textBoxEngineNo.Text = "";
            this.textBoxChassisNo.Text = "";
            if (!this.textBox1.Text.Equals(""))
            {
                this.textBox1.Text = (int.Parse(this.textBox1.Text) - 1).ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
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
            this.label1 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.textBoxInvoiceNo = new TextBox();
            this.label11 = new Label();
            this.comboBoxParty = new ComboBox();
            this.groupBox2 = new GroupBox();
            this.textBox1 = new TextBox();
            this.label13 = new Label();
            this.label14 = new Label();
            this.textBoxQuantity = new TextBox();
            this.textBoxEngineNo = new TextBox();
            this.textBoxChassisNo = new TextBox();
            this.label2 = new Label();
            this.label3 = new Label();
            this.buttonAddInvoice = new Button();
            this.textBoxPricePerUnit = new TextBox();
            this.label10 = new Label();
            this.comboBoxColor = new ComboBox();
            this.comboBoxCC = new ComboBox();
            this.comboBoxModel = new ComboBox();
            this.comboBoxBrand = new ComboBox();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.groupBox3 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.groupBox5 = new GroupBox();
            this.dataGridView2 = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            this.textBoxNetAmountWords = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.textBoxNetAmount = new TextBox();
            this.label4 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox5.SuspendLayout();
            ((ISupportInitialize) this.dataGridView2).BeginInit();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBoxParty);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.ForeColor = Color.Black;
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Margin = new Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(4, 3, 4, 3);
            this.groupBox1.Size = new Size(360, 0x4b);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0x16);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(80, 0x10);
            this.label1.TabIndex = 0x15;
            this.label1.Text = "Select Party";
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x10b, 0x2f);
            this.dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x56, 0x16);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xd9, 0x31);
            this.label12.Margin = new Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxInvoiceNo.BackColor = SystemColors.Window;
            this.textBoxInvoiceNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxInvoiceNo.Location = new Point(100, 0x2f);
            this.textBoxInvoiceNo.Margin = new Padding(4, 3, 4, 3);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new Size(110, 0x16);
            this.textBoxInvoiceNo.TabIndex = 0x12;
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 0x31);
            this.label11.Margin = new Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x48, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Invoice No";
            this.comboBoxParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = SystemColors.Window;
            this.comboBoxParty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new Point(100, 20);
            this.comboBoxParty.Margin = new Padding(4, 3, 4, 3);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new Size(0xfd, 0x18);
            this.comboBoxParty.TabIndex = 5;
            this.comboBoxParty.SelectedIndexChanged += new EventHandler(this.comboBoxParty_SelectedIndexChanged);
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.textBoxEngineNo);
            this.groupBox2.Controls.Add(this.textBoxChassisNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonAddInvoice);
            this.groupBox2.Controls.Add(this.textBoxPricePerUnit);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.comboBoxCC);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.ForeColor = Color.Black;
            this.groupBox2.Location = new Point(5, 0x55);
            this.groupBox2.Margin = new Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new Padding(4, 3, 4, 3);
            this.groupBox2.Size = new Size(360, 0x103);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            this.textBox1.BackColor = SystemColors.Window;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox1.Location = new Point(0x107, 0x91);
            this.textBox1.Margin = new Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(90, 0x16);
            this.textBox1.TabIndex = 0x1c;
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(0xc9, 0x94);
            this.label13.Margin = new Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x38, 0x10);
            this.label13.TabIndex = 0x17;
            this.label13.Text = "Quantity";
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 0x91);
            this.label14.Margin = new Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x2d, 0x10);
            this.label14.TabIndex = 0x15;
            this.label14.Text = "Total: ";
            this.textBoxQuantity.BackColor = SystemColors.Window;
            this.textBoxQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxQuantity.Location = new Point(100, 0x91);
            this.textBoxQuantity.Margin = new Padding(4, 3, 4, 3);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new Size(0x62, 0x16);
            this.textBoxQuantity.TabIndex = 20;
            this.textBoxEngineNo.BackColor = SystemColors.Window;
            this.textBoxEngineNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEngineNo.Location = new Point(100, 0xc1);
            this.textBoxEngineNo.Margin = new Padding(4, 3, 4, 3);
            this.textBoxEngineNo.Name = "textBoxEngineNo";
            this.textBoxEngineNo.Size = new Size(0xfc, 0x16);
            this.textBoxEngineNo.TabIndex = 0x17;
            this.textBoxEngineNo.KeyDown += new KeyEventHandler(this.textBoxEngineNo_KeyDown);
            this.textBoxChassisNo.BackColor = SystemColors.Window;
            this.textBoxChassisNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxChassisNo.Location = new Point(100, 0xa9);
            this.textBoxChassisNo.Margin = new Padding(4, 3, 4, 3);
            this.textBoxChassisNo.Name = "textBoxChassisNo";
            this.textBoxChassisNo.Size = new Size(0xfc, 0x16);
            this.textBoxChassisNo.TabIndex = 0x15;
            this.textBoxChassisNo.TextChanged += new EventHandler(this.textBoxChassisNo_TextChanged);
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0xc2);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x47, 0x10);
            this.label2.TabIndex = 0x10;
            this.label2.Text = "Engine No";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 170);
            this.label3.Margin = new Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x4d, 0x10);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chassis No";
            this.buttonAddInvoice.BackColor = Color.MediumSeaGreen;
            this.buttonAddInvoice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonAddInvoice.Location = new Point(0x92, 0xdd);
            this.buttonAddInvoice.Margin = new Padding(4, 3, 4, 3);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new Size(120, 30);
            this.buttonAddInvoice.TabIndex = 0x1a;
            this.buttonAddInvoice.Text = "Add Item";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new EventHandler(this.buttonAddInvoice_Click);
            this.textBoxPricePerUnit.BackColor = SystemColors.Window;
            this.textBoxPricePerUnit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPricePerUnit.Location = new Point(100, 0x79);
            this.textBoxPricePerUnit.Margin = new Padding(4, 3, 4, 3);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.ReadOnly = true;
            this.textBoxPricePerUnit.Size = new Size(0x62, 0x16);
            this.textBoxPricePerUnit.TabIndex = 13;
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(10, 0x7a);
            this.label10.Margin = new Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x27, 0x10);
            this.label10.TabIndex = 11;
            this.label10.Text = "Price";
            this.comboBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = SystemColors.Window;
            this.comboBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new Point(100, 0x5f);
            this.comboBoxColor.Margin = new Padding(4, 3, 4, 3);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new Size(0xfd, 0x18);
            this.comboBoxColor.TabIndex = 9;
            this.comboBoxColor.SelectedIndexChanged += new EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = SystemColors.Window;
            this.comboBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new Point(100, 0x45);
            this.comboBoxCC.Margin = new Padding(4, 3, 4, 3);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new Size(0xfd, 0x18);
            this.comboBoxCC.TabIndex = 8;
            this.comboBoxCC.SelectedIndexChanged += new EventHandler(this.comboBoxCC_SelectedIndexChanged);
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.Window;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(100, 0x2b);
            this.comboBoxModel.Margin = new Padding(4, 3, 4, 3);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(0xfc, 0x18);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = SystemColors.Window;
            this.comboBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new Point(100, 0x11);
            this.comboBoxBrand.Margin = new Padding(4, 3, 4, 3);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new Size(0xfc, 0x18);
            this.comboBoxBrand.TabIndex = 6;
            this.comboBoxBrand.SelectedIndexChanged += new EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.comboBoxBrand.Click += new EventHandler(this.comboBoxBrand_Click);
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 0x61);
            this.label5.Margin = new Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(40, 0x10);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x48);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x1a, 0x10);
            this.label6.TabIndex = 3;
            this.label6.Text = "CC";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x2e);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 20);
            this.label8.Margin = new Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2c, 0x10);
            this.label8.TabIndex = 0;
            this.label8.Text = "Brand";
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.ForeColor = Color.Black;
            this.groupBox3.Location = new Point(370, 5);
            this.groupBox3.Margin = new Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new Padding(4, 3, 4, 3);
            this.groupBox3.Size = new Size(0x365, 510);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column4, this.Column7, this.Column5, this.Column6 });
            this.dataGridView1.Location = new Point(10, 15);
            this.dataGridView1.Margin = new Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x357, 0x1e4);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.Column1.HeaderText = "S/N";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            this.Column2.FillWeight = 150f;
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            this.Column3.FillWeight = 80f;
            this.Column3.HeaderText = "CC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            this.Column4.FillWeight = 80f;
            this.Column4.HeaderText = "Color";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            this.Column7.FillWeight = 250f;
            this.Column7.HeaderText = "Chassis No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 220;
            this.Column5.HeaderText = "Engine No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 220;
            this.Column6.HeaderText = "P";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 10;
            this.groupBox5.BackColor = Color.DarkSeaGreen;
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Controls.Add(this.textBoxNetAmountWords);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBoxNetAmount);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox5.ForeColor = Color.Black;
            this.groupBox5.Location = new Point(5, 350);
            this.groupBox5.Margin = new Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new Padding(4, 3, 4, 3);
            this.groupBox5.Size = new Size(360, 0xa5);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Amount";
            this.dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            this.dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4, this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn6, this.dataGridViewTextBoxColumn7 });
            this.dataGridView2.Location = new Point(0x182, -340);
            this.dataGridView2.Margin = new Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new Size(0x299, 0x1c9);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridViewTextBoxColumn1.FillWeight = 80f;
            this.dataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            this.dataGridViewTextBoxColumn2.FillWeight = 80f;
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            this.dataGridViewTextBoxColumn3.FillWeight = 80f;
            this.dataGridViewTextBoxColumn3.HeaderText = "CC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            this.dataGridViewTextBoxColumn4.FillWeight = 80f;
            this.dataGridViewTextBoxColumn4.HeaderText = "Color";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            this.dataGridViewTextBoxColumn5.HeaderText = "Chassis No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Engine No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.textBoxNetAmountWords.BackColor = SystemColors.Window;
            this.textBoxNetAmountWords.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmountWords.Location = new Point(12, 0x29);
            this.textBoxNetAmountWords.Margin = new Padding(4, 3, 4, 3);
            this.textBoxNetAmountWords.Name = "textBoxNetAmountWords";
            this.textBoxNetAmountWords.ReadOnly = true;
            this.textBoxNetAmountWords.Size = new Size(340, 0x16);
            this.textBoxNetAmountWords.TabIndex = 0x20;
            this.button1.BackColor = Color.MediumSeaGreen;
            this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(0xcc, 0x6b);
            this.button1.Margin = new Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 30);
            this.button1.TabIndex = 0x1f;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.buttonPrlong_Click);
            this.button2.BackColor = Color.MediumSeaGreen;
            this.button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(0x38, 0x6b);
            this.button2.Margin = new Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new Size(120, 30);
            this.button2.TabIndex = 30;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new EventHandler(this.buttonPreview_Click);
            this.button3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(100, 0xca);
            this.button3.Margin = new Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x4c, 0x17);
            this.button3.TabIndex = 0x1d;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.textBoxNetAmount.BackColor = SystemColors.Window;
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(100, 0x11);
            this.textBoxNetAmount.Margin = new Padding(4, 3, 4, 3);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(0xfc, 0x16);
            this.textBoxNetAmount.TabIndex = 0x16;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 20);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x4d, 0x10);
            this.label4.TabIndex = 0x15;
            this.label4.Text = "Net Amount";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x4da, 0x20a);
            base.Controls.Add(this.groupBox5);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            this.ForeColor = SystemColors.HotTrack;
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(4, 3, 4, 3);
            base.Name = "NewPurchaseMotorCycle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "New Purchase Motor Cycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((ISupportInitialize) this.dataGridView2).EndInit();
            base.ResumeLayout(false);
        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            string query = "SELECT brand FROM firoz_center.tbl_vehicle_info t group by brand";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(1L, query);
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
            this.textBoxQuantity.Text = "";
            this.textBox1.Text = "";
            string query = "SELECT cc FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' group by cc;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxCC.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_color()
        {
            int num;
            this.comboBoxColor.Items.Clear();
            string query = "SELECT color FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' group by color;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(1L, query);
            this.comboBoxColor.Items.Add("Select");
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxColor.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_invoice()
        {
            string query = "SELECT invoice_no from firoz_center.tbl_purchase where type ='Motor';";
            for (int i = 0; i < 1; i++)
            {
                this.Invoice_list[i] = new List<string>();
            }
            this.Invoice_list = dbc.Select(1L, query);
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            string query = "SELECT model FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' group by model;";
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

        private void load_motorcycle()
        {
            string query = "SELECT engine_no,chasis_no from firoz_center.tbl_vehicle;";
            for (int i = 0; i < 2; i++)
            {
                this.MotorCycle_details[i] = new List<string>();
            }
            this.MotorCycle_details = dbc.Select(2L, query);
        }

        private void load_motorcycle_current()
        {
            this.load_motorcycle();
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                this.MotorCycle_details[0].Add(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                this.MotorCycle_details[1].Add(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
        }

        private void load_net_amount()
        {
            long num = long.Parse(this.textBoxPricePerUnit.Text);
            this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count, this.comboBoxModel.SelectedItem.ToString(), this.comboBoxCC.SelectedItem.ToString(), this.comboBoxColor.SelectedItem.ToString(), this.textBoxChassisNo.Text, this.textBoxEngineNo.Text, this.textBoxPricePerUnit.Text });
            long num2 = 0L;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                num2 += long.Parse(this.dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            this.textBoxNetAmount.Text = num2.ToString();
            this.textBoxNetAmountWords.Text = dbc.NumberToText(num2.ToString());
            this.textBoxEngineNo.Text = "";
            this.textBoxChassisNo.Text = "";
        }

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
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
            string query = "SELECT purchase_price FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "';";
            string str2 = dbc.SelectSingle(query);
            this.textBoxPricePerUnit.Text = str2;
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
                        e.Graphics.DrawString("Purchase Motor Cycle :: Invoice No  " + this.textBoxInvoiceNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Date:" + str2, font2, this.drawBrush, new Rectangle(15, 10, 150, font2.Height), this.sfMiddle);
                        y = e.MarginBounds.Top;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            if (num4 <= 5)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                                e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iHeaderHeight), this.sfMiddle);
                                num4++;
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
                            if (num4 == 0)
                            {
                                this.sf = this.sfMiddle;
                            }
                            else
                            {
                                if ((num4 < 1) || (num4 > 5))
                                {
                                    continue;
                                }
                                this.sf = this.sfLeft;
                            }
                            e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                        }
                        if (num4 <= 5)
                        {
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iCellHeight));
                            num4++;
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
                e.Graphics.DrawString("Net Amount: " + this.textBoxNetAmountWords.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(20, y, 800, this.fontSubHeading.Height), this.sfLeft);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void reset_all()
        {
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxCC.Items.Clear();
        }

        private void reset_party()
        {
            this.textBoxInvoiceNo.Text = "";
        }

        private void reset_textbox()
        {
            this.textBoxEngineNo.Text = "";
            this.textBoxChassisNo.Text = "";
            this.textBoxPricePerUnit.Text = "";
            this.textBoxNetAmount.Text = "";
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string text = this.textBoxInvoiceNo.Text;
            long num = long.Parse(this.Party[0].ElementAt<string>(this.comboBoxParty.SelectedIndex).ToString());
            string query = string.Concat(new object[] { "insert into firoz_center.tbl_purchase (`invoice_no`,`purchase_date`,`grand_total`,`net_amount`,`user_id`,`party_id`,`type`) values ('", this.textBoxInvoiceNo.Text, "','", str, "','", this.textBoxNetAmount.Text, "','", this.textBoxNetAmount.Text, "','1','", num, "','Motor');" });
            connect.Insert(query);
            query = "insert into firoz_center.tbl_transcation (`invoice_no`,`credit`,`user_id`,`date`,`description`) values ('" + this.textBoxInvoiceNo.Text + "','" + this.textBoxNetAmount.Text + "','1','" + str + "','Purchase Motor Cycle');";
            connect.Insert(query);
            query = string.Concat(new object[] { "insert into firoz_center.tbl_party_transcation (`invoice_no`,`party_id`,`date`,`amount`,`description`,`type`,`details`) values ('", this.textBoxInvoiceNo.Text, "','", num, "','", str, "','", this.textBoxNetAmount.Text, "','Received Motor Cycle','Debit','Purchase');" });
            connect.Insert(query);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str4 = "Honda";
                string str5 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str7 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                string str8 = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str9 = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                string str10 = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                string str11 = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand ='" + str4 + "' and model='" + str5 + "' and cc='" + str6 + "' and color='" + str7 + "';";
                string str12 = connect.SelectSingle(str11);
                query = "insert into firoz_center.tbl_vehicle (`invoice_no`,`vehicleid`,`engine_no`,`chasis_no`,`purchase_rate`,`status`) values ('" + text + "','" + str12 + "','" + str9 + "','" + str8 + "','" + str10 + "','stock');";
                connect.Insert(query);
            }
            MessageBox.Show("Data Inserted");
            this.button2.Enabled = false;
            this.button2.BackColor = Color.Red;
            this.tag = 1;
        }

        private void textBoxChassisNo_TextChanged(object sender, EventArgs e)
        {
            this.textBoxChassisNo.TabIndex = 0x15;
        }

        private void textBoxEngineNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBoxChassisNo.Text.Equals("") || this.textBoxEngineNo.Text.Equals(""))
                {
                    MessageBox.Show("Please insert Engine No & Chassis No!");
                }
                else
                {
                    e.SuppressKeyPress = true;
                    this.load_net_amount();
                    this.textBoxChassisNo.Focus();
                    this.add_quantity();
                }
            }
        }

        private void textBoxEngineNo_TabIndexChanged(object sender, EventArgs e)
        {
            this.load_net_amount();
            this.textBoxChassisNo.Focus();
            this.add_quantity();
        }
    }
}

