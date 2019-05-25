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
    public partial class NewServicing : Form
    {
        DBConnect dbc = new DBConnect();

        public NewServicing(string date, string memo_no, string name, string contact, string servicing_no)
        {
            InitializeComponent();

            string query = "SELECT max(servicing_id) FROM firoz_center.tbl_servicing t;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxSID.Text = "101";
            }
            else
            {
                string str2 = "SELECT max(servicing_id) FROM firoz_center.tbl_servicing t;";
                this.textBoxSID.Text = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }

            DateTime now = new DateTime();
            now = DateTime.Now;                       

            textBoxMemoNo.Text = memo_no;
            textBoxName.Text = name;
            textBoxContact.Text = contact;
            textBoxDate.Text = date;
            textBoxSNO.Text = servicing_no;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxMileage.Text.Equals(""))
            {
                MessageBox.Show("PLease enter mileage!");
                return;
            }
            
            if(MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                save_transcation();

                this.Close();
            }
        }

        private void save_transcation()
        {
            string sid = this.textBoxSID.Text;
            string sno = this.textBoxSNO.Text;
            string memo_no = this.textBoxMemoNo.Text;
            string mileage = this.textBoxMileage.Text;
            string comments = "Default";
            
            DateTime now = new DateTime();
            now = DateTime.Now;           
            string date = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string query = "insert into firoz_center.tbl_servicing (`servicing_id`,`date`,`memo_no`,`service_no`,`mileage`,`comments`) values ('" + sid + "','" + date + "','" + memo_no + "','" + sno + "','" + mileage + "','" + comments + "');";
            dbc.Insert(query);
            
            MessageBox.Show("Data Inserted");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
