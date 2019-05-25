namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AddNewParty : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxEmail;
        private TextBox textBoxName;

        public AddNewParty()
        {
            this.InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new Party?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.textBoxName.Text.Equals("") || this.textBoxAddress.Text.Equals(""))
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
            this.buttonSave = new Button();
            this.groupBox1 = new GroupBox();
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
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x98, 0xb1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x199, 0xd4);
            this.groupBox1.TabIndex = 0x13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Party Information";
            this.textBoxEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxEmail.Location = new Point(0x4b, 0x98);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(0x146, 0x16);
            this.textBoxEmail.TabIndex = 0x1a;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.Location = new Point(0x4b, 0x80);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x146, 0x16);
            this.textBoxContact.TabIndex = 0x19;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x4b, 0x2d);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x146, 0x51);
            this.textBoxAddress.TabIndex = 0x18;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x4b, 0x15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x146, 0x16);
            this.textBoxName.TabIndex = 0x17;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0x98);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x2a, 0x10);
            this.label4.TabIndex = 0x16;
            this.label4.Text = "Email";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x80);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 0x15;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x2d);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 20;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x13;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(420, 0xe0);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "AddNewParty";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "AddNewParty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string text = this.textBoxName.Text;
            string str2 = this.textBoxAddress.Text;
            string str3 = this.textBoxContact.Text;
            string str4 = this.textBoxEmail.Text;
            string query = "insert into firoz_center.tbl_party (`name`,`address`,`contact`,`e-mail`,`comments`) values ('" + text + "','" + str2 + "','" + str3 + "','" + str4 + "','');";
            connect.Insert(query);
            base.Dispose();
            MessageBox.Show("Data Inserted");
        }
    }
}

