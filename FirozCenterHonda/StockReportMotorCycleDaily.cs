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

    public class StockReportMotorCycleDaily : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
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
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label12;
        private Label labelStock;
        private Panel panel1;
        private RadioButton radioButtonDisplay;
        private RadioButton radioButtonStock;
        private RadioButton radioButtonStore;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private Button buttonSave;
        private StringFormat strFormat;

        public StockReportMotorCycleDaily()
        {
            this.InitializeComponent();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplay = new System.Windows.Forms.RadioButton();
            this.radioButtonStock = new System.Windows.Forms.RadioButton();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 500);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Stock Report";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonStore);
            this.panel1.Controls.Add(this.radioButtonDisplay);
            this.panel1.Controls.Add(this.radioButtonStock);
            this.panel1.Location = new System.Drawing.Point(325, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 21);
            this.panel1.TabIndex = 48;
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Location = new System.Drawing.Point(193, 1);
            this.radioButtonStore.Name = "radioButtonStore";
            this.radioButtonStore.Size = new System.Drawing.Size(50, 17);
            this.radioButtonStore.TabIndex = 4;
            this.radioButtonStore.TabStop = true;
            this.radioButtonStore.Text = "Store";
            this.radioButtonStore.UseVisualStyleBackColor = true;
            this.radioButtonStore.CheckedChanged += new System.EventHandler(this.radioButtonStore_CheckedChanged);
            // 
            // radioButtonDisplay
            // 
            this.radioButtonDisplay.AutoSize = true;
            this.radioButtonDisplay.Location = new System.Drawing.Point(81, 1);
            this.radioButtonDisplay.Name = "radioButtonDisplay";
            this.radioButtonDisplay.Size = new System.Drawing.Size(83, 17);
            this.radioButtonDisplay.TabIndex = 3;
            this.radioButtonDisplay.TabStop = true;
            this.radioButtonDisplay.Text = "Show Room";
            this.radioButtonDisplay.UseVisualStyleBackColor = true;
            this.radioButtonDisplay.CheckedChanged += new System.EventHandler(this.radioButtonDisplay_CheckedChanged);
            // 
            // radioButtonStock
            // 
            this.radioButtonStock.AutoSize = true;
            this.radioButtonStock.Location = new System.Drawing.Point(5, 1);
            this.radioButtonStock.Name = "radioButtonStock";
            this.radioButtonStock.Size = new System.Drawing.Size(53, 17);
            this.radioButtonStock.TabIndex = 1;
            this.radioButtonStock.TabStop = true;
            this.radioButtonStock.Text = "Stock";
            this.radioButtonStock.UseVisualStyleBackColor = true;
            this.radioButtonStock.CheckedChanged += new System.EventHandler(this.radioButtonStock_CheckedChanged);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(918, 17);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(45, 16);
            this.labelStock.TabIndex = 47;
            this.labelStock.Text = "Total: ";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(244, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 27);
            this.buttonPrint.TabIndex = 46;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(164, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 27);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column5,
            this.Column8,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(8, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(994, 455);
            this.dataGridView1.TabIndex = 42;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 250F;
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Opening";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 110F;
            this.Column1.HeaderText = "Received";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Sale";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Memo No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Closing";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Date";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(597, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // StockReportMotorCycleDaily
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1020, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockReportMotorCycleDaily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report MotorCycle Daily";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void load_stock()
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where (brand='HONDA' or brand = 'honda') order by cc,model asc ;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                Console.WriteLine(num);

                string str3 = listArray[0].ElementAt<string>(num);

                Console.WriteLine(str3);

                string str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                int num8 = int.Parse(this.dbc.SelectSingle(str4));
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "');";
                string s = this.dbc.SelectSingle(str4);
                string str7 = (num8 - int.Parse(s)).ToString();
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date ='" + str + "' );";
                string str8 = this.dbc.SelectSingle(str4);
                int num10 = int.Parse(str7) + int.Parse(str8);
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                string str9 = this.dbc.SelectSingle(str4);
                str4 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str4);
                string str10 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str10 = str10 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str11 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str3 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str11);
                int num12 = num10 - int.Parse(str9);
                this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), str7, str8, num10, str9, str10, num12 });
                num3 += int.Parse(str7);
                num4 += int.Parse(str8);
                num7 += num10;
                num6 += int.Parse(str9);
                num5 += num12;
                num2 += num12;
            }
            this.labelStock.Text = "Total: " + num2.ToString();
            this.dataGridView1.Rows.Add(new object[] { "", "Total: ", num3, num4, num7, num6, "", num2 });
        }

        private void load_stock(string status)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info order by cc,model asc";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str3 = listArray[0].ElementAt<string>(num);
                string str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                int num8 = int.Parse(this.dbc.SelectSingle(str4));
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "');";
                string s = this.dbc.SelectSingle(str4);
                string str7 = (num8 - int.Parse(s)).ToString();
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date ='" + str + "' );";
                string str8 = this.dbc.SelectSingle(str4);
                int num10 = int.Parse(str7) + int.Parse(str8);
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                string str9 = this.dbc.SelectSingle(str4);
                str4 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str4);
                string str10 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str10 = str10 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str11 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str3 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str11);
                int num12 = num10 - int.Parse(str9);
                this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), str7, str8, num10, str9, str10, num12 });
                num3 += int.Parse(str7);
                num4 += int.Parse(str8);
                num7 += num10;
                num6 += int.Parse(str9);
                num5 += num12;
                num2 += num12;
            }
            this.labelStock.Text = "Total: " + num2.ToString();
            this.dataGridView1.Rows.Add(new object[] { "", "Total: ", num3, num4, num7, num6, "", num2 });
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
                        StringFormat format = new StringFormat();
                        SolidBrush brush = new SolidBrush(Color.Black);
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
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Daily Stock Report: Motor Cycle     Date:" + str2, font4, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 20;
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
                            e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sfMiddle);
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

        private void radioButtonDisplay_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock("showroom");
        }

        private void radioButtonStock_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock();
        }

        private void radioButtonStore_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock("stock");
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

