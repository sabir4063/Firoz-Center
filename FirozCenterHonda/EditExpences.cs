namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EditExpences : Form
    {
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonPrint;
        private Button buttonSave;
        private Button buttonSearch;
        private Button buttonUpdate;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
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
        private Label label8;
        private TextBox textBoxAmount;
        private TextBox textBoxAvailable;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private TextBox textBoxNetAmount;
        private TextBox textBoxTextNetAmount;
        private TextBox textBoxTID;

        public EditExpences()
        {
            this.InitializeComponent();
            this.load_petty_cash();
        }

        private void add_item()
        {
            string text = this.textBoxName.Text;
            string str2 = this.textBoxAmount.Text;
            string str3 = this.textBoxDescription.Text;
            this.dataGridView1.Rows.Add(new object[] { text, str3, str2 });
            double num = 0.0;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                double num3 = double.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                num += num3;
            }
            this.textBoxNetAmount.Text = num.ToString();
            this.textBoxTextNetAmount.Text = this.dbc.NumberToText(this.textBoxNetAmount.Text);
            this.textBoxName.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxAmount.Text = "";
            this.textBoxName.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.add_item();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.textBoxName.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxAmount.Text = "";
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
            this.load_transcation();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.add_item();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.textBoxName.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.textBoxDescription.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.textBoxAmount.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.dataGridView1.Rows.RemoveAt(e.RowIndex);
            double num = 0.0;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                double num3 = double.Parse(this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                num += num3;
            }
            this.textBoxNetAmount.Text = num.ToString();
            this.textBoxTextNetAmount.Text = this.dbc.NumberToText(this.textBoxNetAmount.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            this.dataGridView1 = new DataGridView();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.groupBox3 = new GroupBox();
            this.buttonSearch = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.label5 = new Label();
            this.label6 = new Label();
            this.textBoxTID = new TextBox();
            this.groupBox2 = new GroupBox();
            this.buttonPrint = new Button();
            this.buttonSave = new Button();
            this.textBoxTextNetAmount = new TextBox();
            this.textBoxNetAmount = new TextBox();
            this.label8 = new Label();
            this.groupBox1 = new GroupBox();
            this.buttonDelete = new Button();
            this.buttonUpdate = new Button();
            this.textBoxAvailable = new TextBox();
            this.label3 = new Label();
            this.textBoxName = new TextBox();
            this.buttonAdd = new Button();
            this.textBoxAmount = new TextBox();
            this.label4 = new Label();
            this.textBoxDescription = new TextBox();
            this.label2 = new Label();
            this.label1 = new Label();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column4, this.Column5, this.Column6 });
            this.dataGridView1.Location = new Point(5, 0x2f);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x1e3, 0xd7);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.Column4.FillWeight = 150f;
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = style2;
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style3;
            this.Column6.FillWeight = 80f;
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxTID);
            this.groupBox3.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x1ef, 0x109);
            this.groupBox3.TabIndex = 0x24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0x167, 0x10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(0x73, 30);
            this.buttonSearch.TabIndex = 0x4e;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0xf4, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x65, 0x16);
            this.dateTimePicker1.TabIndex = 5;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xcb, 0x18);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x25, 0x10);
            this.label5.TabIndex = 0x45;
            this.label5.Text = "Date";
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 0x17);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x43, 0x10);
            this.label6.TabIndex = 0x47;
            this.label6.Text = "Memo No";
            this.textBoxTID.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTID.Location = new Point(0x4e, 20);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.Size = new Size(0x75, 0x16);
            this.textBoxTID.TabIndex = 1;
            this.textBoxTID.KeyDown += new KeyEventHandler(this.textBoxTID_KeyDown);
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.buttonPrint);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.textBoxTextNetAmount);
            this.groupBox2.Controls.Add(this.textBoxNetAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(0x1fa, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x191, 100);
            this.groupBox2.TabIndex = 0x27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Amount";
            this.buttonPrint.BackColor = Color.MediumSeaGreen;
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(0xf5, 0x43);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(150, 30);
            this.buttonPrint.TabIndex = 0x52;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x5e, 0x43);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(150, 30);
            this.buttonSave.TabIndex = 0x51;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxTextNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTextNetAmount.Location = new Point(0x5e, 0x2b);
            this.textBoxTextNetAmount.Name = "textBoxTextNetAmount";
            this.textBoxTextNetAmount.ReadOnly = true;
            this.textBoxTextNetAmount.Size = new Size(0x12d, 0x16);
            this.textBoxTextNetAmount.TabIndex = 80;
            this.textBoxTextNetAmount.TextAlign = HorizontalAlignment.Right;
            this.textBoxNetAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetAmount.Location = new Point(0x5e, 0x13);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new Size(0x12d, 0x16);
            this.textBoxNetAmount.TabIndex = 0x4e;
            this.textBoxNetAmount.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(13, 0x16);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x4d, 0x10);
            this.label8.TabIndex = 0x4f;
            this.label8.Text = "Net Amount";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxAvailable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(0x1fa, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x191, 0x9e);
            this.groupBox1.TabIndex = 0x26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Expences";
            this.buttonDelete.BackColor = Color.MediumSeaGreen;
            this.buttonDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonDelete.Location = new Point(0x12b, 120);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new Size(90, 30);
            this.buttonDelete.TabIndex = 0x4f;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new EventHandler(this.buttonDelete_Click);
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0xc3, 120);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(90, 30);
            this.buttonUpdate.TabIndex = 0x4e;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            this.textBoxAvailable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAvailable.Location = new Point(0x58, 20);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.ReadOnly = true;
            this.textBoxAvailable.Size = new Size(0x12d, 0x16);
            this.textBoxAvailable.TabIndex = 0x48;
            this.textBoxAvailable.TextAlign = HorizontalAlignment.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x41, 0x10);
            this.label3.TabIndex = 0x49;
            this.label3.Text = "Available";
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x58, 0x2c);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x12d, 0x16);
            this.textBoxName.TabIndex = 2;
            this.buttonAdd.BackColor = Color.MediumSeaGreen;
            this.buttonAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonAdd.Location = new Point(0x58, 120);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(90, 30);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            this.textBoxAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAmount.Location = new Point(0x58, 0x5c);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new Size(0x12d, 0x16);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.Text = "0";
            this.textBoxAmount.TextAlign = HorizontalAlignment.Right;
            this.textBoxAmount.KeyDown += new KeyEventHandler(this.textBoxAmount_KeyDown);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(7, 0x5c);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x35, 0x10);
            this.label4.TabIndex = 0x3d;
            this.label4.Text = "Amount";
            this.textBoxDescription.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDescription.Location = new Point(0x58, 0x44);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new Size(0x12d, 0x16);
            this.textBoxDescription.TabIndex = 3;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(7, 0x44);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x4c, 0x10);
            this.label2.TabIndex = 0x3a;
            this.label2.Text = "Description";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(7, 0x2c);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x39;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x38f, 0x113);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox3);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditExpences";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "EditExpences";
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_petty_cash()
        {
            string query = "Select sum(amount) from firoz_center.tbl_cash_expences";
            string str2 = "0";
            if (this.dbc.Count(query) == -1L)
            {
                str2 = "0";
            }
            else
            {
                str2 = this.dbc.SelectSingle(query);
            }
            this.textBoxAvailable.Text = str2;
        }

        private void load_transcation()
        {
            this.dataGridView1.Rows.Clear();

            string text = this.textBoxTID.Text;
            string query = "Select * FROM firoz_center.tbl_expences where expences_id='" + text + "'";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Search Again");
            }
            else
            {
                int num2;
                List<string>[] listArray = new List<string>[6];
                for (num2 = 0; num2 < 6; num2++)
                {
                    listArray[num2] = new List<string>();
                }
                listArray = this.dbc.Select(6L, query);
                string s = this.dbc.SelectSingle("Select DATE_FORMAT(date, '%Y-%m-%d') AS date from firoz_center.tbl_expences where expences_id='" + text + "';");
                this.dateTimePicker1.Value = DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                for (num2 = 0; num2 < listArray[0].Count; num2++)
                {
                    string str4 = listArray[5].ElementAt<string>(num2);
                    string str5 = listArray[1].ElementAt<string>(num2);
                    string str6 = listArray[4].ElementAt<string>(num2);
                    this.dataGridView1.Rows.Add(new object[] { str4, str5, str6 });
                }
            }
        }

        private void save_transcation()
        {
            string text = this.textBoxTID.Text;
            string str2 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str3 = this.textBoxTID.Text;
            string query = "Delete from firoz_center.tbl_expences where expences_id='" + str3 + "';";
            this.dbc.Delete(query);
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str5 = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str7 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str8 = "Insert into firoz_center.tbl_expences (`expences_id`,`description`,`date`,`userid`,`amount`,`name`) values ('" + str3 + "','" + str7 + "','" + str2 + "','1','" + str6 + "','" + str5 + "');";
                this.dbc.Insert(str8);
            }
            double num2 = double.Parse(this.textBoxNetAmount.Text);
            string str9 = string.Concat(new object[] { "UPDATE firoz_center.tbl_cash_expences set date='", str2, "', amount=-'", num2, "', description='Expences' where bank_transcation_id='", str3, "';" });
            this.dbc.Update(str9);
            base.Dispose();
            this.buttonSave.Enabled = false;
            this.buttonSave.BackColor = Color.Red;
            MessageBox.Show("Data Updated");
        }

        private void textBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBoxAmount.Text.Equals(""))
                {
                    MessageBox.Show("Please Check Amount!");
                }
                else
                {
                    e.SuppressKeyPress = true;
                    this.add_item();
                }
            }
        }

        private void textBoxTID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBoxTID.Text.Equals(""))
                {
                    MessageBox.Show("Please Search Again!");
                }
                else
                {
                    e.SuppressKeyPress = true;
                    this.load_transcation();
                }
            }
        }
    }
}

