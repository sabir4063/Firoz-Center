namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Linq;
    using System.Windows.Forms;

    public class PrintEngineOil : Form
    {
        private Button buttonPrint;
        private IContainer components = null;
        private DBConnect dbc = new DBConnect();
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private TextBox textBoxContact;
        private TextBox textBoxDate;
        private TextBox textBoxDue;
        private TextBox textBoxMemoNo;
        private TextBox textBoxName;
        private TextBox textBoxPaid;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private TextBox textBoxTotal;

        public PrintEngineOil()
        {
            this.InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview();
                this.buttonPrint.BackColor = Color.Yellow;
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

        private void Doc_PrintPreview(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Serpentine-Bold", 10f);
            Font font2 = new Font("Siyam Rupali", 8f);
            Font font3 = new Font("Arial Black", 16f, FontStyle.Underline);
            Font font4 = new Font("Serpentine-Bold", 10f);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string text = this.textBoxDate.Text;
            string s = this.textBoxName.Text;
            string str4 = this.textBoxAddress.Text;
            string str5 = this.textBoxContact.Text;
            StringFormat format = new StringFormat();
            StringFormat format2 = new StringFormat();
            StringFormat format3 = new StringFormat {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Near;
            format2.LineAlignment = StringAlignment.Center;
            Font font5 = new Font("Bookman Old Style", 8f);
            Image image = Image.FromFile(@"D:\Logo.png");
            e.Graphics.DrawImage(image, 5, 5, image.Width, image.Height);
            e.Graphics.DrawString("Dealer: Bangladesh Honda Private Ltd.  ", font5, brush, new Rectangle(5, 40, 280, font5.Height), format);
            int y = 15;
            y += 12;
            e.Graphics.DrawString("Naiorpul, Sylhet", font5, brush, new Rectangle(60, y, 320, font5.Height), format3);
            e.Graphics.DrawString("Mobile: 01738116666", font5, brush, new Rectangle(370, y, 150, font5.Height), format3);
            y += 12;
            e.Graphics.DrawString("Tel:0821727298", font5, brush, new Rectangle(60, y, 320, font5.Height), format3);
            e.Graphics.DrawString("01199304020", font5, brush, new Rectangle(370, y, 150, font5.Height), format3);
            e.Graphics.DrawString("SALES INVOICE", font3, brush, (float) 160f, (float) 80f);
            e.Graphics.DrawRectangle(pen, 20, 130, 80, 0x17);
            e.Graphics.DrawString("Memo No", font, brush, (float) 25f, (float) 130f);
            e.Graphics.DrawRectangle(pen, 0x69, 130, 100, 0x17);
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 110f, (float) 130f);
            e.Graphics.DrawRectangle(pen, 340, 130, 70, 0x17);
            e.Graphics.DrawString("Date", font, brush, (float) 355f, (float) 130f);
            e.Graphics.DrawRectangle(pen, 0x19f, 130, 0x73, 0x17);
            e.Graphics.DrawString(text, font, brush, (float) 420f, (float) 130f);
            e.Graphics.DrawRectangle(pen, 340, 160, 70, 0x17);
            e.Graphics.DrawString("Mobile", font, brush, (float) 355f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 0x19f, 160, 0x73, 0x17);
            e.Graphics.DrawString(this.textBoxContact.Text, font, brush, (float) 420f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 20, 200, 80, 0x17);
            e.Graphics.DrawString("Name", font, brush, (float) 25f, (float) 200f);
            e.Graphics.DrawRectangle(pen, 0x69, 200, 430, 0x17);
            e.Graphics.DrawString(s, font, brush, (float) 110f, (float) 200f);
            str4 = str4.Replace('\n', ' ');
            if (str4.Length >= 50)
            {
                int index = str4.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str4.Length;
                }
                e.Graphics.DrawRectangle(pen, 20, 230, 80, 0x17);
                e.Graphics.DrawString("Address", font, brush, (float) 25f, (float) 230f);
                e.Graphics.DrawRectangle(pen, 0x69, 230, 430, 0x17);
                e.Graphics.DrawString(str4.Substring(0, index), font, brush, (float) 110f, (float) 230f);
                if (index != str4.Length)
                {
                    e.Graphics.DrawRectangle(pen, 0x69, 260, 430, 0x17);
                    e.Graphics.DrawString(str4, font, brush, (float) 110f, (float) 260f);
                }
            }
            else
            {
                e.Graphics.DrawRectangle(pen, 20, 230, 80, 0x17);
                e.Graphics.DrawString("Address", font, brush, (float) 25f, (float) 230f);
                e.Graphics.DrawRectangle(pen, 0x69, 230, 430, 0x17);
                e.Graphics.DrawString(str4, font, brush, (float) 110f, (float) 230f);
            }
            e.Graphics.DrawRectangle(pen, 20, 280, 0x203, 40);
            e.Graphics.DrawRectangle(pen, 0x19, 0x11d, 0x1f9, 30);
            e.Graphics.DrawString("Item Description", font, brush, new Rectangle(0x19, 290, 510, 20), format);
            e.Graphics.DrawRectangle(pen, 20, 0x145, 80, 40);
            e.Graphics.DrawString("Item ", font, brush, (float) 25f, (float) 335f);
            e.Graphics.DrawRectangle(pen, 100, 0x145, 190, 40);
            e.Graphics.DrawString("Description ", font, brush, (float) 105f, (float) 335f);
            e.Graphics.DrawRectangle(pen, 290, 0x145, 80, 40);
            e.Graphics.DrawString("Quantity ", font, brush, (float) 305f, (float) 335f);
            e.Graphics.DrawRectangle(pen, 370, 0x145, 80, 40);
            e.Graphics.DrawString("Price ", font, brush, (float) 385f, (float) 335f);
            e.Graphics.DrawRectangle(pen, 450, 0x145, 0x55, 40);
            e.Graphics.DrawString("Net Amount ", font, brush, (float) 455f, (float) 335f);
            e.Graphics.DrawString("Engine Oil ", font, brush, (float) 25f, (float) 380f);
            e.Graphics.DrawString("HONDA 4T 10W30 SJ ", font, brush, (float) 105f, (float) 380f);
            e.Graphics.DrawString(this.textBoxQuantity.Text, font, brush, new Rectangle(290, 380, 60, 20), format3);
            e.Graphics.DrawString(this.textBoxPrice.Text, font, brush, new Rectangle(370, 380, 60, 20), format3);
            e.Graphics.DrawString(this.textBoxTotal.Text, font, brush, new Rectangle(450, 380, 60, 20), format3);
            e.Graphics.DrawRectangle(pen, 20, 370, 0x203, 100);
            e.Graphics.DrawString("Net Amount: ", font, brush, new Rectangle(0x19, 480, 400, 20), format3);
            e.Graphics.DrawString(this.textBoxTotal.Text + " Taka", font, brush, new Rectangle(420, 480, 100, 20), format3);
            e.Graphics.DrawString("Paid Amount: ", font, brush, new Rectangle(0x19, 500, 400, 20), format3);
            e.Graphics.DrawString(this.textBoxPaid.Text + " Taka", font, brush, new Rectangle(420, 500, 100, 20), format3);
            e.Graphics.DrawString("Due Amount: ", font, brush, new Rectangle(0x19, 520, 400, 20), format3);
            e.Graphics.DrawString(this.textBoxDue.Text + " Taka", font, brush, new Rectangle(420, 520, 100, 20), format3);
            e.Graphics.DrawString("Customer Signature", font, brush, (float) 20f, (float) 700f);
            e.Graphics.DrawString("বিঃদ্রঃ বিক্রিত মাল ফেরত নেয়া হয় না", font2, brush, (float) 180f, (float) 720f);
            e.Graphics.DrawString("For Firoz Motors", font, brush, (float) 400f, (float) 700f);
        }

        private void InitializeComponent()
        {
            this.textBoxDue = new TextBox();
            this.label7 = new Label();
            this.label5 = new Label();
            this.textBoxPaid = new TextBox();
            this.buttonPrint = new Button();
            this.label8 = new Label();
            this.groupBox2 = new GroupBox();
            this.textBoxTotal = new TextBox();
            this.label6 = new Label();
            this.textBoxPrice = new TextBox();
            this.label1 = new Label();
            this.textBoxQuantity = new TextBox();
            this.label9 = new Label();
            this.groupBox1 = new GroupBox();
            this.textBoxDate = new TextBox();
            this.label12 = new Label();
            this.textBoxMemoNo = new TextBox();
            this.label11 = new Label();
            this.textBoxContact = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxName = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label19 = new Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.textBoxDue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDue.Location = new Point(0x110, 70);
            this.textBoxDue.Name = "textBoxDue";
            this.textBoxDue.ReadOnly = true;
            this.textBoxDue.Size = new Size(0x81, 0x16);
            this.textBoxDue.TabIndex = 0x6a;
            this.textBoxDue.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.DarkSeaGreen;
            this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0xdf, 0x49);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x21, 0x10);
            this.label7.TabIndex = 0x6b;
            this.label7.Text = "Due";
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.DarkSeaGreen;
            this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(0xdf, 0x31);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x24, 0x10);
            this.label5.TabIndex = 0x69;
            this.label5.Text = "Paid";
            this.textBoxPaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPaid.Location = new Point(0x110, 0x2e);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.ReadOnly = true;
            this.textBoxPaid.Size = new Size(0x81, 0x16);
            this.textBoxPaid.TabIndex = 0x68;
            this.textBoxPaid.TextAlign = HorizontalAlignment.Right;
            this.buttonPrint.BackColor = Color.FromArgb(0xff, 0x80, 0);
            this.buttonPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.buttonPrint.Location = new Point(0x95, 0x65);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(120, 30);
            this.buttonPrint.TabIndex = 0x6f;
            this.buttonPrint.TabStop = false;
            this.buttonPrint.Text = "Pirnt";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click);
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.DarkSeaGreen;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(9, 0x31);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x27, 0x10);
            this.label8.TabIndex = 0x66;
            this.label8.Text = "Total";
            this.groupBox2.BackColor = Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.buttonPrint);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.textBoxPaid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox2.Location = new Point(5, 0xa4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x19d, 0x89);
            this.groupBox2.TabIndex = 0x23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Engine Oil";
            this.textBoxTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxTotal.Location = new Point(0x53, 0x2e);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new Size(0x81, 0x16);
            this.textBoxTotal.TabIndex = 0x65;
            this.textBoxTotal.TextAlign = HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.DarkSeaGreen;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(0x27, 0x31);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0, 0x10);
            this.label6.TabIndex = 100;
            this.textBoxPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxPrice.Location = new Point(0x110, 0x16);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new Size(0x81, 0x16);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextAlign = HorizontalAlignment.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.DarkSeaGreen;
            this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0xdf, 0x19);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x27, 0x10);
            this.label1.TabIndex = 0x15;
            this.label1.Text = "Price";
            this.textBoxQuantity.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxQuantity.Location = new Point(0x53, 0x16);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.ReadOnly = true;
            this.textBoxQuantity.Size = new Size(0x81, 0x16);
            this.textBoxQuantity.TabIndex = 20;
            this.textBoxQuantity.TextAlign = HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = Color.DarkSeaGreen;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(10, 0x16);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x38, 0x10);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity";
            this.groupBox1.BackColor = Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x19d, 0x99);
            this.groupBox1.TabIndex = 0x22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            this.textBoxDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxDate.Location = new Point(0x120, 0x13);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new Size(0x71, 0x16);
            this.textBoxDate.TabIndex = 20;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0xe5, 0x16);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x25, 0x10);
            this.label12.TabIndex = 0x13;
            this.label12.Text = "Date";
            this.textBoxMemoNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxMemoNo.Location = new Point(0x53, 0x13);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new Size(0x71, 0x16);
            this.textBoxMemoNo.TabIndex = 1;
            this.textBoxMemoNo.KeyDown += new KeyEventHandler(this.textBoxMemoNo_KeyDown);
            this.label11.AutoSize = true;
            this.label11.BackColor = Color.DarkSeaGreen;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.Location = new Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x43, 0x10);
            this.label11.TabIndex = 0x11;
            this.label11.Text = "Memo No";
            this.textBoxContact.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxContact.Location = new Point(0x53, 0x7b);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new Size(0x13e, 0x16);
            this.textBoxContact.TabIndex = 6;
            this.textBoxContact.TabStop = false;
            this.textBoxAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxAddress.Location = new Point(0x53, 0x43);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new Size(0x13e, 0x36);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBoxName.Location = new Point(0x53, 0x2b);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new Size(0x13e, 0x16);
            this.textBoxName.TabIndex = 4;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.DarkSeaGreen;
            this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(10, 0x7b);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.DarkSeaGreen;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(10, 0x43);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 0x10);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            this.label19.AutoSize = true;
            this.label19.BackColor = Color.DarkSeaGreen;
            this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(10, 0x2f);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x2d, 0x10);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            ////base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.MediumSeaGreen;
            base.ClientSize = new Size(0x1a8, 0x133);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Name = "PrintEngineOil";
            this.Text = "PrintEngineOil";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void load_transcation()
        {
            string text = this.textBoxMemoNo.Text;
            string query = "Select net_amount,customer_id,type,paid_amount,due_amount,comments,grand_total,discount from firoz_center.tbl_sales_parts where memo_no='" + text + "';";
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Invalid Memo No");
            }
            else
            {
                int num2;
                List<string>[] listArray = new List<string>[8];
                for (num2 = 0; num2 < 8; num2++)
                {
                    listArray[num2] = new List<string>();
                }
                listArray = this.dbc.Select(8L, query);
                this.textBoxTotal.Text = listArray[0].ElementAt<string>(0);
                this.textBoxPaid.Text = listArray[3].ElementAt<string>(0);
                this.textBoxDue.Text = listArray[4].ElementAt<string>(0);
                query = "Select name,address,contact from firoz_center.tbl_customer where customer_id='" + listArray[1].ElementAt<string>(0) + "';";
                List<string>[] listArray2 = new List<string>[3];
                for (num2 = 0; num2 < 3; num2++)
                {
                    listArray2[num2] = new List<string>();
                }
                listArray2 = this.dbc.Select(3L, query);
                this.textBoxName.Text = listArray2[0].ElementAt<string>(0);
                this.textBoxAddress.Text = listArray2[1].ElementAt<string>(0);
                this.textBoxContact.Text = listArray2[2].ElementAt<string>(0);
                query = "Select partsId,sale_rate,count(*) from firoz_center.tbl_parts where memo_no='" + text + "' group by partsId;";
                List<string>[] listArray3 = new List<string>[3];
                for (num2 = 0; num2 < 3; num2++)
                {
                    listArray3[num2] = new List<string>();
                }
                listArray3 = this.dbc.Select(3L, query);
                this.textBoxQuantity.Text = listArray3[2].ElementAt<string>(0);
                this.textBoxPrice.Text = listArray3[1].ElementAt<string>(0);
                string str3 = this.dbc.SelectSingle("Select DATE_FORMAT(date, '%d-%m-%Y') AS date from firoz_center.tbl_sales_parts where memo_no='" + text + "';");
                this.textBoxDate.Text = str3;
            }
        }

        private void print_preview()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            document.DefaultPageSettings.PaperSize = new PaperSize("PaperA4", 600, 800);
            dialog.ShowDialog();
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBoxMemoNo.Text.Equals(""))
                {
                    MessageBox.Show("Please Search Again!");
                }
                else
                {
                    e.SuppressKeyPress = true;
                    this.load_transcation();
                }
            }
        }
    }
}

