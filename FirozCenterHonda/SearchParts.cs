namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class SearchParts : Form
    {
        public ComboBox comboBoxDescip;
        public ComboBox comboBoxModel;
        public ComboBox comboBoxPartsNo;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;

        public SearchParts()
        {
            this.InitializeComponent();
            this.load_model();
        }

        private void comboBoxDescip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxPartsNo.SelectedIndex = this.comboBoxDescip.SelectedIndex;
            this.load_quantity();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_description_Parts();
        }

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_quantity();
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
            this.textBoxQuantity = new TextBox();
            this.label9 = new Label();
            this.comboBoxDescip = new ComboBox();
            this.comboBoxPartsNo = new ComboBox();
            this.label5 = new Label();
            this.label6 = new Label();
            this.groupBox2 = new GroupBox();
            this.label7 = new Label();
            this.comboBoxModel = new ComboBox();
            this.textBoxPrice = new TextBox();
            this.label1 = new Label();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.textBoxQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxQuantity.Location = new Point(0x66, 0x62);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new Size(250, 0x16);
            this.textBoxQuantity.TabIndex = 12;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(6, 0x62);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x38, 0x10);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity";
            this.comboBoxDescip.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = SystemColors.ControlLight;
            this.comboBoxDescip.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new Point(0x66, 0x48);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new Size(250, 0x18);
            this.comboBoxDescip.TabIndex = 9;
            this.comboBoxDescip.SelectedIndexChanged += new EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            this.comboBoxPartsNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new Point(0x66, 0x2e);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new Size(250, 0x18);
            this.comboBoxPartsNo.TabIndex = 8;
            this.comboBoxPartsNo.SelectedIndexChanged += new EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(6, 0x48);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x4c, 0x10);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(6, 0x2e);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 0x10);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x16c, 0xb0);
            this.groupBox2.TabIndex = 0x13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Parts";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(7, 0x17);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 15;
            this.label7.Text = "Model";
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.ControlLight;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x66, 20);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(250, 0x18);
            this.comboBoxModel.TabIndex = 1;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(0x66, 0x7a);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new Size(250, 0x16);
            this.textBoxPrice.TabIndex = 14;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(6, 0x7b);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x27, 0x10);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x177, 0xb8);
            base.Controls.Add(this.groupBox2);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "SearchParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SearchParts";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_description_Parts()
        {
            int num;
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string query = "SELECT description,partsNo FROM firoz_center.tbl_parts_info where model='" + this.comboBoxModel.SelectedItem.ToString() + "' group by description,partsNo;";
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
            string query = "SELECT model FROM firoz_center.tbl_parts_info t group by model;";
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

        private void load_quantity()
        {
            this.textBoxQuantity.Text = "";
            string query = "SELECT partsId FROM firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            query = "SELECT sale_price FROM firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' ORDER BY DATE DESC LIMIT 1;";
            string str3 = this.dbc.SelectSingle(query);
            query = "Select count(*) FROM firoz_center.tbl_parts where partsId='" + str2 + "' and status ='stock'";
            this.textBoxQuantity.Text = long.Parse(this.dbc.SelectSingle(query)).ToString();
            this.textBoxPrice.Text = str3;
        }
    }
}

