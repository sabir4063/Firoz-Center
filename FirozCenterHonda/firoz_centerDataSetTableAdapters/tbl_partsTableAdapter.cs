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

    [HelpKeyword("vs.data.TableAdapter"), DesignerCategory("code"), ToolboxItem(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DataObject(true)]
    public class tbl_partsTableAdapter : Component
    {
        private MySqlDataAdapter _adapter;
        private bool _clearBeforeFill;
        private MySqlCommand[] _commandCollection;
        private MySqlConnection _connection;
        private MySqlTransaction _transaction;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public tbl_partsTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Delete, true), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(uint p1, string p3, uint p4, double? p6, string p7, double? p9, string p11)
        {
            int num2;
            this.Adapter.DeleteCommand.Parameters[0].Value = p1;
            if (p3 == null)
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = 1;
                this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = 0;
                this.Adapter.DeleteCommand.Parameters[2].Value = p3;
            }
            this.Adapter.DeleteCommand.Parameters[3].Value = p4;
            if (p6.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[4].Value = 0;
                this.Adapter.DeleteCommand.Parameters[5].Value = p6.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[4].Value = 1;
                this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
            }
            if (p7 == null)
            {
                throw new ArgumentNullException("p7");
            }
            this.Adapter.DeleteCommand.Parameters[6].Value = p7;
            if (p9.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = 0;
                this.Adapter.DeleteCommand.Parameters[8].Value = p9.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = 1;
                this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
            }
            if (p11 == null)
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = 1;
                this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = 0;
                this.Adapter.DeleteCommand.Parameters[10].Value = p11;
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

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Fill, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Fill(teDataSet.tbl_partsDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Select, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual teDataSet.tbl_partsDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            teDataSet.tbl_partsDataTable dataTable = new teDataSet.tbl_partsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new MySqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "tbl_parts",
                ColumnMappings = { 
                    { 
                        "id",
                        "id"
                    },
                    { 
                        "invoice_no",
                        "invoice_no"
                    },
                    { 
                        "partsId",
                        "partsId"
                    },
                    { 
                        "purchase_rate",
                        "purchase_rate"
                    },
                    { 
                        "status",
                        "status"
                    },
                    { 
                        "sale_rate",
                        "sale_rate"
                    },
                    { 
                        "memo_no",
                        "memo_no"
                    }
                }
            };
            this._adapter.TableMappings.Add(mapping);
            this._adapter.DeleteCommand = new MySqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `tbl_parts` WHERE ((`id` = @p1) AND ((@p2 = 1 AND `invoice_no` IS NULL) OR (`invoice_no` = @p3)) AND (`partsId` = @p4) AND ((@p5 = 1 AND `purchase_rate` IS NULL) OR (`purchase_rate` = @p6)) AND (`status` = @p7) AND ((@p8 = 1 AND `sale_rate` IS NULL) OR (`sale_rate` = @p9)) AND ((@p10 = 1 AND `memo_no` IS NULL) OR (`memo_no` = @p11)))";
            this._adapter.DeleteCommand.CommandType = CommandType.Text;
            MySqlParameter parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "invoice_no",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "invoice_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "partsId",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "purchase_rate",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_rate",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "status",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "sale_rate",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_rate",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            this._adapter.InsertCommand = new MySqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `tbl_parts` (`invoice_no`, `partsId`, `purchase_rate`, `status`, `sale_rate`, `memo_no`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            this._adapter.InsertCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "invoice_no"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "partsId"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_rate"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "status"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_rate"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            this._adapter.UpdateCommand = new MySqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `tbl_parts` SET `invoice_no` = @p1, `partsId` = @p2, `purchase_rate` = @p3, `status` = @p4, `sale_rate` = @p5, `memo_no` = @p6 WHERE ((`id` = @p7) AND ((@p8 = 1 AND `invoice_no` IS NULL) OR (`invoice_no` = @p9)) AND (`partsId` = @p10) AND ((@p11 = 1 AND `purchase_rate` IS NULL) OR (`purchase_rate` = @p12)) AND (`status` = @p13) AND ((@p14 = 1 AND `sale_rate` IS NULL) OR (`sale_rate` = @p15)) AND ((@p16 = 1 AND `memo_no` IS NULL) OR (`memo_no` = @p17)))";
            this._adapter.UpdateCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "invoice_no"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "partsId"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_rate"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "status"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_rate"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "id",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "invoice_no",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "invoice_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "partsId",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "purchase_rate",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p12",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_rate",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p13",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "status",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p14",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "sale_rate",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p15",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_rate",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p16",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p17",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "memo_no",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new MySqlCommand[] { new MySqlCommand() };
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT `id`, `invoice_no`, `partsId`, `purchase_rate`, `status`, `sale_rate`, `memo_no` FROM `tbl_parts`";
            this._commandCollection[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitConnection()
        {
            this._connection = new MySqlConnection();
            this._connection.ConnectionString = Settings.Default.teConnectionString;
        }

        [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Insert, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(string p1, uint p2, double? p3, string p4, double? p5, string p6)
        {
            int num2;
            if (p1 == null)
            {
                this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = p1;
            }
            this.Adapter.InsertCommand.Parameters[1].Value = p2;
            if (p3.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[2].Value = p3.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
            }
            if (p4 == null)
            {
                throw new ArgumentNullException("p4");
            }
            this.Adapter.InsertCommand.Parameters[3].Value = p4;
            if (p5.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[4].Value = p5.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
            }
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
            return this.Adapter.Update(dataSet, "tbl_parts");
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(teDataSet.tbl_partsDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
        public virtual int Update(string p1, uint p2, double? p3, string p4, double? p5, string p6, uint p7, string p9, uint p10, double? p12, string p13, double? p15, string p17)
        {
            int num2;
            if (p1 == null)
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = p1;
            }
            this.Adapter.UpdateCommand.Parameters[1].Value = p2;
            if (p3.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = p3.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
            }
            if (p4 == null)
            {
                throw new ArgumentNullException("p4");
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = p4;
            if (p5.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = p5.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
            }
            if (p6 == null)
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = p6;
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = p7;
            if (p9 == null)
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = 1;
                this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = 0;
                this.Adapter.UpdateCommand.Parameters[8].Value = p9;
            }
            this.Adapter.UpdateCommand.Parameters[9].Value = p10;
            if (p12.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = 0;
                this.Adapter.UpdateCommand.Parameters[11].Value = p12.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = 1;
                this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
            }
            if (p13 == null)
            {
                throw new ArgumentNullException("p13");
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = p13;
            if (p15.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[13].Value = 0;
                this.Adapter.UpdateCommand.Parameters[14].Value = p15.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[13].Value = 1;
                this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
            }
            if (p17 == null)
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x10].Value = p17;
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

