namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class UpdateCustomer : Form
    {
        private Button buttonSave;
        private Button buttonSearch;
        private ComboBox comboBox1;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label labelId;
        private Label labelIDNew;
        private List<string>[] Party = new List<string>[7];
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxMemo;
        private TextBox textBoxName;
        private TextBox textBoxNewAddress;
        private TextBox textBoxNewCOntact;
        private TextBox textBoxNewName;

        public UpdateCustomer()
        {
            this.InitializeComponent();
            this.load_customer();
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
            this.search();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxNewName.Text = this.Party[1].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.textBoxNewAddress.Text = this.Party[2].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.textBoxNewCOntact.Text = this.Party[3].ElementAt<string>(this.comboBox1.SelectedIndex);
            this.labelIDNew.Text = this.Party[0].ElementAt<string>(this.comboBox1.SelectedIndex);
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
            this.textBoxMemo = new TextBox();
            this.label4 = new Label();
            this.labelId = new Label();
            this.buttonSearch = new Button();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox2 = new GroupBox();
            this.labelIDNew = new Label();
            this.comboBox1 = new ComboBox();
            this.label9 = new Label();
            this.buttonSave = new Button();
            this.textBoxNewCOntact = new TextBox();
            this.textBoxNewAddress = new TextBox();
            this.textBoxNewName = new TextBox();
            this.label11 = new Label();
            this.label12 = new Label();
            this.label13 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxMemo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1a3, 0xdb);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Customer";
            this.textBoxMemo.BackColor = SystemColors.HighlightText;
            this.textBoxMemo.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemo.ForeColor = SystemColors.Desktop;
            this.textBoxMemo.Location = new Point(110, 0x13);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new Size(0xe0, 0x17);
            this.textBoxMemo.TabIndex = 1;
            this.textBoxMemo.TextChanged += new EventHandler(this.textBoxMemo_TextChanged);
            this.textBoxMemo.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.DarkSeaGreen;
            this.label4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = SystemColors.Desktop;
            this.label4.Location = new Point(6, 0x13);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x44, 0x10);
            this.label4.TabIndex = 0x38;
            this.label4.Text = "Memo No";
            this.labelId.AutoSize = true;
            this.labelId.BackColor = Color.DarkSeaGreen;
            this.labelId.BorderStyle = BorderStyle.FixedSingle;
            this.labelId.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelId.ForeColor = SystemColors.Desktop;
            this.labelId.Location = new Point(0x15b, 0x16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(0x37, 0x12);
            this.labelId.TabIndex = 0x37;
            this.labelId.Text = "ID OLD";
            this.buttonSearch.BackColor = Color.MediumSeaGreen;
            this.buttonSearch.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSearch.ForeColor = SystemColors.Desktop;
            this.buttonSearch.Location = new Point(0xb7, 0xb3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new Size(0x4b, 0x1c);
            this.buttonSearch.TabIndex = 0x26;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new EventHandler(this.buttonSearch_Click);
            this.textBoxContact.BackColor = SystemColors.HighlightText;
            this.textBoxContact.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.ForeColor = SystemColors.Desktop;
            this.textBoxContact.Location = new Point(110, 0x98);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new Size(0x126, 0x17);
            this.textBoxContact.TabIndex = 0x24;
            this.textBoxAddress.BackColor = SystemColors.HighlightText;
            this.textBoxAddress.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.ForeColor = SystemColors.Desktop;
            this.textBoxAddress.Location = new Point(110, 0x45);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new Size(0x126, 0x51);
            this.textBoxAddress.TabIndex = 0x23;
            this.textBoxName.BackColor = SystemColors.HighlightText;
            this.textBoxName.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.ForeColor = SystemColors.Desktop;
            this.textBoxName.Location = new Point(110, 0x2c);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x126, 0x17);
            this.textBoxName.TabIndex = 0x21;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = SystemColors.Desktop;
            this.label3.Location = new Point(7, 0x98);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x3d, 0x10);
            this.label3.TabIndex = 0x1f;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = SystemColors.Desktop;
            this.label2.Location = new Point(6, 0x45);
            this.label2.Name = "label2";
            this.label2.Size = new Size(60, 0x10);
            this.label2.TabIndex = 30;
            this.label2.Text = "Address";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = SystemColors.Desktop;
            this.label1.Location = new Point(6, 0x2c);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2c, 0x10);
            this.label1.TabIndex = 0x1d;
            this.label1.Text = "Name";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.labelIDNew);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.textBoxNewCOntact);
            this.groupBox2.Controls.Add(this.textBoxNewAddress);
            this.groupBox2.Controls.Add(this.textBoxNewName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(430, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x1a3, 0xdb);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Customer";
            this.labelIDNew.AutoSize = true;
            this.labelIDNew.BackColor = Color.DarkSeaGreen;
            this.labelIDNew.BorderStyle = BorderStyle.FixedSingle;
            this.labelIDNew.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelIDNew.ForeColor = SystemColors.Desktop;
            this.labelIDNew.Location = new Point(0x159, 0x17);
            this.labelIDNew.Name = "labelIDNew";
            this.labelIDNew.Size = new Size(0x3b, 0x12);
            this.labelIDNew.TabIndex = 0x37;
            this.labelIDNew.Text = "ID NEW";
            this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = SystemColors.Window;
            this.comboBox1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(0x71, 0x13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0xe0, 0x18);
            this.comboBox1.TabIndex = 0x36;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(7, 0x13);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x2c, 0x10);
            this.label9.TabIndex = 0x33;
            this.label9.Text = "Name";
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.ForeColor = SystemColors.Desktop;
            this.buttonSave.Location = new Point(0xbb, 0xb3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x1c);
            this.buttonSave.TabIndex = 0x26;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.textBoxNewCOntact.BackColor = SystemColors.HighlightText;
            this.textBoxNewCOntact.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNewCOntact.ForeColor = SystemColors.Desktop;
            this.textBoxNewCOntact.Location = new Point(0x71, 0x99);
            this.textBoxNewCOntact.Name = "textBoxNewCOntact";
            this.textBoxNewCOntact.ReadOnly = true;
            this.textBoxNewCOntact.Size = new Size(0x126, 0x17);
            this.textBoxNewCOntact.TabIndex = 0x24;
            this.textBoxNewAddress.BackColor = SystemColors.HighlightText;
            this.textBoxNewAddress.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNewAddress.ForeColor = SystemColors.Desktop;
            this.textBoxNewAddress.Location = new Point(0x71, 70);
            this.textBoxNewAddress.Multiline = true;
            this.textBoxNewAddress.Name = "textBoxNewAddress";
            this.textBoxNewAddress.ReadOnly = true;
            this.textBoxNewAddress.Size = new Size(0x126, 0x51);
            this.textBoxNewAddress.TabIndex = 0x23;
            this.textBoxNewName.BackColor = SystemColors.HighlightText;
            this.textBoxNewName.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxNewName.ForeColor = SystemColors.Desktop;
            this.textBoxNewName.Location = new Point(0x71, 0x2d);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.ReadOnly = true;
            this.textBoxNewName.Size = new Size(0x126, 0x17);
            this.textBoxNewName.TabIndex = 0x21;
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.ForeColor = SystemColors.Desktop;
            this.label11.Location = new Point(7, 0x99);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x3d, 0x10);
            this.label11.TabIndex = 0x1f;
            this.label11.Text = "Contact";
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.DarkSeaGreen;
            this.label12.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.ForeColor = SystemColors.Desktop;
            this.label12.Location = new Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new Size(60, 0x10);
            this.label12.TabIndex = 30;
            this.label12.Text = "Address";
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.DarkSeaGreen;
            this.label13.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.ForeColor = SystemColors.Desktop;
            this.label13.Location = new Point(6, 0x2d);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x2c, 0x10);
            this.label13.TabIndex = 0x1d;
            this.label13.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x356, 0xe3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "UpdateCustomer";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "UpdateCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_customer()
        {
            int num;
            string query = "SELECT * FROM firoz_center.tbl_customer t where type='2' order by name;";
            for (num = 0; num < 7; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(7L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBox1.Items.Add(this.Party[1].ElementAt<string>(num).ToString());
            }
        }

        private void save_transcation()
        {
            string query = "Update firoz_center.tbl_payment set customer_id='" + this.labelIDNew.Text + "' where memo_no='" + this.textBoxMemo.Text + "';";
            this.dbc.Update(query);
            string str2 = "Update firoz_center.tbl_sales_parts set customer_id='" + this.labelIDNew.Text + "' where memo_no='" + this.textBoxMemo.Text + "';";
            this.dbc.Update(str2);
            MessageBox.Show("Update Completed");
        }

        private void search()
        {
            string query = "Select customer_id from firoz_center.tbl_sales_parts where memo_no='" + this.textBoxMemo.Text + "';";
            string str2 = this.dbc.SelectSingle(query);
            this.labelId.Text = str2;
            this.textBoxName.Text = this.dbc.SelectSingle("Select name from firoz_center.tbl_customer  where customer_id='" + str2 + "';");
            this.textBoxAddress.Text = this.dbc.SelectSingle("Select address from firoz_center.tbl_customer  where customer_id='" + str2 + "';");
            this.textBoxContact.Text = this.dbc.SelectSingle("Select contact from firoz_center.tbl_customer  where customer_id='" + str2 + "';");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void textBoxMemo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

