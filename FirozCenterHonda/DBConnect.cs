namespace FirozCenterHonda
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    internal class DBConnect
    {
        private MySqlConnection connection;
        private string database;
        private string password;
        private string server;
        private string uid;
        private string DB_LOC = "";

        public DBConnect()
        {
            this.Initialize("root", "", "192.168.1.4");
        }

        public DBConnect(string ip)
        {
            this.Initialize("root", "", ip);
        }

        public DBConnect(string name, string password, string ip)
        {
            this.Initialize(name, password, ip);
        }


        public void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        
        public void Backup()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            string FILE_LOCATION = "C:\\SW\\";
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FILE_LOCATION = FBD.SelectedPath+"\\";
            }

            try
            {
                DateTime now = DateTime.Now;
                long year = now.Year;
                long month = now.Month;
                long day = now.Day;
                long hour = now.Hour;
                long minute = now.Minute;
                long second = now.Second;
                long millisecond = now.Millisecond;
                StreamWriter writer = new StreamWriter(string.Concat(new object[] { @FILE_LOCATION, year, "-", month, "-", day, "-", hour, "-", minute, "-", second, "-", millisecond, ".sql" }));
                ProcessStartInfo startInfo = new ProcessStartInfo {
                    FileName = @"C:\xampp\mysql\bin\mysqldump.exe",
                    RedirectStandardInput = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Format("-u{0} -p{1} -h{2} {3}", new object[] { 
                        this.uid,
                        this.password,
                        this.server,
                        this.database
                    }),
                    UseShellExecute = false
                };
                Process process = Process.Start(startInfo);
                string str2 = process.StandardOutput.ReadToEnd();
                writer.WriteLine(str2);
                process.WaitForExit();
                writer.Close();
                process.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }
        

        public bool CloseConnection()
        {
            try
            {
                this.connection.Close();
                return true;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public long Count(string query)
        {
            long num = -1L;
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        reader.Close();
                        this.CloseConnection();
                        return -1L;
                    }
                    num += 1L;
                }
                reader.Close();
                this.CloseConnection();
                return num;
            }
            return num;
        }

        public void Delete(string query)
        {
            if (this.OpenConnection())
            {
                new MySqlCommand(query, this.connection).ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public string getDate(string d)
        {
            string[] strArray = d.Split(new char[] { '/', ' ' });
            return (this.getMonthName(long.Parse(strArray[0])) + "-" + strArray[2]);
        }

        public string getFullDate(string d)
        {
            string[] strArray = d.Split(new char[] { ' ', '/' });
            return (strArray[2] + "-" + this.getMonthName(long.Parse(strArray[0])) + "-" + strArray[1]);
        }

        public string getMonthName(long m)
        {
            if (m == 1L)
            {
                return "January";
            }
            if (m == 2L)
            {
                return "February";
            }
            if (m == 3L)
            {
                return "March";
            }
            if (m == 4L)
            {
                return "April";
            }
            if (m == 5L)
            {
                return "May";
            }
            if (m == 6L)
            {
                return "June";
            }
            if (m == 7L)
            {
                return "July";
            }
            if (m == 8L)
            {
                return "August";
            }
            if (m == 9L)
            {
                return "September";
            }
            if (m == 10L)
            {
                return "October";
            }
            if (m == 11L)
            {
                return "November";
            }
            return "December";
        }

        private void Initialize(string name, string password, string ip)
        {
            this.server = ip;
            this.database = "firoz_center";
            this.uid = name;
            this.password = password;
            string connectionString = "SERVER=" + this.server + ";DATABASE=" + this.database + ";UID=" + this.uid + ";PASSWORD=" + password + "; PORT=3306; ";
            this.connection = new MySqlConnection(connectionString);
        }

        public void Insert(string query)
        {
            try
            {
                if (this.OpenConnection())
                {
                    new MySqlCommand(query, this.connection).ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check Data Again!!");
                this.CloseConnection();
            }
        }

        public string NumberToText(string only_number)
        {
            double num = double.Parse(only_number);
            if (num < 0.0)
            {
                num *= -1.0;
            }
            only_number = num.ToString();
            string str = "";
            string[] strArray = new string[] { " ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] strArray2 = new string[] { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] strArray3 = new string[] { " ", " ", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] strArray4 = new string[] { 
                "Vigintillion", "Novemdecillion", "Octodecillion", "Septendecillion", "Sexdecillion", "Quindecillion", "quattuordecillion", "Tredecillion", "Duodecillion", "Undecillion", "Decillion", "Nonillion", "Octillion", "Septillion", "Sextillion", "Quintillion",
                "Quadrillion", "Trillion ", "Billion ", "Million ", "Thounsand ", "Hundred "
            };
            string[] strArray5 = new string[150];
            int length = only_number.Length;
            int num6 = 0;
            int index = 0;
            int num3 = 0;
            while (index < length)
            {
                int num4 = (length - index) % 3;
                if (num4 != 0)
                {
                    num6 = 0;
                }
                if (only_number[index] != '0')
                {
                    switch (num4)
                    {
                        case 1:
                            strArray5[num3++] = strArray[only_number[index] - '0'];
                            num6 = 1;
                            break;

                        case 2:
                            if (only_number[index] == '1')
                            {
                                strArray5[num3++] = strArray2[only_number[++index] - '0'];
                            }
                            else
                            {
                                strArray5[num3++] = strArray3[only_number[index] - '0'];
                            }
                            num6 = 1;
                            break;

                        case 0:
                            strArray5[num3++] = strArray[only_number[index] - '0'];
                            strArray5[num3++] = strArray4[0x15];
                            num6 = 1;
                            break;
                    }
                }
                if (num6 != 0)
                {
                    int num7 = length - index;
                    if (num7 <= 0x1f)
                    {
                        switch (num7)
                        {
                            case 10:
                                strArray5[num3++] = strArray4[0x12];
                                break;

                            case 13:
                                strArray5[num3++] = strArray4[0x11];
                                break;

                            case 0x10:
                                strArray5[num3++] = strArray4[0x10];
                                break;

                            case 4:
                                goto Label_05EE;

                            case 7:
                                goto Label_05DD;

                            case 0x13:
                                goto Label_0599;

                            case 0x16:
                                goto Label_0588;

                            case 0x19:
                                strArray5[num3++] = strArray4[13];
                                break;

                            case 0x1c:
                                strArray5[num3++] = strArray4[12];
                                break;

                            case 0x1f:
                                strArray5[num3++] = strArray4[11];
                                break;
                        }
                    }
                    else if (num7 <= 0x2e)
                    {
                        switch (num7)
                        {
                            case 40:
                                strArray5[num3++] = strArray4[8];
                                break;

                            case 0x2b:
                                strArray5[num3++] = strArray4[7];
                                break;

                            case 0x2e:
                                strArray5[num3++] = strArray4[6];
                                break;

                            case 0x22:
                                goto Label_053B;

                            case 0x25:
                                goto Label_0527;
                        }
                    }
                    else if (num7 <= 0x37)
                    {
                        switch (num7)
                        {
                            case 0x31:
                                goto Label_04DB;

                            case 0x34:
                                goto Label_04C8;

                            case 0x37:
                                goto Label_04B5;
                        }
                    }
                    else
                    {
                        switch (num7)
                        {
                            case 0x3a:
                                strArray5[num3++] = strArray4[2];
                                goto Label_0600;

                            case 0x3d:
                                strArray5[num3++] = strArray4[1];
                                goto Label_0600;
                        }
                        if (num7 == 0x40)
                        {
                            strArray5[num3++] = strArray4[0];
                        }
                    }
                }
                goto Label_0600;
            Label_04B5:
                strArray5[num3++] = strArray4[3];
                goto Label_0600;
            Label_04C8:
                strArray5[num3++] = strArray4[4];
                goto Label_0600;
            Label_04DB:
                strArray5[num3++] = strArray4[5];
                goto Label_0600;
            Label_0527:
                strArray5[num3++] = strArray4[9];
                goto Label_0600;
            Label_053B:
                strArray5[num3++] = strArray4[10];
                goto Label_0600;
            Label_0588:
                strArray5[num3++] = strArray4[14];
                goto Label_0600;
            Label_0599:
                strArray5[num3++] = strArray4[15];
                goto Label_0600;
            Label_05DD:
                strArray5[num3++] = strArray4[0x13];
                goto Label_0600;
            Label_05EE:
                strArray5[num3++] = strArray4[20];
            Label_0600:
                index++;
            }
            num3--;
            str = strArray5[0];
            for (index = 1; index <= num3; index++)
            {
                str = str + strArray5[index];
            }
            return str;
        }

        public bool OpenConnection()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch (MySqlException exception)
            {
                switch (exception.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 0x415:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /*
        public void Restore()
        {
            try
            {
                string path = @"C:\Backup\MySqlBackup.sql";
                StreamReader reader = new StreamReader(path);
                string str2 = reader.ReadToEnd();
                reader.Close();
                ProcessStartInfo startInfo = new ProcessStartInfo {
                    FileName = @"C:\Program Files (x86)\MySQL\MySQL Server 5.1\bin\mysql.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    Arguments = string.Format("-u{0} -p{1} -h{2} {3}", new object[] { 
                        this.uid,
                        this.password,
                        this.server,
                        this.database
                    }),
                    UseShellExecute = false
                };
                Process process = Process.Start(startInfo);
                process.StandardInput.WriteLine(str2);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
        */

        public string Select(string query)
        {
            string str = "";
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetDateTime(0).ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
                }
                reader.Close();
                this.CloseConnection();
                return str;
            }
            return str;
        }

        public List<string>[] Select(long n, string query)
        {
            List<string>[] listArray = new List<string>[n];
            int index = 0;
            while (index < n)
            {
                listArray[index] = new List<string>();
                index++;
            }
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for (index = 0; index < n; index++)
                        {
                            if (reader.GetString(index).Equals((string) null))
                            {
                                listArray[index].Add("");
                            }
                            else
                            {
                                listArray[index].Add(reader.GetString(index));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Check Again!");
                }
                reader.Close();
                this.CloseConnection();
                return listArray;
            }
            return listArray;
        }

        public string Select_Date(string query)
        {
            string str = "";
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetDateTime(0).ToString("yyyy-MMM-dd", CultureInfo.InvariantCulture);
                }
                reader.Close();
                this.CloseConnection();
                return str;
            }
            return str;
        }

        public string Select_Date_Format(string query)
        {
            string str = "";
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetDateTime(0).ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture);
                }
                reader.Close();
                this.CloseConnection();
                return str;
            }
            return str;
        }

        public string Select_Date_Format_2(string query)
        {
            string str = "";
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetDateTime(0).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                reader.Close();
                this.CloseConnection();
                return str;
            }
            return str;
        }

        public string SelectSingle(string query)
        {
            string str = "";
            if (this.OpenConnection())
            {
                MySqlDataReader reader = new MySqlCommand(query, this.connection).ExecuteReader();
                while (reader.Read())
                {
                    str = reader.GetString(0);
                }
                reader.Close();
                this.CloseConnection();
                return str;
            }
            return str;
        }

        public void Update(string query)
        {
            if (this.OpenConnection())
            {
                new MySqlCommand { 
                    CommandText = query,
                    Connection = this.connection
                }.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void RestoreDatabase(string ExeLocation, string DBName)
        {
            /*
            try
            {
                string sql = "drop schema if exists firoz_center;";
                Delete(sql);

                string path = @"D:\SW\Backup.sql";
                StreamReader reader = new StreamReader(path);
                string str2 = reader.ReadToEnd();
                reader.Close();
                string str3 = string.Format("-u{0} -p{1} --databases{2}", " root", " 101proof", DBName);
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ExeLocation,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    Arguments = string.Format("-u{0} {1} {2}", " root", " 101proof", " firoz_center"),
                    UseShellExecute = false
                };
                Process process = Process.Start(startInfo);
                process.StandardInput.WriteLine(str2);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
                MessageBox.Show("পুনরুদ্ধার করা হল!");
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
            */
        }

        public void DatabaseBackup(string ExeLocation, string DBName)
        {
            try
            {
                string str = "";
                str = (DBName + "-" + DateTime.Now.ToShortDateString() + ".sql").Replace("/", "-");
                StreamWriter writer = new StreamWriter("C:/SW/" + str);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                string str2 = string.Format("-u{0} -p{1} -h{2} -P{3} {4}", new object[] { "root", "", "192.168.35.1", "3306", DBName });
                startInfo.FileName = ExeLocation;
                startInfo.RedirectStandardInput = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.Arguments = str2;
                startInfo.UseShellExecute = false;
                Process process = Process.Start(startInfo);
                string str3 = process.StandardOutput.ReadToEnd();
                writer.WriteLine(str3);
                process.WaitForExit();
                writer.Close();
                MessageBox.Show("Backup Completed");
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }
    }
}

