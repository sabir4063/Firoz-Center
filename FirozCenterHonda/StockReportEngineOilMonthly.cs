namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class StockReportEngineOilMonthly : Form
    {
        private Button buttonPrint;
        private Button buttonSearch;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelStock;
        private TextBox textBoxC;
        private TextBox textBoxO;
        private TextBox textBoxR;
        private TextBox textBoxS;
        private TextBox textBoxT;

        public StockReportEngineOilMonthly()
        {
            this.InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.load_stock();
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
            this.buttonPrint = new Button();
            this.labelStock = new Label();
            this.groupBox1 = new GroupBox();
            this.dateTimePicker2 = new DateTimePicker();
            this.label1 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.textBoxO = new TextBox();
            this.textBoxR = new TextBox();
            this.textBoxT = new TextBox();
            this.textBoxS = new TextBox();
            this.textBoxC = new TextBox();
            this.buttonSearch = new Button();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.buttonPrint.BackColor = Color.MediumSeaGreen;
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(0x9b, 0x33);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(0x4b, 0x1b);
            this.buttonPrint.TabIndex = 0x30;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = Color.DarkSeaGreen;
            this.labelStock.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelStock.Location = new Point(0x37, 0x5e);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new Size(0x3e, 0x10);
            this.labelStock.TabIndex = 0x31;
            this.labelStock.Text = "Opening:";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.textBoxS);
            this.groupBox1.Controls.Add(this.textBoxT);
            this.groupBox1.Controls.Add(this.textBoxR);
            this.groupBox1.Controls.Add(this.textBoxO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x130, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Stock Report";
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0xd0, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x55, 0x16);
            this.dateTimePicker2.TabIndex = 0x2c;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0xb0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x19, 0x10);
            this.label1.TabIndex = 0x2b;
            this.label1.Text = "To";
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x54, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x55, 0x16);
            this.dateTimePicker1.TabIndex = 0x26;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x43, 0x10);
            this.label12.TabIndex = 0x25;
            this.label12.Text = "Start Date";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x37, 0x76);
            this.label2.Name = "label2";
            this.label2.Size = new Size(70, 0x10);
            this.label2.TabIndex = 50;
            this.label2.Text = "Received:";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(0x37, 0x8e);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2a, 0x10);
            this.label3.TabIndex = 0x33;
            this.label3.Text = "Total:";
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0x37, 0xa6);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x27, 0x10);
            this.label4.TabIndex = 0x34;
            this.label4.Text = "Sale:";
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0x37, 190);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x38, 0x10);
            this.label5.TabIndex = 0x35;
            this.label5.Text = "Closing:";
            this.textBoxO.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxO.Location = new Point(0x88, 0x58);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.ReadOnly = true;
//            this.textBoxO.RightToLeft = RightToLeft.No;
            this.textBoxO.Size = new Size(110, 0x16);
            this.textBoxO.TabIndex = 0x36;
            this.textBoxR.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxR.Location = new Point(0x88, 0x70);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
//            this.textBoxR.RightToLeft = RightToLeft.No;
            this.textBoxR.Size = new Size(110, 0x16);
            this.textBoxR.TabIndex = 0x37;
            this.textBoxT.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxT.Location = new Point(0x88, 0x88);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
//            this.textBoxT.RightToLeft = RightToLeft.No;
            this.textBoxT.Size = new Size(110, 0x16);
            this.textBoxT.TabIndex = 0x38;
            this.textBoxS.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxS.Location = new Point(0x88, 160);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
//            this.textBoxS.RightToLeft = RightToLeft.No;
            this.textBoxS.Size = new Size(110, 0x16);
            this.textBoxS.TabIndex = 0x39;
            this.textBoxC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxC.Location = new Point(0x88, 0xb8);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
//            this.textBoxC.RightToLeft = RightToLeft.No;
            this.textBoxC.Size = new Size(110, 0x16);
            this.textBoxC.TabIndex = 0x3a;
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0x4d, 0x33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(0x4b, 0x1b);
            this.buttonSearch.TabIndex = 0x3b;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x139, 0xe5);
            base.Controls.Add(this.groupBox1);
            base.Name = "StockReportEngineOilMonthly";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "StockReportEngineOilMonthly";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_stock()
        {
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str3 = "2347";
            string query = "";
            query = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + str3 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str + "');";
            int num = int.Parse(this.dbc.SelectSingle(query));
            query = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + str3 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_parts t where date <'" + str + "');";
            string s = this.dbc.SelectSingle(query);
            string str7 = (num - int.Parse(s)).ToString();
            this.textBoxO.Text = str7;
            query = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + str3 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date between '" + str + "' and '" + str2 + "');";
            string str8 = this.dbc.SelectSingle(query);
            this.textBoxR.Text = str8;
            int num3 = int.Parse(str7) + int.Parse(str8);
            this.textBoxT.Text = num3.ToString();
            query = "SELECT count(*) FROM firoz_center.tbl_parts t where partsId='" + str3 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_parts t where date between '" + str + "' and '" + str2 + "');";
            string str9 = this.dbc.SelectSingle(query);
            this.textBoxS.Text = str9;
            this.textBoxC.Text = (num3 - int.Parse(str9)).ToString();
        }
    }
}

