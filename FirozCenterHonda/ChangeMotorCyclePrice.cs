namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class ChangeMotorCyclePrice : Form
    {
        private Button buttonChange;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxPurchase;
        private TextBox textBoxSale;
        private List<string>[] Vehicle = new List<string>[6];

        public ChangeMotorCyclePrice()
        {
            this.InitializeComponent();
            this.load_brand();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.textBoxPurchase.Text.Equals("") || this.textBoxSale.Text.Equals(""))
                {
                    MessageBox.Show("Check Data Again");
                }
                else
                {
                    string query = "update firoz_center.tbl_vehicle_info t set purchase_price='" + this.textBoxPurchase.Text + "', sale_price='" + this.textBoxSale.Text + "' where brand='" + this.comboBoxBrand.SelectedItem.ToString() + "' and model ='" + this.comboBoxModel.SelectedItem.ToString() + "' and cc='" + this.comboBoxCC.SelectedItem.ToString() + "';";
                    this.dbc.Update(query);
                    this.textBoxPurchase.Text = "";
                    this.textBoxSale.Text = "";
                    MessageBox.Show("Updated");
                }
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_price();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_cc();
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
            this.buttonChange = new Button();
            this.textBoxPurchase = new TextBox();
            this.comboBoxColor = new ComboBox();
            this.comboBoxCC = new ComboBox();
            this.comboBoxModel = new ComboBox();
            this.comboBoxBrand = new ComboBox();
            this.groupBox2 = new GroupBox();
            this.textBoxSale = new TextBox();
            this.label1 = new Label();
            this.label10 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.buttonChange.BackColor = Color.MediumSeaGreen;
            this.buttonChange.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonChange.Location = new Point(0x86, 170);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new Size(120, 30);
            this.buttonChange.TabIndex = 14;
            this.buttonChange.Text = "Update";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new EventHandler(this.buttonChange_Click);
            this.textBoxPurchase.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPurchase.Location = new Point(0x75, 0x79);
            this.textBoxPurchase.Name = "textBoxPurchase";
            this.textBoxPurchase.Size = new Size(0x103, 0x16);
            this.textBoxPurchase.TabIndex = 13;
            this.comboBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = SystemColors.ControlLight;
            this.comboBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new Point(0x75, 0x5f);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new Size(0x103, 0x18);
            this.comboBoxColor.TabIndex = 9;
            this.comboBoxColor.SelectedIndexChanged += new EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = SystemColors.ControlLight;
            this.comboBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new Point(0x75, 0x45);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new Size(0x103, 0x18);
            this.comboBoxCC.TabIndex = 8;
            this.comboBoxCC.SelectedIndexChanged += new EventHandler(this.comboBoxCC_SelectedIndexChanged);
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.ControlLight;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x75, 0x2b);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(0x103, 0x18);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = SystemColors.ControlLight;
            this.comboBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new Point(0x75, 0x11);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new Size(0x103, 0x18);
            this.comboBoxBrand.TabIndex = 6;
            this.comboBoxBrand.SelectedIndexChanged += new EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxSale);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonChange);
            this.groupBox2.Controls.Add(this.textBoxPurchase);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.comboBoxCC);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x182, 0xcc);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Price";
            this.textBoxSale.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSale.Location = new Point(0x75, 0x91);
            this.textBoxSale.Name = "textBoxSale";
            this.textBoxSale.Size = new Size(0x103, 0x16);
            this.textBoxSale.TabIndex = 0x10;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(11, 0x92);
            this.label1.Name = "label1";
            this.label1.Size = new Size(70, 0x10);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sale Price";
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(11, 0x79);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x63, 0x10);
            this.label10.TabIndex = 11;
            this.label10.Text = "Purchase Price";
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(11, 0x5f);
            this.label5.Name = "label5";
            this.label5.Size = new Size(40, 0x10);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(11, 0x45);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x1a, 0x10);
            this.label6.TabIndex = 3;
            this.label6.Text = "CC";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(11, 0x2b);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model";
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(11, 0x11);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2c, 0x10);
            this.label8.TabIndex = 0;
            this.label8.Text = "Brand";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x18c, 0xd7);
            base.Controls.Add(this.groupBox2);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "ChangeMotorCyclePrice";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Motor Cycle Price";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.textBoxPurchase.Text = "";
            this.textBoxSale.Text = "";
            string query = "SELECT brand FROM firoz_center.tbl_vehicle_info t group by brand;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxBrand.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_cc()
        {
            int num;
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.textBoxPurchase.Text = "";
            this.textBoxSale.Text = "";
            string query = "SELECT cc FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' group by cc;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxCC.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_color()
        {
            int num;
            this.comboBoxColor.Items.Clear();
            this.textBoxPurchase.Text = "";
            this.textBoxSale.Text = "";
            string query = "SELECT color FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' group by color;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxColor.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.textBoxPurchase.Text = "";
            this.textBoxSale.Text = "";
            string query = "SELECT model FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' group by model;";
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

        private void load_price()
        {
            this.textBoxPurchase.Text = "";
            this.textBoxSale.Text = "";
            string query = "SELECT purchase_price FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxPurchase.Text = str2;
            query = "SELECT sale_price FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str3 = this.dbc.SelectSingle(query);
            this.textBoxSale.Text = str3;
        }
    }
}

