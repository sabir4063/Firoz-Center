namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class BUsinessSummary : Form
    {
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label9;
        private TextBox textBoxAccountPayable;
        private TextBox textBoxAccountReceiavable;
        private TextBox textBoxCID;
        private TextBox textBoxDueReceiable;
        private TextBox textBoxMS;
        private TextBox textBoxPC;
        private TextBox textBoxPS;

        public BUsinessSummary()
        {
            this.InitializeComponent();
            this.load_data();
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
            this.textBoxAccountPayable = new TextBox();
            this.label10 = new Label();
            this.textBoxDueReceiable = new TextBox();
            this.label9 = new Label();
            this.textBoxAccountReceiavable = new TextBox();
            this.label8 = new Label();
            this.textBoxCID = new TextBox();
            this.label2 = new Label();
            this.textBoxPS = new TextBox();
            this.textBoxMS = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.groupBox1 = new GroupBox();
            this.textBoxPC = new TextBox();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.textBoxAccountPayable.BackColor = Color.SeaShell;
            this.textBoxAccountPayable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAccountPayable.ForeColor = SystemColors.Desktop;
            this.textBoxAccountPayable.Location = new Point(0x9d, 0xb5);
            this.textBoxAccountPayable.Name = "textBoxAccountPayable";
            this.textBoxAccountPayable.Size = new Size(0x7a, 0x16);
            this.textBoxAccountPayable.TabIndex = 0x54;
            this.textBoxAccountPayable.TextAlign = HorizontalAlignment.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.ForeColor = Color.Black;
            this.label10.Location = new Point(12, 0xb8);
            this.label10.Name = "label10";
            this.label10.Size = new Size(110, 0x10);
            this.label10.TabIndex = 0x53;
            this.label10.Text = "Account Payable";
            this.textBoxDueReceiable.BackColor = Color.SeaShell;
            this.textBoxDueReceiable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDueReceiable.ForeColor = SystemColors.Desktop;
            this.textBoxDueReceiable.Location = new Point(0x9d, 150);
            this.textBoxDueReceiable.Name = "textBoxDueReceiable";
            this.textBoxDueReceiable.Size = new Size(0x7a, 0x16);
            this.textBoxDueReceiable.TabIndex = 0x52;
            this.textBoxDueReceiable.TextAlign = HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.ForeColor = Color.Black;
            this.label9.Location = new Point(12, 0x99);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x6a, 0x10);
            this.label9.TabIndex = 0x51;
            this.label9.Text = "Due Receivable";
            this.textBoxAccountReceiavable.BackColor = Color.SeaShell;
            this.textBoxAccountReceiavable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAccountReceiavable.ForeColor = SystemColors.Desktop;
            this.textBoxAccountReceiavable.Location = new Point(0x9d, 0x7e);
            this.textBoxAccountReceiavable.Name = "textBoxAccountReceiavable";
            this.textBoxAccountReceiavable.Size = new Size(0x7a, 0x16);
            this.textBoxAccountReceiavable.TabIndex = 80;
            this.textBoxAccountReceiavable.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.ForeColor = Color.Black;
            this.label8.Location = new Point(12, 0x81);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x70, 0x10);
            this.label8.TabIndex = 0x4f;
            this.label8.Text = "Party Receivable";
            this.textBoxCID.BackColor = Color.SeaShell;
            this.textBoxCID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCID.ForeColor = SystemColors.Desktop;
            this.textBoxCID.Location = new Point(0x9d, 0x49);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new Size(0x7a, 0x16);
            this.textBoxCID.TabIndex = 0x49;
            this.textBoxCID.TextAlign = HorizontalAlignment.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(12, 0x49);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x58, 0x10);
            this.label2.TabIndex = 0x48;
            this.label2.Text = "Cash In Hand";
            this.textBoxPS.BackColor = Color.SeaShell;
            this.textBoxPS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPS.ForeColor = SystemColors.Desktop;
            this.textBoxPS.Location = new Point(0x9d, 0x2d);
            this.textBoxPS.Name = "textBoxPS";
            this.textBoxPS.Size = new Size(0x7a, 0x16);
            this.textBoxPS.TabIndex = 0x42;
            this.textBoxPS.TextAlign = HorizontalAlignment.Right;
            this.textBoxMS.BackColor = Color.SeaShell;
            this.textBoxMS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMS.ForeColor = SystemColors.Desktop;
            this.textBoxMS.Location = new Point(0x9d, 0x15);
            this.textBoxMS.Name = "textBoxMS";
            this.textBoxMS.Size = new Size(0x7a, 0x16);
            this.textBoxMS.TabIndex = 0x41;
            this.textBoxMS.TextAlign = HorizontalAlignment.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(12, 0x2d);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x4c, 0x10);
            this.label4.TabIndex = 0x40;
            this.label4.Text = "Parts Stock";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(12, 0x15);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x74, 0x10);
            this.label3.TabIndex = 0x3f;
            this.label3.Text = "Motor Cycle Stock";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxPC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAccountPayable);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxDueReceiable);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxAccountReceiavable);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxCID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPS);
            this.groupBox1.Controls.Add(this.textBoxMS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x12a, 0xf4);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Business Summary";
            this.textBoxPC.BackColor = Color.SeaShell;
            this.textBoxPC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPC.ForeColor = SystemColors.Desktop;
            this.textBoxPC.Location = new Point(0x9d, 0x61);
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.Size = new Size(0x7a, 0x16);
            this.textBoxPC.TabIndex = 0x56;
            this.textBoxPC.TextAlign = HorizontalAlignment.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(12, 0x61);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x10);
            this.label1.TabIndex = 0x55;
            this.label1.Text = "Petty Cash";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x134, 0xfc);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "BUsinessSummary";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BusinessSummary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_data()
        {
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:yyyy-MM-dd}", now);
            string query = "select round(sum(purchase_rate),2) from firoz_center.tbl_vehicle  where status like '%stock%';";
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
            query = "select  round(sum(purchase_rate),2) from firoz_center.tbl_parts  where status like '%stock%';";
            if (this.dbc.Count(query) >= 0L)
            {
                num2 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select  round(sum(amount),2) from firoz_center.tbl_payment  where bank_deposite like '0';";
            if (this.dbc.Count(query) >= 0L)
            {
                num3 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select  round(sum(amount),2) from firoz_center.tbl_cash_expences;";
            if (this.dbc.Count(query) >= 0L)
            {
                num7 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select round(sum(amount),2) from firoz_center.tbl_party_transcation  where date<='" + str + "' and type='Credit'";
            if (this.dbc.Count(query) >= 0L)
            {
                num4 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select round(sum(amount),2) from firoz_center.tbl_party_transcation  where date<='" + str + "' and type='Debit'";
            if (this.dbc.Count(query) >= 0L)
            {
                num5 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select round(sum(due_amount),2) from firoz_center.tbl_sales_motorcycle  where date<='" + str + "';";
            if (this.dbc.Count(query) >= 0L)
            {
                num6 = double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select round(sum(due_amount),2) from firoz_center.tbl_sales_parts  where date<='" + str + "';";
            if (this.dbc.Count(query) >= 0L)
            {
                num6 += double.Parse(this.dbc.SelectSingle(query));
            }
            query = "select round(sum(due_amount),2) from firoz_center.tbl_sales_service  where date<='" + str + "';";
            if (this.dbc.Count(query) >= 0L)
            {
                num6 += double.Parse(this.dbc.SelectSingle(query));
            }
            this.textBoxMS.Text = num.ToString("n2");
            this.textBoxPS.Text = num2.ToString("n2");
            this.textBoxPC.Text = num7.ToString("n2");
            this.textBoxCID.Text = num3.ToString("n2");
            double num8 = num5 - num4;
            if (num8 > 0.0)
            {
                num5 = num8;
                num4 = 0.0;
                this.textBoxAccountPayable.Text = num5.ToString("n2");
                this.textBoxAccountReceiavable.Text = num4.ToString("n2");
            }
            else
            {
                num5 = 0.0;
                num4 = Math.Abs(num8);
                this.textBoxAccountPayable.Text = num5.ToString("n2");
                this.textBoxAccountReceiavable.Text = num4.ToString("n2");
            }
            this.textBoxDueReceiable.Text = num6.ToString("n2");
        }
    }
}

