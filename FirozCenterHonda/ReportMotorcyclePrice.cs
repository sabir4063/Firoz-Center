using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirozCenterHonda
{
    public partial class ReportMotorcyclePrice : Form
    {
        public ReportMotorcyclePrice()
        {
            InitializeComponent();
            load_price();
        }

        private void load_price()
        {
            DBConnect dbc = new DBConnect();

            string sql = "SELECT model,cc,color,purchase_price,sale_price  FROM firoz_center.tbl_vehicle_info t where brand='HONDA' order by model,cc,color;";

            List<string>[] listArray = new List<string>[5];

            int num;

            for (num = 0; num < 5; num++)
            {
                listArray[num] = new List<string>();
            }

            listArray = dbc.Select(5L, sql);
            
            for (num = 0; num < listArray[0].Count; num++)
            {
                dataGridView1.Rows.Add(listArray[0].ElementAt(num), listArray[1].ElementAt(num), listArray[2].ElementAt(num), listArray[3].ElementAt(num), listArray[4].ElementAt(num));                    
            }
        }
    }
}
