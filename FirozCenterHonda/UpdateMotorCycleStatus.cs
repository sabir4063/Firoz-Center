namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class UpdateMotorCycleStatus : Form
    {
        private Button buttonSave;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxChassisNo;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label13;
        private Label label18;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBoxEngineNo;

        public UpdateMotorCycleStatus()
        {
            this.InitializeComponent();
            this.load_brand();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string str = "stock";
            if (this.radioButton1.Checked.Equals(true))
            {
                str = "showroom";
            }
            else
            {
                str = "stock";
            }
            string query = "Update firoz_center.tbl_vehicle set `comments`='" + str + "' where chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';";
            this.dbc.Update(query);
            MessageBox.Show("Updated");
            this.load_engine_no();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
        }

        private void comboBoxChassisNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_engine_no();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_chassis_no();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_cc();
            this.comboBoxCC.SelectedIndex = 0;
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
            this.groupBox2 = new GroupBox();
            this.buttonSave = new Button();
            this.textBoxEngineNo = new TextBox();
            this.label18 = new Label();
            this.comboBoxChassisNo = new ComboBox();
            this.label9 = new Label();
            this.comboBoxColor = new ComboBox();
            this.comboBoxCC = new ComboBox();
            this.comboBoxModel = new ComboBox();
            this.comboBoxBrand = new ComboBox();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label13 = new Label();
            this.panel1 = new Panel();
            this.radioButton2 = new RadioButton();
            this.radioButton1 = new RadioButton();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.textBoxEngineNo);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.comboBoxChassisNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.comboBoxCC);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Margin = new Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new Padding(4);
            this.groupBox2.Size = new Size(0x1a0, 240);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x98, 0xcb);
            this.buttonSave.Margin = new Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x1b;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxEngineNo.BackColor = SystemColors.Window;
            this.textBoxEngineNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEngineNo.Location = new Point(0x69, 0x91);
            this.textBoxEngineNo.Margin = new Padding(4);
            this.textBoxEngineNo.Name = "textBoxEngineNo";
            this.textBoxEngineNo.ReadOnly = true;
            this.textBoxEngineNo.Size = new Size(300, 0x16);
            this.textBoxEngineNo.TabIndex = 15;
            this.label18.AutoSize = true;
            this.label18.BackColor = Color.DarkSeaGreen;
            this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label18.Location = new Point(10, 0x95);
            this.label18.Margin = new Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x47, 0x10);
            this.label18.TabIndex = 0x17;
            this.label18.Text = "Engine No";
            this.comboBoxChassisNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxChassisNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxChassisNo.BackColor = SystemColors.Window;
            this.comboBoxChassisNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxChassisNo.FormattingEnabled = true;
            this.comboBoxChassisNo.Location = new Point(0x69, 0x77);
            this.comboBoxChassisNo.Margin = new Padding(4);
            this.comboBoxChassisNo.Name = "comboBoxChassisNo";
            this.comboBoxChassisNo.Size = new Size(300, 0x18);
            this.comboBoxChassisNo.TabIndex = 14;
            this.comboBoxChassisNo.SelectedIndexChanged += new EventHandler(this.comboBoxChassisNo_SelectedIndexChanged);
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x7d);
            this.label9.Margin = new Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x4d, 0x10);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chassis No";
            this.comboBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = SystemColors.Window;
            this.comboBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new Point(0x69, 0x5d);
            this.comboBoxColor.Margin = new Padding(4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new Size(300, 0x18);
            this.comboBoxColor.TabIndex = 13;
            this.comboBoxColor.SelectedIndexChanged += new EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = SystemColors.Window;
            this.comboBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new Point(0x69, 0x43);
            this.comboBoxCC.Margin = new Padding(4);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new Size(300, 0x18);
            this.comboBoxCC.TabIndex = 12;
            this.comboBoxCC.SelectedIndexChanged += new EventHandler(this.comboBoxCC_SelectedIndexChanged);
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.Window;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x69, 0x29);
            this.comboBoxModel.Margin = new Padding(4);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(300, 0x18);
            this.comboBoxModel.TabIndex = 11;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = SystemColors.Window;
            this.comboBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new Point(0x69, 15);
            this.comboBoxBrand.Margin = new Padding(4);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new Size(300, 0x18);
            this.comboBoxBrand.TabIndex = 10;
            this.comboBoxBrand.SelectedIndexChanged += new EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x65);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(40, 0x10);
            this.label6.TabIndex = 4;
            this.label6.Text = "Color";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x49);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x1a, 0x10);
            this.label7.TabIndex = 3;
            this.label7.Text = "CC";
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0x2e);
            this.label8.Margin = new Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2e, 0x10);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(10, 20);
            this.label13.Margin = new Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x2c, 0x10);
            this.label13.TabIndex = 0;
            this.label13.Text = "Brand";
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Font = new Font("MS Reference Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.panel1.Location = new Point(0x69, 0xab);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(300, 0x19);
            this.panel1.TabIndex = 0x1c;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(160, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(0x39, 0x13);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stock";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(0x5d, 0x13);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show Room";
            this.radioButton1.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1a9, 250);
            base.Controls.Add(this.groupBox2);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "UpdateMotorCycleStatus";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UpdateMotorCycleStatus";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
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
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
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

        private void load_chassis_no()
        {
            int num;
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT chasis_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and status='stock';";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, str3);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxChassisNo.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_color()
        {
            int num;
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
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

        private void load_engine_no()
        {
            this.textBoxEngineNo.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT engine_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';";
            string str4 = this.dbc.SelectSingle(str3);
            this.textBoxEngineNo.Text = str4;
            string str5 = "Select comments FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';";
            if (this.dbc.SelectSingle(str5).Equals("stock"))
            {
                this.radioButton2.Checked = true;
            }
            else
            {
                this.radioButton1.Checked = true;
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxEngineNo.Text = "";
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
    }
}

