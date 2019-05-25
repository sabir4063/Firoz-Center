namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class DeleteParts : Form
    {
        private Button buttonDelete;
        public ComboBox comboBoxDate;
        public ComboBox comboBoxDescip;
        private ComboBox comboBoxModel;
        public ComboBox comboBoxPartsNo;
        private ComboBox comboBoxParty;
        private IContainer components = null;
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

        public DeleteParts()
        {
            this.InitializeComponent();
            this.load_party();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete parts?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_price();
        }

        private void comboBoxDescip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxPartsNo.SelectedIndex = this.comboBoxDescip.SelectedIndex;
            this.load_date();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_description_Parts();
        }

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_date();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
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
            this.buttonDelete = new Button();
            this.comboBoxDescip = new ComboBox();
            this.comboBoxPartsNo = new ComboBox();
            this.label5 = new Label();
            this.label6 = new Label();
            this.groupBox2 = new GroupBox();
            this.comboBoxDate = new ComboBox();
            this.label7 = new Label();
            this.label16 = new Label();
            this.comboBoxModel = new ComboBox();
            this.label8 = new Label();
            this.comboBoxParty = new ComboBox();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.Location = new Point(0x156, 0xe0);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x18, 0x10);
            this.label13.TabIndex = 90;
            this.label13.Text = "Tk";
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0x157, 200);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x18, 0x10);
            this.label12.TabIndex = 0x59;
            this.label12.Text = "Tk";
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(0x157, 0xb0);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x18, 0x10);
            this.label11.TabIndex = 0x58;
            this.label11.Text = "Tk";
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(0x156, 150);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x18, 0x10);
            this.label10.TabIndex = 0x57;
            this.label10.Text = "Tk";
            this.textBoxD.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxD.Location = new Point(0xe7, 0xda);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ReadOnly = true;
            //this.textBoxD.RightToLeft = RightToLeft.Yes;
            this.textBoxD.Size = new Size(0x66, 0x16);
            this.textBoxD.TabIndex = 0x56;
            this.textBoxW.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxW.Location = new Point(0xe7, 0xc2);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.ReadOnly = true;
            this.textBoxW.RightToLeft = RightToLeft.Yes;
            this.textBoxW.Size = new Size(0x66, 0x16);
            this.textBoxW.TabIndex = 0x55;
            this.textBoxR.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxR.Location = new Point(0xe7, 170);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.RightToLeft = RightToLeft.Yes;
            this.textBoxR.Size = new Size(0x66, 0x16);
            this.textBoxR.TabIndex = 0x54;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(0xcd, 0xdd);
            this.label9.Name = "label9";
            this.label9.Size = new Size(20, 0x10);
            this.label9.TabIndex = 0x53;
            this.label9.Text = "%";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0xcd, 0xc5);
            this.label1.Name = "label1";
            this.label1.Size = new Size(20, 0x10);
            this.label1.TabIndex = 0x52;
            this.label1.Text = "%";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0xcd, 0xad);
            this.label2.Name = "label2";
            this.label2.Size = new Size(20, 0x10);
            this.label2.TabIndex = 0x51;
            this.label2.Text = "%";
            this.textBoxDealerPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDealerPrice.Location = new Point(0x79, 0xda);
            this.textBoxDealerPrice.Name = "textBoxDealerPrice";
            this.textBoxDealerPrice.ReadOnly = true;
            this.textBoxDealerPrice.Size = new Size(0x4e, 0x16);
            this.textBoxDealerPrice.TabIndex = 0x4c;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0xda);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x53, 0x10);
            this.label3.TabIndex = 80;
            this.label3.Text = "Dealer Price";
            this.textBoxWholeSalePrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxWholeSalePrice.Location = new Point(0x79, 0xc2);
            this.textBoxWholeSalePrice.Name = "textBoxWholeSalePrice";
            this.textBoxWholeSalePrice.ReadOnly = true;
            this.textBoxWholeSalePrice.Size = new Size(0x4e, 0x16);
            this.textBoxWholeSalePrice.TabIndex = 0x4b;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0xc2);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x6b, 0x10);
            this.label4.TabIndex = 0x4f;
            this.label4.Text = "Wholesale Price";
            this.textBoxRetailPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxRetailPrice.Location = new Point(0x79, 170);
            this.textBoxRetailPrice.Name = "textBoxRetailPrice";
            this.textBoxRetailPrice.ReadOnly = true;
            this.textBoxRetailPrice.Size = new Size(0x4e, 0x16);
            this.textBoxRetailPrice.TabIndex = 0x4a;
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.DarkSeaGreen;
            this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.Location = new Point(10, 170);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x4d, 0x10);
            this.label14.TabIndex = 0x4e;
            this.label14.Text = "Retail Price";
            this.textBoxPurchasePrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPurchasePrice.Location = new Point(0x79, 0x92);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.ReadOnly = true;
            this.textBoxPurchasePrice.RightToLeft = RightToLeft.Yes;
            this.textBoxPurchasePrice.Size = new Size(0xd4, 0x16);
            this.textBoxPurchasePrice.TabIndex = 0x49;
            this.label15.AutoSize = true;
            this.label15.BackColor = Color.DarkSeaGreen;
            this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label15.Location = new Point(10, 0x95);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x63, 0x10);
            this.label15.TabIndex = 0x4d;
            this.label15.Text = "Purchase Price";
            this.buttonDelete.BackColor = Color.MediumSeaGreen;
            this.buttonDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonDelete.Location = new Point(130, 0xfb);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new Size(120, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            this.comboBoxDescip.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = SystemColors.ControlLight;
            this.comboBoxDescip.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new Point(0x79, 0x5e);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new Size(250, 0x18);
            this.comboBoxDescip.TabIndex = 9;
            this.comboBoxDescip.SelectedIndexChanged += new EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            this.comboBoxPartsNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new Point(0x79, 0x44);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new Size(250, 0x18);
            this.comboBoxPartsNo.TabIndex = 8;
            this.comboBoxPartsNo.SelectedIndexChanged += new EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 0x5e);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x4c, 0x10);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x44);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 0x10);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxParty);
            this.groupBox2.Controls.Add(this.comboBoxDate);
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
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            //this.groupBox2.RightToLeft = RightToLeft.No;
            this.groupBox2.Size = new Size(380, 0x123);
            this.groupBox2.TabIndex = 0x10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Parts";
            this.comboBoxDate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxDate.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxDate.BackColor = SystemColors.ControlLight;
            this.comboBoxDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new Point(0x79, 120);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new Size(130, 0x18);
            this.comboBoxDate.TabIndex = 0x5c;
            this.comboBoxDate.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 120);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x5b, 0x10);
            this.label7.TabIndex = 0x5b;
            this.label7.Text = "Effective Date";
            this.label16.AutoSize = true;
            this.label16.BackColor = Color.DarkSeaGreen;
            this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label16.Location = new Point(10, 0x2c);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x2e, 0x10);
            this.label16.TabIndex = 100;
            this.label16.Text = "Model";
            this.comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = SystemColors.ControlLight;
            this.comboBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new Point(0x79, 0x2a);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new Size(250, 0x18);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.SelectedIndexChanged += new EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new Size(80, 0x10);
            this.label8.TabIndex = 0x63;
            this.label8.Text = "Select Party";
            this.comboBoxParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = SystemColors.ControlLight;
            this.comboBoxParty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new Point(0x79, 0x10);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new Size(250, 0x18);
            this.comboBoxParty.TabIndex = 1;
            this.comboBoxParty.SelectedIndexChanged += new EventHandler(this.comboBoxParty_SelectedIndexChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(390, 300);
            base.Controls.Add(this.groupBox2);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "DeleteParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DeleteParts";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_date()
        {
            int num;
            this.comboBoxDate.Items.Clear();
            string query = "SELECT DATE_FORMAT(date, '%Y-%m-%d') AS date FROM firoz_center.tbl_parts_info t where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "';";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxDate.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
            this.textBoxPurchasePrice.Text = "";
            this.textBoxRetailPrice.Text = "";
            this.textBoxDealerPrice.Text = "";
            this.textBoxWholeSalePrice.Text = "";
            this.textBoxD.Text = "";
            this.textBoxW.Text = "";
            this.textBoxR.Text = "";
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
            string query = "SELECT description,partsNo AS date FROM firoz_center.tbl_parts_info where `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' group by description,partsNo;";
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
            string query = "Select purchase_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and date = '" + this.comboBoxDate.SelectedItem.ToString() + "';";
            string str2 = this.dbc.SelectSingle(query);
            this.textBoxPurchasePrice.Text = str2;
            query = "Select sale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and date = '" + this.comboBoxDate.SelectedItem.ToString() + "';";
            this.textBoxR.Text = this.dbc.SelectSingle(query);
            query = "Select distributor_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and date = '" + this.comboBoxDate.SelectedItem.ToString() + "';";
            this.textBoxD.Text = this.dbc.SelectSingle(query);
            query = "Select wholesale_price from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "' and date = '" + this.comboBoxDate.SelectedItem.ToString() + "';";
            this.textBoxW.Text = this.dbc.SelectSingle(query);
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string str2 = this.comboBoxPartsNo.SelectedItem.ToString();
            string str3 = this.comboBoxDescip.SelectedItem.ToString();
            string str4 = this.comboBoxDate.SelectedItem.ToString();
            string query = "DELETE from firoz_center.tbl_parts_info where partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "' and date = '" + this.comboBoxDate.SelectedItem.ToString() + "' and `group` = '" + this.comboBoxParty.SelectedItem.ToString() + "';";
            connect.Delete(query);
            this.textBoxPurchasePrice.Text = "";
            this.textBoxRetailPrice.Text = "";
            this.textBoxWholeSalePrice.Text = "";
            this.textBoxDealerPrice.Text = "";
            this.textBoxD.Text = "";
            this.textBoxR.Text = "";
            this.textBoxW.Text = "";
            MessageBox.Show("Parts Deleted");
        }
    }
}

