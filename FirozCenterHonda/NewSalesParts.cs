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

    public class NewSalesParts : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonAddInvoice;
        private Button buttonNew;
        private Button buttonPreview;
        private Button buttonSave;
        private CheckBox checkBoxNew;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        public ComboBox comboBoxDescip;
        public ComboBox comboBoxGroup;
        public ComboBox comboBoxModel;
        public ComboBox comboBoxPartsNo;
        private ComboBox comboBoxParty;
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
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private List<string>[] Parts = new List<string>[6];
        private List<string>[] Parts_details = new List<string>[2];
        private List<string>[] Party = new List<string>[7];
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
        private TextBox textBoxDiscount;
        private TextBox textBoxDue;
        private TextBox textBoxInText;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxNetAmount;
        private TextBox textBoxPaid;
        private TextBox textBoxSell;
        private ComboBox comboBox1;
        private TextBox textBoxTotalAmount;

        public NewSalesParts()
        {
            this.InitializeComponent();
            this.checkBoxNew.Checked = true;
            this.load_party();
            this.load_group();
            string query = "SELECT max(memo_no) FROM firoz_center.tbl_sales_parts t;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxMemoNo.Text = "30000001";
            }
            else
            {
                string str2 = "SELECT max(memo_no) FROM firoz_center.tbl_sales_parts t;";
                this.textBoxMemoNo.Text = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }
        }

        private void add_item()
        {
            string str = this.comboBoxGroup.SelectedItem.ToString();
            string str2 = this.comboBoxModel.SelectedItem.ToString();
            string str3 = this.comboBoxPartsNo.SelectedItem.ToString();
            string str4 = this.comboBoxDescip.SelectedItem.ToString();
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
                    int num3;
                    for (num3 = 0; num3 < this.Parts_details[0].Count; num3++)
                    {
                        if (this.Parts_details[0].ElementAt<string>(num3).Equals(this.comboBoxPartsNo.SelectedItem.ToString()))
                        {
                            MessageBox.Show("Duplicate Parts No!");
                            return;
                        }
                    }
                    string str7 = (long.Parse(text) * long.Parse(s)).ToString();
                    this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count + 1, str2, str3, str4, text, s, str7, str });
                    long num4 = 0L;
                    for (num3 = 0; num3 < this.dataGridView1.Rows.Count; num3++)
                    {
                        num4 += long.Parse(this.dataGridView1.Rows[num3].Cells[6].Value.ToString());
                    }
                    this.textBoxNetAmount.Text = num4.ToString();
                    this.textBoxTotalAmount.Text = num4.ToString();
                    this.textBoxSell.Text = "";
                    this.comboBoxGroup.Focus();
                }
            }
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            this.load_parts_current();
            this.add_item();
        }

        private void buttonAddNewParty_Click(object sender, EventArgs e)
        {
            new AddNewCustomer().Show();
        }

        private void buttonAddNewParty_Click_1(object sender, EventArgs e)
        {
            new AddNewCustomer().Show();
            base.Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            base.Dispose();
            new NewSalesParts().Show();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
                MessageBox.Show("Please save sale");
            }
            else if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new PrintSaleParts(this.textBoxMemoNo.Text).Show();
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
                    this.groupBox3.Enabled = false;
                    this.groupBox2.Enabled = false;
                    this.comboBoxPartsNo.Enabled = true;
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

        private void comboBoxDescip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxPartsNo.SelectedIndex = this.comboBoxDescip.SelectedIndex;
            this.load_quantity();
            this.load_price();
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string str = textInfo.ToTitleCase(this.textBoxName.Text);
            this.textBoxName.Text = str;
            string str2 = textInfo.ToTitleCase(this.textBoxAddress.Text);
            this.textBoxAddress.Text = str2;
            this.load_description_Parts();
        }

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_quantity();
            this.load_price();
        }

        private void comboBoxParty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Party[1].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxAddress.Text = this.Party[2].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            this.textBoxContact.Text = this.Party[3].ElementAt<string>(this.comboBoxParty.SelectedIndex);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            long num = 0L;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = i + 1;
                num += long.Parse(this.dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            this.textBoxNetAmount.Text = num.ToString();
            this.textBoxSell.Text = "";
            this.comboBoxGroup.Focus();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxInText = new System.Windows.Forms.TextBox();
            this.textBoxDue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAvailable = new System.Windows.Forms.TextBox();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.textBoxCurrentPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDescip = new System.Windows.Forms.ComboBox();
            this.comboBoxPartsNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBoxTotalAmount);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxDiscount);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.buttonNew);
            this.groupBox4.Controls.Add(this.textBoxInText);
            this.groupBox4.Controls.Add(this.textBoxDue);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPaid);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonPreview);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 442);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(799, 98);
            this.groupBox4.TabIndex = 200;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(412, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 107;
            this.label16.Text = "In words: ";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(86, 65);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(110, 22);
            this.textBoxTotalAmount.TabIndex = 105;
            this.textBoxTotalAmount.TabStop = false;
            this.textBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 106;
            this.label15.Text = "Net Amount";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(86, 41);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(110, 22);
            this.textBoxDiscount.TabIndex = 103;
            this.textBoxDiscount.TabStop = false;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 104;
            this.label13.Text = "Discount";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(660, 63);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(120, 30);
            this.buttonNew.TabIndex = 15;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxInText
            // 
            this.textBoxInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInText.Location = new System.Drawing.Point(413, 37);
            this.textBoxInText.Name = "textBoxInText";
            this.textBoxInText.ReadOnly = true;
            this.textBoxInText.Size = new System.Drawing.Size(367, 22);
            this.textBoxInText.TabIndex = 37;
            this.textBoxInText.TabStop = false;
            this.textBoxInText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDue
            // 
            this.textBoxDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDue.Location = new System.Drawing.Point(266, 41);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new System.Drawing.Size(115, 22);
            this.textBoxDue.TabIndex = 35;
            this.textBoxDue.TabStop = false;
            this.textBoxDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Due";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaid.Location = new System.Drawing.Point(266, 17);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(115, 22);
            this.textBoxPaid.TabIndex = 13;
            this.textBoxPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPaid.TextChanged += new System.EventHandler(this.textBoxPaid_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Paid";
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreview.Location = new System.Drawing.Point(535, 63);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(120, 30);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.TabStop = false;
            this.buttonPreview.Text = "Print";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.BackColor = System.Drawing.Color.White;
            this.textBoxNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmount.Location = new System.Drawing.Point(86, 17);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(110, 22);
            this.textBoxNetAmount.TabIndex = 12;
            this.textBoxNetAmount.TabStop = false;
            this.textBoxNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(413, 63);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.comboBoxGroup);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxSell);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxAvailable);
            this.groupBox2.Controls.Add(this.buttonAddInvoice);
            this.groupBox2.Controls.Add(this.textBoxCurrentPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 182);
            this.groupBox2.TabIndex = 180;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(83, 18);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(284, 24);
            this.comboBoxGroup.TabIndex = 7;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 16);
            this.label17.TabIndex = 100;
            this.label17.Text = "Group";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(83, 44);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(284, 24);
            this.comboBoxModel.TabIndex = 8;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 98;
            this.label8.Text = "Model";
            // 
            // textBoxSell
            // 
            this.textBoxSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSell.Location = new System.Drawing.Point(238, 122);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.Size = new System.Drawing.Size(129, 22);
            this.textBoxSell.TabIndex = 11;
            this.textBoxSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSell.TextChanged += new System.EventHandler(this.textBoxSell_TextChanged);
            this.textBoxSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSell_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sell";
            // 
            // textBoxAvailable
            // 
            this.textBoxAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailable.Location = new System.Drawing.Point(83, 122);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.ReadOnly = true;
            this.textBoxAvailable.Size = new System.Drawing.Size(112, 22);
            this.textBoxAvailable.TabIndex = 20;
            this.textBoxAvailable.TabStop = false;
            this.textBoxAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInvoice.Location = new System.Drawing.Point(238, 146);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(129, 30);
            this.buttonAddInvoice.TabIndex = 12;
            this.buttonAddInvoice.Text = "Add Item";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new System.EventHandler(this.buttonAddInvoice_Click);
            // 
            // textBoxCurrentPrice
            // 
            this.textBoxCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPrice.Location = new System.Drawing.Point(83, 146);
            this.textBoxCurrentPrice.Name = "textBoxCurrentPrice";
            this.textBoxCurrentPrice.ReadOnly = true;
            this.textBoxCurrentPrice.Size = new System.Drawing.Size(112, 22);
            this.textBoxCurrentPrice.TabIndex = 97;
            this.textBoxCurrentPrice.TabStop = false;
            this.textBoxCurrentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 149);
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
            this.label9.Location = new System.Drawing.Point(10, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Available";
            // 
            // comboBoxDescip
            // 
            this.comboBoxDescip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxDescip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new System.Drawing.Point(83, 96);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new System.Drawing.Size(284, 24);
            this.comboBoxDescip.TabIndex = 10;
            this.comboBoxDescip.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            // 
            // comboBoxPartsNo
            // 
            this.comboBoxPartsNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new System.Drawing.Point(83, 70);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new System.Drawing.Size(284, 24);
            this.comboBoxPartsNo.TabIndex = 9;
            this.comboBoxPartsNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 97);
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
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 243);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(7, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(773, 221);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S/N";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Parts No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 270;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Group";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
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
            this.groupBox1.Size = new System.Drawing.Size(407, 182);
            this.groupBox1.TabIndex = 1;
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
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.textBoxMemoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemoNo.Location = new System.Drawing.Point(83, 19);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.ReadOnly = true;
            this.textBoxMemoNo.Size = new System.Drawing.Size(113, 22);
            this.textBoxMemoNo.TabIndex = 100;
            this.textBoxMemoNo.TabStop = false;
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
            this.textBoxContact.Size = new System.Drawing.Size(318, 22);
            this.textBoxContact.TabIndex = 6;
            this.textBoxContact.TabIndexChanged += new System.EventHandler(this.textBoxContact_TabIndexChanged);
            this.textBoxContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContact_KeyDown);
            this.textBoxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContact_KeyPress);
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
            this.comboBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(83, 43);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(171, 24);
            this.comboBoxParty.TabIndex = 3;
            this.comboBoxParty.SelectedIndexChanged += new System.EventHandler(this.comboBoxParty_SelectedIndexChanged_1);
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
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NewSalesParts
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(808, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "NewSalesParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartsSalesNew";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void load_description_Parts()
        {
            int num;
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string query = "SELECT description,partsNo FROM firoz_center.tbl_parts_info t where `group`='" + this.comboBoxGroup.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and partsid in(SELECT partsid FROM firoz_center.tbl_parts t where status like 'stock'  and partsId not like '2347' group by partsId)group by description,partsNo;";
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
                this.textBoxAvailable.Text = "";
                this.textBoxCurrentPrice.Text = "";
                this.textBoxSell.Text = "";
            }
        }

        private void load_group()
        {
            int num;
            this.comboBoxGroup.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            this.textBoxAvailable.Text = "";
            this.textBoxCurrentPrice.Text = "";
            this.textBoxSell.Text = "";
            string query = "SELECT `group` FROM firoz_center.tbl_parts_info group by `group`;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxGroup.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            this.textBoxAvailable.Text = "";
            this.textBoxCurrentPrice.Text = "";
            this.textBoxSell.Text = "";
            string query = "SELECT model FROM firoz_center.tbl_parts_info where `group`='" + this.comboBoxGroup.SelectedItem.ToString() + "' and model not like 'Engine Oil'  group by model;";
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
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            this.comboBoxGroup.Items.Clear();
            this.comboBoxModel.Items.Clear();
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
            string date = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select sale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxGroup.SelectedItem.ToString() + "' and `date`<='" + date + "' ORDER BY DATE DESC LIMIT 1;";

            string str2 = this.dbc.SelectSingle(query);
            this.textBoxCurrentPrice.Text = str2;
        }

        private void load_price(string type)
        {
            string query = "";
            string date = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (type.Equals("R"))
            {                
                query = "Select sale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and `date`<='" + date + "' ORDER BY DATE DESC LIMIT 1;";

            }
            else if (type.Equals("W"))
            {
                query = "Select wholesale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and `date`<='" + date + "' ORDER BY DATE DESC LIMIT 1;";                
            }
            else if (type.Equals("D"))
            {
                query = "Select wholesale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and `date`<='" + date + "' ORDER BY DATE DESC LIMIT 1;";                
            }
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxCurrentPrice.Text = str2;
        }

        private void load_quantity()
        {
            this.textBoxAvailable.Text = "";
            string query = "SELECT partsId FROM firoz_center.tbl_parts_info t where `group`='" + this.comboBoxGroup.SelectedItem.ToString() + "' and partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            query = "Select count(*) FROM firoz_center.tbl_parts where `group`='" + this.comboBoxGroup.SelectedItem.ToString() + "' and partsId='" + str2 + "' and status ='stock'";
            this.textBoxAvailable.Text = long.Parse(this.dbc.SelectSingle(query)).ToString();
        }

        private void print_preview()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            document.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
            document.DefaultPageSettings.PaperSize = new PaperSize("PaperA4", 700, 580);
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
                        string str2 = this.dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, this.drawBrush, new Rectangle(15, y, 700, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", this.fontSubHeading, this.drawBrush, new Rectangle(15, y, 700, this.fontSubHeading.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Invoice No :: " + this.textBoxMemoNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 700, this.fontTitle.Height), this.sfMiddle);
                        y += 15;
                        e.Graphics.DrawString("Date :: " + str2, this.fontTitle, this.drawBrush, new Rectangle(15, y, 700, this.fontTitle.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Print Date:" + str, this.fontDate, this.drawBrush, new Rectangle(15, 10, 150, this.fontDate.Height), this.sfMiddle);
                        e.Graphics.DrawString("Name: " + this.textBoxName.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 700, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        e.Graphics.DrawString("Address: " + this.textBoxAddress.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 700, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        e.Graphics.DrawString("Contact: " + this.textBoxContact.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 700, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        y = e.MarginBounds.Top + 100;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
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
                            if ((num4 == 2) || (num4 == 3))
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if ((num4 == 0) || (num4 == 1))
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
                e.Graphics.DrawString("Total Amount (In words): " + this.dbc.NumberToText(this.textBoxTotalAmount.Text) + " Taka", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 700, this.fontSubHeading.Height), this.sfLeft);
                e.Graphics.DrawString("Net Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 450, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxNetAmount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(450, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Discount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 450, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxDiscount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(450, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Total Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 450, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxTotalAmount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(450, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Paid Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 450, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxPaid.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(450, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Due Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 450, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxDue.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(450, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 150;
                e.Graphics.DrawString("Signature\nCustomer", this.fontTitle, this.drawBrush, new Rectangle(50, y, 450, this.fontTitle.Height * 3), this.sfLeft);
                e.Graphics.DrawString("Signature\nFiroz Motors", this.fontTitle, this.drawBrush, new Rectangle(50, y, 450, this.fontTitle.Height * 3), this.sfRight);
                y += 50;
                e.Graphics.DrawString("** Sold product will not be taken back **", this.fontDate, this.drawBrush, new Rectangle(0x19, y, 450, this.fontDate.Height), this.sfMiddle);
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
            this.load_price("W");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.load_price("D");
        }

        private void reset_price()
        {
            this.textBoxCurrentPrice.Text = "";
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
            string str10 = this.textBoxNetAmount.Text;
            string str11 = this.textBoxTotalAmount.Text;
            string str12 = this.textBoxDiscount.Text;
            string str13 = "insert into firoz_center.tbl_sales_parts (`memo_no`,`date`,`net_amount`,`discount`,`grand_total`,`user_id`,`customer_id`,`type`,`comments`,`paid_amount`,`due_amount`) values ('" + text + "','" + str9 + "','" + str10 + "','" + str12 + "','" + str11 + "','1','" + str8 + "','Sales Parts','','" + this.textBoxPaid.Text + "','" + this.textBoxDue.Text + "');";
            this.dbc.Insert(str13);
            string str14 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + text + "','" + this.textBoxPaid.Text + "','1','Sales Parts','" + str9 + "');";
            this.dbc.Insert(str14);
            string str15 = "insert into firoz_center.tbl_payment (`memo_no`,`date`,`customer_id`,`amount`,`user_id`,`comments`) values ('" + text + "','" + str9 + "','" + str8 + "','" + this.textBoxPaid.Text + "','1','');";
            this.dbc.Insert(str15);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str16 = this.dataGridView1.Rows[i].Cells[7].Value.ToString();
                string str17 = "select partsid from firoz_center.tbl_parts_info where partsNo='" + this.dataGridView1.Rows[i].Cells[2].Value.ToString() + "' and `group`='" + str16 + "';";
                string str18 = this.dbc.SelectSingle(str17);
                string s = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str20 = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                for (int j = 0; j < int.Parse(s); j++)
                {
                    string str21 = "update firoz_center.tbl_parts set `sale_rate`='" + str20 + "',`status`='sold',memo_no='" + text + "' where `group`='" + str16 + "' and partsid ='" + str18 + "' and status like '%stock%' limit 1; ";
                    this.dbc.Update(str21);
                }
            }
            MessageBox.Show("Sale Completed");
        }

        private void textBoxContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                this.comboBoxGroup.Focus();
            }
        }

        private void textBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxContact_TabIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxGroup.Focus();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxNetAmount.Text.Equals("") && !this.textBoxDiscount.Text.Equals(""))
            {
                if (this.textBoxDiscount.Text.Equals(""))
                {
                    this.textBoxTotalAmount.Text = this.textBoxNetAmount.Text;
                }
                else
                {
                    double num = double.Parse(this.textBoxNetAmount.Text);
                    double num2 = double.Parse(this.textBoxDiscount.Text);
                    double num3 = num - num2;
                    if (num2 > num3)
                    {
                        MessageBox.Show("Check Discount");
                    }
                    else
                    {
                        this.textBoxTotalAmount.Text = num3.ToString();
                    }
                }
            }
        }

        private void textBoxPaid_TextChanged_1(object sender, EventArgs e)
        {
            if (!this.textBoxTotalAmount.Text.Equals("") && !this.textBoxPaid.Text.Equals(""))
            {
                if (this.textBoxPaid.Text.Equals(""))
                {
                    this.textBoxDue.Text = this.textBoxTotalAmount.Text;
                }
                else
                {
                    double num = double.Parse(this.textBoxTotalAmount.Text);
                    double num2 = double.Parse(this.textBoxPaid.Text);
                    this.textBoxDue.Text = (num - num2).ToString();
                    if (num2 > num)
                    {
                        MessageBox.Show("Check Paid Amount");
                    }
                    else
                    {
                        if (num2 < num)
                        {
                            this.textBoxDue.BackColor = Color.Red;
                        }
                        else
                        {
                            this.textBoxDue.BackColor = Color.White;
                        }
                        this.textBoxInText.Text = this.dbc.NumberToText(num.ToString());
                    }
                }
            }
        }

        private void textBoxSell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.load_parts_current();
                this.add_item();
            }
        }

        private void textBoxSell_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Party[1].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.textBoxAddress.Text = this.Party[2].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.textBoxContact.Text = this.Party[3].ElementAt<string>(this.comboBox1.SelectedIndex);
        }
    }
}

