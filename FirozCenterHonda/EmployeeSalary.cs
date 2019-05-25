namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EmployeeSalary : Form
    {
        private Button buttonPrint;
        private Button buttonSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private List<string>[] Employee = new List<string>[4];
        private GroupBox groupBox3;
        private Label label5;

        public EmployeeSalary()
        {
            this.InitializeComponent();
            this.load_employee();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            double num = 0.0;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                string str = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string str2 = this.dataGridView1.Rows[i].Cells[9].Value.ToString();
                string str3 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str4 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                string str5 = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                string str7 = this.dataGridView1.Rows[i].Cells[7].Value.ToString();
                string s = this.dataGridView1.Rows[i].Cells[8].Value.ToString();
                string str9 = this.dateTimePicker1.Value.ToString("yyyy-MM-01", CultureInfo.InvariantCulture);
                string str10 = this.dateTimePicker1.Value.ToString("yyyy-MMM", CultureInfo.InvariantCulture);
                string str11 = DateTime.Today.ToString("yyyy-MM-dd");
                num += double.Parse(s);
                string str12 = "Insert into firoz_center.tbl_salary (`expences_id`,`employeeid`,`salary`,`month`,`payment`,`loan`,`advance`,`deduction`,`net_salary`) values ('" + str + "','" + str2 + "','" + str4 + "','" + str9 + "','" + str11 + "','" + str5 + "','" + str6 + "','" + str7 + "','" + s + "');";
                this.dbc.Insert(str12);
                if (!str5.Equals("0"))
                {
                    string str13 = "Select loan_id,paid,due,monthly_payment from firoz_center.tbl_loan where employee_id='" + str2 + "' and due>'0';";
                    List<string>[] listArray = new List<string>[4];
                    for (long j = 0L; j < 4L; j += 1L)
                    {
                        listArray[(int) ((IntPtr) j)] = new List<string>();
                    }
                    listArray = this.dbc.Select(4L, str13);
                    string str14 = listArray[0].ElementAt<string>(0);
                    double num4 = double.Parse(listArray[1].ElementAt<string>(0));
                    double num5 = double.Parse(listArray[2].ElementAt<string>(0));
                    double num6 = double.Parse(listArray[3].ElementAt<string>(0));
                    num4 += num6;
                    num5 -= num6;
                    string str15 = string.Concat(new object[] { "UPDATE firoz_center.tbl_loan  set paid='", num4, "', due='", num5, "' where loan_id='", str14, "';" });
                    this.dbc.Update(str15);
                }
            }
            string str16 = this.dataGridView1.Rows[0].Cells[0].Value.ToString();
            string str17 = this.dateTimePicker1.Value.ToString("yyyy-MM-01", CultureInfo.InvariantCulture);
            string query = string.Concat(new object[] { "Insert into firoz_center.tbl_expences (`expences_id`,`description`,`date`,`userid`,`amount`,`name`) values ('", str16, "','Salary','", str17, "','1','", num, "','Firoz Motors');" });
            this.dbc.Insert(query);
            string str19 = string.Concat(new object[] { "insert into firoz_center.tbl_cash_expences (`bank_transcation_id`,`date`,`amount`,`description`) values ('", str16, "','", str17, "','-", num, "','Salary');" });
            this.dbc.Insert(str19);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                long num2 = long.Parse(this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                long num3 = long.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                long num4 = long.Parse(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                long num5 = long.Parse(this.dataGridView1.Rows[i].Cells[6].Value.ToString());
                double num6 = (num2 / 30L) * (30L - num5);
                this.dataGridView1.Rows[i].Cells[7].Value = num6.ToString();
                this.dataGridView1.Rows[i].Cells[8].Value = (num2 - ((num3 + num4) + num6)).ToString();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string str = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string position = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string salary = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string month = this.dateTimePicker1.Value.ToString("MMM-yyyy", CultureInfo.InvariantCulture);
            string str6 = DateTime.Today.ToString("yyyy-MM-dd");
            string loan = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string advance = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            new EmployeeMonthlySalary(str, name, position, salary, month, str6, loan, advance).Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.load_employee();
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
            this.dateTimePicker1 = new DateTimePicker();
            this.label5 = new Label();
            this.groupBox3 = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Column10 = new DataGridViewTextBoxColumn();
            this.buttonSave = new Button();
            this.buttonPrint = new Button();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.dateTimePicker1.CustomFormat = "MMM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x62, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x58, 0x16);
            this.dateTimePicker1.TabIndex = 0x1f;
            this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.MediumSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(5, 7);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x55, 0x10);
            this.label5.TabIndex = 30;
            this.label5.Text = "Select Month";
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new Point(5, 0x24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x421, 0x1df);
            this.groupBox3.TabIndex = 0x20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column4, this.Column1, this.Column2, this.Column3, this.Column5, this.Column6, this.Column9, this.Column7, this.Column8, this.Column10 });
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = style;
            this.dataGridView1.Location = new Point(6, 0x11);
            this.dataGridView1.Name = "dataGridView1";
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = style2;
            this.dataGridView1.Size = new Size(0x415, 0x1c5);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridView1.KeyDown += new KeyEventHandler(this.dataGridView1_KeyDown);
            this.Column4.FillWeight = 50f;
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column1.FillWeight = 150f;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            this.Column2.HeaderText = "Position";
            this.Column2.Name = "Column2";
            this.Column3.FillWeight = 150f;
            this.Column3.HeaderText = "Salary";
            this.Column3.Name = "Column3";
            this.Column5.HeaderText = "Loan";
            this.Column5.Name = "Column5";
            this.Column6.HeaderText = "Advance";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column9.HeaderText = "Attendence";
            this.Column9.Name = "Column9";
            this.Column7.HeaderText = "Deduction";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column8.HeaderText = "Net Salary";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column10.HeaderText = "E ID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0xca, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x29;
            this.buttonSave.Text = "Generate";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.buttonPrint.BackColor = Color.MediumSeaGreen;
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(0x161, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(120, 30);
            this.buttonPrint.TabIndex = 0x2a;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x42d, 0x206);
            base.Controls.Add(this.buttonPrint);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.dateTimePicker1);
            base.Controls.Add(this.label5);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EmployeeSalary";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Employee Salary";
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void load_employee()
        {
            long num2;
            this.dataGridView1.Rows.Clear();
            string query = "SELECT employeeId,name,position,salary FROM firoz_center.tbl_employee where status='Active';";
            for (long i = 0L; i < 4L; i += 1L)
            {
                this.Employee[(int) ((IntPtr) i)] = new List<string>();
            }
            this.Employee = this.dbc.Select(4L, query);
            string str2 = "SELECT max(expences_id) FROM firoz_center.tbl_expences t;";
            if (this.dbc.Count(str2) == -1L)
            {
                num2 = 0x3d0901L;
            }
            else
            {
                string str3 = "SELECT max(expences_id) FROM firoz_center.tbl_expences t;";
                num2 = long.Parse(this.dbc.SelectSingle(str3)) + 1L;
            }
            for (int j = 0; j < this.Employee[0].Count; j++)
            {
                string str4 = this.Employee[0].ElementAt<string>(j);
                string str5 = this.dateTimePicker1.Value.ToString("yyyy-MM-01", CultureInfo.InvariantCulture);
                string str6 = "select salary from firoz_center.tbl_salary where employeeId='" + str4 + "' and month='" + str5 + "';";
                long num4 = this.dbc.Count(str6);
                string str7 = "select monthly_payment from firoz_center.tbl_loan where employee_Id='" + str4 + "' and due>'0';";
                string str8 = this.dbc.SelectSingle(str7);
                if (str8.Equals(""))
                {
                    str8 = "0";
                }
                string str9 = "select amount from firoz_center.tbl_advance_pay where employee_Id='" + str4 + "'  and date='" + str5 + "';";
                string str10 = this.dbc.SelectSingle(str9);
                if (str10.Equals(""))
                {
                    str10 = "0";
                }
                if (num4 == -1L)
                {
                    this.dataGridView1.Rows.Add(new object[] { num2, this.Employee[1].ElementAt<string>(j), this.Employee[2].ElementAt<string>(j), this.Employee[3].ElementAt<string>(j), str8, str10, "", "", "", str4 });
                }
            }
        }
    }
}

