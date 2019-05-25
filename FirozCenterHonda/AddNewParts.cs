namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AddNewParts : Form
    {
        private Button buttonAddNewProduct;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxD;
        private TextBox textBoxDealer;
        private TextBox textBoxDescription;
        private TextBox textBoxGroup;
        private TextBox textBoxModel;
        private TextBox textBoxPartsNo;
        private TextBox textBoxPurchasePrice;
        private TextBox textBoxR;
        private TextBox textBoxSalesPrice;
        private TextBox textBoxW;
        private TextBox textBoxWholeSAle;

        public AddNewParts()
        {
            this.InitializeComponent();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new part?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((((this.textBoxPurchasePrice.Text.Equals("") || this.textBoxR.Text.Equals("")) || (this.textBoxW.Text.Equals("") || this.textBoxD.Text.Equals(""))) || ((this.textBoxModel.Text.Equals("") || this.textBoxDescription.Text.Equals("")) || this.textBoxPartsNo.Text.Equals(""))) || this.textBoxGroup.Text.Equals(""))
                {
                    MessageBox.Show("Check Data");
                }
                else
                {
                    this.save_transcation();
                }
            }
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
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDealer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWholeSAle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSalesPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPartsNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewProduct.Location = new System.Drawing.Point(147, 262);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(120, 30);
            this.buttonAddNewProduct.TabIndex = 53;
            this.buttonAddNewProduct.Text = "Add New";
            this.buttonAddNewProduct.UseVisualStyleBackColor = false;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxGroup);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxD);
            this.groupBox1.Controls.Add(this.textBoxW);
            this.groupBox1.Controls.Add(this.textBoxR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDealer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxWholeSAle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSalesPrice);
            this.groupBox1.Controls.Add(this.buttonAddNewProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPurchasePrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPartsNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 301);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Parts Information";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup.Location = new System.Drawing.Point(118, 21);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(280, 22);
            this.textBoxGroup.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 76;
            this.label15.Text = "Group";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(118, 45);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(280, 22);
            this.textBoxModel.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 74;
            this.label14.Text = "Model";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(351, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 72;
            this.label13.Text = "Tk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 71;
            this.label12.Text = "Tk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "Tk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Tk";
            // 
            // textBoxD
            // 
            this.textBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxD.Location = new System.Drawing.Point(255, 234);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(92, 22);
            this.textBoxD.TabIndex = 68;
            // 
            // textBoxW
            // 
            this.textBoxW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW.Location = new System.Drawing.Point(255, 210);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(92, 22);
            this.textBoxW.TabIndex = 67;
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR.Location = new System.Drawing.Point(255, 186);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(92, 22);
            this.textBoxR.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "%";
            // 
            // textBoxDealer
            // 
            this.textBoxDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDealer.Location = new System.Drawing.Point(118, 234);
            this.textBoxDealer.Name = "textBoxDealer";
            this.textBoxDealer.Size = new System.Drawing.Size(102, 22);
            this.textBoxDealer.TabIndex = 6;
            this.textBoxDealer.TextChanged += new System.EventHandler(this.textBoxDealer_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Dealer Price";
            // 
            // textBoxWholeSAle
            // 
            this.textBoxWholeSAle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWholeSAle.Location = new System.Drawing.Point(118, 210);
            this.textBoxWholeSAle.Name = "textBoxWholeSAle";
            this.textBoxWholeSAle.Size = new System.Drawing.Size(102, 22);
            this.textBoxWholeSAle.TabIndex = 5;
            this.textBoxWholeSAle.TextChanged += new System.EventHandler(this.textBoxWholeSAle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Wholesale Price";
            // 
            // textBoxSalesPrice
            // 
            this.textBoxSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalesPrice.Location = new System.Drawing.Point(118, 186);
            this.textBoxSalesPrice.Name = "textBoxSalesPrice";
            this.textBoxSalesPrice.Size = new System.Drawing.Size(102, 22);
            this.textBoxSalesPrice.TabIndex = 4;
            this.textBoxSalesPrice.TextChanged += new System.EventHandler(this.textBoxSalesPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Retail Price";
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(118, 162);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(229, 22);
            this.textBoxPurchasePrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Purchase Price";
            // 
            // textBoxPartsNo
            // 
            this.textBoxPartsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPartsNo.Location = new System.Drawing.Point(118, 69);
            this.textBoxPartsNo.Name = "textBoxPartsNo";
            this.textBoxPartsNo.Size = new System.Drawing.Size(280, 22);
            this.textBoxPartsNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Parts No";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(118, 93);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(280, 67);
            this.textBoxDescription.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Description";
            // 
            // AddNewParts
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewParts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void save_transcation()
        {
            string str13;
            string text = this.textBoxGroup.Text;
            string str2 = "Honda";
            string str3 = this.textBoxModel.Text;
            string str4 = this.textBoxPartsNo.Text;
            string str5 = this.textBoxDescription.Text;
            string str6 = this.textBoxPurchasePrice.Text;
            string str7 = this.textBoxR.Text;
            
            DateTime now = new DateTime();
            now = DateTime.Now;
            //string str8 = string.Format("{0:yyyy-MM-dd}", now);
            string str8 = "2016-01-01";

            string str9 = this.textBoxW.Text;
            string str10 = this.textBoxD.Text;
            DBConnect connect = new DBConnect();
            string query = "SELECT partsId FROM firoz_center.tbl_parts_info where partsNo='" + this.textBoxPartsNo.Text + "';";
            string str12 = connect.SelectSingle(query);
            if (connect.Count(query) == -1L)
            {
                str13 = "insert into firoz_center.tbl_parts_info (`brand`,`model`,`partsNo`,`description`,`purchase_price`,`sale_price`,`date`,`wholesale_price`,`distributor_price`,`group`) values ('" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str9 + "','" + str10 + "','" + text + "');";
                connect.Insert(str13);
            }
            else
            {
                str13 = "insert into firoz_center.tbl_parts_info (`partsid`,`brand`,`model`,`partsNo`,`description`,`purchase_price`,`sale_price`,`date`,`wholesale_price`,`distributor_price`,`group`) values ('" + str12 + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str9 + "','" + str10 + "','" + text + "');";
                connect.Insert(str13);
            }
            this.textBoxGroup.Text = "";
            this.textBoxModel.Text = "";
            this.textBoxPartsNo.Text = "";
            this.textBoxPurchasePrice.Text = "";
            this.textBoxSalesPrice.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxWholeSAle.Text = "";
            this.textBoxDealer.Text = "";
            this.textBoxD.Text = "";
            this.textBoxR.Text = "";
            this.textBoxW.Text = "";
            MessageBox.Show("Data Inserted");
        }

        private void textBoxDealer_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxDealer.Text.Equals("") && !this.textBoxPurchasePrice.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPurchasePrice.Text);
                double num2 = double.Parse(this.textBoxDealer.Text);
                this.textBoxD.Text = (num * ((num2 + 100.0) / 100.0)).ToString();
            }
        }

        private void textBoxSalesPrice_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxSalesPrice.Text.Equals("") && !this.textBoxPurchasePrice.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPurchasePrice.Text);
                double num2 = double.Parse(this.textBoxSalesPrice.Text);
                this.textBoxR.Text = (num * ((num2 + 100.0) / 100.0)).ToString();
            }
        }

        private void textBoxWholeSAle_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxWholeSAle.Text.Equals("") && !this.textBoxPurchasePrice.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxPurchasePrice.Text);
                double num2 = double.Parse(this.textBoxWholeSAle.Text);
                this.textBoxW.Text = (num * ((num2 + 100.0) / 100.0)).ToString();
            }
        }
    }
}

