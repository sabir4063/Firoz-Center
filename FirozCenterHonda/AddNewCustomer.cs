namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AddNewCustomer : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxEmail;
        private TextBox textBoxName;

        public AddNewCustomer()
        {
            this.InitializeComponent();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            DBConnect connect = new DBConnect();
            string text = this.textBoxName.Text;
            string str2 = this.textBox1.Text;
            string str3 = this.textBoxAddress.Text;
            string str4 = this.textBoxContact.Text;
            string str5 = this.textBoxEmail.Text;
            string query = "insert into firoz_center.tbl_customer (`name`,`fathers_name`,`address`,`contact`,`email`,`comments`) values ('" + text + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','');";
            connect.Insert(query);
            base.Dispose();
            MessageBox.Show("Data Inserted");
            new NewSalesMotorCycle().Show();
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
            this.textBox1 = new TextBox();
            this.label5 = new Label();
            this.buttonSave = new Button();
            this.textBoxEmail = new TextBox();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1ab, 0xf5);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Customer";
            this.textBox1.BackColor = SystemColors.HighlightText;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = SystemColors.Desktop;
            this.textBox1.Location = new Point(0x77, 0x2c);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x126, 0x16);
            this.textBox1.TabIndex = 0x22;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = SystemColors.Desktop;
            this.label5.Location = new Point(6, 0x2c);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x60, 0x10);
            this.label5.TabIndex = 0x27;
            this.label5.Text = "Father's Name";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.ForeColor = SystemColors.Desktop;
            this.buttonSave.Location = new Point(0xae, 0xd0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x1c);
            this.buttonSave.TabIndex = 0x26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click_1);
            this.textBoxEmail.BackColor = SystemColors.HighlightText;
            this.textBoxEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEmail.ForeColor = SystemColors.Desktop;
            this.textBoxEmail.Location = new Point(0x77, 180);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(0x126, 0x16);
            this.textBoxEmail.TabIndex = 0x25;
            this.textBoxContact.BackColor = SystemColors.HighlightText;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.ForeColor = SystemColors.Desktop;
            this.textBoxContact.Location = new Point(0x77, 0x9b);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x126, 0x16);
            this.textBoxContact.TabIndex = 0x24;
            this.textBoxAddress.BackColor = SystemColors.HighlightText;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.ForeColor = SystemColors.Desktop;
            this.textBoxAddress.Location = new Point(0x77, 70);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x126, 0x51);
            this.textBoxAddress.TabIndex = 0x23;
            this.textBoxName.BackColor = SystemColors.HighlightText;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = SystemColors.Desktop;
            this.textBoxName.Location = new Point(0x77, 0x12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x126, 0x16);
            this.textBoxName.TabIndex = 0x21;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = SystemColors.Desktop;
            this.label4.Location = new Point(5, 180);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x2a, 0x10);
            this.label4.TabIndex = 0x20;
            this.label4.Text = "Email";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = SystemColors.Desktop;
            this.label3.Location = new Point(5, 0x9b);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 0x1f;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = SystemColors.Desktop;
            this.label2.Location = new Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 30;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = SystemColors.Desktop;
            this.label1.Location = new Point(6, 0x12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x1d;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1b5, 0xfd);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "AddNewCustomer";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "AddNewCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

