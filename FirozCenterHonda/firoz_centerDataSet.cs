namespace FirozCenterHonda
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, ToolboxItem(true), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), XmlRoot("teDataSet"), DesignerCategory("code")]
    public class teDataSet : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private tbl_advance_payDataTable tabletbl_advance_pay;
        private tbl_bank_infoDataTable tabletbl_bank_info;
        private tbl_bank_transcationDataTable tabletbl_bank_transcation;
        private tbl_cash_expencesDataTable tabletbl_cash_expences;
        private tbl_customerDataTable tabletbl_customer;
        private tbl_employeeDataTable tabletbl_employee;
        private tbl_expencesDataTable tabletbl_expences;
        private tbl_loanDataTable tabletbl_loan;
        private tbl_partsDataTable tabletbl_parts;
        private tbl_parts_infoDataTable tabletbl_parts_info;
        private tbl_partyDataTable tabletbl_party;
        private tbl_party_transcationDataTable tabletbl_party_transcation;
        private tbl_paymentDataTable tabletbl_payment;
        private tbl_purchaseDataTable tabletbl_purchase;
        private tbl_salaryDataTable tabletbl_salary;
        private tbl_sales_motorcycleDataTable tabletbl_sales_motorcycle;
        private tbl_sales_partsDataTable tabletbl_sales_parts;
        private tbl_sales_serviceDataTable tabletbl_sales_service;
        private tbl_serviceDataTable tabletbl_service;
        private tbl_service_chargeDataTable tabletbl_service_charge;
        private tbl_transcationDataTable tabletbl_transcation;
        private tbl_userDataTable tabletbl_user;
        private tbl_vehicleDataTable tabletbl_vehicle;
        private tbl_vehicle_infoDataTable tabletbl_vehicle_info;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public teDataSet()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.InitClass();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected teDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(info, context))
            {
                this.InitVars(false);
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
            else
            {
                string s = (string) info.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["tbl_advance_pay"] != null)
                    {
                        base.Tables.Add(new tbl_advance_payDataTable(dataSet.Tables["tbl_advance_pay"]));
                    }
                    if (dataSet.Tables["tbl_bank_info"] != null)
                    {
                        base.Tables.Add(new tbl_bank_infoDataTable(dataSet.Tables["tbl_bank_info"]));
                    }
                    if (dataSet.Tables["tbl_bank_transcation"] != null)
                    {
                        base.Tables.Add(new tbl_bank_transcationDataTable(dataSet.Tables["tbl_bank_transcation"]));
                    }
                    if (dataSet.Tables["tbl_cash_expences"] != null)
                    {
                        base.Tables.Add(new tbl_cash_expencesDataTable(dataSet.Tables["tbl_cash_expences"]));
                    }
                    if (dataSet.Tables["tbl_customer"] != null)
                    {
                        base.Tables.Add(new tbl_customerDataTable(dataSet.Tables["tbl_customer"]));
                    }
                    if (dataSet.Tables["tbl_employee"] != null)
                    {
                        base.Tables.Add(new tbl_employeeDataTable(dataSet.Tables["tbl_employee"]));
                    }
                    if (dataSet.Tables["tbl_expences"] != null)
                    {
                        base.Tables.Add(new tbl_expencesDataTable(dataSet.Tables["tbl_expences"]));
                    }
                    if (dataSet.Tables["tbl_loan"] != null)
                    {
                        base.Tables.Add(new tbl_loanDataTable(dataSet.Tables["tbl_loan"]));
                    }
                    if (dataSet.Tables["tbl_parts"] != null)
                    {
                        base.Tables.Add(new tbl_partsDataTable(dataSet.Tables["tbl_parts"]));
                    }
                    if (dataSet.Tables["tbl_parts_info"] != null)
                    {
                        base.Tables.Add(new tbl_parts_infoDataTable(dataSet.Tables["tbl_parts_info"]));
                    }
                    if (dataSet.Tables["tbl_party"] != null)
                    {
                        base.Tables.Add(new tbl_partyDataTable(dataSet.Tables["tbl_party"]));
                    }
                    if (dataSet.Tables["tbl_party_transcation"] != null)
                    {
                        base.Tables.Add(new tbl_party_transcationDataTable(dataSet.Tables["tbl_party_transcation"]));
                    }
                    if (dataSet.Tables["tbl_payment"] != null)
                    {
                        base.Tables.Add(new tbl_paymentDataTable(dataSet.Tables["tbl_payment"]));
                    }
                    if (dataSet.Tables["tbl_purchase"] != null)
                    {
                        base.Tables.Add(new tbl_purchaseDataTable(dataSet.Tables["tbl_purchase"]));
                    }
                    if (dataSet.Tables["tbl_salary"] != null)
                    {
                        base.Tables.Add(new tbl_salaryDataTable(dataSet.Tables["tbl_salary"]));
                    }
                    if (dataSet.Tables["tbl_sales_motorcycle"] != null)
                    {
                        base.Tables.Add(new tbl_sales_motorcycleDataTable(dataSet.Tables["tbl_sales_motorcycle"]));
                    }
                    if (dataSet.Tables["tbl_sales_parts"] != null)
                    {
                        base.Tables.Add(new tbl_sales_partsDataTable(dataSet.Tables["tbl_sales_parts"]));
                    }
                    if (dataSet.Tables["tbl_sales_service"] != null)
                    {
                        base.Tables.Add(new tbl_sales_serviceDataTable(dataSet.Tables["tbl_sales_service"]));
                    }
                    if (dataSet.Tables["tbl_service"] != null)
                    {
                        base.Tables.Add(new tbl_serviceDataTable(dataSet.Tables["tbl_service"]));
                    }
                    if (dataSet.Tables["tbl_service_charge"] != null)
                    {
                        base.Tables.Add(new tbl_service_chargeDataTable(dataSet.Tables["tbl_service_charge"]));
                    }
                    if (dataSet.Tables["tbl_transcation"] != null)
                    {
                        base.Tables.Add(new tbl_transcationDataTable(dataSet.Tables["tbl_transcation"]));
                    }
                    if (dataSet.Tables["tbl_user"] != null)
                    {
                        base.Tables.Add(new tbl_userDataTable(dataSet.Tables["tbl_user"]));
                    }
                    if (dataSet.Tables["tbl_vehicle"] != null)
                    {
                        base.Tables.Add(new tbl_vehicleDataTable(dataSet.Tables["tbl_vehicle"]));
                    }
                    if (dataSet.Tables["tbl_vehicle_info"] != null)
                    {
                        base.Tables.Add(new tbl_vehicle_infoDataTable(dataSet.Tables["tbl_vehicle_info"]));
                    }
                    base.DataSetName = dataSet.DataSetName;
                    base.Prefix = dataSet.Prefix;
                    base.Namespace = dataSet.Namespace;
                    base.Locale = dataSet.Locale;
                    base.CaseSensitive = dataSet.CaseSensitive;
                    base.EnforceConstraints = dataSet.EnforceConstraints;
                    base.Merge(dataSet, false, MissingSchemaAction.Add);
                    this.InitVars();
                }
                else
                {
                    base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                }
                base.GetSerializationData(info, context);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.SchemaChanged);
                base.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public override DataSet Clone()
        {
            teDataSet set = (teDataSet) base.Clone();
            set.InitVars();
            set.SchemaSerializationMode = this.SchemaSerializationMode;
            return set;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override XmlSchema GetSchemaSerializable()
        {
            MemoryStream w = new MemoryStream();
            base.WriteXmlSchema(new XmlTextWriter(w, null));
            w.Position = 0L;
            return XmlSchema.Read(new XmlTextReader(w), null);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
        {
            teDataSet set = new teDataSet();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = set.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = set.GetSchemaSerializable();
            if (xs.Contains(schemaSerializable.TargetNamespace))
            {
                MemoryStream stream = new MemoryStream();
                MemoryStream stream2 = new MemoryStream();
                try
                {
                    XmlSchema current = null;
                    schemaSerializable.Write(stream);
                    IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        current = (XmlSchema) enumerator.Current;
                        stream2.SetLength(0L);
                        current.Write(stream2);
                        if (stream.Length == stream2.Length)
                        {
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                            {
                            }
                            if (stream.Position == stream.Length)
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
            }
            xs.Add(schemaSerializable);
            return type;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void InitClass()
        {
            base.DataSetName = "teDataSet";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/teDataSet.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletbl_advance_pay = new tbl_advance_payDataTable();
            base.Tables.Add(this.tabletbl_advance_pay);
            this.tabletbl_bank_info = new tbl_bank_infoDataTable();
            base.Tables.Add(this.tabletbl_bank_info);
            this.tabletbl_bank_transcation = new tbl_bank_transcationDataTable();
            base.Tables.Add(this.tabletbl_bank_transcation);
            this.tabletbl_cash_expences = new tbl_cash_expencesDataTable();
            base.Tables.Add(this.tabletbl_cash_expences);
            this.tabletbl_customer = new tbl_customerDataTable();
            base.Tables.Add(this.tabletbl_customer);
            this.tabletbl_employee = new tbl_employeeDataTable();
            base.Tables.Add(this.tabletbl_employee);
            this.tabletbl_expences = new tbl_expencesDataTable();
            base.Tables.Add(this.tabletbl_expences);
            this.tabletbl_loan = new tbl_loanDataTable();
            base.Tables.Add(this.tabletbl_loan);
            this.tabletbl_parts = new tbl_partsDataTable();
            base.Tables.Add(this.tabletbl_parts);
            this.tabletbl_parts_info = new tbl_parts_infoDataTable();
            base.Tables.Add(this.tabletbl_parts_info);
            this.tabletbl_party = new tbl_partyDataTable();
            base.Tables.Add(this.tabletbl_party);
            this.tabletbl_party_transcation = new tbl_party_transcationDataTable();
            base.Tables.Add(this.tabletbl_party_transcation);
            this.tabletbl_payment = new tbl_paymentDataTable();
            base.Tables.Add(this.tabletbl_payment);
            this.tabletbl_purchase = new tbl_purchaseDataTable();
            base.Tables.Add(this.tabletbl_purchase);
            this.tabletbl_salary = new tbl_salaryDataTable();
            base.Tables.Add(this.tabletbl_salary);
            this.tabletbl_sales_motorcycle = new tbl_sales_motorcycleDataTable();
            base.Tables.Add(this.tabletbl_sales_motorcycle);
            this.tabletbl_sales_parts = new tbl_sales_partsDataTable();
            base.Tables.Add(this.tabletbl_sales_parts);
            this.tabletbl_sales_service = new tbl_sales_serviceDataTable();
            base.Tables.Add(this.tabletbl_sales_service);
            this.tabletbl_service = new tbl_serviceDataTable();
            base.Tables.Add(this.tabletbl_service);
            this.tabletbl_service_charge = new tbl_service_chargeDataTable();
            base.Tables.Add(this.tabletbl_service_charge);
            this.tabletbl_transcation = new tbl_transcationDataTable();
            base.Tables.Add(this.tabletbl_transcation);
            this.tabletbl_user = new tbl_userDataTable();
            base.Tables.Add(this.tabletbl_user);
            this.tabletbl_vehicle = new tbl_vehicleDataTable();
            base.Tables.Add(this.tabletbl_vehicle);
            this.tabletbl_vehicle_info = new tbl_vehicle_infoDataTable();
            base.Tables.Add(this.tabletbl_vehicle_info);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            base.BeginInit();
            this.InitClass();
            base.EndInit();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.InitVars(true);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void InitVars(bool initTable)
        {
            this.tabletbl_advance_pay = (tbl_advance_payDataTable) base.Tables["tbl_advance_pay"];
            if (initTable && (this.tabletbl_advance_pay != null))
            {
                this.tabletbl_advance_pay.InitVars();
            }
            this.tabletbl_bank_info = (tbl_bank_infoDataTable) base.Tables["tbl_bank_info"];
            if (initTable && (this.tabletbl_bank_info != null))
            {
                this.tabletbl_bank_info.InitVars();
            }
            this.tabletbl_bank_transcation = (tbl_bank_transcationDataTable) base.Tables["tbl_bank_transcation"];
            if (initTable && (this.tabletbl_bank_transcation != null))
            {
                this.tabletbl_bank_transcation.InitVars();
            }
            this.tabletbl_cash_expences = (tbl_cash_expencesDataTable) base.Tables["tbl_cash_expences"];
            if (initTable && (this.tabletbl_cash_expences != null))
            {
                this.tabletbl_cash_expences.InitVars();
            }
            this.tabletbl_customer = (tbl_customerDataTable) base.Tables["tbl_customer"];
            if (initTable && (this.tabletbl_customer != null))
            {
                this.tabletbl_customer.InitVars();
            }
            this.tabletbl_employee = (tbl_employeeDataTable) base.Tables["tbl_employee"];
            if (initTable && (this.tabletbl_employee != null))
            {
                this.tabletbl_employee.InitVars();
            }
            this.tabletbl_expences = (tbl_expencesDataTable) base.Tables["tbl_expences"];
            if (initTable && (this.tabletbl_expences != null))
            {
                this.tabletbl_expences.InitVars();
            }
            this.tabletbl_loan = (tbl_loanDataTable) base.Tables["tbl_loan"];
            if (initTable && (this.tabletbl_loan != null))
            {
                this.tabletbl_loan.InitVars();
            }
            this.tabletbl_parts = (tbl_partsDataTable) base.Tables["tbl_parts"];
            if (initTable && (this.tabletbl_parts != null))
            {
                this.tabletbl_parts.InitVars();
            }
            this.tabletbl_parts_info = (tbl_parts_infoDataTable) base.Tables["tbl_parts_info"];
            if (initTable && (this.tabletbl_parts_info != null))
            {
                this.tabletbl_parts_info.InitVars();
            }
            this.tabletbl_party = (tbl_partyDataTable) base.Tables["tbl_party"];
            if (initTable && (this.tabletbl_party != null))
            {
                this.tabletbl_party.InitVars();
            }
            this.tabletbl_party_transcation = (tbl_party_transcationDataTable) base.Tables["tbl_party_transcation"];
            if (initTable && (this.tabletbl_party_transcation != null))
            {
                this.tabletbl_party_transcation.InitVars();
            }
            this.tabletbl_payment = (tbl_paymentDataTable) base.Tables["tbl_payment"];
            if (initTable && (this.tabletbl_payment != null))
            {
                this.tabletbl_payment.InitVars();
            }
            this.tabletbl_purchase = (tbl_purchaseDataTable) base.Tables["tbl_purchase"];
            if (initTable && (this.tabletbl_purchase != null))
            {
                this.tabletbl_purchase.InitVars();
            }
            this.tabletbl_salary = (tbl_salaryDataTable) base.Tables["tbl_salary"];
            if (initTable && (this.tabletbl_salary != null))
            {
                this.tabletbl_salary.InitVars();
            }
            this.tabletbl_sales_motorcycle = (tbl_sales_motorcycleDataTable) base.Tables["tbl_sales_motorcycle"];
            if (initTable && (this.tabletbl_sales_motorcycle != null))
            {
                this.tabletbl_sales_motorcycle.InitVars();
            }
            this.tabletbl_sales_parts = (tbl_sales_partsDataTable) base.Tables["tbl_sales_parts"];
            if (initTable && (this.tabletbl_sales_parts != null))
            {
                this.tabletbl_sales_parts.InitVars();
            }
            this.tabletbl_sales_service = (tbl_sales_serviceDataTable) base.Tables["tbl_sales_service"];
            if (initTable && (this.tabletbl_sales_service != null))
            {
                this.tabletbl_sales_service.InitVars();
            }
            this.tabletbl_service = (tbl_serviceDataTable) base.Tables["tbl_service"];
            if (initTable && (this.tabletbl_service != null))
            {
                this.tabletbl_service.InitVars();
            }
            this.tabletbl_service_charge = (tbl_service_chargeDataTable) base.Tables["tbl_service_charge"];
            if (initTable && (this.tabletbl_service_charge != null))
            {
                this.tabletbl_service_charge.InitVars();
            }
            this.tabletbl_transcation = (tbl_transcationDataTable) base.Tables["tbl_transcation"];
            if (initTable && (this.tabletbl_transcation != null))
            {
                this.tabletbl_transcation.InitVars();
            }
            this.tabletbl_user = (tbl_userDataTable) base.Tables["tbl_user"];
            if (initTable && (this.tabletbl_user != null))
            {
                this.tabletbl_user.InitVars();
            }
            this.tabletbl_vehicle = (tbl_vehicleDataTable) base.Tables["tbl_vehicle"];
            if (initTable && (this.tabletbl_vehicle != null))
            {
                this.tabletbl_vehicle.InitVars();
            }
            this.tabletbl_vehicle_info = (tbl_vehicle_infoDataTable) base.Tables["tbl_vehicle_info"];
            if (initTable && (this.tabletbl_vehicle_info != null))
            {
                this.tabletbl_vehicle_info.InitVars();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["tbl_advance_pay"] != null)
                {
                    base.Tables.Add(new tbl_advance_payDataTable(dataSet.Tables["tbl_advance_pay"]));
                }
                if (dataSet.Tables["tbl_bank_info"] != null)
                {
                    base.Tables.Add(new tbl_bank_infoDataTable(dataSet.Tables["tbl_bank_info"]));
                }
                if (dataSet.Tables["tbl_bank_transcation"] != null)
                {
                    base.Tables.Add(new tbl_bank_transcationDataTable(dataSet.Tables["tbl_bank_transcation"]));
                }
                if (dataSet.Tables["tbl_cash_expences"] != null)
                {
                    base.Tables.Add(new tbl_cash_expencesDataTable(dataSet.Tables["tbl_cash_expences"]));
                }
                if (dataSet.Tables["tbl_customer"] != null)
                {
                    base.Tables.Add(new tbl_customerDataTable(dataSet.Tables["tbl_customer"]));
                }
                if (dataSet.Tables["tbl_employee"] != null)
                {
                    base.Tables.Add(new tbl_employeeDataTable(dataSet.Tables["tbl_employee"]));
                }
                if (dataSet.Tables["tbl_expences"] != null)
                {
                    base.Tables.Add(new tbl_expencesDataTable(dataSet.Tables["tbl_expences"]));
                }
                if (dataSet.Tables["tbl_loan"] != null)
                {
                    base.Tables.Add(new tbl_loanDataTable(dataSet.Tables["tbl_loan"]));
                }
                if (dataSet.Tables["tbl_parts"] != null)
                {
                    base.Tables.Add(new tbl_partsDataTable(dataSet.Tables["tbl_parts"]));
                }
                if (dataSet.Tables["tbl_parts_info"] != null)
                {
                    base.Tables.Add(new tbl_parts_infoDataTable(dataSet.Tables["tbl_parts_info"]));
                }
                if (dataSet.Tables["tbl_party"] != null)
                {
                    base.Tables.Add(new tbl_partyDataTable(dataSet.Tables["tbl_party"]));
                }
                if (dataSet.Tables["tbl_party_transcation"] != null)
                {
                    base.Tables.Add(new tbl_party_transcationDataTable(dataSet.Tables["tbl_party_transcation"]));
                }
                if (dataSet.Tables["tbl_payment"] != null)
                {
                    base.Tables.Add(new tbl_paymentDataTable(dataSet.Tables["tbl_payment"]));
                }
                if (dataSet.Tables["tbl_purchase"] != null)
                {
                    base.Tables.Add(new tbl_purchaseDataTable(dataSet.Tables["tbl_purchase"]));
                }
                if (dataSet.Tables["tbl_salary"] != null)
                {
                    base.Tables.Add(new tbl_salaryDataTable(dataSet.Tables["tbl_salary"]));
                }
                if (dataSet.Tables["tbl_sales_motorcycle"] != null)
                {
                    base.Tables.Add(new tbl_sales_motorcycleDataTable(dataSet.Tables["tbl_sales_motorcycle"]));
                }
                if (dataSet.Tables["tbl_sales_parts"] != null)
                {
                    base.Tables.Add(new tbl_sales_partsDataTable(dataSet.Tables["tbl_sales_parts"]));
                }
                if (dataSet.Tables["tbl_sales_service"] != null)
                {
                    base.Tables.Add(new tbl_sales_serviceDataTable(dataSet.Tables["tbl_sales_service"]));
                }
                if (dataSet.Tables["tbl_service"] != null)
                {
                    base.Tables.Add(new tbl_serviceDataTable(dataSet.Tables["tbl_service"]));
                }
                if (dataSet.Tables["tbl_service_charge"] != null)
                {
                    base.Tables.Add(new tbl_service_chargeDataTable(dataSet.Tables["tbl_service_charge"]));
                }
                if (dataSet.Tables["tbl_transcation"] != null)
                {
                    base.Tables.Add(new tbl_transcationDataTable(dataSet.Tables["tbl_transcation"]));
                }
                if (dataSet.Tables["tbl_user"] != null)
                {
                    base.Tables.Add(new tbl_userDataTable(dataSet.Tables["tbl_user"]));
                }
                if (dataSet.Tables["tbl_vehicle"] != null)
                {
                    base.Tables.Add(new tbl_vehicleDataTable(dataSet.Tables["tbl_vehicle"]));
                }
                if (dataSet.Tables["tbl_vehicle_info"] != null)
                {
                    base.Tables.Add(new tbl_vehicle_infoDataTable(dataSet.Tables["tbl_vehicle_info"]));
                }
                base.DataSetName = dataSet.DataSetName;
                base.Prefix = dataSet.Prefix;
                base.Namespace = dataSet.Namespace;
                base.Locale = dataSet.Locale;
                base.CaseSensitive = dataSet.CaseSensitive;
                base.EnforceConstraints = dataSet.EnforceConstraints;
                base.Merge(dataSet, false, MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                base.ReadXml(reader);
                this.InitVars();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.InitVars();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_advance_pay()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_bank_info()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_bank_transcation()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_cash_expences()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_customer()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_employee()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_expences()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_loan()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_parts()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_parts_info()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_party()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_party_transcation()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_payment()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_purchase()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_salary()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_sales_motorcycle()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_sales_parts()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_sales_service()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_service()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_service_charge()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_transcation()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializetbl_user()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_vehicle()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool ShouldSerializetbl_vehicle_info()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
        public DataRelationCollection Relationss
        {
            get
            {
                return base.Relations;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode, Browsable(true)]
        public override System.Data.SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this._schemaSerializationMode;
            }
            set
            {
                this._schemaSerializationMode = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataTableCollection Tabless
        {
            get
            {
                return base.Tables;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public tbl_advance_payDataTable tbl_advance_pay
        {
            get
            {
                return this.tabletbl_advance_pay;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tbl_bank_infoDataTable tbl_bank_info
        {
            get
            {
                return this.tabletbl_bank_info;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tbl_bank_transcationDataTable tbl_bank_transcation
        {
            get
            {
                return this.tabletbl_bank_transcation;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public tbl_cash_expencesDataTable tbl_cash_expences
        {
            get
            {
                return this.tabletbl_cash_expences;
            }
        }

        [Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_customerDataTable tbl_customer
        {
            get
            {
                return this.tabletbl_customer;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public tbl_employeeDataTable tbl_employee
        {
            get
            {
                return this.tabletbl_employee;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tbl_expencesDataTable tbl_expences
        {
            get
            {
                return this.tabletbl_expences;
            }
        }

        [Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_loanDataTable tbl_loan
        {
            get
            {
                return this.tabletbl_loan;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_partsDataTable tbl_parts
        {
            get
            {
                return this.tabletbl_parts;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public tbl_parts_infoDataTable tbl_parts_info
        {
            get
            {
                return this.tabletbl_parts_info;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_partyDataTable tbl_party
        {
            get
            {
                return this.tabletbl_party;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tbl_party_transcationDataTable tbl_party_transcation
        {
            get
            {
                return this.tabletbl_party_transcation;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tbl_paymentDataTable tbl_payment
        {
            get
            {
                return this.tabletbl_payment;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_purchaseDataTable tbl_purchase
        {
            get
            {
                return this.tabletbl_purchase;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tbl_salaryDataTable tbl_salary
        {
            get
            {
                return this.tabletbl_salary;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tbl_sales_motorcycleDataTable tbl_sales_motorcycle
        {
            get
            {
                return this.tabletbl_sales_motorcycle;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public tbl_sales_partsDataTable tbl_sales_parts
        {
            get
            {
                return this.tabletbl_sales_parts;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tbl_sales_serviceDataTable tbl_sales_service
        {
            get
            {
                return this.tabletbl_sales_service;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public tbl_serviceDataTable tbl_service
        {
            get
            {
                return this.tabletbl_service;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tbl_service_chargeDataTable tbl_service_charge
        {
            get
            {
                return this.tabletbl_service_charge;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tbl_transcationDataTable tbl_transcation
        {
            get
            {
                return this.tabletbl_transcation;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tbl_userDataTable tbl_user
        {
            get
            {
                return this.tabletbl_user;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public tbl_vehicleDataTable tbl_vehicle
        {
            get
            {
                return this.tabletbl_vehicle;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tbl_vehicle_infoDataTable tbl_vehicle_info
        {
            get
            {
                return this.tabletbl_vehicle_info;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_advance_payDataTable : TypedTableBase<teDataSet.tbl_advance_payRow>
        {
            private DataColumn columnadvancepay_id;
            private DataColumn columnamount;
            private DataColumn columndate;
            private DataColumn columndescription;
            private DataColumn columnemployee_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_advance_payRowChangeEventHandler tbl_advance_payRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_advance_payRowChangeEventHandler tbl_advance_payRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_advance_payRowChangeEventHandler tbl_advance_payRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_advance_payRowChangeEventHandler tbl_advance_payRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_advance_payDataTable()
            {
                base.TableName = "tbl_advance_pay";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_advance_payDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_advance_payDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_advance_payRow(teDataSet.tbl_advance_payRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_advance_payRow Addtbl_advance_payRow(uint advancepay_id, uint employee_id, DateTime date, double amount, string description)
            {
                teDataSet.tbl_advance_payRow row = (teDataSet.tbl_advance_payRow) base.NewRow();
                row.ItemArray = new object[] { advancepay_id, employee_id, date, amount, description };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_advance_payDataTable table = (teDataSet.tbl_advance_payDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_advance_payDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_advance_payRow FindByadvancepay_id(uint advancepay_id)
            {
                return (teDataSet.tbl_advance_payRow) base.Rows.Find(new object[] { advancepay_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_advance_payRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_advance_payDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnadvancepay_id = new DataColumn("advancepay_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnadvancepay_id);
                this.columnemployee_id = new DataColumn("employee_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnemployee_id);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnamount = new DataColumn("amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnadvancepay_id }, true));
                this.columnadvancepay_id.AllowDBNull = false;
                this.columnadvancepay_id.Unique = true;
                this.columnemployee_id.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columnamount.AllowDBNull = false;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnadvancepay_id = base.Columns["advancepay_id"];
                this.columnemployee_id = base.Columns["employee_id"];
                this.columndate = base.Columns["date"];
                this.columnamount = base.Columns["amount"];
                this.columndescription = base.Columns["description"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_advance_payRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_advance_payRow Newtbl_advance_payRow()
            {
                return (teDataSet.tbl_advance_payRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_advance_payRowChanged != null)
                {
                    this.tbl_advance_payRowChanged(this, new teDataSet.tbl_advance_payRowChangeEvent((teDataSet.tbl_advance_payRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_advance_payRowChanging != null)
                {
                    this.tbl_advance_payRowChanging(this, new teDataSet.tbl_advance_payRowChangeEvent((teDataSet.tbl_advance_payRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_advance_payRowDeleted != null)
                {
                    this.tbl_advance_payRowDeleted(this, new teDataSet.tbl_advance_payRowChangeEvent((teDataSet.tbl_advance_payRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_advance_payRowDeleting != null)
                {
                    this.tbl_advance_payRowDeleting(this, new teDataSet.tbl_advance_payRowChangeEvent((teDataSet.tbl_advance_payRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_advance_payRow(teDataSet.tbl_advance_payRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn advancepay_idColumn
            {
                get
                {
                    return this.columnadvancepay_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn employee_idColumn
            {
                get
                {
                    return this.columnemployee_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_advance_payRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_advance_payRow) base.Rows[index];
                }
            }
        }

        public class tbl_advance_payRow : DataRow
        {
            private teDataSet.tbl_advance_payDataTable tabletbl_advance_pay;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_advance_payRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_advance_pay = (teDataSet.tbl_advance_payDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint advancepay_id
            {
                get
                {
                    return (uint) base[this.tabletbl_advance_pay.advancepay_idColumn];
                }
                set
                {
                    base[this.tabletbl_advance_pay.advancepay_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double amount
            {
                get
                {
                    return (double) base[this.tabletbl_advance_pay.amountColumn];
                }
                set
                {
                    base[this.tabletbl_advance_pay.amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_advance_pay.dateColumn];
                }
                set
                {
                    base[this.tabletbl_advance_pay.dateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_advance_pay.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_advance_pay.descriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint employee_id
            {
                get
                {
                    return (uint) base[this.tabletbl_advance_pay.employee_idColumn];
                }
                set
                {
                    base[this.tabletbl_advance_pay.employee_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_advance_payRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_advance_payRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_advance_payRowChangeEvent(teDataSet.tbl_advance_payRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_advance_payRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_advance_payRowChangeEventHandler(object sender, teDataSet.tbl_advance_payRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_bank_infoDataTable : TypedTableBase<teDataSet.tbl_bank_infoRow>
        {
            private DataColumn columnac_no;
            private DataColumn columnaddress;
            private DataColumn columnbalance;
            private DataColumn columnbank_id;
            private DataColumn columnbranch;
            private DataColumn columncomments;
            private DataColumn columncontact;
            private DataColumn columndescription;
            private DataColumn columnname;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_infoRowChangeEventHandler tbl_bank_infoRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_infoRowChangeEventHandler tbl_bank_infoRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_infoRowChangeEventHandler tbl_bank_infoRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_infoRowChangeEventHandler tbl_bank_infoRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_bank_infoDataTable()
            {
                base.TableName = "tbl_bank_info";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_bank_infoDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_bank_infoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_bank_infoRow(teDataSet.tbl_bank_infoRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_bank_infoRow Addtbl_bank_infoRow(uint bank_id, string name, string description, string branch, string address, string contact, string comments, string ac_no, double balance)
            {
                teDataSet.tbl_bank_infoRow row = (teDataSet.tbl_bank_infoRow) base.NewRow();
                row.ItemArray = new object[] { bank_id, name, description, branch, address, contact, comments, ac_no, balance };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_bank_infoDataTable table = (teDataSet.tbl_bank_infoDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_bank_infoDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_bank_infoRow FindBybank_id(uint bank_id)
            {
                return (teDataSet.tbl_bank_infoRow) base.Rows.Find(new object[] { bank_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_bank_infoRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_bank_infoDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnbank_id = new DataColumn("bank_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnbank_id);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columnbranch = new DataColumn("branch", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnbranch);
                this.columnaddress = new DataColumn("address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnaddress);
                this.columncontact = new DataColumn("contact", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncontact);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columnac_no = new DataColumn("ac_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnac_no);
                this.columnbalance = new DataColumn("balance", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnbalance);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnbank_id }, true));
                this.columnbank_id.AllowDBNull = false;
                this.columnbank_id.Unique = true;
                this.columnname.AllowDBNull = false;
                this.columnname.MaxLength = 0x2d;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 0x2d;
                this.columnbranch.AllowDBNull = false;
                this.columnbranch.MaxLength = 0x2d;
                this.columnaddress.AllowDBNull = false;
                this.columnaddress.MaxLength = 0x2d;
                this.columncontact.AllowDBNull = false;
                this.columncontact.MaxLength = 0x2d;
                this.columncomments.AllowDBNull = false;
                this.columncomments.MaxLength = 0x2d;
                this.columnac_no.AllowDBNull = false;
                this.columnac_no.MaxLength = 0x2d;
                this.columnbalance.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnbank_id = base.Columns["bank_id"];
                this.columnname = base.Columns["name"];
                this.columndescription = base.Columns["description"];
                this.columnbranch = base.Columns["branch"];
                this.columnaddress = base.Columns["address"];
                this.columncontact = base.Columns["contact"];
                this.columncomments = base.Columns["comments"];
                this.columnac_no = base.Columns["ac_no"];
                this.columnbalance = base.Columns["balance"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_bank_infoRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_bank_infoRow Newtbl_bank_infoRow()
            {
                return (teDataSet.tbl_bank_infoRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_bank_infoRowChanged != null)
                {
                    this.tbl_bank_infoRowChanged(this, new teDataSet.tbl_bank_infoRowChangeEvent((teDataSet.tbl_bank_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_bank_infoRowChanging != null)
                {
                    this.tbl_bank_infoRowChanging(this, new teDataSet.tbl_bank_infoRowChangeEvent((teDataSet.tbl_bank_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_bank_infoRowDeleted != null)
                {
                    this.tbl_bank_infoRowDeleted(this, new teDataSet.tbl_bank_infoRowChangeEvent((teDataSet.tbl_bank_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_bank_infoRowDeleting != null)
                {
                    this.tbl_bank_infoRowDeleting(this, new teDataSet.tbl_bank_infoRowChangeEvent((teDataSet.tbl_bank_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_bank_infoRow(teDataSet.tbl_bank_infoRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ac_noColumn
            {
                get
                {
                    return this.columnac_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn addressColumn
            {
                get
                {
                    return this.columnaddress;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn balanceColumn
            {
                get
                {
                    return this.columnbalance;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn bank_idColumn
            {
                get
                {
                    return this.columnbank_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn branchColumn
            {
                get
                {
                    return this.columnbranch;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn contactColumn
            {
                get
                {
                    return this.columncontact;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_bank_infoRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_bank_infoRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }
        }

        public class tbl_bank_infoRow : DataRow
        {
            private teDataSet.tbl_bank_infoDataTable tabletbl_bank_info;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_bank_infoRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_bank_info = (teDataSet.tbl_bank_infoDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string ac_no
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.ac_noColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.ac_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string address
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.addressColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.addressColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double balance
            {
                get
                {
                    return (double) base[this.tabletbl_bank_info.balanceColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.balanceColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint bank_id
            {
                get
                {
                    return (uint) base[this.tabletbl_bank_info.bank_idColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.bank_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string branch
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.branchColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.branchColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.commentsColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.commentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string contact
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.contactColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.contactColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.descriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string name
            {
                get
                {
                    return (string) base[this.tabletbl_bank_info.nameColumn];
                }
                set
                {
                    base[this.tabletbl_bank_info.nameColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_bank_infoRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_bank_infoRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_bank_infoRowChangeEvent(teDataSet.tbl_bank_infoRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_bank_infoRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_bank_infoRowChangeEventHandler(object sender, teDataSet.tbl_bank_infoRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_bank_transcationDataTable : TypedTableBase<teDataSet.tbl_bank_transcationRow>
        {
            private DataColumn columnamount;
            private DataColumn columnbank_id;
            private DataColumn columnbank_transcation_id;
            private DataColumn columncomments;
            private DataColumn columndate;
            private DataColumn columndescription;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_transcationRowChangeEventHandler tbl_bank_transcationRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_transcationRowChangeEventHandler tbl_bank_transcationRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_transcationRowChangeEventHandler tbl_bank_transcationRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_bank_transcationRowChangeEventHandler tbl_bank_transcationRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_bank_transcationDataTable()
            {
                base.TableName = "tbl_bank_transcation";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_bank_transcationDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_bank_transcationDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_bank_transcationRow(teDataSet.tbl_bank_transcationRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_bank_transcationRow Addtbl_bank_transcationRow(uint bank_transcation_id, uint bank_id, DateTime date, double amount, string description, string comments)
            {
                teDataSet.tbl_bank_transcationRow row = (teDataSet.tbl_bank_transcationRow) base.NewRow();
                row.ItemArray = new object[] { bank_transcation_id, bank_id, date, amount, description, comments };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_bank_transcationDataTable table = (teDataSet.tbl_bank_transcationDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_bank_transcationDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_bank_transcationRow FindBybank_transcation_id(uint bank_transcation_id)
            {
                return (teDataSet.tbl_bank_transcationRow) base.Rows.Find(new object[] { bank_transcation_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_bank_transcationRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_bank_transcationDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnbank_transcation_id = new DataColumn("bank_transcation_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnbank_transcation_id);
                this.columnbank_id = new DataColumn("bank_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnbank_id);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnamount = new DataColumn("amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnbank_transcation_id }, true));
                this.columnbank_transcation_id.AllowDBNull = false;
                this.columnbank_transcation_id.Unique = true;
                this.columnbank_id.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columnamount.AllowDBNull = false;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 100;
                this.columncomments.AllowDBNull = false;
                this.columncomments.MaxLength = 200;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnbank_transcation_id = base.Columns["bank_transcation_id"];
                this.columnbank_id = base.Columns["bank_id"];
                this.columndate = base.Columns["date"];
                this.columnamount = base.Columns["amount"];
                this.columndescription = base.Columns["description"];
                this.columncomments = base.Columns["comments"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_bank_transcationRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_bank_transcationRow Newtbl_bank_transcationRow()
            {
                return (teDataSet.tbl_bank_transcationRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_bank_transcationRowChanged != null)
                {
                    this.tbl_bank_transcationRowChanged(this, new teDataSet.tbl_bank_transcationRowChangeEvent((teDataSet.tbl_bank_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_bank_transcationRowChanging != null)
                {
                    this.tbl_bank_transcationRowChanging(this, new teDataSet.tbl_bank_transcationRowChangeEvent((teDataSet.tbl_bank_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_bank_transcationRowDeleted != null)
                {
                    this.tbl_bank_transcationRowDeleted(this, new teDataSet.tbl_bank_transcationRowChangeEvent((teDataSet.tbl_bank_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_bank_transcationRowDeleting != null)
                {
                    this.tbl_bank_transcationRowDeleting(this, new teDataSet.tbl_bank_transcationRowChangeEvent((teDataSet.tbl_bank_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_bank_transcationRow(teDataSet.tbl_bank_transcationRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn bank_idColumn
            {
                get
                {
                    return this.columnbank_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn bank_transcation_idColumn
            {
                get
                {
                    return this.columnbank_transcation_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_bank_transcationRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_bank_transcationRow) base.Rows[index];
                }
            }
        }

        public class tbl_bank_transcationRow : DataRow
        {
            private teDataSet.tbl_bank_transcationDataTable tabletbl_bank_transcation;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_bank_transcationRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_bank_transcation = (teDataSet.tbl_bank_transcationDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double amount
            {
                get
                {
                    return (double) base[this.tabletbl_bank_transcation.amountColumn];
                }
                set
                {
                    base[this.tabletbl_bank_transcation.amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint bank_id
            {
                get
                {
                    return (uint) base[this.tabletbl_bank_transcation.bank_idColumn];
                }
                set
                {
                    base[this.tabletbl_bank_transcation.bank_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint bank_transcation_id
            {
                get
                {
                    return (uint) base[this.tabletbl_bank_transcation.bank_transcation_idColumn];
                }
                set
                {
                    base[this.tabletbl_bank_transcation.bank_transcation_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string comments
            {
                get
                {
                    return (string) base[this.tabletbl_bank_transcation.commentsColumn];
                }
                set
                {
                    base[this.tabletbl_bank_transcation.commentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_bank_transcation.dateColumn];
                }
                set
                {
                    base[this.tabletbl_bank_transcation.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_bank_transcation.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_bank_transcation.descriptionColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_bank_transcationRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_bank_transcationRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_bank_transcationRowChangeEvent(teDataSet.tbl_bank_transcationRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_bank_transcationRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_bank_transcationRowChangeEventHandler(object sender, teDataSet.tbl_bank_transcationRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_cash_expencesDataTable : TypedTableBase<teDataSet.tbl_cash_expencesRow>
        {
            private DataColumn columnamount;
            private DataColumn columnbank_transcation_id;
            private DataColumn columncash_expences_id;
            private DataColumn columndate;
            private DataColumn columndescription;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_cash_expencesRowChangeEventHandler tbl_cash_expencesRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_cash_expencesRowChangeEventHandler tbl_cash_expencesRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_cash_expencesRowChangeEventHandler tbl_cash_expencesRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_cash_expencesRowChangeEventHandler tbl_cash_expencesRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_cash_expencesDataTable()
            {
                base.TableName = "tbl_cash_expences";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_cash_expencesDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_cash_expencesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_cash_expencesRow(teDataSet.tbl_cash_expencesRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_cash_expencesRow Addtbl_cash_expencesRow(uint cash_expences_id, DateTime date, double amount, uint bank_transcation_id, string description)
            {
                teDataSet.tbl_cash_expencesRow row = (teDataSet.tbl_cash_expencesRow) base.NewRow();
                row.ItemArray = new object[] { cash_expences_id, date, amount, bank_transcation_id, description };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_cash_expencesDataTable table = (teDataSet.tbl_cash_expencesDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_cash_expencesDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_cash_expencesRow FindBycash_expences_id(uint cash_expences_id)
            {
                return (teDataSet.tbl_cash_expencesRow) base.Rows.Find(new object[] { cash_expences_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_cash_expencesRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_cash_expencesDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columncash_expences_id = new DataColumn("cash_expences_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columncash_expences_id);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnamount = new DataColumn("amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columnbank_transcation_id = new DataColumn("bank_transcation_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnbank_transcation_id);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columncash_expences_id }, true));
                this.columncash_expences_id.AllowDBNull = false;
                this.columncash_expences_id.Unique = true;
                this.columndate.AllowDBNull = false;
                this.columnamount.AllowDBNull = false;
                this.columnbank_transcation_id.AllowDBNull = false;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columncash_expences_id = base.Columns["cash_expences_id"];
                this.columndate = base.Columns["date"];
                this.columnamount = base.Columns["amount"];
                this.columnbank_transcation_id = base.Columns["bank_transcation_id"];
                this.columndescription = base.Columns["description"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_cash_expencesRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_cash_expencesRow Newtbl_cash_expencesRow()
            {
                return (teDataSet.tbl_cash_expencesRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_cash_expencesRowChanged != null)
                {
                    this.tbl_cash_expencesRowChanged(this, new teDataSet.tbl_cash_expencesRowChangeEvent((teDataSet.tbl_cash_expencesRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_cash_expencesRowChanging != null)
                {
                    this.tbl_cash_expencesRowChanging(this, new teDataSet.tbl_cash_expencesRowChangeEvent((teDataSet.tbl_cash_expencesRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_cash_expencesRowDeleted != null)
                {
                    this.tbl_cash_expencesRowDeleted(this, new teDataSet.tbl_cash_expencesRowChangeEvent((teDataSet.tbl_cash_expencesRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_cash_expencesRowDeleting != null)
                {
                    this.tbl_cash_expencesRowDeleting(this, new teDataSet.tbl_cash_expencesRowChangeEvent((teDataSet.tbl_cash_expencesRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_cash_expencesRow(teDataSet.tbl_cash_expencesRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn bank_transcation_idColumn
            {
                get
                {
                    return this.columnbank_transcation_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn cash_expences_idColumn
            {
                get
                {
                    return this.columncash_expences_id;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_cash_expencesRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_cash_expencesRow) base.Rows[index];
                }
            }
        }

        public class tbl_cash_expencesRow : DataRow
        {
            private teDataSet.tbl_cash_expencesDataTable tabletbl_cash_expences;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_cash_expencesRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_cash_expences = (teDataSet.tbl_cash_expencesDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double amount
            {
                get
                {
                    return (double) base[this.tabletbl_cash_expences.amountColumn];
                }
                set
                {
                    base[this.tabletbl_cash_expences.amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint bank_transcation_id
            {
                get
                {
                    return (uint) base[this.tabletbl_cash_expences.bank_transcation_idColumn];
                }
                set
                {
                    base[this.tabletbl_cash_expences.bank_transcation_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint cash_expences_id
            {
                get
                {
                    return (uint) base[this.tabletbl_cash_expences.cash_expences_idColumn];
                }
                set
                {
                    base[this.tabletbl_cash_expences.cash_expences_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_cash_expences.dateColumn];
                }
                set
                {
                    base[this.tabletbl_cash_expences.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_cash_expences.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_cash_expences.descriptionColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_cash_expencesRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_cash_expencesRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_cash_expencesRowChangeEvent(teDataSet.tbl_cash_expencesRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_cash_expencesRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_cash_expencesRowChangeEventHandler(object sender, teDataSet.tbl_cash_expencesRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_customerDataTable : TypedTableBase<teDataSet.tbl_customerRow>
        {
            private DataColumn columnaddress;
            private DataColumn columncomments;
            private DataColumn columncontact;
            private DataColumn columncustomer_id;
            private DataColumn columnemail;
            private DataColumn columnfathers_name;
            private DataColumn columnname;
            private DataColumn columntype;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_customerRowChangeEventHandler tbl_customerRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_customerRowChangeEventHandler tbl_customerRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_customerRowChangeEventHandler tbl_customerRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_customerRowChangeEventHandler tbl_customerRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_customerDataTable()
            {
                base.TableName = "tbl_customer";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_customerDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_customerDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_customerRow(teDataSet.tbl_customerRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_customerRow Addtbl_customerRow(uint customer_id, string name, string address, string contact, string email, string comments, string fathers_name, string type)
            {
                teDataSet.tbl_customerRow row = (teDataSet.tbl_customerRow) base.NewRow();
                row.ItemArray = new object[] { customer_id, name, address, contact, email, comments, fathers_name, type };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_customerDataTable table = (teDataSet.tbl_customerDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_customerDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_customerRow FindBycustomer_id(uint customer_id)
            {
                return (teDataSet.tbl_customerRow) base.Rows.Find(new object[] { customer_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_customerRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_customerDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columncustomer_id = new DataColumn("customer_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columncustomer_id);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columnaddress = new DataColumn("address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnaddress);
                this.columncontact = new DataColumn("contact", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncontact);
                this.columnemail = new DataColumn("email", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnemail);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columnfathers_name = new DataColumn("fathers_name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnfathers_name);
                this.columntype = new DataColumn("type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntype);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columncustomer_id }, true));
                this.columncustomer_id.AllowDBNull = false;
                this.columncustomer_id.Unique = true;
                this.columnname.AllowDBNull = false;
                this.columnname.MaxLength = 0x2d;
                this.columnaddress.AllowDBNull = false;
                this.columnaddress.MaxLength = 100;
                this.columncontact.AllowDBNull = false;
                this.columncontact.MaxLength = 0x2d;
                this.columnemail.AllowDBNull = false;
                this.columnemail.MaxLength = 0x2d;
                this.columncomments.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
                this.columnfathers_name.AllowDBNull = false;
                this.columnfathers_name.MaxLength = 0x2d;
                this.columntype.AllowDBNull = false;
                this.columntype.MaxLength = 0x2d;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columncustomer_id = base.Columns["customer_id"];
                this.columnname = base.Columns["name"];
                this.columnaddress = base.Columns["address"];
                this.columncontact = base.Columns["contact"];
                this.columnemail = base.Columns["email"];
                this.columncomments = base.Columns["comments"];
                this.columnfathers_name = base.Columns["fathers_name"];
                this.columntype = base.Columns["type"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_customerRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_customerRow Newtbl_customerRow()
            {
                return (teDataSet.tbl_customerRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_customerRowChanged != null)
                {
                    this.tbl_customerRowChanged(this, new teDataSet.tbl_customerRowChangeEvent((teDataSet.tbl_customerRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_customerRowChanging != null)
                {
                    this.tbl_customerRowChanging(this, new teDataSet.tbl_customerRowChangeEvent((teDataSet.tbl_customerRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_customerRowDeleted != null)
                {
                    this.tbl_customerRowDeleted(this, new teDataSet.tbl_customerRowChangeEvent((teDataSet.tbl_customerRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_customerRowDeleting != null)
                {
                    this.tbl_customerRowDeleting(this, new teDataSet.tbl_customerRowChangeEvent((teDataSet.tbl_customerRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_customerRow(teDataSet.tbl_customerRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn addressColumn
            {
                get
                {
                    return this.columnaddress;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn contactColumn
            {
                get
                {
                    return this.columncontact;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn customer_idColumn
            {
                get
                {
                    return this.columncustomer_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn emailColumn
            {
                get
                {
                    return this.columnemail;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn fathers_nameColumn
            {
                get
                {
                    return this.columnfathers_name;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_customerRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_customerRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeColumn
            {
                get
                {
                    return this.columntype;
                }
            }
        }

        public class tbl_customerRow : DataRow
        {
            private teDataSet.tbl_customerDataTable tabletbl_customer;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_customerRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_customer = (teDataSet.tbl_customerDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string address
            {
                get
                {
                    return (string) base[this.tabletbl_customer.addressColumn];
                }
                set
                {
                    base[this.tabletbl_customer.addressColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    return (string) base[this.tabletbl_customer.commentsColumn];
                }
                set
                {
                    base[this.tabletbl_customer.commentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string contact
            {
                get
                {
                    return (string) base[this.tabletbl_customer.contactColumn];
                }
                set
                {
                    base[this.tabletbl_customer.contactColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint customer_id
            {
                get
                {
                    return (uint) base[this.tabletbl_customer.customer_idColumn];
                }
                set
                {
                    base[this.tabletbl_customer.customer_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string email
            {
                get
                {
                    return (string) base[this.tabletbl_customer.emailColumn];
                }
                set
                {
                    base[this.tabletbl_customer.emailColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string fathers_name
            {
                get
                {
                    return (string) base[this.tabletbl_customer.fathers_nameColumn];
                }
                set
                {
                    base[this.tabletbl_customer.fathers_nameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string name
            {
                get
                {
                    return (string) base[this.tabletbl_customer.nameColumn];
                }
                set
                {
                    base[this.tabletbl_customer.nameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string type
            {
                get
                {
                    return (string) base[this.tabletbl_customer.typeColumn];
                }
                set
                {
                    base[this.tabletbl_customer.typeColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_customerRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_customerRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_customerRowChangeEvent(teDataSet.tbl_customerRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_customerRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_customerRowChangeEventHandler(object sender, teDataSet.tbl_customerRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_employeeDataTable : TypedTableBase<teDataSet.tbl_employeeRow>
        {
            private DataColumn columnaddress;
            private DataColumn columncomments;
            private DataColumn columncontact;
            private DataColumn columnemployeeId;
            private DataColumn columnjoinDate;
            private DataColumn columnname;
            private DataColumn columnposition;
            private DataColumn columnsalary;
            private DataColumn columnstatus;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_employeeRowChangeEventHandler tbl_employeeRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_employeeRowChangeEventHandler tbl_employeeRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_employeeRowChangeEventHandler tbl_employeeRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_employeeRowChangeEventHandler tbl_employeeRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_employeeDataTable()
            {
                base.TableName = "tbl_employee";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_employeeDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_employeeDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_employeeRow(teDataSet.tbl_employeeRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_employeeRow Addtbl_employeeRow(uint employeeId, string name, string address, string contact, string comments, string position, uint salary, DateTime joinDate, string status)
            {
                teDataSet.tbl_employeeRow row = (teDataSet.tbl_employeeRow) base.NewRow();
                row.ItemArray = new object[] { employeeId, name, address, contact, comments, position, salary, joinDate, status };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_employeeDataTable table = (teDataSet.tbl_employeeDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_employeeDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_employeeRow FindByemployeeId(uint employeeId)
            {
                return (teDataSet.tbl_employeeRow) base.Rows.Find(new object[] { employeeId });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_employeeRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_employeeDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnemployeeId = new DataColumn("employeeId", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnemployeeId);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columnaddress = new DataColumn("address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnaddress);
                this.columncontact = new DataColumn("contact", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncontact);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columnposition = new DataColumn("position", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnposition);
                this.columnsalary = new DataColumn("salary", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnsalary);
                this.columnjoinDate = new DataColumn("joinDate", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnjoinDate);
                this.columnstatus = new DataColumn("status", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstatus);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnemployeeId }, true));
                this.columnemployeeId.AllowDBNull = false;
                this.columnemployeeId.Unique = true;
                this.columnname.AllowDBNull = false;
                this.columnname.MaxLength = 0x2d;
                this.columnaddress.AllowDBNull = false;
                this.columnaddress.MaxLength = 100;
                this.columncontact.AllowDBNull = false;
                this.columncontact.MaxLength = 0x2d;
                this.columncomments.MaxLength = 0x2d;
                this.columnposition.AllowDBNull = false;
                this.columnposition.MaxLength = 0x2d;
                this.columnsalary.AllowDBNull = false;
                this.columnjoinDate.AllowDBNull = false;
                this.columnstatus.AllowDBNull = false;
                this.columnstatus.MaxLength = 0x2d;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnemployeeId = base.Columns["employeeId"];
                this.columnname = base.Columns["name"];
                this.columnaddress = base.Columns["address"];
                this.columncontact = base.Columns["contact"];
                this.columncomments = base.Columns["comments"];
                this.columnposition = base.Columns["position"];
                this.columnsalary = base.Columns["salary"];
                this.columnjoinDate = base.Columns["joinDate"];
                this.columnstatus = base.Columns["status"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_employeeRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_employeeRow Newtbl_employeeRow()
            {
                return (teDataSet.tbl_employeeRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_employeeRowChanged != null)
                {
                    this.tbl_employeeRowChanged(this, new teDataSet.tbl_employeeRowChangeEvent((teDataSet.tbl_employeeRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_employeeRowChanging != null)
                {
                    this.tbl_employeeRowChanging(this, new teDataSet.tbl_employeeRowChangeEvent((teDataSet.tbl_employeeRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_employeeRowDeleted != null)
                {
                    this.tbl_employeeRowDeleted(this, new teDataSet.tbl_employeeRowChangeEvent((teDataSet.tbl_employeeRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_employeeRowDeleting != null)
                {
                    this.tbl_employeeRowDeleting(this, new teDataSet.tbl_employeeRowChangeEvent((teDataSet.tbl_employeeRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_employeeRow(teDataSet.tbl_employeeRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn addressColumn
            {
                get
                {
                    return this.columnaddress;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn contactColumn
            {
                get
                {
                    return this.columncontact;
                }
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn employeeIdColumn
            {
                get
                {
                    return this.columnemployeeId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_employeeRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_employeeRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn joinDateColumn
            {
                get
                {
                    return this.columnjoinDate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn positionColumn
            {
                get
                {
                    return this.columnposition;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn salaryColumn
            {
                get
                {
                    return this.columnsalary;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn statusColumn
            {
                get
                {
                    return this.columnstatus;
                }
            }
        }

        public class tbl_employeeRow : DataRow
        {
            private teDataSet.tbl_employeeDataTable tabletbl_employee;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_employeeRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_employee = (teDataSet.tbl_employeeDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscommentsNull()
            {
                return base.IsNull(this.tabletbl_employee.commentsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetcommentsNull()
            {
                base[this.tabletbl_employee.commentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string address
            {
                get
                {
                    return (string) base[this.tabletbl_employee.addressColumn];
                }
                set
                {
                    base[this.tabletbl_employee.addressColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_employee.commentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comments' in table 'tbl_employee' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_employee.commentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string contact
            {
                get
                {
                    return (string) base[this.tabletbl_employee.contactColumn];
                }
                set
                {
                    base[this.tabletbl_employee.contactColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint employeeId
            {
                get
                {
                    return (uint) base[this.tabletbl_employee.employeeIdColumn];
                }
                set
                {
                    base[this.tabletbl_employee.employeeIdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime joinDate
            {
                get
                {
                    return (DateTime) base[this.tabletbl_employee.joinDateColumn];
                }
                set
                {
                    base[this.tabletbl_employee.joinDateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string name
            {
                get
                {
                    return (string) base[this.tabletbl_employee.nameColumn];
                }
                set
                {
                    base[this.tabletbl_employee.nameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string position
            {
                get
                {
                    return (string) base[this.tabletbl_employee.positionColumn];
                }
                set
                {
                    base[this.tabletbl_employee.positionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint salary
            {
                get
                {
                    return (uint) base[this.tabletbl_employee.salaryColumn];
                }
                set
                {
                    base[this.tabletbl_employee.salaryColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string status
            {
                get
                {
                    return (string) base[this.tabletbl_employee.statusColumn];
                }
                set
                {
                    base[this.tabletbl_employee.statusColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_employeeRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_employeeRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_employeeRowChangeEvent(teDataSet.tbl_employeeRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_employeeRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_employeeRowChangeEventHandler(object sender, teDataSet.tbl_employeeRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_expencesDataTable : TypedTableBase<teDataSet.tbl_expencesRow>
        {
            private DataColumn columnamount;
            private DataColumn columndate;
            private DataColumn columndescription;
            private DataColumn columnexpences_id;
            private DataColumn columnname;
            private DataColumn columnuserId;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_expencesRowChangeEventHandler tbl_expencesRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_expencesRowChangeEventHandler tbl_expencesRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_expencesRowChangeEventHandler tbl_expencesRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_expencesRowChangeEventHandler tbl_expencesRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_expencesDataTable()
            {
                base.TableName = "tbl_expences";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_expencesDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_expencesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_expencesRow(teDataSet.tbl_expencesRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_expencesRow Addtbl_expencesRow(uint expences_id, string description, DateTime date, uint userId, uint amount, string name)
            {
                teDataSet.tbl_expencesRow row = (teDataSet.tbl_expencesRow) base.NewRow();
                row.ItemArray = new object[] { expences_id, description, date, userId, amount, name };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_expencesDataTable table = (teDataSet.tbl_expencesDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_expencesDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_expencesRow FindByexpences_id(uint expences_id)
            {
                return (teDataSet.tbl_expencesRow) base.Rows.Find(new object[] { expences_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_expencesRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_expencesDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnexpences_id = new DataColumn("expences_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnexpences_id);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnuserId = new DataColumn("userId", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuserId);
                this.columnamount = new DataColumn("amount", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnexpences_id }, true));
                this.columnexpences_id.AllowDBNull = false;
                this.columnexpences_id.Unique = true;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 200;
                this.columndate.AllowDBNull = false;
                this.columnuserId.AllowDBNull = false;
                this.columnamount.AllowDBNull = false;
                this.columnname.AllowDBNull = false;
                this.columnname.MaxLength = 100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnexpences_id = base.Columns["expences_id"];
                this.columndescription = base.Columns["description"];
                this.columndate = base.Columns["date"];
                this.columnuserId = base.Columns["userId"];
                this.columnamount = base.Columns["amount"];
                this.columnname = base.Columns["name"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_expencesRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_expencesRow Newtbl_expencesRow()
            {
                return (teDataSet.tbl_expencesRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_expencesRowChanged != null)
                {
                    this.tbl_expencesRowChanged(this, new teDataSet.tbl_expencesRowChangeEvent((teDataSet.tbl_expencesRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_expencesRowChanging != null)
                {
                    this.tbl_expencesRowChanging(this, new teDataSet.tbl_expencesRowChangeEvent((teDataSet.tbl_expencesRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_expencesRowDeleted != null)
                {
                    this.tbl_expencesRowDeleted(this, new teDataSet.tbl_expencesRowChangeEvent((teDataSet.tbl_expencesRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_expencesRowDeleting != null)
                {
                    this.tbl_expencesRowDeleting(this, new teDataSet.tbl_expencesRowChangeEvent((teDataSet.tbl_expencesRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_expencesRow(teDataSet.tbl_expencesRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn expences_idColumn
            {
                get
                {
                    return this.columnexpences_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_expencesRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_expencesRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn userIdColumn
            {
                get
                {
                    return this.columnuserId;
                }
            }
        }

        public class tbl_expencesRow : DataRow
        {
            private teDataSet.tbl_expencesDataTable tabletbl_expences;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_expencesRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_expences = (teDataSet.tbl_expencesDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint amount
            {
                get
                {
                    return (uint) base[this.tabletbl_expences.amountColumn];
                }
                set
                {
                    base[this.tabletbl_expences.amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_expences.dateColumn];
                }
                set
                {
                    base[this.tabletbl_expences.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_expences.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_expences.descriptionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint expences_id
            {
                get
                {
                    return (uint) base[this.tabletbl_expences.expences_idColumn];
                }
                set
                {
                    base[this.tabletbl_expences.expences_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string name
            {
                get
                {
                    return (string) base[this.tabletbl_expences.nameColumn];
                }
                set
                {
                    base[this.tabletbl_expences.nameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint userId
            {
                get
                {
                    return (uint) base[this.tabletbl_expences.userIdColumn];
                }
                set
                {
                    base[this.tabletbl_expences.userIdColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_expencesRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_expencesRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_expencesRowChangeEvent(teDataSet.tbl_expencesRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_expencesRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_expencesRowChangeEventHandler(object sender, teDataSet.tbl_expencesRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_loanDataTable : TypedTableBase<teDataSet.tbl_loanRow>
        {
            private DataColumn columnamount;
            private DataColumn columncomments;
            private DataColumn columndate;
            private DataColumn columndue;
            private DataColumn columnemployee_id;
            private DataColumn columnloan_id;
            private DataColumn columnmonthly_payment;
            private DataColumn columnpaid;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_loanRowChangeEventHandler tbl_loanRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_loanRowChangeEventHandler tbl_loanRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_loanRowChangeEventHandler tbl_loanRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_loanRowChangeEventHandler tbl_loanRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_loanDataTable()
            {
                base.TableName = "tbl_loan";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_loanDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_loanDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_loanRow(teDataSet.tbl_loanRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_loanRow Addtbl_loanRow(uint loan_id, uint employee_id, double amount, DateTime date, string comments, double paid, double due, double monthly_payment)
            {
                teDataSet.tbl_loanRow row = (teDataSet.tbl_loanRow) base.NewRow();
                row.ItemArray = new object[] { loan_id, employee_id, amount, date, comments, paid, due, monthly_payment };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_loanDataTable table = (teDataSet.tbl_loanDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_loanDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_loanRow FindByloan_id(uint loan_id)
            {
                return (teDataSet.tbl_loanRow) base.Rows.Find(new object[] { loan_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_loanRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_loanDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnloan_id = new DataColumn("loan_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnloan_id);
                this.columnemployee_id = new DataColumn("employee_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnemployee_id);
                this.columnamount = new DataColumn("amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columnpaid = new DataColumn("paid", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpaid);
                this.columndue = new DataColumn("due", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndue);
                this.columnmonthly_payment = new DataColumn("monthly_payment", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnmonthly_payment);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnloan_id }, true));
                this.columnloan_id.AllowDBNull = false;
                this.columnloan_id.Unique = true;
                this.columnemployee_id.AllowDBNull = false;
                this.columnamount.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
                this.columnpaid.AllowDBNull = false;
                this.columndue.AllowDBNull = false;
                this.columnmonthly_payment.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnloan_id = base.Columns["loan_id"];
                this.columnemployee_id = base.Columns["employee_id"];
                this.columnamount = base.Columns["amount"];
                this.columndate = base.Columns["date"];
                this.columncomments = base.Columns["comments"];
                this.columnpaid = base.Columns["paid"];
                this.columndue = base.Columns["due"];
                this.columnmonthly_payment = base.Columns["monthly_payment"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_loanRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_loanRow Newtbl_loanRow()
            {
                return (teDataSet.tbl_loanRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_loanRowChanged != null)
                {
                    this.tbl_loanRowChanged(this, new teDataSet.tbl_loanRowChangeEvent((teDataSet.tbl_loanRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_loanRowChanging != null)
                {
                    this.tbl_loanRowChanging(this, new teDataSet.tbl_loanRowChangeEvent((teDataSet.tbl_loanRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_loanRowDeleted != null)
                {
                    this.tbl_loanRowDeleted(this, new teDataSet.tbl_loanRowChangeEvent((teDataSet.tbl_loanRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_loanRowDeleting != null)
                {
                    this.tbl_loanRowDeleting(this, new teDataSet.tbl_loanRowChangeEvent((teDataSet.tbl_loanRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_loanRow(teDataSet.tbl_loanRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dueColumn
            {
                get
                {
                    return this.columndue;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn employee_idColumn
            {
                get
                {
                    return this.columnemployee_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_loanRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_loanRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn loan_idColumn
            {
                get
                {
                    return this.columnloan_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn monthly_paymentColumn
            {
                get
                {
                    return this.columnmonthly_payment;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn paidColumn
            {
                get
                {
                    return this.columnpaid;
                }
            }
        }

        public class tbl_loanRow : DataRow
        {
            private teDataSet.tbl_loanDataTable tabletbl_loan;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_loanRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_loan = (teDataSet.tbl_loanDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IscommentsNull()
            {
                return base.IsNull(this.tabletbl_loan.commentsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetcommentsNull()
            {
                base[this.tabletbl_loan.commentsColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double amount
            {
                get
                {
                    return (double) base[this.tabletbl_loan.amountColumn];
                }
                set
                {
                    base[this.tabletbl_loan.amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_loan.commentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comments' in table 'tbl_loan' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_loan.commentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_loan.dateColumn];
                }
                set
                {
                    base[this.tabletbl_loan.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double due
            {
                get
                {
                    return (double) base[this.tabletbl_loan.dueColumn];
                }
                set
                {
                    base[this.tabletbl_loan.dueColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint employee_id
            {
                get
                {
                    return (uint) base[this.tabletbl_loan.employee_idColumn];
                }
                set
                {
                    base[this.tabletbl_loan.employee_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint loan_id
            {
                get
                {
                    return (uint) base[this.tabletbl_loan.loan_idColumn];
                }
                set
                {
                    base[this.tabletbl_loan.loan_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double monthly_payment
            {
                get
                {
                    return (double) base[this.tabletbl_loan.monthly_paymentColumn];
                }
                set
                {
                    base[this.tabletbl_loan.monthly_paymentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double paid
            {
                get
                {
                    return (double) base[this.tabletbl_loan.paidColumn];
                }
                set
                {
                    base[this.tabletbl_loan.paidColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_loanRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_loanRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_loanRowChangeEvent(teDataSet.tbl_loanRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_loanRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_loanRowChangeEventHandler(object sender, teDataSet.tbl_loanRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_parts_infoDataTable : TypedTableBase<teDataSet.tbl_parts_infoRow>
        {
            private DataColumn columnbrand;
            private DataColumn columndate;
            private DataColumn columndescription;
            private DataColumn columndistributor_price;
            private DataColumn columnmodel;
            private DataColumn columnpartsId;
            private DataColumn columnpartsNo;
            private DataColumn columnpurchase_price;
            private DataColumn columnsale_price;
            private DataColumn columnwholesale_price;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_parts_infoRowChangeEventHandler tbl_parts_infoRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_parts_infoRowChangeEventHandler tbl_parts_infoRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_parts_infoRowChangeEventHandler tbl_parts_infoRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_parts_infoRowChangeEventHandler tbl_parts_infoRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_parts_infoDataTable()
            {
                base.TableName = "tbl_parts_info";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_parts_infoDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_parts_infoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_parts_infoRow(teDataSet.tbl_parts_infoRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_parts_infoRow Addtbl_parts_infoRow(uint partsId, string brand, string model, string partsNo, string description, double purchase_price, double sale_price, DateTime date, double wholesale_price, double distributor_price)
            {
                teDataSet.tbl_parts_infoRow row = (teDataSet.tbl_parts_infoRow) base.NewRow();
                row.ItemArray = new object[] { partsId, brand, model, partsNo, description, purchase_price, sale_price, date, wholesale_price, distributor_price };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_parts_infoDataTable table = (teDataSet.tbl_parts_infoDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_parts_infoDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_parts_infoRow FindBypartsId(uint partsId)
            {
                return (teDataSet.tbl_parts_infoRow) base.Rows.Find(new object[] { partsId });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_parts_infoRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_parts_infoDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnpartsId = new DataColumn("partsId", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnpartsId);
                this.columnbrand = new DataColumn("brand", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnbrand);
                this.columnmodel = new DataColumn("model", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmodel);
                this.columnpartsNo = new DataColumn("partsNo", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpartsNo);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columnpurchase_price = new DataColumn("purchase_price", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpurchase_price);
                this.columnsale_price = new DataColumn("sale_price", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnsale_price);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnwholesale_price = new DataColumn("wholesale_price", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnwholesale_price);
                this.columndistributor_price = new DataColumn("distributor_price", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndistributor_price);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnpartsId }, true));
                this.columnpartsId.AllowDBNull = false;
                this.columnpartsId.Unique = true;
                this.columnbrand.AllowDBNull = false;
                this.columnbrand.MaxLength = 0x2d;
                this.columnmodel.AllowDBNull = false;
                this.columnmodel.MaxLength = 0x2d;
                this.columnpartsNo.AllowDBNull = false;
                this.columnpartsNo.MaxLength = 0x2d;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 0x2d;
                this.columnpurchase_price.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columnwholesale_price.AllowDBNull = false;
                this.columndistributor_price.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnpartsId = base.Columns["partsId"];
                this.columnbrand = base.Columns["brand"];
                this.columnmodel = base.Columns["model"];
                this.columnpartsNo = base.Columns["partsNo"];
                this.columndescription = base.Columns["description"];
                this.columnpurchase_price = base.Columns["purchase_price"];
                this.columnsale_price = base.Columns["sale_price"];
                this.columndate = base.Columns["date"];
                this.columnwholesale_price = base.Columns["wholesale_price"];
                this.columndistributor_price = base.Columns["distributor_price"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_parts_infoRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_parts_infoRow Newtbl_parts_infoRow()
            {
                return (teDataSet.tbl_parts_infoRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_parts_infoRowChanged != null)
                {
                    this.tbl_parts_infoRowChanged(this, new teDataSet.tbl_parts_infoRowChangeEvent((teDataSet.tbl_parts_infoRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_parts_infoRowChanging != null)
                {
                    this.tbl_parts_infoRowChanging(this, new teDataSet.tbl_parts_infoRowChangeEvent((teDataSet.tbl_parts_infoRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_parts_infoRowDeleted != null)
                {
                    this.tbl_parts_infoRowDeleted(this, new teDataSet.tbl_parts_infoRowChangeEvent((teDataSet.tbl_parts_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_parts_infoRowDeleting != null)
                {
                    this.tbl_parts_infoRowDeleting(this, new teDataSet.tbl_parts_infoRowChangeEvent((teDataSet.tbl_parts_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_parts_infoRow(teDataSet.tbl_parts_infoRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn brandColumn
            {
                get
                {
                    return this.columnbrand;
                }
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn distributor_priceColumn
            {
                get
                {
                    return this.columndistributor_price;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_parts_infoRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_parts_infoRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn modelColumn
            {
                get
                {
                    return this.columnmodel;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn partsIdColumn
            {
                get
                {
                    return this.columnpartsId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn partsNoColumn
            {
                get
                {
                    return this.columnpartsNo;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn purchase_priceColumn
            {
                get
                {
                    return this.columnpurchase_price;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn sale_priceColumn
            {
                get
                {
                    return this.columnsale_price;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn wholesale_priceColumn
            {
                get
                {
                    return this.columnwholesale_price;
                }
            }
        }

        public class tbl_parts_infoRow : DataRow
        {
            private teDataSet.tbl_parts_infoDataTable tabletbl_parts_info;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_parts_infoRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_parts_info = (teDataSet.tbl_parts_infoDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Issale_priceNull()
            {
                return base.IsNull(this.tabletbl_parts_info.sale_priceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setsale_priceNull()
            {
                base[this.tabletbl_parts_info.sale_priceColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string brand
            {
                get
                {
                    return (string) base[this.tabletbl_parts_info.brandColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.brandColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_parts_info.dateColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_parts_info.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.descriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double distributor_price
            {
                get
                {
                    return (double) base[this.tabletbl_parts_info.distributor_priceColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.distributor_priceColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string model
            {
                get
                {
                    return (string) base[this.tabletbl_parts_info.modelColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.modelColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint partsId
            {
                get
                {
                    return (uint) base[this.tabletbl_parts_info.partsIdColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.partsIdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string partsNo
            {
                get
                {
                    return (string) base[this.tabletbl_parts_info.partsNoColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.partsNoColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double purchase_price
            {
                get
                {
                    return (double) base[this.tabletbl_parts_info.purchase_priceColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.purchase_priceColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double sale_price
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_parts_info.sale_priceColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'sale_price' in table 'tbl_parts_info' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_parts_info.sale_priceColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double wholesale_price
            {
                get
                {
                    return (double) base[this.tabletbl_parts_info.wholesale_priceColumn];
                }
                set
                {
                    base[this.tabletbl_parts_info.wholesale_priceColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_parts_infoRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_parts_infoRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_parts_infoRowChangeEvent(teDataSet.tbl_parts_infoRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_parts_infoRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_parts_infoRowChangeEventHandler(object sender, teDataSet.tbl_parts_infoRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_partsDataTable : TypedTableBase<teDataSet.tbl_partsRow>
        {
            private DataColumn columnid;
            private DataColumn columninvoice_no;
            private DataColumn columnmemo_no;
            private DataColumn columnpartsId;
            private DataColumn columnpurchase_rate;
            private DataColumn columnsale_rate;
            private DataColumn columnstatus;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partsRowChangeEventHandler tbl_partsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partsRowChangeEventHandler tbl_partsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partsRowChangeEventHandler tbl_partsRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partsRowChangeEventHandler tbl_partsRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_partsDataTable()
            {
                base.TableName = "tbl_parts";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_partsDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_partsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_partsRow(teDataSet.tbl_partsRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partsRow Addtbl_partsRow(uint id, string invoice_no, uint partsId, double purchase_rate, string status, double sale_rate, string memo_no)
            {
                teDataSet.tbl_partsRow row = (teDataSet.tbl_partsRow) base.NewRow();
                row.ItemArray = new object[] { id, invoice_no, partsId, purchase_rate, status, sale_rate, memo_no };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_partsDataTable table = (teDataSet.tbl_partsDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_partsDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partsRow FindByid(uint id)
            {
                return (teDataSet.tbl_partsRow) base.Rows.Find(new object[] { id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_partsRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_partsDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnid = new DataColumn("id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columninvoice_no = new DataColumn("invoice_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvoice_no);
                this.columnpartsId = new DataColumn("partsId", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnpartsId);
                this.columnpurchase_rate = new DataColumn("purchase_rate", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpurchase_rate);
                this.columnstatus = new DataColumn("status", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstatus);
                this.columnsale_rate = new DataColumn("sale_rate", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnsale_rate);
                this.columnmemo_no = new DataColumn("memo_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnid }, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columninvoice_no.MaxLength = 0x2d;
                this.columnpartsId.AllowDBNull = false;
                this.columnstatus.AllowDBNull = false;
                this.columnstatus.MaxLength = 0x2d;
                this.columnmemo_no.MaxLength = 0x2d;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnid = base.Columns["id"];
                this.columninvoice_no = base.Columns["invoice_no"];
                this.columnpartsId = base.Columns["partsId"];
                this.columnpurchase_rate = base.Columns["purchase_rate"];
                this.columnstatus = base.Columns["status"];
                this.columnsale_rate = base.Columns["sale_rate"];
                this.columnmemo_no = base.Columns["memo_no"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_partsRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partsRow Newtbl_partsRow()
            {
                return (teDataSet.tbl_partsRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_partsRowChanged != null)
                {
                    this.tbl_partsRowChanged(this, new teDataSet.tbl_partsRowChangeEvent((teDataSet.tbl_partsRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_partsRowChanging != null)
                {
                    this.tbl_partsRowChanging(this, new teDataSet.tbl_partsRowChangeEvent((teDataSet.tbl_partsRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_partsRowDeleted != null)
                {
                    this.tbl_partsRowDeleted(this, new teDataSet.tbl_partsRowChangeEvent((teDataSet.tbl_partsRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_partsRowDeleting != null)
                {
                    this.tbl_partsRowDeleting(this, new teDataSet.tbl_partsRowChangeEvent((teDataSet.tbl_partsRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_partsRow(teDataSet.tbl_partsRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn invoice_noColumn
            {
                get
                {
                    return this.columninvoice_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partsRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_partsRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn partsIdColumn
            {
                get
                {
                    return this.columnpartsId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn purchase_rateColumn
            {
                get
                {
                    return this.columnpurchase_rate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn sale_rateColumn
            {
                get
                {
                    return this.columnsale_rate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn statusColumn
            {
                get
                {
                    return this.columnstatus;
                }
            }
        }

        public class tbl_partsRow : DataRow
        {
            private teDataSet.tbl_partsDataTable tabletbl_parts;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_partsRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_parts = (teDataSet.tbl_partsDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Isinvoice_noNull()
            {
                return base.IsNull(this.tabletbl_parts.invoice_noColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Ismemo_noNull()
            {
                return base.IsNull(this.tabletbl_parts.memo_noColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Ispurchase_rateNull()
            {
                return base.IsNull(this.tabletbl_parts.purchase_rateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Issale_rateNull()
            {
                return base.IsNull(this.tabletbl_parts.sale_rateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setinvoice_noNull()
            {
                base[this.tabletbl_parts.invoice_noColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setmemo_noNull()
            {
                base[this.tabletbl_parts.memo_noColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setpurchase_rateNull()
            {
                base[this.tabletbl_parts.purchase_rateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setsale_rateNull()
            {
                base[this.tabletbl_parts.sale_rateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint id
            {
                get
                {
                    return (uint) base[this.tabletbl_parts.idColumn];
                }
                set
                {
                    base[this.tabletbl_parts.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string invoice_no
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_parts.invoice_noColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'invoice_no' in table 'tbl_parts' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_parts.invoice_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string memo_no
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_parts.memo_noColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'memo_no' in table 'tbl_parts' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_parts.memo_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint partsId
            {
                get
                {
                    return (uint) base[this.tabletbl_parts.partsIdColumn];
                }
                set
                {
                    base[this.tabletbl_parts.partsIdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double purchase_rate
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_parts.purchase_rateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'purchase_rate' in table 'tbl_parts' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_parts.purchase_rateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double sale_rate
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_parts.sale_rateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'sale_rate' in table 'tbl_parts' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_parts.sale_rateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string status
            {
                get
                {
                    return (string) base[this.tabletbl_parts.statusColumn];
                }
                set
                {
                    base[this.tabletbl_parts.statusColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_partsRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_partsRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_partsRowChangeEvent(teDataSet.tbl_partsRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partsRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_partsRowChangeEventHandler(object sender, teDataSet.tbl_partsRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_party_transcationDataTable : TypedTableBase<teDataSet.tbl_party_transcationRow>
        {
            private DataColumn columnamount;
            private DataColumn columndate;
            private DataColumn columndescription;
            private DataColumn columndetails;
            private DataColumn columninvoice_no;
            private DataColumn columnparty_id;
            private DataColumn columntranscation_id;
            private DataColumn columntype;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_party_transcationRowChangeEventHandler tbl_party_transcationRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_party_transcationRowChangeEventHandler tbl_party_transcationRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_party_transcationRowChangeEventHandler tbl_party_transcationRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_party_transcationRowChangeEventHandler tbl_party_transcationRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_party_transcationDataTable()
            {
                base.TableName = "tbl_party_transcation";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_party_transcationDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_party_transcationDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_party_transcationRow(teDataSet.tbl_party_transcationRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_party_transcationRow Addtbl_party_transcationRow(uint transcation_id, uint party_id, DateTime date, double amount, string description, string type, string details, string invoice_no)
            {
                teDataSet.tbl_party_transcationRow row = (teDataSet.tbl_party_transcationRow) base.NewRow();
                row.ItemArray = new object[] { transcation_id, party_id, date, amount, description, type, details, invoice_no };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_party_transcationDataTable table = (teDataSet.tbl_party_transcationDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_party_transcationDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_party_transcationRow FindBytranscation_id(uint transcation_id)
            {
                return (teDataSet.tbl_party_transcationRow) base.Rows.Find(new object[] { transcation_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_party_transcationRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_party_transcationDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columntranscation_id = new DataColumn("transcation_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columntranscation_id);
                this.columnparty_id = new DataColumn("party_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnparty_id);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnamount = new DataColumn("amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columntype = new DataColumn("type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntype);
                this.columndetails = new DataColumn("details", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndetails);
                this.columninvoice_no = new DataColumn("invoice_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvoice_no);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columntranscation_id }, true));
                this.columntranscation_id.AllowDBNull = false;
                this.columntranscation_id.Unique = true;
                this.columnparty_id.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columnamount.AllowDBNull = false;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 500;
                this.columntype.AllowDBNull = false;
                this.columntype.MaxLength = 100;
                this.columndetails.AllowDBNull = false;
                this.columndetails.MaxLength = 100;
                this.columninvoice_no.AllowDBNull = false;
                this.columninvoice_no.MaxLength = 0x2d;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columntranscation_id = base.Columns["transcation_id"];
                this.columnparty_id = base.Columns["party_id"];
                this.columndate = base.Columns["date"];
                this.columnamount = base.Columns["amount"];
                this.columndescription = base.Columns["description"];
                this.columntype = base.Columns["type"];
                this.columndetails = base.Columns["details"];
                this.columninvoice_no = base.Columns["invoice_no"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_party_transcationRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_party_transcationRow Newtbl_party_transcationRow()
            {
                return (teDataSet.tbl_party_transcationRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_party_transcationRowChanged != null)
                {
                    this.tbl_party_transcationRowChanged(this, new teDataSet.tbl_party_transcationRowChangeEvent((teDataSet.tbl_party_transcationRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_party_transcationRowChanging != null)
                {
                    this.tbl_party_transcationRowChanging(this, new teDataSet.tbl_party_transcationRowChangeEvent((teDataSet.tbl_party_transcationRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_party_transcationRowDeleted != null)
                {
                    this.tbl_party_transcationRowDeleted(this, new teDataSet.tbl_party_transcationRowChangeEvent((teDataSet.tbl_party_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_party_transcationRowDeleting != null)
                {
                    this.tbl_party_transcationRowDeleting(this, new teDataSet.tbl_party_transcationRowChangeEvent((teDataSet.tbl_party_transcationRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_party_transcationRow(teDataSet.tbl_party_transcationRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn detailsColumn
            {
                get
                {
                    return this.columndetails;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn invoice_noColumn
            {
                get
                {
                    return this.columninvoice_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_party_transcationRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_party_transcationRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn party_idColumn
            {
                get
                {
                    return this.columnparty_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn transcation_idColumn
            {
                get
                {
                    return this.columntranscation_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeColumn
            {
                get
                {
                    return this.columntype;
                }
            }
        }

        public class tbl_party_transcationRow : DataRow
        {
            private teDataSet.tbl_party_transcationDataTable tabletbl_party_transcation;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_party_transcationRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_party_transcation = (teDataSet.tbl_party_transcationDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double amount
            {
                get
                {
                    return (double) base[this.tabletbl_party_transcation.amountColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_party_transcation.dateColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_party_transcation.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.descriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string details
            {
                get
                {
                    return (string) base[this.tabletbl_party_transcation.detailsColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.detailsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string invoice_no
            {
                get
                {
                    return (string) base[this.tabletbl_party_transcation.invoice_noColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.invoice_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint party_id
            {
                get
                {
                    return (uint) base[this.tabletbl_party_transcation.party_idColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.party_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint transcation_id
            {
                get
                {
                    return (uint) base[this.tabletbl_party_transcation.transcation_idColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.transcation_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string type
            {
                get
                {
                    return (string) base[this.tabletbl_party_transcation.typeColumn];
                }
                set
                {
                    base[this.tabletbl_party_transcation.typeColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_party_transcationRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_party_transcationRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_party_transcationRowChangeEvent(teDataSet.tbl_party_transcationRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_party_transcationRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_party_transcationRowChangeEventHandler(object sender, teDataSet.tbl_party_transcationRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_partyDataTable : TypedTableBase<teDataSet.tbl_partyRow>
        {
            private DataColumn _columnE_Mail;
            private DataColumn columnAddress;
            private DataColumn columnComments;
            private DataColumn columnContact;
            private DataColumn columncustomer_id;
            private DataColumn columnName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partyRowChangeEventHandler tbl_partyRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partyRowChangeEventHandler tbl_partyRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partyRowChangeEventHandler tbl_partyRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_partyRowChangeEventHandler tbl_partyRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_partyDataTable()
            {
                base.TableName = "tbl_party";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_partyDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_partyDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_partyRow(teDataSet.tbl_partyRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_partyRow Addtbl_partyRow(uint customer_id, string Name, string Address, string Contact, string _E_Mail, string Comments)
            {
                teDataSet.tbl_partyRow row = (teDataSet.tbl_partyRow) base.NewRow();
                row.ItemArray = new object[] { customer_id, Name, Address, Contact, _E_Mail, Comments };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_partyDataTable table = (teDataSet.tbl_partyDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_partyDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partyRow FindBycustomer_id(uint customer_id)
            {
                return (teDataSet.tbl_partyRow) base.Rows.Find(new object[] { customer_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_partyRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_partyDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columncustomer_id = new DataColumn("customer_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columncustomer_id);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.columnContact = new DataColumn("Contact", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnContact);
                this._columnE_Mail = new DataColumn("E-Mail", typeof(string), null, MappingType.Element);
                this._columnE_Mail.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnE_Mail");
                this._columnE_Mail.ExtendedProperties.Add("Generator_UserColumnName", "E-Mail");
                base.Columns.Add(this._columnE_Mail);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columncustomer_id }, true));
                this.columncustomer_id.AllowDBNull = false;
                this.columncustomer_id.Unique = true;
                this.columnName.AllowDBNull = false;
                this.columnName.MaxLength = 0x2d;
                this.columnAddress.AllowDBNull = false;
                this.columnAddress.MaxLength = 100;
                this.columnContact.AllowDBNull = false;
                this.columnContact.MaxLength = 0x2d;
                this._columnE_Mail.AllowDBNull = false;
                this._columnE_Mail.MaxLength = 0x2d;
                this.columnComments.AllowDBNull = false;
                this.columnComments.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columncustomer_id = base.Columns["customer_id"];
                this.columnName = base.Columns["Name"];
                this.columnAddress = base.Columns["Address"];
                this.columnContact = base.Columns["Contact"];
                this._columnE_Mail = base.Columns["E-Mail"];
                this.columnComments = base.Columns["Comments"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_partyRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_partyRow Newtbl_partyRow()
            {
                return (teDataSet.tbl_partyRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_partyRowChanged != null)
                {
                    this.tbl_partyRowChanged(this, new teDataSet.tbl_partyRowChangeEvent((teDataSet.tbl_partyRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_partyRowChanging != null)
                {
                    this.tbl_partyRowChanging(this, new teDataSet.tbl_partyRowChangeEvent((teDataSet.tbl_partyRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_partyRowDeleted != null)
                {
                    this.tbl_partyRowDeleted(this, new teDataSet.tbl_partyRowChangeEvent((teDataSet.tbl_partyRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_partyRowDeleting != null)
                {
                    this.tbl_partyRowDeleting(this, new teDataSet.tbl_partyRowChangeEvent((teDataSet.tbl_partyRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_partyRow(teDataSet.tbl_partyRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn _E_MailColumn
            {
                get
                {
                    return this._columnE_Mail;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AddressColumn
            {
                get
                {
                    return this.columnAddress;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ContactColumn
            {
                get
                {
                    return this.columnContact;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn customer_idColumn
            {
                get
                {
                    return this.columncustomer_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partyRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_partyRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NameColumn
            {
                get
                {
                    return this.columnName;
                }
            }
        }

        public class tbl_partyRow : DataRow
        {
            private teDataSet.tbl_partyDataTable tabletbl_party;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_partyRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_party = (teDataSet.tbl_partyDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string _E_Mail
            {
                get
                {
                    return (string) base[this.tabletbl_party._E_MailColumn];
                }
                set
                {
                    base[this.tabletbl_party._E_MailColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Address
            {
                get
                {
                    return (string) base[this.tabletbl_party.AddressColumn];
                }
                set
                {
                    base[this.tabletbl_party.AddressColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comments
            {
                get
                {
                    return (string) base[this.tabletbl_party.CommentsColumn];
                }
                set
                {
                    base[this.tabletbl_party.CommentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Contact
            {
                get
                {
                    return (string) base[this.tabletbl_party.ContactColumn];
                }
                set
                {
                    base[this.tabletbl_party.ContactColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint customer_id
            {
                get
                {
                    return (uint) base[this.tabletbl_party.customer_idColumn];
                }
                set
                {
                    base[this.tabletbl_party.customer_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Name
            {
                get
                {
                    return (string) base[this.tabletbl_party.NameColumn];
                }
                set
                {
                    base[this.tabletbl_party.NameColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_partyRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_partyRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_partyRowChangeEvent(teDataSet.tbl_partyRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_partyRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_partyRowChangeEventHandler(object sender, teDataSet.tbl_partyRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_paymentDataTable : TypedTableBase<teDataSet.tbl_paymentRow>
        {
            private DataColumn columnamount;
            private DataColumn columncomments;
            private DataColumn columncustomer_id;
            private DataColumn columndate;
            private DataColumn columnmemo_no;
            private DataColumn columnpayment_id;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_paymentRowChangeEventHandler tbl_paymentRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_paymentRowChangeEventHandler tbl_paymentRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_paymentRowChangeEventHandler tbl_paymentRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_paymentRowChangeEventHandler tbl_paymentRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_paymentDataTable()
            {
                base.TableName = "tbl_payment";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_paymentDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_paymentDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_paymentRow(teDataSet.tbl_paymentRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_paymentRow Addtbl_paymentRow(uint payment_id, string memo_no, DateTime date, string customer_id, double amount, uint user_id, string comments)
            {
                teDataSet.tbl_paymentRow row = (teDataSet.tbl_paymentRow) base.NewRow();
                row.ItemArray = new object[] { payment_id, memo_no, date, customer_id, amount, user_id, comments };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_paymentDataTable table = (teDataSet.tbl_paymentDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_paymentDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_paymentRow FindBypayment_id(uint payment_id)
            {
                return (teDataSet.tbl_paymentRow) base.Rows.Find(new object[] { payment_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_paymentRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_paymentDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnpayment_id = new DataColumn("payment_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnpayment_id);
                this.columnmemo_no = new DataColumn("memo_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columncustomer_id = new DataColumn("customer_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncustomer_id);
                this.columnamount = new DataColumn("amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnamount);
                this.columnuser_id = new DataColumn("user_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnpayment_id }, true));
                this.columnpayment_id.AllowDBNull = false;
                this.columnpayment_id.Unique = true;
                this.columnmemo_no.AllowDBNull = false;
                this.columnmemo_no.MaxLength = 0x2d;
                this.columndate.AllowDBNull = false;
                this.columncustomer_id.AllowDBNull = false;
                this.columncustomer_id.MaxLength = 0x2d;
                this.columnamount.AllowDBNull = false;
                this.columnuser_id.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnpayment_id = base.Columns["payment_id"];
                this.columnmemo_no = base.Columns["memo_no"];
                this.columndate = base.Columns["date"];
                this.columncustomer_id = base.Columns["customer_id"];
                this.columnamount = base.Columns["amount"];
                this.columnuser_id = base.Columns["user_id"];
                this.columncomments = base.Columns["comments"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_paymentRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_paymentRow Newtbl_paymentRow()
            {
                return (teDataSet.tbl_paymentRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_paymentRowChanged != null)
                {
                    this.tbl_paymentRowChanged(this, new teDataSet.tbl_paymentRowChangeEvent((teDataSet.tbl_paymentRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_paymentRowChanging != null)
                {
                    this.tbl_paymentRowChanging(this, new teDataSet.tbl_paymentRowChangeEvent((teDataSet.tbl_paymentRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_paymentRowDeleted != null)
                {
                    this.tbl_paymentRowDeleted(this, new teDataSet.tbl_paymentRowChangeEvent((teDataSet.tbl_paymentRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_paymentRowDeleting != null)
                {
                    this.tbl_paymentRowDeleting(this, new teDataSet.tbl_paymentRowChangeEvent((teDataSet.tbl_paymentRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_paymentRow(teDataSet.tbl_paymentRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn amountColumn
            {
                get
                {
                    return this.columnamount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn customer_idColumn
            {
                get
                {
                    return this.columncustomer_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_paymentRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_paymentRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn payment_idColumn
            {
                get
                {
                    return this.columnpayment_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_paymentRow : DataRow
        {
            private teDataSet.tbl_paymentDataTable tabletbl_payment;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_paymentRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_payment = (teDataSet.tbl_paymentDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscommentsNull()
            {
                return base.IsNull(this.tabletbl_payment.commentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetcommentsNull()
            {
                base[this.tabletbl_payment.commentsColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double amount
            {
                get
                {
                    return (double) base[this.tabletbl_payment.amountColumn];
                }
                set
                {
                    base[this.tabletbl_payment.amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_payment.commentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comments' in table 'tbl_payment' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_payment.commentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string customer_id
            {
                get
                {
                    return (string) base[this.tabletbl_payment.customer_idColumn];
                }
                set
                {
                    base[this.tabletbl_payment.customer_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_payment.dateColumn];
                }
                set
                {
                    base[this.tabletbl_payment.dateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string memo_no
            {
                get
                {
                    return (string) base[this.tabletbl_payment.memo_noColumn];
                }
                set
                {
                    base[this.tabletbl_payment.memo_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint payment_id
            {
                get
                {
                    return (uint) base[this.tabletbl_payment.payment_idColumn];
                }
                set
                {
                    base[this.tabletbl_payment.payment_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint user_id
            {
                get
                {
                    return (uint) base[this.tabletbl_payment.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_payment.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_paymentRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_paymentRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_paymentRowChangeEvent(teDataSet.tbl_paymentRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_paymentRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_paymentRowChangeEventHandler(object sender, teDataSet.tbl_paymentRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_purchaseDataTable : TypedTableBase<teDataSet.tbl_purchaseRow>
        {
            private DataColumn columncarring_cost;
            private DataColumn columncomments;
            private DataColumn columndiscount;
            private DataColumn columnexclusive_discount;
            private DataColumn columngrand_total;
            private DataColumn columnid;
            private DataColumn columninvoice_no;
            private DataColumn columnnet_amount;
            private DataColumn columnparty_id;
            private DataColumn columnpurchase_date;
            private DataColumn columntype;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_purchaseRowChangeEventHandler tbl_purchaseRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_purchaseRowChangeEventHandler tbl_purchaseRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_purchaseRowChangeEventHandler tbl_purchaseRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_purchaseRowChangeEventHandler tbl_purchaseRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_purchaseDataTable()
            {
                base.TableName = "tbl_purchase";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_purchaseDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_purchaseDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_purchaseRow(teDataSet.tbl_purchaseRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_purchaseRow Addtbl_purchaseRow(uint id, string invoice_no, DateTime purchase_date, double grand_total, double carring_cost, double discount, double exclusive_discount, double net_amount, int user_id, int party_id, string comments, string type)
            {
                teDataSet.tbl_purchaseRow row = (teDataSet.tbl_purchaseRow) base.NewRow();
                row.ItemArray = new object[] { id, invoice_no, purchase_date, grand_total, carring_cost, discount, exclusive_discount, net_amount, user_id, party_id, comments, type };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_purchaseDataTable table = (teDataSet.tbl_purchaseDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_purchaseDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_purchaseRow FindByid(uint id)
            {
                return (teDataSet.tbl_purchaseRow) base.Rows.Find(new object[] { id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_purchaseRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_purchaseDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnid = new DataColumn("id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columninvoice_no = new DataColumn("invoice_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvoice_no);
                this.columnpurchase_date = new DataColumn("purchase_date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnpurchase_date);
                this.columngrand_total = new DataColumn("grand_total", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columngrand_total);
                this.columncarring_cost = new DataColumn("carring_cost", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columncarring_cost);
                this.columndiscount = new DataColumn("discount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndiscount);
                this.columnexclusive_discount = new DataColumn("exclusive_discount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnexclusive_discount);
                this.columnnet_amount = new DataColumn("net_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnet_amount);
                this.columnuser_id = new DataColumn("user_id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columnparty_id = new DataColumn("party_id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnparty_id);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columntype = new DataColumn("type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntype);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnid }, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columninvoice_no.AllowDBNull = false;
                this.columninvoice_no.MaxLength = 0x2d;
                this.columnpurchase_date.AllowDBNull = false;
                this.columngrand_total.AllowDBNull = false;
                this.columnnet_amount.AllowDBNull = false;
                this.columnuser_id.AllowDBNull = false;
                this.columnparty_id.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
                this.columntype.AllowDBNull = false;
                this.columntype.MaxLength = 0x2d;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnid = base.Columns["id"];
                this.columninvoice_no = base.Columns["invoice_no"];
                this.columnpurchase_date = base.Columns["purchase_date"];
                this.columngrand_total = base.Columns["grand_total"];
                this.columncarring_cost = base.Columns["carring_cost"];
                this.columndiscount = base.Columns["discount"];
                this.columnexclusive_discount = base.Columns["exclusive_discount"];
                this.columnnet_amount = base.Columns["net_amount"];
                this.columnuser_id = base.Columns["user_id"];
                this.columnparty_id = base.Columns["party_id"];
                this.columncomments = base.Columns["comments"];
                this.columntype = base.Columns["type"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_purchaseRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_purchaseRow Newtbl_purchaseRow()
            {
                return (teDataSet.tbl_purchaseRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_purchaseRowChanged != null)
                {
                    this.tbl_purchaseRowChanged(this, new teDataSet.tbl_purchaseRowChangeEvent((teDataSet.tbl_purchaseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_purchaseRowChanging != null)
                {
                    this.tbl_purchaseRowChanging(this, new teDataSet.tbl_purchaseRowChangeEvent((teDataSet.tbl_purchaseRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_purchaseRowDeleted != null)
                {
                    this.tbl_purchaseRowDeleted(this, new teDataSet.tbl_purchaseRowChangeEvent((teDataSet.tbl_purchaseRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_purchaseRowDeleting != null)
                {
                    this.tbl_purchaseRowDeleting(this, new teDataSet.tbl_purchaseRowChangeEvent((teDataSet.tbl_purchaseRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_purchaseRow(teDataSet.tbl_purchaseRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn carring_costColumn
            {
                get
                {
                    return this.columncarring_cost;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn discountColumn
            {
                get
                {
                    return this.columndiscount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn exclusive_discountColumn
            {
                get
                {
                    return this.columnexclusive_discount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn grand_totalColumn
            {
                get
                {
                    return this.columngrand_total;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn invoice_noColumn
            {
                get
                {
                    return this.columninvoice_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_purchaseRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_purchaseRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn net_amountColumn
            {
                get
                {
                    return this.columnnet_amount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn party_idColumn
            {
                get
                {
                    return this.columnparty_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn purchase_dateColumn
            {
                get
                {
                    return this.columnpurchase_date;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeColumn
            {
                get
                {
                    return this.columntype;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_purchaseRow : DataRow
        {
            private teDataSet.tbl_purchaseDataTable tabletbl_purchase;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_purchaseRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_purchase = (teDataSet.tbl_purchaseDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Iscarring_costNull()
            {
                return base.IsNull(this.tabletbl_purchase.carring_costColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscommentsNull()
            {
                return base.IsNull(this.tabletbl_purchase.commentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsdiscountNull()
            {
                return base.IsNull(this.tabletbl_purchase.discountColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Isexclusive_discountNull()
            {
                return base.IsNull(this.tabletbl_purchase.exclusive_discountColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setcarring_costNull()
            {
                base[this.tabletbl_purchase.carring_costColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetcommentsNull()
            {
                base[this.tabletbl_purchase.commentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdiscountNull()
            {
                base[this.tabletbl_purchase.discountColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setexclusive_discountNull()
            {
                base[this.tabletbl_purchase.exclusive_discountColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double carring_cost
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_purchase.carring_costColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'carring_cost' in table 'tbl_purchase' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_purchase.carring_costColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_purchase.commentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comments' in table 'tbl_purchase' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_purchase.commentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double discount
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_purchase.discountColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'discount' in table 'tbl_purchase' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_purchase.discountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double exclusive_discount
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_purchase.exclusive_discountColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'exclusive_discount' in table 'tbl_purchase' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_purchase.exclusive_discountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double grand_total
            {
                get
                {
                    return (double) base[this.tabletbl_purchase.grand_totalColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.grand_totalColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint id
            {
                get
                {
                    return (uint) base[this.tabletbl_purchase.idColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string invoice_no
            {
                get
                {
                    return (string) base[this.tabletbl_purchase.invoice_noColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.invoice_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double net_amount
            {
                get
                {
                    return (double) base[this.tabletbl_purchase.net_amountColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.net_amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int party_id
            {
                get
                {
                    return (int) base[this.tabletbl_purchase.party_idColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.party_idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime purchase_date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_purchase.purchase_dateColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.purchase_dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string type
            {
                get
                {
                    return (string) base[this.tabletbl_purchase.typeColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.typeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int user_id
            {
                get
                {
                    return (int) base[this.tabletbl_purchase.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_purchase.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_purchaseRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_purchaseRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_purchaseRowChangeEvent(teDataSet.tbl_purchaseRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_purchaseRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_purchaseRowChangeEventHandler(object sender, teDataSet.tbl_purchaseRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_salaryDataTable : TypedTableBase<teDataSet.tbl_salaryRow>
        {
            private DataColumn columnadvance;
            private DataColumn columndeduction;
            private DataColumn columnemployeeId;
            private DataColumn columnexpences_id;
            private DataColumn columnloan;
            private DataColumn columnmonth;
            private DataColumn columnnet_salary;
            private DataColumn columnpayment;
            private DataColumn columnsalary;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_salaryRowChangeEventHandler tbl_salaryRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_salaryRowChangeEventHandler tbl_salaryRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_salaryRowChangeEventHandler tbl_salaryRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_salaryRowChangeEventHandler tbl_salaryRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_salaryDataTable()
            {
                base.TableName = "tbl_salary";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_salaryDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_salaryDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_salaryRow(teDataSet.tbl_salaryRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_salaryRow Addtbl_salaryRow(uint employeeId, double salary, DateTime month, DateTime payment, double loan, double advance, double deduction, double net_salary, string expences_id)
            {
                teDataSet.tbl_salaryRow row = (teDataSet.tbl_salaryRow) base.NewRow();
                row.ItemArray = new object[] { employeeId, salary, month, payment, loan, advance, deduction, net_salary, expences_id };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_salaryDataTable table = (teDataSet.tbl_salaryDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_salaryDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_salaryRow FindByemployeeIdmonth(uint employeeId, DateTime month)
            {
                return (teDataSet.tbl_salaryRow) base.Rows.Find(new object[] { employeeId, month });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_salaryRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_salaryDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnemployeeId = new DataColumn("employeeId", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnemployeeId);
                this.columnsalary = new DataColumn("salary", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnsalary);
                this.columnmonth = new DataColumn("month", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnmonth);
                this.columnpayment = new DataColumn("payment", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnpayment);
                this.columnloan = new DataColumn("loan", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnloan);
                this.columnadvance = new DataColumn("advance", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnadvance);
                this.columndeduction = new DataColumn("deduction", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndeduction);
                this.columnnet_salary = new DataColumn("net_salary", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnet_salary);
                this.columnexpences_id = new DataColumn("expences_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnexpences_id);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnemployeeId, this.columnmonth }, true));
                this.columnemployeeId.AllowDBNull = false;
                this.columnsalary.AllowDBNull = false;
                this.columnmonth.AllowDBNull = false;
                this.columnpayment.AllowDBNull = false;
                this.columnloan.AllowDBNull = false;
                this.columnadvance.AllowDBNull = false;
                this.columndeduction.AllowDBNull = false;
                this.columnnet_salary.AllowDBNull = false;
                this.columnexpences_id.AllowDBNull = false;
                this.columnexpences_id.MaxLength = 0x2d;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnemployeeId = base.Columns["employeeId"];
                this.columnsalary = base.Columns["salary"];
                this.columnmonth = base.Columns["month"];
                this.columnpayment = base.Columns["payment"];
                this.columnloan = base.Columns["loan"];
                this.columnadvance = base.Columns["advance"];
                this.columndeduction = base.Columns["deduction"];
                this.columnnet_salary = base.Columns["net_salary"];
                this.columnexpences_id = base.Columns["expences_id"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_salaryRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_salaryRow Newtbl_salaryRow()
            {
                return (teDataSet.tbl_salaryRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_salaryRowChanged != null)
                {
                    this.tbl_salaryRowChanged(this, new teDataSet.tbl_salaryRowChangeEvent((teDataSet.tbl_salaryRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_salaryRowChanging != null)
                {
                    this.tbl_salaryRowChanging(this, new teDataSet.tbl_salaryRowChangeEvent((teDataSet.tbl_salaryRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_salaryRowDeleted != null)
                {
                    this.tbl_salaryRowDeleted(this, new teDataSet.tbl_salaryRowChangeEvent((teDataSet.tbl_salaryRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_salaryRowDeleting != null)
                {
                    this.tbl_salaryRowDeleting(this, new teDataSet.tbl_salaryRowChangeEvent((teDataSet.tbl_salaryRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_salaryRow(teDataSet.tbl_salaryRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn advanceColumn
            {
                get
                {
                    return this.columnadvance;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn deductionColumn
            {
                get
                {
                    return this.columndeduction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn employeeIdColumn
            {
                get
                {
                    return this.columnemployeeId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn expences_idColumn
            {
                get
                {
                    return this.columnexpences_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_salaryRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_salaryRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn loanColumn
            {
                get
                {
                    return this.columnloan;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn monthColumn
            {
                get
                {
                    return this.columnmonth;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn net_salaryColumn
            {
                get
                {
                    return this.columnnet_salary;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn paymentColumn
            {
                get
                {
                    return this.columnpayment;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn salaryColumn
            {
                get
                {
                    return this.columnsalary;
                }
            }
        }

        public class tbl_salaryRow : DataRow
        {
            private teDataSet.tbl_salaryDataTable tabletbl_salary;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_salaryRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_salary = (teDataSet.tbl_salaryDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double advance
            {
                get
                {
                    return (double) base[this.tabletbl_salary.advanceColumn];
                }
                set
                {
                    base[this.tabletbl_salary.advanceColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double deduction
            {
                get
                {
                    return (double) base[this.tabletbl_salary.deductionColumn];
                }
                set
                {
                    base[this.tabletbl_salary.deductionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint employeeId
            {
                get
                {
                    return (uint) base[this.tabletbl_salary.employeeIdColumn];
                }
                set
                {
                    base[this.tabletbl_salary.employeeIdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string expences_id
            {
                get
                {
                    return (string) base[this.tabletbl_salary.expences_idColumn];
                }
                set
                {
                    base[this.tabletbl_salary.expences_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double loan
            {
                get
                {
                    return (double) base[this.tabletbl_salary.loanColumn];
                }
                set
                {
                    base[this.tabletbl_salary.loanColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime month
            {
                get
                {
                    return (DateTime) base[this.tabletbl_salary.monthColumn];
                }
                set
                {
                    base[this.tabletbl_salary.monthColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double net_salary
            {
                get
                {
                    return (double) base[this.tabletbl_salary.net_salaryColumn];
                }
                set
                {
                    base[this.tabletbl_salary.net_salaryColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime payment
            {
                get
                {
                    return (DateTime) base[this.tabletbl_salary.paymentColumn];
                }
                set
                {
                    base[this.tabletbl_salary.paymentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double salary
            {
                get
                {
                    return (double) base[this.tabletbl_salary.salaryColumn];
                }
                set
                {
                    base[this.tabletbl_salary.salaryColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_salaryRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_salaryRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_salaryRowChangeEvent(teDataSet.tbl_salaryRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_salaryRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_salaryRowChangeEventHandler(object sender, teDataSet.tbl_salaryRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_sales_motorcycleDataTable : TypedTableBase<teDataSet.tbl_sales_motorcycleRow>
        {
            private DataColumn columncomments;
            private DataColumn columncustomer_id;
            private DataColumn columndate;
            private DataColumn columndiscount;
            private DataColumn columndue_amount;
            private DataColumn columngrand_total;
            private DataColumn columnmemo_no;
            private DataColumn columnnet_amount;
            private DataColumn columnpaid_amount;
            private DataColumn columntype;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_motorcycleRowChangeEventHandler tbl_sales_motorcycleRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_motorcycleRowChangeEventHandler tbl_sales_motorcycleRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_motorcycleRowChangeEventHandler tbl_sales_motorcycleRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_motorcycleRowChangeEventHandler tbl_sales_motorcycleRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_sales_motorcycleDataTable()
            {
                base.TableName = "tbl_sales_motorcycle";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_sales_motorcycleDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_sales_motorcycleDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_sales_motorcycleRow(teDataSet.tbl_sales_motorcycleRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_sales_motorcycleRow Addtbl_sales_motorcycleRow(uint memo_no, string date, double grand_total, double discount, double net_amount, uint user_id, string comments, uint customer_id, string type, double paid_amount, double due_amount)
            {
                teDataSet.tbl_sales_motorcycleRow row = (teDataSet.tbl_sales_motorcycleRow) base.NewRow();
                row.ItemArray = new object[] { memo_no, date, grand_total, discount, net_amount, user_id, comments, customer_id, type, paid_amount, due_amount };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_sales_motorcycleDataTable table = (teDataSet.tbl_sales_motorcycleDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_sales_motorcycleDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_sales_motorcycleRow FindBymemo_no(uint memo_no)
            {
                return (teDataSet.tbl_sales_motorcycleRow) base.Rows.Find(new object[] { memo_no });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_sales_motorcycleRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_sales_motorcycleDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnmemo_no = new DataColumn("memo_no", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                this.columndate = new DataColumn("date", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columngrand_total = new DataColumn("grand_total", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columngrand_total);
                this.columndiscount = new DataColumn("discount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndiscount);
                this.columnnet_amount = new DataColumn("net_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnet_amount);
                this.columnuser_id = new DataColumn("user_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columncustomer_id = new DataColumn("customer_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columncustomer_id);
                this.columntype = new DataColumn("type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntype);
                this.columnpaid_amount = new DataColumn("paid_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpaid_amount);
                this.columndue_amount = new DataColumn("due_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndue_amount);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnmemo_no }, true));
                this.columnmemo_no.AllowDBNull = false;
                this.columnmemo_no.Unique = true;
                this.columndate.AllowDBNull = false;
                this.columndate.MaxLength = 0x2d;
                this.columngrand_total.AllowDBNull = false;
                this.columndiscount.AllowDBNull = false;
                this.columnnet_amount.AllowDBNull = false;
                this.columnuser_id.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
                this.columncustomer_id.AllowDBNull = false;
                this.columntype.AllowDBNull = false;
                this.columntype.MaxLength = 0x2d;
                this.columnpaid_amount.AllowDBNull = false;
                this.columndue_amount.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnmemo_no = base.Columns["memo_no"];
                this.columndate = base.Columns["date"];
                this.columngrand_total = base.Columns["grand_total"];
                this.columndiscount = base.Columns["discount"];
                this.columnnet_amount = base.Columns["net_amount"];
                this.columnuser_id = base.Columns["user_id"];
                this.columncomments = base.Columns["comments"];
                this.columncustomer_id = base.Columns["customer_id"];
                this.columntype = base.Columns["type"];
                this.columnpaid_amount = base.Columns["paid_amount"];
                this.columndue_amount = base.Columns["due_amount"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_sales_motorcycleRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_motorcycleRow Newtbl_sales_motorcycleRow()
            {
                return (teDataSet.tbl_sales_motorcycleRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_sales_motorcycleRowChanged != null)
                {
                    this.tbl_sales_motorcycleRowChanged(this, new teDataSet.tbl_sales_motorcycleRowChangeEvent((teDataSet.tbl_sales_motorcycleRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_sales_motorcycleRowChanging != null)
                {
                    this.tbl_sales_motorcycleRowChanging(this, new teDataSet.tbl_sales_motorcycleRowChangeEvent((teDataSet.tbl_sales_motorcycleRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_sales_motorcycleRowDeleted != null)
                {
                    this.tbl_sales_motorcycleRowDeleted(this, new teDataSet.tbl_sales_motorcycleRowChangeEvent((teDataSet.tbl_sales_motorcycleRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_sales_motorcycleRowDeleting != null)
                {
                    this.tbl_sales_motorcycleRowDeleting(this, new teDataSet.tbl_sales_motorcycleRowChangeEvent((teDataSet.tbl_sales_motorcycleRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_sales_motorcycleRow(teDataSet.tbl_sales_motorcycleRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn customer_idColumn
            {
                get
                {
                    return this.columncustomer_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn discountColumn
            {
                get
                {
                    return this.columndiscount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn due_amountColumn
            {
                get
                {
                    return this.columndue_amount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn grand_totalColumn
            {
                get
                {
                    return this.columngrand_total;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_sales_motorcycleRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_sales_motorcycleRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn net_amountColumn
            {
                get
                {
                    return this.columnnet_amount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn paid_amountColumn
            {
                get
                {
                    return this.columnpaid_amount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeColumn
            {
                get
                {
                    return this.columntype;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_sales_motorcycleRow : DataRow
        {
            private teDataSet.tbl_sales_motorcycleDataTable tabletbl_sales_motorcycle;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_sales_motorcycleRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_sales_motorcycle = (teDataSet.tbl_sales_motorcycleDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IscommentsNull()
            {
                return base.IsNull(this.tabletbl_sales_motorcycle.commentsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetcommentsNull()
            {
                base[this.tabletbl_sales_motorcycle.commentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_sales_motorcycle.commentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'comments' in table 'tbl_sales_motorcycle' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.commentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint customer_id
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_motorcycle.customer_idColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.customer_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string date
            {
                get
                {
                    return (string) base[this.tabletbl_sales_motorcycle.dateColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double discount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_motorcycle.discountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.discountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double due_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_motorcycle.due_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.due_amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double grand_total
            {
                get
                {
                    return (double) base[this.tabletbl_sales_motorcycle.grand_totalColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.grand_totalColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint memo_no
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_motorcycle.memo_noColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.memo_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double net_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_motorcycle.net_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.net_amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double paid_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_motorcycle.paid_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.paid_amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string type
            {
                get
                {
                    return (string) base[this.tabletbl_sales_motorcycle.typeColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.typeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint user_id
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_motorcycle.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_sales_motorcycle.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_sales_motorcycleRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_sales_motorcycleRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_sales_motorcycleRowChangeEvent(teDataSet.tbl_sales_motorcycleRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_motorcycleRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_sales_motorcycleRowChangeEventHandler(object sender, teDataSet.tbl_sales_motorcycleRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_sales_partsDataTable : TypedTableBase<teDataSet.tbl_sales_partsRow>
        {
            private DataColumn columncomments;
            private DataColumn columncustomer_id;
            private DataColumn columndate;
            private DataColumn columndiscount;
            private DataColumn columndue_amount;
            private DataColumn columngrand_total;
            private DataColumn columnmemo_no;
            private DataColumn columnnet_amount;
            private DataColumn columnpaid_amount;
            private DataColumn columntype;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_partsRowChangeEventHandler tbl_sales_partsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_partsRowChangeEventHandler tbl_sales_partsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_partsRowChangeEventHandler tbl_sales_partsRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_partsRowChangeEventHandler tbl_sales_partsRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_sales_partsDataTable()
            {
                base.TableName = "tbl_sales_parts";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_sales_partsDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_sales_partsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_sales_partsRow(teDataSet.tbl_sales_partsRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_partsRow Addtbl_sales_partsRow(uint memo_no, DateTime date, double grand_total, double discount, double net_amount, string user_id, string comments, uint customer_id, string type, double paid_amount, double due_amount)
            {
                teDataSet.tbl_sales_partsRow row = (teDataSet.tbl_sales_partsRow) base.NewRow();
                row.ItemArray = new object[] { memo_no, date, grand_total, discount, net_amount, user_id, comments, customer_id, type, paid_amount, due_amount };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_sales_partsDataTable table = (teDataSet.tbl_sales_partsDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_sales_partsDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_partsRow FindBymemo_no(uint memo_no)
            {
                return (teDataSet.tbl_sales_partsRow) base.Rows.Find(new object[] { memo_no });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_sales_partsRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_sales_partsDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnmemo_no = new DataColumn("memo_no", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columngrand_total = new DataColumn("grand_total", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columngrand_total);
                this.columndiscount = new DataColumn("discount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndiscount);
                this.columnnet_amount = new DataColumn("net_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnet_amount);
                this.columnuser_id = new DataColumn("user_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columncustomer_id = new DataColumn("customer_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columncustomer_id);
                this.columntype = new DataColumn("type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntype);
                this.columnpaid_amount = new DataColumn("paid_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpaid_amount);
                this.columndue_amount = new DataColumn("due_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndue_amount);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnmemo_no }, true));
                this.columnmemo_no.AllowDBNull = false;
                this.columnmemo_no.Unique = true;
                this.columndate.AllowDBNull = false;
                this.columngrand_total.AllowDBNull = false;
                this.columndiscount.AllowDBNull = false;
                this.columnnet_amount.AllowDBNull = false;
                this.columnuser_id.AllowDBNull = false;
                this.columnuser_id.MaxLength = 0x2d;
                this.columncomments.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
                this.columncustomer_id.AllowDBNull = false;
                this.columntype.AllowDBNull = false;
                this.columntype.MaxLength = 0x2d;
                this.columnpaid_amount.AllowDBNull = false;
                this.columndue_amount.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnmemo_no = base.Columns["memo_no"];
                this.columndate = base.Columns["date"];
                this.columngrand_total = base.Columns["grand_total"];
                this.columndiscount = base.Columns["discount"];
                this.columnnet_amount = base.Columns["net_amount"];
                this.columnuser_id = base.Columns["user_id"];
                this.columncomments = base.Columns["comments"];
                this.columncustomer_id = base.Columns["customer_id"];
                this.columntype = base.Columns["type"];
                this.columnpaid_amount = base.Columns["paid_amount"];
                this.columndue_amount = base.Columns["due_amount"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_sales_partsRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_sales_partsRow Newtbl_sales_partsRow()
            {
                return (teDataSet.tbl_sales_partsRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_sales_partsRowChanged != null)
                {
                    this.tbl_sales_partsRowChanged(this, new teDataSet.tbl_sales_partsRowChangeEvent((teDataSet.tbl_sales_partsRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_sales_partsRowChanging != null)
                {
                    this.tbl_sales_partsRowChanging(this, new teDataSet.tbl_sales_partsRowChangeEvent((teDataSet.tbl_sales_partsRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_sales_partsRowDeleted != null)
                {
                    this.tbl_sales_partsRowDeleted(this, new teDataSet.tbl_sales_partsRowChangeEvent((teDataSet.tbl_sales_partsRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_sales_partsRowDeleting != null)
                {
                    this.tbl_sales_partsRowDeleting(this, new teDataSet.tbl_sales_partsRowChangeEvent((teDataSet.tbl_sales_partsRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_sales_partsRow(teDataSet.tbl_sales_partsRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn customer_idColumn
            {
                get
                {
                    return this.columncustomer_id;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn discountColumn
            {
                get
                {
                    return this.columndiscount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn due_amountColumn
            {
                get
                {
                    return this.columndue_amount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn grand_totalColumn
            {
                get
                {
                    return this.columngrand_total;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_partsRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_sales_partsRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn net_amountColumn
            {
                get
                {
                    return this.columnnet_amount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn paid_amountColumn
            {
                get
                {
                    return this.columnpaid_amount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeColumn
            {
                get
                {
                    return this.columntype;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_sales_partsRow : DataRow
        {
            private teDataSet.tbl_sales_partsDataTable tabletbl_sales_parts;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_sales_partsRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_sales_parts = (teDataSet.tbl_sales_partsDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string comments
            {
                get
                {
                    return (string) base[this.tabletbl_sales_parts.commentsColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.commentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint customer_id
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_parts.customer_idColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.customer_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_sales_parts.dateColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.dateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double discount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_parts.discountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.discountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double due_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_parts.due_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.due_amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double grand_total
            {
                get
                {
                    return (double) base[this.tabletbl_sales_parts.grand_totalColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.grand_totalColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint memo_no
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_parts.memo_noColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.memo_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double net_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_parts.net_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.net_amountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double paid_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_parts.paid_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.paid_amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string type
            {
                get
                {
                    return (string) base[this.tabletbl_sales_parts.typeColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.typeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string user_id
            {
                get
                {
                    return (string) base[this.tabletbl_sales_parts.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_sales_parts.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_sales_partsRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_sales_partsRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_sales_partsRowChangeEvent(teDataSet.tbl_sales_partsRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_partsRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_sales_partsRowChangeEventHandler(object sender, teDataSet.tbl_sales_partsRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_sales_serviceDataTable : TypedTableBase<teDataSet.tbl_sales_serviceRow>
        {
            private DataColumn columncomments;
            private DataColumn columncustomer_id;
            private DataColumn columndate;
            private DataColumn columndiscount;
            private DataColumn columndue_amount;
            private DataColumn columngrand_total;
            private DataColumn columnmemo_no;
            private DataColumn columnnet_amount;
            private DataColumn columnpaid_amount;
            private DataColumn columntype;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_serviceRowChangeEventHandler tbl_sales_serviceRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_serviceRowChangeEventHandler tbl_sales_serviceRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_serviceRowChangeEventHandler tbl_sales_serviceRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_sales_serviceRowChangeEventHandler tbl_sales_serviceRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_sales_serviceDataTable()
            {
                base.TableName = "tbl_sales_service";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_sales_serviceDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_sales_serviceDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_sales_serviceRow(teDataSet.tbl_sales_serviceRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_serviceRow Addtbl_sales_serviceRow(uint memo_no, DateTime date, double grand_total, double discount, double net_amount, uint user_id, string comments, uint customer_id, string type, double paid_amount, double due_amount)
            {
                teDataSet.tbl_sales_serviceRow row = (teDataSet.tbl_sales_serviceRow) base.NewRow();
                row.ItemArray = new object[] { memo_no, date, grand_total, discount, net_amount, user_id, comments, customer_id, type, paid_amount, due_amount };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_sales_serviceDataTable table = (teDataSet.tbl_sales_serviceDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_sales_serviceDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_sales_serviceRow FindBymemo_no(uint memo_no)
            {
                return (teDataSet.tbl_sales_serviceRow) base.Rows.Find(new object[] { memo_no });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_sales_serviceRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_sales_serviceDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnmemo_no = new DataColumn("memo_no", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columngrand_total = new DataColumn("grand_total", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columngrand_total);
                this.columndiscount = new DataColumn("discount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndiscount);
                this.columnnet_amount = new DataColumn("net_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnnet_amount);
                this.columnuser_id = new DataColumn("user_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columncomments = new DataColumn("comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncomments);
                this.columncustomer_id = new DataColumn("customer_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columncustomer_id);
                this.columntype = new DataColumn("type", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntype);
                this.columnpaid_amount = new DataColumn("paid_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpaid_amount);
                this.columndue_amount = new DataColumn("due_amount", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndue_amount);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnmemo_no }, true));
                this.columnmemo_no.AllowDBNull = false;
                this.columnmemo_no.Unique = true;
                this.columndate.AllowDBNull = false;
                this.columngrand_total.AllowDBNull = false;
                this.columndiscount.AllowDBNull = false;
                this.columnnet_amount.AllowDBNull = false;
                this.columnuser_id.AllowDBNull = false;
                this.columncomments.AllowDBNull = false;
                this.columncomments.MaxLength = 100;
                this.columncustomer_id.AllowDBNull = false;
                this.columntype.AllowDBNull = false;
                this.columntype.MaxLength = 0x2d;
                this.columnpaid_amount.AllowDBNull = false;
                this.columndue_amount.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnmemo_no = base.Columns["memo_no"];
                this.columndate = base.Columns["date"];
                this.columngrand_total = base.Columns["grand_total"];
                this.columndiscount = base.Columns["discount"];
                this.columnnet_amount = base.Columns["net_amount"];
                this.columnuser_id = base.Columns["user_id"];
                this.columncomments = base.Columns["comments"];
                this.columncustomer_id = base.Columns["customer_id"];
                this.columntype = base.Columns["type"];
                this.columnpaid_amount = base.Columns["paid_amount"];
                this.columndue_amount = base.Columns["due_amount"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_sales_serviceRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_serviceRow Newtbl_sales_serviceRow()
            {
                return (teDataSet.tbl_sales_serviceRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_sales_serviceRowChanged != null)
                {
                    this.tbl_sales_serviceRowChanged(this, new teDataSet.tbl_sales_serviceRowChangeEvent((teDataSet.tbl_sales_serviceRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_sales_serviceRowChanging != null)
                {
                    this.tbl_sales_serviceRowChanging(this, new teDataSet.tbl_sales_serviceRowChangeEvent((teDataSet.tbl_sales_serviceRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_sales_serviceRowDeleted != null)
                {
                    this.tbl_sales_serviceRowDeleted(this, new teDataSet.tbl_sales_serviceRowChangeEvent((teDataSet.tbl_sales_serviceRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_sales_serviceRowDeleting != null)
                {
                    this.tbl_sales_serviceRowDeleting(this, new teDataSet.tbl_sales_serviceRowChangeEvent((teDataSet.tbl_sales_serviceRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_sales_serviceRow(teDataSet.tbl_sales_serviceRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn commentsColumn
            {
                get
                {
                    return this.columncomments;
                }
            }

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn customer_idColumn
            {
                get
                {
                    return this.columncustomer_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn discountColumn
            {
                get
                {
                    return this.columndiscount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn due_amountColumn
            {
                get
                {
                    return this.columndue_amount;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn grand_totalColumn
            {
                get
                {
                    return this.columngrand_total;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_sales_serviceRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_sales_serviceRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn net_amountColumn
            {
                get
                {
                    return this.columnnet_amount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn paid_amountColumn
            {
                get
                {
                    return this.columnpaid_amount;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeColumn
            {
                get
                {
                    return this.columntype;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_sales_serviceRow : DataRow
        {
            private teDataSet.tbl_sales_serviceDataTable tabletbl_sales_service;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_sales_serviceRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_sales_service = (teDataSet.tbl_sales_serviceDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string comments
            {
                get
                {
                    return (string) base[this.tabletbl_sales_service.commentsColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.commentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint customer_id
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_service.customer_idColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.customer_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_sales_service.dateColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double discount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_service.discountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.discountColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double due_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_service.due_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.due_amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double grand_total
            {
                get
                {
                    return (double) base[this.tabletbl_sales_service.grand_totalColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.grand_totalColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint memo_no
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_service.memo_noColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.memo_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double net_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_service.net_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.net_amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double paid_amount
            {
                get
                {
                    return (double) base[this.tabletbl_sales_service.paid_amountColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.paid_amountColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string type
            {
                get
                {
                    return (string) base[this.tabletbl_sales_service.typeColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.typeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint user_id
            {
                get
                {
                    return (uint) base[this.tabletbl_sales_service.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_sales_service.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_sales_serviceRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_sales_serviceRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_sales_serviceRowChangeEvent(teDataSet.tbl_sales_serviceRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_sales_serviceRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_sales_serviceRowChangeEventHandler(object sender, teDataSet.tbl_sales_serviceRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_service_chargeDataTable : TypedTableBase<teDataSet.tbl_service_chargeRow>
        {
            private DataColumn columncharge;
            private DataColumn columndescription;
            private DataColumn columnname;
            private DataColumn columnservice_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_service_chargeRowChangeEventHandler tbl_service_chargeRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_service_chargeRowChangeEventHandler tbl_service_chargeRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_service_chargeRowChangeEventHandler tbl_service_chargeRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_service_chargeRowChangeEventHandler tbl_service_chargeRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_service_chargeDataTable()
            {
                base.TableName = "tbl_service_charge";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_service_chargeDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_service_chargeDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_service_chargeRow(teDataSet.tbl_service_chargeRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_service_chargeRow Addtbl_service_chargeRow(uint service_id, string name, string description, double charge)
            {
                teDataSet.tbl_service_chargeRow row = (teDataSet.tbl_service_chargeRow) base.NewRow();
                row.ItemArray = new object[] { service_id, name, description, charge };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_service_chargeDataTable table = (teDataSet.tbl_service_chargeDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_service_chargeDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_service_chargeRow FindByservice_id(uint service_id)
            {
                return (teDataSet.tbl_service_chargeRow) base.Rows.Find(new object[] { service_id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_service_chargeRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_service_chargeDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnservice_id = new DataColumn("service_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnservice_id);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columncharge = new DataColumn("charge", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columncharge);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnservice_id }, true));
                this.columnservice_id.AllowDBNull = false;
                this.columnservice_id.Unique = true;
                this.columnname.AllowDBNull = false;
                this.columnname.MaxLength = 0x2d;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 0x2d;
                this.columncharge.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnservice_id = base.Columns["service_id"];
                this.columnname = base.Columns["name"];
                this.columndescription = base.Columns["description"];
                this.columncharge = base.Columns["charge"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_service_chargeRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_service_chargeRow Newtbl_service_chargeRow()
            {
                return (teDataSet.tbl_service_chargeRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_service_chargeRowChanged != null)
                {
                    this.tbl_service_chargeRowChanged(this, new teDataSet.tbl_service_chargeRowChangeEvent((teDataSet.tbl_service_chargeRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_service_chargeRowChanging != null)
                {
                    this.tbl_service_chargeRowChanging(this, new teDataSet.tbl_service_chargeRowChangeEvent((teDataSet.tbl_service_chargeRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_service_chargeRowDeleted != null)
                {
                    this.tbl_service_chargeRowDeleted(this, new teDataSet.tbl_service_chargeRowChangeEvent((teDataSet.tbl_service_chargeRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_service_chargeRowDeleting != null)
                {
                    this.tbl_service_chargeRowDeleting(this, new teDataSet.tbl_service_chargeRowChangeEvent((teDataSet.tbl_service_chargeRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_service_chargeRow(teDataSet.tbl_service_chargeRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn chargeColumn
            {
                get
                {
                    return this.columncharge;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_service_chargeRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_service_chargeRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn service_idColumn
            {
                get
                {
                    return this.columnservice_id;
                }
            }
        }

        public class tbl_service_chargeRow : DataRow
        {
            private teDataSet.tbl_service_chargeDataTable tabletbl_service_charge;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_service_chargeRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_service_charge = (teDataSet.tbl_service_chargeDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double charge
            {
                get
                {
                    return (double) base[this.tabletbl_service_charge.chargeColumn];
                }
                set
                {
                    base[this.tabletbl_service_charge.chargeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_service_charge.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_service_charge.descriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string name
            {
                get
                {
                    return (string) base[this.tabletbl_service_charge.nameColumn];
                }
                set
                {
                    base[this.tabletbl_service_charge.nameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint service_id
            {
                get
                {
                    return (uint) base[this.tabletbl_service_charge.service_idColumn];
                }
                set
                {
                    base[this.tabletbl_service_charge.service_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_service_chargeRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_service_chargeRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_service_chargeRowChangeEvent(teDataSet.tbl_service_chargeRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_service_chargeRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_service_chargeRowChangeEventHandler(object sender, teDataSet.tbl_service_chargeRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_serviceDataTable : TypedTableBase<teDataSet.tbl_serviceRow>
        {
            private DataColumn columncharge;
            private DataColumn columnid;
            private DataColumn columnmemo_no;
            private DataColumn columnservice_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_serviceRowChangeEventHandler tbl_serviceRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_serviceRowChangeEventHandler tbl_serviceRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_serviceRowChangeEventHandler tbl_serviceRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_serviceRowChangeEventHandler tbl_serviceRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_serviceDataTable()
            {
                base.TableName = "tbl_service";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_serviceDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_serviceDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_serviceRow(teDataSet.tbl_serviceRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_serviceRow Addtbl_serviceRow(uint id, string service_id, uint memo_no, double charge)
            {
                teDataSet.tbl_serviceRow row = (teDataSet.tbl_serviceRow) base.NewRow();
                row.ItemArray = new object[] { id, service_id, memo_no, charge };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_serviceDataTable table = (teDataSet.tbl_serviceDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_serviceDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_serviceRow FindByid(uint id)
            {
                return (teDataSet.tbl_serviceRow) base.Rows.Find(new object[] { id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_serviceRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_serviceDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnid = new DataColumn("id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnservice_id = new DataColumn("service_id", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnservice_id);
                this.columnmemo_no = new DataColumn("memo_no", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                this.columncharge = new DataColumn("charge", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columncharge);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnid }, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnservice_id.AllowDBNull = false;
                this.columnservice_id.MaxLength = 50;
                this.columnmemo_no.AllowDBNull = false;
                this.columncharge.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnid = base.Columns["id"];
                this.columnservice_id = base.Columns["service_id"];
                this.columnmemo_no = base.Columns["memo_no"];
                this.columncharge = base.Columns["charge"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_serviceRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_serviceRow Newtbl_serviceRow()
            {
                return (teDataSet.tbl_serviceRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_serviceRowChanged != null)
                {
                    this.tbl_serviceRowChanged(this, new teDataSet.tbl_serviceRowChangeEvent((teDataSet.tbl_serviceRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_serviceRowChanging != null)
                {
                    this.tbl_serviceRowChanging(this, new teDataSet.tbl_serviceRowChangeEvent((teDataSet.tbl_serviceRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_serviceRowDeleted != null)
                {
                    this.tbl_serviceRowDeleted(this, new teDataSet.tbl_serviceRowChangeEvent((teDataSet.tbl_serviceRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_serviceRowDeleting != null)
                {
                    this.tbl_serviceRowDeleting(this, new teDataSet.tbl_serviceRowChangeEvent((teDataSet.tbl_serviceRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_serviceRow(teDataSet.tbl_serviceRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn chargeColumn
            {
                get
                {
                    return this.columncharge;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_serviceRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_serviceRow) base.Rows[index];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn service_idColumn
            {
                get
                {
                    return this.columnservice_id;
                }
            }
        }

        public class tbl_serviceRow : DataRow
        {
            private teDataSet.tbl_serviceDataTable tabletbl_service;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_serviceRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_service = (teDataSet.tbl_serviceDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double charge
            {
                get
                {
                    return (double) base[this.tabletbl_service.chargeColumn];
                }
                set
                {
                    base[this.tabletbl_service.chargeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint id
            {
                get
                {
                    return (uint) base[this.tabletbl_service.idColumn];
                }
                set
                {
                    base[this.tabletbl_service.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint memo_no
            {
                get
                {
                    return (uint) base[this.tabletbl_service.memo_noColumn];
                }
                set
                {
                    base[this.tabletbl_service.memo_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string service_id
            {
                get
                {
                    return (string) base[this.tabletbl_service.service_idColumn];
                }
                set
                {
                    base[this.tabletbl_service.service_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_serviceRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_serviceRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_serviceRowChangeEvent(teDataSet.tbl_serviceRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_serviceRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_serviceRowChangeEventHandler(object sender, teDataSet.tbl_serviceRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_transcationDataTable : TypedTableBase<teDataSet.tbl_transcationRow>
        {
            private DataColumn columnbank_deposite;
            private DataColumn columncredit;
            private DataColumn columndate;
            private DataColumn columndebit;
            private DataColumn columndescription;
            private DataColumn columnid;
            private DataColumn columninvoice_no;
            private DataColumn columnmemo_no;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_transcationRowChangeEventHandler tbl_transcationRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_transcationRowChangeEventHandler tbl_transcationRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_transcationRowChangeEventHandler tbl_transcationRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_transcationRowChangeEventHandler tbl_transcationRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_transcationDataTable()
            {
                base.TableName = "tbl_transcation";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_transcationDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tbl_transcationDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_transcationRow(teDataSet.tbl_transcationRow row)
            {
                base.Rows.Add(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_transcationRow Addtbl_transcationRow(uint id, string invoice_no, double credit, string memo_no, double debit, uint user_id, DateTime date, string description, sbyte bank_deposite)
            {
                teDataSet.tbl_transcationRow row = (teDataSet.tbl_transcationRow) base.NewRow();
                row.ItemArray = new object[] { id, invoice_no, credit, memo_no, debit, user_id, date, description, bank_deposite };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_transcationDataTable table = (teDataSet.tbl_transcationDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_transcationDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_transcationRow FindByid(uint id)
            {
                return (teDataSet.tbl_transcationRow) base.Rows.Find(new object[] { id });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_transcationRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_transcationDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnid = new DataColumn("id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columninvoice_no = new DataColumn("invoice_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvoice_no);
                this.columncredit = new DataColumn("credit", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columncredit);
                this.columnmemo_no = new DataColumn("memo_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                this.columndebit = new DataColumn("debit", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columndebit);
                this.columnuser_id = new DataColumn("user_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndescription);
                this.columnbank_deposite = new DataColumn("bank_deposite", typeof(sbyte), null, MappingType.Element);
                base.Columns.Add(this.columnbank_deposite);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnid }, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columninvoice_no.MaxLength = 0x2d;
                this.columnmemo_no.MaxLength = 0x2d;
                this.columnuser_id.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columndescription.AllowDBNull = false;
                this.columndescription.MaxLength = 0x2d;
                this.columnbank_deposite.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnid = base.Columns["id"];
                this.columninvoice_no = base.Columns["invoice_no"];
                this.columncredit = base.Columns["credit"];
                this.columnmemo_no = base.Columns["memo_no"];
                this.columndebit = base.Columns["debit"];
                this.columnuser_id = base.Columns["user_id"];
                this.columndate = base.Columns["date"];
                this.columndescription = base.Columns["description"];
                this.columnbank_deposite = base.Columns["bank_deposite"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_transcationRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_transcationRow Newtbl_transcationRow()
            {
                return (teDataSet.tbl_transcationRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_transcationRowChanged != null)
                {
                    this.tbl_transcationRowChanged(this, new teDataSet.tbl_transcationRowChangeEvent((teDataSet.tbl_transcationRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_transcationRowChanging != null)
                {
                    this.tbl_transcationRowChanging(this, new teDataSet.tbl_transcationRowChangeEvent((teDataSet.tbl_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_transcationRowDeleted != null)
                {
                    this.tbl_transcationRowDeleted(this, new teDataSet.tbl_transcationRowChangeEvent((teDataSet.tbl_transcationRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_transcationRowDeleting != null)
                {
                    this.tbl_transcationRowDeleting(this, new teDataSet.tbl_transcationRowChangeEvent((teDataSet.tbl_transcationRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_transcationRow(teDataSet.tbl_transcationRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn bank_depositeColumn
            {
                get
                {
                    return this.columnbank_deposite;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn creditColumn
            {
                get
                {
                    return this.columncredit;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn debitColumn
            {
                get
                {
                    return this.columndebit;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn descriptionColumn
            {
                get
                {
                    return this.columndescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn invoice_noColumn
            {
                get
                {
                    return this.columninvoice_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_transcationRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_transcationRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_transcationRow : DataRow
        {
            private teDataSet.tbl_transcationDataTable tabletbl_transcation;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_transcationRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_transcation = (teDataSet.tbl_transcationDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscreditNull()
            {
                return base.IsNull(this.tabletbl_transcation.creditColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsdebitNull()
            {
                return base.IsNull(this.tabletbl_transcation.debitColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Isinvoice_noNull()
            {
                return base.IsNull(this.tabletbl_transcation.invoice_noColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Ismemo_noNull()
            {
                return base.IsNull(this.tabletbl_transcation.memo_noColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetcreditNull()
            {
                base[this.tabletbl_transcation.creditColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdebitNull()
            {
                base[this.tabletbl_transcation.debitColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setinvoice_noNull()
            {
                base[this.tabletbl_transcation.invoice_noColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setmemo_noNull()
            {
                base[this.tabletbl_transcation.memo_noColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public sbyte bank_deposite
            {
                get
                {
                    return (sbyte) base[this.tabletbl_transcation.bank_depositeColumn];
                }
                set
                {
                    base[this.tabletbl_transcation.bank_depositeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double credit
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_transcation.creditColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'credit' in table 'tbl_transcation' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_transcation.creditColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_transcation.dateColumn];
                }
                set
                {
                    base[this.tabletbl_transcation.dateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double debit
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_transcation.debitColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'debit' in table 'tbl_transcation' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_transcation.debitColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string description
            {
                get
                {
                    return (string) base[this.tabletbl_transcation.descriptionColumn];
                }
                set
                {
                    base[this.tabletbl_transcation.descriptionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public uint id
            {
                get
                {
                    return (uint) base[this.tabletbl_transcation.idColumn];
                }
                set
                {
                    base[this.tabletbl_transcation.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string invoice_no
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_transcation.invoice_noColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'invoice_no' in table 'tbl_transcation' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_transcation.invoice_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string memo_no
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_transcation.memo_noColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'memo_no' in table 'tbl_transcation' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_transcation.memo_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint user_id
            {
                get
                {
                    return (uint) base[this.tabletbl_transcation.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_transcation.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_transcationRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_transcationRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_transcationRowChangeEvent(teDataSet.tbl_transcationRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_transcationRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_transcationRowChangeEventHandler(object sender, teDataSet.tbl_transcationRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_userDataTable : TypedTableBase<teDataSet.tbl_userRow>
        {
            private DataColumn columnaccess_level;
            private DataColumn columnname;
            private DataColumn columnpassword;
            private DataColumn columnstatus;
            private DataColumn columnuser_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_userRowChangeEventHandler tbl_userRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_userRowChangeEventHandler tbl_userRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_userRowChangeEventHandler tbl_userRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_userRowChangeEventHandler tbl_userRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_userDataTable()
            {
                base.TableName = "tbl_user";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_userDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_userDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Addtbl_userRow(teDataSet.tbl_userRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_userRow Addtbl_userRow(uint user_id, string name, string password, string status, string access_level)
            {
                teDataSet.tbl_userRow row = (teDataSet.tbl_userRow) base.NewRow();
                row.ItemArray = new object[] { user_id, name, password, status, access_level };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_userDataTable table = (teDataSet.tbl_userDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_userDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_userRow FindByuser_id(uint user_id)
            {
                return (teDataSet.tbl_userRow) base.Rows.Find(new object[] { user_id });
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_userRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_userDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void InitClass()
            {
                this.columnuser_id = new DataColumn("user_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columnpassword = new DataColumn("password", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnpassword);
                this.columnstatus = new DataColumn("status", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstatus);
                this.columnaccess_level = new DataColumn("access_level", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnaccess_level);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnuser_id }, true));
                this.columnuser_id.AllowDBNull = false;
                this.columnuser_id.Unique = true;
                this.columnname.AllowDBNull = false;
                this.columnname.MaxLength = 0x2d;
                this.columnpassword.AllowDBNull = false;
                this.columnpassword.MaxLength = 0x2d;
                this.columnstatus.AllowDBNull = false;
                this.columnstatus.MaxLength = 0x2d;
                this.columnaccess_level.AllowDBNull = false;
                this.columnaccess_level.MaxLength = 0x2d;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnuser_id = base.Columns["user_id"];
                this.columnname = base.Columns["name"];
                this.columnpassword = base.Columns["password"];
                this.columnstatus = base.Columns["status"];
                this.columnaccess_level = base.Columns["access_level"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_userRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_userRow Newtbl_userRow()
            {
                return (teDataSet.tbl_userRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_userRowChanged != null)
                {
                    this.tbl_userRowChanged(this, new teDataSet.tbl_userRowChangeEvent((teDataSet.tbl_userRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_userRowChanging != null)
                {
                    this.tbl_userRowChanging(this, new teDataSet.tbl_userRowChangeEvent((teDataSet.tbl_userRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_userRowDeleted != null)
                {
                    this.tbl_userRowDeleted(this, new teDataSet.tbl_userRowChangeEvent((teDataSet.tbl_userRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_userRowDeleting != null)
                {
                    this.tbl_userRowDeleting(this, new teDataSet.tbl_userRowChangeEvent((teDataSet.tbl_userRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_userRow(teDataSet.tbl_userRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn access_levelColumn
            {
                get
                {
                    return this.columnaccess_level;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_userRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_userRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn passwordColumn
            {
                get
                {
                    return this.columnpassword;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn statusColumn
            {
                get
                {
                    return this.columnstatus;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }
        }

        public class tbl_userRow : DataRow
        {
            private teDataSet.tbl_userDataTable tabletbl_user;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tbl_userRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_user = (teDataSet.tbl_userDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string access_level
            {
                get
                {
                    return (string) base[this.tabletbl_user.access_levelColumn];
                }
                set
                {
                    base[this.tabletbl_user.access_levelColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string name
            {
                get
                {
                    return (string) base[this.tabletbl_user.nameColumn];
                }
                set
                {
                    base[this.tabletbl_user.nameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string password
            {
                get
                {
                    return (string) base[this.tabletbl_user.passwordColumn];
                }
                set
                {
                    base[this.tabletbl_user.passwordColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string status
            {
                get
                {
                    return (string) base[this.tabletbl_user.statusColumn];
                }
                set
                {
                    base[this.tabletbl_user.statusColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint user_id
            {
                get
                {
                    return (uint) base[this.tabletbl_user.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_user.user_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_userRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_userRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_userRowChangeEvent(teDataSet.tbl_userRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_userRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_userRowChangeEventHandler(object sender, teDataSet.tbl_userRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_vehicle_infoDataTable : TypedTableBase<teDataSet.tbl_vehicle_infoRow>
        {
            private DataColumn columnbrand;
            private DataColumn columncc;
            private DataColumn columncolor;
            private DataColumn columndate;
            private DataColumn columnmodel;
            private DataColumn columnpurchase_price;
            private DataColumn columnsale_price;
            private DataColumn columnuser_id;
            private DataColumn columnvehicle_id;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicle_infoRowChangeEventHandler tbl_vehicle_infoRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicle_infoRowChangeEventHandler tbl_vehicle_infoRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicle_infoRowChangeEventHandler tbl_vehicle_infoRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicle_infoRowChangeEventHandler tbl_vehicle_infoRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_vehicle_infoDataTable()
            {
                base.TableName = "tbl_vehicle_info";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_vehicle_infoDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_vehicle_infoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_vehicle_infoRow(teDataSet.tbl_vehicle_infoRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_vehicle_infoRow Addtbl_vehicle_infoRow(uint vehicle_id, string brand, string model, string cc, string color, double purchase_price, double sale_price, DateTime date, uint user_id)
            {
                teDataSet.tbl_vehicle_infoRow row = (teDataSet.tbl_vehicle_infoRow) base.NewRow();
                row.ItemArray = new object[] { vehicle_id, brand, model, cc, color, purchase_price, sale_price, date, user_id };
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                teDataSet.tbl_vehicle_infoDataTable table = (teDataSet.tbl_vehicle_infoDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_vehicle_infoDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_vehicle_infoRow FindByvehicle_idbrandmodelcccolor(uint vehicle_id, string brand, string model, string cc, string color)
            {
                return (teDataSet.tbl_vehicle_infoRow) base.Rows.Find(new object[] { vehicle_id, brand, model, cc, color });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_vehicle_infoRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_vehicle_infoDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnvehicle_id = new DataColumn("vehicle_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnvehicle_id);
                this.columnbrand = new DataColumn("brand", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnbrand);
                this.columnmodel = new DataColumn("model", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmodel);
                this.columncc = new DataColumn("cc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncc);
                this.columncolor = new DataColumn("color", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncolor);
                this.columnpurchase_price = new DataColumn("purchase_price", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpurchase_price);
                this.columnsale_price = new DataColumn("sale_price", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnsale_price);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnuser_id = new DataColumn("user_id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnuser_id);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnvehicle_id, this.columnbrand, this.columnmodel, this.columncc, this.columncolor }, true));
                this.columnvehicle_id.AllowDBNull = false;
                this.columnbrand.AllowDBNull = false;
                this.columnbrand.MaxLength = 0x2d;
                this.columnmodel.AllowDBNull = false;
                this.columnmodel.MaxLength = 0x2d;
                this.columncc.AllowDBNull = false;
                this.columncc.MaxLength = 0x2d;
                this.columncolor.AllowDBNull = false;
                this.columncolor.MaxLength = 0x2d;
                this.columnpurchase_price.AllowDBNull = false;
                this.columnsale_price.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
                this.columnuser_id.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void InitVars()
            {
                this.columnvehicle_id = base.Columns["vehicle_id"];
                this.columnbrand = base.Columns["brand"];
                this.columnmodel = base.Columns["model"];
                this.columncc = base.Columns["cc"];
                this.columncolor = base.Columns["color"];
                this.columnpurchase_price = base.Columns["purchase_price"];
                this.columnsale_price = base.Columns["sale_price"];
                this.columndate = base.Columns["date"];
                this.columnuser_id = base.Columns["user_id"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_vehicle_infoRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_vehicle_infoRow Newtbl_vehicle_infoRow()
            {
                return (teDataSet.tbl_vehicle_infoRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_vehicle_infoRowChanged != null)
                {
                    this.tbl_vehicle_infoRowChanged(this, new teDataSet.tbl_vehicle_infoRowChangeEvent((teDataSet.tbl_vehicle_infoRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_vehicle_infoRowChanging != null)
                {
                    this.tbl_vehicle_infoRowChanging(this, new teDataSet.tbl_vehicle_infoRowChangeEvent((teDataSet.tbl_vehicle_infoRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_vehicle_infoRowDeleted != null)
                {
                    this.tbl_vehicle_infoRowDeleted(this, new teDataSet.tbl_vehicle_infoRowChangeEvent((teDataSet.tbl_vehicle_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_vehicle_infoRowDeleting != null)
                {
                    this.tbl_vehicle_infoRowDeleting(this, new teDataSet.tbl_vehicle_infoRowChangeEvent((teDataSet.tbl_vehicle_infoRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Removetbl_vehicle_infoRow(teDataSet.tbl_vehicle_infoRow row)
            {
                base.Rows.Remove(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn brandColumn
            {
                get
                {
                    return this.columnbrand;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ccColumn
            {
                get
                {
                    return this.columncc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn colorColumn
            {
                get
                {
                    return this.columncolor;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_vehicle_infoRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_vehicle_infoRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn modelColumn
            {
                get
                {
                    return this.columnmodel;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn purchase_priceColumn
            {
                get
                {
                    return this.columnpurchase_price;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn sale_priceColumn
            {
                get
                {
                    return this.columnsale_price;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn user_idColumn
            {
                get
                {
                    return this.columnuser_id;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn vehicle_idColumn
            {
                get
                {
                    return this.columnvehicle_id;
                }
            }
        }

        public class tbl_vehicle_infoRow : DataRow
        {
            private teDataSet.tbl_vehicle_infoDataTable tabletbl_vehicle_info;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_vehicle_infoRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_vehicle_info = (teDataSet.tbl_vehicle_infoDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string brand
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle_info.brandColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.brandColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string cc
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle_info.ccColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.ccColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string color
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle_info.colorColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.colorColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime date
            {
                get
                {
                    return (DateTime) base[this.tabletbl_vehicle_info.dateColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.dateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string model
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle_info.modelColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.modelColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double purchase_price
            {
                get
                {
                    return (double) base[this.tabletbl_vehicle_info.purchase_priceColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.purchase_priceColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double sale_price
            {
                get
                {
                    return (double) base[this.tabletbl_vehicle_info.sale_priceColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.sale_priceColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint user_id
            {
                get
                {
                    return (uint) base[this.tabletbl_vehicle_info.user_idColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.user_idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint vehicle_id
            {
                get
                {
                    return (uint) base[this.tabletbl_vehicle_info.vehicle_idColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle_info.vehicle_idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_vehicle_infoRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_vehicle_infoRow eventRow;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tbl_vehicle_infoRowChangeEvent(teDataSet.tbl_vehicle_infoRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_vehicle_infoRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_vehicle_infoRowChangeEventHandler(object sender, teDataSet.tbl_vehicle_infoRowChangeEvent e);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tbl_vehicleDataTable : TypedTableBase<teDataSet.tbl_vehicleRow>
        {
            private DataColumn columnchasis_no;
            private DataColumn columnengine_no;
            private DataColumn columnid;
            private DataColumn columninvoice_no;
            private DataColumn columnmemo_no;
            private DataColumn columnpurchase_rate;
            private DataColumn columnsale_rate;
            private DataColumn columnstatus;
            private DataColumn columnvehicleId;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicleRowChangeEventHandler tbl_vehicleRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicleRowChangeEventHandler tbl_vehicleRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicleRowChangeEventHandler tbl_vehicleRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event teDataSet.tbl_vehicleRowChangeEventHandler tbl_vehicleRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_vehicleDataTable()
            {
                base.TableName = "tbl_vehicle";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_vehicleDataTable(DataTable table)
            {
                base.TableName = table.TableName;
                if (table.CaseSensitive != table.DataSet.CaseSensitive)
                {
                    base.CaseSensitive = table.CaseSensitive;
                }
                if (table.Locale.ToString() != table.DataSet.Locale.ToString())
                {
                    base.Locale = table.Locale;
                }
                if (table.Namespace != table.DataSet.Namespace)
                {
                    base.Namespace = table.Namespace;
                }
                base.Prefix = table.Prefix;
                base.MinimumCapacity = table.MinimumCapacity;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tbl_vehicleDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.InitVars();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Addtbl_vehicleRow(teDataSet.tbl_vehicleRow row)
            {
                base.Rows.Add(row);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_vehicleRow Addtbl_vehicleRow(uint id, string invoice_no, uint vehicleId, string engine_no, string chasis_no, double purchase_rate, double sale_rate, string status, string memo_no)
            {
                teDataSet.tbl_vehicleRow row = (teDataSet.tbl_vehicleRow) base.NewRow();
                row.ItemArray = new object[] { id, invoice_no, vehicleId, engine_no, chasis_no, purchase_rate, sale_rate, status, memo_no };
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                teDataSet.tbl_vehicleDataTable table = (teDataSet.tbl_vehicleDataTable) base.Clone();
                table.InitVars();
                return table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new teDataSet.tbl_vehicleDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_vehicleRow FindByidvehicleIdengine_nochasis_no(uint id, uint vehicleId, string engine_no, string chasis_no)
            {
                return (teDataSet.tbl_vehicleRow) base.Rows.Find(new object[] { id, vehicleId, engine_no, chasis_no });
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(teDataSet.tbl_vehicleRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                teDataSet set = new teDataSet();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tbl_vehicleDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
                if (xs.Contains(schemaSerializable.TargetNamespace))
                {
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        XmlSchema current = null;
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            current = (XmlSchema) enumerator.Current;
                            stream2.SetLength(0L);
                            current.Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while ((stream.Position != stream.Length) && (stream.ReadByte() == stream2.ReadByte()))
                                {
                                }
                                if (stream.Position == stream.Length)
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                }
                xs.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnid = new DataColumn("id", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columninvoice_no = new DataColumn("invoice_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninvoice_no);
                this.columnvehicleId = new DataColumn("vehicleId", typeof(uint), null, MappingType.Element);
                base.Columns.Add(this.columnvehicleId);
                this.columnengine_no = new DataColumn("engine_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnengine_no);
                this.columnchasis_no = new DataColumn("chasis_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnchasis_no);
                this.columnpurchase_rate = new DataColumn("purchase_rate", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnpurchase_rate);
                this.columnsale_rate = new DataColumn("sale_rate", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnsale_rate);
                this.columnstatus = new DataColumn("status", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnstatus);
                this.columnmemo_no = new DataColumn("memo_no", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmemo_no);
                base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] { this.columnid, this.columnvehicleId, this.columnengine_no, this.columnchasis_no }, true));
                this.columnid.AllowDBNull = false;
                this.columninvoice_no.AllowDBNull = false;
                this.columninvoice_no.MaxLength = 0x2d;
                this.columnvehicleId.AllowDBNull = false;
                this.columnengine_no.AllowDBNull = false;
                this.columnengine_no.MaxLength = 0x2d;
                this.columnchasis_no.AllowDBNull = false;
                this.columnchasis_no.MaxLength = 0x2d;
                this.columnpurchase_rate.AllowDBNull = false;
                this.columnstatus.AllowDBNull = false;
                this.columnstatus.MaxLength = 0x2d;
                this.columnmemo_no.MaxLength = 0x2d;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnid = base.Columns["id"];
                this.columninvoice_no = base.Columns["invoice_no"];
                this.columnvehicleId = base.Columns["vehicleId"];
                this.columnengine_no = base.Columns["engine_no"];
                this.columnchasis_no = base.Columns["chasis_no"];
                this.columnpurchase_rate = base.Columns["purchase_rate"];
                this.columnsale_rate = base.Columns["sale_rate"];
                this.columnstatus = base.Columns["status"];
                this.columnmemo_no = base.Columns["memo_no"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new teDataSet.tbl_vehicleRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_vehicleRow Newtbl_vehicleRow()
            {
                return (teDataSet.tbl_vehicleRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if (this.tbl_vehicleRowChanged != null)
                {
                    this.tbl_vehicleRowChanged(this, new teDataSet.tbl_vehicleRowChangeEvent((teDataSet.tbl_vehicleRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if (this.tbl_vehicleRowChanging != null)
                {
                    this.tbl_vehicleRowChanging(this, new teDataSet.tbl_vehicleRowChangeEvent((teDataSet.tbl_vehicleRow) e.Row, e.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if (this.tbl_vehicleRowDeleted != null)
                {
                    this.tbl_vehicleRowDeleted(this, new teDataSet.tbl_vehicleRowChangeEvent((teDataSet.tbl_vehicleRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if (this.tbl_vehicleRowDeleting != null)
                {
                    this.tbl_vehicleRowDeleting(this, new teDataSet.tbl_vehicleRowChangeEvent((teDataSet.tbl_vehicleRow) e.Row, e.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Removetbl_vehicleRow(teDataSet.tbl_vehicleRow row)
            {
                base.Rows.Remove(row);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn chasis_noColumn
            {
                get
                {
                    return this.columnchasis_no;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn engine_noColumn
            {
                get
                {
                    return this.columnengine_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn invoice_noColumn
            {
                get
                {
                    return this.columninvoice_no;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public teDataSet.tbl_vehicleRow this[int index]
            {
                get
                {
                    return (teDataSet.tbl_vehicleRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn memo_noColumn
            {
                get
                {
                    return this.columnmemo_no;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn purchase_rateColumn
            {
                get
                {
                    return this.columnpurchase_rate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn sale_rateColumn
            {
                get
                {
                    return this.columnsale_rate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn statusColumn
            {
                get
                {
                    return this.columnstatus;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn vehicleIdColumn
            {
                get
                {
                    return this.columnvehicleId;
                }
            }
        }

        public class tbl_vehicleRow : DataRow
        {
            private teDataSet.tbl_vehicleDataTable tabletbl_vehicle;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tbl_vehicleRow(DataRowBuilder rb) : base(rb)
            {
                this.tabletbl_vehicle = (teDataSet.tbl_vehicleDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool Ismemo_noNull()
            {
                return base.IsNull(this.tabletbl_vehicle.memo_noColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Issale_rateNull()
            {
                return base.IsNull(this.tabletbl_vehicle.sale_rateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void Setmemo_noNull()
            {
                base[this.tabletbl_vehicle.memo_noColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void Setsale_rateNull()
            {
                base[this.tabletbl_vehicle.sale_rateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string chasis_no
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle.chasis_noColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.chasis_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string engine_no
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle.engine_noColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.engine_noColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint id
            {
                get
                {
                    return (uint) base[this.tabletbl_vehicle.idColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string invoice_no
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle.invoice_noColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.invoice_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string memo_no
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tabletbl_vehicle.memo_noColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'memo_no' in table 'tbl_vehicle' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tabletbl_vehicle.memo_noColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double purchase_rate
            {
                get
                {
                    return (double) base[this.tabletbl_vehicle.purchase_rateColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.purchase_rateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public double sale_rate
            {
                get
                {
                    double num;
                    try
                    {
                        num = (double) base[this.tabletbl_vehicle.sale_rateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'sale_rate' in table 'tbl_vehicle' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tabletbl_vehicle.sale_rateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string status
            {
                get
                {
                    return (string) base[this.tabletbl_vehicle.statusColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.statusColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public uint vehicleId
            {
                get
                {
                    return (uint) base[this.tabletbl_vehicle.vehicleIdColumn];
                }
                set
                {
                    base[this.tabletbl_vehicle.vehicleIdColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tbl_vehicleRowChangeEvent : EventArgs
        {
            private DataRowAction eventAction;
            private teDataSet.tbl_vehicleRow eventRow;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tbl_vehicleRowChangeEvent(teDataSet.tbl_vehicleRow row, DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public teDataSet.tbl_vehicleRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tbl_vehicleRowChangeEventHandler(object sender, teDataSet.tbl_vehicleRowChangeEvent e);
    }
}

