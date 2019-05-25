namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class EmployeeInformationUpdate : Form
    {
        private Button buttonSave;
        private CheckBox checkBox1;
        public ComboBox comboBoxEmployee;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private static DBConnect dbc = new DBConnect();
        private List<string>[] Employee = new List<string>[9];
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxName;
        private TextBox textBoxPosition;
        private TextBox textBoxSalary;

        public EmployeeInformationUpdate()
        {
            this.InitializeComponent();
            this.load_party();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxName.Text = this.Employee[1].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            this.textBoxAddress.Text = this.Employee[2].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            this.textBoxContact.Text = this.Employee[3].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            this.textBoxSalary.Text = this.Employee[6].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            this.textBoxPosition.Text = this.Employee[5].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            this.dateTimePicker1.Text = this.Employee[7].ElementAt<string>(this.comboBoxEmployee.SelectedIndex);
            if (this.Employee[8].ElementAt<string>(this.comboBoxEmployee.SelectedIndex).Equals("Active"))
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox1.Checked = false;
            }
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
            this.checkBox1 = new CheckBox();
            this.comboBoxEmployee = new ComboBox();
            this.textBoxSalary = new TextBox();
            this.label6 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.label5 = new Label();
            this.textBoxPosition = new TextBox();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x95, 0xfb);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Update";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.comboBoxEmployee);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPosition);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x192, 0x121);
            this.groupBox1.TabIndex = 0x29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information Update";
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = Color.DarkSeaGreen;
            this.checkBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.checkBox1.Location = new Point(0x4f, 0xe3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(0x40, 20);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.comboBoxEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxEmployee.BackColor = SystemColors.ControlLight;
            this.comboBoxEmployee.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new Point(0x4c, 20);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new Size(0x13c, 0x18);
            this.comboBoxEmployee.TabIndex = 0x3b;
            this.comboBoxEmployee.SelectedIndexChanged += new EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            this.textBoxSalary.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSalary.Location = new Point(0xf3, 0xc9);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new Size(0x95, 0x16);
            this.textBoxSalary.TabIndex = 0x3a;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(0xbc, 0xcc);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x2f, 0x10);
            this.label6.TabIndex = 0x39;
            this.label6.Text = "Salary";
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x4c, 0xc9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x58, 0x16);
            this.dateTimePicker1.TabIndex = 0x38;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(9, 0xcc);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x41, 0x10);
            this.label5.TabIndex = 0x37;
            this.label5.Text = "Join Date";
            this.textBoxPosition.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPosition.Location = new Point(0x4c, 0xb1);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new Size(0x13c, 0x16);
            this.textBoxPosition.TabIndex = 0x36;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.Location = new Point(0x4c, 0x99);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x13c, 0x16);
            this.textBoxContact.TabIndex = 0x35;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x4c, 70);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x13c, 0x51);
            this.textBoxAddress.TabIndex = 0x34;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x4c, 0x2e);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x13c, 0x16);
            this.textBoxName.TabIndex = 0x33;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(10, 0xb1);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x38, 0x10);
            this.label4.TabIndex = 50;
            this.label4.Text = "Position";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x99);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 0x31;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 0x30;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x2f;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19d, 0x12b);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EmployeeInformationUpdate";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Update Employee Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_party()
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

        private void save_transcation()
        {
            string text = this.textBoxName.Text;
            string str2 = this.textBoxAddress.Text;
            string str3 = this.textBoxContact.Text;
            string str4 = this.textBoxPosition.Text;
            string str5 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str6 = this.textBoxSalary.Text;
            string str7 = "Active";
            if (this.checkBox1.Checked)
            {
                str7 = "Active";
            }
            else
            {
                str7 = "Inactive";
            }
            if ((((text.Equals("") || str2.Equals("")) || (str3.Equals("") || str4.Equals(""))) || str5.Equals("")) || str6.Equals(""))
            {
                MessageBox.Show("Check Data Again");
            }
            else
            {
                string query = "update firoz_center.tbl_employee set name='" + text + "', address='" + str2 + "', contact='" + str3 + "', position='" + str4 + "', salary='" + str6 + "', joinDate='" + str5 + "', status='" + str7 + "' where employeeId='" + this.Employee[0].ElementAt<string>(this.comboBoxEmployee.SelectedIndex) + "';";
                dbc.Update(query);
                this.textBoxName.Text = "";
                this.textBoxContact.Text = "";
                this.textBoxAddress.Text = "";
                this.textBoxSalary.Text = "";
                this.textBoxPosition.Text = "";
                this.checkBox1.Checked = false;
                this.load_party();
                MessageBox.Show("Data Updated");
            }
        }
    }
}

