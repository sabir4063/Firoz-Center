namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class UpdatePurchaseParts : Form
    {
        private Button buttondelete;
        private Button buttonUpdate;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private string description = "";
        private string group = "";
        private GroupBox groupBox1;
        private string invoice_no = "";
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private string partsId = "";
        private string partsNo = "";
        private string price = "";
        private string quantity = "";
        private TextBox textBoxDescription;
        private TextBox textBoxGroup;
        private TextBox textBoxPartsNo;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;

        public UpdatePurchaseParts(string partsNo, string description, string quantity, string invoice_no, string price, string group)
        {
            this.InitializeComponent();
            this.group = group;
            this.invoice_no = invoice_no;
            this.partsNo = partsNo;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
            string query = "Select partsId,brand,model from firoz_center.tbl_parts_info where `group`='" + group + "' and partsNo='" + partsNo + "' and description='" + description + "';";
            List<string>[] listArray = new List<string>[3];
            for (int i = 0; i < 3; i++)
            {
                listArray[i] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            this.partsId = listArray[0].ElementAt<string>(0);
            this.textBoxGroup.Text = group;
            this.textBoxPartsNo.Text = partsNo;
            this.textBoxDescription.Text = description;
            this.textBoxQuantity.Text = quantity;
            this.textBoxPrice.Text = price;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all parts?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "Delete from firoz_center.tbl_parts where `group`='" + this.group + "' and partsId='" + this.partsId + "' and invoice_no='" + this.invoice_no + "' and status='stock';";
                this.dbc.Delete(query);
                new EditPurchaseParts(this.invoice_no).Show();
                base.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                string str;
                long num = long.Parse(this.quantity);
                long num3 = long.Parse(this.textBoxQuantity.Text) - num;
                if (num3 == 0L)
                {
                    str = "";
                }
                else
                {
                    int num4;
                    if (num3 < 0L)
                    {
                        for (num4 = 0; num4 < Math.Abs(num3); num4++)
                        {
                            str = "Delete from firoz_center.tbl_parts where `group`='" + this.group + "' and partsId='" + this.partsId + "' and invoice_no='" + this.invoice_no + "' and status='stock' limit 1;";
                            this.dbc.Delete(str);
                        }
                    }
                    else
                    {
                        for (num4 = 0; num4 < num3; num4++)
                        {
                            str = "insert into firoz_center.tbl_parts (`invoice_no`,`partsid`,`purchase_rate`,`status`,`group`) values ('" + this.invoice_no + "','" + this.partsId + "','" + this.price + "','stock','" + this.group + "');";
                            this.dbc.Insert(str);
                        }
                    }
                }
                new EditPurchaseParts(this.invoice_no).Show();
                base.Close();
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
            this.textBoxQuantity = new TextBox();
            this.buttondelete = new Button();
            this.label2 = new Label();
            this.label6 = new Label();
            this.textBoxDescription = new TextBox();
            this.label5 = new Label();
            this.textBoxPartsNo = new TextBox();
            this.groupBox1 = new GroupBox();
            this.textBoxPrice = new TextBox();
            this.label1 = new Label();
            this.buttonUpdate = new Button();
            this.label3 = new Label();
            this.textBoxGroup = new TextBox();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.textBoxQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxQuantity.Location = new Point(0x60, 0x8f);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new Size(0x102, 0x16);
            this.textBoxQuantity.TabIndex = 0x23;
            this.buttondelete.BackColor = Color.MediumSeaGreen;
            this.buttondelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttondelete.Location = new Point(0x60, 0xc3);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new Size(100, 30);
            this.buttondelete.TabIndex = 0x10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new EventHandler(this.buttondelete_Click);
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(13, 0x8f);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x38, 0x10);
            this.label2.TabIndex = 0x21;
            this.label2.Text = "Quantity";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(13, 0x2e);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 0x10);
            this.label6.TabIndex = 0x12;
            this.label6.Text = "Parts No";
            this.textBoxDescription.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDescription.Location = new Point(0x60, 70);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new Size(0x102, 0x47);
            this.textBoxDescription.TabIndex = 0x20;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x4c, 0x10);
            this.label5.TabIndex = 0x13;
            this.label5.Text = "Description";
            this.textBoxPartsNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPartsNo.Location = new Point(0x60, 0x2e);
            this.textBoxPartsNo.Name = "textBoxPartsNo";
            this.textBoxPartsNo.ReadOnly = true;
            this.textBoxPartsNo.Size = new Size(0x102, 0x16);
            this.textBoxPartsNo.TabIndex = 0x1f;
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGroup);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.buttondelete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPartsNo);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x16a, 0xeb);
            this.groupBox1.TabIndex = 0x27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update / Delete";
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(0x60, 0xa7);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new Size(0x102, 0x16);
            this.textBoxPrice.TabIndex = 0x27;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(13, 0xa7);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x27, 0x10);
            this.label1.TabIndex = 0x26;
            this.label1.Text = "Price";
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0xfe, 0xc3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(100, 30);
            this.buttonUpdate.TabIndex = 0x25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(14, 0x15);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2d, 0x10);
            this.label3.TabIndex = 40;
            this.label3.Text = "Group";
            this.textBoxGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxGroup.Location = new Point(0x60, 0x16);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new Size(0x103, 0x16);
            this.textBoxGroup.TabIndex = 0x29;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x173, 0xf4);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "UpdatePurchaseParts";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UpdatePurchaseParts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

