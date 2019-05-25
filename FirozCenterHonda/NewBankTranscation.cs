namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class NewBankTranscation : Form
    {
        private List<string>[] ACNo = new List<string>[2];
        private List<string>[] Bank = new List<string>[2];
        private Button buttonSave;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewCheckBoxColumn Column6;
        public ComboBox comboBoxACNo;
        public ComboBox comboBoxBank;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxAmount;
        private TextBox textBoxBalance;
        private TextBox textBoxDes;
        private TextBox textBoxNetBalance;
        private TextBox textBoxTID;

        public NewBankTranscation()
        {
            this.InitializeComponent();
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
            this.load_bank();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = this.Bank[1].ElementAt<string>(this.comboBoxBank.SelectedIndex);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string text = this.textBoxAmount.Text;
            string query = "insert into firoz_center.tbl_bank_transcation (`bank_transcation_id`,`bank_id`,`date`,`amount`,`description`,`comments`) values ('" + this.textBoxTID.Text + "','" + str + "','" + str2 + "','" + text + "','Deposite','');";
            this.dbc.Insert(query);
            query = "UPDATE firoz_center.tbl_bank_info set balance='" + this.textBoxNetBalance.Text + "' where bank_id = '" + str + "';";
            this.dbc.Update(query);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                if ((bool) this.dataGridView1.Rows[i].Cells[2].Value)
                {
                    string str5 = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string str6 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string str7 = "Update firoz_center.tbl_payment set bank_deposite='1',bank_transcation_id='" + this.textBoxTID.Text + "' where payment_id='" + str6 + "';";
                    this.dbc.Update(str7);
                }
            }
            base.Dispose();
            MessageBox.Show("Data Inserted");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker3.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select memo_no,amount,payment_id from firoz_center.tbl_payment where date between '" + str + "' and '" + str2 + "' and bank_deposite='0';";
            List<string>[] listArray = new List<string>[3];
            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            double num2 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str4 = listArray[0].ElementAt<string>(num);
                string s = listArray[1].ElementAt<string>(num);
                string str6 = listArray[2].ElementAt<string>(num);
                num2 += double.Parse(s);
                this.dataGridView1.Rows.Add(new object[] { str4, s, false, str6 });
            }
        }

        private void comboBoxACNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxBalance.Text = "";
            this.textBoxAmount.Text = "";
            this.textBoxNetBalance.Text = "";
            this.load_balance();
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxACNo.Items.Clear();
            this.load_acno();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double num = 0.0;
            this.textBoxDes.Text = "";
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                if ((bool) this.dataGridView1.Rows[i].Cells[2].Value)
                {
                    num += double.Parse(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                    string text = this.textBoxDes.Text;
                    this.textBoxDes.Text = text + "Memo: " + this.dataGridView1.Rows[i].Cells[0].Value.ToString() + " Amount: " + this.dataGridView1.Rows[i].Cells[1].Value.ToString() + "; \n";
                }
            }
            this.textBoxAmount.Text = num.ToString();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            this.groupBox1 = new GroupBox();
            this.textBoxNetBalance = new TextBox();
            this.label8 = new Label();
            this.textBoxBalance = new TextBox();
            this.label2 = new Label();
            this.textBoxTID = new TextBox();
            this.label6 = new Label();
            this.comboBoxACNo = new ComboBox();
            this.dateTimePicker2 = new DateTimePicker();
            this.label5 = new Label();
            this.buttonSave = new Button();
            this.textBoxAmount = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label1 = new Label();
            this.comboBoxBank = new ComboBox();
            this.dataGridView1 = new DataGridView();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewCheckBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.buttonSearch = new Button();
            this.groupBox2 = new GroupBox();
            this.label7 = new Label();
            this.dateTimePicker3 = new DateTimePicker();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            this.groupBox3 = new GroupBox();
            this.textBoxDes = new TextBox();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxNetBalance);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxACNo);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBank);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(0x1e1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x16b, 0xd5);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Info.";
            this.textBoxNetBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetBalance.Location = new Point(0x5b, 0x90);
            this.textBoxNetBalance.Name = "textBoxNetBalance";
            this.textBoxNetBalance.ReadOnly = true;
            this.textBoxNetBalance.Size = new Size(0x107, 0x16);
            this.textBoxNetBalance.TabIndex = 0x3b;
            this.textBoxNetBalance.Text = "0";
            this.textBoxNetBalance.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0x90);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x52, 0x10);
            this.label8.TabIndex = 0x3a;
            this.label8.Text = "Net Balance";
            this.textBoxBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBalance.Location = new Point(0x5b, 0x60);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new Size(0x107, 0x16);
            this.textBoxBalance.TabIndex = 0x39;
            this.textBoxBalance.Text = "0";
            this.textBoxBalance.TextAlign = HorizontalAlignment.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x60);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3a, 0x10);
            this.label2.TabIndex = 0x38;
            this.label2.Text = "Balance";
            this.textBoxTID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTID.Location = new Point(0x5b, 0x48);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.ReadOnly = true;
            this.textBoxTID.Size = new Size(0x6b, 0x16);
            this.textBoxTID.TabIndex = 0x37;
            this.textBoxTID.TextAlign = HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x48);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x15, 0x10);
            this.label6.TabIndex = 0x36;
            this.label6.Text = "ID";
            this.comboBoxACNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxACNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxACNo.BackColor = SystemColors.ControlLight;
            this.comboBoxACNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxACNo.FormattingEnabled = true;
            this.comboBoxACNo.Location = new Point(0x5b, 0x2e);
            this.comboBoxACNo.Name = "comboBoxACNo";
            this.comboBoxACNo.Size = new Size(0x107, 0x18);
            this.comboBoxACNo.TabIndex = 0x35;
            this.comboBoxACNo.SelectedIndexChanged += new EventHandler(this.comboBoxACNo_SelectedIndexChanged);
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(0xf7, 0x48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x6b, 0x16);
            this.dateTimePicker2.TabIndex = 0x34;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xcc, 0x4b);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x25, 0x10);
            this.label5.TabIndex = 0x33;
            this.label5.Text = "Date";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(110, 0xac);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(150, 30);
            this.buttonSave.TabIndex = 50;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.button1_Click);
            this.textBoxAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAmount.Location = new Point(0x5b, 120);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new Size(0x107, 0x16);
            this.textBoxAmount.TabIndex = 0x31;
            this.textBoxAmount.Text = "0";
            this.textBoxAmount.TextAlign = HorizontalAlignment.Right;
            this.textBoxAmount.TextChanged += new EventHandler(this.textBoxAmount_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x3f, 0x10);
            this.label4.TabIndex = 0x30;
            this.label4.Text = "Deposite";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x2e);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2f, 0x10);
            this.label3.TabIndex = 0x2b;
            this.label3.Text = "AC No";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x29;
            this.label1.Text = "Name";
            this.comboBoxBank.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBank.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBank.BackColor = SystemColors.ControlLight;
            this.comboBoxBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new Point(0x5b, 20);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new Size(0x107, 0x18);
            this.comboBoxBank.TabIndex = 7;
            this.comboBoxBank.SelectedIndexChanged += new EventHandler(this.comboBoxBank_SelectedIndexChanged);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column3, this.Column4, this.Column6, this.Column5 });
            this.dataGridView1.Location = new Point(8, 0x2d);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(0x1c5, 0x1b0);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseUp += new DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.CellStateChanged += new DataGridViewCellStateChangedEventHandler(this.dataGridView1_CellStateChanged);
            this.dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = style2;
            this.Column3.HeaderText = "Memo No";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = style3;
            this.Column4.FillWeight = 120f;
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = DataGridViewTriState.True;
            this.Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 40;
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0x14b, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(120, 30);
            this.buttonSearch.TabIndex = 0x2b;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(470, 0x1e3);
            this.groupBox2.TabIndex = 0x2c;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transcation";
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0xa9, 0x16);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x19, 0x10);
            this.label7.TabIndex = 0x2d;
            this.label7.Text = "To";
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker3.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new Point(200, 0x12);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new Size(0x6b, 0x16);
            this.dateTimePicker3.TabIndex = 0x2c;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x38, 0x11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x6b, 0x16);
            this.dateTimePicker1.TabIndex = 0x2a;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x29;
            this.label12.Text = "Date";
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.textBoxDes);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(0x1e1, 0xe0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x16b, 0x108);
            this.groupBox3.TabIndex = 0x2d;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            this.textBoxDes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDes.Location = new Point(8, 0x13);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.ReadOnly = true;
            this.textBoxDes.Size = new Size(0x15c, 0xed);
            this.textBoxDes.TabIndex = 0x39;
            this.textBoxDes.TextAlign = HorizontalAlignment.Right;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x350, 0x1eb);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "NewBankTranscation";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "New Bank Transcation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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

