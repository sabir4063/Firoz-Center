namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EmployeeAdvancePayment : Form
    {
        private Button buttonSave;
        public ComboBox comboBoxEmployee;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private static DBConnect dbc = new DBConnect();
        private List<string>[] Employee = new List<string>[3];
        private string employee_id = "";
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox textBoxAmount;
        private TextBox textBoxMemoNo;
        private TextBox textBoxSalary;

        public EmployeeAdvancePayment()
        {
            this.InitializeComponent();
            this.load_employee();
            string query = "SELECT max(advancepay_id) FROM firoz_center.tbl_advance_pay t;";
            if (dbc.Count(query) == -1L)
            {
                this.textBoxMemoNo.Text = "4000001";
            }
            else
            {
                string str2 = "SELECT max(advancepay_id) FROM firoz_center.tbl_advance_pay t;";
                this.textBoxMemoNo.Text = (long.Parse(dbc.SelectSingle(str2)) + 1L).ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string text = this.textBoxMemoNo.Text;
                string s = this.textBoxAmount.Text;
                string str3 = this.textBoxSalary.Text;
                string str4 = this.dateTimePicker1.Value.ToString("yyyy-MM-01", CultureInfo.InvariantCulture);
                if (s.Equals(""))
                {
                    MessageBox.Show("Check Amount");
                }
                else
                {
                    long num = long.Parse(s);
                    long num2 = long.Parse(str3);
                    if (num > num2)
                    {
                        MessageBox.Show("Check");
                    }
                    else
                    {
                        string query = "INSERT into firoz_center.tbl_advance_pay (`advancepay_id`,`employee_id`,`amount`,`date`,`description`) values ('" + text + "','" + this.employee_id + "','" + s + "','" + str4 + "','');";
                        dbc.Insert(query);
                        string str6 = "insert into firoz_center.tbl_transcation (`memo_no`,`debit`,`user_id`,`description`,`date`) values ('" + text + "','" + s + "','1','Loan','" + str4 + "');";
                        dbc.Insert(str6);
                        MessageBox.Show("Data Saved!");
                        base.Dispose();
                    }
                }
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxSalary.Text = this.Employee[2].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            this.employee_id = this.Employee[0].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
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
            this.textBoxAmount = new TextBox();
            this.label9 = new Label();
            this.textBoxSalary = new TextBox();
            this.label2 = new Label();
            this.textBoxMemoNo = new TextBox();
            this.label6 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label5 = new Label();
            this.label1 = new Label();
            this.buttonSave = new Button();
            this.groupBox1 = new GroupBox();
            this.comboBoxEmployee = new ComboBox();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.textBoxAmount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAmount.Location = new Point(0x54, 0x5b);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new Size(0x120, 0x16);
            this.textBoxAmount.TabIndex = 0x40;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x59);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x3e, 0x10);
            this.label9.TabIndex = 0x3f;
            this.label9.Text = "Advance";
            this.textBoxSalary.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSalary.Location = new Point(0x54, 0x43);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new Size(0x120, 0x16);
            this.textBoxSalary.TabIndex = 0x38;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x2f, 0x10);
            this.label2.TabIndex = 0x37;
            this.label2.Text = "Salary";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(0x54, 0x11);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.ReadOnly = true;
            this.textBoxMemoNo.Size = new Size(0x95, 0x16);
            this.textBoxMemoNo.TabIndex = 0x36;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x43, 0x10);
            this.label6.TabIndex = 0x35;
            this.label6.Text = "Memo No";
            this.dateTimePicker1.CustomFormat = "MMM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x11c, 0x11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x58, 0x16);
            this.dateTimePicker1.TabIndex = 0x34;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xef, 0x11);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x25, 0x10);
            this.label5.TabIndex = 0x33;
            this.label5.Text = "Date";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(9, 0x29);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x31;
            this.label1.Text = "Name";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x81, 0x75);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.BackgroundImageLayout = ImageLayout.None;
            this.groupBox1.Controls.Add(this.comboBoxEmployee);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x17e, 0x9a);
            this.groupBox1.TabIndex = 0x2a;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advance Payment";
            this.comboBoxEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxEmployee.BackColor = SystemColors.ControlLight;
            this.comboBoxEmployee.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new Point(0x54, 0x29);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new Size(0x120, 0x18);
            this.comboBoxEmployee.TabIndex = 0x41;
            this.comboBoxEmployee.SelectedIndexChanged += new EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x187, 0xa4);
            base.Controls.Add(this.groupBox1);
            base.Name = "EmployeeAdvancePayment";
            this.Text = "Employee Advance Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_employee()
        {
            int num;
            this.comboBoxEmployee.Items.Clear();
            string query = "SELECT employeeId,name,salary FROM firoz_center.tbl_employee t where status='ACTIVE' order by employeeId;";
            for (num = 0; num < 3; num++)
            {
                this.Employee[num] = new List<string>();
            }
            this.Employee = dbc.Select(3L, query);
            for (num = 0; num < this.Employee[0].Count; num++)
            {
                this.comboBoxEmployee.Items.Add(this.Employee[1].ElementAt<string>(num).ToString());
            }
        }
    }
}

