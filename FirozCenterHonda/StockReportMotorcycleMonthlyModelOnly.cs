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
    public partial class StockReportMotorcycleMonthlyModelOnly : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private DBConnect dbc = new DBConnect();
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;

        public StockReportMotorcycleMonthlyModelOnly()
        {
            InitializeComponent();
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

        private void load_stock()
        {
            int num7;
            this.dataGridView1.Rows.Clear();
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;

            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string sql_model = "SELECT model FROM firoz_center.tbl_vehicle_info t group by model;";
            List<string>[] listArrayModel = new List<string>[1];
            for (num7 = 0; num7 < 1; num7++)
            {
                listArrayModel[num7] = new List<string>();
            }
            listArrayModel = this.dbc.Select(1L, sql_model);

            for (int num19 = 0; num19 < listArrayModel[0].Count; num19++)
            {
                num = 0;
                num2 = 0;
                num3 = 0;
                num4 = 0;
                num5 = 0;
                num6 = 0;

                string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where (brand='HONDA' or brand = 'honda') and model = '"+listArrayModel[0].ElementAt(num19) +"';";

                int o = 0, r = 0, t = 0, ss = 0, c = 0;
                
                List<string>[] listArray = new List<string>[1];
                for (num7 = 0; num7 < 1; num7++)
                {
                    listArray[num7] = new List<string>();
                }
                listArray = this.dbc.Select(1L, query);
                for (num7 = 0; num7 < listArray[0].Count; num7++)
                {
                    string str4 = listArray[0].ElementAt<string>(num7);
                    string str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                    string s = this.dbc.SelectSingle(str5);
                    str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str + "');";
                    string str7 = this.dbc.SelectSingle(str5);
                    int num8 = int.Parse(s);
                    str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "');";
                    string str8 = this.dbc.SelectSingle(str5);
                    int num9 = num8 - int.Parse(str8);
                    str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                    string str9 = num9.ToString();
                    str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date between '" + str + "' and '" + str2 + "');";
                    string str10 = this.dbc.SelectSingle(str5);
                    int num10 = int.Parse(str9) + int.Parse(str10);
                    str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                    string str11 = this.dbc.SelectSingle(str5);
                    str5 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                    List<string>[] listArray2 = new List<string>[1];
                    int index = 0;
                    while (index < 1)
                    {
                        listArray2[index] = new List<string>();
                        index++;
                    }
                    listArray2 = this.dbc.Select(1L, str5);
                    string str12 = "";
                    index = 0;
                    while (index < listArray2[0].Count)
                    {
                        str12 = str12 + listArray2[0].ElementAt<string>(index) + ",";
                        index++;
                    }
                    string str13 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str4 + "';";
                    List<string>[] listArray3 = new List<string>[4];
                    for (index = 0; index < 4; index++)
                    {
                        listArray3[index] = new List<string>();
                    }
                    listArray3 = this.dbc.Select(4L, str13);
                    int num12 = num10 - int.Parse(str11);
                    num += num12;
                    
                    num2 += int.Parse(str9);
                    num3 += int.Parse(str10);
                    num6 += num10;
                    num5 += int.Parse(str11);
                    num4 += num12;

                    o = num2;
                    r = num3;
                    t = num6;
                    ss = num5;
                    c = num;
                }

                this.dataGridView1.Rows.Add(new object[] { listArrayModel[0].ElementAt<string>(num19), o, r, t, ss, c});
                n1 += o;
                n2 += r;
                n3 += t;
                n4 += ss;
                n5 += c;
            }
            this.dataGridView1.Rows.Add(new object[] { "Total: ", n1, n2, n3, n4, n5});
        }

        private void load_stock_active()
        {
            int num7;
            this.dataGridView1.Rows.Clear();
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where (brand='HONDA' or brand = 'honda') order by cc,model asc;";
            List<string>[] listArray = new List<string>[1];
            for (num7 = 0; num7 < 1; num7++)
            {
                listArray[num7] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num7 = 0; num7 < listArray[0].Count; num7++)
            {
                string str4 = listArray[0].ElementAt<string>(num7);
                string str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                string s = this.dbc.SelectSingle(str5);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str + "');";
                string str7 = this.dbc.SelectSingle(str5);
                int num8 = int.Parse(s);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "');";
                string str8 = this.dbc.SelectSingle(str5);
                int num9 = num8 - int.Parse(str8);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                string str9 = num9.ToString();
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date between '" + str + "' and '" + str2 + "');";
                string str10 = this.dbc.SelectSingle(str5);
                int num10 = int.Parse(str9) + int.Parse(str10);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                string str11 = this.dbc.SelectSingle(str5);
                str5 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str5);
                string str12 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str12 = str12 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str13 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str4 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str13);
                int num12 = num10 - int.Parse(str11);
                num += num12;

                if (num9 == 0 && num10 == 0 && num12 == 0 && str10.Equals("0") && str11.Equals("0"))
                    continue;
                else
                    this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), num9, str10, num10, str11, num12 });

                num2 += int.Parse(str9);
                num3 += int.Parse(str10);
                num6 += num10;
                num5 += int.Parse(str11);
                num4 += num12;
            }

            this.dataGridView1.Rows.Add(new object[] { "", "Total: ", num2, num3, num6, num5, num });
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
                string str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and ((status like 'stock' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))or (status like 'sold' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' )));";
                string s = this.dbc.SelectSingle(str4);
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date ='" + str + "' );";
                string str6 = this.dbc.SelectSingle(str4);
                int num8 = int.Parse(s) + int.Parse(str6);
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                string str7 = this.dbc.SelectSingle(str4);
                str4 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str4);
                string str8 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str8 = str8 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str9 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str3 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str9);
                int num10 = num8 - int.Parse(str7);
                this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), s, str6, num8, str7, str8, num10 });
                num3 += int.Parse(s);
                num4 += int.Parse(str6);
                num7 += num8;
                num6 += int.Parse(str7);
                num5 += num10;
                num2 += num10;
            }
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
                        string str3 = this.dateTimePicker2.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Monthly Stock Report: Motor Cycle", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Range:" + str2 + " to " + str3, font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), format);
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
                            e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float)((int)this.arrColumnLefts[num4]), (float)y, (float)((int)this.arrColumnWidths[num4]), (float)this.iCellHeight), this.sfMiddle);
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

        private void radioButtonActive_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock_active();
        }
    }
}
