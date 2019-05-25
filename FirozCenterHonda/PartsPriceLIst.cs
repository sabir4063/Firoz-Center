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
    public partial class PartsPriceLIst : Form
    {
        public PartsPriceLIst()
        {
            InitializeComponent();
            this.load_party();
        }

        private void comboBoxDescip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxPartsNo.SelectedIndex = this.comboBoxDescip.SelectedIndex;
            this.load_price();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_description_Parts();
        }

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_price();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        DBConnect dbc = new DBConnect();

        private void load_description_Parts()
        {
            int num;
            this.comboBoxDescip.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();            
            string query = "SELECT description,partsNo FROM firoz_center.tbl_parts_info t where `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and `model` = '" + this.comboBoxModel.SelectedItem.ToString() + "' group by description,partsNo;";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(2L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxDescip.Items.Add(listArray[0].ElementAt<string>(num).ToString());
                this.comboBoxPartsNo.Items.Add(listArray[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string str = this.comboBoxParty.SelectedItem.ToString();
            string query = "SELECT model FROM firoz_center.tbl_parts_info t where `group` = '" + str + "' group by model;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxModel.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private List<string>[] Party = new List<string>[6];
        private List<string>[] Price = new List<string>[3];
        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string query = "SELECT * FROM firoz_center.tbl_party t order by customer_id;";
            for (num = 0; num < 6; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(6L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_price()
        {
            dataGridView1.Rows.Clear();

            string query = "Select DATE_FORMAT(date, '%d-%m-%Y') AS 'date1', purchase_price, sale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ORDER BY DATE;";                                   

            for (int num = 0; num < 3; num++)
            {
                this.Price[num] = new List<string>();
            }
            this.Price = this.dbc.Select(3, query);

            for (int num = 0; num < this.Price[0].Count; num++)
            {
                dataGridView1.Rows.Add(dataGridView1.RowCount + 1, Price[0].ElementAt(num), Price[1].ElementAt(num),Price[2].ElementAt(num));
            }
        }
    }
}
