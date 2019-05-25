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

    public class DueReportName : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonPrint;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private string tag = "";

        public DueReportName(string tag)
        {
            this.InitializeComponent();
            this.tag = tag;
            this.load_data(tag);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print report?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.tag.Equals("MotorCycle"))
            {
                new DuePaymentMotorCycle(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
            }
            else if (this.tag.Equals("Parts"))
            {
                new DuePaymentParts(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
            }
            else
            {
                new DuePaymentService(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.tag.Equals("MotorCycle"))
            {
                new DuePaymentMotorCycle(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
            }
            else if (this.tag.Equals("Parts"))
            {
                new DuePaymentParts(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
            }
            else
            {
                new DuePaymentService(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
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
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            this.groupBox1 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.buttonPrint = new Button();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x354, 0x1e8);
            this.groupBox1.TabIndex = 3;
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
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column5, this.Column4, this.Column6 });
            this.dataGridView1.Location = new Point(6, 0x11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x347, 0x1d2);
            this.dataGridView1.TabIndex = 0x25;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick_1);
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = style2;
            this.Column1.HeaderText = "Customer Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            style3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = style3;
            this.Column2.FillWeight = 120f;
            this.Column2.HeaderText = "Invoice No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            this.Column3.FillWeight = 250f;
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = style4;
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = style5;
            this.Column4.HeaderText = "Paid";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            style6.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style6;
            this.Column6.HeaderText = "Due";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.buttonPrint.BackColor = Color.MediumSeaGreen;
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(0x17b, 0x1ef);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(120, 30);
            this.buttonPrint.TabIndex = 0x2f;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x35e, 0x20f);
            base.Controls.Add(this.buttonPrint);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "DueReportName";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Due Report";
            this.groupBox1.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        private void load_data(string tag)
        {
            int num;
            string query = "";
            if (tag.Equals("MotorCycle"))
            {
                query = "Select memo_no,DATE_FORMAT(date, '%d-%m-%Y') AS date1,customer_id,net_amount,paid_amount,due_amount from firoz_center.tbl_sales_motorcycle where due_amount>0 order by customer_id asc;";
            }
            else if (tag.Equals("Parts"))
            {
                query = "Select memo_no,DATE_FORMAT(date, '%d-%m-%Y') AS date1,customer_id,net_amount,paid_amount,due_amount from firoz_center.tbl_sales_parts where due_amount>0 order by customer_id asc;";
            }
            else
            {
                query = "Select memo_no,DATE_FORMAT(date, '%d-%m-%Y') AS date1,customer_id,net_amount,paid_amount,due_amount from firoz_center.tbl_sales_service where due_amount>0 order by customer_id asc;";
            }
            List<string>[] listArray = new List<string>[6];
            for (num = 0; num < 6; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(6L, query);
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = "Select name from firoz_center.tbl_customer where customer_id='" + listArray[2].ElementAt<string>(num) + "';";
                string str3 = this.dbc.SelectSingle(str2);
                string str4 = listArray[2].ElementAt<string>(num);
                if (num >= 1)
                {
                    if (num == (listArray[0].Count - 1))
                    {
                        if (str4.Equals(listArray[2].ElementAt<string>(num - 1)))
                        {
                            num3 += double.Parse(listArray[5].ElementAt<string>(num));
                            num4 += double.Parse(listArray[4].ElementAt<string>(num));
                            num5 += double.Parse(listArray[3].ElementAt<string>(num));
                        }
                        else
                        {
                            this.dataGridView1.Rows.Add(new object[] { "", "", "Total", num5, num4, num3 });
                            num3 = double.Parse(listArray[5].ElementAt<string>(num));
                            num4 = double.Parse(listArray[4].ElementAt<string>(num));
                            num5 = double.Parse(listArray[3].ElementAt<string>(num));
                        }
                        this.dataGridView1.Rows.Add(new object[] { str3, listArray[0].ElementAt<string>(num), listArray[1].ElementAt<string>(num), listArray[3].ElementAt<string>(num), listArray[4].ElementAt<string>(num), listArray[5].ElementAt<string>(num) });
                        this.dataGridView1.Rows.Add(new object[] { "", "", "Total", num5, num4, num3 });
                        num2 += double.Parse(listArray[5].ElementAt<string>(num));
                        break;
                    }
                    if (str4.Equals(listArray[2].ElementAt<string>(num - 1)))
                    {
                        num3 += double.Parse(listArray[5].ElementAt<string>(num));
                        num4 += double.Parse(listArray[4].ElementAt<string>(num));
                        num5 += double.Parse(listArray[3].ElementAt<string>(num));
                    }
                    else
                    {
                        this.dataGridView1.Rows.Add(new object[] { "", "", "Total", num5, num4, num3 });
                        num3 = double.Parse(listArray[5].ElementAt<string>(num));
                        num4 = double.Parse(listArray[4].ElementAt<string>(num));
                        num5 = double.Parse(listArray[3].ElementAt<string>(num));
                    }
                }
                else if (num == 0)
                {
                    num3 = double.Parse(listArray[5].ElementAt<string>(num));
                    num4 = double.Parse(listArray[4].ElementAt<string>(num));
                    num5 = double.Parse(listArray[3].ElementAt<string>(num));
                }
                this.dataGridView1.Rows.Add(new object[] { str3, listArray[0].ElementAt<string>(num), listArray[1].ElementAt<string>(num), listArray[3].ElementAt<string>(num), listArray[4].ElementAt<string>(num), listArray[5].ElementAt<string>(num) });
                num2 += double.Parse(listArray[5].ElementAt<string>(num));
            }
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
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Due Report", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
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
                            if (num4 == 0)
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else if ((num4 == 2) || (num4 == 1))
                            {
                                this.sf = this.sfMiddle;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else
                            {
                                this.sf = this.sfRight;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) (((int) this.arrColumnWidths[num4]) - 10), (float) this.iCellHeight), this.sf);
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
    }
}

