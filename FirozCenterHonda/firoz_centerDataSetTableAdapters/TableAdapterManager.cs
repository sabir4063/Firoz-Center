namespace FirozCenterHonda.teDataSetTableAdapters
{
    using FirozCenterHonda;
    using MySql.Data.MySqlClient;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    [HelpKeyword("vs.data.TableAdapterManager"), DesignerCategory("code"), ToolboxItem(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class TableAdapterManager : Component
    {
        private bool _backupDataSetBeforeUpdate;
        private IDbConnection _connection;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_advance_payTableAdapter _tbl_advance_payTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_bank_infoTableAdapter _tbl_bank_infoTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_bank_transcationTableAdapter _tbl_bank_transcationTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_cash_expencesTableAdapter _tbl_cash_expencesTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_customerTableAdapter _tbl_customerTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_employeeTableAdapter _tbl_employeeTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_expencesTableAdapter _tbl_expencesTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_loanTableAdapter _tbl_loanTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_parts_infoTableAdapter _tbl_parts_infoTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_partsTableAdapter _tbl_partsTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_party_transcationTableAdapter _tbl_party_transcationTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_partyTableAdapter _tbl_partyTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_paymentTableAdapter _tbl_paymentTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_purchaseTableAdapter _tbl_purchaseTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_salaryTableAdapter _tbl_salaryTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_sales_motorcycleTableAdapter _tbl_sales_motorcycleTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_sales_partsTableAdapter _tbl_sales_partsTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_sales_serviceTableAdapter _tbl_sales_serviceTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_service_chargeTableAdapter _tbl_service_chargeTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_serviceTableAdapter _tbl_serviceTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_transcationTableAdapter _tbl_transcationTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_userTableAdapter _tbl_userTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_vehicle_infoTableAdapter _tbl_vehicle_infoTableAdapter;
        private FirozCenterHonda.teDataSetTableAdapters.tbl_vehicleTableAdapter _tbl_vehicleTableAdapter;
        private UpdateOrderOption _updateOrder;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
        {
            if ((updatedRows == null) || (updatedRows.Length < 1))
            {
                return updatedRows;
            }
            if ((allAddedRows == null) || (allAddedRows.Count < 1))
            {
                return updatedRows;
            }
            List<DataRow> list = new List<DataRow>();
            for (int i = 0; i < updatedRows.Length; i++)
            {
                DataRow item = updatedRows[i];
                if (!allAddedRows.Contains(item))
                {
                    list.Add(item);
                }
            }
            return list.ToArray();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
        {
            return ((this._connection != null) || (((this.Connection == null) || (inputConnection == null)) || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal)));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
        {
            Array.Sort<DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual int UpdateAll(teDataSet dataSet)
        {
            DataRow[] rowArray;
            int num2;
            DataRow row;
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (!dataSet.HasChanges())
            {
                return 0;
            }
            if (!((this._tbl_advance_payTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_advance_payTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_bank_infoTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_bank_infoTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_bank_transcationTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_bank_transcationTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_cash_expencesTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_cash_expencesTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_customerTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_customerTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_employeeTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_employeeTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_expencesTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_expencesTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_loanTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_loanTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_partsTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_partsTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_parts_infoTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_parts_infoTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_partyTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_partyTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_party_transcationTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_party_transcationTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_paymentTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_paymentTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_purchaseTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_purchaseTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_salaryTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_salaryTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_sales_motorcycleTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_sales_motorcycleTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_sales_partsTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_sales_partsTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_sales_serviceTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_sales_serviceTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_serviceTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_serviceTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_service_chargeTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_service_chargeTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_transcationTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_transcationTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_userTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_userTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_vehicleTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_vehicleTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this._tbl_vehicle_infoTableAdapter == null) || this.MatchTableAdapterConnection(this._tbl_vehicle_infoTableAdapter.Connection)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            IDbConnection connection = this.Connection;
            if (connection == null)
            {
                throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
            }
            bool flag = false;
            if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
            {
                connection.Close();
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                flag = true;
            }
            IDbTransaction transaction = connection.BeginTransaction();
            if (transaction == null)
            {
                throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
            }
            List<DataRow> allChangedRows = new List<DataRow>();
            List<DataRow> allAddedRows = new List<DataRow>();
            List<DataAdapter> list3 = new List<DataAdapter>();
            Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
            int num = 0;
            DataSet set = null;
            if (this.BackupDataSetBeforeUpdate)
            {
                set = new DataSet();
                set.Merge(dataSet);
            }
            try
            {
                if (this._tbl_advance_payTableAdapter != null)
                {
                    dictionary.Add(this._tbl_advance_payTableAdapter, this._tbl_advance_payTableAdapter.Connection);
                    this._tbl_advance_payTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_advance_payTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_advance_payTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_advance_payTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_advance_payTableAdapter.Adapter);
                    }
                }
                if (this._tbl_bank_infoTableAdapter != null)
                {
                    dictionary.Add(this._tbl_bank_infoTableAdapter, this._tbl_bank_infoTableAdapter.Connection);
                    this._tbl_bank_infoTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_bank_infoTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_bank_infoTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_bank_infoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_bank_infoTableAdapter.Adapter);
                    }
                }
                if (this._tbl_bank_transcationTableAdapter != null)
                {
                    dictionary.Add(this._tbl_bank_transcationTableAdapter, this._tbl_bank_transcationTableAdapter.Connection);
                    this._tbl_bank_transcationTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_bank_transcationTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_bank_transcationTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_bank_transcationTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_bank_transcationTableAdapter.Adapter);
                    }
                }
                if (this._tbl_cash_expencesTableAdapter != null)
                {
                    dictionary.Add(this._tbl_cash_expencesTableAdapter, this._tbl_cash_expencesTableAdapter.Connection);
                    this._tbl_cash_expencesTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_cash_expencesTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_cash_expencesTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_cash_expencesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_cash_expencesTableAdapter.Adapter);
                    }
                }
                if (this._tbl_customerTableAdapter != null)
                {
                    dictionary.Add(this._tbl_customerTableAdapter, this._tbl_customerTableAdapter.Connection);
                    this._tbl_customerTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_customerTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_customerTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_customerTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_customerTableAdapter.Adapter);
                    }
                }
                if (this._tbl_employeeTableAdapter != null)
                {
                    dictionary.Add(this._tbl_employeeTableAdapter, this._tbl_employeeTableAdapter.Connection);
                    this._tbl_employeeTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_employeeTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_employeeTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_employeeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_employeeTableAdapter.Adapter);
                    }
                }
                if (this._tbl_expencesTableAdapter != null)
                {
                    dictionary.Add(this._tbl_expencesTableAdapter, this._tbl_expencesTableAdapter.Connection);
                    this._tbl_expencesTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_expencesTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_expencesTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_expencesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_expencesTableAdapter.Adapter);
                    }
                }
                if (this._tbl_loanTableAdapter != null)
                {
                    dictionary.Add(this._tbl_loanTableAdapter, this._tbl_loanTableAdapter.Connection);
                    this._tbl_loanTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_loanTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_loanTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_loanTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_loanTableAdapter.Adapter);
                    }
                }
                if (this._tbl_partsTableAdapter != null)
                {
                    dictionary.Add(this._tbl_partsTableAdapter, this._tbl_partsTableAdapter.Connection);
                    this._tbl_partsTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_partsTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_partsTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_partsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_partsTableAdapter.Adapter);
                    }
                }
                if (this._tbl_parts_infoTableAdapter != null)
                {
                    dictionary.Add(this._tbl_parts_infoTableAdapter, this._tbl_parts_infoTableAdapter.Connection);
                    this._tbl_parts_infoTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_parts_infoTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_parts_infoTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_parts_infoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_parts_infoTableAdapter.Adapter);
                    }
                }
                if (this._tbl_partyTableAdapter != null)
                {
                    dictionary.Add(this._tbl_partyTableAdapter, this._tbl_partyTableAdapter.Connection);
                    this._tbl_partyTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_partyTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_partyTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_partyTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_partyTableAdapter.Adapter);
                    }
                }
                if (this._tbl_party_transcationTableAdapter != null)
                {
                    dictionary.Add(this._tbl_party_transcationTableAdapter, this._tbl_party_transcationTableAdapter.Connection);
                    this._tbl_party_transcationTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_party_transcationTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_party_transcationTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_party_transcationTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_party_transcationTableAdapter.Adapter);
                    }
                }
                if (this._tbl_paymentTableAdapter != null)
                {
                    dictionary.Add(this._tbl_paymentTableAdapter, this._tbl_paymentTableAdapter.Connection);
                    this._tbl_paymentTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_paymentTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_paymentTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_paymentTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_paymentTableAdapter.Adapter);
                    }
                }
                if (this._tbl_purchaseTableAdapter != null)
                {
                    dictionary.Add(this._tbl_purchaseTableAdapter, this._tbl_purchaseTableAdapter.Connection);
                    this._tbl_purchaseTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_purchaseTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_purchaseTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_purchaseTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_purchaseTableAdapter.Adapter);
                    }
                }
                if (this._tbl_salaryTableAdapter != null)
                {
                    dictionary.Add(this._tbl_salaryTableAdapter, this._tbl_salaryTableAdapter.Connection);
                    this._tbl_salaryTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_salaryTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_salaryTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_salaryTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_salaryTableAdapter.Adapter);
                    }
                }
                if (this._tbl_sales_motorcycleTableAdapter != null)
                {
                    dictionary.Add(this._tbl_sales_motorcycleTableAdapter, this._tbl_sales_motorcycleTableAdapter.Connection);
                    this._tbl_sales_motorcycleTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_sales_motorcycleTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_sales_motorcycleTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_sales_motorcycleTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_sales_motorcycleTableAdapter.Adapter);
                    }
                }
                if (this._tbl_sales_partsTableAdapter != null)
                {
                    dictionary.Add(this._tbl_sales_partsTableAdapter, this._tbl_sales_partsTableAdapter.Connection);
                    this._tbl_sales_partsTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_sales_partsTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_sales_partsTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_sales_partsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_sales_partsTableAdapter.Adapter);
                    }
                }
                if (this._tbl_sales_serviceTableAdapter != null)
                {
                    dictionary.Add(this._tbl_sales_serviceTableAdapter, this._tbl_sales_serviceTableAdapter.Connection);
                    this._tbl_sales_serviceTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_sales_serviceTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_sales_serviceTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_sales_serviceTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_sales_serviceTableAdapter.Adapter);
                    }
                }
                if (this._tbl_serviceTableAdapter != null)
                {
                    dictionary.Add(this._tbl_serviceTableAdapter, this._tbl_serviceTableAdapter.Connection);
                    this._tbl_serviceTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_serviceTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_serviceTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_serviceTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_serviceTableAdapter.Adapter);
                    }
                }
                if (this._tbl_service_chargeTableAdapter != null)
                {
                    dictionary.Add(this._tbl_service_chargeTableAdapter, this._tbl_service_chargeTableAdapter.Connection);
                    this._tbl_service_chargeTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_service_chargeTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_service_chargeTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_service_chargeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_service_chargeTableAdapter.Adapter);
                    }
                }
                if (this._tbl_transcationTableAdapter != null)
                {
                    dictionary.Add(this._tbl_transcationTableAdapter, this._tbl_transcationTableAdapter.Connection);
                    this._tbl_transcationTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_transcationTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_transcationTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_transcationTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_transcationTableAdapter.Adapter);
                    }
                }
                if (this._tbl_userTableAdapter != null)
                {
                    dictionary.Add(this._tbl_userTableAdapter, this._tbl_userTableAdapter.Connection);
                    this._tbl_userTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_userTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_userTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_userTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_userTableAdapter.Adapter);
                    }
                }
                if (this._tbl_vehicleTableAdapter != null)
                {
                    dictionary.Add(this._tbl_vehicleTableAdapter, this._tbl_vehicleTableAdapter.Connection);
                    this._tbl_vehicleTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_vehicleTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_vehicleTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_vehicleTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_vehicleTableAdapter.Adapter);
                    }
                }
                if (this._tbl_vehicle_infoTableAdapter != null)
                {
                    dictionary.Add(this._tbl_vehicle_infoTableAdapter, this._tbl_vehicle_infoTableAdapter.Connection);
                    this._tbl_vehicle_infoTableAdapter.Connection = (MySqlConnection) connection;
                    this._tbl_vehicle_infoTableAdapter.Transaction = (MySqlTransaction) transaction;
                    if (this._tbl_vehicle_infoTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tbl_vehicle_infoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this._tbl_vehicle_infoTableAdapter.Adapter);
                    }
                }
                if (this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
                {
                    num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                    num += this.UpdateInsertedRows(dataSet, allAddedRows);
                }
                else
                {
                    num += this.UpdateInsertedRows(dataSet, allAddedRows);
                    num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                }
                num += this.UpdateDeletedRows(dataSet, allChangedRows);
                transaction.Commit();
                if (0 < allAddedRows.Count)
                {
                    rowArray = new DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rowArray);
                    for (num2 = 0; num2 < rowArray.Length; num2++)
                    {
                        row = rowArray[num2];
                        row.AcceptChanges();
                    }
                }
                if (0 < allChangedRows.Count)
                {
                    rowArray = new DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rowArray);
                    for (num2 = 0; num2 < rowArray.Length; num2++)
                    {
                        row = rowArray[num2];
                        row.AcceptChanges();
                    }
                }
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                if (this.BackupDataSetBeforeUpdate)
                {
                    Debug.Assert(set != null);
                    dataSet.Clear();
                    dataSet.Merge(set);
                }
                else if (0 < allAddedRows.Count)
                {
                    rowArray = new DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rowArray);
                    for (num2 = 0; num2 < rowArray.Length; num2++)
                    {
                        row = rowArray[num2];
                        row.AcceptChanges();
                        row.SetAdded();
                    }
                }
                throw exception;
            }
            finally
            {
                if (flag)
                {
                    connection.Close();
                }
                if (this._tbl_advance_payTableAdapter != null)
                {
                    this._tbl_advance_payTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_advance_payTableAdapter];
                    this._tbl_advance_payTableAdapter.Transaction = null;
                }
                if (this._tbl_bank_infoTableAdapter != null)
                {
                    this._tbl_bank_infoTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_bank_infoTableAdapter];
                    this._tbl_bank_infoTableAdapter.Transaction = null;
                }
                if (this._tbl_bank_transcationTableAdapter != null)
                {
                    this._tbl_bank_transcationTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_bank_transcationTableAdapter];
                    this._tbl_bank_transcationTableAdapter.Transaction = null;
                }
                if (this._tbl_cash_expencesTableAdapter != null)
                {
                    this._tbl_cash_expencesTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_cash_expencesTableAdapter];
                    this._tbl_cash_expencesTableAdapter.Transaction = null;
                }
                if (this._tbl_customerTableAdapter != null)
                {
                    this._tbl_customerTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_customerTableAdapter];
                    this._tbl_customerTableAdapter.Transaction = null;
                }
                if (this._tbl_employeeTableAdapter != null)
                {
                    this._tbl_employeeTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_employeeTableAdapter];
                    this._tbl_employeeTableAdapter.Transaction = null;
                }
                if (this._tbl_expencesTableAdapter != null)
                {
                    this._tbl_expencesTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_expencesTableAdapter];
                    this._tbl_expencesTableAdapter.Transaction = null;
                }
                if (this._tbl_loanTableAdapter != null)
                {
                    this._tbl_loanTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_loanTableAdapter];
                    this._tbl_loanTableAdapter.Transaction = null;
                }
                if (this._tbl_partsTableAdapter != null)
                {
                    this._tbl_partsTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_partsTableAdapter];
                    this._tbl_partsTableAdapter.Transaction = null;
                }
                if (this._tbl_parts_infoTableAdapter != null)
                {
                    this._tbl_parts_infoTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_parts_infoTableAdapter];
                    this._tbl_parts_infoTableAdapter.Transaction = null;
                }
                if (this._tbl_partyTableAdapter != null)
                {
                    this._tbl_partyTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_partyTableAdapter];
                    this._tbl_partyTableAdapter.Transaction = null;
                }
                if (this._tbl_party_transcationTableAdapter != null)
                {
                    this._tbl_party_transcationTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_party_transcationTableAdapter];
                    this._tbl_party_transcationTableAdapter.Transaction = null;
                }
                if (this._tbl_paymentTableAdapter != null)
                {
                    this._tbl_paymentTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_paymentTableAdapter];
                    this._tbl_paymentTableAdapter.Transaction = null;
                }
                if (this._tbl_purchaseTableAdapter != null)
                {
                    this._tbl_purchaseTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_purchaseTableAdapter];
                    this._tbl_purchaseTableAdapter.Transaction = null;
                }
                if (this._tbl_salaryTableAdapter != null)
                {
                    this._tbl_salaryTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_salaryTableAdapter];
                    this._tbl_salaryTableAdapter.Transaction = null;
                }
                if (this._tbl_sales_motorcycleTableAdapter != null)
                {
                    this._tbl_sales_motorcycleTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_sales_motorcycleTableAdapter];
                    this._tbl_sales_motorcycleTableAdapter.Transaction = null;
                }
                if (this._tbl_sales_partsTableAdapter != null)
                {
                    this._tbl_sales_partsTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_sales_partsTableAdapter];
                    this._tbl_sales_partsTableAdapter.Transaction = null;
                }
                if (this._tbl_sales_serviceTableAdapter != null)
                {
                    this._tbl_sales_serviceTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_sales_serviceTableAdapter];
                    this._tbl_sales_serviceTableAdapter.Transaction = null;
                }
                if (this._tbl_serviceTableAdapter != null)
                {
                    this._tbl_serviceTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_serviceTableAdapter];
                    this._tbl_serviceTableAdapter.Transaction = null;
                }
                if (this._tbl_service_chargeTableAdapter != null)
                {
                    this._tbl_service_chargeTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_service_chargeTableAdapter];
                    this._tbl_service_chargeTableAdapter.Transaction = null;
                }
                if (this._tbl_transcationTableAdapter != null)
                {
                    this._tbl_transcationTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_transcationTableAdapter];
                    this._tbl_transcationTableAdapter.Transaction = null;
                }
                if (this._tbl_userTableAdapter != null)
                {
                    this._tbl_userTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_userTableAdapter];
                    this._tbl_userTableAdapter.Transaction = null;
                }
                if (this._tbl_vehicleTableAdapter != null)
                {
                    this._tbl_vehicleTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_vehicleTableAdapter];
                    this._tbl_vehicleTableAdapter.Transaction = null;
                }
                if (this._tbl_vehicle_infoTableAdapter != null)
                {
                    this._tbl_vehicle_infoTableAdapter.Connection = (MySqlConnection) dictionary[this._tbl_vehicle_infoTableAdapter];
                    this._tbl_vehicle_infoTableAdapter.Transaction = null;
                }
                if (0 < list3.Count)
                {
                    DataAdapter[] array = new DataAdapter[list3.Count];
                    list3.CopyTo(array);
                    for (num2 = 0; num2 < array.Length; num2++)
                    {
                        DataAdapter adapter = array[num2];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return num;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateDeletedRows(teDataSet dataSet, List<DataRow> allChangedRows)
        {
            DataRow[] rowArray;
            int num = 0;
            if (this._tbl_vehicle_infoTableAdapter != null)
            {
                rowArray = dataSet.tbl_vehicle_info.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_vehicle_infoTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_vehicleTableAdapter != null)
            {
                rowArray = dataSet.tbl_vehicle.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_vehicleTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_bank_infoTableAdapter != null)
            {
                rowArray = dataSet.tbl_bank_info.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_bank_infoTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_bank_transcationTableAdapter != null)
            {
                rowArray = dataSet.tbl_bank_transcation.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_bank_transcationTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_cash_expencesTableAdapter != null)
            {
                rowArray = dataSet.tbl_cash_expences.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_cash_expencesTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_customerTableAdapter != null)
            {
                rowArray = dataSet.tbl_customer.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_customerTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_employeeTableAdapter != null)
            {
                rowArray = dataSet.tbl_employee.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_employeeTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_expencesTableAdapter != null)
            {
                rowArray = dataSet.tbl_expences.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_expencesTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_loanTableAdapter != null)
            {
                rowArray = dataSet.tbl_loan.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_loanTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_partsTableAdapter != null)
            {
                rowArray = dataSet.tbl_parts.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_partsTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_parts_infoTableAdapter != null)
            {
                rowArray = dataSet.tbl_parts_info.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_parts_infoTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_partyTableAdapter != null)
            {
                rowArray = dataSet.tbl_party.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_partyTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_party_transcationTableAdapter != null)
            {
                rowArray = dataSet.tbl_party_transcation.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_party_transcationTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_paymentTableAdapter != null)
            {
                rowArray = dataSet.tbl_payment.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_paymentTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_purchaseTableAdapter != null)
            {
                rowArray = dataSet.tbl_purchase.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_purchaseTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_salaryTableAdapter != null)
            {
                rowArray = dataSet.tbl_salary.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_salaryTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_sales_motorcycleTableAdapter != null)
            {
                rowArray = dataSet.tbl_sales_motorcycle.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_sales_motorcycleTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_sales_partsTableAdapter != null)
            {
                rowArray = dataSet.tbl_sales_parts.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_sales_partsTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_sales_serviceTableAdapter != null)
            {
                rowArray = dataSet.tbl_sales_service.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_sales_serviceTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_serviceTableAdapter != null)
            {
                rowArray = dataSet.tbl_service.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_serviceTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_service_chargeTableAdapter != null)
            {
                rowArray = dataSet.tbl_service_charge.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_service_chargeTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_transcationTableAdapter != null)
            {
                rowArray = dataSet.tbl_transcation.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_transcationTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_userTableAdapter != null)
            {
                rowArray = dataSet.tbl_user.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_userTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_advance_payTableAdapter != null)
            {
                rowArray = dataSet.tbl_advance_pay.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_advance_payTableAdapter.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private int UpdateInsertedRows(teDataSet dataSet, List<DataRow> allAddedRows)
        {
            DataRow[] rowArray;
            int num = 0;
            if (this._tbl_advance_payTableAdapter != null)
            {
                rowArray = dataSet.tbl_advance_pay.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_advance_payTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_userTableAdapter != null)
            {
                rowArray = dataSet.tbl_user.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_userTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_transcationTableAdapter != null)
            {
                rowArray = dataSet.tbl_transcation.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_transcationTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_service_chargeTableAdapter != null)
            {
                rowArray = dataSet.tbl_service_charge.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_service_chargeTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_serviceTableAdapter != null)
            {
                rowArray = dataSet.tbl_service.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_serviceTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_sales_serviceTableAdapter != null)
            {
                rowArray = dataSet.tbl_sales_service.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_sales_serviceTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_sales_partsTableAdapter != null)
            {
                rowArray = dataSet.tbl_sales_parts.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_sales_partsTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_sales_motorcycleTableAdapter != null)
            {
                rowArray = dataSet.tbl_sales_motorcycle.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_sales_motorcycleTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_salaryTableAdapter != null)
            {
                rowArray = dataSet.tbl_salary.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_salaryTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_purchaseTableAdapter != null)
            {
                rowArray = dataSet.tbl_purchase.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_purchaseTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_paymentTableAdapter != null)
            {
                rowArray = dataSet.tbl_payment.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_paymentTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_party_transcationTableAdapter != null)
            {
                rowArray = dataSet.tbl_party_transcation.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_party_transcationTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_partyTableAdapter != null)
            {
                rowArray = dataSet.tbl_party.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_partyTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_parts_infoTableAdapter != null)
            {
                rowArray = dataSet.tbl_parts_info.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_parts_infoTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_partsTableAdapter != null)
            {
                rowArray = dataSet.tbl_parts.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_partsTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_loanTableAdapter != null)
            {
                rowArray = dataSet.tbl_loan.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_loanTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_expencesTableAdapter != null)
            {
                rowArray = dataSet.tbl_expences.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_expencesTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_employeeTableAdapter != null)
            {
                rowArray = dataSet.tbl_employee.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_employeeTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_customerTableAdapter != null)
            {
                rowArray = dataSet.tbl_customer.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_customerTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_cash_expencesTableAdapter != null)
            {
                rowArray = dataSet.tbl_cash_expences.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_cash_expencesTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_bank_transcationTableAdapter != null)
            {
                rowArray = dataSet.tbl_bank_transcation.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_bank_transcationTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_bank_infoTableAdapter != null)
            {
                rowArray = dataSet.tbl_bank_info.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_bank_infoTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_vehicleTableAdapter != null)
            {
                rowArray = dataSet.tbl_vehicle.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_vehicleTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this._tbl_vehicle_infoTableAdapter != null)
            {
                rowArray = dataSet.tbl_vehicle_info.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this._tbl_vehicle_infoTableAdapter.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            return num;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateUpdatedRows(teDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
        {
            DataRow[] realUpdatedRows;
            int num = 0;
            if (this._tbl_advance_payTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_advance_pay.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_advance_payTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_userTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_user.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_userTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_transcationTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_transcation.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_transcationTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_service_chargeTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_service_charge.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_service_chargeTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_serviceTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_service.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_serviceTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_sales_serviceTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_sales_service.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_sales_serviceTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_sales_partsTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_sales_parts.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_sales_partsTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_sales_motorcycleTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_sales_motorcycle.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_sales_motorcycleTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_salaryTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_salary.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_salaryTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_purchaseTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_purchase.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_purchaseTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_paymentTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_payment.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_paymentTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_party_transcationTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_party_transcation.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_party_transcationTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_partyTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_party.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_partyTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_parts_infoTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_parts_info.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_parts_infoTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_partsTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_parts.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_partsTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_loanTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_loan.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_loanTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_expencesTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_expences.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_expencesTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_employeeTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_employee.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_employeeTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_customerTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_customer.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_customerTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_cash_expencesTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_cash_expences.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_cash_expencesTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_bank_transcationTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_bank_transcation.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_bank_transcationTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_bank_infoTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_bank_info.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_bank_infoTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_vehicleTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_vehicle.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_vehicleTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            if (this._tbl_vehicle_infoTableAdapter != null)
            {
                realUpdatedRows = dataSet.tbl_vehicle_info.Select(null, null, DataViewRowState.ModifiedCurrent);
                realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
                if ((realUpdatedRows != null) && (0 < realUpdatedRows.Length))
                {
                    num += this._tbl_vehicle_infoTableAdapter.Update(realUpdatedRows);
                    allChangedRows.AddRange(realUpdatedRows);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public bool BackupDataSetBeforeUpdate
        {
            get
            {
                return this._backupDataSetBeforeUpdate;
            }
            set
            {
                this._backupDataSetBeforeUpdate = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public IDbConnection Connection
        {
            get
            {
                if (this._connection != null)
                {
                    return this._connection;
                }
                if ((this._tbl_advance_payTableAdapter != null) && (this._tbl_advance_payTableAdapter.Connection != null))
                {
                    return this._tbl_advance_payTableAdapter.Connection;
                }
                if ((this._tbl_bank_infoTableAdapter != null) && (this._tbl_bank_infoTableAdapter.Connection != null))
                {
                    return this._tbl_bank_infoTableAdapter.Connection;
                }
                if ((this._tbl_bank_transcationTableAdapter != null) && (this._tbl_bank_transcationTableAdapter.Connection != null))
                {
                    return this._tbl_bank_transcationTableAdapter.Connection;
                }
                if ((this._tbl_cash_expencesTableAdapter != null) && (this._tbl_cash_expencesTableAdapter.Connection != null))
                {
                    return this._tbl_cash_expencesTableAdapter.Connection;
                }
                if ((this._tbl_customerTableAdapter != null) && (this._tbl_customerTableAdapter.Connection != null))
                {
                    return this._tbl_customerTableAdapter.Connection;
                }
                if ((this._tbl_employeeTableAdapter != null) && (this._tbl_employeeTableAdapter.Connection != null))
                {
                    return this._tbl_employeeTableAdapter.Connection;
                }
                if ((this._tbl_expencesTableAdapter != null) && (this._tbl_expencesTableAdapter.Connection != null))
                {
                    return this._tbl_expencesTableAdapter.Connection;
                }
                if ((this._tbl_loanTableAdapter != null) && (this._tbl_loanTableAdapter.Connection != null))
                {
                    return this._tbl_loanTableAdapter.Connection;
                }
                if ((this._tbl_partsTableAdapter != null) && (this._tbl_partsTableAdapter.Connection != null))
                {
                    return this._tbl_partsTableAdapter.Connection;
                }
                if ((this._tbl_parts_infoTableAdapter != null) && (this._tbl_parts_infoTableAdapter.Connection != null))
                {
                    return this._tbl_parts_infoTableAdapter.Connection;
                }
                if ((this._tbl_partyTableAdapter != null) && (this._tbl_partyTableAdapter.Connection != null))
                {
                    return this._tbl_partyTableAdapter.Connection;
                }
                if ((this._tbl_party_transcationTableAdapter != null) && (this._tbl_party_transcationTableAdapter.Connection != null))
                {
                    return this._tbl_party_transcationTableAdapter.Connection;
                }
                if ((this._tbl_paymentTableAdapter != null) && (this._tbl_paymentTableAdapter.Connection != null))
                {
                    return this._tbl_paymentTableAdapter.Connection;
                }
                if ((this._tbl_purchaseTableAdapter != null) && (this._tbl_purchaseTableAdapter.Connection != null))
                {
                    return this._tbl_purchaseTableAdapter.Connection;
                }
                if ((this._tbl_salaryTableAdapter != null) && (this._tbl_salaryTableAdapter.Connection != null))
                {
                    return this._tbl_salaryTableAdapter.Connection;
                }
                if ((this._tbl_sales_motorcycleTableAdapter != null) && (this._tbl_sales_motorcycleTableAdapter.Connection != null))
                {
                    return this._tbl_sales_motorcycleTableAdapter.Connection;
                }
                if ((this._tbl_sales_partsTableAdapter != null) && (this._tbl_sales_partsTableAdapter.Connection != null))
                {
                    return this._tbl_sales_partsTableAdapter.Connection;
                }
                if ((this._tbl_sales_serviceTableAdapter != null) && (this._tbl_sales_serviceTableAdapter.Connection != null))
                {
                    return this._tbl_sales_serviceTableAdapter.Connection;
                }
                if ((this._tbl_serviceTableAdapter != null) && (this._tbl_serviceTableAdapter.Connection != null))
                {
                    return this._tbl_serviceTableAdapter.Connection;
                }
                if ((this._tbl_service_chargeTableAdapter != null) && (this._tbl_service_chargeTableAdapter.Connection != null))
                {
                    return this._tbl_service_chargeTableAdapter.Connection;
                }
                if ((this._tbl_transcationTableAdapter != null) && (this._tbl_transcationTableAdapter.Connection != null))
                {
                    return this._tbl_transcationTableAdapter.Connection;
                }
                if ((this._tbl_userTableAdapter != null) && (this._tbl_userTableAdapter.Connection != null))
                {
                    return this._tbl_userTableAdapter.Connection;
                }
                if ((this._tbl_vehicleTableAdapter != null) && (this._tbl_vehicleTableAdapter.Connection != null))
                {
                    return this._tbl_vehicleTableAdapter.Connection;
                }
                if ((this._tbl_vehicle_infoTableAdapter != null) && (this._tbl_vehicle_infoTableAdapter.Connection != null))
                {
                    return this._tbl_vehicle_infoTableAdapter.Connection;
                }
                return null;
            }
            set
            {
                this._connection = value;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public int TableAdapterInstanceCount
        {
            get
            {
                int num = 0;
                if (this._tbl_advance_payTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_bank_infoTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_bank_transcationTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_cash_expencesTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_customerTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_employeeTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_expencesTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_loanTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_partsTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_parts_infoTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_partyTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_party_transcationTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_paymentTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_purchaseTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_salaryTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_sales_motorcycleTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_sales_partsTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_sales_serviceTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_serviceTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_service_chargeTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_transcationTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_userTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_vehicleTableAdapter != null)
                {
                    num++;
                }
                if (this._tbl_vehicle_infoTableAdapter != null)
                {
                    num++;
                }
                return num;
            }
        }

        [DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_advance_payTableAdapter tbl_advance_payTableAdapter
        {
            get
            {
                return this._tbl_advance_payTableAdapter;
            }
            set
            {
                this._tbl_advance_payTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_bank_infoTableAdapter tbl_bank_infoTableAdapter
        {
            get
            {
                return this._tbl_bank_infoTableAdapter;
            }
            set
            {
                this._tbl_bank_infoTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_bank_transcationTableAdapter tbl_bank_transcationTableAdapter
        {
            get
            {
                return this._tbl_bank_transcationTableAdapter;
            }
            set
            {
                this._tbl_bank_transcationTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_cash_expencesTableAdapter tbl_cash_expencesTableAdapter
        {
            get
            {
                return this._tbl_cash_expencesTableAdapter;
            }
            set
            {
                this._tbl_cash_expencesTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter
        {
            get
            {
                return this._tbl_customerTableAdapter;
            }
            set
            {
                this._tbl_customerTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter
        {
            get
            {
                return this._tbl_employeeTableAdapter;
            }
            set
            {
                this._tbl_employeeTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_expencesTableAdapter tbl_expencesTableAdapter
        {
            get
            {
                return this._tbl_expencesTableAdapter;
            }
            set
            {
                this._tbl_expencesTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_loanTableAdapter tbl_loanTableAdapter
        {
            get
            {
                return this._tbl_loanTableAdapter;
            }
            set
            {
                this._tbl_loanTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_parts_infoTableAdapter tbl_parts_infoTableAdapter
        {
            get
            {
                return this._tbl_parts_infoTableAdapter;
            }
            set
            {
                this._tbl_parts_infoTableAdapter = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_partsTableAdapter tbl_partsTableAdapter
        {
            get
            {
                return this._tbl_partsTableAdapter;
            }
            set
            {
                this._tbl_partsTableAdapter = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_party_transcationTableAdapter tbl_party_transcationTableAdapter
        {
            get
            {
                return this._tbl_party_transcationTableAdapter;
            }
            set
            {
                this._tbl_party_transcationTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_partyTableAdapter tbl_partyTableAdapter
        {
            get
            {
                return this._tbl_partyTableAdapter;
            }
            set
            {
                this._tbl_partyTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_paymentTableAdapter tbl_paymentTableAdapter
        {
            get
            {
                return this._tbl_paymentTableAdapter;
            }
            set
            {
                this._tbl_paymentTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_purchaseTableAdapter tbl_purchaseTableAdapter
        {
            get
            {
                return this._tbl_purchaseTableAdapter;
            }
            set
            {
                this._tbl_purchaseTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_salaryTableAdapter tbl_salaryTableAdapter
        {
            get
            {
                return this._tbl_salaryTableAdapter;
            }
            set
            {
                this._tbl_salaryTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_sales_motorcycleTableAdapter tbl_sales_motorcycleTableAdapter
        {
            get
            {
                return this._tbl_sales_motorcycleTableAdapter;
            }
            set
            {
                this._tbl_sales_motorcycleTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_sales_partsTableAdapter tbl_sales_partsTableAdapter
        {
            get
            {
                return this._tbl_sales_partsTableAdapter;
            }
            set
            {
                this._tbl_sales_partsTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_sales_serviceTableAdapter tbl_sales_serviceTableAdapter
        {
            get
            {
                return this._tbl_sales_serviceTableAdapter;
            }
            set
            {
                this._tbl_sales_serviceTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_service_chargeTableAdapter tbl_service_chargeTableAdapter
        {
            get
            {
                return this._tbl_service_chargeTableAdapter;
            }
            set
            {
                this._tbl_service_chargeTableAdapter = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_serviceTableAdapter tbl_serviceTableAdapter
        {
            get
            {
                return this._tbl_serviceTableAdapter;
            }
            set
            {
                this._tbl_serviceTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_transcationTableAdapter tbl_transcationTableAdapter
        {
            get
            {
                return this._tbl_transcationTableAdapter;
            }
            set
            {
                this._tbl_transcationTableAdapter = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_userTableAdapter tbl_userTableAdapter
        {
            get
            {
                return this._tbl_userTableAdapter;
            }
            set
            {
                this._tbl_userTableAdapter = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_vehicle_infoTableAdapter tbl_vehicle_infoTableAdapter
        {
            get
            {
                return this._tbl_vehicle_infoTableAdapter;
            }
            set
            {
                this._tbl_vehicle_infoTableAdapter = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public FirozCenterHonda.teDataSetTableAdapters.tbl_vehicleTableAdapter tbl_vehicleTableAdapter
        {
            get
            {
                return this._tbl_vehicleTableAdapter;
            }
            set
            {
                this._tbl_vehicleTableAdapter = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public UpdateOrderOption UpdateOrder
        {
            get
            {
                return this._updateOrder;
            }
            set
            {
                this._updateOrder = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : IComparer<DataRow>
        {
            private int _childFirst;
            private DataRelation _relation;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal SelfReferenceComparer(DataRelation relation, bool childFirst)
            {
                this._relation = relation;
                if (childFirst)
                {
                    this._childFirst = -1;
                }
                else
                {
                    this._childFirst = 1;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Compare(DataRow row1, DataRow row2)
            {
                if (object.ReferenceEquals(row1, row2))
                {
                    return 0;
                }
                if (row1 == null)
                {
                    return -1;
                }
                if (row2 != null)
                {
                    int distance = 0;
                    DataRow root = this.GetRoot(row1, out distance);
                    int num2 = 0;
                    DataRow objB = this.GetRoot(row2, out num2);
                    if (object.ReferenceEquals(root, objB))
                    {
                        return (this._childFirst * distance.CompareTo(num2));
                    }
                    Debug.Assert((root.Table != null) && (objB.Table != null));
                    if (root.Table.Rows.IndexOf(root) < objB.Table.Rows.IndexOf(objB))
                    {
                        return -1;
                    }
                }
                return 1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private DataRow GetRoot(DataRow row, out int distance)
            {
                DataRow row3;
                Debug.Assert(row != null);
                DataRow row2 = row;
                distance = 0;
                IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
                dictionary[row] = row;
                for (row3 = row.GetParentRow(this._relation, DataRowVersion.Default); (row3 != null) && !dictionary.ContainsKey(row3); row3 = row3.GetParentRow(this._relation, DataRowVersion.Default))
                {
                    distance++;
                    row2 = row3;
                    dictionary[row3] = row3;
                }
                if (distance == 0)
                {
                    dictionary.Clear();
                    dictionary[row] = row;
                    for (row3 = row.GetParentRow(this._relation, DataRowVersion.Original); (row3 != null) && !dictionary.ContainsKey(row3); row3 = row3.GetParentRow(this._relation, DataRowVersion.Original))
                    {
                        distance++;
                        row2 = row3;
                        dictionary[row3] = row3;
                    }
                }
                return row2;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption
        {
            InsertUpdateDelete,
            UpdateInsertDelete
        }
    }
}

