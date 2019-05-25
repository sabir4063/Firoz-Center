namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class AddNewVehicle : Form
    {
        private Button buttonAddNewProduct;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxBrand;
        private TextBox textBoxCC;
        private TextBox textBoxColor;
        private TextBox textBoxModel;
        private TextBox textBoxPurchaseRate;
        private TextBox textBoxSalesRate;

        public AddNewVehicle()
        {
            this.InitializeComponent();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            string text = this.textBoxBrand.Text;
            string str2 = this.textBoxModel.Text;
            string str3 = this.textBoxCC.Text;
            string str4 = this.textBoxColor.Text;
            string str5 = this.textBoxPurchaseRate.Text;
            string str6 = this.textBoxSalesRate.Text;
            string str7 = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "insert into firoz_center.tbl_vehicle_info (`brand`,`model`,`cc`,`color`,`purchase_price`,`sale_price`,`date`,`user_id`) values ('" + text + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "','1');";
            new DBConnect().Insert(query);
            this.resetAll();
            MessageBox.Show("Data Inserted");
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
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.buttonAddNewProduct = new Button();
            this.label8 = new Label();
            this.textBoxBrand = new TextBox();
            this.textBoxModel = new TextBox();
            this.textBoxCC = new TextBox();
            this.textBoxColor = new TextBox();
            this.textBoxSalesRate = new TextBox();
            this.textBoxPurchaseRate = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.groupBox1 = new GroupBox();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(10, 0x5c);
            this.label5.Margin = new Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(40, 0x10);
            this.label5.TabIndex = 0x13;
            this.label5.Text = "Color";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x44);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x1a, 0x10);
            this.label6.TabIndex = 0x12;
            this.label6.Text = "CC";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x2c);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 0x11;
            this.label7.Text = "Model";
            this.buttonAddNewProduct.BackColor = Color.MediumSeaGreen;
            this.buttonAddNewProduct.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonAddNewProduct.Location = new Point(0x9e, 0x9e);
            this.buttonAddNewProduct.Margin = new Padding(4);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new Size(120, 30);
            this.buttonAddNewProduct.TabIndex = 0x10;
            this.buttonAddNewProduct.Text = "Add New";
            this.buttonAddNewProduct.UseVisualStyleBackColor = false;
            this.buttonAddNewProduct.Click += new EventHandler(this.buttonAddNewProduct_Click);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 20);
            this.label8.Margin = new Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2c, 0x10);
            this.label8.TabIndex = 15;
            this.label8.Text = "Brand";
            this.textBoxBrand.BackColor = SystemColors.HighlightText;
            this.textBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBrand.Location = new Point(0x75, 14);
            this.textBoxBrand.Margin = new Padding(4);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new Size(300, 0x16);
            this.textBoxBrand.TabIndex = 0x1d;
            this.textBoxModel.BackColor = SystemColors.HighlightText;
            this.textBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxModel.Location = new Point(0x75, 0x26);
            this.textBoxModel.Margin = new Padding(4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new Size(300, 0x16);
            this.textBoxModel.TabIndex = 30;
            this.textBoxCC.BackColor = SystemColors.HighlightText;
            this.textBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCC.Location = new Point(0x75, 0x3e);
            this.textBoxCC.Margin = new Padding(4);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new Size(300, 0x16);
            this.textBoxCC.TabIndex = 0x1f;
            this.textBoxColor.BackColor = SystemColors.HighlightText;
            this.textBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxColor.Location = new Point(0x75, 0x56);
            this.textBoxColor.Margin = new Padding(4);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new Size(300, 0x16);
            this.textBoxColor.TabIndex = 0x20;
            this.textBoxSalesRate.BackColor = SystemColors.HighlightText;
            this.textBoxSalesRate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSalesRate.Location = new Point(0x75, 0x86);
            this.textBoxSalesRate.Margin = new Padding(4);
            this.textBoxSalesRate.Name = "textBoxSalesRate";
            this.textBoxSalesRate.Size = new Size(300, 0x16);
            this.textBoxSalesRate.TabIndex = 0x24;
            this.textBoxPurchaseRate.BackColor = SystemColors.HighlightText;
            this.textBoxPurchaseRate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPurchaseRate.Location = new Point(0x75, 110);
            this.textBoxPurchaseRate.Margin = new Padding(4);
            this.textBoxPurchaseRate.Name = "textBoxPurchaseRate";
            this.textBoxPurchaseRate.Size = new Size(300, 0x16);
            this.textBoxPurchaseRate.TabIndex = 0x23;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 140);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4b, 0x10);
            this.label1.TabIndex = 0x22;
            this.label1.Text = "Sales Rate";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x74);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x61, 0x10);
            this.label2.TabIndex = 0x21;
            this.label2.Text = "Purchase Rate";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxBrand);
            this.groupBox1.Controls.Add(this.textBoxSalesRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxPurchaseRate);
            this.groupBox1.Controls.Add(this.buttonAddNewProduct);
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
            this.groupBox1.Margin = new Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(4);
            this.groupBox1.Size = new Size(0x1a7, 0xc1);
            this.groupBox1.TabIndex = 0x25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Motor Cycle";
            base.AutoScaleDimensions = new SizeF(9f, 16f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1b0, 0xc9);
            base.Controls.Add(this.groupBox1);
            this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(4);
            base.Name = "AddNewVehicle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "New Motor Cycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void resetAll()
        {
            this.textBoxBrand.Text = "";
            this.textBoxModel.Text = "";
            this.textBoxColor.Text = "";
            this.textBoxCC.Text = "";
            this.textBoxPurchaseRate.Text = "";
            this.textBoxSalesRate.Text = "";
        }
    }
}

