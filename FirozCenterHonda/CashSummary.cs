namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class CashSummary : Form
    {
        private Button buttonSearch;
        private IContainer components = null;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxAccountPayable;
        private TextBox textBoxAccountReceiavable;
        private TextBox textBoxBD;
        private TextBox textBoxCID;
        private TextBox textBoxDueReceiable;
        private TextBox textBoxMS;
        private TextBox textBoxPrev;
        private TextBox textBoxPS;
        private TextBox textBoxSS;

        public CashSummary()
        {
            this.InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "select sum(paid_amount) from firoz_center.tbl_sales_motorcycle  where date<'" + str + "'";
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            double num7 = 0.0;
            if (this.dbc.Count(query) >= 0L)
            {
                num = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(paid_amount) from firoz_center.tbl_sales_parts  where date<'" + str + "'";
            if (this.dbc.Count(query) >= 0L)
            {
                num2 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(paid_amount) from firoz_center.tbl_sales_service  where date<'" + str + "'";
            if (this.dbc.Count(query) >= 0L)
            {
                num3 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(amount) from firoz_center.tbl_bank_transcation  where date<'" + str + "' and amount>0";
            if (this.dbc.Count(query) >= 0L)
            {
                num4 = double.Parse(this.dbc.SelectSingle(query));
            }
            double num8 = ((num + num2) + num3) - num4;
            this.textBoxPrev.Text = num8.ToString();
            num = num2 = num3 = num4 = 0.0;
            query = "select sum(paid_amount) from firoz_center.tbl_sales_motorcycle  where date='" + str + "'";
            if (this.dbc.Count(query) >= 0L)
            {
                num = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(paid_amount) from firoz_center.tbl_sales_parts  where date='" + str + "'";
            if (this.dbc.Count(query) >= 0L)
            {
                num2 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(paid_amount) from firoz_center.tbl_sales_service  where date='" + str + "'";
            if (this.dbc.Count(query) >= 0L)
            {
                num3 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(amount) from firoz_center.tbl_bank_transcation  where date='" + str + "' and amount>0";
            if (this.dbc.Count(query) >= 0L)
            {
                num4 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(amount) from firoz_center.tbl_party_transcation  where date<='" + str + "' and type='Credit'";
            if (this.dbc.Count(query) >= 0L)
            {
                num5 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(amount) from firoz_center.tbl_party_transcation  where date<='" + str + "' and type='Debit'";
            if (this.dbc.Count(query) >= 0L)
            {
                num6 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(due_amount) from firoz_center.tbl_sales_motorcycle  where date<='" + str + "';";
            if (this.dbc.Count(query) >= 0L)
            {
                num7 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(due_amount) from firoz_center.tbl_sales_parts  where date<='" + str + "';";
            if (this.dbc.Count(query) >= 0L)
            {
                num7 += double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select sum(due_amount) from firoz_center.tbl_sales_service  where date<='" + str + "';";
            if (this.dbc.Count(query) >= 0L)
            {
                num7 += double.Parse(this.dbc.SelectSingle(query));
            }
            double num9 = (((num8 + num) + num3) + num2) - num4;
            this.textBoxMS.Text = num.ToString("n2");
            this.textBoxPS.Text = num2.ToString("n2");
            this.textBoxSS.Text = num3.ToString("n2");
            this.textBoxBD.Text = num4.ToString("n2");
            this.textBoxCID.Text = num9.ToString("n2");
            this.textBoxAccountPayable.Text = num6.ToString("n2");
            this.textBoxAccountReceiavable.Text = num5.ToString("n2");
            this.textBoxDueReceiable.Text = num7.ToString("n2");
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
            this.textBoxAccountPayable = new TextBox();
            this.label10 = new Label();
            this.textBoxDueReceiable = new TextBox();
            this.label9 = new Label();
            this.textBoxAccountReceiavable = new TextBox();
            this.label8 = new Label();
            this.textBoxPrev = new TextBox();
            this.label7 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.label6 = new Label();
            this.buttonSearch = new Button();
            this.textBoxCID = new TextBox();
            this.label2 = new Label();
            this.textBoxBD = new TextBox();
            this.label1 = new Label();
            this.textBoxSS = new TextBox();
            this.label5 = new Label();
            this.textBoxPS = new TextBox();
            this.textBoxMS = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxAccountPayable);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxDueReceiable);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxAccountReceiavable);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxPrev);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxCID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxBD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPS);
            this.groupBox1.Controls.Add(this.textBoxMS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x145, 0x13e);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Summary";
            this.textBoxAccountPayable.BackColor = Color.SeaShell;
            this.textBoxAccountPayable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAccountPayable.ForeColor = SystemColors.Desktop;
            this.textBoxAccountPayable.Location = new Point(0xa2, 0x110);
            this.textBoxAccountPayable.Name = "textBoxAccountPayable";
            this.textBoxAccountPayable.Size = new Size(0x7a, 0x16);
            this.textBoxAccountPayable.TabIndex = 0x54;
            this.textBoxAccountPayable.TextAlign = HorizontalAlignment.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.ForeColor = Color.Black;
            this.label10.Location = new Point(0x11, 0x113);
            this.label10.Name = "label10";
            this.label10.Size = new Size(110, 0x10);
            this.label10.TabIndex = 0x53;
            this.label10.Text = "Account Payable";
            this.textBoxDueReceiable.BackColor = Color.SeaShell;
            this.textBoxDueReceiable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDueReceiable.ForeColor = SystemColors.Desktop;
            this.textBoxDueReceiable.Location = new Point(0xa2, 0xf8);
            this.textBoxDueReceiable.Name = "textBoxDueReceiable";
            this.textBoxDueReceiable.Size = new Size(0x7a, 0x16);
            this.textBoxDueReceiable.TabIndex = 0x52;
            this.textBoxDueReceiable.TextAlign = HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.ForeColor = Color.Black;
            this.label9.Location = new Point(0x11, 0xfb);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x6a, 0x10);
            this.label9.TabIndex = 0x51;
            this.label9.Text = "Due Receivable";
            this.textBoxAccountReceiavable.BackColor = Color.SeaShell;
            this.textBoxAccountReceiavable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAccountReceiavable.ForeColor = SystemColors.Desktop;
            this.textBoxAccountReceiavable.Location = new Point(0xa2, 0xe0);
            this.textBoxAccountReceiavable.Name = "textBoxAccountReceiavable";
            this.textBoxAccountReceiavable.Size = new Size(0x7a, 0x16);
            this.textBoxAccountReceiavable.TabIndex = 80;
            this.textBoxAccountReceiavable.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.ForeColor = Color.Black;
            this.label8.Location = new Point(0x11, 0xe3);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x81, 0x10);
            this.label8.TabIndex = 0x4f;
            this.label8.Text = "Account Receivable";
            this.textBoxPrev.BackColor = Color.SeaShell;
            this.textBoxPrev.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrev.ForeColor = SystemColors.Desktop;
            this.textBoxPrev.Location = new Point(0xa2, 0xa2);
            this.textBoxPrev.Name = "textBoxPrev";
            this.textBoxPrev.Size = new Size(0x7a, 0x16);
            this.textBoxPrev.TabIndex = 0x4e;
            this.textBoxPrev.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.ForeColor = Color.Black;
            this.label7.Location = new Point(0x11, 0xa2);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x3d, 0x10);
            this.label7.TabIndex = 0x4d;
            this.label7.Text = "Previous";
            this.dateTimePicker2.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(60, 0x11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x7a, 0x16);
            this.dateTimePicker2.TabIndex = 0x4c;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(0x11, 0x17);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x25, 0x10);
            this.label6.TabIndex = 0x4b;
            this.label6.Text = "Date";
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0xbc, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(120, 30);
            this.buttonSearch.TabIndex = 0x4a;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.textBoxCID.BackColor = Color.SeaShell;
            this.textBoxCID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCID.ForeColor = SystemColors.Desktop;
            this.textBoxCID.Location = new Point(0xa2, 0xba);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new Size(0x7a, 0x16);
            this.textBoxCID.TabIndex = 0x49;
            this.textBoxCID.TextAlign = HorizontalAlignment.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(0x11, 0xba);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x58, 0x10);
            this.label2.TabIndex = 0x48;
            this.label2.Text = "Cash In Hand";
            this.textBoxBD.BackColor = Color.SeaShell;
            this.textBoxBD.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBD.ForeColor = SystemColors.Desktop;
            this.textBoxBD.Location = new Point(0xa2, 0x8a);
            this.textBoxBD.Name = "textBoxBD";
            this.textBoxBD.Size = new Size(0x7a, 0x16);
            this.textBoxBD.TabIndex = 0x47;
            this.textBoxBD.TextAlign = HorizontalAlignment.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(0x11, 0x8a);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x61, 0x10);
            this.label1.TabIndex = 70;
            this.label1.Text = "Bank Deposite";
            this.textBoxSS.BackColor = Color.SeaShell;
            this.textBoxSS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSS.ForeColor = SystemColors.Desktop;
            this.textBoxSS.Location = new Point(0xa2, 0x65);
            this.textBoxSS.Name = "textBoxSS";
            this.textBoxSS.Size = new Size(0x7a, 0x16);
            this.textBoxSS.TabIndex = 0x44;
            this.textBoxSS.TextAlign = HorizontalAlignment.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.Black;
            this.label5.Location = new Point(0x11, 0x65);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x5c, 0x10);
            this.label5.TabIndex = 0x43;
            this.label5.Text = "Service Sales";
            this.textBoxPS.BackColor = Color.SeaShell;
            this.textBoxPS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPS.ForeColor = SystemColors.Desktop;
            this.textBoxPS.Location = new Point(0xa2, 0x4d);
            this.textBoxPS.Name = "textBoxPS";
            this.textBoxPS.Size = new Size(0x7a, 0x16);
            this.textBoxPS.TabIndex = 0x42;
            this.textBoxPS.TextAlign = HorizontalAlignment.Right;
            this.textBoxMS.BackColor = Color.SeaShell;
            this.textBoxMS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMS.ForeColor = SystemColors.Desktop;
            this.textBoxMS.Location = new Point(0xa2, 0x35);
            this.textBoxMS.Name = "textBoxMS";
            this.textBoxMS.Size = new Size(0x7a, 0x16);
            this.textBoxMS.TabIndex = 0x41;
            this.textBoxMS.TextAlign = HorizontalAlignment.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(0x11, 0x4d);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x4d, 0x10);
            this.label4.TabIndex = 0x40;
            this.label4.Text = "Parts Sales";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(0x11, 0x35);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x75, 0x10);
            this.label3.TabIndex = 0x3f;
            this.label3.Text = "Motor Cycle Sales";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x14f, 0x147);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "CashSummary";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "CashSummary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

