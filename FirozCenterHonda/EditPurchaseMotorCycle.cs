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

    public class EditPurchaseMotorCycle : Form
    {
        private string address;
        private ArrayList arrColumnLefts;
        private ArrayList arrColumnWidths;
        private bool bFirstPage;
        private bool bNewPage;
        private Button button3;
        private Button buttonAddNew;
        private Button buttonDeleteInvoice;
        private Button buttonPrint;
        private Button buttonS;
        private Button buttonSave;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
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
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private StringFormat sf;
        private StringFormat sfLeft;
        private StringFormat sfMiddle;
        private StringFormat sfRight;
        private StringFormat strFormat;
        private int tag;
        private TextBox textBoxChassisNo;
        private TextBox textBoxEngineNo;
        private TextBox textBoxInvoiceNo;
        private TextBox textBoxNetAmount;
        private TextBox textBoxNetAmountWords;
        private TextBox textBoxParty;
        private TextBox textBoxPricePerUnit;

        public EditPurchaseMotorCycle()
        {
            this.dbc = new DBConnect();
            this.address = "";
            this.contact = "";
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
            this.load_brand();
            this.comboBoxBrand.SelectedIndex = 0;
        }

        public EditPurchaseMotorCycle(string invoice)
        {
            this.dbc = new DBConnect();
            this.address = "";
            this.contact = "";
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
            this.load_brand();
            if (invoice.Equals(""))
            {
                this.buttonS.Visible = false;
                this.groupBox2.Visible = false;
            }
            else if (invoice.Equals("Delete"))
            {
                this.textBoxChassisNo.ReadOnly = true;
                this.textBoxEngineNo.ReadOnly = true;
                this.buttonAddNew.Visible = false;
                this.buttonPrint.Visible = false;
                this.buttonS.Visible = false;
                this.groupBox5.Visible = true;
            }
            else
            {
                this.textBoxInvoiceNo.Text = invoice;
                this.textBoxInvoiceNo.ReadOnly = true;
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            this.load_net_amount();
        }

        private void buttonAddNewParty_Click(object sender, EventArgs e)
        {
        }

        private void buttonDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete all including Invoice No?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "delete FROM firoz_center.tbl_vehicle where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
                query = "delete FROM firoz_center.tbl_transcation where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
                query = "delete FROM firoz_center.tbl_purchase where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
                query = "delete FROM firoz_center.tbl_party_transcation where invoice_no = '" + this.textBoxInvoiceNo.Text + "';";
                this.dbc.Delete(query);
            }
        }

        private void buttonPrlong_Click(object sender, EventArgs e)
        {
            if (this.tag == 0)
            {
            }
            if (MessageBox.Show("Do you want to print invoice?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (this.textBoxInvoiceNo.Text.Equals(""))
            {
                MessageBox.Show("Give Invoice No");
            }
            else if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
                this.tag = 1;
                this.buttonS.Enabled = false;
                this.buttonS.BackColor = Color.Red;
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

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
            this.comboBoxColor.SelectedIndex = 0;
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_cc();
            this.load_price();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string vehicleId = "";
            string engine = "";
            string chassis = "";
            string query = "select vehicle_id  from firoz_center.tbl_vehicle_info where brand='Honda' and model='" + this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' and cc='" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and color='" + this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'";
            vehicleId = this.dbc.SelectSingle(query);
            engine = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            chassis = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string text = this.textBoxInvoiceNo.Text;
            string s = this.textBoxNetAmount.Text;
            this.textBoxNetAmountWords.Text = double.Parse(s).ToString("n2");
            string str8 = "select purchase_rate  from firoz_center.tbl_vehicle where vehicleid='" + vehicleId + "' and invoice_no='" + text + "' and chasis_no='" + chassis + "' and engine_no='" + engine + "';";
            string str6 = this.dbc.SelectSingle(str8);
            new UpdatePurchaseMotorCycle(vehicleId, engine, chassis, text, s, str6).Show();
            base.Dispose();
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
            string query = "Select purchase_date from firoz_center.tbl_purchase where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
            if (this.dbc.Select_Date(query).Equals(""))
            {
                MessageBox.Show("Check Again!!!");
            }
            else
            {
                int num;
                string str3 = this.dbc.Select_Date_Format_2(query);
                string[] strArray = new string[5];
                strArray = str3.Split(new char[] { '-' });
                this.dateTimePicker1.Value = new DateTime(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]));
                query = "Select net_amount from firoz_center.tbl_purchase where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
                string s = this.dbc.SelectSingle(query);
                this.textBoxNetAmount.Text = s;
                this.textBoxNetAmountWords.Text = double.Parse(s).ToString("n2");
                query = "Select party_id from firoz_center.tbl_purchase where invoice_no='" + this.textBoxInvoiceNo.Text + "';";
                string str5 = this.dbc.SelectSingle(query);
                string str6 = "select name from firoz_center.tbl_party where customer_id = '" + str5 + "';";
                this.textBoxParty.Text = this.dbc.SelectSingle(str6);
                str6 = "select address from firoz_center.tbl_party where customer_id = '" + str5 + "';";
                this.address = this.dbc.SelectSingle(str6);
                str6 = "select contact from firoz_center.tbl_party where customer_id = '" + str5 + "';";
                this.contact = this.dbc.SelectSingle(str6);
                query = "select vehicleId,engine_no,chasis_no,purchase_rate,status from firoz_center.tbl_vehicle where invoice_no='" + this.textBoxInvoiceNo.Text + "' order by vehicleId;";
                List<string>[] listArray = new List<string>[5];
                for (num = 0; num < 5; num++)
                {
                    listArray[num] = new List<string>();
                }
                listArray = this.dbc.Select(5L, query);
                for (num = 0; num < listArray[0].Count; num++)
                {
                    string str7 = "select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray[0].ElementAt<string>(num).ToString() + "'";
                    List<string>[] listArray2 = new List<string>[4];
                    for (int i = 0; i < 4; i++)
                    {
                        listArray2[i] = new List<string>();
                    }
                    listArray2 = this.dbc.Select(4L, str7);
                    string str8 = listArray2[0].ElementAt<string>(0);
                    string str9 = listArray2[1].ElementAt<string>(0);
                    string str10 = listArray2[2].ElementAt<string>(0);
                    string str11 = listArray2[3].ElementAt<string>(0);
                    this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.RowCount + 1, str9, str10, str11, listArray[1].ElementAt<string>(num), listArray[2].ElementAt<string>(num), listArray[3].ElementAt<string>(num), "Old" });
                }
            }
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxNetAmountWords = new System.Windows.Forms.TextBox();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxParty = new System.Windows.Forms.TextBox();
            this.textBoxEngineNo = new System.Windows.Forms.TextBox();
            this.textBoxChassisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.textBoxPricePerUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxCC = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteInvoice = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8});
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(8, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(874, 488);
            this.dataGridView1.TabIndex = 0;
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
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "CC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Color";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 200F;
            this.Column5.HeaderText = "Engine No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 220;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Chassis No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 220;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price Per Unit";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 10;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 40F;
            this.Column8.HeaderText = "N";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 20;
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmount.Location = new System.Drawing.Point(100, 16);
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
            this.groupBox4.Controls.Add(this.buttonS);
            this.groupBox4.Controls.Add(this.buttonPrint);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 123);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // textBoxNetAmountWords
            // 
            this.textBoxNetAmountWords.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNetAmountWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmountWords.Location = new System.Drawing.Point(10, 42);
            this.textBoxNetAmountWords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNetAmountWords.Name = "textBoxNetAmountWords";
            this.textBoxNetAmountWords.ReadOnly = true;
            this.textBoxNetAmountWords.Size = new System.Drawing.Size(340, 22);
            this.textBoxNetAmountWords.TabIndex = 33;
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(226, 87);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(120, 30);
            this.buttonS.TabIndex = 32;
            this.buttonS.Text = "Save";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(100, 87);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(120, 30);
            this.buttonPrint.TabIndex = 31;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrlong_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Party";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date";
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(100, 16);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(101, 22);
            this.textBoxInvoiceNo.TabIndex = 18;
            this.textBoxInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInvoiceNo_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Invoice No";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(371, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 509);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxParty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxInvoiceNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(132, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 30);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxParty
            // 
            this.textBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParty.Location = new System.Drawing.Point(99, 41);
            this.textBoxParty.Name = "textBoxParty";
            this.textBoxParty.ReadOnly = true;
            this.textBoxParty.Size = new System.Drawing.Size(250, 22);
            this.textBoxParty.TabIndex = 22;
            // 
            // textBoxEngineNo
            // 
            this.textBoxEngineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngineNo.Location = new System.Drawing.Point(100, 168);
            this.textBoxEngineNo.Name = "textBoxEngineNo";
            this.textBoxEngineNo.Size = new System.Drawing.Size(148, 22);
            this.textBoxEngineNo.TabIndex = 18;
            // 
            // textBoxChassisNo
            // 
            this.textBoxChassisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChassisNo.Location = new System.Drawing.Point(100, 144);
            this.textBoxChassisNo.Name = "textBoxChassisNo";
            this.textBoxChassisNo.Size = new System.Drawing.Size(147, 22);
            this.textBoxChassisNo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Engine No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chassis No";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.Location = new System.Drawing.Point(255, 140);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(80, 30);
            this.buttonAddNew.TabIndex = 14;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // textBoxPricePerUnit
            // 
            this.textBoxPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPricePerUnit.Location = new System.Drawing.Point(100, 120);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.ReadOnly = true;
            this.textBoxPricePerUnit.Size = new System.Drawing.Size(147, 22);
            this.textBoxPricePerUnit.TabIndex = 13;
            this.textBoxPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Price";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(100, 94);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(253, 24);
            this.comboBoxColor.TabIndex = 9;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // comboBoxCC
            // 
            this.comboBoxCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new System.Drawing.Point(100, 68);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new System.Drawing.Size(253, 24);
            this.comboBoxCC.TabIndex = 8;
            this.comboBoxCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCC_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(100, 42);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(253, 24);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(100, 16);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(253, 24);
            this.comboBoxBrand.TabIndex = 6;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "CC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Brand";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxEngineNo);
            this.groupBox2.Controls.Add(this.textBoxChassisNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonAddNew);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 195);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox5.Controls.Add(this.buttonDeleteInvoice);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 442);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 72);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete";
            this.groupBox5.Visible = false;
            // 
            // buttonDeleteInvoice
            // 
            this.buttonDeleteInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteInvoice.Location = new System.Drawing.Point(56, 24);
            this.buttonDeleteInvoice.Name = "buttonDeleteInvoice";
            this.buttonDeleteInvoice.Size = new System.Drawing.Size(250, 30);
            this.buttonDeleteInvoice.TabIndex = 31;
            this.buttonDeleteInvoice.Text = "Delete Invoice";
            this.buttonDeleteInvoice.UseVisualStyleBackColor = false;
            this.buttonDeleteInvoice.Click += new System.EventHandler(this.buttonDeleteInvoice_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(99, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EditPurchaseMotorCycle
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1262, 522);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditPurchaseMotorCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Purchase Motor Cycle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
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
            this.comboBoxCC.SelectedIndex = 0;
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
            listArray = this.dbc.Select(1L, query);
            this.comboBoxColor.Items.Add("Select");
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxColor.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
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
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxModel.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_net_amount()
        {
            double num = long.Parse(this.textBoxPricePerUnit.Text);
            this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.RowCount + 1, this.comboBoxModel.SelectedItem.ToString(), this.comboBoxCC.SelectedItem.ToString(), this.comboBoxColor.SelectedItem.ToString(), this.textBoxChassisNo.Text, this.textBoxEngineNo.Text, this.textBoxPricePerUnit.Text, "New" });
            double num2 = 0.0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                num2 += double.Parse(this.dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            this.textBoxNetAmount.Text = num2.ToString();
            this.textBoxNetAmountWords.Text = double.Parse(num2.ToString()).ToString("n2");
            this.textBoxEngineNo.Text = "";
            this.textBoxChassisNo.Text = "";
        }

        private void load_price()
        {
            string query = "SELECT purchase_price FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' ORDER BY DATE DESC LIMIT 1;";
            string str2 = this.dbc.SelectSingle(query);
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
                        e.Graphics.DrawString("Purchase Motor Cycle :: Invoice No " + this.textBoxInvoiceNo.Text, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
                        y += 15;
                        e.Graphics.DrawString("Date :: " + str2, this.fontTitle, this.drawBrush, new Rectangle(15, y, 800, this.fontTitle.Height), this.sfMiddle);
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
                e.Graphics.DrawString("Net Amount: " + this.textBoxNetAmountWords.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 700, this.fontSubHeading.Height), this.sfRight);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void save_transcation()
        {
            string str = this.dateTimePicker1.Value.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
            string text = this.textBoxInvoiceNo.Text;
            string str3 = this.textBoxNetAmount.Text;
            string query = "update firoz_center.tbl_purchase set `grand_total`='" + str3 + "',`net_amount`='" + str3 + "' where invoice_no='" + text + "';";
            this.dbc.Update(query);
            query = "update firoz_center.tbl_transcation set `credit`='" + str3 + "' where invoice_no='" + text + "';";
            this.dbc.Update(query);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str5 = i.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str7 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str8 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                string str9 = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str10 = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                string str11 = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                if (this.dataGridView1.Rows[i].Cells[7].Value.ToString().Equals("New"))
                {
                    string str13 = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand ='Honda' and model='" + str6 + "' and cc='" + str7 + "' and color='" + str8 + "';";
                    string str14 = this.dbc.SelectSingle(str13);
                    query = "insert into firoz_center.tbl_vehicle (`invoice_no`,`vehicleid`,`engine_no`,`chasis_no`,`purchase_rate`,`status`) values ('" + text + "','" + str14 + "','" + str9 + "','" + str10 + "','" + str11 + "','stock');";
                    this.dbc.Insert(query);
                }
            }
        }

        private void textBoxInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.do_it();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

