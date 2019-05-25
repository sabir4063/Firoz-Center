namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class TranscationDaily : Form
    {
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label11;
        private Label label12;
        private TextBox textBoxNetAmount;
        private TextBox textBoxPreviousAmount;

        public TranscationDaily()
        {
            this.InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select invoice_no,credit,memo_no,debit,description from firoz_center.tbl_transcation where date = '" + str + "';";
            List<string>[] listArray = new List<string>[5];
            for (num = 0; num < 5; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(5L, query);
            double num2 = 0.0;
            double num3 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str3 = listArray[0].ElementAt<string>(num);
                string s = listArray[1].ElementAt<string>(num);
                string str5 = listArray[2].ElementAt<string>(num);
                string str6 = listArray[3].ElementAt<string>(num);
                string str7 = listArray[4].ElementAt<string>(num);
                if (!str3.Equals("-"))
                {
                    num2 += double.Parse(s);
                    this.dataGridView1.Rows.Add(new object[] { str3, s, str7, str5, str6, "" });
                }
                if (!str5.Equals("-"))
                {
                    num3 += double.Parse(str6);
                    this.dataGridView1.Rows.Add(new object[] { str3, s, "", str5, str6, str7 });
                }
            }
            this.dataGridView1.Rows.Add(new object[] { "Total: ", num2, "", "Total: ", num3, "" });
            this.textBoxNetAmount.Text = (num3 - num2).ToString();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string invoice = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string str2 = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string memo = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string str4 = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (!(invoice.Equals("-") || !str2.Equals("Motor Cycle")))
            {
                new EditPurchaseMotorCycle(invoice).Show();
            }
            else if (!(invoice.Equals("-") || !str2.Equals("Parts")))
            {
                new EditPurchaseParts(invoice).Show();
            }
            else if (!(memo.Equals("-") || !str4.Equals("Motor Cycle")))
            {
                new UpdateSaleMotorCycle(memo).Show();
            }
            else if (!(memo.Equals("-") || !str4.Equals("Parts")))
            {
                PrintSaleMotorCycle cycle3 = new PrintSaleMotorCycle(memo);
                cycle3.Show();
            }
            else if (!(memo.Equals("-") || !str4.Equals("Salary")))
            {
                new PrintSaleMotorCycle(memo).Show();
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
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            this.groupBox1 = new GroupBox();
            this.textBoxPreviousAmount = new TextBox();
            this.label1 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.dataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.buttonSearch = new Button();
            this.textBoxNetAmount = new TextBox();
            this.label11 = new Label();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxPreviousAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2bf, 0x1e7);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Transcation";
            this.textBoxPreviousAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPreviousAmount.Location = new Point(0x16e, 0x15);
            this.textBoxPreviousAmount.Name = "textBoxPreviousAmount";
            this.textBoxPreviousAmount.ReadOnly = true;
            this.textBoxPreviousAmount.Size = new Size(0x75, 0x16);
            this.textBoxPreviousAmount.TabIndex = 0x2b;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0xf7, 0x18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x6d, 0x10);
            this.label1.TabIndex = 0x2a;
            this.label1.Text = "Previous Amount";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new Point(0x38, 0x13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x6b, 0x16);
            this.dateTimePicker1.TabIndex = 0x26;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(11, 0x16);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x25;
            this.label12.Text = "Date";
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
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column5, this.Column3, this.Column4, this.Column6 });
            this.dataGridView1.Location = new Point(9, 0x30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x2ae, 0x1b1);
            this.dataGridView1.TabIndex = 0x24;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = style2;
            this.Column1.HeaderText = "Invoice No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = style3;
            this.Column2.FillWeight = 120f;
            this.Column2.HeaderText = "Credit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = style4;
            this.Column3.HeaderText = "Memo No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = style5;
            this.Column4.FillWeight = 120f;
            this.Column4.HeaderText = "Debit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0xa9, 0x12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(0x4b, 0x1b);
            this.buttonSearch.TabIndex = 0x27;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(0x247, 0x1f2);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(0x75, 0x16);
            this.textBoxNetAmount.TabIndex = 0x2b;
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(0x1f1, 0x1f6);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x4d, 0x10);
            this.label11.TabIndex = 0x2a;
            this.label11.Text = "Net Amount";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x2c8, 0x20c);
            base.Controls.Add(this.textBoxNetAmount);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.groupBox1);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Name = "TranscationDaily";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Transcation Daily";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

