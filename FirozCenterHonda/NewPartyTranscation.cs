namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class NewPartyTranscation : Form
    {
        private List<string>[] ACNo = new List<string>[2];
        private List<string>[] Bank = new List<string>[2];
        private Button buttonSave;
        public ComboBox comboBoxACNo;
        public ComboBox comboBoxBank;
        public ComboBox comboBoxParty;
        private IContainer components = null;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private List<string>[] Party = new List<string>[2];
        private TextBox textBoxAddress;
        private TextBox textBoxAmount;
        private TextBox textBoxAvailable;
        private TextBox textBoxBalance;
        private TextBox textBoxC;
        private TextBox textBoxTID;

        public NewPartyTranscation()
        {
            this.InitializeComponent();
            this.load_TID();
            this.load_bank();
            this.load_party();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new transcation?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxACNo.Items.Clear();
            this.textBoxBalance.Text = "";
            this.textBoxAvailable.Text = "";
            this.load_acno();
        }

        private void comboBoxACNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_balance();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            this.textBoxTID = new TextBox();
            this.label6 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.label5 = new Label();
            this.buttonSave = new Button();
            this.textBoxAmount = new TextBox();
            this.label4 = new Label();
            this.textBoxC = new TextBox();
            this.textBoxAddress = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.comboBoxParty = new ComboBox();
            this.groupBox2 = new GroupBox();
            this.textBoxAvailable = new TextBox();
            this.label7 = new Label();
            this.comboBoxACNo = new ComboBox();
            this.textBoxBalance = new TextBox();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label11 = new Label();
            this.comboBoxBank = new ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxTID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxParty);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 0x8a);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x194, 0x10f);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Transcation Info.";
            this.textBoxTID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTID.Location = new Point(0x5b, 0x11);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.ReadOnly = true;
            this.textBoxTID.Size = new Size(0x94, 0x16);
            this.textBoxTID.TabIndex = 0x38;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x21, 0x10);
            this.label6.TabIndex = 0x37;
            this.label6.Text = "T ID";
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0x120, 0x11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x67, 0x16);
            this.dateTimePicker2.TabIndex = 0x34;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xf5, 0x15);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x25, 0x10);
            this.label5.TabIndex = 0x33;
            this.label5.Text = "Date";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x93, 0xe9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 50;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAmount.Location = new Point(0x5b, 0xcd);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new Size(300, 0x16);
            this.textBoxAmount.TabIndex = 0x31;
            this.textBoxAmount.Text = "0";
            this.textBoxAmount.TextAlign = HorizontalAlignment.Right;
            this.textBoxAmount.TextChanged += new EventHandler(this.textBoxAmount_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0xcd);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x35, 0x10);
            this.label4.TabIndex = 0x30;
            this.label4.Text = "Amount";
            this.textBoxC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxC.Location = new Point(0x5b, 0xb5);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new Size(300, 0x16);
            this.textBoxC.TabIndex = 0x2f;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x5b, 0x41);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(300, 0x72);
            this.textBoxAddress.TabIndex = 0x2e;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0xb5);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 0x2b;
            this.label3.Text = "Method";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x4c, 0x10);
            this.label2.TabIndex = 0x2a;
            this.label2.Text = "Description";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x29;
            this.label1.Text = "Name";
            this.comboBoxParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = SystemColors.ControlLight;
            this.comboBoxParty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new Point(0x5b, 40);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new Size(300, 0x18);
            this.comboBoxParty.TabIndex = 7;
            this.comboBoxParty.SelectedIndexChanged += new EventHandler(this.comboBoxParty_SelectedIndexChanged);
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxAvailable);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxACNo);
            this.groupBox2.Controls.Add(this.textBoxBalance);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBoxBank);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x194, 0x7f);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank Info.";
            this.textBoxAvailable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAvailable.Location = new Point(0x5b, 0x60);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.Size = new Size(300, 0x16);
            this.textBoxAvailable.TabIndex = 0x37;
            this.textBoxAvailable.Text = "0";
            this.textBoxAvailable.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x60);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x3a, 0x10);
            this.label7.TabIndex = 0x36;
            this.label7.Text = "Aailable";
            this.comboBoxACNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxACNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxACNo.BackColor = SystemColors.ControlLight;
            this.comboBoxACNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxACNo.FormattingEnabled = true;
            this.comboBoxACNo.Location = new Point(0x5b, 0x2e);
            this.comboBoxACNo.Name = "comboBoxACNo";
            this.comboBoxACNo.Size = new Size(300, 0x18);
            this.comboBoxACNo.TabIndex = 0x35;
            this.comboBoxACNo.SelectedIndexChanged += new EventHandler(this.comboBoxACNo_SelectedIndexChanged);
            this.textBoxBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBalance.Location = new Point(0x5b, 0x48);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new Size(300, 0x16);
            this.textBoxBalance.TabIndex = 0x31;
            this.textBoxBalance.Text = "0";
            this.textBoxBalance.TextAlign = HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x48);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x3a, 0x10);
            this.label9.TabIndex = 0x30;
            this.label9.Text = "Balance";
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(10, 0x2e);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x2f, 0x10);
            this.label10.TabIndex = 0x2b;
            this.label10.Text = "AC No";
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x2d, 0x10);
            this.label11.TabIndex = 0x29;
            this.label11.Text = "Name";
            this.comboBoxBank.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBank.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBank.BackColor = SystemColors.ControlLight;
            this.comboBoxBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new Point(0x5b, 20);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new Size(300, 0x18);
            this.comboBoxBank.TabIndex = 7;
            this.comboBoxBank.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19d, 0x19e);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "NewPartyTranscation";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "New Party Transcation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_acno()
        {
            int num;
            string query = "SELECT bank_id,ac_no FROM firoz_center.tbl_bank_info where name='" + this.comboBoxBank.SelectedItem.ToString() + "';";
            for (num = 0; num < 2; num++)
            {
                this.ACNo[num] = new List<string>();
            }
            this.ACNo = this.dbc.Select(2L, query);
            for (num = 0; num < this.ACNo[0].Count; num++)
            {
                this.comboBoxACNo.Items.Add(this.ACNo[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_balance()
        {
            string query = "SELECT balance FROM firoz_center.tbl_bank_info where name='" + this.comboBoxBank.SelectedItem.ToString() + "' and ac_no='" + this.comboBoxACNo.SelectedItem.ToString() + "';";
            this.textBoxBalance.Text = this.dbc.SelectSingle(query);
        }

        private void load_bank()
        {
            int num;
            string query = "SELECT name,bank_id FROM firoz_center.tbl_bank_info t group by name;";
            for (num = 0; num < 2; num++)
            {
                this.Bank[num] = new List<string>();
            }
            this.Bank = this.dbc.Select(2L, query);
            for (num = 0; num < this.Bank[0].Count; num++)
            {
                this.comboBoxBank.Items.Add(this.Bank[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_party()
        {
            int num;
            string query = "SELECT customer_id,name FROM firoz_center.tbl_party;";
            for (num = 0; num < 2; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(2L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_TID()
        {
            string query = "SELECT max(bank_transcation_id) FROM firoz_center.tbl_bank_transcation t;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxTID.Text = "400001";
            }
            else
            {
                string str2 = "SELECT max(bank_transcation_id) FROM firoz_center.tbl_bank_transcation t;";
                this.textBoxTID.Text = (long.Parse(this.dbc.SelectSingle(str2)) + 1L).ToString();
            }
        }

        private void save_transcation()
        {
            string text = this.textBoxTID.Text;
            string str2 = this.Party[0].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            string str3 = this.Party[1].ElementAt<string>(this.comboBoxParty.SelectedIndex);
            string str4 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str5 = this.textBoxAmount.Text;
            string str6 = this.textBoxAddress.Text;
            string str7 = this.Bank[1].ElementAt<string>(this.comboBoxBank.SelectedIndex);
            if (double.Parse(this.textBoxAvailable.Text) < 0.0)
            {
                MessageBox.Show("Check Amount");
            }
            else if (str6.Equals("") || str5.Equals(""))
            {
                MessageBox.Show("Check Amount & Description");
            }
            else
            {
                string query = "insert into firoz_center.tbl_party_transcation (`party_id`,`date`,`amount`,`description`,`type`,`details`,`invoice_no`) values ('" + str2 + "','" + str4 + "','" + str5 + "','" + str6 + "','Credit','Deposite','" + this.textBoxTID.Text + "');";
                this.dbc.Insert(query);
                query = "insert into firoz_center.tbl_bank_transcation (`bank_transcation_id`,`bank_id`,`date`,`amount`,`description`) values ('" + text + "','" + str7 + "','" + str4 + "','-" + str5 + "','Withdraw');";
                this.dbc.Insert(query);
                query = "UPDATE firoz_center.tbl_bank_info set balance='" + this.textBoxAvailable.Text + "' where bank_id = '" + str7 + "';";
                this.dbc.Update(query);
                MessageBox.Show("Data Inserted");
                base.Dispose();
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxAmount.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxBalance.Text);
                double num2 = double.Parse(this.textBoxAmount.Text);
                this.textBoxAvailable.Text = (num - num2).ToString();
            }
        }
    }
}

