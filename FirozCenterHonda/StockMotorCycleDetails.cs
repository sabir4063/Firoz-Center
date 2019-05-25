namespace FirozCenterHonda
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Linq;
    using System.Windows.Forms;

    public class StockMotorCycleDetails : Form
    {
        private ArrayList arrColumnLefts = new ArrayList();
        private ArrayList arrColumnWidths = new ArrayList();
        private bool bFirstPage = false;
        private bool bNewPage = false;
        private Button buttonPrint;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        public ComboBox comboBoxModel;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox3;
        private int iCellHeight = 0;
        private int iHeaderHeight = 0;
        private int iRow = 0;
        private int iTotalWidth = 0;
        private Label label1;
        private Label label7;
        private Panel panel1;
        private RadioButton radioButtonAll;
        private RadioButton radioButtonDisplay;
        private RadioButton radioButtonSold;
        private RadioButton radioButtonStock;
        private RadioButton radioButtonStore;
        private StringFormat sf = new StringFormat();
        private StringFormat sfLeft = new StringFormat();
        private StringFormat sfMiddle = new StringFormat();
        private StringFormat sfRight = new StringFormat();
        private StringFormat strFormat;
        private int tag = 0;
        private Button buttonSave;
        private TextBox textBoxQuantity;

        public StockMotorCycleDetails()
        {
            this.InitializeComponent();
            this.load_stock();
            this.load_model();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print report?", "Print", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
            }
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tag = 1;
            this.dataGridView1.Rows.Clear();
            this.radioButtonAll.Checked = false;
            this.radioButtonSold.Checked = false;
            this.radioButtonStock.Checked = false;
            this.textBoxQuantity.Text = "";
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplay = new System.Windows.Forms.RadioButton();
            this.radioButtonSold = new System.Windows.Forms.RadioButton();
            this.radioButtonStock = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column1,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Location = new System.Drawing.Point(9, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column2
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Color";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column1
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column1.HeaderText = "Engine No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column6
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column6.HeaderText = "Chassis No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column5
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column5.HeaderText = "BHL Invoice No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Memo No";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1297, 481);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor Cycle Stock";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(74, 7);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(266, 24);
            this.comboBoxModel.TabIndex = 29;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Model";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonStore);
            this.panel1.Controls.Add(this.radioButtonDisplay);
            this.panel1.Controls.Add(this.radioButtonSold);
            this.panel1.Controls.Add(this.radioButtonStock);
            this.panel1.Controls.Add(this.radioButtonAll);
            this.panel1.Location = new System.Drawing.Point(348, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 21);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Location = new System.Drawing.Point(276, 1);
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
            this.radioButtonDisplay.Location = new System.Drawing.Point(184, 1);
            this.radioButtonDisplay.Name = "radioButtonDisplay";
            this.radioButtonDisplay.Size = new System.Drawing.Size(83, 17);
            this.radioButtonDisplay.TabIndex = 3;
            this.radioButtonDisplay.TabStop = true;
            this.radioButtonDisplay.Text = "Show Room";
            this.radioButtonDisplay.UseVisualStyleBackColor = true;
            this.radioButtonDisplay.CheckedChanged += new System.EventHandler(this.radioButtonDisplay_CheckedChanged);
            // 
            // radioButtonSold
            // 
            this.radioButtonSold.AutoSize = true;
            this.radioButtonSold.Location = new System.Drawing.Point(122, 1);
            this.radioButtonSold.Name = "radioButtonSold";
            this.radioButtonSold.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSold.TabIndex = 2;
            this.radioButtonSold.TabStop = true;
            this.radioButtonSold.Text = "Sold";
            this.radioButtonSold.UseVisualStyleBackColor = true;
            this.radioButtonSold.CheckedChanged += new System.EventHandler(this.radioButtonStcok_CheckedChanged);
            // 
            // radioButtonStock
            // 
            this.radioButtonStock.AutoSize = true;
            this.radioButtonStock.Location = new System.Drawing.Point(60, 1);
            this.radioButtonStock.Name = "radioButtonStock";
            this.radioButtonStock.Size = new System.Drawing.Size(53, 17);
            this.radioButtonStock.TabIndex = 1;
            this.radioButtonStock.TabStop = true;
            this.radioButtonStock.Text = "Stock";
            this.radioButtonStock.UseVisualStyleBackColor = true;
            this.radioButtonStock.CheckedChanged += new System.EventHandler(this.radioButtonStock_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(4, 1);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(776, 9);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(162, 20);
            this.textBoxQuantity.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Quantity";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonPrint.Location = new System.Drawing.Point(966, 8);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 33;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSave.Location = new System.Drawing.Point(1060, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // StockMotorCycleDetails
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1309, 520);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Name = "StockMotorCycleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockMOtorCycleDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void load_model()
        {
            int num;
            this.comboBoxModel.Items.Clear();
            string query = "SELECT model FROM firoz_center.tbl_vehicle_info t where brand = 'Honda' group by model;";
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

        private void load_stock()
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string query = "select vehicleId,engine_no,chasis_no,invoice_no from firoz_center.tbl_vehicle where status='stock'";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(4L, query);
            int num2 = 0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = listArray[0].ElementAt<string>(num);
                string str3 = listArray[1].ElementAt<string>(num);
                string str4 = "Select brand,model, cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str2 + "';";
                List<string>[] listArray2 = new List<string>[4];
                for (int i = 0; i < 4; i++)
                {
                    listArray2[i] = new List<string>();
                }
                listArray2 = this.dbc.Select(4L, str4);
                this.dataGridView1.Rows.Add(new object[] { listArray2[1].ElementAt<string>(0), listArray2[2].ElementAt<string>(0), listArray2[3].ElementAt<string>(0), listArray[1].ElementAt<string>(num), listArray[2].ElementAt<string>(num), listArray[3].ElementAt<string>(num) });
                num2++;
            }
            this.textBoxQuantity.Text = num2.ToString();
        }

        private void load_stock(string model, string type)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string query = "select vehicleId,engine_no,chasis_no,invoice_no from firoz_center.tbl_vehicle where status='" + type + "'";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(4L, query);
            int num2 = 0;
            for (num = 0; num < listArray[0].Count; num++)
            {
  
                string str2 = listArray[0].ElementAt<string>(num);
                string str3 = listArray[1].ElementAt<string>(num);
                string str4 = "Select brand,model, cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str2 + "';";
                List<string>[] listArray2 = new List<string>[4];

                for (int i = 0; i < 4; i++)
                {
                    listArray2[i] = new List<string>();
                }
                listArray2 = this.dbc.Select(4L, str4);
                if (listArray2[1].ElementAt<string>(0).Equals(this.comboBoxModel.SelectedItem.ToString()))
                {
                    num2++;
                    string str5 = "SELECT memo_no from firoz_center.tbl_vehicle where engine_no='" + listArray[1].ElementAt<string>(num) + "';";
                    string str6 = this.dbc.Select_Date_Format("SELECT purchase_date from firoz_center.tbl_purchase where invoice_no='" + listArray[3].ElementAt<string>(num) + "';");
                    long num4 = this.dbc.Count(str5);
                    string str7 = "";
                    string str8 = "";
                    if (num4 == 0L)
                    {
                        str7 = this.dbc.SelectSingle("SELECT memo_no from firoz_center.tbl_vehicle where engine_no='" + listArray[1].ElementAt<string>(num) + "';");
                        str8 = this.dbc.Select_Date_Format("SELECT date from firoz_center.tbl_payment where memo_no='" + str7 + "';");
                    }
                    this.dataGridView1.Rows.Add(new object[] { listArray2[1].ElementAt<string>(0), listArray2[3].ElementAt<string>(0), listArray[1].ElementAt<string>(num), listArray[2].ElementAt<string>(num), listArray[3].ElementAt<string>(num), str6, str7, str8 });
                }
            }
            this.textBoxQuantity.Text = num2.ToString();
        }

        private void load_stock(string model, string type, string comments)
        {
            int num;
            this.dataGridView1.Rows.Clear();
            string query = "select vehicleId,engine_no,chasis_no,invoice_no from firoz_center.tbl_vehicle where status='" + type + "' and comments='" + comments + "';";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(4L, query);
            int num2 = 0;
            for (num = 0; num < listArray[0].Count; num++)
            {
                string str2 = listArray[0].ElementAt<string>(num);
                string str3 = listArray[1].ElementAt<string>(num);
                string str4 = "Select brand,model, cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + str2 + "';";
                List<string>[] listArray2 = new List<string>[4];
                for (int i = 0; i < 4; i++)
                {
                    listArray2[i] = new List<string>();
                }
                listArray2 = this.dbc.Select(4L, str4);
                if (listArray2[1].ElementAt<string>(0).Equals(this.comboBoxModel.SelectedItem.ToString()))
                {
                    num2++;
                    string str5 = "SELECT memo_no from firoz_center.tbl_vehicle where engine_no='" + listArray[1].ElementAt<string>(num) + "';";
                    string str6 = this.dbc.Select_Date_Format("SELECT purchase_date from firoz_center.tbl_purchase where invoice_no='" + listArray[3].ElementAt<string>(num) + "';");
                    long num4 = this.dbc.Count(str5);
                    string str7 = "";
                    string str8 = "";
                    if (num4 == 0L)
                    {
                        str7 = this.dbc.SelectSingle("SELECT memo_no from firoz_center.tbl_vehicle where engine_no='" + listArray[1].ElementAt<string>(num) + "';");
                        str8 = this.dbc.Select_Date_Format("SELECT date from firoz_center.tbl_payment where memo_no='" + str7 + "';");
                    }
                    this.dataGridView1.Rows.Add(new object[] { listArray2[1].ElementAt<string>(0), listArray2[3].ElementAt<string>(0), listArray[1].ElementAt<string>(num), listArray[2].ElementAt<string>(num), listArray[3].ElementAt<string>(num), str6, str7, str8 });
                }
            }
            this.textBoxQuantity.Text = num2.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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
                        SolidBrush brush = new SolidBrush(Color.Black);
                        this.sf.Alignment = StringAlignment.Center;
                        this.sf.LineAlignment = StringAlignment.Center;
                        this.sfLeft.Alignment = StringAlignment.Near;
                        this.sfLeft.LineAlignment = StringAlignment.Center;
                        this.sfMiddle.Alignment = StringAlignment.Center;
                        this.sfMiddle.LineAlignment = StringAlignment.Center;
                        this.sfRight.Alignment = StringAlignment.Far;
                        this.sfRight.LineAlignment = StringAlignment.Center;
                        DateTime now = new DateTime();
                        now = DateTime.Now;
                        string str = string.Format("{0:dd-MMM-yyyy}", now);
                        e.Graphics.DrawString("Firoz Motors", font, brush, new Rectangle(15, y, 800, font.Height), this.sfMiddle);
                        y += 30;
                        e.Graphics.DrawString("Naiorpul Sylhet, Sylhet", font2, brush, new Rectangle(15, y, 800, font2.Height), this.sfMiddle);
                        y += 0x19;
                        e.Graphics.DrawString("MotorCycle Details Report", font4, brush, new Rectangle(15, y, 800, font4.Height), this.sfMiddle);
                        y += 20;
                        e.Graphics.DrawString("Print Date:" + str, font3, brush, new Rectangle(15, 10, 150, font3.Height), this.sfMiddle);
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
                            if ((num4 >= 0) || (num4 <= 3))
                            {
                                this.sf = this.sfLeft;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
                            else
                            {
                                this.sf = this.sfMiddle;
                                e.Graphics.DrawString(cell.Value.ToString(), cell.InheritedStyle.Font, new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((float) (((int) this.arrColumnLefts[num4]) + 3), (float) y, (float) ((int) this.arrColumnWidths[num4]), (float) this.iCellHeight), this.sf);
                            }
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

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAll.Checked.Equals(true))
            {
                if (this.tag == 0)
                {
                    MessageBox.Show("Select Model");
                }
                else
                {
                    this.load_stock(this.comboBoxModel.SelectedItem.ToString(), "stock' or status='sold");
                }
            }
        }

        private void radioButtonDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonDisplay.Checked.Equals(true))
            {
                this.load_stock(this.comboBoxModel.SelectedItem.ToString(), "stock", "showroom");
            }
        }

        private void radioButtonStcok_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSold.Checked.Equals(true))
            {
                if (this.tag == 0)
                {
                    MessageBox.Show("Select Model");
                }
                else
                {
                    this.load_stock(this.comboBoxModel.SelectedItem.ToString(), "sold");
                }
            }
        }

        private void radioButtonStock_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonStock.Checked.Equals(true))
            {
                if (this.tag == 0)
                {
                    MessageBox.Show("Select Model");
                }
                else
                {
                    this.load_stock(this.comboBoxModel.SelectedItem.ToString(), "stock");
                }
            }
        }

        private void radioButtonStore_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonStore.Checked.Equals(true))
            {
                this.load_stock(this.comboBoxModel.SelectedItem.ToString(), "stock", "stock");
            }
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
    }
}

