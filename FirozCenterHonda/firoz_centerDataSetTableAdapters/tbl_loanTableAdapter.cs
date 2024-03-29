﻿namespace FirozCenterHonda.teDataSetTableAdapters
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
    public class tbl_loanTableAdapter : Component
    {
        private MySqlDataAdapter _adapter;
        private bool _clearBeforeFill;
        private MySqlCommand[] _commandCollection;
        private MySqlConnection _connection;
        private MySqlTransaction _transaction;

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_loanTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(uint p1, uint p2, double p3, DateTime p4, string p6, double p7, double p8, double p9)
        {
            int num2;
            this.Adapter.DeleteCommand.Parameters[0].Value = p1;
            this.Adapter.DeleteCommand.Parameters[1].Value = p2;
            this.Adapter.DeleteCommand.Parameters[2].Value = p3;
            this.Adapter.DeleteCommand.Parameters[3].Value = p4;
            if (p6 == null)
            {
                this.Adapter.DeleteCommand.Parameters[4].Value = 1;
                this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[4].Value = 0;
                this.Adapter.DeleteCommand.Parameters[5].Value = p6;
            }
            this.Adapter.DeleteCommand.Parameters[6].Value = p7;
            this.Adapter.DeleteCommand.Parameters[7].Value = p8;
            this.Adapter.DeleteCommand.Parameters[8].Value = p9;
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

        [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Fill(teDataSet.tbl_loanDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual teDataSet.tbl_loanDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            teDataSet.tbl_loanDataTable dataTable = new teDataSet.tbl_loanDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new MySqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "tbl_loan",
                ColumnMappings = { 
                    { 
                        "loan_id",
                        "loan_id"
                    },
                    { 
                        "employee_id",
                        "employee_id"
                    },
                    { 
                        "amount",
                        "amount"
                    },
                    { 
                        "date",
                        "date"
                    },
                    { 
                        "comments",
                        "comments"
                    },
                    { 
                        "paid",
                        "paid"
                    },
                    { 
                        "due",
                        "due"
                    },
                    { 
                        "monthly_payment",
                        "monthly_payment"
                    }
                }
            };
            this._adapter.TableMappings.Add(mapping);
            this._adapter.DeleteCommand = new MySqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `tbl_loan` WHERE ((`loan_id` = @p1) AND (`employee_id` = @p2) AND (`amount` = @p3) AND (`date` = @p4) AND ((@p5 = 1 AND `comments` IS NULL) OR (`comments` = @p6)) AND (`paid` = @p7) AND (`due` = @p8) AND (`monthly_payment` = @p9))";
            this._adapter.DeleteCommand.CommandType = CommandType.Text;
            MySqlParameter parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "loan_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "employee_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "monthly_payment",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            this._adapter.InsertCommand = new MySqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `tbl_loan` (`employee_id`, `amount`, `date`, `comments`, `paid`, `due`, `monthly_payment`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
            this._adapter.InsertCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "employee_id"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "monthly_payment"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            this._adapter.UpdateCommand = new MySqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `tbl_loan` SET `employee_id` = @p1, `amount` = @p2, `date` = @p3, `comments` = @p4, `paid` = @p5, `due` = @p6, `monthly_payment` = @p7 WHERE ((`loan_id` = @p8) AND (`employee_id` = @p9) AND (`amount` = @p10) AND (`date` = @p11) AND ((@p12 = 1 AND `comments` IS NULL) OR (`comments` = @p13)) AND (`paid` = @p14) AND (`due` = @p15) AND (`monthly_payment` = @p16))";
            this._adapter.UpdateCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "employee_id"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "monthly_payment"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "loan_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "employee_id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "amount",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p12",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p13",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "comments",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p14",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "paid",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p15",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "due",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p16",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "monthly_payment",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitCommandCollection()
        {
            this._commandCollection = new MySqlCommand[] { new MySqlCommand() };
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT `loan_id`, `employee_id`, `amount`, `date`, `comments`, `paid`, `due`, `monthly_payment` FROM `tbl_loan`";
            this._commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitConnection()
        {
            this._connection = new MySqlConnection();
            this._connection.ConnectionString = Settings.Default.teConnectionString;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Insert, true), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(uint p1, double p2, DateTime p3, string p4, double p5, double p6, double p7)
        {
            int num2;
            this.Adapter.InsertCommand.Parameters[0].Value = p1;
            this.Adapter.InsertCommand.Parameters[1].Value = p2;
            this.Adapter.InsertCommand.Parameters[2].Value = p3;
            if (p4 == null)
            {
                this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = p4;
            }
            this.Adapter.InsertCommand.Parameters[4].Value = p5;
            this.Adapter.InsertCommand.Parameters[5].Value = p6;
            this.Adapter.InsertCommand.Parameters[6].Value = p7;
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
            return this.Adapter.Update(dataSet, "tbl_loan");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Update(teDataSet.tbl_loanDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Update, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(uint p1, double p2, DateTime p3, string p4, double p5, double p6, double p7, uint p8, uint p9, double p10, DateTime p11, string p13, double p14, double p15, double p16)
        {
            int num2;
            this.Adapter.UpdateCommand.Parameters[0].Value = p1;
            this.Adapter.UpdateCommand.Parameters[1].Value = p2;
            this.Adapter.UpdateCommand.Parameters[2].Value = p3;
            if (p4 == null)
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = p4;
            }
            this.Adapter.UpdateCommand.Parameters[4].Value = p5;
            this.Adapter.UpdateCommand.Parameters[5].Value = p6;
            this.Adapter.UpdateCommand.Parameters[6].Value = p7;
            this.Adapter.UpdateCommand.Parameters[7].Value = p8;
            this.Adapter.UpdateCommand.Parameters[8].Value = p9;
            this.Adapter.UpdateCommand.Parameters[9].Value = p10;
            this.Adapter.UpdateCommand.Parameters[10].Value = p11;
            if (p13 == null)
            {
                this.Adapter.UpdateCommand.Parameters[11].Value = 1;
                this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[11].Value = 0;
                this.Adapter.UpdateCommand.Parameters[12].Value = p13;
            }
            this.Adapter.UpdateCommand.Parameters[13].Value = p14;
            this.Adapter.UpdateCommand.Parameters[14].Value = p15;
            this.Adapter.UpdateCommand.Parameters[15].Value = p16;
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

