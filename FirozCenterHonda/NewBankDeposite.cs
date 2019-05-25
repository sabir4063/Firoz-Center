namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class NewBankDeposite : Form
    {
        private List<string>[] ACNo = new List<string>[2];
        private List<string>[] Bank = new List<string>[1];
        private Button button1;
        public ComboBox comboBoxACNo;
        public ComboBox comboBoxBank;
        private IContainer components = null;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxAmount;
        private TextBox textBoxBalance;
        private TextBox textBoxDescription;
        private TextBox textBoxNetBalance;
        private TextBox textBoxTID;

        public NewBankDeposite()
        {
            this.InitializeComponent();
            this.load_TID();
            this.load_bank();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new deposite?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
        }

        private void comboBoxACNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxAmount.Text = "";
            this.textBoxNetBalance.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxBalance.Text = "";
            this.load_balance();
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxACNo.Items.Clear();
            this.textBoxAmount.Text = "";
            this.textBoxNetBalance.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxBalance.Text = "";
            this.load_acno();
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
            this.textBoxNetBalance = new TextBox();
            this.label8 = new Label();
            this.textBoxBalance = new TextBox();
            this.label7 = new Label();
            this.textBoxTID = new TextBox();
            this.label6 = new Label();
            this.dateTimePicker2 = new DateTimePicker();
            this.label5 = new Label();
            this.comboBoxACNo = new ComboBox();
            this.button1 = new Button();
            this.textBoxAmount = new TextBox();
            this.label4 = new Label();
            this.textBoxDescription = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.comboBoxBank = new ComboBox();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxNetBalance);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxTID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxACNo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBank);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x191, 0x138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Deposite";
            this.textBoxNetBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetBalance.Location = new Point(0x58, 0xf7);
            this.textBoxNetBalance.Name = "textBoxNetBalance";
            this.textBoxNetBalance.Size = new Size(0x12d, 0x16);
            this.textBoxNetBalance.TabIndex = 0x4c;
            this.textBoxNetBalance.Text = "0";
            this.textBoxNetBalance.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(7, 0xf7);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x52, 0x10);
            this.label8.TabIndex = 0x4b;
            this.label8.Text = "Net Balance";
            this.textBoxBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBalance.Location = new Point(0x58, 0x61);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new Size(0x12d, 0x16);
            this.textBoxBalance.TabIndex = 0x4a;
            this.textBoxBalance.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(7, 0x61);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x3a, 0x10);
            this.label7.TabIndex = 0x49;
            this.label7.Text = "Balance";
            this.textBoxTID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTID.Location = new Point(0x58, 0x15);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.ReadOnly = true;
            this.textBoxTID.Size = new Size(150, 0x16);
            this.textBoxTID.TabIndex = 0x48;
            this.textBoxTID.TextAlign = HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(7, 0x15);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x21, 0x10);
            this.label6.TabIndex = 0x47;
            this.label6.Text = "T ID";
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0x120, 0x15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x65, 0x16);
            this.dateTimePicker2.TabIndex = 70;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xf4, 0x18);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x25, 0x10);
            this.label5.TabIndex = 0x45;
            this.label5.Text = "Date";
            this.comboBoxACNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxACNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxACNo.BackColor = SystemColors.ControlLight;
            this.comboBoxACNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxACNo.FormattingEnabled = true;
            this.comboBoxACNo.Location = new Point(0x58, 0x47);
            this.comboBoxACNo.Name = "comboBoxACNo";
            this.comboBoxACNo.Size = new Size(0x12d, 0x18);
            this.comboBoxACNo.TabIndex = 0x42;
            this.comboBoxACNo.SelectedIndexChanged += new EventHandler(this.comboBoxACNo_SelectedIndexChanged);
            this.button1.BackColor = Color.MediumSeaGreen;
            this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(0x92, 0x113);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 30);
            this.button1.TabIndex = 0x3f;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBoxAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAmount.Location = new Point(0x58, 0xdf);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new Size(0x12d, 0x16);
            this.textBoxAmount.TabIndex = 0x3e;
            this.textBoxAmount.Text = "0";
            this.textBoxAmount.TextAlign = HorizontalAlignment.Right;
            this.textBoxAmount.TextChanged += new EventHandler(this.textBoxAmount_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(7, 0xdf);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x35, 0x10);
            this.label4.TabIndex = 0x3d;
            this.label4.Text = "Amount";
            this.textBoxDescription.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDescription.Location = new Point(0x58, 0x79);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new Size(0x12d, 100);
            this.textBoxDescription.TabIndex = 60;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(7, 0x47);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2f, 0x10);
            this.label3.TabIndex = 0x3b;
            this.label3.Text = "AC No";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(7, 0x79);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x4c, 0x10);
            this.label2.TabIndex = 0x3a;
            this.label2.Text = "Description";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(7, 0x2d);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x39;
            this.label1.Text = "Name";
            this.comboBoxBank.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBank.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBank.BackColor = SystemColors.ControlLight;
            this.comboBoxBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new Point(0x58, 0x2d);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new Size(0x12d, 0x18);
            this.comboBoxBank.TabIndex = 0x38;
            this.comboBoxBank.SelectedIndexChanged += new EventHandler(this.comboBoxBank_SelectedIndexChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19b, 0x142);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "NewBankDeposite";
            this.Text = "New Bank Deposite";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            string query = "SELECT name FROM firoz_center.tbl_bank_info t group by name;";
            for (num = 0; num < 1; num++)
            {
                this.Bank[num] = new List<string>();
            }
            this.Bank = this.dbc.Select(1L, query);
            for (num = 0; num < this.Bank[0].Count; num++)
            {
                this.comboBoxBank.Items.Add(this.Bank[0].ElementAt<string>(num).ToString());
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
            string str2 = this.dbc.SelectSingle("SELECT bank_id FROM firoz_center.tbl_bank_info where name='" + this.comboBoxBank.SelectedItem.ToString() + "' and ac_no='" + this.comboBoxACNo.SelectedItem.ToString() + "';");
            string str3 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str4 = this.textBoxAmount.Text;
            string query = "insert into firoz_center.tbl_bank_transcation (`bank_transcation_id`,`bank_id`,`date`,`amount`,`description`) values ('" + text + "','" + str2 + "','" + str3 + "','" + str4 + "','Deposite');";
            this.dbc.Insert(query);
            query = "UPDATE firoz_center.tbl_bank_info set balance='" + this.textBoxNetBalance.Text + "' where bank_id = '" + str2 + "';";
            this.dbc.Update(query);
            base.Dispose();
            MessageBox.Show("Data Inserted");
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBoxAmount.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxBalance.Text);
                double num2 = double.Parse(this.textBoxAmount.Text);
                this.textBoxNetBalance.Text = (num + num2).ToString();
            }
        }
    }
}

