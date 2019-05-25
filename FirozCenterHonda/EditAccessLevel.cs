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
    public partial class EditAccessLevel : Form
    {
        public EditAccessLevel()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string sql="";

            if(checkBoxStatus.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `status`='inactive' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `status`='active' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox1.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab1`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab1`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox2.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab2`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab2`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox3.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab3`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab3`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox4.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab4`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab4`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox5.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab5`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab5`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox6.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab6`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab6`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox7.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab7`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab7`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox8.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab8`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab8`='False' where name='" + name + "';";
            dbc.Update(sql);

            if (checkBox9.Checked.Equals(true))
                sql = "update firoz_center.tbl_user set `tab9`='True' where name='" + name + "';";
            else
                sql = "update firoz_center.tbl_user set `tab9`='False' where name='" + name + "';";
            dbc.Update(sql);

            MessageBox.Show("User Access Level Updated");
            this.Dispose();
        }
    }
}
