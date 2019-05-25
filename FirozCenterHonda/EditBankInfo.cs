namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class EditBankInfo : Form
    {
        private List<string>[] Bank = new List<string>[5];
        private Button buttonSave;
        public ComboBox comboBoxBank;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAC;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxName;

        public EditBankInfo()
        {
            this.InitializeComponent();
            this.load_bank();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update bank info?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((this.textBoxName.Text.Equals("") || this.textBoxAddress.Text.Equals("")) || this.textBoxAC.Text.Equals(""))
                {
                    MessageBox.Show("Check Data Again");
                }
                else
                {
                    this.save_transcation();
                }
            }
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxBank.SelectedIndex;
            this.textBoxName.Text = this.Bank[1].ElementAt<string>(selectedIndex);
            this.textBoxAddress.Text = this.Bank[2].ElementAt<string>(selectedIndex);
            this.textBoxAC.Text = this.Bank[3].ElementAt<string>(selectedIndex);
            this.textBoxContact.Text = this.Bank[4].ElementAt<string>(selectedIndex);
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
            this.textBoxName = new TextBox();
            this.comboBoxBank = new ComboBox();
            this.buttonSave = new Button();
            this.textBoxContact = new TextBox();
            this.textBoxAC = new TextBox();
            this.textBoxAddress = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.comboBoxBank);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAC);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1a9, 0xf7);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Bank Information";
            this.textBoxName.BackColor = SystemColors.Window;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = SystemColors.Desktop;
            this.textBoxName.Location = new Point(0x61, 0x2c);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x13c, 0x16);
            this.textBoxName.TabIndex = 0x33;
            this.comboBoxBank.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxBank.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxBank.BackColor = SystemColors.ControlLight;
            this.comboBoxBank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new Point(0x61, 0x12);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new Size(0x13c, 0x18);
            this.comboBoxBank.TabIndex = 50;
            this.comboBoxBank.SelectedIndexChanged += new EventHandler(this.comboBoxBank_SelectedIndexChanged);
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.ForeColor = Color.Black;
            this.buttonSave.Location = new Point(0x99, 0xd5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x31;
            this.buttonSave.Text = "Update";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxContact.BackColor = SystemColors.Window;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.ForeColor = SystemColors.Desktop;
            this.textBoxContact.Location = new Point(0x61, 0xbd);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x13c, 0x16);
            this.textBoxContact.TabIndex = 0x30;
            this.textBoxAC.BackColor = SystemColors.Window;
            this.textBoxAC.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAC.ForeColor = SystemColors.Desktop;
            this.textBoxAC.Location = new Point(0x61, 0xa5);
            this.textBoxAC.Name = "textBoxAC";
            this.textBoxAC.Size = new Size(0x13c, 0x16);
            this.textBoxAC.TabIndex = 0x2f;
            this.textBoxAddress.BackColor = SystemColors.Window;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.ForeColor = SystemColors.Desktop;
            this.textBoxAddress.Location = new Point(0x61, 0x44);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x13c, 0x5f);
            this.textBoxAddress.TabIndex = 0x2e;
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new Point(10, 0xbd);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x3d, 0x10);
            this.label4.TabIndex = 0x2c;
            this.label4.Text = "Contact";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new Point(10, 0xa5);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x30, 0x10);
            this.label3.TabIndex = 0x2b;
            this.label3.Text = "AC No";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new Point(10, 0x44);
            this.label2.Name = "label2";
            this.label2.Size = new Size(60, 0x10);
            this.label2.TabIndex = 0x2a;
            this.label2.Text = "Address";
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
            base.ClientSize = new Size(0x1b3, 0xff);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditBankInfo";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chnage Bank Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_bank()
        {
            int num;
            string query = "SELECT bank_id,name,address,ac_no,contact FROM firoz_center.tbl_bank_info t group by name;";
            for (num = 0; num < 5; num++)
            {
                this.Bank[num] = new List<string>();
            }
            this.Bank = this.dbc.Select(5L, query);
            for (num = 0; num < this.Bank[0].Count; num++)
            {
                this.comboBoxBank.Items.Add(this.Bank[1].ElementAt<string>(num).ToString());
            }
        }

        private void save_transcation()
        {
            DBConnect connect = new DBConnect();
            string text = this.textBoxName.Text;
            string str2 = this.textBoxAddress.Text;
            string str3 = this.textBoxContact.Text;
            string str4 = this.textBoxAC.Text;
            string query = "UPDATE firoz_center.tbl_bank_info set name='" + text + "', address='" + str2 + "', contact='" + str3 + "',ac_no='" + str4 + "' where bank_id = '" + this.Bank[0].ElementAt<string>(this.comboBoxBank.SelectedIndex) + "';";
            connect.Update(query);
            base.Dispose();
            MessageBox.Show("Data Updated");
        }
    }
}

