namespace FirozCenterHonda
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class StockReportMotorCycleTranscation : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonPrint;
        private Button buttonSelect;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
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
        private Label label12;
        private Label labelStock;
        private Button buttonSave;
        private StringFormat strFormat;

        public StockReportMotorCycleTranscation()
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

        private void buttonSelect_Click(object sender, EventArgs e)
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

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (DateTime iteratorVariable0 = from.Date; iteratorVariable0.Date <= thru.Date; iteratorVariable0 = iteratorVariable0.AddDays(1.0))
            {
                yield return iteratorVariable0;
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(581, 16);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(45, 16);
            this.labelStock.TabIndex = 49;
            this.labelStock.Text = "Total: ";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(424, 11);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 27);
            this.buttonPrint.TabIndex = 48;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Size = new System.Drawing.Size(708, 460);
            this.dataGridView1.TabIndex = 42;
            // 
            // Column6
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column8.HeaderText = "Opening";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column1.FillWeight = 110F;
            this.Column1.HeaderText = "Received";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Sale";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column7.HeaderText = "Closing";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonSelect);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 505);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Stock Report";
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(348, 11);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 27);
            this.buttonSelect.TabIndex = 50;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(249, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 22);
            this.dateTimePicker2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Start Date";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(500, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 51;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // StockReportMotorCycleTranscation
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(730, 514);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockReportMotorCycleTranscation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockReportMotorCycleTranscation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void load_stock()
        {
            this.dataGridView1.Rows.Clear();
            string s = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime from = DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime thru = DateTime.ParseExact(str2, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            foreach (DateTime time3 in this.EachDay(from, thru))
            {
                string str5;
                int num3;
                double num4;
                string str3 = time3.ToString("yyyy-MM-dd");
                string query = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str3 + "') group by vehicleid;";
                List<string>[] listArray = new List<string>[2];
                int index = 0;
                while (index < 2)
                {
                    listArray[index] = new List<string>();
                    index++;
                }
                listArray = this.dbc.Select(2L, query);
                double num2 = 0.0;
                index = 0;
                while (index < listArray[0].Count)
                {
                    str5 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray[0].ElementAt<string>(index) + "'";
                    num3 = int.Parse(listArray[1].ElementAt<string>(index));
                    num4 = double.Parse(this.dbc.SelectSingle(str5));
                    num2 += num4 * num3;
                    index++;
                }
                string str6 = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str3 + "') group by vehicleid;";
                List<string>[] listArray2 = new List<string>[2];
                index = 0;
                while (index < 2)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(2L, str6);
                double num5 = 0.0;
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str5 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray2[0].ElementAt<string>(index) + "'";
                    num3 = int.Parse(listArray2[1].ElementAt<string>(index));
                    num4 = double.Parse(this.dbc.SelectSingle(str5));
                    num5 += num4 * num3;
                    index++;
                }
                num2 -= num5;
                string str7 = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date ='" + str3 + "') group by vehicleid;";
                List<string>[] listArray3 = new List<string>[2];
                index = 0;
                while (index < 2)
                {
                    listArray3[index] = new List<string>();
                    index++;
                }
                listArray3 = this.dbc.Select(2L, str7);
                double num6 = 0.0;
                index = 0;
                while (index < listArray3[0].Count)
                {
                    str5 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray3[0].ElementAt<string>(index) + "'";
                    num3 = int.Parse(listArray3[1].ElementAt<string>(index));
                    num4 = double.Parse(this.dbc.SelectSingle(str5));
                    num6 += num4 * num3;
                    index++;
                }
                double num7 = num2 + num6;
                string str8 = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str3 + "') group by vehicleid;";
                List<string>[] listArray4 = new List<string>[2];
                index = 0;
                while (index < 2)
                {
                    listArray4[index] = new List<string>();
                    index++;
                }
                listArray4 = this.dbc.Select(2L, str8);
                double num8 = 0.0;
                for (index = 0; index < listArray4[0].Count; index++)
                {
                    str5 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray4[0].ElementAt<string>(index) + "'";
                    num3 = int.Parse(listArray4[1].ElementAt<string>(index));
                    num4 = double.Parse(this.dbc.SelectSingle(str5));
                    num8 += num4 * num3;
                }
                double num9 = num7 - num8;
                this.dataGridView1.Rows.Add(new object[] { str3, num2, num6, num7, num8, num9 });
            }
            this.summary_stock();
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
                StringFormat format = new StringFormat();
                StringFormat format2 = new StringFormat();
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
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;
                        format2.Alignment = StringAlignment.Far;
                        format2.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        string str2 = this.dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        string str3 = this.dateTimePicker2.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), format);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), format);
                        y += 20;
                        e.Graphics.DrawString("Monthly Stock Report: Parts", font4, brush, new Rectangle(15, y, 800, font2.Height), format);
                        y += 20;
                        e.Graphics.DrawString("Range:" + str2 + " to " + str3, font4, brush, new Rectangle(15, y, 800, font4.Height), format);
                        y += 20;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), format);
                        y = e.MarginBounds.Top;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iHeaderHeight), format);
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
                            e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) (((int) this.arrColumnWidths[num4]) - 10), (float) this.iCellHeight), format2);
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

        public void summary_stock()
        {
            int num;
            string str4;
            int num3;
            double num4;
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str + "') group by vehicleid;";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(2L, query);
            double num2 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                str4 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray[0].ElementAt<string>(num) + "'";
                num3 = int.Parse(listArray[1].ElementAt<string>(num));
                num4 = double.Parse(this.dbc.SelectSingle(str4));
                num2 += num4 * num3;
            }
            string str5 = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "') group by vehicleid;";
            List<string>[] listArray2 = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray2[num] = new List<string>();
            }
            listArray2 = this.dbc.Select(2L, str5);
            double num5 = 0.0;
            for (num = 0; num < listArray2[0].Count; num++)
            {
                str4 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray2[0].ElementAt<string>(num) + "'";
                num3 = int.Parse(listArray2[1].ElementAt<string>(num));
                num4 = double.Parse(this.dbc.SelectSingle(str4));
                num5 += num4 * num3;
            }
            num2 -= num5;
            string str6 = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date between '" + str + "' and '" + str2 + "') group by vehicleid;";
            List<string>[] listArray3 = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray3[num] = new List<string>();
            }
            listArray3 = this.dbc.Select(2L, str6);
            double num6 = 0.0;
            for (num = 0; num < listArray3[0].Count; num++)
            {
                str4 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray3[0].ElementAt<string>(num) + "'";
                num3 = int.Parse(listArray3[1].ElementAt<string>(num));
                num4 = double.Parse(this.dbc.SelectSingle(str4));
                num6 += num4 * num3;
            }
            double num7 = num2 + num6;
            string str7 = "SELECT vehicleid,count(*) FROM firoz_center.tbl_vehicle t where memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between'" + str + "' and '" + str2 + "') group by vehicleid;";
            List<string>[] listArray4 = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray4[num] = new List<string>();
            }
            listArray4 = this.dbc.Select(2L, str7);
            double num8 = 0.0;
            for (num = 0; num < listArray4[0].Count; num++)
            {
                str4 = "SELECT sale_price from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray4[0].ElementAt<string>(num) + "'";
                num3 = int.Parse(listArray4[1].ElementAt<string>(num));
                num4 = double.Parse(this.dbc.SelectSingle(str4));
                num8 += num4 * num3;
            }
            double num9 = num7 - num8;
            this.dataGridView1.Rows.Add(new object[] { "Summary", num2, num6, num7, num8, num9 });
            this.labelStock.Text = "In Stock: " + num9.ToString() + " Taka";
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

