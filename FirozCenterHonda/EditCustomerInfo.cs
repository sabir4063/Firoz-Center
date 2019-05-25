namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class EditCustomerInfo : Form
    {
        private Button buttonSave;
        private ComboBox comboBoxParty;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label labelId;
        private List<string>[] Party = new List<string>[7];
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxFName;
        private TextBox textBoxName;

        public EditCustomerInfo()
        {
            this.InitializeComponent();
            this.load_party();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save change?", "Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string text = this.labelId.Text;
                string str2 = this.textBoxName.Text;
                string str3 = this.textBoxFName.Text;
                string str4 = this.textBoxAddress.Text;
                string str5 = this.textBoxContact.Text;
                string query = "Update firoz_center.tbl_customer set name='" + str2 + "', fathers_name='" + str3 + "', address='" + str4 + "', contact='" + str5 + "' where customer_id = '" + text + "';";
                this.dbc.Update(query);
                MessageBox.Show("Updated");
                base.Dispose();
            }
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = this.comboBoxParty.SelectedItem.ToString();
            string sql = "customer_id='" + this.Party[0].ElementAt<string>(this.comboBoxParty.SelectedIndex).ToString() + "'";
            this.load_info(sql);
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
            this.labelId = new Label();
            this.comboBoxParty = new ComboBox();
            this.label6 = new Label();
            this.textBoxFName = new TextBox();
            this.label5 = new Label();
            this.buttonSave = new Button();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.comboBoxParty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1a3, 0xf1);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Customer";
            this.labelId.AutoSize = true;
            this.labelId.BackColor = Color.DarkSeaGreen;
            this.labelId.BorderStyle = BorderStyle.FixedSingle;
            this.labelId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelId.ForeColor = SystemColors.Desktop;
            this.labelId.Location = new Point(0x151, 0xd0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(2, 0x12);
            this.labelId.TabIndex = 0x37;
            this.labelId.Visible = false;
            this.comboBoxParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = SystemColors.Window;
            this.comboBoxParty.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new Point(0x76, 15);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new Size(0x126, 0x18);
            this.comboBoxParty.TabIndex = 0x36;
            this.comboBoxParty.SelectedIndexChanged += new EventHandler(this.comboBoxParty_SelectedIndexChanged);
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x2d, 0x10);
            this.label6.TabIndex = 0x33;
            this.label6.Text = "Name";
            this.textBoxFName.BackColor = SystemColors.HighlightText;
            this.textBoxFName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxFName.ForeColor = SystemColors.Desktop;
            this.textBoxFName.Location = new Point(0x76, 0x43);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new Size(0x126, 0x16);
            this.textBoxFName.TabIndex = 0x22;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = SystemColors.Desktop;
            this.label5.Location = new Point(5, 0x43);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x60, 0x10);
            this.label5.TabIndex = 0x27;
            this.label5.Text = "Father's Name";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.ForeColor = SystemColors.Desktop;
            this.buttonSave.Location = new Point(0xa2, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxContact.BackColor = SystemColors.HighlightText;
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.ForeColor = SystemColors.Desktop;
            this.textBoxContact.Location = new Point(0x76, 0xac);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new Size(0x126, 0x16);
            this.textBoxContact.TabIndex = 0x24;
            this.textBoxAddress.BackColor = SystemColors.HighlightText;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.ForeColor = SystemColors.Desktop;
            this.textBoxAddress.Location = new Point(0x76, 90);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(0x126, 0x51);
            this.textBoxAddress.TabIndex = 0x23;
            this.textBoxName.BackColor = SystemColors.HighlightText;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = SystemColors.Desktop;
            this.textBoxName.Location = new Point(0x76, 0x2c);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(0x126, 0x16);
            this.textBoxName.TabIndex = 0x21;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = SystemColors.Desktop;
            this.label3.Location = new Point(4, 0xac);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 0x1f;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = SystemColors.Desktop;
            this.label2.Location = new Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 30;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = SystemColors.Desktop;
            this.label1.Location = new Point(5, 0x2c);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0x1d;
            this.label1.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1ac, 0xf9);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "EditCustomerInfo";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "EditCustomerInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_info(string sql)
        {
            this.labelId.Text = this.dbc.SelectSingle("SELECT customer_id FROM firoz_center.tbl_customer where " + sql + ";");
            this.textBoxName.Text = this.dbc.SelectSingle("SELECT name FROM firoz_center.tbl_customer where " + sql + ";");
            this.textBoxFName.Text = this.dbc.SelectSingle("SELECT fathers_name FROM firoz_center.tbl_customer where " + sql + ";");
            this.textBoxAddress.Text = this.dbc.SelectSingle("SELECT address FROM firoz_center.tbl_customer where " + sql + ";");
            this.textBoxContact.Text = this.dbc.SelectSingle("SELECT contact FROM firoz_center.tbl_customer where " + sql + ";");
        }

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            string query = "SELECT * FROM firoz_center.tbl_customer t order by customer_id;";
            for (num = 0; num < 7; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(7L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
            }
        }
    }
}

