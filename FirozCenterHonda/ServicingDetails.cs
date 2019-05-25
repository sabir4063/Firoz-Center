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
    public partial class ServicingDetails : Form
    {
        DBConnect dbc = new DBConnect();

        public ServicingDetails(string memo_no, string name, string contact, string dt)
        {
            InitializeComponent();
            
            textBoxMemoNo.Text = memo_no;
            textBoxName.Text = name;
            textBoxContact.Text = contact;
            textBoxDate.Text = dt;

            string sql = "SELECT * FROM firoz_center.tbl_servicing t where memo_no='"+memo_no+"' order by service_no;";

            int num;

            List<string>[] listArray = new List<string>[6];
            for (num = 0; num < 6; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(6L, sql);

            for (num = 0; num < listArray[0].Count; num++)
            {
                string s_id = listArray[0].ElementAt(num);
                string date = listArray[1].ElementAt(num);
                string mileage = listArray[2].ElementAt(num);
                string s_no = listArray[5].ElementAt(num);

                this.dataGridView1.Rows.Add(new object[] { date, s_id, s_no, mileage});
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sid = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                string query = "DELETE from firoz_center.tbl_servicing where servicing_id='" + sid + "';";
                dbc.Delete(query);

                MessageBox.Show("Data Deleted!");

                string memo_no = textBoxMemoNo.Text;
                string name = textBoxName.Text;
                string contact = textBoxContact.Text;
                string dt = textBoxDate.Text;

                ServicingDetails SD = new ServicingDetails(memo_no, name, contact, dt);
                SD.Show();

                this.Dispose();
            }
        }                        
    }
}
