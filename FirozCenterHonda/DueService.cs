using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirozCenterHonda
{
    public partial class DueService : Form
    {
        public DueService()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();

        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        
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
                        width = (int)(Math.Floor((double)((((column.Width - 5.0) / ((double)this.iTotalWidth)) * this.iTotalWidth) * (((double)e.MarginBounds.Width) / ((double)this.iTotalWidth)))) * 1.25);
                        this.iHeaderHeight = ((int)e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, width).Height) + 11;
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
                        e.Graphics.DrawString("Monthly Sales Report: Parts", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Range:" + str2 + " to " + str3, font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), this.sfMiddle);
                        y = e.MarginBounds.Top;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int)this.arrColumnLefts[num4], y, (int)this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)this.arrColumnLefts[num4], y, (int)this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float)((int)this.arrColumnLefts[num4]), (float)y, (float)((int)this.arrColumnWidths[num4]), (float)this.iHeaderHeight), this.sfMiddle);
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
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float)((int)this.arrColumnLefts[num4]), (float)y, (float)((int)this.arrColumnWidths[num4]), (float)this.iCellHeight), this.sf);
                            }
                            else if (num4 == 2)
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float)(((int)this.arrColumnLefts[num4]) + 3), (float)y, (float)((int)this.arrColumnWidths[num4]), (float)this.iCellHeight), this.sf);
                            }
                            else
                            {
                                this.sf = this.sfRight;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float)(((int)this.arrColumnLefts[num4]) - 5), (float)y, (float)((int)this.arrColumnWidths[num4]), (float)this.iCellHeight), this.sf);
                            }
                        }
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)this.arrColumnLefts[num4], y, (int)this.arrColumnWidths[num4], this.iCellHeight));
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


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select memo_no,customer_id,DATE_FORMAT(date, '%d-%M-%Y') AS date1 from firoz_center.tbl_sales_motorcycle order by date";
            List<string>[] listArray = new List<string>[3];

            int[] service_no={0,30,120,240,365,480,600,720};

            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            
            for (num = 0; num < listArray[0].Count; num++)
            {
                string memo_no = listArray[0].ElementAt<string>(num);
                string customer_id = listArray[1].ElementAt<string>(num);
                string date = listArray[2].ElementAt<string>(num);

                string sql_name = "select name from firoz_center.tbl_customer where customer_id='" + customer_id + "'";
                string name = this.dbc.SelectSingle(sql_name);
                string sql_contact = "select contact from firoz_center.tbl_customer where customer_id='" + customer_id + "'";
                string contact = this.dbc.SelectSingle(sql_contact);

                DateTime dt = DateTime.Parse(date);
                DateTime dtt = DateTime.Parse(date);
                DateTime sale_dt = DateTime.Parse(date);                

                DateTime start_dt = DateTime.Parse(str);
                DateTime end_dt = DateTime.Parse(str2);

                for (int i = 1; i <= 7; i++)
                {                    
                    dt = dtt.AddDays(service_no[i]);

                    if (dt >= start_dt && dt <= end_dt)
                    {
                        long count = dbc.Count("SELECT * FROM firoz_center.tbl_servicing t where memo_no='" + memo_no + "' and service_no='" + i + "';");

                        if (count == -1)
                            this.dataGridView1.Rows.Add(new object[] { date, memo_no, name, contact, i });
                    }
                }                
            }            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print report?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new NewServicing(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()).Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = this.textBoxSearch.Text;
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select memo_no,customer_id,DATE_FORMAT(date, '%d-%M-%Y') AS date1 from firoz_center.tbl_sales_motorcycle order by date";
            List<string>[] listArray = new List<string>[3];

            int[] service_no={0,30,120,240,365,480,600,720};

            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            
            for (num = 0; num < listArray[0].Count; num++)
            {
                string memo_no = listArray[0].ElementAt<string>(num);
                string customer_id = listArray[1].ElementAt<string>(num);
                string date = listArray[2].ElementAt<string>(num);

                string sql_name = "select name from firoz_center.tbl_customer where customer_id='" + customer_id + "'";
                string name = this.dbc.SelectSingle(sql_name);
                string sql_contact = "select contact from firoz_center.tbl_customer where customer_id='" + customer_id + "'";
                string contact = this.dbc.SelectSingle(sql_contact);

                DateTime dt = DateTime.Parse(date);
                DateTime dtt = DateTime.Parse(date);
                DateTime sale_dt = DateTime.Parse(date);                

                DateTime start_dt = DateTime.Parse(str);
                DateTime end_dt = DateTime.Parse(str2);

                for (int i = 1; i <= 7; i++)
                {                    
                    dt = dtt.AddDays(service_no[i]);

                    if (dt >= start_dt && dt <= end_dt)
                    {
                        long count = dbc.Count("SELECT * FROM firoz_center.tbl_servicing t where memo_no='" + memo_no + "' and service_no='" + i + "';");

                        if (count == -1)
                            if(name.Contains(text) || contact.Contains(text))
                                this.dataGridView1.Rows.Add(new object[] { date, memo_no, name, contact, i });
                    }
                }                
            }                    
        }
    }
}
