namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EmployeeReport : Form
    {
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public ComboBox comboBoxEmployee;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private static DBConnect dbc = new DBConnect();
        private List<string>[] Employee = new List<string>[9];
        private string employee_id = "";
        private Label label1;
        private Label label12;
        private Label label2;

        public EmployeeReport()
        {
            this.InitializeComponent();
            this.load_employeey();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select month,salary,loan,advance,deduction,net_salary from firoz_center.tbl_salary where employeeid='" + this.employee_id + "' and month between '" + str + "' and '" + str2 + "';";
            List<string>[] listArray = new List<string>[6];
            for (num = 0; num < 6; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = dbc.Select(6L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.dataGridView1.Rows.Add(new object[] { listArray[0].ElementAt<string>(num), listArray[1].ElementAt<string>(num), listArray[2].ElementAt<string>(num), listArray[3].ElementAt<string>(num), listArray[4].ElementAt<string>(num), listArray[5].ElementAt<string>(num) });
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            this.comboBoxEmployee = new ComboBox();
            this.label1 = new Label();
            this.dataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.buttonSearch = new Button();
            this.dateTimePicker2 = new DateTimePicker();
            this.label2 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label12 = new Label();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.comboBoxEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxEmployee.BackColor = SystemColors.ControlLight;
            this.comboBoxEmployee.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new Point(0x37, 9);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new Size(0x127, 0x18);
            this.comboBoxEmployee.TabIndex = 0x3d;
            this.comboBoxEmployee.SelectedIndexChanged += new EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.MediumSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 60;
            this.label1.Text = "Name";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column5, this.Column4, this.Column6 });
            this.dataGridView1.Location = new Point(10, 0x2a);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x330, 0x1c8);
            this.dataGridView1.TabIndex = 0x25;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = style2;
            this.Column1.HeaderText = "Month";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = style3;
            this.Column2.FillWeight = 120f;
            this.Column2.HeaderText = "Salary";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            this.Column3.FillWeight = 250f;
            this.Column3.HeaderText = "Advance";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = style4;
            this.Column5.HeaderText = "Loan";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = style5;
            this.Column4.HeaderText = "Deduction";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            style6.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style6;
            this.Column6.HeaderText = "Net Salary";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.Location = new Point(0x2e1, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(0x4b, 0x1b);
            this.buttonSearch.TabIndex = 0x42;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new Point(620, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new Size(0x6b, 0x16);
            this.dateTimePicker2.TabIndex = 0x41;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.MediumSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x223, 14);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x40, 0x10);
            this.label2.TabIndex = 0x40;
            this.label2.Text = "End Date";
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x1b0, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x6b, 0x16);
            this.dateTimePicker1.TabIndex = 0x3f;
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.MediumSeaGreen;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0x166, 14);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x43, 0x10);
            this.label12.TabIndex = 0x3e;
            this.label12.Text = "Start Date";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x346, 510);
            base.Controls.Add(this.buttonSearch);
            base.Controls.Add(this.dateTimePicker2);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.dateTimePicker1);
            base.Controls.Add(this.label12);
            base.Controls.Add(this.dataGridView1);
            base.Controls.Add(this.comboBoxEmployee);
            base.Controls.Add(this.label1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EmployeeReport";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Employee Salary Report";
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public void load_employeey()
        {
            int num;
            this.comboBoxEmployee.Items.Clear();
            string query = "SELECT * FROM firoz_center.tbl_employee t order by employeeId;";
            for (num = 0; num < 9; num++)
            {
                this.Employee[num] = new List<string>();
            }
            this.Employee = dbc.Select(9L, query);
            for (num = 0; num < this.Employee[0].Count; num++)
            {
                this.comboBoxEmployee.Items.Add(this.Employee[1].ElementAt<string>(num).ToString());
            }
        }
    }
}

