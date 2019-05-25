namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EditPartyTranscation : Form
    {
        private Button buttonDelete;
        private IContainer components;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private List<string>[] PT;
        private TextBox textBoxAC;
        private TextBox textBoxAmount;
        private TextBox textBoxBank;
        private TextBox textBoxDescription;
        private TextBox textBoxID;
        private TextBox textBoxName;

        public EditPartyTranscation()
        {
            this.PT = new List<string>[8];
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
        }

        public EditPartyTranscation(string invoice_no)
        {
            this.PT = new List<string>[8];
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
            this.textBoxID.Text = invoice_no;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string text = this.textBoxID.Text;
            string query = "Delete from firoz_center.tbl_party_transcation where invoice_no ='" + text + "';";
            this.dbc.Delete(query);
            query = "Delete from firoz_center.tbl_bank_transcation where bank_transcation_id ='" + text + "';";
            this.dbc.Delete(query);
            MessageBox.Show("Data Deleted");
            base.Dispose();
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
            this.textBoxBank = new TextBox();
            this.label7 = new Label();
            this.textBoxName = new TextBox();
            this.textBoxID = new TextBox();
            this.label6 = new Label();
            this.buttonDelete = new Button();
            this.dateTimePicker2 = new DateTimePicker();
            this.label5 = new Label();
            this.textBoxAmount = new TextBox();
            this.label4 = new Label();
            this.textBoxAC = new TextBox();
            this.textBoxDescription = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxBank);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAC);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x194, 0x10d);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Transcation Info.";
            this.textBoxBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBank.Location = new Point(0x5b, 0x9b);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new Size(0x131, 0x16);
            this.textBoxBank.TabIndex = 0x3b;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x9b);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x27, 0x10);
            this.label7.TabIndex = 0x3a;
            this.label7.Text = "Bank";
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x5b, 0x2b);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x131, 0x16);
            this.textBoxName.TabIndex = 0x39;
            this.textBoxID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxID.Location = new Point(0x5b, 0x11);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new Size(0x8b, 0x16);
            this.textBoxID.TabIndex = 0x38;
            this.textBoxID.KeyDown += new KeyEventHandler(this.textBoxID_KeyDown);
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x21, 0x10);
            this.label6.TabIndex = 0x37;
            this.label6.Text = "T ID";
            this.buttonDelete.BackColor = Color.MediumSeaGreen;
            this.buttonDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonDelete.Location = new Point(0x90, 0xe5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new Size(0x7d, 30);
            this.buttonDelete.TabIndex = 0x35;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0x11c, 0x11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x70, 0x16);
            this.dateTimePicker2.TabIndex = 0x34;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xe8, 0x15);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x25, 0x10);
            this.label5.TabIndex = 0x33;
            this.label5.Text = "Date";
            this.textBoxAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAmount.Location = new Point(0x5b, 0xcb);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new Size(0x131, 0x16);
            this.textBoxAmount.TabIndex = 0x31;
            this.textBoxAmount.Text = "0";
            this.textBoxAmount.TextAlign = HorizontalAlignment.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0xcb);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x35, 0x10);
            this.label4.TabIndex = 0x30;
            this.label4.Text = "Amount";
            this.textBoxAC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAC.Location = new Point(0x5b, 0xb3);
            this.textBoxAC.Name = "textBoxAC";
            this.textBoxAC.Size = new Size(0x131, 0x16);
            this.textBoxAC.TabIndex = 0x2f;
            this.textBoxDescription.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDescription.Location = new Point(0x5b, 0x43);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new Size(0x131, 0x56);
            this.textBoxDescription.TabIndex = 0x2e;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0xb3);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2f, 0x10);
            this.label3.TabIndex = 0x2b;
            this.label3.Text = "AC No";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x43);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x4c, 0x10);
            this.label2.TabIndex = 0x2a;
            this.label2.Text = "Description";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0x29);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x29;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19d, 0x116);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditPartyTranscation";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Party Transcation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_all(string invoice_no)
        {
            string query = "Select transcation_id,party_id,DATE_FORMAT(date, '%Y-%m-%d'), amount,description,type,details,invoice_no from firoz_center.tbl_party_transcation where invoice_no ='" + invoice_no + "';";
            for (int i = 0; i < 8; i++)
            {
                this.PT[i] = new List<string>();
            }
            this.PT = this.dbc.Select(8L, query);
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Search Again");
            }
            else
            {
                string str2 = this.PT[1].ElementAt<string>(0);
                string s = this.PT[2].ElementAt<string>(0);
                string str4 = this.PT[3].ElementAt<string>(0);
                string str5 = this.PT[4].ElementAt<string>(0);
                string str6 = this.dbc.SelectSingle("Select name from firoz_center.tbl_party where customer_id='" + str2 + "'");
                this.dateTimePicker2.Value = DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                this.textBoxAmount.Text = str4;
                this.textBoxDescription.Text = str5;
                string str7 = "Select bank_id from firoz_center.tbl_bank_transcation where bank_transcation_id='" + invoice_no + "';";
                string str8 = this.dbc.SelectSingle(str7);
                string str9 = this.dbc.SelectSingle("SELECT name FROM firoz_center.tbl_bank_info where bank_id='" + str8 + "'");
                string str10 = this.dbc.SelectSingle("SELECT ac_no FROM firoz_center.tbl_bank_info where bank_id='" + str8 + "'");
                this.textBoxBank.Text = str9;
                this.textBoxAC.Text = str10;
            }
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_all(this.textBoxID.Text);
            }
        }
    }
}

