namespace FirozCenterHonda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Linq;
    using System.Windows.Forms;

    public class PrintSaleMotorCycle : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonChalan;
        private Button buttonInvoice;
        private IContainer components;
        private DBConnect dbc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private TextBox textBoxBrand;
        private TextBox textBoxCC;
        private TextBox textBoxChassis;
        private TextBox textBoxColor;
        private TextBox textBoxContact;
        private TextBox textBoxDate;
        private TextBox textBoxEngine;
        private TextBox textBoxFName;
        private TextBox textBoxMemoNo;
        private TextBox textBoxModel;
        private TextBox textBoxName;
        private Button buttonRegForm;
        private Button button5;
        private Button button4;
        private Button button6;
        private TextBox textBoxPrice;

        public PrintSaleMotorCycle()
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
        }

        public PrintSaleMotorCycle(string memo_no)
        {
            this.dbc = new DBConnect();
            this.components = null;
            this.InitializeComponent();
            this.textBoxMemoNo.Text = memo_no;
            this.textBoxMemoNo.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.load_transcation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.print_preview_chalan_temp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.print_preview_invoice_temp();
        }

        private void buttonChalan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print chalan?", "Print Chalan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_chalan();
            }
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_invoice();
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            this.print_preview_invoice();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Doc_PrintPreview_Chalan(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 14f);
            SolidBrush brush = new SolidBrush(Color.Black);
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string text = this.textBoxDate.Text;
            string s = this.textBoxName.Text;
            string str4 = this.textBoxFName.Text;
            string str5 = this.textBoxAddress.Text;
            string str6 = this.textBoxContact.Text;
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 140f, (float) 160f);
            e.Graphics.DrawString(text, font, brush, (float) 530f, (float) 160f);
            e.Graphics.DrawString(s, font, brush, (float) 140f, (float) 205f);
            e.Graphics.DrawString(str6, font, brush, (float) 530f, (float) 205f);
            e.Graphics.DrawString(str4, font, brush, (float) 140f, (float) 240f);
            if (str5.Length >= 50)
            {
                int index = str5.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str5.Length;
                }
                e.Graphics.DrawString(str5.Substring(0, index), font, brush, (float) 140f, (float) 280f);
                if (index != str5.Length)
                {
                    e.Graphics.DrawString(str5.Substring(index + 1), font, brush, (float) 140f, (float) 315f);
                }
            }
            else
            {
                e.Graphics.DrawString(str5, font, brush, (float) 140f, (float) 280f);
            }
            e.Graphics.DrawString(this.textBoxBrand.Text + " " + this.textBoxModel.Text + " " + this.textBoxCC.Text + " CC", font, brush, (float) 140f, (float) 380f);
            e.Graphics.DrawString(this.textBoxChassis.Text, font, brush, (float) 140f, (float) 460f);
            e.Graphics.DrawString(this.textBoxEngine.Text, font, brush, (float) 140f, (float) 540f);
            e.Graphics.DrawString(this.textBoxColor.Text, font, brush, (float) 140f, (float) 620f);
        }

        private void Doc_PrintPreview_Chalan_Temp(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Serpentine-Bold", 12f);
            Font font2 = new Font("Siyam Rupali", 8f);
            Font font3 = new Font("Arial Black", 16f, FontStyle.Underline);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
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
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string text = this.textBoxDate.Text;
            string s = this.textBoxName.Text;
            string str4 = this.textBoxFName.Text;
            string str5 = this.textBoxAddress.Text;
            string str6 = this.textBoxContact.Text;
            Font font4 = new Font("Bookman Old Style", 10f);
            Font font5 = new Font("Bookman Old Style", 14f);
            Image image = Image.FromFile(@"D:\LogoM.bmp");
            e.Graphics.DrawImage(image, 5, 5, image.Width, image.Height);
            e.Graphics.DrawString("Dealer: Bangladesh Honda Private Ltd.  ", font5, brush, new Rectangle(5, 80, 500, font5.Height), format);
            int y = 0x19;
            y += 10;
            e.Graphics.DrawString("Naiorpul, Sylhet", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            y += 15;
            e.Graphics.DrawString("Tel:0821727298", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            y += 15;
            e.Graphics.DrawString("Mobile: 01738116666", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            y += 15;
            e.Graphics.DrawString("01199304020", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            e.Graphics.DrawString("DELIVERY CHALLAN", font3, brush, (float) 220f, (float) 110f);
            e.Graphics.DrawString("Memo No.", font, brush, (float) 25f, (float) 160f);
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 170f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 450, 160, 70, 0x17);
            e.Graphics.DrawString("Date", font, brush, (float) 455f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 0x20d, 160, 170, 0x17);
            e.Graphics.DrawString(text, font, brush, (float) 540f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 450, 190, 70, 0x17);
            e.Graphics.DrawString("Mobile", font, brush, (float) 455f, (float) 190f);
            e.Graphics.DrawRectangle(pen, 0x20d, 190, 170, 0x17);
            e.Graphics.DrawString(str6, font, brush, (float) 540f, (float) 190f);
            e.Graphics.DrawRectangle(pen, 20, 220, 150, 0x17);
            e.Graphics.DrawString("Name", font, brush, (float) 25f, (float) 220f);
            e.Graphics.DrawRectangle(pen, 0xaf, 220, 520, 0x17);
            e.Graphics.DrawString(s, font, brush, (float) 180f, (float) 220f);
            e.Graphics.DrawRectangle(pen, 20, 250, 150, 0x17);
            e.Graphics.DrawString("Fathers Name", font, brush, (float) 25f, (float) 250f);
            e.Graphics.DrawRectangle(pen, 0xaf, 250, 520, 0x17);
            e.Graphics.DrawString(str4, font, brush, (float) 180f, (float) 250f);
            str5 = str5.Replace('\n', ' ');
            if (str5.Length >= 50)
            {
                int index = str5.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str5.Length;
                }
                e.Graphics.DrawRectangle(pen, 20, 280, 150, 0x17);
                e.Graphics.DrawString("Address", font, brush, (float) 25f, (float) 280f);
                e.Graphics.DrawRectangle(pen, 0xaf, 280, 520, 0x17);
                e.Graphics.DrawString(str5.Substring(0, index), font, brush, (float) 180f, (float) 280f);
                if (index != str5.Length)
                {
                    e.Graphics.DrawRectangle(pen, 0xaf, 310, 520, 0x17);
                    e.Graphics.DrawString(str5.Substring(index + 1), font, brush, (float) 180f, (float) 310f);
                }
            }
            else
            {
                e.Graphics.DrawRectangle(pen, 20, 280, 150, 0x17);
                e.Graphics.DrawString("Address", font, brush, (float) 25f, (float) 280f);
                e.Graphics.DrawRectangle(pen, 0xaf, 280, 520, 0x17);
                e.Graphics.DrawString(str5, font, brush, (float) 180f, (float) 280f);
            }
            e.Graphics.DrawRectangle(pen, 20, 350, 150, 0x37);
            e.Graphics.DrawString("Model", font, brush, (float) 25f, (float) 365f);
            e.Graphics.DrawRectangle(pen, 0xaf, 350, 520, 0x37);
            e.Graphics.DrawString(this.textBoxBrand.Text + " " + this.textBoxModel.Text + " " + this.textBoxCC.Text + " CC", font, brush, (float) 180f, (float) 365f);
            e.Graphics.DrawRectangle(pen, 20, 410, 150, 0x37);
            e.Graphics.DrawString("Chassis No.", font, brush, (float) 25f, (float) 425f);
            e.Graphics.DrawRectangle(pen, 0xaf, 410, 520, 0x37);
            e.Graphics.DrawString(this.textBoxChassis.Text, font, brush, (float) 180f, (float) 425f);
            e.Graphics.DrawRectangle(pen, 20, 470, 150, 0x37);
            e.Graphics.DrawString("Engine No.", font, brush, (float) 25f, (float) 485f);
            e.Graphics.DrawRectangle(pen, 0xaf, 470, 520, 0x37);
            e.Graphics.DrawString(this.textBoxEngine.Text, font, brush, (float) 180f, (float) 485f);
            e.Graphics.DrawRectangle(pen, 20, 530, 150, 0x37);
            e.Graphics.DrawString("Colour", font, brush, (float) 25f, (float) 545f);
            e.Graphics.DrawRectangle(pen, 0xaf, 530, 520, 0x37);
            e.Graphics.DrawString(this.textBoxColor.Text, font, brush, (float) 180f, (float) 545f);
            e.Graphics.DrawRectangle(pen, 20, 590, 150, 0x37);
            e.Graphics.DrawString("Remarks", font, brush, (float) 25f, (float) 605f);
            e.Graphics.DrawRectangle(pen, 0xaf, 590, 520, 0x37);
            e.Graphics.DrawString("Customer Signature", font, brush, (float) 20f, (float) 800f);
            e.Graphics.DrawString("বিঃদ্রঃ এই চালানটি রেজিষ্ট্রেশনের জন্য প্রযোজ্য নয়", font2, brush, (float) 250f, (float) 800f);
            e.Graphics.DrawString("For Firoz Motors", font, brush, (float) 535f, (float) 800f);
        }

        private void Doc_PrintPreview_Invoice(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Serpentine-Bold", 14f);
            SolidBrush brush = new SolidBrush(Color.Black);
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string text = this.textBoxDate.Text;
            string s = this.textBoxName.Text;
            string str4 = this.textBoxFName.Text;
            string str5 = this.textBoxAddress.Text;
            string str6 = this.textBoxContact.Text;
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 140f, (float) 120f);
            e.Graphics.DrawString(text, font, brush, (float) 530f, (float) 120f);
            e.Graphics.DrawString(s, font, brush, (float) 140f, (float) 165f);
            e.Graphics.DrawString(str6, font, brush, (float) 530f, (float) 165f);
            e.Graphics.DrawString(str4, font, brush, (float) 140f, (float) 205f);
            if (str5.Length >= 50)
            {
                int index = str5.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str5.Length;
                }
                e.Graphics.DrawString(str5.Substring(0, index), font, brush, (float) 140f, (float) 245f);
                if (index != str5.Length)
                {
                    e.Graphics.DrawString(str5.Substring(index + 1), font, brush, (float) 140f, (float) 285f);
                }
            }
            else
            {
                e.Graphics.DrawString(str5, font, brush, (float) 140f, (float) 245f);
            }
            e.Graphics.DrawString(this.textBoxBrand.Text + " " + this.textBoxModel.Text, font, brush, (float) 140f, (float) 450f);
            e.Graphics.DrawString(this.textBoxEngine.Text, font, brush, (float) 140f, (float) 535f);
            e.Graphics.DrawString(this.textBoxChassis.Text, font, brush, (float) 140f, (float) 585f);
            e.Graphics.DrawString(this.textBoxColor.Text, font, brush, (float) 140f, (float) 640f);
            e.Graphics.DrawString(this.textBoxCC.Text, font, brush, (float) 380f, (float) 640f);
            e.Graphics.DrawString(this.textBoxModel.Text, font, brush, (float) 380f, (float) 700f);
            e.Graphics.DrawString(this.textBoxPrice.Text, font, brush, (float) 570f, (float) 700f);
            e.Graphics.DrawString(this.dbc.NumberToText(this.textBoxPrice.Text), font, brush, (float) 140f, (float) 725f);
        }

        private void Doc_PrintPreview_Invoice_Temp(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Serpentine-Bold", 12f);
            Font font2 = new Font("Siyam Rupali", 8f);
            Font font3 = new Font("Arial Black", 16f, FontStyle.Underline);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
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
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:dd-MMM-yyyy}", now);
            string text = this.textBoxDate.Text;
            string s = this.textBoxName.Text;
            string str4 = this.textBoxFName.Text;
            string str5 = this.textBoxAddress.Text;
            string str6 = this.textBoxContact.Text;
            Font font4 = new Font("Bookman Old Style", 10f);
            Font font5 = new Font("Bookman Old Style", 14f);
            Image image = Image.FromFile(@"D:\LogoM.bmp");
            e.Graphics.DrawImage(image, 5, 5, image.Width, image.Height);
            e.Graphics.DrawString("Dealer: Bangladesh Honda Private Ltd.  ", font5, brush, new Rectangle(5, 80, 500, font5.Height), format);
            int y = 0x19;
            y += 10;
            e.Graphics.DrawString("Naiorpul, Sylhet", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            y += 15;
            e.Graphics.DrawString("Tel:0821727298", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            y += 15;
            e.Graphics.DrawString("Mobile: 01738116666", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            y += 15;
            e.Graphics.DrawString("01199304020", font4, brush, new Rectangle(500, y, 180, font4.Height), format3);
            e.Graphics.DrawString("SALES INVOICE", font3, brush, (float) 220f, (float) 110f);
            e.Graphics.DrawString("Memo No.", font, brush, (float) 25f, (float) 160f);
            e.Graphics.DrawString(this.textBoxMemoNo.Text, font, brush, (float) 170f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 450, 160, 70, 0x17);
            e.Graphics.DrawString("Date", font, brush, (float) 455f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 0x20d, 160, 170, 0x17);
            e.Graphics.DrawString(text, font, brush, (float) 540f, (float) 160f);
            e.Graphics.DrawRectangle(pen, 450, 190, 70, 0x17);
            e.Graphics.DrawString("Mobile", font, brush, (float) 455f, (float) 190f);
            e.Graphics.DrawRectangle(pen, 0x20d, 190, 170, 0x17);
            e.Graphics.DrawString(str6, font, brush, (float) 540f, (float) 190f);
            e.Graphics.DrawRectangle(pen, 20, 220, 150, 0x17);
            e.Graphics.DrawString("Name", font, brush, (float) 25f, (float) 220f);
            e.Graphics.DrawRectangle(pen, 0xaf, 220, 520, 0x17);
            e.Graphics.DrawString(s, font, brush, (float) 180f, (float) 220f);
            e.Graphics.DrawRectangle(pen, 20, 250, 150, 0x17);
            e.Graphics.DrawString("Fathers Name", font, brush, (float) 25f, (float) 250f);
            e.Graphics.DrawRectangle(pen, 0xaf, 250, 520, 0x17);
            e.Graphics.DrawString(str4, font, brush, (float) 180f, (float) 250f);
            if (str5.Length >= 50)
            {
                int index = str5.IndexOf(' ', 0x31);
                if (index == -1)
                {
                    index = str5.Length;
                }
                e.Graphics.DrawRectangle(pen, 20, 280, 150, 0x17);
                e.Graphics.DrawString("Address", font, brush, (float) 25f, (float) 280f);
                e.Graphics.DrawRectangle(pen, 0xaf, 280, 520, 0x17);
                e.Graphics.DrawString(str5.Substring(0, index), font, brush, (float) 180f, (float) 280f);
                if (index != str5.Length)
                {
                    e.Graphics.DrawRectangle(pen, 0xaf, 310, 520, 0x17);
                    e.Graphics.DrawString(str5.Substring(index + 1), font, brush, (float) 180f, (float) 310f);
                }
            }
            else
            {
                e.Graphics.DrawRectangle(pen, 20, 280, 150, 0x17);
                e.Graphics.DrawString("Address", font, brush, (float) 25f, (float) 280f);
                e.Graphics.DrawRectangle(pen, 0xaf, 280, 520, 0x17);
                e.Graphics.DrawString(str5, font, brush, (float) 180f, (float) 280f);
            }
            e.Graphics.DrawRectangle(pen, 20, 350, 0x2a3, 30);
            e.Graphics.DrawString("Particulars", font, brush, (float) 300f, (float) 352f);
            e.Graphics.DrawRectangle(pen, 20, 380, 0x2a3, 270);
            e.Graphics.DrawString("Model", font, brush, (float) 25f, (float) 400f);
            e.Graphics.DrawString(this.textBoxBrand.Text + " " + this.textBoxModel.Text, font, brush, (float) 180f, (float) 400f);
            e.Graphics.DrawString("Chassis No.", font, brush, (float) 25f, (float) 450f);
            e.Graphics.DrawString(this.textBoxChassis.Text, font, brush, (float) 180f, (float) 450f);
            e.Graphics.DrawString("Engine No.", font, brush, (float) 25f, (float) 500f);
            e.Graphics.DrawString(this.textBoxEngine.Text, font, brush, (float) 180f, (float) 500f);
            e.Graphics.DrawString("Colour", font, brush, (float) 25f, (float) 550f);
            e.Graphics.DrawString(this.textBoxColor.Text, font, brush, (float) 180f, (float) 550f);
            e.Graphics.DrawString("CC", font, brush, (float) 25f, (float) 600f);
            e.Graphics.DrawString(this.textBoxCC.Text, font, brush, (float) 180f, (float) 600f);
            e.Graphics.DrawString("Amount: ", font, brush, (float) 25f, (float) 655f);
            e.Graphics.DrawString(this.textBoxPrice.Text + " Taka", font, brush, (float) 180f, (float) 655f);
            e.Graphics.DrawString("Taka in words: ", font, brush, (float) 25f, (float) 680f);
            e.Graphics.DrawString(this.dbc.NumberToText(this.textBoxPrice.Text) + " Taka", font, brush, (float) 180f, (float) 680f);
            e.Graphics.DrawString("Customer Signature", font, brush, (float) 20f, (float) 800f);
            e.Graphics.DrawString("For Firoz Motors", font, brush, (float) 535f, (float) 800f);
        }

        private void InitializeComponent()
        {
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRegForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonChalan = new System.Windows.Forms.Button();
            this.textBoxChassis = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMemoNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoice.Location = new System.Drawing.Point(120, 191);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(120, 30);
            this.buttonInvoice.TabIndex = 27;
            this.buttonInvoice.Text = "Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = false;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(120, 163);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(268, 22);
            this.textBoxPrice.TabIndex = 25;
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngine.Location = new System.Drawing.Point(120, 139);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.ReadOnly = true;
            this.textBoxEngine.Size = new System.Drawing.Size(268, 22);
            this.textBoxEngine.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Engine No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chassis No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 91);
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
            this.label7.Location = new System.Drawing.Point(16, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "CC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Brand";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.buttonRegForm);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.buttonChalan);
            this.groupBox2.Controls.Add(this.textBoxChassis);
            this.groupBox2.Controls.Add(this.textBoxColor);
            this.groupBox2.Controls.Add(this.textBoxCC);
            this.groupBox2.Controls.Add(this.textBoxModel);
            this.groupBox2.Controls.Add(this.textBoxBrand);
            this.groupBox2.Controls.Add(this.buttonInvoice);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.textBoxEngine);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 289);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(281, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 30);
            this.button6.TabIndex = 39;
            this.button6.Text = "Form";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(187, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 30);
            this.button5.TabIndex = 38;
            this.button5.Text = "Page 3";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(93, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 30);
            this.button4.TabIndex = 37;
            this.button4.Text = "Page 2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonRegForm
            // 
            this.buttonRegForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRegForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegForm.Location = new System.Drawing.Point(4, 253);
            this.buttonRegForm.Name = "buttonRegForm";
            this.buttonRegForm.Size = new System.Drawing.Size(83, 30);
            this.buttonRegForm.TabIndex = 36;
            this.buttonRegForm.Text = "Page 1";
            this.buttonRegForm.UseVisualStyleBackColor = false;
            this.buttonRegForm.Click += new System.EventHandler(this.buttonRegForm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(268, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 30);
            this.button3.TabIndex = 35;
            this.button3.Text = "Invoice";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "Chalan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonChalan
            // 
            this.buttonChalan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonChalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChalan.Location = new System.Drawing.Point(268, 191);
            this.buttonChalan.Name = "buttonChalan";
            this.buttonChalan.Size = new System.Drawing.Size(120, 30);
            this.buttonChalan.TabIndex = 33;
            this.buttonChalan.Text = "Chalan";
            this.buttonChalan.UseVisualStyleBackColor = false;
            this.buttonChalan.Click += new System.EventHandler(this.buttonChalan_Click);
            // 
            // textBoxChassis
            // 
            this.textBoxChassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChassis.Location = new System.Drawing.Point(120, 115);
            this.textBoxChassis.Name = "textBoxChassis";
            this.textBoxChassis.ReadOnly = true;
            this.textBoxChassis.Size = new System.Drawing.Size(268, 22);
            this.textBoxChassis.TabIndex = 32;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(120, 91);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.ReadOnly = true;
            this.textBoxColor.Size = new System.Drawing.Size(268, 22);
            this.textBoxColor.TabIndex = 31;
            // 
            // textBoxCC
            // 
            this.textBoxCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCC.Location = new System.Drawing.Point(120, 67);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ReadOnly = true;
            this.textBoxCC.Size = new System.Drawing.Size(268, 22);
            this.textBoxCC.TabIndex = 30;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(120, 43);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(268, 22);
            this.textBoxModel.TabIndex = 29;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrand.Location = new System.Drawing.Point(120, 19);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.ReadOnly = true;
            this.textBoxBrand.Size = new System.Drawing.Size(268, 22);
            this.textBoxBrand.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Model";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.Location = new System.Drawing.Point(120, 88);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.ReadOnly = true;
            this.textBoxFName.Size = new System.Drawing.Size(268, 22);
            this.textBoxFName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Father\'s Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date";
            // 
            // textBoxMemoNo
            // 
            this.textBoxMemoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemoNo.Location = new System.Drawing.Point(120, 16);
            this.textBoxMemoNo.Name = "textBoxMemoNo";
            this.textBoxMemoNo.Size = new System.Drawing.Size(118, 22);
            this.textBoxMemoNo.TabIndex = 1;
            this.textBoxMemoNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMemoNo_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Memo No";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(120, 195);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new System.Drawing.Size(268, 22);
            this.textBoxContact.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(120, 112);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(268, 81);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(120, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(268, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxDate);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMemoNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 226);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.Location = new System.Drawing.Point(120, 40);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(118, 22);
            this.textBoxDate.TabIndex = 23;
            // 
            // PrintSaleMotorCycle
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(411, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintSaleMotorCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSaleMotorCycle";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void load_transcation()
        {
            int num;
            string text = this.textBoxMemoNo.Text;
            string query = "Select net_amount,customer_id,type from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';";
            List<string>[] listArray = new List<string>[3];
            for (num = 0; num < 3; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(3L, query);
            if (this.dbc.Count(query) == -1L)
            {
                MessageBox.Show("Search Again");
            }
            else
            {
                query = "Select name,fathers_name,address,contact from firoz_center.tbl_customer where customer_id='" + listArray[1].ElementAt<string>(0) + "';";
                List<string>[] listArray2 = new List<string>[4];
                for (num = 0; num < 4; num++)
                {
                    listArray2[num] = new List<string>();
                }
                listArray2 = this.dbc.Select(4L, query);
                this.textBoxName.Text = listArray2[0].ElementAt<string>(0);
                this.textBoxFName.Text = listArray2[1].ElementAt<string>(0);
                this.textBoxAddress.Text = listArray2[2].ElementAt<string>(0);
                this.textBoxContact.Text = listArray2[3].ElementAt<string>(0);
                query = "Select vehicleid,chasis_no,engine_no,sale_rate from firoz_center.tbl_vehicle where memo_no='" + text + "';";
                List<string>[] listArray3 = new List<string>[4];
                for (num = 0; num < 4; num++)
                {
                    listArray3[num] = new List<string>();
                }
                listArray3 = this.dbc.Select(4L, query);
                this.textBoxChassis.Text = listArray3[1].ElementAt<string>(0);
                this.textBoxEngine.Text = listArray3[2].ElementAt<string>(0);
                this.textBoxPrice.Text = listArray3[3].ElementAt<string>(0);
                query = "Select brand,model,cc,color from firoz_center.tbl_vehicle_info where vehicle_id='" + listArray3[0].ElementAt<string>(0) + "';";
                List<string>[] listArray4 = new List<string>[4];
                for (num = 0; num < 4; num++)
                {
                    listArray4[num] = new List<string>();
                }
                listArray4 = this.dbc.Select(4L, query);
                this.textBoxBrand.Text = listArray4[0].ElementAt<string>(0);
                this.textBoxModel.Text = listArray4[1].ElementAt<string>(0);
                this.textBoxCC.Text = listArray4[2].ElementAt<string>(0);
                this.textBoxColor.Text = listArray4[3].ElementAt<string>(0);
                this.textBoxDate.Text = this.dbc.SelectSingle("Select DATE_FORMAT(date, '%d-%m-%Y') AS date from firoz_center.tbl_sales_motorcycle where memo_no='" + text + "';");
            }
        }

        private void print_preview_chalan()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_Chalan);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void print_preview_chalan_temp()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_Chalan_Temp);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void print_preview_invoice()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_Invoice);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void print_preview_invoice_temp()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_Invoice_Temp);
            dialog.Document = document;
            dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void textBoxMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.load_transcation();
            }
        }

        private void buttonRegForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_reg_form1();
            }
        }

        private void print_preview_reg_form1()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_reg_form);
            dialog.Document = document;

            Margins margins = new Margins(10, 10, 10, 10);
            document.DefaultPageSettings.Margins = margins;

            //dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void DrawJustifiedLine(Graphics gr, RectangleF rect, Font font, Brush brush, string text)
        {
            // Break the text into words.
            string[] words = text.Split(' ');

            // Add a space to each word and get their lengths.
            float[] word_width = new float[words.Length];
            float total_width = 0;
            for (int i = 0; i < words.Length; i++)
            {
                // See how wide this word is.
                SizeF size = gr.MeasureString(words[i], font);
                word_width[i] = size.Width;
                total_width += word_width[i];
            }

            // Get the additional spacing between words.
            float extra_space = rect.Width - total_width;
            int num_spaces = words.Length - 1;
            if (words.Length > 1) extra_space /= num_spaces;

            // Draw the words.
            float x = rect.Left;
            float y = rect.Top;
            for (int i = 0; i < words.Length; i++)
            {
                // Draw the word.
                gr.DrawString(words[i], font, brush, x, y);

                // Move right to draw the next word.
                x += word_width[i] + extra_space;
            }
        }

        private void Doc_PrintPreview_reg_form(object sender, PrintPageEventArgs e)
        {
            Font header = new Font("Times New Roman", 15f, FontStyle.Bold);
            Font sub_header = new Font("Times New Roman", 15f, FontStyle.Regular);
            Font title = new Font("Times New Roman", 10f, FontStyle.Regular);
            Font content = new Font("Times New Roman", 10f, FontStyle.Bold);
            
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            
            StringFormat format = new StringFormat();
            StringFormat format2 = new StringFormat();
            StringFormat format3 = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Near;
            format2.LineAlignment = StringAlignment.Center;

            int y = 5;

            e.Graphics.DrawString("FORM OF APPLICATION FOR THE REGISTRATION OF MOTOR VEHICLE", header, brush, new Rectangle(30, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("TO BE FILLED BY THE OFFICE", sub_header, brush, new Rectangle(10, y, 820, header.Height), format);
            y = y + 20;
            e.Graphics.DrawString("SECTION I", header, brush, new Rectangle(10, y, 820, header.Height), format);

            y = y + 50;

            e.Graphics.DrawString("Reg. No:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Date:", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("Prev. Reg. No. (If Any):", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("Issue. No:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Date:", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("Issued By:", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("Diary . No:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Date:", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("Received By:", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("Customer Id:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("District :", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("Vehicle Id:", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("Vehicle Description:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Call On Date:", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("Vehicle Description:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;

            e.Graphics.DrawString("Refusal By:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;

            e.Graphics.DrawString("Remarks (If Any):", title, brush, new Rectangle(10, y, 820, header.Height));
            
            y = y + 25;
            e.Graphics.DrawString("TO BE FILLED BY THE OWNER", sub_header, brush, new Rectangle(10, y, 820, header.Height), format);
            y = y + 20;
            e.Graphics.DrawString("SECTION II", header, brush, new Rectangle(10, y, 820, header.Height), format);

            y = y + 40;

            e.Graphics.DrawString("1. Name of Owner: " , title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString(textBoxName.Text, content, brush, new Rectangle(140, y, 820, header.Height));
            e.Graphics.DrawString("3. Date Of Birth:", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("2. Father/Husband Name: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString(textBoxFName.Text, content, brush, new Rectangle(160, y, 820, header.Height));

            e.Graphics.DrawString("4. Nationality:", title, brush, new Rectangle(410, y, 820, header.Height));
            e.Graphics.DrawString("Bangladeshi", content, brush, new Rectangle(500, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("5. Sex:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Male", content, brush, new Rectangle(60, y, 820, header.Height));

            e.Graphics.DrawString("6. Guardian’s Name:  ", title, brush, new Rectangle(410, y, 820, header.Height));
            e.Graphics.DrawString(textBoxFName.Text, content, brush, new Rectangle(540, y, 820, header.Height));

            y = y + 20;

            e.Graphics.DrawString("7. Owner’s Address: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString(textBoxAddress.Text, content, brush, new Rectangle(140, y, 820, header.Height));

            y = y + 20;

            e.Graphics.DrawString("8. Phone No:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString(textBoxContact.Text, content, brush, new Rectangle(100, y, 820, header.Height));

            e.Graphics.DrawString("9. PO/Bank:", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("10. Joint Owner:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("11. Owner Type::", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("12. Hire:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 25;

            e.Graphics.DrawString("(Vehicle Information)", sub_header, brush, new Rectangle(10, y, 820, header.Height), format);
            y = y + 20;
            e.Graphics.DrawString("SECTION III", header, brush, new Rectangle(10, y, 820, header.Height), format);

            y = y + 40;

            e.Graphics.DrawString("14. Vehicle or Trailer:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("M/C", title, brush, new Rectangle(140, y, 820, header.Height));

            e.Graphics.DrawString("15. Prev. Reg. No. (If Any):", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("14. a. Class OF Vehicle: M/C", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("M/C", content, brush, new Rectangle(180, y, 820, header.Height));

            e.Graphics.DrawString("15 .Maker’s Name:", title, brush, new Rectangle(410, y, 820, header.Height));
            e.Graphics.DrawString("HONDA", content, brush, new Rectangle(530, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("16. Type of Body:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("MOTORCYLE", content, brush, new Rectangle(140, y, 820, header.Height));

            e.Graphics.DrawString("17. Maker’s Country:  ", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("18. Color (cabin/body) :", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("19. Year of manufacture :", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("20. Number OF Cylinder", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Single", content, brush, new Rectangle(170, y, 820, header.Height));

            e.Graphics.DrawString("21. Chassis No: ", title, brush, new Rectangle(410, y, 820, header.Height));
            e.Graphics.DrawString(textBoxChassis.Text, content, brush, new Rectangle(520, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("22. Engine No: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString(textBoxEngine.Text, content, brush, new Rectangle(110, y, 820, header.Height));

            e.Graphics.DrawString("23. Fuel Used: Petrol", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("24. Horse Power:", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("25. RPM:", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("26. Cubic Capacity (C.C):", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("27. Seats (Incl.Driver):", title, brush, new Rectangle(410, y, 820, header.Height));
            e.Graphics.DrawString("2 Person", content, brush, new Rectangle(5300, y, 820, header.Height));

            y = y + 20;

            e.Graphics.DrawString("28. No.Of  Standee-", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("29. Wheel Base", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("30. Unladen Weight :", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("31. Maximum laden: ", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("32. Train Weight (kegs)	:", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 25;

            e.Graphics.DrawString("(Additional information for transport vehicle))", sub_header, brush, new Rectangle(10, y, 820, header.Height), format);
            y = y + 20;
            e.Graphics.DrawString("SECTION IV", header, brush, new Rectangle(10, y, 820, header.Height), format);

            y = y + 40;

            e.Graphics.DrawString("32. No. of types :02", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("33. Tires size", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("34. No. of axle : 02", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("35. Maximum axle weight (kg) :", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("a) Front axle   (1) 		(2)", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;
            e.Graphics.DrawString("b) Central axle(1) 	(2) 	(3)", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;
            e.Graphics.DrawString("c) Rear axle    (1) 	(2) 	(3)", title, brush, new Rectangle(410, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("36. Dimensions (mm) :", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("a) Overall length :", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("b) Overall width ", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("c) Overall height:", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 40;

            e.Graphics.DrawString("37. Overhangs (%)", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;
            e.Graphics.DrawString("a) Front ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("b) Rear ", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("c) Other ", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 30;

            DrawJustifiedLineFull("38. A copy of the drawing showing the vehicle dimension specifications of the body and of the seating arrangements approved ", title, brush, new Rectangle(10, y, 820, header.Height), e.Graphics);
            y = y + 20;
            e.Graphics.DrawString("by ........................................on.................................................is attached herewith.", title, brush, new Rectangle(10, y, 820, header.Height));

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_reg_form2();
            }
        }

        private void DrawJustifiedLineFull(string text, Font font, Brush brush, RectangleF rect, Graphics gr)
        {
            // Break the text into words.
            string[] words = text.Split(' ');

            // Add a space to each word and get their lengths.
            float[] word_width = new float[words.Length];
            float total_width = 0;
            for (int i = 0; i < words.Length; i++)
            {
                // See how wide this word is.
                SizeF size = gr.MeasureString(words[i], font);
                word_width[i] = size.Width;
                total_width += word_width[i];
            }

            // Get the additional spacing between words.
            float extra_space = rect.Width - total_width;
            int num_spaces = words.Length - 1;
            if (words.Length > 1) extra_space /= num_spaces;

            // Draw the words.
            float x = rect.Left;
            float y = rect.Top;
            for (int i = 0; i < words.Length; i++)
            {
                // Draw the word.
                gr.DrawString(words[i], font, brush, x, y);

                // Move right to draw the next word.
                x += word_width[i] + extra_space;
            }
        }


        private void print_preview_reg_form2()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_reg_form2);
            dialog.Document = document;

            Margins margins = new Margins(10, 10, 10, 10);
            document.DefaultPageSettings.Margins = margins;

            //dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void Doc_PrintPreview_reg_form2(object sender, PrintPageEventArgs e)
        {
            Font header = new Font("Times New Roman", 15f, FontStyle.Bold);
            Font title = new Font("Times New Roman", 10f, FontStyle.Regular);
            Font content = new Font("Times New Roman", 10f, FontStyle.Bold);

            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);

            StringFormat format = new StringFormat();
            StringFormat format2 = new StringFormat();
            StringFormat format3 = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Near;
            format2.LineAlignment = StringAlignment.Center;

            int y = 5;
            
            e.Graphics.DrawString("SECTION V", header, brush, new Rectangle(10, y, 820, header.Height), format);

            y = y + 20;

            e.Graphics.DrawString("39. Hire purchase/hypothecation information:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;
            e.Graphics.DrawString("The vehicle is subject to hire purchase/hypothecation with:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;

            y += 20;
            e.Graphics.DrawString("a) Name: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("b) Date:", title, brush, new Rectangle(340, y, 820, header.Height));

            y = y + 20;
            e.Graphics.DrawString("Adress:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("40.Insurance information:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("a) Policy no: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("b) Type of policy: ", title, brush, new Rectangle(340, y, 820, header.Height));
            e.Graphics.DrawString("c) Insurer’s name & address:", title, brush, new Rectangle(510, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("d) Date of expiry:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;

            e.Graphics.DrawString("41. Joint owner information:", title, brush, new Rectangle(10, y, 820, header.Height));
            y = y + 20;

            y += 20;
            e.Graphics.DrawString("a) Name: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("b) Name: ", title, brush, new Rectangle(340, y, 820, header.Height));

            y += 20;
            e.Graphics.DrawString("a) Father/Husband: : ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("b) Father/Husband: ", title, brush, new Rectangle(340, y, 820, header.Height));

            y = y + 30;
            e.Graphics.DrawString("SECTION VI", header, brush, new Rectangle(10, y, 820, header.Height), format);
            y += 20;
            e.Graphics.DrawString("(Declaration, Certificates and documents)", title, brush, new Rectangle(10, y, 820, header.Height), format);

            y = y + 20;
            e.Graphics.DrawString("42. Declaration by owner:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;
            DrawJustifiedLineFull("a) I the undersigned do hereby declare that to the best of my knowledge and belief, the information given and the documents", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            DrawJustifiedLineFull("enclosed (as per list attached) are true. I also declare that in case the papers/documents and information furnished is found to be", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            e.Graphics.DrawString("incorrect at any later stage, I shall be liable for legal action", title, brush, new Rectangle(10, y, 800, header.Height));
            y += 40;
            
            e.Graphics.DrawString("Date: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Signature of owner", title, brush, new Rectangle(610, y, 820, header.Height));

            y += 20;

            e.Graphics.DrawString("Encl: List of documents", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Seal", title, brush, new Rectangle(660, y, 820, header.Height));

            y += 30;
            
            e.Graphics.DrawString("43. Registered dealer’s certificate:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;
            DrawJustifiedLineFull("I the undersigned do hereby certify that the vehicle in question has been sold by me/my firm and the ownership Documents", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            DrawJustifiedLineFull("attached with the application for registration are true. Information/specifications pertaining to the vehicle are correct and ", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            e.Graphics.DrawString("the vehicle complies with all the requirements of the registration.", title, brush, new Rectangle(10, y, 800, header.Height));
            y += 40;

            e.Graphics.DrawString("Date: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Signature of owner", title, brush, new Rectangle(610, y, 820, header.Height));
            y += 20;

            e.Graphics.DrawString("Encl: List of documents", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Seal", title, brush, new Rectangle(660, y, 820, header.Height));

            y += 30;
            e.Graphics.DrawString("44. Certificate by the Inspector of Motor Vehicles:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;
            DrawJustifiedLineFull("Certificate that the particulars pertain to the owner and the vehicle Engine No: "+textBoxEngine.Text+" Chassis: "+textBoxChassis.Text +" in", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            DrawJustifiedLineFull("the application match with the ownership documents attached to this application. It is further certified", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            DrawJustifiedLineFull("that the vehicle complies with the registration requirements specified in the MV Act and the Rules and/or Regulations made there", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);
            y += 20;
            DrawJustifiedLineFull("under and the vehicle is not mechanically defective. The necessary documents/papers are available as per list enclosed.", title, brush, new Rectangle(10, y, 800, header.Height), e.Graphics);         
            y += 40;

            e.Graphics.DrawString("Date: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Signature of Inspector of Motor Vehicles", title, brush, new Rectangle(550, y, 820, header.Height));
            y += 20;

            e.Graphics.DrawString("Encl: List of documents", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Seal", title, brush, new Rectangle(660, y, 820, header.Height));
            y += 30;
            
            e.Graphics.DrawString("45. Registration Status:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;
            e.Graphics.DrawString("Registration allowed/not allowed ", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;

            e.Graphics.DrawString("Date: ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Signature of Registering Authority", title, brush, new Rectangle(580, y, 820, header.Height));
            y += 20;

            e.Graphics.DrawString("Seal", title, brush, new Rectangle(660, y, 820, header.Height));
            y += 30;

            e.Graphics.DrawString("46. Fees and Tax Accounts:", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;
            e.Graphics.DrawString("Necessary fees and taxes amounting to taka...........................have been paid to PO/Bank.......................vide vouchers and receipts enclosed.", title, brush, new Rectangle(10, y, 820, header.Height));
            y += 20;
            e.Graphics.DrawString("", title, brush, new Rectangle(10, y, 800, header.Height));
            y += 30;
            
            e.Graphics.DrawString("Signature of owner of his representative                       ", title, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("Signature of dealing assistant", title, brush, new Rectangle(580, y, 820, header.Height));
            y += 50;
            e.Graphics.DrawString("Counter signature by the registering authority", title, brush, new Rectangle(310, y, 820, header.Height));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoice?", "Print Invoice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.print_preview_reg_form3();
            }
        }

        private void print_preview_reg_form3()
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.Doc_PrintPreview_reg_form3);
            dialog.Document = document;
            //dialog.PrintPreviewControl.Zoom = 1.0;
            dialog.ShowDialog();
        }

        private void Doc_PrintPreview_reg_form3(object sender, PrintPageEventArgs e)
        {
            Font header = new Font("Times New Roman", 13f, FontStyle.Bold);
            Font title = new Font("Times New Roman", 15f, FontStyle.Regular);
            Font content = new Font("Times New Roman", 13f, FontStyle.Bold);

            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);

            StringFormat format = new StringFormat();
            StringFormat format2 = new StringFormat();
            StringFormat format3 = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Near;
            format2.LineAlignment = StringAlignment.Center;

            int y = 5;
            e.Graphics.DrawString("OWNER’S PARTICULARS/SPECIMEN SIGNATURE", title, brush, new Rectangle(10, y, 820, title.Height), format);
            y += 60;

            e.Graphics.DrawString("1. NAME: " + textBoxName.Text, header, brush, new Rectangle(10, y, 820, header.Height));
            e.Graphics.DrawString("  3 Copies \n Photograph", header, brush, new Rectangle(610, y, 820, header.Height*3));

            e.Graphics.DrawRectangle(pen, 580, y+40, 200, 250);

            y = y + 40;
            e.Graphics.DrawString("2. FATHER/: HUSBAND: " + textBoxFName.Text, header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("3. ADDRESS: " + textBoxAddress.Text, header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("4. SEX:  Male", header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("5. PHONE NO: " + textBoxContact.Text, header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("6. DATE OF BIRTH: ", header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("7. GUARDIAN’S NAME: " + textBoxFName.Text, header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("8. CHASSIS NO: " + textBoxChassis.Text, header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("9. ENGINE NO: " + textBoxEngine.Text, header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("10. YEAR OF MFG: ", header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("11. PREV. REGN. NO. (IF ANY): ", header, brush, new Rectangle(10, y, 820, header.Height));

            y = y + 40;
            e.Graphics.DrawString("12. P.O./BANK: ", header, brush, new Rectangle(10, y, 820, header.Height));


            y = y + 140;
            e.Graphics.DrawString("SPECIMEN SIGNATURE", header, brush, new Rectangle(10, y, 820, header.Height));

            e.Graphics.DrawRectangle(pen, 50, 760, 250, 50);

            e.Graphics.DrawRectangle(pen, 450, 760, 250, 50);

            e.Graphics.DrawRectangle(pen, 50, 900, 250, 50);

            e.Graphics.DrawRectangle(pen, 450, 900, 250, 50);

        }
    }
}

