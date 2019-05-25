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

    public class PrintSaleParts : Form
    {
        private ArrayList arrColumnLefts;
        private ArrayList arrColumnWidths;
        private bool bFirstPage;
        private bool bNewPage;
        private Button buttonNew;
        private Button buttonPreview;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private IContainer components;
        private DataGridView dataGridView1;
        private DBConnect dbc;
        private SolidBrush drawBrush;
        private Font fontDate;
        private Font fontSubHeading;
        private Font fontTitle;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private int iCellHeight;
        private int iHeaderHeight;
        private int iRow;
        private int iTotalWidth;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private StringFormat sf;
        private StringFormat sfLeft;
        private StringFormat sfMiddle;
        private StringFormat sfRight;
        private StringFormat strFormat;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxDate;
        private TextBox textBoxDiscount;
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxNetAmount;
        private TextBox textBoxPaid;
        private TextBox textBoxTotalAmount;

        public PrintSaleParts()
        {
            this.dbc = new DBConnect();
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
            this.fontDate = new Font("Serpentine-Bold", 8f);
            this.components = null;
            this.InitializeComponent();
        }

        public PrintSaleParts(string memo_no)
        {
            this.dbc = new DBConnect();
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
            this.fontDate = new Font("Serpentine-Bold", 8f);
            this.components = null;
            this.InitializeComponent();
            this.textBoxMemoNo.Text = memo_no;
            this.load_transcation();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.load_transcation();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
                this.buttonPreview.BackColor = Color.Yellow;
                base.Dispose();
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
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.groupBox1 = new GroupBox();
            this.textBoxDate = new TextBox();
            this.buttonNew = new Button();
            this.label12 = new Label();
            this.textBoxMemoNo = new TextBox();
            this.label11 = new Label();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label19 = new Label();
            this.buttonPreview = new Button();
            this.groupBox4 = new GroupBox();
            this.textBoxTotalAmount = new TextBox();
            this.label15 = new Label();
            this.textBoxDiscount = new TextBox();
            this.label16 = new Label();
            this.textBoxDue = new TextBox();
            this.label7 = new Label();
            this.textBoxPaid = new TextBox();
            this.label4 = new Label();
            this.textBoxNetAmount = new TextBox();
            this.label14 = new Label();
            this.dataGridView1 = new DataGridView();
            this.groupBox3 = new GroupBox();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.buttonNew);
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
            this.groupBox1.Size = new Size(0x189, 0xcc);
            this.groupBox1.TabIndex = 0x22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.textBoxDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDate.Location = new Point(0x53, 0x2c);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new Size(0x8d, 0x16);
            this.textBoxDate.TabIndex = 0x20;
            this.buttonNew.BackColor = Color.MediumSeaGreen;
            this.buttonNew.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonNew.Location = new Point(0xf4, 0x1c);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new Size(120, 30);
            this.buttonNew.TabIndex = 0x1f;
            this.buttonNew.Text = "Search";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new EventHandler(this.buttonNew_Click);
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(10, 0x2c);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(0x53, 20);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x8d, 0x16);
            this.textBoxMemoNo.TabIndex = 0;
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
            this.textBoxContact.Location = new Point(0x53, 0xaf);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new Size(0x130, 0x16);
            this.textBoxContact.TabIndex = 3;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x53, 0x5c);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new Size(0x130, 0x51);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x53, 0x44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x130, 0x16);
            this.textBoxName.TabIndex = 1;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0xaf);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x5c);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0x48);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x2d, 0x10);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            this.buttonPreview.BackColor = Color.MediumSeaGreen;
            this.buttonPreview.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPreview.Location = new Point(0xfb, 0x45);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new Size(120, 30);
            this.buttonPreview.TabIndex = 30;
            this.buttonPreview.Text = "Print";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new EventHandler(this.buttonPreview_Click);
            this.groupBox4.BackColor = Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.textBoxTotalAmount);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxDiscount);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBoxDue);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxPaid);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonPreview);
            this.groupBox4.Controls.Add(this.textBoxNetAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox4.Location = new Point(5, 0xd7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0x189, 0x6b);
            this.groupBox4.TabIndex = 0x21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            this.textBoxTotalAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTotalAmount.Location = new Point(0x5d, 0x3f);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
//            this.textBoxTotalAmount.RightToLeft = RightToLeft.No;
            this.textBoxTotalAmount.Size = new Size(110, 0x16);
            this.textBoxTotalAmount.TabIndex = 0x71;
            this.label15.AutoSize = true;
            this.label15.BackColor = Color.DarkSeaGreen;
            this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label15.Location = new Point(7, 0x42);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x4d, 0x10);
            this.label15.TabIndex = 0x72;
            this.label15.Text = "Net Amount";
            this.textBoxDiscount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDiscount.Location = new Point(0x5d, 0x27);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
//            this.textBoxDiscount.RightToLeft = RightToLeft.No;
            this.textBoxDiscount.Size = new Size(110, 0x16);
            this.textBoxDiscount.TabIndex = 0x6f;
            this.label16.AutoSize = true;
            this.label16.BackColor = Color.DarkSeaGreen;
            this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label16.Location = new Point(0x1b, 0x29);
            this.label16.Name = "label16";
            this.label16.Size = new Size(60, 0x10);
            this.label16.TabIndex = 0x70;
            this.label16.Text = "Discount";
            this.textBoxDue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDue.Location = new Point(0x105, 0x29);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
//            this.textBoxDue.RightToLeft = RightToLeft.No;
            this.textBoxDue.Size = new Size(110, 0x16);
            this.textBoxDue.TabIndex = 0x23;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0xdf, 0x2c);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x21, 0x10);
            this.label7.TabIndex = 0x24;
            this.label7.Text = "Due";
            this.textBoxPaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPaid.Location = new Point(0x105, 0x11);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.ReadOnly = true;
//            this.textBoxPaid.RightToLeft = RightToLeft.No;
            this.textBoxPaid.Size = new Size(110, 0x16);
            this.textBoxPaid.TabIndex = 0x1f;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(220, 0x15);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x24, 0x10);
            this.label4.TabIndex = 0x20;
            this.label4.Text = "Paid";
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(0x5d, 15);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(110, 0x16);
            this.textBoxNetAmount.TabIndex = 0x16;
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(0x22, 20);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x27, 0x10);
            this.label14.TabIndex = 0x15;
            this.label14.Text = "Total";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column4, this.Column5, this.Column6, this.Column7 });
            this.dataGridView1.Location = new Point(6, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x19d, 0x126);
            this.dataGridView1.TabIndex = 100;
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(0x194, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(430, 0x13d);
            this.groupBox3.TabIndex = 0x20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.Column1.HeaderText = "S/N";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            this.Column4.FillWeight = 200f;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = style2;
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style3;
            this.Column6.FillWeight = 80f;
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = style4;
            this.Column7.FillWeight = 80f;
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x347, 0x147);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox3);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "PrintSaleParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PrintSaleParts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox3.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void load_transcation()
        {
            this.dataGridView1.Rows.Clear();
            string text = this.textBoxMemoNo.Text;
            string query = "Select net_amount,customer_id,type,paid_amount,due_amount,comments,grand_total,discount from firoz_center.tbl_sales_parts where memo_no='" + text + "';";
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
                this.textBoxNetAmount.Text = listArray[0].ElementAt<string>(0);
                this.textBoxPaid.Text = listArray[3].ElementAt<string>(0);
                this.textBoxDue.Text = listArray[4].ElementAt<string>(0);
                this.textBoxTotalAmount.Text = listArray[6].ElementAt<string>(0);
                this.textBoxDiscount.Text = listArray[7].ElementAt<string>(0);
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
                query = "Select partsId,sale_rate,count(*) from firoz_center.tbl_parts where memo_no='" + text + "' group by partsId;";
                List<string>[] listArray3 = new List<string>[3];
                num2 = 0;
                while (num2 < 3)
                {
                    listArray3[num2] = new List<string>();
                    num2++;
                }
                listArray3 = this.dbc.Select(3L, query);
                for (int i = 0; i < listArray3[0].Count; i++)
                {
                    query = "Select model,partsNo,description from firoz_center.tbl_parts_info where partsId='" + listArray3[0].ElementAt<string>(i) + "';";
                    List<string>[] listArray4 = new List<string>[3];
                    for (num2 = 0; num2 < 3; num2++)
                    {
                        listArray4[num2] = new List<string>();
                    }
                    listArray4 = this.dbc.Select(3L, query);
                    double num4 = double.Parse(listArray3[2].ElementAt<string>(0)) * double.Parse(listArray3[1].ElementAt<string>(i));
                    this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count + 1, listArray4[2].ElementAt<string>(0), listArray3[2].ElementAt<string>(i), listArray3[1].ElementAt<string>(i), num4 });
                }
                int rowCount = this.dataGridView1.RowCount;
                if (rowCount < 12)
                {
                    this.dataGridView1.Rows.Add((int) (12 - rowCount));
                }
                string str3 = this.dbc.SelectSingle("Select DATE_FORMAT(date, '%d-%m-%Y') AS date from firoz_center.tbl_sales_parts where memo_no='" + text + "';");
                this.textBoxDate.Text = str3;
            }
        }

        private void print_preview()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument {
                DefaultPageSettings = { PaperSize = new PaperSize("PaperA4", 640, 660) }
            };
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
                        Font font2 = new Font("Bookman Old Style", 8f);
                        Image image = Image.FromFile(@"D:\Logo.png");
                        e.Graphics.DrawImage(image, 5, 5, image.Width, image.Height);
                        e.Graphics.DrawString("Dealer: Bangladesh Honda Private Ltd.  ", font2, this.drawBrush, new Rectangle(5, 40, 280, font2.Height), this.sfMiddle);
                        y += 10;
                        e.Graphics.DrawString("Naiorpul, Sylhet", font2, this.drawBrush, new Rectangle(60, y, 320, this.fontTitle.Height), this.sfRight);
                        e.Graphics.DrawString("Mobile: 01738116666", font2, this.drawBrush, new Rectangle(370, y, 150, this.fontTitle.Height), this.sfRight);
                        y += 12;
                        e.Graphics.DrawString("Tel:0821727298", font2, this.drawBrush, new Rectangle(60, y, 320, this.fontTitle.Height), this.sfRight);
                        e.Graphics.DrawString("01199304020", font2, this.drawBrush, new Rectangle(370, y, 150, this.fontTitle.Height), this.sfRight);
                        y = 80;
                        e.Graphics.DrawString("SL No: " + this.textBoxMemoNo.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 640, this.fontTitle.Height), this.sfLeft);
                        e.Graphics.DrawString("Date: " + text, this.fontTitle, this.drawBrush, new Rectangle(50, y, 460, this.fontTitle.Height), this.sfRight);
                        y += 20;
                        e.Graphics.DrawString("Name: " + this.textBoxName.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 640, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        e.Graphics.DrawString("Address: " + this.textBoxAddress.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 640, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        e.Graphics.DrawString("Contact: " + this.textBoxContact.Text, this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 640, this.fontTitle.Height), this.sfLeft);
                        y += 20;
                        y = e.MarginBounds.Top + 60;
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
                            if (num4 == 1)
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if (num4 == 0)
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
                y = 560;
                e.Graphics.DrawString("Total Amount (In words): " + this.dbc.NumberToText(this.textBoxTotalAmount.Text) + "Taka", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 520, this.fontSubHeading.Height), this.sfLeft);
                y += 20;
                e.Graphics.DrawString("Net Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 420, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxNetAmount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(420, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Total Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 420, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxTotalAmount.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(420, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("Paid Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 420, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxPaid.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(420, y, 100, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString("Signature\nCustomer", this.fontTitle, this.drawBrush, new Rectangle(50, y, 420, this.fontTitle.Height * 3), this.sfLeft);
                y += 20;
                e.Graphics.DrawString("Due Amount: ", this.fontTitle, this.drawBrush, new Rectangle(0x19, y, 420, this.fontSubHeading.Height), this.sfRight);
                e.Graphics.DrawString(this.textBoxDue.Text + " Taka", this.fontTitle, this.drawBrush, new Rectangle(420, y, 100, this.fontSubHeading.Height), this.sfRight);
                y += 20;
                e.Graphics.DrawString("** Sold product will not be taken back **", this.fontDate, this.drawBrush, new Rectangle(0x19, y, 420, this.fontDate.Height), this.sfMiddle);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
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
    }
}

