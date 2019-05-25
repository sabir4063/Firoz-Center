namespace FirozCenterHonda
{
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    using Excel = Microsoft.Office.Interop.Excel;

    public class ReadExcel : Form
    {
        private System.Windows.Forms.Button buttonLOad;
        private System.Windows.Forms.Button buttonSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DBConnect dbc = new DBConnect();
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        //private Microsoft.Office.Interop.Excel.Application xlApp = ((Microsoft.Office.Interop.Excel.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046"))));

        public ReadExcel()
        {
            this.InitializeComponent();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            //Workbook workbook = this.xlApp.Workbooks.Open("C:/Parts.xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //Range usedRange = ((_Worksheet) workbook.Sheets[1]).UsedRange;


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range usedRange;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\A.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            usedRange = xlWorkSheet.UsedRange;

            int count = usedRange.Rows.Count;
            int num2 = usedRange.Columns.Count;
            for (int i = 1; i <= 6571; i++)
            {
                this.dataGridView1.Rows.Add(((dynamic) usedRange.Cells[i, 1]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 2]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 3]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 4]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 5]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 6]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 7]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 8]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 9]).Value2.ToString(), ((dynamic) usedRange.Cells[i, 10]).Value2.ToString());
            }

            //workbook.Close(Missing.Value, Missing.Value, Missing.Value);

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to insert new part?", "Insert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.save_transcation();
            }
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
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.buttonLOad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Column10 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.buttonLOad.BackColor = Color.MediumSeaGreen;
            this.buttonLOad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonLOad.Location = new System.Drawing.Point(6, 4);
            this.buttonLOad.Margin = new Padding(4);
            this.buttonLOad.Name = "buttonLOad";
            this.buttonLOad.Size = new Size(120, 30);
            this.buttonLOad.TabIndex = 0x11;
            this.buttonLOad.Text = "Load";
            this.buttonLOad.UseVisualStyleBackColor = false;
            this.buttonLOad.Click += new EventHandler(this.buttonAddNewProduct_Click);
            this.groupBox3.BackColor = Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.Location = new System.Drawing.Point(4, 0x22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x4af, 0x203);
            this.groupBox3.TabIndex = 0x15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column10, this.Column2, this.Column3, this.Column4, this.Column5, this.Column6, this.Column8, this.Column7, this.Column1, this.Column9 });
            this.dataGridView1.Location = new System.Drawing.Point(5, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x4a4, 0x1ed);
            this.dataGridView1.TabIndex = 0;
            this.buttonSave.BackColor = Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonSave.Location = new System.Drawing.Point(0x86, 4);
            this.buttonSave.Margin = new Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(120, 30);
            this.buttonSave.TabIndex = 0x16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.Column10.HeaderText = "PartsId";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column3.HeaderText = "Parts No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            this.Column4.FillWeight = 150f;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = style;
            this.Column5.FillWeight = 80f;
            this.Column5.HeaderText = "Purchase";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            style2.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = style2;
            this.Column6.FillWeight = 80f;
            this.Column6.HeaderText = "Retail";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column8.HeaderText = "Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = style3;
            this.Column7.FillWeight = 80f;
            this.Column7.HeaderText = "Wholesale";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = style4;
            this.Column1.HeaderText = "Distributor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column9.HeaderText = "Group";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DarkSeaGreen;
            base.ClientSize = new Size(0x4bf, 0x229);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.buttonLOad);
            //base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "ReadExcel";
            this.Text = "ReadExcel";
            this.groupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView1).EndInit();
            base.ResumeLayout(false);
        }

        private void save_transcation()
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                string str = "Honda";
                string str2 = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string str3 = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string str4 = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string str5 = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                string str6 = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                string str7 = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                string str8 = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                string str9 = this.dataGridView1.Rows[i].Cells[7].Value.ToString();
                string str10 = this.dataGridView1.Rows[i].Cells[8].Value.ToString();
                string str11 = this.dataGridView1.Rows[i].Cells[9].Value.ToString();
                string query = "insert into firoz_center.tbl_parts_info (`partsId`,`brand`,`model`,`partsNo`,`description`,`purchase_price`,`sale_price`,`date`,`wholesale_price`,`distributor_price`,`group`) values ('" + str2 + "','" + str + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "','2016-06-05','" + str9 + "','" + str10 + "','" + str11 + "');";
                this.dbc.Insert(query);
            }
            MessageBox.Show("Data Inserted");
        }
    }
}

