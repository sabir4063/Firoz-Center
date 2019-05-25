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
    public partial class DeleteServicing : Form
    {
        DBConnect dbc = new DBConnect();

        public DeleteServicing(string date, string memo_no, string name, string contact, string servicing_no, string servicing_id)
        {
            InitializeComponent();
            
            textBoxMemoNo.Text = memo_no;
            textBoxName.Text = name;
            textBoxContact.Text = contact;
            textBoxDate.Text = date;
            textBoxSNO.Text = servicing_no;
            textBoxSID.Text = servicing_id;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                save_transcation();

                this.Close();
            }
        }

        private void save_transcation()
        {
            string sid = this.textBoxSID.Text;
            
            string query = "DELETE from firoz_center.tbl_servicing where servicing_id='"+sid+"';";
            dbc.Delete(query);
            
            MessageBox.Show("Data Deleted");


        }
    }
}
