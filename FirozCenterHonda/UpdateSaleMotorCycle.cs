namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class UpdateSaleMotorCycle : Form
    {
        private Button button1;
        private Button buttonDelete;
        private Button buttonUpdate;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxChassisNo;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private IContainer components;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxBrand;
        private TextBox textBoxCC;
        private TextBox textBoxChassis;
        private TextBox textBoxColor;
        private TextBox textBoxDate;
        private TextBox textBoxEngine;
        private TextBox textBoxMemo;
        private TextBox textBoxModel;
        private TextBox textBoxNewEngine;
        private TextBox textBoxPrice;
        private TextBox textBoxPriceOld;

        public UpdateSaleMotorCycle()
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
            this.load_brand();
        }

        public UpdateSaleMotorCycle(string memo)
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
            this.load_brand();
            this.load_all(memo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change date?", "Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string query = "update firoz_center.tbl_transcation set date='" + str + "' where memo_no='" + this.textBoxMemo.Text + "' and description='Motor cycle';";
                this.dbc.Update(query);
                query = "update firoz_center.tbl_sales_motorcycle set date='" + str + "' where memo_no='" + this.textBoxMemo.Text + "';";
                this.dbc.Delete(query);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete sale?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.load_brand();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update sale?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string query = "update firoz_center.tbl_transcation set debit='" + this.textBoxPrice.Text + "', date='" + str + "' where memo_no='" + this.textBoxMemo.Text + "' and description='Motor cycle';";
                this.dbc.Update(query);
                query = "update firoz_center.tbl_vehicle set sale_rate='0', status='stock',memo_no='',comments='stock' where memo_no='" + this.textBoxMemo.Text + "';";
                this.dbc.Update(query);
                string str3 = this.comboBoxBrand.SelectedItem.ToString();
                string str4 = this.comboBoxModel.SelectedItem.ToString();
                string str5 = this.comboBoxCC.SelectedItem.ToString();
                string str6 = this.comboBoxColor.SelectedItem.ToString();
                string str7 = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where brand='" + str3 + "' and model='" + str4 + "' and cc='" + str5 + "' and color='" + str6 + "'; ";
                string str8 = this.dbc.SelectSingle(str7);
                string str9 = this.comboBoxChassisNo.SelectedItem.ToString();
                string text = this.textBoxNewEngine.Text;
                string str11 = this.textBoxPrice.Text;
                string str12 = this.textBoxMemo.Text;
                string str13 = "Select id from firoz_center.tbl_vehicle where vehicleid = '" + str8 + "' and chasis_no='" + str9 + "' and engine_no='" + text + "' and status='stock';";
                string str14 = this.dbc.SelectSingle(str13);
                string str15 = "update firoz_center.tbl_vehicle set `sale_rate`='" + str11 + "',`status`='sold',memo_no='" + str12 + "',`comments`='sold' where id ='" + str14 + "'; ";
                this.dbc.Update(str15);
                query = "update firoz_center.tbl_sales_motorcycle set grand_total='" + str11 + "',net_amount='" + str11 + "',date='" + str + "' where memo_no='" + this.textBoxMemo.Text + "';";
                this.dbc.Delete(query);
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
            this.textBoxBrand = new TextBox();
            this.textBoxChassis = new TextBox();
            this.label8 = new Label();
            this.textBoxEngine = new TextBox();
            this.label1 = new Label();
            this.label7 = new Label();
            this.label2 = new Label();
            this.label6 = new Label();
            this.textBoxColor = new TextBox();
            this.label5 = new Label();
            this.textBoxCC = new TextBox();
            this.groupBox1 = new GroupBox();
            this.textBoxDate = new TextBox();
            this.label11 = new Label();
            this.textBoxPriceOld = new TextBox();
            this.label9 = new Label();
            this.textBoxMemo = new TextBox();
            this.label3 = new Label();
            this.textBoxModel = new TextBox();
            this.groupBox2 = new GroupBox();
            this.button1 = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.label18 = new Label();
            this.textBoxPrice = new TextBox();
            this.label4 = new Label();
            this.comboBoxChassisNo = new ComboBox();
            this.label13 = new Label();
            this.comboBoxColor = new ComboBox();
            this.comboBoxCC = new ComboBox();
            this.comboBoxModel = new ComboBox();
            this.comboBoxBrand = new ComboBox();
            this.label14 = new Label();
            this.label15 = new Label();
            this.label16 = new Label();
            this.label17 = new Label();
            this.buttonUpdate = new Button();
            this.textBoxNewEngine = new TextBox();
            this.buttonDelete = new Button();
            this.label10 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.textBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBrand.Location = new Point(0x5e, 0x44);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.ReadOnly = true;
            this.textBoxBrand.Size = new Size(250, 0x16);
            this.textBoxBrand.TabIndex = 0x1d;
            this.textBoxChassis.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxChassis.Location = new Point(0x5e, 0xbc);
            this.textBoxChassis.Name = "textBoxChassis";
            this.textBoxChassis.ReadOnly = true;
            this.textBoxChassis.Size = new Size(250, 0x16);
            this.textBoxChassis.TabIndex = 0x24;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0x44);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2c, 0x10);
            this.label8.TabIndex = 15;
            this.label8.Text = "Brand";
            this.textBoxEngine.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEngine.Location = new Point(0x5e, 0xa4);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.ReadOnly = true;
            this.textBoxEngine.Size = new Size(250, 0x16);
            this.textBoxEngine.TabIndex = 0x23;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0xbc);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4d, 0x10);
            this.label1.TabIndex = 0x22;
            this.label1.Text = "Chassis No";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x5c);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 0x11;
            this.label7.Text = "Model";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0xa4);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x47, 0x10);
            this.label2.TabIndex = 0x21;
            this.label2.Text = "Engine No";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x74);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x1a, 0x10);
            this.label6.TabIndex = 0x12;
            this.label6.Text = "CC";
            this.textBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxColor.Location = new Point(0x5e, 140);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new Size(250, 0x16);
            this.textBoxColor.TabIndex = 0x20;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new Size(40, 0x10);
            this.label5.TabIndex = 0x13;
            this.label5.Text = "Color";
            this.textBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCC.Location = new Point(0x5e, 0x74);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ReadOnly = true;
            this.textBoxCC.Size = new Size(250, 0x16);
            this.textBoxCC.TabIndex = 0x1f;
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxPriceOld);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxMemo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxBrand);
            this.groupBox1.Controls.Add(this.textBoxChassis);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxEngine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxCC);
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(360, 0x105);
            this.groupBox1.TabIndex = 0x27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update / Delete";
            this.textBoxDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDate.Location = new Point(0x5e, 0x2c);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new Size(250, 0x16);
            this.textBoxDate.TabIndex = 0x35;
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 0x2c);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x25, 0x10);
            this.label11.TabIndex = 0x34;
            this.label11.Text = "Date";
            this.textBoxPriceOld.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPriceOld.Location = new Point(0x5e, 0xd4);
            this.textBoxPriceOld.Name = "textBoxPriceOld";
            this.textBoxPriceOld.ReadOnly = true;
            this.textBoxPriceOld.Size = new Size(250, 0x16);
            this.textBoxPriceOld.TabIndex = 0x33;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0xd4);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x27, 0x10);
            this.label9.TabIndex = 50;
            this.label9.Text = "Price";
            this.textBoxMemo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemo.Location = new Point(0x5e, 20);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new Size(250, 0x16);
            this.textBoxMemo.TabIndex = 1;
            this.textBoxMemo.KeyDown += new KeyEventHandler(this.textBoxMemo_KeyDown);
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x43, 0x10);
            this.label3.TabIndex = 0x25;
            this.label3.Text = "Memo No";
            this.textBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxModel.Location = new Point(0x5e, 0x5c);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new Size(250, 0x16);
            this.textBoxModel.TabIndex = 30;
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxChassisNo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.comboBoxCC);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.textBoxNewEngine);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(0x173, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(360, 0x105);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update / Delete";
            this.button1.BackColor = Color.MediumSeaGreen;
            this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(0xe2, 13);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 30);
            this.button1.TabIndex = 0x38;
            this.button1.Text = "Date Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x60, 0x13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x79, 0x16);
            this.dateTimePicker1.TabIndex = 0x37;
            this.label18.AutoSize = true;
            this.label18.BackColor = Color.DarkSeaGreen;
            this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label18.Location = new Point(10, 20);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x25, 0x10);
            this.label18.TabIndex = 0x36;
            this.label18.Text = "Date";
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(0x60, 0xc5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new Size(250, 0x16);
            this.textBoxPrice.TabIndex = 0x31;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 200);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x27, 0x10);
            this.label4.TabIndex = 0x30;
            this.label4.Text = "Price";
            this.comboBoxChassisNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxChassisNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxChassisNo.BackColor = SystemColors.Window;
            this.comboBoxChassisNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxChassisNo.FormattingEnabled = true;
            this.comboBoxChassisNo.Location = new Point(0x60, 0x93);
            this.comboBoxChassisNo.Name = "comboBoxChassisNo";
            this.comboBoxChassisNo.Size = new Size(250, 0x18);
            this.comboBoxChassisNo.TabIndex = 0x2f;
            this.comboBoxChassisNo.SelectedIndexChanged += new EventHandler(this.comboBoxChassisNo_SelectedIndexChanged);
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(10, 150);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x4d, 0x10);
            this.label13.TabIndex = 0x2e;
            this.label13.Text = "Chassis No";
            this.comboBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = SystemColors.Window;
            this.comboBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new Point(0x60, 0x79);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new Size(250, 0x18);
            this.comboBoxColor.TabIndex = 0x2d;
            this.comboBoxColor.SelectedIndexChanged += new EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = SystemColors.Window;
            this.comboBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new Point(0x60, 0x5f);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new Size(250, 0x18);
            this.comboBoxCC.TabIndex = 0x2c;
            this.comboBoxCC.SelectedIndexChanged += new EventHandler(this.comboBoxCC_SelectedIndexChanged);
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.Window;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x60, 0x45);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(250, 0x18);
            this.comboBoxModel.TabIndex = 0x2b;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = SystemColors.Window;
            this.comboBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new Point(0x60, 0x2b);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new Size(250, 0x18);
            this.comboBoxBrand.TabIndex = 0x2a;
            this.comboBoxBrand.SelectedIndexChanged += new EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 0x7c);
            this.label14.Name = "label14";
            this.label14.Size = new Size(40, 0x10);
            this.label14.TabIndex = 0x29;
            this.label14.Text = "Color";
            this.label15.AutoSize = true;
            this.label15.BackColor = Color.DarkSeaGreen;
            this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label15.Location = new Point(10, 0x5f);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x1a, 0x10);
            this.label15.TabIndex = 40;
            this.label15.Text = "CC";
            this.label16.AutoSize = true;
            this.label16.BackColor = Color.DarkSeaGreen;
            this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label16.Location = new Point(10, 0x45);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x2e, 0x10);
            this.label16.TabIndex = 0x27;
            this.label16.Text = "Model";
            this.label17.AutoSize = true;
            this.label17.BackColor = Color.DarkSeaGreen;
            this.label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label17.Location = new Point(10, 0x2b);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0x2c, 0x10);
            this.label17.TabIndex = 0x26;
            this.label17.Text = "Brand";
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0xbf, 0xe1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(120, 30);
            this.buttonUpdate.TabIndex = 0x25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            this.textBoxNewEngine.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNewEngine.Location = new Point(0x60, 0xad);
            this.textBoxNewEngine.Name = "textBoxNewEngine";
            this.textBoxNewEngine.ReadOnly = true;
            this.textBoxNewEngine.Size = new Size(250, 0x16);
            this.textBoxNewEngine.TabIndex = 0x24;
            this.buttonDelete.BackColor = Color.MediumSeaGreen;
            this.buttonDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonDelete.Location = new Point(0x41, 0xe1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new Size(120, 30);
            this.buttonDelete.TabIndex = 0x10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(10, 0xb0);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x47, 0x10);
            this.label10.TabIndex = 0x21;
            this.label10.Text = "Engine No";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x2df, 0x10f);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "UpdateSaleMotorCycle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Sale Motor Cycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_all(string memo)
        {
            int num;
            this.textBoxMemo.Text = memo;
            string text = this.textBoxMemo.Text;
            string query = "Select net_amount,customer_id,type from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';";
            List<string>[] listArray = new List<string>[3];
            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            if (this.dbc.Select(3L, query)[0].Count == 0)
            {
                MessageBox.Show("Search Again");
            }
            else
            {
                this.textBoxDate.Text = this.dbc.Select_Date_Format("Select date from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';");
                query = "Select vehicleid,chasis_no,engine_no,sale_rate from firoz_center.tbl_vehicle where memo_no='" + text + "';";
                List<string>[] listArray2 = new List<string>[4];
                for (num = 0; num < 4; num++)
                {
                    listArray2[num] = new List<string>();
                }
                listArray2 = this.dbc.Select(4L, query);
                this.textBoxChassis.Text = listArray2[1].ElementAt<string>(0);
                this.textBoxEngine.Text = listArray2[2].ElementAt<string>(0);
                this.textBoxPriceOld.Text = listArray2[3].ElementAt<string>(0);
                query = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray2[0].ElementAt<string>(0) + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (num = 0; num < 4; num++)
                {
                    listArray3[num] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, query);
                this.textBoxBrand.Text = listArray3[0].ElementAt<string>(0);
                this.textBoxModel.Text = listArray3[1].ElementAt<string>(0);
                this.textBoxCC.Text = listArray3[2].ElementAt<string>(0);
                this.textBoxColor.Text = listArray3[3].ElementAt<string>(0);
            }
        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxNewEngine.Text = "";
            this.textBoxPrice.Text = "";
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
            this.textBoxNewEngine.Text = "";
            this.textBoxPrice.Text = "";
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
            this.textBoxNewEngine.Text = "";
            this.textBoxPrice.Text = "";
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
            this.textBoxNewEngine.Text = "";
            this.textBoxPrice.Text = "";
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
            this.textBoxNewEngine.Text = "";
            this.textBoxPrice.Text = "";
            string query = "Select vehicle_id from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            string str3 = "SELECT engine_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str2 + "' and chasis_no='" + this.comboBoxChassisNo.SelectedItem.ToString() + "';";
            string str4 = this.dbc.SelectSingle(str3);
            this.textBoxNewEngine.Text = str4;
            string str5 = "Select sale_price from firoz_center.tbl_vehicle_info where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
            string str6 = this.dbc.SelectSingle(str5);
            this.textBoxPrice.Text = str6;
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.comboBoxChassisNo.Items.Clear();
            this.textBoxNewEngine.Text = "";
            this.textBoxPrice.Text = "";
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

        private void save_transcation()
        {
            string query = "Delete from firoz_center.tbl_transcation where memo_no='" + this.textBoxMemo.Text + "' and description='Motor cycle';";
            this.dbc.Delete(query);
            query = "update firoz_center.tbl_vehicle set sale_rate='0', status='stock',memo_no='',`comments`='stock' where memo_no='" + this.textBoxMemo.Text + "';";
            this.dbc.Update(query);
            query = "Delete from firoz_center.tbl_sales_motorcycle  where memo_no='" + this.textBoxMemo.Text + "';";
            this.dbc.Delete(query);
        }

        private void textBoxMemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_all(this.textBoxMemo.Text);
            }
        }
    }
}

