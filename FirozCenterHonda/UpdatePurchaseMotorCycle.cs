namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class UpdatePurchaseMotorCycle : Form
    {
        private Button buttondelete;
        private Button buttonUpdate;
        private string chassis = "";
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private string engine = "";
        private GroupBox groupBox1;
        private string invoice;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private string purchase_rate;
        private TextBox textBoxBrand;
        private TextBox textBoxCC;
        private TextBox textBoxChassis;
        private TextBox textBoxColor;
        private TextBox textBoxEngine;
        private TextBox textBoxModel;
        private string total;
        private string vehicleId = "";

        public UpdatePurchaseMotorCycle(string vehicleId, string engine, string chassis, string invoice, string total, string purchase_rate)
        {
            this.InitializeComponent();
            this.textBoxChassis.Text = chassis;
            this.textBoxEngine.Text = engine;
            this.vehicleId = vehicleId;
            this.engine = engine;
            this.chassis = chassis;
            this.invoice = invoice;
            this.total = total;
            this.purchase_rate = purchase_rate;
            string query = "select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + vehicleId + "'";
            List<string>[] listArray = new List<string>[4];
            for (int i = 0; i < 4; i++)
            {
                listArray[i] = new List<string>();
            }
            listArray = this.dbc.Select(4L, query);
            this.textBoxBrand.Text = listArray[0].ElementAt<string>(0);
            this.textBoxModel.Text = listArray[1].ElementAt<string>(0);
            this.textBoxCC.Text = listArray[2].ElementAt<string>(0);
            this.textBoxColor.Text = listArray[3].ElementAt<string>(0);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from firoz_center.tbl_vehicle where vehicleid = '" + this.vehicleId + "' and engine_no='" + this.engine + "' and chasis_no='" + this.chassis + "';";
            this.dbc.Delete(query);
            long num = long.Parse(this.total) - long.Parse(this.purchase_rate);
            query = string.Concat(new object[] { "update firoz_center.tbl_purchase set grand_total='", num, "', net_amount='", num, "' where invoice_no='", this.invoice, "';" });
            this.dbc.Update(query);
            query = string.Concat(new object[] { "update firoz_center.tbl_transcation set credit='", num, "' where invoice_no='", this.invoice, "';" });
            this.dbc.Update(query);
            MessageBox.Show("Delete Completed");
            EditPurchaseMotorCycle cycle = new EditPurchaseMotorCycle(this.invoice);
            cycle.Show();
            cycle.do_it();
            base.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "update firoz_center.tbl_vehicle set engine_no='" + this.textBoxEngine.Text + "', chasis_no='" + this.textBoxChassis.Text + "' where vehicleId='" + this.vehicleId + "' and invoice_no='" + this.invoice + "' and engine_no='" + this.engine + "' and chasis_no='" + this.chassis + "';";
            this.dbc.Update(query);
            MessageBox.Show("Update Completed");
            EditPurchaseMotorCycle cycle = new EditPurchaseMotorCycle(this.invoice);
            cycle.Show();
            cycle.do_it();
            base.Close();
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
            this.buttondelete = new Button();
            this.label1 = new Label();
            this.label7 = new Label();
            this.label2 = new Label();
            this.label6 = new Label();
            this.textBoxColor = new TextBox();
            this.label5 = new Label();
            this.textBoxCC = new TextBox();
            this.textBoxModel = new TextBox();
            this.groupBox1 = new GroupBox();
            this.buttonUpdate = new Button();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.textBoxBrand.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBrand.Location = new Point(0x77, 0x13);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.ReadOnly = true;
            this.textBoxBrand.Size = new Size(0xda, 0x16);
            this.textBoxBrand.TabIndex = 0x1d;
            this.textBoxChassis.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxChassis.Location = new Point(0x77, 140);
            this.textBoxChassis.Name = "textBoxChassis";
            this.textBoxChassis.Size = new Size(0xda, 0x16);
            this.textBoxChassis.TabIndex = 0x24;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(14, 0x13);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x2c, 0x10);
            this.label8.TabIndex = 15;
            this.label8.Text = "Brand";
            this.textBoxEngine.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEngine.Location = new Point(0x77, 0x74);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new Size(0xda, 0x16);
            this.textBoxEngine.TabIndex = 0x23;
            this.buttondelete.BackColor = Color.MediumSeaGreen;
            this.buttondelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttondelete.Location = new Point(0x3b, 0xa8);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new Size(120, 30);
            this.buttondelete.TabIndex = 0x10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new EventHandler(this.buttondelete_Click);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(14, 140);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4d, 0x10);
            this.label1.TabIndex = 0x22;
            this.label1.Text = "Chassis No";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(14, 0x2b);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x2e, 0x10);
            this.label7.TabIndex = 0x11;
            this.label7.Text = "Model";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(14, 0x74);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x47, 0x10);
            this.label2.TabIndex = 0x21;
            this.label2.Text = "Engine No";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(14, 0x44);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x1a, 0x10);
            this.label6.TabIndex = 0x12;
            this.label6.Text = "CC";
            this.textBoxColor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxColor.Location = new Point(0x77, 0x5c);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new Size(0xda, 0x16);
            this.textBoxColor.TabIndex = 0x20;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(14, 0x5c);
            this.label5.Name = "label5";
            this.label5.Size = new Size(40, 0x10);
            this.label5.TabIndex = 0x13;
            this.label5.Text = "Color";
            this.textBoxCC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCC.Location = new Point(0x77, 0x44);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ReadOnly = true;
            this.textBoxCC.Size = new Size(0xda, 0x16);
            this.textBoxCC.TabIndex = 0x1f;
            this.textBoxModel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxModel.Location = new Point(0x77, 0x2b);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new Size(0xda, 0x16);
            this.textBoxModel.TabIndex = 30;
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxBrand);
            this.groupBox1.Controls.Add(this.textBoxChassis);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxEngine);
            this.groupBox1.Controls.Add(this.buttondelete);
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
            this.groupBox1.Size = new Size(0x15f, 0xca);
            this.groupBox1.TabIndex = 0x26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update / Delete";
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0xb6, 0xa8);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(120, 30);
            this.buttonUpdate.TabIndex = 0x25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x16a, 0xd6);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "UpdatePurchaseMotorCycle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Purchase Motor Cycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

