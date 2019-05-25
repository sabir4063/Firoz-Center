namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class DuePaymentReport : Form
    {
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox comboBoxParty;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private List<string>[] Party = new List<string>[7];

        public DuePaymentReport()
        {
            this.InitializeComponent();
            this.load_customer();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.Party[0].ElementAt<string>(this.comboBoxParty.SelectedIndex).ToString();
            this.label2.Text = str;
            string query = "Select memo_no,DATE_FORMAT(date, '%d-%m-%Y') AS date1,grand_total,paid_amount,due_amount from firoz_center.tbl_sales_parts where customer_id = '" + str + "' order by memo_no";
            List<string>[] listArray = new List<string>[5];
            for (num = 0; num < 5; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(5L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str3 = listArray[0].ElementAt<string>(num);
                string str4 = listArray[1].ElementAt<string>(num);
                string str5 = listArray[2].ElementAt<string>(num);
                string str6 = listArray[3].ElementAt<string>(num);
                string str7 = listArray[4].ElementAt<string>(num);
                this.dataGridView1.Rows.Add(new object[] { str3, str4, str5, str6, str7 });
                string str8 = "Select DATE_FORMAT(date, '%d-%m-%Y') AS date1,amount from firoz_center.tbl_payment where memo_no='" + str3 + "';";
                List<string>[] listArray2 = new List<string>[2];
                int index = 0;
                while (index < 2)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(2L, str8);
                for (index = 0; index < listArray2[0].Count; index++)
                {
                    string str9 = listArray2[0].ElementAt<string>(index);
                    string str10 = listArray2[1].ElementAt<string>(index);
                    this.dataGridView1.Rows.Add(new object[] { "", str9, "", str10, "" });
                }
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
            this.dataGridView1 = new DataGridView();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.comboBoxParty = new ComboBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 0x22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(590, 0x1e8);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Due Report";
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
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column3, this.Column2, this.Column5, this.Column4, this.Column6 });
            this.dataGridView1.Location = new Point(6, 0x12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x23c, 0x1d2);
            this.dataGridView1.TabIndex = 0x24;
            this.Column3.FillWeight = 250f;
            this.Column3.HeaderText = "Memo No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = style2;
            this.Column2.FillWeight = 120f;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = style3;
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = style4;
            this.Column4.HeaderText = "Paid";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style5;
            this.Column6.HeaderText = "Due";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.comboBoxParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = SystemColors.Window;
            this.comboBoxParty.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new Point(70, 4);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new Size(0x16e, 0x1a);
            this.comboBoxParty.TabIndex = 0x34;
            this.comboBoxParty.SelectedIndexChanged += new EventHandler(this.comboBoxParty_SelectedIndexChanged);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x33;
            this.label1.Text = "Name";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x1d7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x17, 0x12);
            this.label2.TabIndex = 0x35;
            this.label2.Text = "ID";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(600, 0x20f);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.comboBoxParty);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "DuePaymentReport";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DuePaymentReport";
            this.groupBox1.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void load_customer()
        {
            int num;
            string query = "SELECT * FROM firoz_center.tbl_customer t where type='2' order by name;";
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
    }
}

