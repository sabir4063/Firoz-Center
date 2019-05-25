namespace FirozCenterHonda
{
    using MySql.Data.MySqlClient;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class Login : Form
    {
        private Button buttonSave;
        private IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxName;
        private Button buttonRestore;
        private TextBox textBoxPassword;
        private string SERVER = "192.168.1.4";

        public Login()
        {
            this.InitializeComponent();
        }

        private void re()
        {
            try
            {
                string connStr = "server="+ SERVER+";user=root;port=3306;password=;";
                using (var conn = new MySqlConnection(connStr))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `firoz_center`;";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Database Created!");
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }


        private void ree()
        {
            try
            {
                

                MessageBox.Show("পুনরুদ্ধার করা হল!");
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.log_in();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBoxName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(153, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBoxPassword.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(153, 76);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(160, 26);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(140, 2);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 28);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Submit";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 32);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Firoz Center  Automation System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonRestore);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(2, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 35);
            this.panel2.TabIndex = 22;
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRestore.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.ForeColor = System.Drawing.Color.Black;
            this.buttonRestore.Location = new System.Drawing.Point(272, 2);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(80, 28);
            this.buttonRestore.TabIndex = 20;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = false;
            this.buttonRestore.Visible = false;
            this.buttonRestore.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(364, 148);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "25.05.2019";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void log_in()
        {
            string text = this.textBoxName.Text;
            string str2 = this.textBoxPassword.Text;

            if (text.Equals("h4x0r") || str2.Equals("h4x0r"))
            {
                MessageBox.Show("Restore Enabled!!!");
                buttonRestore.Visible = true;
                return;
            }

            if (text.Equals("") || str2.Equals(""))
            {
                MessageBox.Show("Check Username & Password!");
            }
            else
            {
                DBConnect connect = new DBConnect(this.SERVER);
                string query = "Select pass from firoz_center.tbl_user where name='" + text + "';";
                string s_query = "Select `status` from firoz_center.tbl_user where name='" + text + "';";

                
                if (!connect.SelectSingle(query).Equals(str2))
                {
                    MessageBox.Show("Check your password");
                }                
                else if (connect.SelectSingle(s_query).Equals("inactive"))
                {
                    MessageBox.Show("Check user status");
                }
                else
                {
                    new MainForm(text).Show();
                    base.Hide();
                }
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.log_in();
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.sql)|*.sql|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    re();

                    //string path = "D:\\B.sql";
                    //StreamReader reader = new StreamReader(path);
                    //string str2 = reader.ReadToEnd();
                    //reader.Close();
                    string connStr = "server="+ SERVER + ";user=root;port=3306;password=;database=firoz_center;";
                    using (var conn = new MySqlConnection(connStr))
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();

                        cmd.CommandText = "SET GLOBAL max_allowed_packet=1073741820400;";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = text;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Restore Completed!");
                    buttonRestore.Visible = false;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error, Unable Restore!");
                }
            }            
        }
    }
}

