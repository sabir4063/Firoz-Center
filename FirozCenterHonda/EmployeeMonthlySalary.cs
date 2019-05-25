namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class EmployeeMonthlySalary : Form
    {
        private string advance;
        private Button buttonSave;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private string employee_id;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private string loan;
        private string month;
        private string month_day;
        private string name;
        private string position;
        private string salary;
        private TextBox textBoxAdvance;
        private TextBox textBoxDeduction;
        private TextBox textBoxLoan;
        private TextBox textBoxMemo;
        private TextBox textBoxMonth;
        private TextBox textBoxName;
        private TextBox textBoxNetSalary;
        private TextBox textBoxSalary;

        public EmployeeMonthlySalary(string employee_id, string name, string position, string salary, string month, string month_day, string loan, string advance)
        {
            this.name = name;
            this.employee_id = employee_id;
            this.position = position;
            this.salary = salary;
            this.month = month;
            this.month_day = month_day;
            this.loan = loan;
            this.advance = advance;
            this.InitializeComponent();
            this.textBoxName.Text = name;
            this.textBoxSalary.Text = salary;
            this.textBoxMonth.Text = month;
            if (loan.Equals(""))
            {
                loan = "0";
            }
            this.textBoxLoan.Text = loan;
            if (advance.Equals(""))
            {
                advance = "0";
            }
            this.textBoxAdvance.Text = advance;
            this.textBoxDeduction.Text = "0";
            string query = "Select max(salary_id) from firoz_center.tbl_salary;";
            if (this.dbc.Count(query) == -1L)
            {
                this.textBoxMemo.Text = "9800001";
            }
            else
            {
                query = "Select max(salary_id) from firoz_center.tbl_salary;";
                string str2 = this.dbc.SelectSingle(query);
                this.textBoxMemo.Text = str2;
            }
            double num2 = (double.Parse(salary) - double.Parse(loan)) - double.Parse(advance);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string text = this.textBoxMemo.Text;
            string str2 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Insert into firoz_center.tbl_salary (`salary_id`,`employeeId`,`salary`,`month`,`payment`,`loan`,`advance`,`deduction`,`net_salary`) values ('" + this.textBoxMemo.Text + "','" + this.employee_id + "','" + this.salary + "','" + str2 + "','" + this.month_day + "','" + this.textBoxLoan.Text + "','" + this.textBoxAdvance.Text + "','" + this.textBoxDeduction.Text + "','" + this.textBoxNetSalary.Text + "');";
            this.dbc.Insert(query);
            query = "Insert into firoz_center.tbl_cash_expences (`memo_no`,`amount`,`date`) values ('" + this.textBoxMemo.Text + "','-" + this.salary + "','" + str2 + "');";
            this.dbc.Insert(query);
            query = "Insert into firoz_center.tbl_expences (`memo_no`,`amount`,`date`) values ('" + this.textBoxMemo.Text + "','-" + this.salary + "','" + str2 + "');";
            this.dbc.Insert(query);
            MessageBox.Show("Salary Paid");
            this.buttonSave.Enabled = false;
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
            this.textBoxNetSalary = new TextBox();
            this.label4 = new Label();
            this.textBoxDeduction = new TextBox();
            this.label8 = new Label();
            this.textBoxAdvance = new TextBox();
            this.label9 = new Label();
            this.textBoxMonth = new TextBox();
            this.textBoxLoan = new TextBox();
            this.label7 = new Label();
            this.label3 = new Label();
            this.textBoxSalary = new TextBox();
            this.label2 = new Label();
            this.textBoxMemo = new TextBox();
            this.label6 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label5 = new Label();
            this.textBoxName = new TextBox();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x86, 0xd5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Print";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.BackgroundImageLayout = ImageLayout.None;
            this.groupBox1.Controls.Add(this.textBoxNetSalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDeduction);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxAdvance);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxMonth);
            this.groupBox1.Controls.Add(this.textBoxLoan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMemo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x17e, 0xf8);
            this.groupBox1.TabIndex = 0x29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Payment";
            this.textBoxNetSalary.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNetSalary.Location = new Point(0x54, 0xb9);
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.ReadOnly = true;
            this.textBoxNetSalary.Size = new Size(0x120, 0x16);
            this.textBoxNetSalary.TabIndex = 0x44;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0xb9);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x47, 0x10);
            this.label4.TabIndex = 0x43;
            this.label4.Text = "Net Salary";
            this.textBoxDeduction.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDeduction.Location = new Point(0x54, 0xa1);
            this.textBoxDeduction.Name = "textBoxDeduction";
            this.textBoxDeduction.Size = new Size(0x120, 0x16);
            this.textBoxDeduction.TabIndex = 0x42;
            this.textBoxDeduction.KeyDown += new KeyEventHandler(this.textBoxDeduction_KeyDown);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(10, 0xa1);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x45, 0x10);
            this.label8.TabIndex = 0x41;
            this.label8.Text = "Deduction";
            this.textBoxAdvance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAdvance.Location = new Point(0x54, 0x89);
            this.textBoxAdvance.Name = "textBoxAdvance";
            this.textBoxAdvance.Size = new Size(0x120, 0x16);
            this.textBoxAdvance.TabIndex = 0x40;
            this.textBoxAdvance.KeyDown += new KeyEventHandler(this.textBoxAdvance_KeyDown);
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x89);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x3e, 0x10);
            this.label9.TabIndex = 0x3f;
            this.label9.Text = "Advance";
            this.textBoxMonth.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMonth.Location = new Point(0x54, 0x59);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.ReadOnly = true;
            this.textBoxMonth.Size = new Size(0x120, 0x16);
            this.textBoxMonth.TabIndex = 0x3e;
            this.textBoxLoan.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxLoan.Location = new Point(0x54, 0x71);
            this.textBoxLoan.Name = "textBoxLoan";
            this.textBoxLoan.Size = new Size(0x120, 0x16);
            this.textBoxLoan.TabIndex = 60;
            this.textBoxLoan.KeyDown += new KeyEventHandler(this.textBoxLoan_KeyDown);
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(10, 0x71);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x26, 0x10);
            this.label7.TabIndex = 0x3b;
            this.label7.Text = "Loan";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x59);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x2c, 0x10);
            this.label3.TabIndex = 0x39;
            this.label3.Text = "Month";
            this.textBoxSalary.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSalary.Location = new Point(0x54, 0x41);
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
            this.textBoxMemo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemo.Location = new Point(0x54, 0x11);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ReadOnly = true;
            this.textBoxMemo.Size = new Size(0x95, 0x16);
            this.textBoxMemo.TabIndex = 0x36;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x43, 0x10);
            this.label6.TabIndex = 0x35;
            this.label6.Text = "Memo No";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Short;
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
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x54, 0x29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x120, 0x16);
            this.textBoxName.TabIndex = 50;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(9, 0x29);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x31;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x18a, 0x102);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EmployeeMonthlySalary";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Employee Monthly Salary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void textBoxAdvance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxNetSalary.Text = (((double.Parse(this.textBoxSalary.Text) - double.Parse(this.textBoxLoan.Text)) - double.Parse(this.textBoxAdvance.Text)) - double.Parse(this.textBoxDeduction.Text)).ToString();
            }
        }

        private void textBoxDeduction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxNetSalary.Text = (((double.Parse(this.textBoxSalary.Text) - double.Parse(this.textBoxLoan.Text)) - double.Parse(this.textBoxAdvance.Text)) - double.Parse(this.textBoxDeduction.Text)).ToString();
            }
        }

        private void textBoxLoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxNetSalary.Text = (((double.Parse(this.textBoxSalary.Text) - double.Parse(this.textBoxLoan.Text)) - double.Parse(this.textBoxAdvance.Text)) - double.Parse(this.textBoxDeduction.Text)).ToString();
            }
        }
    }
}

