namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class AddNewEmployee : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
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

        public AddNewEmployee()
        {
            this.InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
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
            this.buttonSave.ForeColor = Color.Black;
            this.buttonSave.Location = new Point(0x99, 0xcc);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x1b;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.buttonSave);
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
            this.groupBox1.Size = new Size(0x19b, 0xf4);
            this.groupBox1.TabIndex = 0x1c;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Employee Information";
            this.textBoxSalary.BackColor = SystemColors.Window;
            this.textBoxSalary.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxSalary.ForeColor = Color.Black;
            this.textBoxSalary.Location = new Point(0xfe, 0xb0);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new Size(0x95, 0x16);
            this.textBoxSalary.TabIndex = 0x2b;
            this.textBoxSalary.TextChanged += new EventHandler(this.textBoxSalary_TextChanged);
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.ForeColor = Color.Black;
            this.label6.Location = new Point(0xc0, 0xb3);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x2f, 0x10);
            this.label6.TabIndex = 0x2a;
            this.label6.Text = "Salary";
            this.dateTimePicker1.CalendarForeColor = Color.Black;
            this.dateTimePicker1.CalendarMonthBackground = Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = Color.Black;
            this.dateTimePicker1.CalendarTrailingForeColor = Color.Black;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0x57, 0xb0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(0x58, 0x16);
            this.dateTimePicker1.TabIndex = 0x29;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.Black;
            this.label5.Location = new Point(10, 0xb0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x41, 0x10);
            this.label5.TabIndex = 40;
            this.label5.Text = "Join Date";
            this.textBoxPosition.BackColor = SystemColors.Window;
            this.textBoxPosition.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPosition.ForeColor = Color.Black;
            this.textBoxPosition.Location = new Point(0x57, 0x98);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new Size(0x13c, 0x16);
            this.textBoxPosition.TabIndex = 0x27;
            this.textBoxContact.BackColor = SystemColors.Window;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.ForeColor = Color.Black;
            this.textBoxContact.Location = new Point(0x57, 0x80);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x13c, 0x16);
            this.textBoxContact.TabIndex = 0x26;
            this.textBoxAddress.BackColor = SystemColors.Window;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.ForeColor = Color.Black;
            this.textBoxAddress.Location = new Point(0x57, 0x2d);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x13c, 0x51);
            this.textBoxAddress.TabIndex = 0x25;
            this.textBoxName.BackColor = SystemColors.Window;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = Color.Black;
            this.textBoxName.Location = new Point(0x57, 0x15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x13c, 0x16);
            this.textBoxName.TabIndex = 0x24;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(10, 0x98);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x38, 0x10);
            this.label4.TabIndex = 0x23;
            this.label4.Text = "Position";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(10, 0x80);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 0x22;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(10, 0x2d);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 0x21;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x20;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1a6, 0xfd);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "AddNewEmployee";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "EmployeeInformationEntry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string text = this.textBoxName.Text;
            string str2 = this.textBoxAddress.Text;
            string str3 = this.textBoxContact.Text;
            string str4 = this.textBoxPosition.Text;
            string str5 = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str6 = this.textBoxSalary.Text;
            if ((((text.Equals("") || str2.Equals("")) || (str3.Equals("") || str4.Equals(""))) || str5.Equals("")) || str6.Equals(""))
            {
                MessageBox.Show("Check Data Again");
            }
            else
            {
                string query = "insert into firoz_center.tbl_employee (`name`,`address`,`contact`,`joinDate`,`position`,`salary`,`comments`,`status`) values ('" + text + "','" + str2 + "','" + str3 + "','" + str5 + "','" + str4 + "','" + str6 + "','','Active');";
                connect.Insert(query);
                this.textBoxName.Text = "";
                this.textBoxContact.Text = "";
                this.textBoxAddress.Text = "";
                this.textBoxSalary.Text = "";
                this.textBoxPosition.Text = "";
                MessageBox.Show("Data Inserted");
            }
        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.textBoxSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBoxSalary.Text.Remove(this.textBoxSalary.Text.Length - 1);
            }
        }
    }
}

