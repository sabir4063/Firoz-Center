namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class ChangePartsPrice : Form
    {
        private Button buttonUpdate;
        public ComboBox comboBoxDescip;
        private ComboBox comboBoxModel;
        public ComboBox comboBoxPartsNo;
        private ComboBox comboBoxParty;
        private IContainer components = null;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private List<string>[] Party = new List<string>[6];
        private TextBox textBoxD;
        private TextBox textBoxDealerPrice;
        private TextBox textBoxPurchasePrice;
        private TextBox textBoxR;
        private TextBox textBoxRetailPrice;
        private TextBox textBoxW;
        private TextBox textBoxWholeSalePrice;

        public ChangePartsPrice()
        {
            this.InitializeComponent();
            this.load_party();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update price?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
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
            this.load_description_Parts();
        }

        private void comboBoxParty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.load_model();
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
            this.comboBoxDescip = new ComboBox();
            this.comboBoxPartsNo = new ComboBox();
            this.label5 = new Label();
            this.label6 = new Label();
            this.groupBox2 = new GroupBox();
            this.label16 = new Label();
            this.comboBoxModel = new ComboBox();
            this.label8 = new Label();
            this.comboBoxParty = new ComboBox();
            this.dateTimePicker2 = new DateTimePicker();
            this.label7 = new Label();
            this.label13 = new Label();
            this.label12 = new Label();
            this.label11 = new Label();
            this.label10 = new Label();
            this.textBoxD = new TextBox();
            this.textBoxW = new TextBox();
            this.textBoxR = new TextBox();
            this.label9 = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBoxDealerPrice = new TextBox();
            this.label3 = new Label();
            this.textBoxWholeSalePrice = new TextBox();
            this.label4 = new Label();
            this.textBoxRetailPrice = new TextBox();
            this.label14 = new Label();
            this.textBoxPurchasePrice = new TextBox();
            this.label15 = new Label();
            this.buttonUpdate = new Button();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.comboBoxDescip.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = SystemColors.ControlLight;
            this.comboBoxDescip.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new Point(0x79, 0x5f);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new Size(250, 0x18);
            this.comboBoxDescip.TabIndex = 9;
            this.comboBoxDescip.SelectedIndexChanged += new EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            this.comboBoxPartsNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new Point(0x79, 0x45);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new Size(250, 0x18);
            this.comboBoxPartsNo.TabIndex = 8;
            this.comboBoxPartsNo.SelectedIndexChanged += new EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 0x5f);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x4c, 0x10);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x45);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 0x10);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxParty);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxD);
            this.groupBox2.Controls.Add(this.textBoxW);
            this.groupBox2.Controls.Add(this.textBoxR);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxDealerPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxWholeSalePrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxRetailPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxPurchasePrice);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            //this.groupBox2.RightToLeft = RightToLeft.No;
            this.groupBox2.Size = new Size(380, 0x117);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Price";
            this.label16.AutoSize = true;
            this.label16.BackColor = Color.DarkSeaGreen;
            this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label16.Location = new Point(10, 0x2d);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x2e, 0x10);
            this.label16.TabIndex = 0x60;
            this.label16.Text = "Model";
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.ControlLight;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x79, 0x2b);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(250, 0x18);
            this.comboBoxModel.TabIndex = 4;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0x15);
            this.label8.Name = "label8";
            this.label8.Size = new Size(80, 0x10);
            this.label8.TabIndex = 0x5e;
            this.label8.Text = "Select Party";
            this.comboBoxParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = SystemColors.ControlLight;
            this.comboBoxParty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new Point(0x79, 0x11);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new Size(250, 0x18);
            this.comboBoxParty.TabIndex = 1;
            this.comboBoxParty.SelectedIndexChanged += new EventHandler(this.comboBoxParty_SelectedIndexChanged_1);
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0x79, 0xd9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x6d, 0x16);
            this.dateTimePicker2.TabIndex = 0x5c;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0xd9);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x5b, 0x10);
            this.label7.TabIndex = 0x5b;
            this.label7.Text = "Effective Date";
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(0x155, 0xc6);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x18, 0x10);
            this.label13.TabIndex = 90;
            this.label13.Text = "Tk";
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0x156, 0xae);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x18, 0x10);
            this.label12.TabIndex = 0x59;
            this.label12.Text = "Tk";
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(0x156, 150);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x18, 0x10);
            this.label11.TabIndex = 0x58;
            this.label11.Text = "Tk";
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(0x155, 0x7c);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x18, 0x10);
            this.label10.TabIndex = 0x57;
            this.label10.Text = "Tk";
            this.textBoxD.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxD.Location = new Point(0xe7, 0xc1);
            this.textBoxD.Name = "textBoxD";
            //this.textBoxD.RightToLeft = RightToLeft.Yes;
            this.textBoxD.Size = new Size(0x66, 0x16);
            this.textBoxD.TabIndex = 0x56;
            this.textBoxW.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxW.Location = new Point(0xe7, 0xa9);
            this.textBoxW.Name = "textBoxW";
            //this.textBoxW.RightToLeft = RightToLeft.Yes;
            this.textBoxW.Size = new Size(0x66, 0x16);
            this.textBoxW.TabIndex = 0x55;
            this.textBoxR.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxR.Location = new Point(0xe7, 0x91);
            this.textBoxR.Name = "textBoxR";
//            this.textBoxR.RightToLeft = RightToLeft.Yes;
            this.textBoxR.Size = new Size(0x66, 0x16);
            this.textBoxR.TabIndex = 0x54;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(210, 0xc4);
            this.label9.Name = "label9";
            this.label9.Size = new Size(20, 0x10);
            this.label9.TabIndex = 0x53;
            this.label9.Text = "%";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(210, 0xac);
            this.label1.Name = "label1";
            this.label1.Size = new Size(20, 0x10);
            this.label1.TabIndex = 0x52;
            this.label1.Text = "%";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(210, 0x94);
            this.label2.Name = "label2";
            this.label2.Size = new Size(20, 0x10);
            this.label2.TabIndex = 0x51;
            this.label2.Text = "%";
            this.textBoxDealerPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDealerPrice.Location = new Point(0x79, 0xc1);
            this.textBoxDealerPrice.Name = "textBoxDealerPrice";
            this.textBoxDealerPrice.Size = new Size(0x56, 0x16);
            this.textBoxDealerPrice.TabIndex = 0x4c;
            this.textBoxDealerPrice.TextChanged += new EventHandler(this.textBoxDealer_TextChanged);
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0xc1);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x53, 0x10);
            this.label3.TabIndex = 80;
            this.label3.Text = "Dealer Price";
            this.textBoxWholeSalePrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxWholeSalePrice.Location = new Point(0x79, 0xa9);
            this.textBoxWholeSalePrice.Name = "textBoxWholeSalePrice";
            this.textBoxWholeSalePrice.Size = new Size(0x56, 0x16);
            this.textBoxWholeSalePrice.TabIndex = 0x4b;
            this.textBoxWholeSalePrice.TextChanged += new EventHandler(this.textBoxWholeSAle_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0xa9);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x6b, 0x10);
            this.label4.TabIndex = 0x4f;
            this.label4.Text = "Wholesale Price";
            this.textBoxRetailPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxRetailPrice.Location = new Point(0x79, 0x91);
            this.textBoxRetailPrice.Name = "textBoxRetailPrice";
            this.textBoxRetailPrice.Size = new Size(0x56, 0x16);
            this.textBoxRetailPrice.TabIndex = 0x4a;
            this.textBoxRetailPrice.TextChanged += new EventHandler(this.textBoxSalesPrice_TextChanged);
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 0x91);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x4d, 0x10);
            this.label14.TabIndex = 0x4e;
            this.label14.Text = "Retail Price";
            this.textBoxPurchasePrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPurchasePrice.Location = new Point(0x79, 0x79);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
//            this.textBoxPurchasePrice.RightToLeft = RightToLeft.Yes;
            this.textBoxPurchasePrice.Size = new Size(0xd4, 0x16);
            this.textBoxPurchasePrice.TabIndex = 0x49;
            this.label15.AutoSize = true;
            this.label15.BackColor = Color.DarkSeaGreen;
            this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label15.Location = new Point(10, 0x79);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x63, 0x10);
            this.label15.TabIndex = 0x4d;
            this.label15.Text = "Purchase Price";
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0x88, 0xf4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(120, 30);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(390, 0x11f);
            base.Controls.Add(this.groupBox2);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "ChangePartsPrice";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ChangePartsPrice";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_description_Parts()
        {
            int num;
            this.comboBoxDescip.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.textBoxPurchasePrice.Text = "";
            this.textBoxRetailPrice.Text = "";
            this.textBoxWholeSalePrice.Text = "";
            this.textBoxDealerPrice.Text = "";
            this.textBoxD.Text = "";
            this.textBoxR.Text = "";
            this.textBoxW.Text = "";
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
            this.textBoxPurchasePrice.Text = "";
            this.textBoxRetailPrice.Text = "";
            this.textBoxWholeSalePrice.Text = "";
            this.textBoxDealerPrice.Text = "";
            this.textBoxD.Text = "";
            this.textBoxR.Text = "";
            this.textBoxW.Text = "";
            string query = "Select purchase_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ORDER BY DATE DESC LIMIT 1;";
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxPurchasePrice.Text = str2;
            query = "Select sale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ORDER BY DATE DESC LIMIT 1;";
            this.textBoxR.Text = this.dbc.SelectSingle(query);
            query = "Select distributor_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ORDER BY DATE DESC LIMIT 1;";
            this.textBoxD.Text = this.dbc.SelectSingle(query);
            query = "Select wholesale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ORDER BY DATE DESC LIMIT 1;";
            this.textBoxW.Text = this.dbc.SelectSingle(query);
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string str = "Honda";
            string str2 = this.comboBoxParty.SelectedItem.ToString();
            string str3 = this.comboBoxPartsNo.SelectedItem.ToString();
            string str4 = this.comboBoxDescip.SelectedItem.ToString();
            string text = this.textBoxPurchasePrice.Text;
            string str6 = this.textBoxR.Text;
            string str7 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str8 = this.textBoxW.Text;
            string str9 = this.textBoxD.Text;
            string str10 = connect.SelectSingle("Select model from firoz_center.tbl_parts_info where partsNo='" + str3 + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ;");
            string str11 = connect.SelectSingle("Select partsId from firoz_center.tbl_parts_info where partsNo='" + str3 + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' ;");
            string query = "insert into firoz_center.tbl_parts_info (`partsId`,`brand`,`model`,`partsNo`,`description`,`purchase_price`,`sale_price`,`date`,`wholesale_price`,`distributor_price`,`group`) values ('" + str11 + "','" + str + "','" + str10 + "','" + str3 + "','" + str4 + "','" + text + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str9 + "','" + str2 + "');";
            connect.Insert(query);
            this.textBoxPurchasePrice.Text = "";
            this.textBoxRetailPrice.Text = "";
            this.textBoxWholeSalePrice.Text = "";
            this.textBoxDealerPrice.Text = "";
            this.textBoxD.Text = "";
            this.textBoxR.Text = "";
            this.textBoxW.Text = "";
            MessageBox.Show("Price Updated");
        }

        private void textBoxDealer_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxDealerPrice.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPurchasePrice.Text);
                double num2 = double.Parse(this.textBoxDealerPrice.Text);
                this.textBoxD.Text = Math.Round((double) (num * ((num2 + 100.0) / 100.0))).ToString();
            }
        }

        private void textBoxSalesPrice_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxRetailPrice.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPurchasePrice.Text);
                double num2 = double.Parse(this.textBoxRetailPrice.Text);
                this.textBoxR.Text = Math.Round((double) (num * ((num2 + 100.0) / 100.0))).ToString();
            }
        }

        private void textBoxWholeSAle_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxWholeSalePrice.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPurchasePrice.Text);
                double num2 = double.Parse(this.textBoxWholeSalePrice.Text);
                this.textBoxW.Text = Math.Round((double) (num * ((num2 + 100.0) / 100.0))).ToString();
            }
        }
    }
}

