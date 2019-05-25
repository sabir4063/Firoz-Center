namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EditBankTranscation : Form
    {
        private List<string>[] ACNo = new List<string>[2];
        private List<string>[] Bank = new List<string>[2];
        private Button buttonLoad;
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
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
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
        private TextBox textBoxBankTranscationId;
        private TextBox textBoxDes;
        private TextBox textBoxNetBalance;
        private TextBox textBoxtotal;

        public EditBankTranscation()
        {
            this.InitializeComponent();
            this.load_bank();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.load_data();
            this.calculate_amount();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string text = this.textBoxBankTranscationId.Text;
            string query = "Select memo_no,amount,payment_id from firoz_center.tbl_payment where bank_transcation_id ='" + text + "' and bank_deposite='1';";
            List<string>[] listArray = new List<string>[3];
            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            double num2 = 0.0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str3 = listArray[0].ElementAt<string>(num);
                string str4 = listArray[1].ElementAt<string>(num);
                string str5 = listArray[2].ElementAt<string>(num);
                num2 += double.Parse(str4);
                this.dataGridView1.Rows.Add(new object[] { str3, str4, true, str5 });
            }
            this.load_data();
            string s = this.dbc.SelectSingle("Select DATE_FORMAT(date, '%Y-%m-%d') from firoz_center.tbl_bank_transcation where bank_transcation_id='" + text + "';");
            this.dateTimePicker2.Value = DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        private void calculate_amount()
        {
            if (!this.textBoxAmount.Text.Equals(""))
            {
                double num = double.Parse(this.textBoxBalance.Text);
                double num2 = double.Parse(this.textBoxtotal.Text);
                this.textBoxNetBalance.Text = (num - num2).ToString();
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewCheckBoxColumn();
            this.textBoxNetBalance = new TextBox();
            this.label8 = new Label();
            this.textBoxBalance = new TextBox();
            this.label2 = new Label();
            this.textBoxtotal = new TextBox();
            this.label6 = new Label();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.buttonSearch = new Button();
            this.groupBox2 = new GroupBox();
            this.textBoxBankTranscationId = new TextBox();
            this.label7 = new Label();
            this.dataGridView1 = new DataGridView();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.comboBoxACNo = new ComboBox();
            this.dateTimePicker2 = new DateTimePicker();
            this.label5 = new Label();
            this.textBoxDes = new TextBox();
            this.buttonSave = new Button();
            this.comboBoxBank = new ComboBox();
            this.groupBox3 = new GroupBox();
            this.textBoxAmount = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.groupBox1 = new GroupBox();
            this.buttonLoad = new Button();
            this.label1 = new Label();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = style;
            this.Column3.HeaderText = "Memo No";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = DataGridViewTriState.True;
            this.Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 40;
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
            this.textBoxtotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxtotal.Location = new Point(0x5b, 0x48);
            this.textBoxtotal.Name = "textBoxtotal";
            this.textBoxtotal.ReadOnly = true;
            this.textBoxtotal.Size = new Size(0x6b, 0x16);
            this.textBoxtotal.TabIndex = 0x37;
            this.textBoxtotal.Text = "0";
            this.textBoxtotal.TextAlign = HorizontalAlignment.Right;
            this.textBoxtotal.Visible = false;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x48);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x15, 0x10);
            this.label6.TabIndex = 0x36;
            this.label6.Text = "ID";
            this.label6.Visible = false;
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0x112, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(120, 30);
            this.buttonSearch.TabIndex = 0x2b;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxBankTranscationId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(470, 0x1e3);
            this.groupBox2.TabIndex = 0x2f;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transcation";
            this.textBoxBankTranscationId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxBankTranscationId.Location = new Point(0xa1, 0x11);
            this.textBoxBankTranscationId.Name = "textBoxBankTranscationId";
            this.textBoxBankTranscationId.Size = new Size(0x6b, 0x16);
            this.textBoxBankTranscationId.TabIndex = 0x39;
            this.textBoxBankTranscationId.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0x86, 20);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x15, 0x10);
            this.label7.TabIndex = 0x38;
            this.label7.Text = "ID";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column3, this.Column4, this.Column6, this.Column5 });
            this.dataGridView1.Location = new Point(8, 0x2d);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(0x1c5, 0x1b0);
            this.dataGridView1.TabIndex = 40;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = style3;
            this.Column4.FillWeight = 120f;
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
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
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Short;
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
            this.textBoxDes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDes.Location = new Point(8, 0x13);
            this.textBoxDes.Multiline = true;
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.ReadOnly = true;
            this.textBoxDes.Size = new Size(0x15c, 0xed);
            this.textBoxDes.TabIndex = 0x39;
            this.textBoxDes.TextAlign = HorizontalAlignment.Right;
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0xe8, 0xac);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x7d, 30);
            this.buttonSave.TabIndex = 50;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
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
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.textBoxDes);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(0x1e1, 0xe0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x16b, 0x108);
            this.groupBox3.TabIndex = 0x30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
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
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.textBoxNetBalance);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxtotal);
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
            this.groupBox1.Location = new Point(480, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x16b, 0xd5);
            this.groupBox1.TabIndex = 0x2e;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Info.";
            this.buttonLoad.BackColor = Color.MediumSeaGreen;
            this.buttonLoad.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonLoad.Location = new Point(0x5b, 0xac);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new Size(0x7d, 30);
            this.buttonLoad.TabIndex = 60;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x29;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x350, 0x1ec);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditBankTranscation";
            this.Text = "EditBankTranscation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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

        private void load_data()
        {
            double num = 0.0;
            double num2 = 0.0;
            this.textBoxDes.Text = "";
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                if ((bool) this.dataGridView1.Rows[i].Cells[2].Value)
                {
                    num += double.Parse(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                    string text = this.textBoxDes.Text;
                    this.textBoxDes.Text = text + "Memo: " + this.dataGridView1.Rows[i].Cells[0].Value.ToString() + " Amount: " + this.dataGridView1.Rows[i].Cells[1].Value.ToString() + "; \n";
                }
                else
                {
                    num2 += double.Parse(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            this.textBoxAmount.Text = num.ToString();
            this.textBoxtotal.Text = num2.ToString();
        }

        private void save_transcation()
        {
            string str = this.Bank[1].ElementAt<string>(this.comboBoxBank.SelectedIndex);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string text = this.textBoxAmount.Text;
            string query = "update firoz_center.tbl_bank_transcation set bank_id='" + str + "', date='" + str2 + "', amount='" + text + "' where `bank_transcation_id`='" + this.textBoxBankTranscationId.Text + "';";
            this.dbc.Update(query);
            query = "UPDATE firoz_center.tbl_bank_info set balance='" + this.textBoxNetBalance.Text + "' where bank_id = '" + str + "';";
            this.dbc.Update(query);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                if (!((bool) this.dataGridView1.Rows[i].Cells[2].Value))
                {
                    string str5 = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string str6 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string str7 = "Update firoz_center.tbl_payment set bank_deposite='0',bank_transcation_id=null where payment_id='" + str6 + "';";
                    this.dbc.Update(str7);
                }
            }
            base.Dispose();
            MessageBox.Show("Data Inserted");
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

