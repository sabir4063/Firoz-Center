using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirozCenterHonda
{
    public partial class ReportInventorySummery : Form
    {
        public ReportInventorySummery()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            load_data();
        }

        DBConnect dbc = new DBConnect();

        private void load_data()
        {
            int num;
            double sum = 0;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select DATE_FORMAT(purchase_date, '%d-%m-%Y') AS purchase_date,invoice_no,round(net_amount,2), type from firoz_center.tbl_purchase where purchase_date between '" + str + "' and '" + str2 + "' order by purchase_date";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(4L, query);
            
            for (num = 0; num < listArray[0].Count; num++)
            {
                double net_amount = Double.Parse(listArray[2].ElementAt<string>(num));
                string invoice_no = listArray[1].ElementAt<string>(num);


                if (listArray[3].ElementAt<string>(num).Equals("Motor"))
                {
                    string sql_quantity = "SELECT count(*) FROM firoz_center.tbl_vehicle t where invoice_no='" + invoice_no + "';";
                    string quantity = dbc.SelectSingle(sql_quantity);
                    this.dataGridView1.Rows.Add(new object[] { listArray[0].ElementAt<string>(num), listArray[1].ElementAt<string>(num), net_amount.ToString("n2"), quantity, "Motorcycle" });
                }
                else
                {
                    string sql_quantity = "SELECT count(*) FROM firoz_center.tbl_parts t where invoice_no='" + invoice_no + "';";
                    string quantity = dbc.SelectSingle(sql_quantity);
                    this.dataGridView1.Rows.Add(new object[] { listArray[0].ElementAt<string>(num), listArray[1].ElementAt<string>(num), net_amount.ToString("n2"),quantity, "Parts/Engine Oil" });
                }
                sum = sum + Double.Parse(listArray[2].ElementAt<string>(num));
            }

            dataGridView1.Rows.Add("","Total: ", sum.ToString("n2"), "");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Motorcycle"))
                new EditPurchaseMotorCycle(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
            else
                new EditPurchaseParts(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Show();
        }
    }
}
