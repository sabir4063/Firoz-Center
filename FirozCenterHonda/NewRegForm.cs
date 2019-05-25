using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirozCenterHonda
{
    public partial class NewRegForm : Form
    {
        public NewRegForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            totalnumber = 0;
            images[0] = System.Drawing.Image.FromFile(@"c:\Image\FORM OF APPLICATION FOR THE REGISTRATION OF MOTOR VEHICLE-1.jpg");
            images[1] = System.Drawing.Image.FromFile(@"c:\Image\FORM OF APPLICATION FOR THE REGISTRATION OF MOTOR VEHICLE-2.jpg");
            images[2] = System.Drawing.Image.FromFile(@"c:\Image\FORM OF APPLICATION FOR THE REGISTRATION OF MOTOR VEHICLE-3.jpg");

            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();

            document.PrintPage += new PrintPageEventHandler(this.PrintPage);
            printPrvDlg.Document = document;
            document.Print();

        }

        int totalnumber = 0;//this is for total number of items of the list or array
        Image[] images = new Image[3];

        //The Print Event handeler
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            
            Rectangle m = e.MarginBounds;

            Graphics g = e.Graphics;

            g.DrawImage(images[totalnumber], m);
            e.HasMorePages = ++totalnumber < this.images.Length;

            g.Dispose();
        }
    }
}
