namespace FirozCenterHonda
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public class StockReportMotorCycleMonthly : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonPrint;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label1;
        private Label label12;
        private Panel panel1;
        private RadioButton radioButtonDisplay;
        private RadioButton radioButtonStock;
        private RadioButton radioButtonStore;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private Button buttonSave;
        private RadioButton radioButtonActive;
        private StringFormat strFormat;

        public StockReportMotorCycleMonthly()
        {
            this.InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print report?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.load_stock();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplay = new System.Windows.Forms.RadioButton();
            this.radioButtonStock = new System.Windows.Forms.RadioButton();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Start";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(266, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 27);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "End";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column5,
            this.Column8,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(8, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 455);
            this.dataGridView1.TabIndex = 42;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 250F;
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Opening";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 110F;
            this.Column1.HeaderText = "Received";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Sale";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Closing";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 500);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Stock Report";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(420, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 50;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonActive);
            this.panel1.Controls.Add(this.radioButtonStore);
            this.panel1.Controls.Add(this.radioButtonDisplay);
            this.panel1.Controls.Add(this.radioButtonStock);
            this.panel1.Location = new System.Drawing.Point(501, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 21);
            this.panel1.TabIndex = 49;
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Location = new System.Drawing.Point(148, 1);
            this.radioButtonStore.Name = "radioButtonStore";
            this.radioButtonStore.Size = new System.Drawing.Size(50, 17);
            this.radioButtonStore.TabIndex = 4;
            this.radioButtonStore.TabStop = true;
            this.radioButtonStore.Text = "Store";
            this.radioButtonStore.UseVisualStyleBackColor = true;
            this.radioButtonStore.CheckedChanged += new System.EventHandler(this.radioButtonStore_CheckedChanged);
            // 
            // radioButtonDisplay
            // 
            this.radioButtonDisplay.AutoSize = true;
            this.radioButtonDisplay.Location = new System.Drawing.Point(61, 1);
            this.radioButtonDisplay.Name = "radioButtonDisplay";
            this.radioButtonDisplay.Size = new System.Drawing.Size(83, 17);
            this.radioButtonDisplay.TabIndex = 3;
            this.radioButtonDisplay.TabStop = true;
            this.radioButtonDisplay.Text = "Show Room";
            this.radioButtonDisplay.UseVisualStyleBackColor = true;
            this.radioButtonDisplay.CheckedChanged += new System.EventHandler(this.radioButtonDisplay_CheckedChanged);
            // 
            // radioButtonStock
            // 
            this.radioButtonStock.AutoSize = true;
            this.radioButtonStock.Location = new System.Drawing.Point(5, 1);
            this.radioButtonStock.Name = "radioButtonStock";
            this.radioButtonStock.Size = new System.Drawing.Size(53, 17);
            this.radioButtonStock.TabIndex = 1;
            this.radioButtonStock.TabStop = true;
            this.radioButtonStock.Text = "Stock";
            this.radioButtonStock.UseVisualStyleBackColor = true;
            this.radioButtonStock.CheckedChanged += new System.EventHandler(this.radioButtonStock_CheckedChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(343, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 27);
            this.buttonPrint.TabIndex = 46;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Location = new System.Drawing.Point(204, 2);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(55, 17);
            this.radioButtonActive.TabIndex = 5;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Active";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            this.radioButtonActive.CheckedChanged += new System.EventHandler(this.radioButtonActive_CheckedChanged);
            // 
            // StockReportMotorCycleMonthly
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(777, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockReportMotorCycleMonthly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report MotorCycle Monthly";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void load_stock()
        {
            int num7;
            this.dataGridView1.Rows.Clear();
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where (brand='HONDA' or brand = 'honda') order by cc,model asc;";
            List<string>[] listArray = new List<string>[1];
            for (num7 = 0; num7 < 1; num7++)
            {
                listArray[num7] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num7 = 0; num7 < listArray[0].Count; num7++)
            {
                string str4 = listArray[0].ElementAt<string>(num7);
                string str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                string s = this.dbc.SelectSingle(str5);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str + "');";
                string str7 = this.dbc.SelectSingle(str5);
                int num8 = int.Parse(s);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "');";
                string str8 = this.dbc.SelectSingle(str5);
                int num9 = num8 - int.Parse(str8);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                string str9 = num9.ToString();
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date between '" + str + "' and '" + str2 + "');";
                string str10 = this.dbc.SelectSingle(str5);
                int num10 = int.Parse(str9) + int.Parse(str10);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                string str11 = this.dbc.SelectSingle(str5);
                str5 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str5);
                string str12 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str12 = str12 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str13 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str4 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str13);
                int num12 = num10 - int.Parse(str11);
                num += num12;
                this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), num9, str10, num10, str11, num12 });
                num2 += int.Parse(str9);
                num3 += int.Parse(str10);
                num6 += num10;
                num5 += int.Parse(str11);
                num4 += num12;
            }
            this.dataGridView1.Rows.Add(new object[] { "", "Total: ", num2, num3, num6, num5, num });
        }

        private void load_stock_active()
        {
            int num7;
            this.dataGridView1.Rows.Clear();
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string str2 = this.dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info where (brand='HONDA' or brand = 'honda') order by cc,model asc;";
            List<string>[] listArray = new List<string>[1];
            for (num7 = 0; num7 < 1; num7++)
            {
                listArray[num7] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            for (num7 = 0; num7 < listArray[0].Count; num7++)
            {
                string str4 = listArray[0].ElementAt<string>(num7);
                string str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                string s = this.dbc.SelectSingle(str5);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date <'" + str + "');";
                string str7 = this.dbc.SelectSingle(str5);
                int num8 = int.Parse(s);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date <'" + str + "');";
                string str8 = this.dbc.SelectSingle(str5);
                int num9 = num8 - int.Parse(str8);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and (invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))";
                string str9 = num9.ToString();
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date between '" + str + "' and '" + str2 + "');";
                string str10 = this.dbc.SelectSingle(str5);
                int num10 = int.Parse(str9) + int.Parse(str10);
                str5 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                string str11 = this.dbc.SelectSingle(str5);
                str5 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str4 + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date between '" + str + "' and '" + str2 + "');";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str5);
                string str12 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str12 = str12 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str13 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str4 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str13);
                int num12 = num10 - int.Parse(str11);
                num += num12;
                
                if (num9 == 0 && num10 == 0 && num12 == 0 && str10.Equals("0") && str11.Equals("0"))
                    continue;
                else
                    this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), num9, str10, num10, str11, num12 });

                num2 += int.Parse(str9);
                num3 += int.Parse(str10);
                num6 += num10;
                num5 += int.Parse(str11);
                num4 += num12;
            }

            this.dataGridView1.Rows.Add(new object[] { "", "Total: ", num2, num3, num6, num5, num });
        }

        private void load_stock(string status)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string str = this.dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string query = "SELECT vehicle_id FROM firoz_center.tbl_vehicle_info order by cc,model asc";
            List<string>[] listArray = new List<string>[1];
            for (num = 0; num < 1; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(1L, query);
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str3 = listArray[0].ElementAt<string>(num);
                string str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and ((status like 'stock' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date<'" + str + "'))or (status like 'sold' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' )));";
                string s = this.dbc.SelectSingle(str4);
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and invoice_no in (SELECT invoice_no FROM firoz_center.tbl_purchase t where purchase_date ='" + str + "' );";
                string str6 = this.dbc.SelectSingle(str4);
                int num8 = int.Parse(s) + int.Parse(str6);
                str4 = "SELECT count(*) FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                string str7 = this.dbc.SelectSingle(str4);
                str4 = "SELECT memo_no FROM firoz_center.tbl_vehicle t where vehicleid='" + str3 + "' and comments='" + status + "' and memo_no in (SELECT memo_no FROM firoz_center.tbl_sales_motorcycle t where date ='" + str + "' );";
                List<string>[] listArray2 = new List<string>[1];
                int index = 0;
                while (index < 1)
                {
                    listArray2[index] = new List<string>();
                    index++;
                }
                listArray2 = this.dbc.Select(1L, str4);
                string str8 = "";
                index = 0;
                while (index < listArray2[0].Count)
                {
                    str8 = str8 + listArray2[0].ElementAt<string>(index) + ",";
                    index++;
                }
                string str9 = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str3 + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (index = 0; index < 4; index++)
                {
                    listArray3[index] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, str9);
                int num10 = num8 - int.Parse(str7);
                this.dataGridView1.Rows.Add(new object[] { listArray3[1].ElementAt<string>(0), listArray3[3].ElementAt<string>(0), s, str6, num8, str7, str8, num10 });
                num3 += int.Parse(s);
                num4 += int.Parse(str6);
                num7 += num8;
                num6 += int.Parse(str7);
                num5 += num10;
                num2 += num10;
            }
            this.dataGridView1.Rows.Add(new object[] { "", "Total: ", num3, num4, num7, num6, "", num2 });
        }

        private void print_preview()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            document.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                this.strFormat = new StringFormat();
                this.strFormat.Alignment = StringAlignment.Near;
                this.strFormat.LineAlignment = StringAlignment.Center;
                this.strFormat.Trimming = StringTrimming.EllipsisCharacter;
                this.arrColumnLefts.Clear();
                this.arrColumnWidths.Clear();
                this.iCellHeight = 0;
                this.iRow = 0;
                this.bFirstPage = true;
                this.bNewPage = true;
                this.iTotalWidth = 0;
                foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                {
                    this.iTotalWidth += column.Width;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int num = 20;
                int y = 10;
                bool flag = false;
                int width = 0;
                if (this.bFirstPage)
                {
                    foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                    {
                        width = (int) (Math.Floor((double) ((((column.Width - 5.0) / ((double) this.iTotalWidth)) * this.iTotalWidth) * (((double) e.MarginBounds.Width) / ((double) this.iTotalWidth)))) * 1.25);
                        this.iHeaderHeight = ((int) e.Graphics.MeasureString(column.HeaderText, column.InheritedStyle.Font, width).Height) + 11;
                        this.arrColumnLefts.Add(num);
                        this.arrColumnWidths.Add(width);
                        num += width;
                    }
                }
                while (this.iRow <= (this.dataGridView1.Rows.Count - 1))
                {
                    DataGridViewRow row = this.dataGridView1.Rows[this.iRow];
                    this.iCellHeight = row.Height + 5;
                    int num4 = 0;
                    if ((y + this.iCellHeight) >= (e.MarginBounds.Height + e.MarginBounds.Top))
                    {
                        this.bNewPage = true;
                        this.bFirstPage = false;
                        flag = true;
                        break;
                    }
                    if (this.bNewPage)
                    {
                        Font font = new Font("Serpentine-Bold", 18f, FontStyle.Bold);
                        Font font2 = new Font("Serpentine-Bold", 14f);
                        Font font3 = new Font("Serpentine-Bold", 8f);
                        Font font4 = new Font("Serpentine-Bold", 10f);
                        StringFormat format = new StringFormat();
                        SolidBrush brush = new SolidBrush(Color.Black);
                        this.sfMiddle.Alignment = StringAlignment.Center;
                        this.sfMiddle.LineAlignment = StringAlignment.Center;
                        this.sfLeft.Alignment = StringAlignment.Near;
                        this.sfLeft.LineAlignment = StringAlignment.Center;
                        this.sfRight.Alignment = StringAlignment.Far;
                        this.sfRight.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        string str2 = this.dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        string str3 = this.dateTimePicker2.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("Monthly Stock Report: Motor Cycle", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Range:" + str2 + " to " + str3, font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), format);
                        y = e.MarginBounds.Top;
                        foreach (DataGridViewColumn column in this.dataGridView1.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iHeaderHeight));
                            e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iHeaderHeight), this.sfMiddle);
                            num4++;
                        }
                        this.bNewPage = false;
                        y += this.iHeaderHeight;
                    }
                    num4 = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) ((int) this.arrColumnLefts[num4]), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sfMiddle);
                        }
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int) this.arrColumnLefts[num4], y, (int) this.arrColumnWidths[num4], this.iCellHeight));
                        num4++;
                    }
                    this.iRow++;
                    y += this.iCellHeight;
                }
                if (flag)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void radioButtonDisplay_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock("showroom");
        }

        private void radioButtonStock_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock();
        }

        private void radioButtonStore_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock("stock");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                dbc.ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        private void radioButtonActive_CheckedChanged(object sender, EventArgs e)
        {
            this.load_stock_active();
        }
    }
}

