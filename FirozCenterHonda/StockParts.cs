namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class StockParts : Form
    {
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox3;

        public StockParts()
        {
            this.InitializeComponent();
            this.load_stock();
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
            this.dataGridView1 = new DataGridView();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.groupBox3 = new GroupBox();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column3, this.Column4, this.Column5 });
            this.dataGridView1.Location = new Point(7, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x240, 0x1c8);
            this.dataGridView1.TabIndex = 0;
            this.Column3.FillWeight = 200f;
            this.Column3.HeaderText = "Parts No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            this.Column4.FillWeight = 250f;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new Point(5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x24c, 0x1e1);
            this.groupBox3.TabIndex = 0x15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Stock";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x255, 490);
            base.Controls.Add(this.groupBox3);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "StockParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "StockParts";
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox3.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void load_stock()
        {
            int num;
            string query = "select partsId,count(*) from firoz_center.tbl_parts where status='stock' group by partsId";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(2L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = listArray[0].ElementAt<string>(num);
                string str3 = listArray[1].ElementAt<string>(num);
                string str4 = "Select partsNo,description from firoz_center.tbl_parts_info where partsId='" + str2 + "';";
                List<string>[] listArray2 = new List<string>[2];
                for (int i = 0; i < 2; i++)
                {
                    listArray2[i] = new List<string>();
                }
                listArray2 = this.dbc.Select(2L, str4);
                this.dataGridView1.Rows.Add(new object[] { listArray2[0].ElementAt<string>(0), listArray2[1].ElementAt<string>(0), str3 });
            }
        }
    }
}

