namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class DuePaymentEditMotorCycle : Form
    {
        private Button button1;
        private Button buttonSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private IContainer components;
        private DataGridView dataGridView1;
        private DBConnect dbc;
        private GroupBox groupBox1;
        private Label label1;
        private Label label11;
        private Label label19;
        private Label label2;
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private long total;

        public DuePaymentEditMotorCycle()
        {
            this.dbc = new DBConnect();
            this.total = 0L;
            this.components = null;
            this.InitializeComponent();
        }

        public DuePaymentEditMotorCycle(string memo_no)
        {
            this.dbc = new DBConnect();
            this.total = 0L;
            this.components = null;
            this.InitializeComponent();
            this.textBoxMemoNo.Text = memo_no;
            this.textBoxMemoNo.Enabled = false;
            this.load_transcation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.load_transcation();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string str = this.total.ToString();
            string text = this.textBoxDue.Text;
            string query = "UPDATE firoz_center.tbl_sales_motorcycle set due_amount='" + text + "', paid_amount='" + str + "' where memo_no='" + this.textBoxMemoNo.Text + "';";
            this.dbc.Update(query);
            MessageBox.Show("Update Completed");
            base.Dispose();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string m = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string date = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string amount = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string text = this.textBoxMemoNo.Text;
            new UpdateDueMotorCycleAmount(m, date, amount, text).Show();
            base.Dispose();
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
            this.label19 = new Label();
            this.button1 = new Button();
            this.label11 = new Label();
            this.textBoxName = new TextBox();
            this.groupBox1 = new GroupBox();
            this.textBoxDue = new TextBox();
            this.label2 = new Label();
            this.dataGridView1 = new DataGridView();
            this.textBoxMemoNo = new TextBox();
            this.label1 = new Label();
            this.textBoxPrice = new TextBox();
            this.buttonSave = new Button();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(11, 0x42);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x27, 0x10);
            this.label19.TabIndex = 0x1a;
            this.label19.Text = "Price";
            this.button1.BackColor = Color.MediumSeaGreen;
            this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(0xde, 13);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 30);
            this.button1.TabIndex = 0x1c;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x43, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Memo No";
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(80, 0x2b);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(270, 0x16);
            this.textBoxName.TabIndex = 6;
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxDue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x170, 0x12e);
            this.groupBox1.TabIndex = 0x10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.textBoxDue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDue.Location = new Point(0xeb, 0x43);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new Size(0x73, 0x16);
            this.textBoxDue.TabIndex = 30;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0xc0, 70);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x21, 0x10);
            this.label2.TabIndex = 0x1f;
            this.label2.Text = "Due";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column3 });
            this.dataGridView1.Location = new Point(6, 0x5f);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(0x161, 0xc9);
            this.dataGridView1.TabIndex = 0x1d;
            this.dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(80, 0x13);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x6a, 0x16);
            this.textBoxMemoNo.TabIndex = 1;
            this.textBoxMemoNo.KeyDown += new KeyEventHandler(this.textBoxMemoNo_KeyDown);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(11, 0x2b);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 0x10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(80, 0x43);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new Size(0x6a, 0x16);
            this.textBoxPrice.TabIndex = 0x19;
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new Point(0x81, 0x137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x1d;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.Column1.HeaderText = "Memo No";
            this.Column1.Name = "Column1";
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x17a, 0x15a);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.groupBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "DuePaymentEditMotorCycle";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DuePaymentEditMotorCycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        private void load_transcation()
        {
            this.dataGridView1.Rows.Clear();
            string text = this.textBoxMemoNo.Text;
            string query = "Select grand_total,customer_id,type,due_amount from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Search Again!");
            }
            else
            {
                int num2;
                List<string>[] listArray = new List<string>[4];
                for (num2 = 0; num2 < 4; num2++)
                {
                    listArray[num2] = new List<string>();
                }
                listArray = this.dbc.Select(4L, query);
                if (listArray[0].Count == -1)
                {
                    MessageBox.Show("Search Again!");
                }
                else
                {
                    query = "Select name from firoz_center.tbl_customer where customer_id='" + listArray[1].ElementAt<string>(0) + "';";
                    string str3 = this.dbc.SelectSingle(query);
                    this.textBoxName.Text = str3;
                    query = "Select sale_rate from firoz_center.tbl_vehicle where memo_no='" + text + "';";
                    string str4 = this.dbc.SelectSingle(query);
                    this.textBoxPrice.Text = str4;
                    this.textBoxDue.Text = listArray[3].ElementAt<string>(0);
                    string str5 = "Select payment_id,DATE_FORMAT(date, '%Y-%m-%d') AS date1,amount FROM firoz_center.tbl_payment where memo_no='" + text + "';";
                    List<string>[] listArray2 = new List<string>[3];
                    for (num2 = 0; num2 < 3; num2++)
                    {
                        listArray2[num2] = new List<string>();
                    }
                    listArray2 = this.dbc.Select(3L, str5);
                    for (num2 = 0; num2 < listArray2[0].Count; num2++)
                    {
                        this.dataGridView1.Rows.Add(new object[] { listArray2[0].ElementAt<string>(num2), listArray2[1].ElementAt<string>(num2), listArray2[2].ElementAt<string>(num2) });
                        long num3 = long.Parse(listArray2[2].ElementAt<string>(num2));
                        this.total += num3;
                    }
                    this.dataGridView1.Rows.Add(new object[] { "", "Total", this.total });
                    this.textBoxDue.Text = (long.Parse(this.textBoxPrice.Text) - this.total).ToString();
                }
            }
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_transcation();
            }
        }
    }
}

