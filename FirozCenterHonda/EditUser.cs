namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class EditUser : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBoxName;
        private TextBox textBoxP1;
        private TextBox textBoxP2;

        public EditUser()
        {
            this.InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save change?", "Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            this.groupBox1 = new GroupBox();
            this.textBox1 = new TextBox();
            this.label2 = new Label();
            this.buttonSave = new Button();
            this.textBoxP2 = new TextBox();
            this.textBoxP1 = new TextBox();
            this.textBoxName = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxP2);
            this.groupBox1.Controls.Add(this.textBoxP1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x162, 0xa4);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit User";
            this.textBox1.BackColor = Color.SeaShell;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = SystemColors.Desktop;
            this.textBox1.Location = new Point(0x61, 0x33);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new Size(0xf4, 0x16);
            this.textBox1.TabIndex = 2;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(10, 0x33);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x39, 0x10);
            this.label2.TabIndex = 50;
            this.label2.Text = "Current";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.ForeColor = Color.Black;
            this.buttonSave.Location = new Point(0x7d, 0x7f);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Update";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxP2.BackColor = Color.SeaShell;
            this.textBoxP2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxP2.ForeColor = SystemColors.Desktop;
            this.textBoxP2.Location = new Point(0x61, 0x63);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.PasswordChar = '*';
            this.textBoxP2.Size = new Size(0xf4, 0x16);
            this.textBoxP2.TabIndex = 4;
            this.textBoxP1.BackColor = Color.SeaShell;
            this.textBoxP1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxP1.ForeColor = SystemColors.Desktop;
            this.textBoxP1.Location = new Point(0x61, 0x4b);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.PasswordChar = '*';
            this.textBoxP1.Size = new Size(0xf4, 0x16);
            this.textBoxP1.TabIndex = 3;
            this.textBoxName.BackColor = Color.SeaShell;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = SystemColors.Desktop;
            this.textBoxName.Location = new Point(0x61, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0xf4, 0x16);
            this.textBoxName.TabIndex = 1;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(10, 0x63);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x36, 0x10);
            this.label4.TabIndex = 0x2c;
            this.label4.Text = "Retype";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(10, 0x4b);
            this.label3.Name = "label3";
            this.label3.Size = new Size(70, 0x10);
            this.label3.TabIndex = 0x2b;
            this.label3.Text = "Password";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2c, 0x10);
            this.label1.TabIndex = 0x29;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x16b, 0xad);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditUser";
            this.Text = "EditUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void save_transcation()
        {
            string text = this.textBoxName.Text;
            string str2 = this.textBoxP1.Text;
            string str3 = this.textBoxP2.Text;
            string str4 = this.textBox1.Text;
            if (!(!text.Equals("") && str2.Equals(str3)))
            {
                MessageBox.Show("Check Again!");
            }
            else
            {
                string query = "Select pass from firoz_center.tbl_user where name='" + text + "';";
                DBConnect connect = new DBConnect();
                string str6 = connect.SelectSingle(query);
                if (str4.Equals(str6) && str2.Equals(str3))
                {
                    string str7 = "Update firoz_center.tbl_user set pass = '" + str2 + "' where name = '" + text + "'";
                    connect.Update(str7);
                    MessageBox.Show("Updtaed");
                    base.Dispose();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
        }
    }
}

