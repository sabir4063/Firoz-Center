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

    public class ReportMonthlySaleService : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonPrint;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
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
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private Button buttonSave;
        private StringFormat strFormat;

        public ReportMonthlySaleService()
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
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select memo_no,grand_total,customer_id,DATE_FORMAT(date, '%d-%m-%Y'),paid_amount,due_amount AS date from firoz_center.tbl_sales_service where date between '" + str + "' and '" + str2 + "' and type='Service'";
            List<string>[] listArray = new List<string>[6];
            for (num = 0; num < 6; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(6L, query);
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str4 = listArray[0].ElementAt<string>(num);
                string str5 = listArray[1].ElementAt<string>(num);
                string str6 = "";
                string str7 = listArray[3].ElementAt<string>(num);
                string str8 = listArray[4].ElementAt<string>(num);
                string str9 = listArray[5].ElementAt<string>(num);
                num2 += double.Parse(listArray[1].ElementAt<string>(num));
                num4 += double.Parse(listArray[4].ElementAt<string>(num));
                num3 += double.Parse(listArray[5].ElementAt<string>(num));
                string str10 = "select name from firoz_center.tbl_customer where customer_id='" + listArray[2].ElementAt<string>(num) + "'";
                str6 = this.dbc.SelectSingle(str10);
                string str11 = this.dbc.SelectSingle("SELECT service_id from firoz_center.tbl_service where memo_no='" + str4 + "';");
                string str12 = "select name,description,charge from firoz_center.tbl_service_charge where service_id='" + str11 + "';";
                List<string>[] listArray2 = new List<string>[3];
                for (int i = 0; i < 3; i++)
                {
                    listArray2[i] = new List<string>();
                }
                listArray2 = this.dbc.Select(3L, str12);
                string str13 = listArray2[0].ElementAt<string>(0);
                string str14 = listArray2[1].ElementAt<string>(0);
                string str15 = listArray2[2].ElementAt<string>(0);
                this.dataGridView1.Rows.Add(new object[] { str4, str7, str6, str5, str8, str9 });
            }
            this.dataGridView1.Rows.Add(new object[] { "", "", "Total: ", num2, num4, num3 });
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 528);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Monthly Sales Service ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(835, 479);
            this.dataGridView1.TabIndex = 47;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 80F;
            this.Column8.HeaderText = "Memo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 120F;
            this.Column9.HeaderText = "Customer Name";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 250;
            // 
            // Column5
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Total Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column6.HeaderText = "Paid Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column7.HeaderText = "Due Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 120;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(529, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(120, 30);
            this.buttonPrint.TabIndex = 46;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 22);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 22);
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
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(403, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 30);
            this.buttonSearch.TabIndex = 39;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(655, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ReportMonthlySaleService
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportMonthlySaleService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Sale Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
                        string str2 = this.dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        string str3 = this.dateTimePicker2.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Monthly Sales Report: Service", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Range:" + str2 + " to " + str3, font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
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

