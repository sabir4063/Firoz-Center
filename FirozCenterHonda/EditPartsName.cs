namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class EditPartsName : Form
    {
        private Button buttonUpdate;
        public ComboBox comboBoxDescip;
        public ComboBox comboBoxModel;
        public ComboBox comboBoxPartsNo;
        public ComboBox comboBoxParty;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label1;
        private Label label17;
        private Label label5;
        private Label label6;
        private List<string>[] Party = new List<string>[1];
        private TextBox textBoxDes;
        private TextBox textBoxModel;
        private TextBox textBoxNo;
        private TextBox textBoxParty;

        public EditPartsName()
        {
            this.InitializeComponent();
            this.load_party();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update name?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if ((this.textBoxNo.Text.Equals("") || this.textBoxDes.Text.Equals("")) || this.textBoxModel.Text.Equals(""))
                {
                    MessageBox.Show("Check Data Again");
                }
                else
                {
                    this.save_transcation();
                }
            }
        }

        private void comboBoxDescip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxPartsNo.SelectedIndex = this.comboBoxDescip.SelectedIndex;
            this.load_name();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {            
            this.textBoxModel.Text = this.comboBoxModel.SelectedItem.ToString();
            this.load_description_Parts();
        }

        private void comboBoxPartsNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDescip.SelectedIndex = this.comboBoxPartsNo.SelectedIndex;
            this.load_name();
        }

        private void comboBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {           
            this.textBoxParty.Text = this.comboBoxParty.SelectedItem.ToString();
            this.load_model();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxParty = new System.Windows.Forms.TextBox();
            this.comboBoxParty = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxDescip = new System.Windows.Forms.ComboBox();
            this.comboBoxPartsNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxParty);
            this.groupBox2.Controls.Add(this.comboBoxParty);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxDes);
            this.groupBox2.Controls.Add(this.textBoxNo);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.comboBoxDescip);
            this.groupBox2.Controls.Add(this.comboBoxPartsNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 257);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Price";
            // 
            // textBoxParty
            // 
            this.textBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParty.Location = new System.Drawing.Point(92, 43);
            this.textBoxParty.Name = "textBoxParty";
            this.textBoxParty.Size = new System.Drawing.Size(250, 22);
            this.textBoxParty.TabIndex = 103;
            // 
            // comboBoxParty
            // 
            this.comboBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(92, 18);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(250, 24);
            this.comboBoxParty.TabIndex = 1;
            this.comboBoxParty.SelectedIndexChanged += new System.EventHandler(this.comboBoxParty_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 16);
            this.label17.TabIndex = 102;
            this.label17.Text = "Group";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(92, 91);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(250, 22);
            this.textBoxModel.TabIndex = 77;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(92, 66);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(250, 24);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Model";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDes.Location = new System.Drawing.Point(92, 187);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(250, 22);
            this.textBoxDes.TabIndex = 74;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNo.Location = new System.Drawing.Point(92, 139);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(250, 22);
            this.textBoxNo.TabIndex = 73;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(117, 217);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 30);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxDescip
            // 
            this.comboBoxDescip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDescip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDescip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxDescip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDescip.FormattingEnabled = true;
            this.comboBoxDescip.Location = new System.Drawing.Point(92, 162);
            this.comboBoxDescip.Name = "comboBoxDescip";
            this.comboBoxDescip.Size = new System.Drawing.Size(250, 24);
            this.comboBoxDescip.TabIndex = 9;
            this.comboBoxDescip.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescip_SelectedIndexChanged);
            // 
            // comboBoxPartsNo
            // 
            this.comboBoxPartsNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPartsNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPartsNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxPartsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPartsNo.FormattingEnabled = true;
            this.comboBoxPartsNo.Location = new System.Drawing.Point(92, 114);
            this.comboBoxPartsNo.Name = "comboBoxPartsNo";
            this.comboBoxPartsNo.Size = new System.Drawing.Size(250, 24);
            this.comboBoxPartsNo.TabIndex = 3;
            this.comboBoxPartsNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartsNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parts No";
            // 
            // EditPartsName
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(363, 268);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditPartsName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPartName";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void load_description_Parts()
        {
            int num;
            this.comboBoxDescip.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.textBoxDes.Text = "";
            this.textBoxNo.Text = "";
            string query = "SELECT description,partsNo FROM firoz_center.tbl_parts_info t where `group`='" + this.textBoxParty.Text + "' group by description,partsNo;";
            List<string>[] listArray = new List<string>[2];
            for (num = 0; num < 2; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(2L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxDescip.Items.Add(listArray[0].ElementAt<string>(num).ToString());
                this.comboBoxPartsNo.Items.Add(listArray[1].ElementAt<string>(num).ToString());
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.textBoxModel.Text = "";
            string query = "SELECT model FROM firoz_center.tbl_parts_info t where `group`='" + this.textBoxParty.Text + "' group by model;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxModel.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_name()
        {
            this.textBoxDes.Text = this.comboBoxDescip.SelectedItem.ToString();
            this.textBoxNo.Text = this.comboBoxPartsNo.SelectedItem.ToString();
        }

        public void load_party()
        {
            int num;
            this.comboBoxParty.Items.Clear();
            this.comboBoxPartsNo.Items.Clear();
            this.comboBoxDescip.Items.Clear();
            string query = "SELECT `group` FROM firoz_center.tbl_parts_info group by `group`;";
            for (num = 0; num < 1; num++)
            {
                this.Party[num] = new List<string>();
            }
            this.Party = this.dbc.Select(1L, query);
            for (num = 0; num < this.Party[0].Count; num++)
            {
                this.comboBoxParty.Items.Add(this.Party[0].ElementAt<string>(num).ToString());
            }
        }

        private void save_transcation()
        {
            string text = this.textBoxParty.Text;
            string str2 = this.textBoxNo.Text;
            string str3 = this.textBoxDes.Text;
            string str4 = this.textBoxModel.Text;
            string query = "UPDATE firoz_center.tbl_parts_info set `group`='" + text + "', model='" + str4 + "', description='" + str3 + "', partsNo='" + str2 + "' where `group`='" + this.comboBoxParty.SelectedItem.ToString() + "' and description='" + this.comboBoxDescip.SelectedItem.ToString() + "' and partsNo='" + this.comboBoxPartsNo.SelectedItem.ToString() + "';";
            this.dbc.Update(query);
            MessageBox.Show("Updated");
            this.load_party();
        }
    }
}

