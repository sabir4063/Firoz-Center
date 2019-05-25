namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AddNewService : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxCharge;
        private TextBox textBoxDescription;
        private TextBox textBoxName;

        public AddNewService()
        {
            this.InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new service?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((this.textBoxCharge.Text.Equals("") || this.textBoxDescription.Text.Equals("")) || this.textBoxName.Text.Equals(""))
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.buttonSave = new Button();
            this.groupBox1 = new GroupBox();
            this.textBoxCharge = new TextBox();
            this.textBoxDescription = new TextBox();
            this.textBoxName = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x8f, 0x94);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxCharge);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x193, 0xbb);
            this.groupBox1.TabIndex = 0x29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Service";
            this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
            this.textBoxCharge.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCharge.Location = new Point(0x61, 0x7b);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new Size(0x129, 0x16);
            this.textBoxCharge.TabIndex = 0x2c;
            this.textBoxCharge.TextChanged += new EventHandler(this.textBoxCharge_TextChanged);
            this.textBoxDescription.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDescription.Location = new Point(0x61, 40);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new Size(0x129, 0x51);
            this.textBoxDescription.TabIndex = 0x2b;
            this.textBoxDescription.TextChanged += new EventHandler(this.textBoxDescription_TextChanged);
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x61, 0x10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x129, 0x16);
            this.textBoxName.TabIndex = 0x2a;
            this.textBoxName.TextChanged += new EventHandler(this.textBoxName_TextChanged);
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x7b);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x34, 0x10);
            this.label3.TabIndex = 0x29;
            this.label3.Text = "Charge";
            this.label3.Click += new EventHandler(this.label3_Click);
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x4c, 0x10);
            this.label2.TabIndex = 40;
            this.label2.Text = "Description";
            this.label2.Click += new EventHandler(this.label2_Click);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x36, 0x10);
            this.label1.TabIndex = 0x27;
            this.label1.Text = "Service";
            this.label1.Click += new EventHandler(this.label1_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19d, 0xc5);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "AddNewService";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "AddNewService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string text = this.textBoxName.Text;
            string str2 = this.textBoxDescription.Text;
            string str3 = this.textBoxCharge.Text;
            string query = "insert into firoz_center.tbl_service_charge (`name`,`description`,`charge`) values ('" + text + "','" + str2 + "','" + str3 + "');";
            connect.Insert(query);
            this.textBoxName.Text = "";
            this.textBoxCharge.Text = "";
            this.textBoxDescription.Text = "";
            MessageBox.Show("Data Inserted");
        }

        private void textBoxCharge_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

