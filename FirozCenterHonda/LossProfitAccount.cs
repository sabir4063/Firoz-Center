namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class LossProfitAccount : Form
    {
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label10;
        private Label label15;
        private Label label16;
        private Label label2;
        private Label label23;
        private Label label3;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private TextBox textBoxAP;
        private TextBox textBoxCS;
        private TextBox textBoxDR;
        private TextBox textBoxE;
        private TextBox textBoxOS;
        private TextBox textBoxP;
        private TextBox textBoxS;

        public LossProfitAccount()
        {
            this.InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int num;
            string str5;
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-01", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker1.Value.ToString("yyyy-MM-31", CultureInfo.InvariantCulture);
            string str3 = this.dateTimePicker1.Value.ToString("yyyy-MM", CultureInfo.InvariantCulture);
            string query = "select invoice_no from firoz_center.tbl_purchase  where purchase_date<'" + str + "' and type='parts' group by invoice_no;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            double num2 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                str5 = "SELECT sum(purchase_rate) FROM firoz_center.tbl_parts where invoice_no='" + listArray[0].ElementAt<string>(num) + "';";
                num2 += double.Parse(str5);
            }
            query = "select memo_no from firoz_center.tbl_sales_parts  where purchase_date<'" + str + "';";
            List<string>[] listArray2 = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray2[num] = new List<string>();
            }
            listArray2 = this.dbc.Select(1L, query);
            double num3 = 0.0;
            for (num = 0; num < listArray2[0].Count; num++)
            {
                str5 = "SELECT sum(purchase_rate) FROM firoz_center.tbl_parts where memo_no='" + listArray2[0].ElementAt<string>(num) + "';";
                num3 += double.Parse(str5);
            }
            double num4 = num2 - num3;
            query = "select invoice_no from firoz_center.tbl_purchase  where purchase_date<'" + str + "' and type='Motor' group by invoice_no;";
            List<string>[] listArray3 = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray3[num] = new List<string>();
            }
            listArray3 = this.dbc.Select(1L, query);
            double num5 = 0.0;
            for (num = 0; num < listArray3[0].Count; num++)
            {
                str5 = "SELECT sum(purchase_rate) FROM firoz_center.tbl_vehicle where invoice_no='" + listArray3[0].ElementAt<string>(num) + "';";
                num5 += double.Parse(str5);
            }
            query = "select memo_no from firoz_center.tbl_sales_motorcycle  where purchase_date<'" + str + "';";
            List<string>[] listArray4 = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray4[num] = new List<string>();
            }
            listArray4 = this.dbc.Select(1L, query);
            double num6 = 0.0;
            for (num = 0; num < listArray4[0].Count; num++)
            {
                str5 = "SELECT sum(purchase_rate) FROM firoz_center.tbl_vehicle where memo_no='" + listArray4[0].ElementAt<string>(num) + "';";
                num6 += double.Parse(str5);
            }
            double num7 = num5 - num6;
            this.textBoxOS.Text = (num4 + num7).ToString("n2");
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
            this.label7 = new Label();
            this.label16 = new Label();
            this.label8 = new Label();
            this.label10 = new Label();
            this.label15 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.panel1 = new Panel();
            this.label23 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label1 = new Label();
            this.textBoxOS = new TextBox();
            this.textBoxP = new TextBox();
            this.textBoxCS = new TextBox();
            this.textBoxS = new TextBox();
            this.textBoxAP = new TextBox();
            this.textBoxDR = new TextBox();
            this.textBoxE = new TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxE);
            this.groupBox1.Controls.Add(this.textBoxDR);
            this.groupBox1.Controls.Add(this.textBoxAP);
            this.groupBox1.Controls.Add(this.textBoxS);
            this.groupBox1.Controls.Add(this.textBoxCS);
            this.groupBox1.Controls.Add(this.textBoxP);
            this.groupBox1.Controls.Add(this.textBoxOS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(13, 0x30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1b6, 0x1da);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income Statement";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(13, 0xe7);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x4c, 0x10);
            this.label7.TabIndex = 5;
            this.label7.Text = "Expences";
            this.label16.AutoSize = true;
            this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label16.Location = new Point(13, 0xc0);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x81, 0x10);
            this.label16.TabIndex = 13;
            this.label16.Text = "Due Receiveable";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(13, 0x9b);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x7d, 0x10);
            this.label8.TabIndex = 6;
            this.label8.Text = "Account Payable";
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(13, 0x76);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x30, 0x10);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sales";
            this.label15.AutoSize = true;
            this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label15.Location = new Point(13, 0x51);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x67, 0x10);
            this.label15.TabIndex = 12;
            this.label15.Text = "Closing Stock";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(13, 0x30);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x49, 0x10);
            this.label3.TabIndex = 1;
            this.label3.Text = "Purchase";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x6d, 0x10);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opening Stock";
            this.panel1.BackColor = Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x1b6, 0x1d);
            this.panel1.TabIndex = 2;
            this.label23.AutoSize = true;
            this.label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label23.Location = new Point(0xca, 6);
            this.label23.Name = "label23";
            this.label23.Size = new Size(0x31, 0x10);
            this.label23.TabIndex = 3;
            this.label23.Text = "Month";
            this.dateTimePicker1.CustomFormat = "MMMM-yyyy";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0xff, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x75, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x9b, 0x13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profit and Loss Account";
            this.textBoxOS.Location = new Point(0x9c, 14);
            this.textBoxOS.Name = "textBoxOS";
            this.textBoxOS.Size = new Size(0xad, 20);
            this.textBoxOS.TabIndex = 14;
            this.textBoxP.Location = new Point(0x9c, 0x30);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new Size(0xad, 20);
            this.textBoxP.TabIndex = 15;
            this.textBoxCS.Location = new Point(0x9c, 0x51);
            this.textBoxCS.Name = "textBoxCS";
            this.textBoxCS.Size = new Size(0xad, 20);
            this.textBoxCS.TabIndex = 0x10;
            this.textBoxS.Location = new Point(0x9c, 0x76);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new Size(0xad, 20);
            this.textBoxS.TabIndex = 0x11;
            this.textBoxAP.Location = new Point(0x9c, 0x97);
            this.textBoxAP.Name = "textBoxAP";
            this.textBoxAP.Size = new Size(0xad, 20);
            this.textBoxAP.TabIndex = 0x12;
            this.textBoxDR.Location = new Point(0x9c, 0xbf);
            this.textBoxDR.Name = "textBoxDR";
            this.textBoxDR.Size = new Size(0xad, 20);
            this.textBoxDR.TabIndex = 0x13;
            this.textBoxE.Location = new Point(0x9c, 0xe3);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new Size(0xad, 20);
            this.textBoxE.TabIndex = 20;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1cf, 0x20f);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.groupBox1);
            base.Name = "LossProfitAccount";
            this.Text = "LossProfitAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

