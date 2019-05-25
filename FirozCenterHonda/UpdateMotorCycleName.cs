namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class UpdateMotorCycleName : Form
    {
        private Button buttonSave;
        public ComboBox comboBoxBrand;
        public ComboBox comboBoxCC;
        public ComboBox comboBoxColor;
        public ComboBox comboBoxModel;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label13;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxBrand;
        private TextBox textBoxCC;
        private TextBox textBoxColor;
        private TextBox textBoxModel;

        public UpdateMotorCycleName()
        {
            this.InitializeComponent();
            this.load_brand();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (((this.textBoxBrand.Text.Equals("") || this.textBoxModel.Text.Equals("")) || this.textBoxColor.Text.Equals("")) || this.textBoxCC.Text.Equals(""))
                {
                    MessageBox.Show("Check Data Again");
                }
                else
                {
                    string query = "UPDATE firoz_center.tbl_vehicle_info set brand='" + this.textBoxBrand.Text + "', model='" + this.textBoxModel.Text + "', cc='" + this.textBoxCC.Text + "', color='" + this.textBoxColor.Text + "'  where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' and color='" + this.comboBoxColor.SelectedItem.ToString() + "';";
                    this.dbc.Update(query);
                    MessageBox.Show("Updated");
                    base.Dispose();
                }
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_model();
            this.textBoxBrand.Text = this.comboBoxBrand.SelectedItem.ToString();
        }

        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_color();
            this.textBoxCC.Text = this.comboBoxCC.SelectedItem.ToString();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxColor.Text = this.comboBoxColor.SelectedItem.ToString();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_cc();
            this.comboBoxCC.SelectedIndex = 0;
            this.textBoxModel.Text = this.comboBoxModel.SelectedItem.ToString();
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
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxCC = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textBoxColor);
            this.groupBox2.Controls.Add(this.textBoxCC);
            this.groupBox2.Controls.Add(this.textBoxModel);
            this.groupBox2.Controls.Add(this.textBoxBrand);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.comboBoxCC);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 260);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(60, 196);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(284, 22);
            this.textBoxColor.TabIndex = 22;
            // 
            // textBoxCC
            // 
            this.textBoxCC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCC.Location = new System.Drawing.Point(60, 146);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(284, 22);
            this.textBoxCC.TabIndex = 21;
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(60, 96);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(284, 22);
            this.textBoxModel.TabIndex = 20;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrand.Location = new System.Drawing.Point(60, 46);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(284, 22);
            this.textBoxBrand.TabIndex = 19;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(118, 224);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxColor.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(60, 170);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(284, 24);
            this.comboBoxColor.TabIndex = 13;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // comboBoxCC
            // 
            this.comboBoxCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCC.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Location = new System.Drawing.Point(60, 120);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new System.Drawing.Size(284, 24);
            this.comboBoxCC.TabIndex = 12;
            this.comboBoxCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCC_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(60, 70);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(284, 24);
            this.comboBoxModel.TabIndex = 11;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(60, 20);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(284, 24);
            this.comboBoxBrand.TabIndex = 10;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "CC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Brand";
            // 
            // UpdateMotorCycleName
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(363, 269);
            this.Controls.Add(this.groupBox2);
            this.Name = "UpdateMotorCycleName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMotorCycleName";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void load_brand()
        {
            int num;
            this.comboBoxBrand.Items.Clear();
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.textBoxBrand.Text = "";
            this.textBoxModel.Text = "";
            this.textBoxCC.Text = "";
            this.textBoxColor.Text = "";
            string query = "SELECT brand FROM firoz_center.tbl_vehicle_info t group by brand;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxBrand.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_cc()
        {
            int num;
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.textBoxCC.Text = "";
            this.textBoxColor.Text = "";
            string query = "SELECT cc FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' group by cc;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxCC.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_color()
        {
            int num;
            this.comboBoxColor.Items.Clear();
            this.textBoxColor.Text = "";
            string query = "SELECT color FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' and model = '" + this.comboBoxModel.SelectedItem.ToString() + "' and cc = '" + this.comboBoxCC.SelectedItem.ToString() + "' group by color;";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                this.comboBoxColor.Items.Add(listArray[0].ElementAt<string>(num).ToString());
            }
        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            this.comboBoxCC.Items.Clear();
            this.comboBoxColor.Items.Clear();
            this.textBoxModel.Text = "";
            this.textBoxCC.Text = "";
            this.textBoxColor.Text = "";
            string query = "SELECT model FROM firoz_center.tbl_vehicle_info t where brand = '" + this.comboBoxBrand.SelectedItem.ToString() + "' group by model;";
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
    }
}

