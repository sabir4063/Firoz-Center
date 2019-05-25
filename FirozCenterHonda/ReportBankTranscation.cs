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

    public class ReportBankTranscation : Form
    {
        private List<string>[] ACNo = new List<string>[2];
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private List<string>[] Bank = new List<string>[1];
        private string bank_id = "";
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonPrint;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public ComboBox comboBoxACNo;
        private ComboBox comboBoxBank;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label2;
        private Label label3;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private Button buttonSave;
        private TextBox textBoxNetAmount;

        public ReportBankTranscation()
        {
            this.InitializeComponent();
            this.load_bank();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print report?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select bank_id,amount,description,DATE_FORMAT(date, '%Y-%m-%d') as date1,bank_transcation_id from firoz_center.tbl_bank_transcation where bank_id = '" + this.bank_id + "' and date between '" + str + "' and date'" + str2 + "' order by date asc;";
            List<string>[] listArray = new List<string>[5];
            for (num = 0; num < 5; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(5L, query);
            double num2 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string s = listArray[1].ElementAt<string>(num);
                string str5 = listArray[2].ElementAt<string>(num);
                string str6 = listArray[3].ElementAt<string>(num);
                string str7 = listArray[4].ElementAt<string>(num);
                string str8 = "Select name from firoz_center.tbl_bank_info where bank_id='" + this.bank_id + "'";
                string str9 = this.dbc.SelectSingle(str8);
                string str10 = "Select ac_no from firoz_center.tbl_bank_info where bank_id='" + this.bank_id + "'";
                string str11 = this.dbc.SelectSingle(str10);
                if (str5.Equals("Withdraw") || str5.Equals("Petty Cash"))
                {
                    num2 += double.Parse(s);
                    this.dataGridView1.Rows.Add(new object[] { str7, str6, str5, "-", s, num2 });
                }
                else
                {
                    num2 += double.Parse(s);
                    this.dataGridView1.Rows.Add(new object[] { str7, str6, str5, s, "-", num2 });
                }
            }
            this.textBoxNetAmount.Text = num2.ToString();
        }

        private void comboBoxACNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_bank_id();
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxACNo.Items.Clear();
            this.load_acno();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.comboBoxACNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.comboBoxACNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBank);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBoxNetAmount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 500);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Purchase";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(825, 15);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(65, 25);
            this.buttonPrint.TabIndex = 69;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // comboBoxACNo
            // 
            this.comboBoxACNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxACNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxACNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxACNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxACNo.FormattingEnabled = true;
            this.comboBoxACNo.Location = new System.Drawing.Point(318, 17);
            this.comboBoxACNo.Name = "comboBoxACNo";
            this.comboBoxACNo.Size = new System.Drawing.Size(116, 24);
            this.comboBoxACNo.TabIndex = 68;
            this.comboBoxACNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxACNo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "AC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Select Bank";
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBank.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new System.Drawing.Point(97, 16);
            this.comboBoxBank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(161, 24);
            this.comboBoxBank.TabIndex = 48;
            this.comboBoxBank.SelectedIndexChanged += new System.EventHandler(this.comboBoxBank_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(639, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 22);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 22);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column1,
            this.Column5,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(10, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 411);
            this.dataGridView1.TabIndex = 42;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Invoice No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 280;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Debit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Credit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "Balance";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmount.Location = new System.Drawing.Point(847, 471);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(117, 22);
            this.textBoxNetAmount.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(761, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Net Amount";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(752, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(65, 25);
            this.buttonSearch.TabIndex = 39;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(900, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 25);
            this.buttonSave.TabIndex = 70;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ReportBankTranscation
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(990, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportBankTranscation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportBankTranscation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void load_acno()
        {
            int num;
            string query = "SELECT bank_id,ac_no FROM firoz_center.tbl_bank_info where name='" + this.comboBoxBank.SelectedItem.ToString() + "';";
            for (num = 0; num < 2; num++)
            {
                this.ACNo[num] = new List<string>();
            }
            this.ACNo = this.dbc.Select(2L, query);
            for (num = 0; num < this.ACNo[0].Count; num++)
            {
                this.comboBoxACNo.Items.Add(this.ACNo[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_bank()
        {
            int num;
            string query = "SELECT name FROM firoz_center.tbl_bank_info t group by name;";
            for (num = 0; num < 1; num++)
            {
                this.Bank[num] = new List<string>();
            }
            this.Bank = this.dbc.Select(1L, query);
            for (num = 0; num < this.Bank[0].Count; num++)
            {
                this.comboBoxBank.Items.Add(this.Bank[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_bank_id()
        {
            string query = "SELECT bank_id FROM firoz_center.tbl_bank_info where name='" + this.comboBoxBank.SelectedItem.ToString() + "' and ac_no='" + this.comboBoxACNo.SelectedItem.ToString() + "';";
            this.bank_id = this.dbc.SelectSingle(query);
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
                        Font font2 = new Font("Serpentine-Bold", 14f);
                        Font font3 = new Font("Serpentine-Bold", 8f);
                        Font font4 = new Font("Serpentine-Bold", 10f);
                        SolidBrush brush = new SolidBrush(Color.Black);
                        this.sf.Alignment = StringAlignment.Center;
                        this.sf.LineAlignment = StringAlignment.Center;
                        this.sfLeft.Alignment = StringAlignment.Near;
                        this.sfLeft.LineAlignment = StringAlignment.Center;
                        this.sfMiddle.Alignment = StringAlignment.Center;
                        this.sfMiddle.LineAlignment = StringAlignment.Center;
                        this.sfRight.Alignment = StringAlignment.Far;
                        this.sfRight.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        string str2 = this.dateTimePicker1.Value.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
                        string str3 = this.dateTimePicker2.Value.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Report Bank Transcation", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Range:" + str2 + " to: " + str3, font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), this.sfMiddle);
                        y = e.MarginBounds.Top;
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
                            if ((num4 == 0) || (num4 == 1))
                            {
                                this.sf = this.sfMiddle;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if (num4 == 2)
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else
                            {
                                this.sf = this.sfRight;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) - 5), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                dbc.ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
    }
}

