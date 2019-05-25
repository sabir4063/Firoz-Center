namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class SearchMotorCycle : Form
    {
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxChassisNo;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label13;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxEngineNo;
        private TextBox textBoxInvoice;
        private TextBox textBoxMemo;
        private TextBox textBoxStatus;

        public SearchMotorCycle()
        {
            this.InitializeComponent();
            this.load_brand();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
        }

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
            this.comboBoxColor.SelectedIndex = 0;
        }

        private void comboBoxChassisNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_engine_no();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_chassis_no();
            this.comboBoxChassisNo.SelectedIndex = 0;
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
            this.groupBox1 = new GroupBox();
            this.label2 = new Label();
            this.textBoxMemo = new TextBox();
            this.label1 = new Label();
            this.textBoxStatus = new TextBox();
            this.label19 = new Label();
            this.textBoxInvoice = new TextBox();
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
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMemo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBoxInvoice);
            this.groupBox1.Controls.Add(this.textBoxEngineNo);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.comboBoxChassisNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxColor);
            this.groupBox1.Controls.Add(this.comboBoxCC);
            this.groupBox1.Controls.Add(this.comboBoxModel);
            this.groupBox1.Controls.Add(this.comboBoxBrand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Margin = new Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(4);
            this.groupBox1.Size = new Size(0x192, 0x108);
            this.groupBox1.TabIndex = 0x26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0xe8);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x45, 0x12);
            this.label2.TabIndex = 0x2c;
            this.label2.Text = "Memo No";
            this.textBoxMemo.BackColor = SystemColors.Window;
            this.textBoxMemo.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemo.Location = new Point(0x6d, 0xe8);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new Size(0x11c, 0x17);
            this.textBoxMemo.TabIndex = 0x2b;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0xcf);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x33, 0x12);
            this.label1.TabIndex = 0x2a;
            this.label1.Text = "Status";
            this.textBoxStatus.BackColor = SystemColors.Window;
            this.textBoxStatus.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxStatus.Location = new Point(0x6d, 0xcf);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new Size(0x11c, 0x17);
            this.textBoxStatus.TabIndex = 0x29;
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0xb6);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x4d, 0x12);
            this.label19.TabIndex = 40;
            this.label19.Text = "Invoice No";
            this.textBoxInvoice.BackColor = SystemColors.Window;
            this.textBoxInvoice.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxInvoice.Location = new Point(0x6d, 0xb6);
            this.textBoxInvoice.Name = "textBoxInvoice";
            this.textBoxInvoice.Size = new Size(0x11c, 0x17);
            this.textBoxInvoice.TabIndex = 0x26;
            this.textBoxEngineNo.BackColor = SystemColors.Window;
            this.textBoxEngineNo.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEngineNo.Location = new Point(0x6d, 0x9d);
            this.textBoxEngineNo.Name = "textBoxEngineNo";
            this.textBoxEngineNo.ReadOnly = true;
            this.textBoxEngineNo.Size = new Size(0x11c, 0x17);
            this.textBoxEngineNo.TabIndex = 0x25;
            this.label18.AutoSize = true;
            this.label18.BackColor = Color.DarkSeaGreen;
            this.label18.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label18.Location = new Point(10, 0x9d);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x4b, 0x12);
            this.label18.TabIndex = 0x27;
            this.label18.Text = "Engine No";
            this.comboBoxChassisNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxChassisNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxChassisNo.BackColor = SystemColors.Window;
            this.comboBoxChassisNo.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxChassisNo.FormattingEnabled = true;
            this.comboBoxChassisNo.Location = new Point(0x6d, 0x81);
            this.comboBoxChassisNo.Name = "comboBoxChassisNo";
            this.comboBoxChassisNo.Size = new Size(0x11c, 0x1a);
            this.comboBoxChassisNo.TabIndex = 0x24;
            this.comboBoxChassisNo.SelectedIndexChanged += new EventHandler(this.comboBoxChassisNo_SelectedIndexChanged);
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x81);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x52, 0x12);
            this.label9.TabIndex = 0x1f;
            this.label9.Text = "Chassis No";
            this.comboBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = SystemColors.Window;
            this.comboBoxColor.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new Point(0x6d, 0x65);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new Size(0x11c, 0x1a);
            this.comboBoxColor.TabIndex = 0x23;
            this.comboBoxColor.SelectedIndexChanged += new EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = SystemColors.Window;
            this.comboBoxCC.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new Point(0x6d, 0x49);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new Size(0x11c, 0x1a);
            this.comboBoxCC.TabIndex = 0x22;
            this.comboBoxCC.SelectedIndexChanged += new EventHandler(this.comboBoxCC_SelectedIndexChanged);
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.Window;
            this.comboBoxModel.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x6d, 0x2d);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(0x11c, 0x1a);
            this.comboBoxModel.TabIndex = 0x21;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = SystemColors.Window;
            this.comboBoxBrand.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new Point(0x6d, 0x11);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new Size(0x11c, 0x1a);
            this.comboBoxBrand.TabIndex = 0x20;
            this.comboBoxBrand.SelectedIndexChanged += new EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x65);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x2a, 0x12);
            this.label6.TabIndex = 30;
            this.label6.Text = "Color";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x49);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x1c, 0x12);
            this.label7.TabIndex = 0x1d;
            this.label7.Text = "CC";
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0x2d);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2e, 0x12);
            this.label8.TabIndex = 0x1c;
            this.label8.Text = "Model";
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Bookman Old Style", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(10, 20);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x2f, 0x12);
            this.label13.TabIndex = 0x1b;
            this.label13.Text = "Brand";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19c, 0x111);
            base.Controls.Add(this.groupBox1);
            base.Name = "SearchMotorCycle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SearchMotorCycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            this.textBoxInvoice.Text = "";
            this.textBoxMemo.Text = "";
            this.textBoxStatus.Text = "";
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
            this.textBoxInvoice.Text = "";
            this.textBoxMemo.Text = "";
            this.textBoxStatus.Text = "";
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
            this.textBoxInvoice.Text = "";
            this.textBoxMemo.Text = "";
            this.textBoxStatus.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT chasis_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "';";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, str3);
            this.comboBoxChassisNo.Items.Add("Select");
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
            this.textBoxInvoice.Text = "";
            this.textBoxMemo.Text = "";
            this.textBoxStatus.Text = "";
            string query = "SELECT color FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' group by color;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            this.comboBoxColor.Items.Add("Select");
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxColor.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_engine_no()
        {
            this.textBoxEngineNo.Text = "";
            this.textBoxInvoice.Text = "";
            this.textBoxMemo.Text = "";
            this.textBoxStatus.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT engine_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';";
            string str4 = this.dbc.SelectSingle(str3);
            this.textBoxEngineNo.Text = str4;
            this.textBoxInvoice.Text = this.dbc.SelectSingle("SELECT invoice_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';");
            this.textBoxStatus.Text = this.dbc.SelectSingle("SELECT status FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';");
            if (this.textBoxStatus.Text.Equals("sold"))
            {
                this.textBoxMemo.Text = this.dbc.SelectSingle("SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';");
            }
            else
            {
                this.textBoxMemo.Text = "";
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
            this.textBoxInvoice.Text = "";
            this.textBoxMemo.Text = "";
            this.textBoxStatus.Text = "";
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

