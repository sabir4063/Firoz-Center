namespace FirozCenterHonda.teDataSetTableAdapters
{
    using FirozCenterHonda;
    using FirozCenterHonda.Properties;
    using MySql.Data.MySqlClient;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics;

    [ToolboxItem(true), HelpKeyword("vs.data.TableAdapter"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code"), DataObject(true)]
    public class tbl_sales_serviceTableAdapter : Component
    {
        private MySqlDataAdapter _adapter;
        private bool _clearBeforeFill;
        private MySqlCommand[] _commandCollection;
        private MySqlConnection _connection;
        private MySqlTransaction _transaction;

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_sales_serviceTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(uint p1, DateTime p2, double p3, double p4, double p5, uint p6, string p7, uint p8, string p9, double p10, double p11)
        {
            int num2;
            this.Adapter.DeleteCommand.Parameters[0].Value = p1;
            this.Adapter.DeleteCommand.Parameters[1].Value = p2;
            this.Adapter.DeleteCommand.Parameters[2].Value = p3;
            this.Adapter.DeleteCommand.Parameters[3].Value = p4;
            this.Adapter.DeleteCommand.Parameters[4].Value = p5;
            this.Adapter.DeleteCommand.Parameters[5].Value = p6;
            if (p7 == null)
            {
                throw new ArgumentNullException("p7");
            }
            this.Adapter.DeleteCommand.Parameters[6].Value = p7;
            this.Adapter.DeleteCommand.Parameters[7].Value = p8;
            if (p9 == null)
            {
                throw new ArgumentNullException("p9");
            }
            this.Adapter.DeleteCommand.Parameters[8].Value = p9;
            this.Adapter.DeleteCommand.Parameters[9].Value = p10;
            this.Adapter.DeleteCommand.Parameters[10].Value = p11;
            ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
            if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                num2 = this.Adapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
            return num2;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, true)]
        public virtual int Fill(teDataSet.tbl_sales_serviceDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual teDataSet.tbl_sales_serviceDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            teDataSet.tbl_sales_serviceDataTable dataTable = new teDataSet.tbl_sales_serviceDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitAdapter()
        {
            this._adapter = new MySqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "tbl_sales_service",
                ColumnMappings = { 
                    { 
                        "memo_no",
                        "memo_no"
                    },
                    { 
                        "date",
                        "date"
                    },
                    { 
                        "grand_total",
                        "grand_total"
                    },
                    { 
                        "discount",
                        "discount"
                    },
                    { 
                        "net_amount",
                        "net_amount"
                    },
                    { 
                        "user_id",
                        "user_id"
                    },
                    { 
                        "comments",
                        "comments"
                    },
                    { 
                        "customer_id",
                        "customer_id"
                    },
                    { 
                        "type",
                        "type"
                    },
                    { 
                        "paid_amount",
                        "paid_amount"
                    },
                    { 
                        "due_amount",
                        "due_amount"
                    }
                }
            };
            this._adapter.TableMappings.Add(mapping);
            this._adapter.DeleteCommand = new MySqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `tbl_sales_service` WHERE ((`memo_no` = @p1) AND (`date` = @p2) AND (`grand_total` = @p3) AND (`discount` = @p4) AND (`net_amount` = @p5) AND (`user_id` = @p6) AND (`comments` = @p7) AND (`customer_id` = @p8) AND (`type` = @p9) AND (`paid_amount` = @p10) AND (`due_amount` = @p11))";
            this._adapter.DeleteCommand.CommandType = CommandType.Text;
            MySqlParameter parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.Date,
                MySqlDbType = MySqlDbType.Date,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "grand_total",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "discount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "net_amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "user_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "customer_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "type",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid_amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due_amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            this._adapter.InsertCommand = new MySqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `tbl_sales_service` (`date`, `grand_total`, `discount`, `net_amount`, `user_id`, `comments`, `customer_id`, `type`, `paid_amount`, `due_amount`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";
            this._adapter.InsertCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.Date,
                MySqlDbType = MySqlDbType.Date,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "grand_total"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "discount"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "net_amount"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "user_id"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "customer_id"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "type"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid_amount"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due_amount"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            this._adapter.UpdateCommand = new MySqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `tbl_sales_service` SET `date` = @p1, `grand_total` = @p2, `discount` = @p3, `net_amount` = @p4, `user_id` = @p5, `comments` = @p6, `customer_id` = @p7, `type` = @p8, `paid_amount` = @p9, `due_amount` = @p10 WHERE ((`memo_no` = @p11) AND (`date` = @p12) AND (`grand_total` = @p13) AND (`discount` = @p14) AND (`net_amount` = @p15) AND (`user_id` = @p16) AND (`comments` = @p17) AND (`customer_id` = @p18) AND (`type` = @p19) AND (`paid_amount` = @p20) AND (`due_amount` = @p21))";
            this._adapter.UpdateCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.Date,
                MySqlDbType = MySqlDbType.Date,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "grand_total"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "discount"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "net_amount"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "user_id"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "customer_id"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "type"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid_amount"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due_amount"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p12",
                DbType = DbType.Date,
                MySqlDbType = MySqlDbType.Date,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p13",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "grand_total",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p14",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "discount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p15",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "net_amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p16",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "user_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p17",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p18",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "customer_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p19",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "type",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p20",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid_amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p21",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due_amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitCommandCollection()
        {
            this._commandCollection = new MySqlCommand[] { new MySqlCommand() };
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT `memo_no`, `date`, `grand_total`, `discount`, `net_amount`, `user_id`, `comments`, `customer_id`, `type`, `paid_amount`, `due_amount` FROM `tbl_sales_service`";
            this._commandCollection[0].CommandType = CommandType.Text;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new MySqlConnection();
            this._connection.ConnectionString = Settings.Default.teConnectionString;
        }

        [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Insert, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(DateTime p1, double p2, double p3, double p4, uint p5, string p6, uint p7, string p8, double p9, double p10)
        {
            int num2;
            this.Adapter.InsertCommand.Parameters[0].Value = p1;
            this.Adapter.InsertCommand.Parameters[1].Value = p2;
            this.Adapter.InsertCommand.Parameters[2].Value = p3;
            this.Adapter.InsertCommand.Parameters[3].Value = p4;
            this.Adapter.InsertCommand.Parameters[4].Value = p5;
            if (p6 == null)
            {
                throw new ArgumentNullException("p6");
            }
            this.Adapter.InsertCommand.Parameters[5].Value = p6;
            this.Adapter.InsertCommand.Parameters[6].Value = p7;
            if (p8 == null)
            {
                throw new ArgumentNullException("p8");
            }
            this.Adapter.InsertCommand.Parameters[7].Value = p8;
            this.Adapter.InsertCommand.Parameters[8].Value = p9;
            this.Adapter.InsertCommand.Parameters[9].Value = p10;
            ConnectionState state = this.Adapter.InsertCommand.Connection.State;
            if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                num2 = this.Adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
            return num2;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(teDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "tbl_sales_service");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(teDataSet.tbl_sales_serviceDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Update, true), DebuggerNonUserCode]
        public virtual int Update(DateTime p1, double p2, double p3, double p4, uint p5, string p6, uint p7, string p8, double p9, double p10, uint p11, DateTime p12, double p13, double p14, double p15, uint p16, string p17, uint p18, string p19, double p20, double p21)
        {
            int num2;
            this.Adapter.UpdateCommand.Parameters[0].Value = p1;
            this.Adapter.UpdateCommand.Parameters[1].Value = p2;
            this.Adapter.UpdateCommand.Parameters[2].Value = p3;
            this.Adapter.UpdateCommand.Parameters[3].Value = p4;
            this.Adapter.UpdateCommand.Parameters[4].Value = p5;
            if (p6 == null)
            {
                throw new ArgumentNullException("p6");
            }
            this.Adapter.UpdateCommand.Parameters[5].Value = p6;
            this.Adapter.UpdateCommand.Parameters[6].Value = p7;
            if (p8 == null)
            {
                throw new ArgumentNullException("p8");
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = p8;
            this.Adapter.UpdateCommand.Parameters[8].Value = p9;
            this.Adapter.UpdateCommand.Parameters[9].Value = p10;
            this.Adapter.UpdateCommand.Parameters[10].Value = p11;
            this.Adapter.UpdateCommand.Parameters[11].Value = p12;
            this.Adapter.UpdateCommand.Parameters[12].Value = p13;
            this.Adapter.UpdateCommand.Parameters[13].Value = p14;
            this.Adapter.UpdateCommand.Parameters[14].Value = p15;
            this.Adapter.UpdateCommand.Parameters[15].Value = p16;
            if (p17 == null)
            {
                throw new ArgumentNullException("p17");
            }
            this.Adapter.UpdateCommand.Parameters[0x10].Value = p17;
            this.Adapter.UpdateCommand.Parameters[0x11].Value = p18;
            if (p19 == null)
            {
                throw new ArgumentNullException("p19");
            }
            this.Adapter.UpdateCommand.Parameters[0x12].Value = p19;
            this.Adapter.UpdateCommand.Parameters[0x13].Value = p20;
            this.Adapter.UpdateCommand.Parameters[20].Value = p21;
            ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
            if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                num2 = this.Adapter.UpdateCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
            return num2;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal MySqlDataAdapter Adapter
        {
            get
            {
                if (this._adapter == null)
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected MySqlCommand[] CommandCollection
        {
            get
            {
                if (this._commandCollection == null)
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal MySqlConnection Connection
        {
            get
            {
                if (this._connection == null)
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if (this.Adapter.InsertCommand != null)
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if (this.Adapter.DeleteCommand != null)
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if (this.Adapter.UpdateCommand != null)
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; i < this.CommandCollection.Length; i++)
                {
                    if (this.CommandCollection[i] != null)
                    {
                        this.CommandCollection[i].Connection = value;
                    }
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal MySqlTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; i < this.CommandCollection.Length; i++)
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if ((this.Adapter != null) && (this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if ((this.Adapter != null) && (this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if ((this.Adapter != null) && (this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
    }
}

