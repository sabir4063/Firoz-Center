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

    [ToolboxItem(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), HelpKeyword("vs.data.TableAdapter"), DesignerCategory("code"), DataObject(true)]
    public class tbl_parts_infoTableAdapter : Component
    {
        private MySqlDataAdapter _adapter;
        private bool _clearBeforeFill;
        private MySqlCommand[] _commandCollection;
        private MySqlConnection _connection;
        private MySqlTransaction _transaction;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public tbl_parts_infoTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Delete, true), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(uint p1, string p2, string p3, string p4, string p5, double p6, double? p8, DateTime p9, double p10, double p11)
        {
            int num2;
            this.Adapter.DeleteCommand.Parameters[0].Value = p1;
            if (p2 == null)
            {
                throw new ArgumentNullException("p2");
            }
            this.Adapter.DeleteCommand.Parameters[1].Value = p2;
            if (p3 == null)
            {
                throw new ArgumentNullException("p3");
            }
            this.Adapter.DeleteCommand.Parameters[2].Value = p3;
            if (p4 == null)
            {
                throw new ArgumentNullException("p4");
            }
            this.Adapter.DeleteCommand.Parameters[3].Value = p4;
            if (p5 == null)
            {
                throw new ArgumentNullException("p5");
            }
            this.Adapter.DeleteCommand.Parameters[4].Value = p5;
            this.Adapter.DeleteCommand.Parameters[5].Value = p6;
            if (p8.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[6].Value = 0;
                this.Adapter.DeleteCommand.Parameters[7].Value = p8.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[6].Value = 1;
                this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
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

        [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Fill, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Fill(teDataSet.tbl_parts_infoDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual teDataSet.tbl_parts_infoDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            teDataSet.tbl_parts_infoDataTable dataTable = new teDataSet.tbl_parts_infoDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new MySqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "tbl_parts_info",
                ColumnMappings = { 
                    { 
                        "partsId",
                        "partsId"
                    },
                    { 
                        "brand",
                        "brand"
                    },
                    { 
                        "model",
                        "model"
                    },
                    { 
                        "partsNo",
                        "partsNo"
                    },
                    { 
                        "description",
                        "description"
                    },
                    { 
                        "purchase_price",
                        "purchase_price"
                    },
                    { 
                        "sale_price",
                        "sale_price"
                    },
                    { 
                        "date",
                        "date"
                    },
                    { 
                        "wholesale_price",
                        "wholesale_price"
                    },
                    { 
                        "distributor_price",
                        "distributor_price"
                    }
                }
            };
            this._adapter.TableMappings.Add(mapping);
            this._adapter.DeleteCommand = new MySqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `tbl_parts_info` WHERE ((`partsId` = @p1) AND (`brand` = @p2) AND (`model` = @p3) AND (`partsNo` = @p4) AND (`description` = @p5) AND (`purchase_price` = @p6) AND ((@p7 = 1 AND `sale_price` IS NULL) OR (`sale_price` = @p8)) AND (`date` = @p9) AND (`wholesale_price` = @p10) AND (`distributor_price` = @p11))";
            this._adapter.DeleteCommand.CommandType = CommandType.Text;
            MySqlParameter parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.UInt32,
                MySqlDbType = MySqlDbType.UInt32,
                IsNullable = true,
                SourceColumn = "partsId",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "brand",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "model",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "partsNo",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "description",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "sale_price",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p10",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "wholesale_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p11",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "distributor_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.DeleteCommand.Parameters.Add(parameter);
            this._adapter.InsertCommand = new MySqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `tbl_parts_info` (`brand`, `model`, `partsNo`, `description`, `purchase_price`, `sale_price`, `date`, `wholesale_price`, `distributor_price`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
            this._adapter.InsertCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "brand"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "model"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "partsNo"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "description"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_price"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_price"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "wholesale_price"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "distributor_price"
            };
            this._adapter.InsertCommand.Parameters.Add(parameter);
            this._adapter.UpdateCommand = new MySqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `tbl_parts_info` SET `brand` = @p1, `model` = @p2, `partsNo` = @p3, `description` = @p4, `purchase_price` = @p5, `sale_price` = @p6, `date` = @p7, `wholesale_price` = @p8, `distributor_price` = @p9 WHERE ((`partsId` = @p10) AND (`brand` = @p11) AND (`model` = @p12) AND (`partsNo` = @p13) AND (`description` = @p14) AND (`purchase_price` = @p15) AND ((@p16 = 1 AND `sale_price` IS NULL) OR (`sale_price` = @p17)) AND (`date` = @p18) AND (`wholesale_price` = @p19) AND (`distributor_price` = @p20))";
            this._adapter.UpdateCommand.CommandType = CommandType.Text;
            parameter = new MySqlParameter {
                ParameterName = "@p1",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "brand"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p2",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "model"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p3",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "partsNo"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p4",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "description"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p5",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_price"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p6",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_price"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p7",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p8",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "wholesale_price"
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p9",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "distributor_price"
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
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "brand",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p12",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "model",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p13",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "partsNo",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p14",
                DbType = DbType.String,
                MySqlDbType = MySqlDbType.VarChar,
                IsNullable = true,
                SourceColumn = "description",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p15",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "purchase_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p16",
                DbType = DbType.Int32,
                MySqlDbType = MySqlDbType.Int32,
                IsNullable = true,
                SourceColumn = "sale_price",
                SourceVersion = DataRowVersion.Original,
                SourceColumnNullMapping = true
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p17",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "sale_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p18",
                DbType = DbType.DateTime,
                MySqlDbType = MySqlDbType.DateTime,
                IsNullable = true,
                SourceColumn = "date",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p19",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "wholesale_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
            parameter = new MySqlParameter {
                ParameterName = "@p20",
                DbType = DbType.Double,
                MySqlDbType = MySqlDbType.Double,
                IsNullable = true,
                SourceColumn = "distributor_price",
                SourceVersion = DataRowVersion.Original
            };
            this._adapter.UpdateCommand.Parameters.Add(parameter);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitCommandCollection()
        {
            this._commandCollection = new MySqlCommand[] { new MySqlCommand() };
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT `partsId`, `brand`, `model`, `partsNo`, `description`, `purchase_price`, `sale_price`, `date`, `wholesale_price`, `distributor_price` FROM `tbl_parts_info`";
            this._commandCollection[0].CommandType = CommandType.Text;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new MySqlConnection();
            this._connection.ConnectionString = Settings.Default.teConnectionString;
        }

        [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Insert, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Insert(string p1, string p2, string p3, string p4, double p5, double? p6, DateTime p7, double p8, double p9)
        {
            int num2;
            if (p1 == null)
            {
                throw new ArgumentNullException("p1");
            }
            this.Adapter.InsertCommand.Parameters[0].Value = p1;
            if (p2 == null)
            {
                throw new ArgumentNullException("p2");
            }
            this.Adapter.InsertCommand.Parameters[1].Value = p2;
            if (p3 == null)
            {
                throw new ArgumentNullException("p3");
            }
            this.Adapter.InsertCommand.Parameters[2].Value = p3;
            if (p4 == null)
            {
                throw new ArgumentNullException("p4");
            }
            this.Adapter.InsertCommand.Parameters[3].Value = p4;
            this.Adapter.InsertCommand.Parameters[4].Value = p5;
            if (p6.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[5].Value = p6.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
            }
            this.Adapter.InsertCommand.Parameters[6].Value = p7;
            this.Adapter.InsertCommand.Parameters[7].Value = p8;
            this.Adapter.InsertCommand.Parameters[8].Value = p9;
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(teDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "tbl_parts_info");
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(teDataSet.tbl_parts_infoDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Update, true), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string p1, string p2, string p3, string p4, double p5, double? p6, DateTime p7, double p8, double p9, uint p10, string p11, string p12, string p13, string p14, double p15, double? p17, DateTime p18, double p19, double p20)
        {
            int num2;
            if (p1 == null)
            {
                throw new ArgumentNullException("p1");
            }
            this.Adapter.UpdateCommand.Parameters[0].Value = p1;
            if (p2 == null)
            {
                throw new ArgumentNullException("p2");
            }
            this.Adapter.UpdateCommand.Parameters[1].Value = p2;
            if (p3 == null)
            {
                throw new ArgumentNullException("p3");
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = p3;
            if (p4 == null)
            {
                throw new ArgumentNullException("p4");
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = p4;
            this.Adapter.UpdateCommand.Parameters[4].Value = p5;
            if (p6.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = p6.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = p7;
            this.Adapter.UpdateCommand.Parameters[7].Value = p8;
            this.Adapter.UpdateCommand.Parameters[8].Value = p9;
            this.Adapter.UpdateCommand.Parameters[9].Value = p10;
            if (p11 == null)
            {
                throw new ArgumentNullException("p11");
            }
            this.Adapter.UpdateCommand.Parameters[10].Value = p11;
            if (p12 == null)
            {
                throw new ArgumentNullException("p12");
            }
            this.Adapter.UpdateCommand.Parameters[11].Value = p12;
            if (p13 == null)
            {
                throw new ArgumentNullException("p13");
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = p13;
            if (p14 == null)
            {
                throw new ArgumentNullException("p14");
            }
            this.Adapter.UpdateCommand.Parameters[13].Value = p14;
            this.Adapter.UpdateCommand.Parameters[14].Value = p15;
            if (p17.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x10].Value = p17.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x10].Value = DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[0x11].Value = p18;
            this.Adapter.UpdateCommand.Parameters[0x12].Value = p19;
            this.Adapter.UpdateCommand.Parameters[0x13].Value = p20;
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

