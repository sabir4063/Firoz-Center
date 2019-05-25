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

    public class PrintSalary : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonLoad;
        private Button buttonPrint;
        private Button buttonSave;
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
        private GroupBox groupBox3;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label5;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat strFormat;

        public PrintSalary()
        {
            this.InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                double num2 = double.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                double num3 = double.Parse(this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                double num4 = double.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                double num5 = double.Parse(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                this.dataGridView1.Rows[i].Cells[6].Value = (((num2 - num3) - num4) - num5).ToString();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string str2 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str3 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                string str4 = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str5 = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                string query = "update firoz_center.tbl_salary set `salary`='" + str2 + "', `loan`='" + str3 + "', advance='" + str4 + "', `deduction`='" + str5 + "', net_salary='" + str6 + "' where expences_id='" + str + "'";
                this.dbc.Update(query);
                query = "update firoz_center.tbl_transcation set `credit`='" + str2 + "' where invoice_no='" + str + "'";
                this.dbc.Update(query);
            }
            MessageBox.Show("Data Updated");
        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print report?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string str = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-01", CultureInfo.InvariantCulture);
            string query = "Select * from firoz_center.tbl_salary where month='" + str + "'";
            List<string>[] listArray = new List<string>[9];
            for (long i = 0L; i < 9L; i += 1L)
            {
                listArray[(int) ((IntPtr) i)] = new List<string>();
            }
            listArray = this.dbc.Select(9L, query);
            for (int j = 0; j < listArray[0].Count; j++)
            {
                string str4 = this.dbc.SelectSingle("Select name from firoz_center.tbl_employee where employeeId='" + listArray[0].ElementAt<string>(j) + "'");
                this.dataGridView1.Rows.Add(new object[] { listArray[8].ElementAt<string>(j), str4, listArray[1].ElementAt<string>(j), listArray[4].ElementAt<string>(j), listArray[5].ElementAt<string>(j), listArray[6].ElementAt<string>(j), listArray[7].ElementAt<string>(j) });
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
            this.groupBox3 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.label5 = new Label();
            this.buttonSave = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.buttonLoad = new Button();
            this.buttonPrint = new Button();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(5, 0x22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x2bf, 0x1df);
            this.groupBox3.TabIndex = 0x2d;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salary Print";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column4, this.Column1, this.Column3, this.Column5, this.Column6, this.Column7, this.Column8, this.Column2 });
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = style;
            this.dataGridView1.Location = new Point(6, 0x11);
            this.dataGridView1.Name = "dataGridView1";
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = style2;
            this.dataGridView1.Size = new Size(0x2b1, 0x1c5);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.Column4.FillWeight = 50f;
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            this.Column1.FillWeight = 150f;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            this.Column3.FillWeight = 150f;
            this.Column3.HeaderText = "Salary";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            this.Column5.HeaderText = "Loan";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            this.Column6.HeaderText = "Advance";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            this.Column7.HeaderText = "Deduction";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            this.Column2.HeaderText = "Signature";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 150;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.MediumSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x55, 0x10);
            this.label5.TabIndex = 0x2b;
            this.label5.Text = "Select Month";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x148, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x2f;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonPrint_Click);
            this.dateTimePicker1.CustomFormat = "MMM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x67, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x58, 0x16);
            this.dateTimePicker1.TabIndex = 0x2c;
            this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
            this.buttonLoad.BackColor = Color.MediumSeaGreen;
            this.buttonLoad.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonLoad.Location = new Point(0xca, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new Size(120, 30);
            this.buttonLoad.TabIndex = 0x30;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);
            this.buttonPrint.BackColor = Color.MediumSeaGreen;
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(0x1c6, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(120, 30);
            this.buttonPrint.TabIndex = 0x31;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click_1);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x2c9, 0x204);
            base.Controls.Add(this.buttonPrint);
            base.Controls.Add(this.buttonLoad);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.dateTimePicker1);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.buttonSave);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "PrintSalary";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PrintSalary";
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
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
                        this.sfLeft.Alignment = StringAlignment.Far;
                        this.sfLeft.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        string str2 = this.dateTimePicker1.Value.ToString("MMM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sf);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sf);
                        y += 0x19;
                        e.Graphics.DrawString("Monthly Salary", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sf);
                        y += 20;
                        e.Graphics.DrawString("Salary :" + str2, font4, brush, new Rectangle(15, y, 800, font4.Height), this.sf);
                        y += 30;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), this.sf);
                        y = e.MarginBounds.Top;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iHeaderHeight), this.sf);
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
                            e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sfLeft);
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

