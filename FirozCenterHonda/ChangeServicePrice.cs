namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class ChangeServicePrice : Form
    {
        private Button buttonUpdate;
        public ComboBox comboBoxService;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox2;
        private Label label1;
        private Label label10;
        private Label label8;
        private Label labelId;
        private List<string>[] Service = new List<string>[4];
        private TextBox textBoxCurrentPrice;
        private TextBox textBoxDescription;
        private TextBox textBoxService;

        public ChangeServicePrice()
        {
            this.InitializeComponent();
            this.load_service();
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            string query = "update firoz_center.tbl_service_charge t set charge='" + this.textBoxCurrentPrice.Text + "', description='" + this.textBoxDescription.Text + "', name='" + this.textBoxService.Text + "' where service_id='" + this.labelId.Text + "';";
            this.dbc.Update(query);
            this.textBoxService.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxCurrentPrice.Text = "";
            this.labelId.Text = "";
            this.load_service();
            MessageBox.Show("Service Updated");
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxCurrentPrice.Text = this.Service[1].ElementAt<string>(this.comboBoxService.SelectedIndex);
            this.textBoxService.Text = this.Service[0].ElementAt<string>(this.comboBoxService.SelectedIndex);
            this.textBoxDescription.Text = this.Service[3].ElementAt<string>(this.comboBoxService.SelectedIndex);
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
            this.groupBox2 = new GroupBox();
            this.labelId = new Label();
            this.textBoxDescription = new TextBox();
            this.label1 = new Label();
            this.textBoxService = new TextBox();
            this.buttonUpdate = new Button();
            this.textBoxCurrentPrice = new TextBox();
            this.label10 = new Label();
            this.comboBoxService = new ComboBox();
            this.label8 = new Label();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.labelId);
            this.groupBox2.Controls.Add(this.textBoxDescription);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxService);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.textBoxCurrentPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x183, 240);
            this.groupBox2.TabIndex = 0x24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Service";
            this.labelId.AutoSize = true;
            this.labelId.BackColor = Color.DarkSeaGreen;
            this.labelId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelId.Location = new Point(0x131, 0xd1);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(0x34, 0x10);
            this.labelId.TabIndex = 0x12;
            this.labelId.Text = "Charge";
            this.labelId.Visible = false;
            this.textBoxDescription.BackColor = SystemColors.Window;
            this.textBoxDescription.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDescription.Location = new Point(0x59, 0x48);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new Size(290, 0x63);
            this.textBoxDescription.TabIndex = 0x11;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(12, 0x48);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4c, 0x10);
            this.label1.TabIndex = 0x10;
            this.label1.Text = "Description";
            this.textBoxService.BackColor = SystemColors.Window;
            this.textBoxService.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxService.Location = new Point(0x59, 0x2f);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new Size(290, 0x17);
            this.textBoxService.TabIndex = 15;
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0x8e, 0xca);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(120, 30);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.buttonAddInvoice_Click);
            this.textBoxCurrentPrice.BackColor = SystemColors.Window;
            this.textBoxCurrentPrice.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxCurrentPrice.Location = new Point(0x59, 0xad);
            this.textBoxCurrentPrice.Name = "textBoxCurrentPrice";
            this.textBoxCurrentPrice.Size = new Size(290, 0x17);
            this.textBoxCurrentPrice.TabIndex = 13;
            this.label10.AutoSize = true;
            this.label10.BackColor = Color.DarkSeaGreen;
            this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(12, 0xad);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x34, 0x10);
            this.label10.TabIndex = 11;
            this.label10.Text = "Charge";
            this.comboBoxService.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxService.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxService.BackColor = SystemColors.Window;
            this.comboBoxService.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new Point(0x59, 0x15);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new Size(290, 0x18);
            this.comboBoxService.TabIndex = 6;
            this.comboBoxService.SelectedIndexChanged += new EventHandler(this.comboBoxService_SelectedIndexChanged);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(12, 0x15);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x36, 0x10);
            this.label8.TabIndex = 0;
            this.label8.Text = "Service";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x18c, 0xf9);
            base.Controls.Add(this.groupBox2);
            base.Name = "ChangeServicePrice";
            this.Text = "Change Service Price";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        public void load_service()
        {
            int num;
            this.comboBoxService.Items.Clear();
            string query = "SELECT name,charge,service_id,description FROM firoz_center.tbl_service_charge;";
            for (num = 0; num < 4; num++)
            {
                this.Service[num] = new List<string>();
            }
            this.Service = this.dbc.Select(4L, query);
            for (num = 0; num < this.Service[0].Count; num++)
            {
                this.comboBoxService.Items.Add(this.Service[0].ElementAt<string>(num).ToString());
            }
            this.comboBoxService.Refresh();
        }
    }
}

