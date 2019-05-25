namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class EditPriceService : Form
    {
        private Button buttonSave;
        public ComboBox comboBoxService;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label labelId;
        private List<string>[] Service = new List<string>[3];
        private TextBox textBoxCharge;

        public EditPriceService()
        {
            this.InitializeComponent();
            this.load_service();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save change?", "Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.textBoxCharge.Text.Equals(""))
                {
                    MessageBox.Show("Check Data");
                }
                else
                {
                    this.save_transcation();
                }
            }
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxCharge.Text = this.Service[1].ElementAt<string>(this.comboBoxService.SelectedIndex);
            this.labelId.Text = this.Service[2].ElementAt<string>(this.comboBoxService.SelectedIndex);
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
            this.textBoxCharge = new TextBox();
            this.label3 = new Label();
            this.label1 = new Label();
            this.comboBoxService = new ComboBox();
            this.labelId = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x8f, 0x40);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.comboBoxService);
            this.groupBox1.Controls.Add(this.textBoxCharge);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x193, 0x65);
            this.groupBox1.TabIndex = 0x2a;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Service";
            this.textBoxCharge.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCharge.Location = new Point(0x61, 40);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new Size(0x129, 0x16);
            this.textBoxCharge.TabIndex = 0x2c;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x29);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x34, 0x10);
            this.label3.TabIndex = 0x29;
            this.label3.Text = "Charge";
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(10, 0x12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x36, 0x10);
            this.label1.TabIndex = 0x27;
            this.label1.Text = "Service";
            this.comboBoxService.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxService.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxService.BackColor = SystemColors.Window;
            this.comboBoxService.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new Point(0x61, 14);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new Size(0x129, 0x18);
            this.comboBoxService.TabIndex = 0x2d;
            this.comboBoxService.SelectedIndexChanged += new EventHandler(this.comboBoxService_SelectedIndexChanged);
            this.labelId.AutoSize = true;
            this.labelId.BackColor = Color.DarkSeaGreen;
            this.labelId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelId.Location = new Point(0x156, 0x47);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(0x34, 0x10);
            this.labelId.TabIndex = 0x2e;
            this.labelId.Text = "Charge";
            this.labelId.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x19c, 0x6f);
            base.Controls.Add(this.groupBox1);
            base.Name = "EditPriceService";
            this.Text = "EditPriceService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_service()
        {
            int num;
            this.comboBoxService.Items.Clear();
            string query = "SELECT name,charge,service_id FROM firoz_center.tbl_service_charge;";
            for (num = 0; num < 3; num++)
            {
                this.Service[num] = new List<string>();
            }
            this.Service = this.dbc.Select(3L, query);
            for (num = 0; num < this.Service[0].Count; num++)
            {
                this.comboBoxService.Items.Add(this.Service[0].ElementAt<string>(num).ToString());
            }
        }

        private void save_transcation()
        {
            string text = this.labelId.Text;
            string str2 = this.textBoxCharge.Text;
            string query = "Update firoz_center.tbl_service_charge set charge='" + str2 + "' where service_id='" + text + "';";
            this.dbc.Update(query);
            MessageBox.Show("Updated");
            base.Dispose();
            new EditPriceService().Show();
        }
    }
}

