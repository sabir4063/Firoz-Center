namespace FirozCenterHonda
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public class UpdateDueMotorCycleAmount : Form
    {
        private Button buttonUpdate;
        private IContainer components = null;
        private DateTimePicker dateTimePicker1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private Label label19;
        private Label label2;
        private string m = "";
        private string memo_no = "";
        private string t_id = "";
        private TextBox textBoxPrice;

        public UpdateDueMotorCycleAmount(string m, string date, string amount, string memo_no)
        {
            this.InitializeComponent();
            this.m = m;
            this.memo_no = memo_no;
            this.textBoxPrice.Text = amount;
            this.dateTimePicker1.Value = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Select id from firoz_center.tbl_transcation where debit='" + amount + "' and date='" + date + "' and memo_no='" + memo_no + "';";
            this.t_id = this.dbc.SelectSingle(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "Update firoz_center.tbl_payment set amount = '" + this.textBoxPrice.Text + "', date='" + str + "' where payment_id='" + this.m + "';";
            this.dbc.Update(query);
            query = "Update firoz_center.tbl_transcation set debit = '" + this.textBoxPrice.Text + "', date='" + str + "' where id='" + this.t_id + "';";
            this.dbc.Update(query);
            MessageBox.Show("Update Completed");
            base.Dispose();
            new DuePaymentEditMotorCycle(this.memo_no).Show();
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
            this.label2 = new Label();
            this.buttonUpdate = new Button();
            this.textBoxPrice = new TextBox();
            this.label19 = new Label();
            this.dateTimePicker1 = new DateTimePicker();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x143, 0x52);
            this.groupBox1.TabIndex = 0x11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0xb5, 0x13);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x25, 0x10);
            this.label2.TabIndex = 0x1f;
            this.label2.Text = "Date";
            this.buttonUpdate.BackColor = Color.MediumSeaGreen;
            this.buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonUpdate.Location = new Point(0x65, 0x2b);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new Size(120, 30);
            this.buttonUpdate.TabIndex = 0x1c;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new EventHandler(this.button1_Click);
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(0x45, 0x10);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new Size(0x6a, 0x16);
            this.textBoxPrice.TabIndex = 0x19;
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0x13);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x35, 0x10);
            this.label19.TabIndex = 0x1a;
            this.label19.Text = "Amount";
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(0xe1, 0x10);
            this.dateTimePicker1.Margin = new Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(90, 0x16);
            this.dateTimePicker1.TabIndex = 0x12;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DarkSeaGreen;
            base.ClientSize = new Size(0x14d, 0x5d);
            base.Controls.Add(this.groupBox1);
            base.Name = "UpdateDueAmount";
            this.Text = "UpdateDueAmount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

