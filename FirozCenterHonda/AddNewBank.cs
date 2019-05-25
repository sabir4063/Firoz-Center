namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class AddNewBank : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect("");
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private string t_id = "";
        private TextBox textBoxAC;
        private TextBox textBoxAddress;
        private TextBox textBoxBalance;
        private TextBox textBoxContact;
        private TextBox textBoxName;

        public AddNewBank()
        {
            this.InitializeComponent();
            string query = "SELECT max(bank_transcation_id) FROM firoz_center.tbl_bank_transcation t;";
            if (this.dbc.Count(query) == -1L)
            {
                this.t_id = "400001";
            }
            else
            {
                string str2 = "SELECT max(bank_transcation_id) FROM firoz_center.tbl_bank_transcation t;";
                this.t_id = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new bank?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (((this.textBoxName.Text.Equals("") || this.textBoxAddress.Text.Equals("")) || this.textBoxAC.Text.Equals("")) || this.textBoxBalance.Text.Equals(""))
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
            this.groupBox1 = new GroupBox();
            this.textBoxBalance = new TextBox();
            this.label5 = new Label();
            this.buttonSave = new Button();
            this.textBoxContact = new TextBox();
            this.textBoxAC = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAC);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x197, 0xfb);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Bank Information";
            this.textBoxBalance.BackColor = Color.SeaShell;
            this.textBoxBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBalance.ForeColor = SystemColors.Desktop;
            this.textBoxBalance.Location = new Point(0x61, 0xb9);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new Size(300, 0x16);
            this.textBoxBalance.TabIndex = 0x33;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.Black;
            this.label5.Location = new Point(10, 0xb9);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x3a, 0x10);
            this.label5.TabIndex = 50;
            this.label5.Text = "Balance";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.ForeColor = Color.Black;
            this.buttonSave.Location = new Point(0x8f, 0xd4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x31;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click_1);
            this.textBoxContact.BackColor = Color.SeaShell;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.ForeColor = SystemColors.Desktop;
            this.textBoxContact.Location = new Point(0x61, 0xa1);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(300, 0x16);
            this.textBoxContact.TabIndex = 0x30;
            this.textBoxAC.BackColor = Color.SeaShell;
            this.textBoxAC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAC.ForeColor = SystemColors.Desktop;
            this.textBoxAC.Location = new Point(0x61, 0x89);
            this.textBoxAC.Name = "textBoxAC";
            this.textBoxAC.Size = new Size(300, 0x16);
            this.textBoxAC.TabIndex = 0x2f;
            this.textBoxAddress.BackColor = Color.SeaShell;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.ForeColor = SystemColors.Desktop;
            this.textBoxAddress.Location = new Point(0x61, 0x2c);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(300, 0x5b);
            this.textBoxAddress.TabIndex = 0x2e;
            this.textBoxName.BackColor = Color.SeaShell;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = SystemColors.Desktop;
            this.textBoxName.Location = new Point(0x61, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(300, 0x16);
            this.textBoxName.TabIndex = 0x2d;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(10, 0xa1);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x35, 0x10);
            this.label4.TabIndex = 0x2c;
            this.label4.Text = "Contact";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(10, 0x89);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2f, 0x10);
            this.label3.TabIndex = 0x2b;
            this.label3.Text = "AC No";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(10, 0x2c);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 0x2a;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x29;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1a0, 260);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "AddNewBank";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "AddNewBank";
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
            string str4 = this.textBoxAC.Text;
            string str5 = this.textBoxBalance.Text;
            string str6 = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "insert into firoz_center.tbl_bank_info (`name`,`description`,`address`,`branch`,`contact`,`ac_no`,`balance`) values ('" + text + "','','" + str2 + "','','" + str3 + "','" + str4 + "','" + str5 + "');";
            connect.Insert(query);
            string str8 = connect.SelectSingle("Select bank_id from firoz_center.tbl_bank_info where name='" + text + "' and ac_no='" + str4 + "';");
            query = "insert into firoz_center.tbl_bank_transcation (`bank_transcation_id`,`bank_id`,`date`,`amount`,`description`) values ('" + this.t_id + "','" + str8 + "','" + str6 + "','" + str5 + "','Initial Deposite');";
            connect.Insert(query);
            base.Dispose();
            MessageBox.Show("Data Inserted");
        }
    }
}

