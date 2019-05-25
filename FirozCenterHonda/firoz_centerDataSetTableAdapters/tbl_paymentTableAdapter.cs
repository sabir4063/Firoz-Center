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

    [DesignerCategory("code"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), HelpKeyword("vs.data.TableAdapter"), ToolboxItem(true), DataObject(true)]
    public class tbl_paymentTableAdapter : Component
    {
        private MySqlDataAdapter _adapter;
        private bool _clearBeforeFill;
        private MySqlCommand[] _commandCollection;
        private MySqlConnection _connection;
        private MySqlTransaction _transaction;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public tbl_paymentTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Delete, true)]
        public virtual int Delete(uint p1, string p2, DateTime p3, string p4, double p5, uint p6, string p8)
        {
            int num2;
            this.Adapter.DeleteCommand.Parameters[0].Value = p1;
            if (p2 == null)
            {
                throw new ArgumentNullException("p2");
            }
            this.Adapter.DeleteCommand.Parameters[1].Value = p2;
            this.Adapter.DeleteCommand.Parameters[2].Value = p3;
            if (p4 == null)
            {
                throw new ArgumentNullException("p4");
            }
            this.Adapter.DeleteCommand.Parameters[3].Value = p4;
            this.Adapter.DeleteCommand.Parameters[4].Value = p5;
            this.Adapter.DeleteCommand.Parameters[5].Value = p6;
            if (p8 == null)
            {
                this.Adapter.DeleteCommand.Parameters[6].Value = 1;
                this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[6].Value = 0;
                this.Adapter.DeleteCommand.Parameters[7].Value = p8;
            }
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

        [DataObjectMethod(DataObjectMethodType.Fill, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Fill(teDataSet.tbl_paymentDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual teDataSet.tbl_paymentDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            teDataSet.tbl_paymentDataTable dataTable = new teDataSet.tbl_paymentDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new MySqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "tbl_payment",
                ColumnMappings = { 
                    { 
                        "payment_id",
                        "payment_id"
                    },
                    { 
                        "memo_no",
                        "memo_no"
                    },
                    { 
                        "date",
                        "date"
                    },
                    { 
                        "customer_id",
                        "customer_id"
                    },
                    { 
                        "amount",
                        "amount"
                    },
                    { 
                        "user_id",
                        "user_id"
                    },
                    { 
                        "comments",
                        "comments"
                    }
                }
            };
            this._adapter.TableMappings.Add(mapping);
            this._adapter.DeleteCommand = new MySqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `tbl_payment` WHERE ((`payment_id` = @p1) AND (`memo_no` = @p2) AND (`date` = @p3) AND (`customer_id` = @p4) AND (`amount` = @p5) AND (`user_id` = @p6) AND ((@p7 = 1 AND `comments` IS NULL) OR (`comments` = @p8)))";
            this._adapter.DeleteCommand.CommandType = CommandType.Text;
            MySqlParameter parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "payment_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "customer_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount",
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
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            this._adapter.InsertCommand = new MySqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `tbl_payment` (`memo_no`, `date`, `customer_id`, `amount`, `user_id`, `comments`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            this._adapter.InsertCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "customer_id"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount"
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
            this._adapter.UpdateCommand = new MySqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `tbl_payment` SET `memo_no` = @p1, `date` = @p2, `customer_id` = @p3, `amount` = @p4, `user_id` = @p5, `comments` = @p6 WHERE ((`payment_id` = @p7) AND (`memo_no` = @p8) AND (`date` = @p9) AND (`customer_id` = @p10) AND (`amount` = @p11) AND (`user_id` = @p12) AND ((@p13 = 1 AND `comments` IS NULL) OR (`comments` = @p14)))";
            this._adapter.UpdateCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "customer_id"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount"
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
                SourceColumn = "payment_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "customer_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p12",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "user_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p13",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p14",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new MySqlCommand[] { new MySqlCommand() };
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT `payment_id`, `memo_no`, `date`, `customer_id`, `amount`, `user_id`, `comments` FROM `tbl_payment`";
            this._commandCollection[0].CommandType = CommandType.Text;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new MySqlConnection();
            this._connection.ConnectionString = Settings.Default.teConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Insert(string p1, DateTime p2, string p3, double p4, uint p5, string p6)
        {
            int num2;
            if (p1 == null)
            {
                throw new ArgumentNullException("p1");
            }
            this.Adapter.InsertCommand.Parameters[0].Value = p1;
            this.Adapter.InsertCommand.Parameters[1].Value = p2;
            if (p3 == null)
            {
                throw new ArgumentNullException("p3");
            }
            this.Adapter.InsertCommand.Parameters[2].Value = p3;
            this.Adapter.InsertCommand.Parameters[3].Value = p4;
            this.Adapter.InsertCommand.Parameters[4].Value = p5;
            if (p6 == null)
            {
                this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = p6;
            }
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

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(teDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "tbl_payment");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Update(teDataSet.tbl_paymentDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string p1, DateTime p2, string p3, double p4, uint p5, string p6, uint p7, string p8, DateTime p9, string p10, double p11, uint p12, string p14)
        {
            int num2;
            if (p1 == null)
            {
                throw new ArgumentNullException("p1");
            }
            this.Adapter.UpdateCommand.Parameters[0].Value = p1;
            this.Adapter.UpdateCommand.Parameters[1].Value = p2;
            if (p3 == null)
            {
                throw new ArgumentNullException("p3");
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = p3;
            this.Adapter.UpdateCommand.Parameters[3].Value = p4;
            this.Adapter.UpdateCommand.Parameters[4].Value = p5;
            if (p6 == null)
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = p6;
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = p7;
            if (p8 == null)
            {
                throw new ArgumentNullException("p8");
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = p8;
            this.Adapter.UpdateCommand.Parameters[8].Value = p9;
            if (p10 == null)
            {
                throw new ArgumentNullException("p10");
            }
            this.Adapter.UpdateCommand.Parameters[9].Value = p10;
            this.Adapter.UpdateCommand.Parameters[10].Value = p11;
            this.Adapter.UpdateCommand.Parameters[11].Value = p12;
            if (p14 == null)
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = 1;
                this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = 0;
                this.Adapter.UpdateCommand.Parameters[13].Value = p14;
            }
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

