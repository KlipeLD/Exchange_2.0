﻿#pragma warning disable 1591

namespace Main {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("ExchangeDataSet1")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class ExchangeDataSet1 : global::System.Data.DataSet {
        
        private КассирDataTable tableКассир;
        
        private КлиентDataTable tableКлиент;
        
        private КурсDataTable tableКурс;
        
        private Список_операцийDataTable tableСписок_операций;
        
        private global::System.Data.DataRelation relationКассирСписок_операций;
        
        private global::System.Data.DataRelation relationКлиентСписок_операций;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ExchangeDataSet1() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected ExchangeDataSet1(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Кассир"] != null)) {
                    base.Tables.Add(new КассирDataTable(ds.Tables["Кассир"]));
                }
                if ((ds.Tables["Клиент"] != null)) {
                    base.Tables.Add(new КлиентDataTable(ds.Tables["Клиент"]));
                }
                if ((ds.Tables["Курс"] != null)) {
                    base.Tables.Add(new КурсDataTable(ds.Tables["Курс"]));
                }
                if ((ds.Tables["Список операций"] != null)) {
                    base.Tables.Add(new Список_операцийDataTable(ds.Tables["Список операций"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public КассирDataTable Кассир {
            get {
                return this.tableКассир;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public КлиентDataTable Клиент {
            get {
                return this.tableКлиент;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public КурсDataTable Курс {
            get {
                return this.tableКурс;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public Список_операцийDataTable Список_операций {
            get {
                return this.tableСписок_операций;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            ExchangeDataSet1 cln = ((ExchangeDataSet1)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Кассир"] != null)) {
                    base.Tables.Add(new КассирDataTable(ds.Tables["Кассир"]));
                }
                if ((ds.Tables["Клиент"] != null)) {
                    base.Tables.Add(new КлиентDataTable(ds.Tables["Клиент"]));
                }
                if ((ds.Tables["Курс"] != null)) {
                    base.Tables.Add(new КурсDataTable(ds.Tables["Курс"]));
                }
                if ((ds.Tables["Список операций"] != null)) {
                    base.Tables.Add(new Список_операцийDataTable(ds.Tables["Список операций"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableКассир = ((КассирDataTable)(base.Tables["Кассир"]));
            if ((initTable == true)) {
                if ((this.tableКассир != null)) {
                    this.tableКассир.InitVars();
                }
            }
            this.tableКлиент = ((КлиентDataTable)(base.Tables["Клиент"]));
            if ((initTable == true)) {
                if ((this.tableКлиент != null)) {
                    this.tableКлиент.InitVars();
                }
            }
            this.tableКурс = ((КурсDataTable)(base.Tables["Курс"]));
            if ((initTable == true)) {
                if ((this.tableКурс != null)) {
                    this.tableКурс.InitVars();
                }
            }
            this.tableСписок_операций = ((Список_операцийDataTable)(base.Tables["Список операций"]));
            if ((initTable == true)) {
                if ((this.tableСписок_операций != null)) {
                    this.tableСписок_операций.InitVars();
                }
            }
            this.relationКассирСписок_операций = this.Relations["КассирСписок операций"];
            this.relationКлиентСписок_операций = this.Relations["КлиентСписок операций"];
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "ExchangeDataSet1";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/ExchangeDataSet1.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableКассир = new КассирDataTable();
            base.Tables.Add(this.tableКассир);
            this.tableКлиент = new КлиентDataTable();
            base.Tables.Add(this.tableКлиент);
            this.tableКурс = new КурсDataTable();
            base.Tables.Add(this.tableКурс);
            this.tableСписок_операций = new Список_операцийDataTable();
            base.Tables.Add(this.tableСписок_операций);
            this.relationКассирСписок_операций = new global::System.Data.DataRelation("КассирСписок операций", new global::System.Data.DataColumn[] {
                        this.tableКассир.ФамилияColumn}, new global::System.Data.DataColumn[] {
                        this.tableСписок_операций.Фамилия_кассираColumn}, false);
            this.Relations.Add(this.relationКассирСписок_операций);
            this.relationКлиентСписок_операций = new global::System.Data.DataRelation("КлиентСписок операций", new global::System.Data.DataColumn[] {
                        this.tableКлиент.Номер_паспортаColumn}, new global::System.Data.DataColumn[] {
                        this.tableСписок_операций.Номер_паспортаColumn}, false);
            this.Relations.Add(this.relationКлиентСписок_операций);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeКассир() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeКлиент() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeКурс() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeСписок_операций() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            ExchangeDataSet1 ds = new ExchangeDataSet1();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void КассирRowChangeEventHandler(object sender, КассирRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void КлиентRowChangeEventHandler(object sender, КлиентRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void КурсRowChangeEventHandler(object sender, КурсRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Список_операцийRowChangeEventHandler(object sender, Список_операцийRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class КассирDataTable : global::System.Data.TypedTableBase<КассирRow> {
            
            private global::System.Data.DataColumn columnКод;
            
            private global::System.Data.DataColumn columnФамилия;
            
            private global::System.Data.DataColumn columnИмя;
            
            private global::System.Data.DataColumn columnОтчество;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирDataTable() {
                this.TableName = "Кассир";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal КассирDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected КассирDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn КодColumn {
                get {
                    return this.columnКод;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ФамилияColumn {
                get {
                    return this.columnФамилия;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ИмяColumn {
                get {
                    return this.columnИмя;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ОтчествоColumn {
                get {
                    return this.columnОтчество;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRow this[int index] {
                get {
                    return ((КассирRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КассирRowChangeEventHandler КассирRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КассирRowChangeEventHandler КассирRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КассирRowChangeEventHandler КассирRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КассирRowChangeEventHandler КассирRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddКассирRow(КассирRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRow AddКассирRow(string Фамилия, string Имя, string Отчество) {
                КассирRow rowКассирRow = ((КассирRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Фамилия,
                        Имя,
                        Отчество};
                rowКассирRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowКассирRow);
                return rowКассирRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRow FindByФамилия(string Фамилия) {
                return ((КассирRow)(this.Rows.Find(new object[] {
                            Фамилия})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                КассирDataTable cln = ((КассирDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new КассирDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnКод = base.Columns["Код"];
                this.columnФамилия = base.Columns["Фамилия"];
                this.columnИмя = base.Columns["Имя"];
                this.columnОтчество = base.Columns["Отчество"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnКод = new global::System.Data.DataColumn("Код", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод);
                this.columnФамилия = new global::System.Data.DataColumn("Фамилия", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnФамилия);
                this.columnИмя = new global::System.Data.DataColumn("Имя", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnИмя);
                this.columnОтчество = new global::System.Data.DataColumn("Отчество", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnОтчество);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnФамилия}, true));
                this.columnКод.AutoIncrement = true;
                this.columnКод.AutoIncrementSeed = -1;
                this.columnКод.AutoIncrementStep = -1;
                this.columnФамилия.AllowDBNull = false;
                this.columnФамилия.Unique = true;
                this.columnФамилия.MaxLength = 255;
                this.columnИмя.MaxLength = 255;
                this.columnОтчество.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRow NewКассирRow() {
                return ((КассирRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new КассирRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(КассирRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.КассирRowChanged != null)) {
                    this.КассирRowChanged(this, new КассирRowChangeEvent(((КассирRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.КассирRowChanging != null)) {
                    this.КассирRowChanging(this, new КассирRowChangeEvent(((КассирRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.КассирRowDeleted != null)) {
                    this.КассирRowDeleted(this, new КассирRowChangeEvent(((КассирRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.КассирRowDeleting != null)) {
                    this.КассирRowDeleting(this, new КассирRowChangeEvent(((КассирRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveКассирRow(КассирRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                ExchangeDataSet1 ds = new ExchangeDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "КассирDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class КлиентDataTable : global::System.Data.TypedTableBase<КлиентRow> {
            
            private global::System.Data.DataColumn columnКод;
            
            private global::System.Data.DataColumn columnФамилия;
            
            private global::System.Data.DataColumn columnИмя;
            
            private global::System.Data.DataColumn columnОтчество;
            
            private global::System.Data.DataColumn columnСумма_покупки;
            
            private global::System.Data.DataColumn columnСумма_продажи;
            
            private global::System.Data.DataColumn columnНомер_паспорта;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентDataTable() {
                this.TableName = "Клиент";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal КлиентDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected КлиентDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn КодColumn {
                get {
                    return this.columnКод;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ФамилияColumn {
                get {
                    return this.columnФамилия;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ИмяColumn {
                get {
                    return this.columnИмя;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ОтчествоColumn {
                get {
                    return this.columnОтчество;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Сумма_покупкиColumn {
                get {
                    return this.columnСумма_покупки;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Сумма_продажиColumn {
                get {
                    return this.columnСумма_продажи;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Номер_паспортаColumn {
                get {
                    return this.columnНомер_паспорта;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRow this[int index] {
                get {
                    return ((КлиентRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КлиентRowChangeEventHandler КлиентRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КлиентRowChangeEventHandler КлиентRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КлиентRowChangeEventHandler КлиентRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КлиентRowChangeEventHandler КлиентRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddКлиентRow(КлиентRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRow AddКлиентRow(string Фамилия, string Имя, string Отчество, int Сумма_покупки, int Сумма_продажи, string Номер_паспорта) {
                КлиентRow rowКлиентRow = ((КлиентRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Фамилия,
                        Имя,
                        Отчество,
                        Сумма_покупки,
                        Сумма_продажи,
                        Номер_паспорта};
                rowКлиентRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowКлиентRow);
                return rowКлиентRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRow FindByНомер_паспорта(string Номер_паспорта) {
                return ((КлиентRow)(this.Rows.Find(new object[] {
                            Номер_паспорта})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                КлиентDataTable cln = ((КлиентDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new КлиентDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnКод = base.Columns["Код"];
                this.columnФамилия = base.Columns["Фамилия"];
                this.columnИмя = base.Columns["Имя"];
                this.columnОтчество = base.Columns["Отчество"];
                this.columnСумма_покупки = base.Columns["Сумма покупки"];
                this.columnСумма_продажи = base.Columns["Сумма продажи"];
                this.columnНомер_паспорта = base.Columns["Номер паспорта"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnКод = new global::System.Data.DataColumn("Код", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод);
                this.columnФамилия = new global::System.Data.DataColumn("Фамилия", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnФамилия);
                this.columnИмя = new global::System.Data.DataColumn("Имя", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnИмя);
                this.columnОтчество = new global::System.Data.DataColumn("Отчество", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnОтчество);
                this.columnСумма_покупки = new global::System.Data.DataColumn("Сумма покупки", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСумма_покупки);
                this.columnСумма_продажи = new global::System.Data.DataColumn("Сумма продажи", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСумма_продажи);
                this.columnНомер_паспорта = new global::System.Data.DataColumn("Номер паспорта", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНомер_паспорта);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnНомер_паспорта}, true));
                this.columnКод.AutoIncrement = true;
                this.columnКод.AutoIncrementSeed = -1;
                this.columnКод.AutoIncrementStep = -1;
                this.columnФамилия.MaxLength = 255;
                this.columnИмя.MaxLength = 255;
                this.columnОтчество.MaxLength = 255;
                this.columnНомер_паспорта.AllowDBNull = false;
                this.columnНомер_паспорта.Unique = true;
                this.columnНомер_паспорта.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRow NewКлиентRow() {
                return ((КлиентRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new КлиентRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(КлиентRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.КлиентRowChanged != null)) {
                    this.КлиентRowChanged(this, new КлиентRowChangeEvent(((КлиентRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.КлиентRowChanging != null)) {
                    this.КлиентRowChanging(this, new КлиентRowChangeEvent(((КлиентRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.КлиентRowDeleted != null)) {
                    this.КлиентRowDeleted(this, new КлиентRowChangeEvent(((КлиентRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.КлиентRowDeleting != null)) {
                    this.КлиентRowDeleting(this, new КлиентRowChangeEvent(((КлиентRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveКлиентRow(КлиентRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                ExchangeDataSet1 ds = new ExchangeDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "КлиентDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class КурсDataTable : global::System.Data.TypedTableBase<КурсRow> {
            
            private global::System.Data.DataColumn columnКод;
            
            private global::System.Data.DataColumn columnНазвание_валюты;
            
            private global::System.Data.DataColumn columnПродажа;
            
            private global::System.Data.DataColumn columnПокупка;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсDataTable() {
                this.TableName = "Курс";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal КурсDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected КурсDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn КодColumn {
                get {
                    return this.columnКод;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Название_валютыColumn {
                get {
                    return this.columnНазвание_валюты;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ПродажаColumn {
                get {
                    return this.columnПродажа;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ПокупкаColumn {
                get {
                    return this.columnПокупка;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсRow this[int index] {
                get {
                    return ((КурсRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КурсRowChangeEventHandler КурсRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КурсRowChangeEventHandler КурсRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КурсRowChangeEventHandler КурсRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event КурсRowChangeEventHandler КурсRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddКурсRow(КурсRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсRow AddКурсRow(string Название_валюты, decimal Продажа, decimal Покупка) {
                КурсRow rowКурсRow = ((КурсRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Название_валюты,
                        Продажа,
                        Покупка};
                rowКурсRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowКурсRow);
                return rowКурсRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсRow FindByКод(int Код) {
                return ((КурсRow)(this.Rows.Find(new object[] {
                            Код})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                КурсDataTable cln = ((КурсDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new КурсDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnКод = base.Columns["Код"];
                this.columnНазвание_валюты = base.Columns["Название валюты"];
                this.columnПродажа = base.Columns["Продажа"];
                this.columnПокупка = base.Columns["Покупка"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnКод = new global::System.Data.DataColumn("Код", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод);
                this.columnНазвание_валюты = new global::System.Data.DataColumn("Название валюты", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНазвание_валюты);
                this.columnПродажа = new global::System.Data.DataColumn("Продажа", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnПродажа);
                this.columnПокупка = new global::System.Data.DataColumn("Покупка", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnПокупка);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод}, true));
                this.columnКод.AutoIncrement = true;
                this.columnКод.AutoIncrementSeed = -1;
                this.columnКод.AutoIncrementStep = -1;
                this.columnКод.AllowDBNull = false;
                this.columnКод.Unique = true;
                this.columnНазвание_валюты.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсRow NewКурсRow() {
                return ((КурсRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new КурсRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(КурсRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.КурсRowChanged != null)) {
                    this.КурсRowChanged(this, new КурсRowChangeEvent(((КурсRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.КурсRowChanging != null)) {
                    this.КурсRowChanging(this, new КурсRowChangeEvent(((КурсRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.КурсRowDeleted != null)) {
                    this.КурсRowDeleted(this, new КурсRowChangeEvent(((КурсRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.КурсRowDeleting != null)) {
                    this.КурсRowDeleting(this, new КурсRowChangeEvent(((КурсRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveКурсRow(КурсRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                ExchangeDataSet1 ds = new ExchangeDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "КурсDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class Список_операцийDataTable : global::System.Data.TypedTableBase<Список_операцийRow> {
            
            private global::System.Data.DataColumn columnКод;
            
            private global::System.Data.DataColumn columnФамилия_клиента;
            
            private global::System.Data.DataColumn columnФамилия_кассира;
            
            private global::System.Data.DataColumn columnДата;
            
            private global::System.Data.DataColumn columnСумма_продажи;
            
            private global::System.Data.DataColumn columnСумма_покупки;
            
            private global::System.Data.DataColumn columnВалюта;
            
            private global::System.Data.DataColumn columnНомер_паспорта;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийDataTable() {
                this.TableName = "Список операций";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Список_операцийDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected Список_операцийDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn КодColumn {
                get {
                    return this.columnКод;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Фамилия_клиентаColumn {
                get {
                    return this.columnФамилия_клиента;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Фамилия_кассираColumn {
                get {
                    return this.columnФамилия_кассира;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ДатаColumn {
                get {
                    return this.columnДата;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Сумма_продажиColumn {
                get {
                    return this.columnСумма_продажи;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Сумма_покупкиColumn {
                get {
                    return this.columnСумма_покупки;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ВалютаColumn {
                get {
                    return this.columnВалюта;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn Номер_паспортаColumn {
                get {
                    return this.columnНомер_паспорта;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow this[int index] {
                get {
                    return ((Список_операцийRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event Список_операцийRowChangeEventHandler Список_операцийRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event Список_операцийRowChangeEventHandler Список_операцийRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event Список_операцийRowChangeEventHandler Список_операцийRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event Список_операцийRowChangeEventHandler Список_операцийRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddСписок_операцийRow(Список_операцийRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow AddСписок_операцийRow(string Фамилия_клиента, КассирRow parentКассирRowByКассирСписок_операций, System.DateTime Дата, int Сумма_продажи, int Сумма_покупки, string Валюта, КлиентRow parentКлиентRowByКлиентСписок_операций) {
                Список_операцийRow rowСписок_операцийRow = ((Список_операцийRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Фамилия_клиента,
                        null,
                        Дата,
                        Сумма_продажи,
                        Сумма_покупки,
                        Валюта,
                        null};
                if ((parentКассирRowByКассирСписок_операций != null)) {
                    columnValuesArray[2] = parentКассирRowByКассирСписок_операций[1];
                }
                if ((parentКлиентRowByКлиентСписок_операций != null)) {
                    columnValuesArray[7] = parentКлиентRowByКлиентСписок_операций[6];
                }
                rowСписок_операцийRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowСписок_операцийRow);
                return rowСписок_операцийRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow FindByКод(int Код) {
                return ((Список_операцийRow)(this.Rows.Find(new object[] {
                            Код})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                Список_операцийDataTable cln = ((Список_операцийDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new Список_операцийDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnКод = base.Columns["Код"];
                this.columnФамилия_клиента = base.Columns["Фамилия клиента"];
                this.columnФамилия_кассира = base.Columns["Фамилия кассира"];
                this.columnДата = base.Columns["Дата"];
                this.columnСумма_продажи = base.Columns["Сумма продажи"];
                this.columnСумма_покупки = base.Columns["Сумма покупки"];
                this.columnВалюта = base.Columns["Валюта"];
                this.columnНомер_паспорта = base.Columns["Номер паспорта"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnКод = new global::System.Data.DataColumn("Код", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnКод);
                this.columnФамилия_клиента = new global::System.Data.DataColumn("Фамилия клиента", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnФамилия_клиента);
                this.columnФамилия_кассира = new global::System.Data.DataColumn("Фамилия кассира", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnФамилия_кассира);
                this.columnДата = new global::System.Data.DataColumn("Дата", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnДата);
                this.columnСумма_продажи = new global::System.Data.DataColumn("Сумма продажи", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСумма_продажи);
                this.columnСумма_покупки = new global::System.Data.DataColumn("Сумма покупки", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnСумма_покупки);
                this.columnВалюта = new global::System.Data.DataColumn("Валюта", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnВалюта);
                this.columnНомер_паспорта = new global::System.Data.DataColumn("Номер паспорта", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnНомер_паспорта);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnКод}, true));
                this.columnКод.AutoIncrement = true;
                this.columnКод.AutoIncrementSeed = -1;
                this.columnКод.AutoIncrementStep = -1;
                this.columnКод.AllowDBNull = false;
                this.columnКод.Unique = true;
                this.columnФамилия_клиента.MaxLength = 255;
                this.columnФамилия_кассира.MaxLength = 255;
                this.columnВалюта.MaxLength = 255;
                this.columnНомер_паспорта.MaxLength = 255;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow NewСписок_операцийRow() {
                return ((Список_операцийRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new Список_операцийRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(Список_операцийRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Список_операцийRowChanged != null)) {
                    this.Список_операцийRowChanged(this, new Список_операцийRowChangeEvent(((Список_операцийRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Список_операцийRowChanging != null)) {
                    this.Список_операцийRowChanging(this, new Список_операцийRowChangeEvent(((Список_операцийRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Список_операцийRowDeleted != null)) {
                    this.Список_операцийRowDeleted(this, new Список_операцийRowChangeEvent(((Список_операцийRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Список_операцийRowDeleting != null)) {
                    this.Список_операцийRowDeleting(this, new Список_операцийRowChangeEvent(((Список_операцийRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveСписок_операцийRow(Список_операцийRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                ExchangeDataSet1 ds = new ExchangeDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "Список_операцийDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class КассирRow : global::System.Data.DataRow {
            
            private КассирDataTable tableКассир;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal КассирRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableКассир = ((КассирDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Код {
                get {
                    try {
                        return ((int)(this[this.tableКассир.КодColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Код\' in table \'Кассир\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКассир.КодColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Фамилия {
                get {
                    return ((string)(this[this.tableКассир.ФамилияColumn]));
                }
                set {
                    this[this.tableКассир.ФамилияColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Имя {
                get {
                    try {
                        return ((string)(this[this.tableКассир.ИмяColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Имя\' in table \'Кассир\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКассир.ИмяColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Отчество {
                get {
                    try {
                        return ((string)(this[this.tableКассир.ОтчествоColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Отчество\' in table \'Кассир\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКассир.ОтчествоColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsКодNull() {
                return this.IsNull(this.tableКассир.КодColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetКодNull() {
                this[this.tableКассир.КодColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsИмяNull() {
                return this.IsNull(this.tableКассир.ИмяColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetИмяNull() {
                this[this.tableКассир.ИмяColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsОтчествоNull() {
                return this.IsNull(this.tableКассир.ОтчествоColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetОтчествоNull() {
                this[this.tableКассир.ОтчествоColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow[] GetСписок_операцийRows() {
                if ((this.Table.ChildRelations["КассирСписок операций"] == null)) {
                    return new Список_операцийRow[0];
                }
                else {
                    return ((Список_операцийRow[])(base.GetChildRows(this.Table.ChildRelations["КассирСписок операций"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class КлиентRow : global::System.Data.DataRow {
            
            private КлиентDataTable tableКлиент;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal КлиентRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableКлиент = ((КлиентDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Код {
                get {
                    try {
                        return ((int)(this[this.tableКлиент.КодColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Код\' in table \'Клиент\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКлиент.КодColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Фамилия {
                get {
                    try {
                        return ((string)(this[this.tableКлиент.ФамилияColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Фамилия\' in table \'Клиент\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКлиент.ФамилияColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Имя {
                get {
                    try {
                        return ((string)(this[this.tableКлиент.ИмяColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Имя\' in table \'Клиент\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКлиент.ИмяColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Отчество {
                get {
                    try {
                        return ((string)(this[this.tableКлиент.ОтчествоColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Отчество\' in table \'Клиент\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКлиент.ОтчествоColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Сумма_покупки {
                get {
                    try {
                        return ((int)(this[this.tableКлиент.Сумма_покупкиColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Сумма покупки\' in table \'Клиент\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКлиент.Сумма_покупкиColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Сумма_продажи {
                get {
                    try {
                        return ((int)(this[this.tableКлиент.Сумма_продажиColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Сумма продажи\' in table \'Клиент\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКлиент.Сумма_продажиColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Номер_паспорта {
                get {
                    return ((string)(this[this.tableКлиент.Номер_паспортаColumn]));
                }
                set {
                    this[this.tableКлиент.Номер_паспортаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsКодNull() {
                return this.IsNull(this.tableКлиент.КодColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetКодNull() {
                this[this.tableКлиент.КодColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsФамилияNull() {
                return this.IsNull(this.tableКлиент.ФамилияColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetФамилияNull() {
                this[this.tableКлиент.ФамилияColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsИмяNull() {
                return this.IsNull(this.tableКлиент.ИмяColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetИмяNull() {
                this[this.tableКлиент.ИмяColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsОтчествоNull() {
                return this.IsNull(this.tableКлиент.ОтчествоColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetОтчествоNull() {
                this[this.tableКлиент.ОтчествоColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsСумма_покупкиNull() {
                return this.IsNull(this.tableКлиент.Сумма_покупкиColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetСумма_покупкиNull() {
                this[this.tableКлиент.Сумма_покупкиColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsСумма_продажиNull() {
                return this.IsNull(this.tableКлиент.Сумма_продажиColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetСумма_продажиNull() {
                this[this.tableКлиент.Сумма_продажиColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow[] GetСписок_операцийRows() {
                if ((this.Table.ChildRelations["КлиентСписок операций"] == null)) {
                    return new Список_операцийRow[0];
                }
                else {
                    return ((Список_операцийRow[])(base.GetChildRows(this.Table.ChildRelations["КлиентСписок операций"])));
                }
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class КурсRow : global::System.Data.DataRow {
            
            private КурсDataTable tableКурс;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal КурсRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableКурс = ((КурсDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Код {
                get {
                    return ((int)(this[this.tableКурс.КодColumn]));
                }
                set {
                    this[this.tableКурс.КодColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Название_валюты {
                get {
                    try {
                        return ((string)(this[this.tableКурс.Название_валютыColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Название валюты\' in table \'Курс\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКурс.Название_валютыColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Продажа {
                get {
                    try {
                        return ((decimal)(this[this.tableКурс.ПродажаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Продажа\' in table \'Курс\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКурс.ПродажаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal Покупка {
                get {
                    try {
                        return ((decimal)(this[this.tableКурс.ПокупкаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Покупка\' in table \'Курс\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableКурс.ПокупкаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsНазвание_валютыNull() {
                return this.IsNull(this.tableКурс.Название_валютыColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetНазвание_валютыNull() {
                this[this.tableКурс.Название_валютыColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsПродажаNull() {
                return this.IsNull(this.tableКурс.ПродажаColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetПродажаNull() {
                this[this.tableКурс.ПродажаColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsПокупкаNull() {
                return this.IsNull(this.tableКурс.ПокупкаColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetПокупкаNull() {
                this[this.tableКурс.ПокупкаColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class Список_операцийRow : global::System.Data.DataRow {
            
            private Список_операцийDataTable tableСписок_операций;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Список_операцийRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableСписок_операций = ((Список_операцийDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Код {
                get {
                    return ((int)(this[this.tableСписок_операций.КодColumn]));
                }
                set {
                    this[this.tableСписок_операций.КодColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Фамилия_клиента {
                get {
                    try {
                        return ((string)(this[this.tableСписок_операций.Фамилия_клиентаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Фамилия клиента\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.Фамилия_клиентаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Фамилия_кассира {
                get {
                    try {
                        return ((string)(this[this.tableСписок_операций.Фамилия_кассираColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Фамилия кассира\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.Фамилия_кассираColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime Дата {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableСписок_операций.ДатаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Дата\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.ДатаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Сумма_продажи {
                get {
                    try {
                        return ((int)(this[this.tableСписок_операций.Сумма_продажиColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Сумма продажи\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.Сумма_продажиColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Сумма_покупки {
                get {
                    try {
                        return ((int)(this[this.tableСписок_операций.Сумма_покупкиColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Сумма покупки\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.Сумма_покупкиColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Валюта {
                get {
                    try {
                        return ((string)(this[this.tableСписок_операций.ВалютаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Валюта\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.ВалютаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Номер_паспорта {
                get {
                    try {
                        return ((string)(this[this.tableСписок_операций.Номер_паспортаColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Номер паспорта\' in table \'Список операций\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableСписок_операций.Номер_паспортаColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRow КассирRow {
                get {
                    return ((КассирRow)(this.GetParentRow(this.Table.ParentRelations["КассирСписок операций"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["КассирСписок операций"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRow КлиентRow {
                get {
                    return ((КлиентRow)(this.GetParentRow(this.Table.ParentRelations["КлиентСписок операций"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["КлиентСписок операций"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsФамилия_клиентаNull() {
                return this.IsNull(this.tableСписок_операций.Фамилия_клиентаColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetФамилия_клиентаNull() {
                this[this.tableСписок_операций.Фамилия_клиентаColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsФамилия_кассираNull() {
                return this.IsNull(this.tableСписок_операций.Фамилия_кассираColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetФамилия_кассираNull() {
                this[this.tableСписок_операций.Фамилия_кассираColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsДатаNull() {
                return this.IsNull(this.tableСписок_операций.ДатаColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetДатаNull() {
                this[this.tableСписок_операций.ДатаColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsСумма_продажиNull() {
                return this.IsNull(this.tableСписок_операций.Сумма_продажиColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetСумма_продажиNull() {
                this[this.tableСписок_операций.Сумма_продажиColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsСумма_покупкиNull() {
                return this.IsNull(this.tableСписок_операций.Сумма_покупкиColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetСумма_покупкиNull() {
                this[this.tableСписок_операций.Сумма_покупкиColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsВалютаNull() {
                return this.IsNull(this.tableСписок_операций.ВалютаColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetВалютаNull() {
                this[this.tableСписок_операций.ВалютаColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsНомер_паспортаNull() {
                return this.IsNull(this.tableСписок_операций.Номер_паспортаColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetНомер_паспортаNull() {
                this[this.tableСписок_операций.Номер_паспортаColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class КассирRowChangeEvent : global::System.EventArgs {
            
            private КассирRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRowChangeEvent(КассирRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КассирRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class КлиентRowChangeEvent : global::System.EventArgs {
            
            private КлиентRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRowChangeEvent(КлиентRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КлиентRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class КурсRowChangeEvent : global::System.EventArgs {
            
            private КурсRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсRowChangeEvent(КурсRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public КурсRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class Список_операцийRowChangeEvent : global::System.EventArgs {
            
            private Список_операцийRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRowChangeEvent(Список_операцийRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Список_операцийRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ExchangeDataSet1КассирTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ExchangeDataSet1КассирTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Кассир";
            tableMapping.ColumnMappings.Add("Код", "Код");
            tableMapping.ColumnMappings.Add("Фамилия", "Фамилия");
            tableMapping.ColumnMappings.Add("Имя", "Имя");
            tableMapping.ColumnMappings.Add("Отчество", "Отчество");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `Кассир` WHERE (((? = 1 AND `Код` IS NULL) OR (`Код` = ?)) AND (`Фами" +
                "лия` = ?) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя` = ?)) AND ((? = 1 AND `Отчест" +
                "во` IS NULL) OR (`Отчество` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Имя", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Отчество", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Кассир` (`Фамилия`, `Имя`, `Отчество`) VALUES (?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE `Кассир` SET `Фамилия` = ?, `Имя` = ?, `Отчество` = ? WHERE (((? = 1 AND `" +
                "Код` IS NULL) OR (`Код` = ?)) AND (`Фамилия` = ?) AND ((? = 1 AND `Имя` IS NULL)" +
                " OR (`Имя` = ?)) AND ((? = 1 AND `Отчество` IS NULL) OR (`Отчество` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Имя", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Отчество", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::Main.Properties.Settings.Default.ExchangeConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Код, Фамилия, Имя, Отчество FROM Кассир";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(ExchangeDataSet1.КассирDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual ExchangeDataSet1.КассирDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            ExchangeDataSet1.КассирDataTable dataTable = new ExchangeDataSet1.КассирDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1.КассирDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Кассир");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код, string Original_Фамилия, string Original_Имя, string Original_Отчество) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((object)(0));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_Код));
            if ((Original_Фамилия == null)) {
                throw new global::System.ArgumentNullException("Original_Фамилия");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Фамилия));
            }
            if ((Original_Имя == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Имя));
            }
            if ((Original_Отчество == null)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((string)(Original_Отчество));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Фамилия, string Имя, string Отчество) {
            if ((Фамилия == null)) {
                throw new global::System.ArgumentNullException("Фамилия");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Фамилия));
            }
            if ((Имя == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Имя));
            }
            if ((Отчество == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Отчество));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Фамилия, string Имя, string Отчество, int Original_Код, string Original_Фамилия, string Original_Имя, string Original_Отчество) {
            if ((Фамилия == null)) {
                throw new global::System.ArgumentNullException("Фамилия");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Фамилия));
            }
            if ((Имя == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Имя));
            }
            if ((Отчество == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Отчество));
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = ((object)(0));
            this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_Код));
            if ((Original_Фамилия == null)) {
                throw new global::System.ArgumentNullException("Original_Фамилия");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Original_Фамилия));
            }
            if ((Original_Имя == null)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Original_Имя));
            }
            if ((Original_Отчество == null)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_Отчество));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Имя, string Отчество, int Original_Код, string Original_Фамилия, string Original_Имя, string Original_Отчество) {
            return this.Update(Original_Фамилия, Имя, Отчество, Original_Код, Original_Фамилия, Original_Имя, Original_Отчество);
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ExchangeDataSet1КлиентTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ExchangeDataSet1КлиентTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Клиент";
            tableMapping.ColumnMappings.Add("Код", "Код");
            tableMapping.ColumnMappings.Add("Фамилия", "Фамилия");
            tableMapping.ColumnMappings.Add("Имя", "Имя");
            tableMapping.ColumnMappings.Add("Отчество", "Отчество");
            tableMapping.ColumnMappings.Add("Сумма покупки", "Сумма покупки");
            tableMapping.ColumnMappings.Add("Сумма продажи", "Сумма продажи");
            tableMapping.ColumnMappings.Add("Номер паспорта", "Номер паспорта");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Клиент` WHERE (((? = 1 AND `Код` IS NULL) OR (`Код` = ?)) AND ((? = 1 AND `Фамилия` IS NULL) OR (`Фамилия` = ?)) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя` = ?)) AND ((? = 1 AND `Отчество` IS NULL) OR (`Отчество` = ?)) AND ((? = 1 AND `Сумма покупки` IS NULL) OR (`Сумма покупки` = ?)) AND ((? = 1 AND `Сумма продажи` IS NULL) OR (`Сумма продажи` = ?)) AND (`Номер паспорта` = ?))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Имя", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Отчество", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Клиент` (`Фамилия`, `Имя`, `Отчество`, `Сумма покупки`, `Сумма прода" +
                "жи`, `Номер паспорта`) VALUES (?, ?, ?, ?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Клиент` SET `Фамилия` = ?, `Имя` = ?, `Отчество` = ?, `Сумма покупки` = ?, `Сумма продажи` = ?, `Номер паспорта` = ? WHERE (((? = 1 AND `Код` IS NULL) OR (`Код` = ?)) AND ((? = 1 AND `Фамилия` IS NULL) OR (`Фамилия` = ?)) AND ((? = 1 AND `Имя` IS NULL) OR (`Имя` = ?)) AND ((? = 1 AND `Отчество` IS NULL) OR (`Отчество` = ?)) AND ((? = 1 AND `Сумма покупки` IS NULL) OR (`Сумма покупки` = ?)) AND ((? = 1 AND `Сумма продажи` IS NULL) OR (`Сумма продажи` = ?)) AND (`Номер паспорта` = ?))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Имя", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Имя", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Имя", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Отчество", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Отчество", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Отчество", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::Main.Properties.Settings.Default.ExchangeConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Код, Фамилия, Имя, Отчество, [Сумма покупки], [Сумма продажи], [Номер пасп" +
                "орта] FROM Клиент";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(ExchangeDataSet1.КлиентDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual ExchangeDataSet1.КлиентDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            ExchangeDataSet1.КлиентDataTable dataTable = new ExchangeDataSet1.КлиентDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1.КлиентDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Клиент");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код, string Original_Фамилия, string Original_Имя, string Original_Отчество, global::System.Nullable<int> Original_Сумма_покупки, global::System.Nullable<int> Original_Сумма_продажи, string Original_Номер_паспорта) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((object)(0));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_Код));
            if ((Original_Фамилия == null)) {
                throw new global::System.ArgumentNullException("Original_Фамилия");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_Фамилия));
            }
            if ((Original_Имя == null)) {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_Имя));
            }
            if ((Original_Отчество == null)) {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[7].Value = ((string)(Original_Отчество));
            }
            if ((Original_Сумма_покупки.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[9].Value = ((int)(Original_Сумма_покупки.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Original_Сумма_продажи.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[11].Value = ((int)(Original_Сумма_продажи.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Original_Номер_паспорта == null)) {
                throw new global::System.ArgumentNullException("Original_Номер_паспорта");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[12].Value = ((string)(Original_Номер_паспорта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Фамилия, string Имя, string Отчество, global::System.Nullable<int> Сумма_покупки, global::System.Nullable<int> Сумма_продажи, string Номер_паспорта) {
            if ((Фамилия == null)) {
                throw new global::System.ArgumentNullException("Фамилия");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Фамилия));
            }
            if ((Имя == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Имя));
            }
            if ((Отчество == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Отчество));
            }
            if ((Сумма_покупки.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((int)(Сумма_покупки.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Сумма_продажи.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((int)(Сумма_продажи.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Номер_паспорта == null)) {
                throw new global::System.ArgumentNullException("Номер_паспорта");
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Номер_паспорта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Фамилия, string Имя, string Отчество, global::System.Nullable<int> Сумма_покупки, global::System.Nullable<int> Сумма_продажи, string Номер_паспорта, int Original_Код, string Original_Фамилия, string Original_Имя, string Original_Отчество, global::System.Nullable<int> Original_Сумма_покупки, global::System.Nullable<int> Original_Сумма_продажи, string Original_Номер_паспорта) {
            if ((Фамилия == null)) {
                throw new global::System.ArgumentNullException("Фамилия");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Фамилия));
            }
            if ((Имя == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Имя));
            }
            if ((Отчество == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Отчество));
            }
            if ((Сумма_покупки.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Сумма_покупки.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Сумма_продажи.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Сумма_продажи.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Номер_паспорта == null)) {
                throw new global::System.ArgumentNullException("Номер_паспорта");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Номер_паспорта));
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(0));
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_Код));
            if ((Original_Фамилия == null)) {
                throw new global::System.ArgumentNullException("Original_Фамилия");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_Фамилия));
            }
            if ((Original_Имя == null)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((string)(Original_Имя));
            }
            if ((Original_Отчество == null)) {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[13].Value = ((string)(Original_Отчество));
            }
            if ((Original_Сумма_покупки.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((int)(Original_Сумма_покупки.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Original_Сумма_продажи.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((int)(Original_Сумма_продажи.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Original_Номер_паспорта == null)) {
                throw new global::System.ArgumentNullException("Original_Номер_паспорта");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((string)(Original_Номер_паспорта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Фамилия, string Имя, string Отчество, global::System.Nullable<int> Сумма_покупки, global::System.Nullable<int> Сумма_продажи, int Original_Код, string Original_Фамилия, string Original_Имя, string Original_Отчество, global::System.Nullable<int> Original_Сумма_покупки, global::System.Nullable<int> Original_Сумма_продажи, string Original_Номер_паспорта) {
            return this.Update(Фамилия, Имя, Отчество, Сумма_покупки, Сумма_продажи, Original_Номер_паспорта, Original_Код, Original_Фамилия, Original_Имя, Original_Отчество, Original_Сумма_покупки, Original_Сумма_продажи, Original_Номер_паспорта);
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ExchangeDataSet1КурсTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ExchangeDataSet1КурсTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Курс";
            tableMapping.ColumnMappings.Add("Код", "Код");
            tableMapping.ColumnMappings.Add("Название валюты", "Название валюты");
            tableMapping.ColumnMappings.Add("Продажа", "Продажа");
            tableMapping.ColumnMappings.Add("Покупка", "Покупка");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM `Курс` WHERE ((`Код` = ?) AND ((? = 1 AND `Название валюты` IS NULL) " +
                "OR (`Название валюты` = ?)) AND ((? = 1 AND `Продажа` IS NULL) OR (`Продажа` = ?" +
                ")) AND ((? = 1 AND `Покупка` IS NULL) OR (`Покупка` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Название_валюты", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название валюты", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Название_валюты", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название валюты", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Продажа", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Продажа", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Продажа", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Продажа", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Покупка", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Покупка", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Покупка", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Покупка", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Курс` (`Название валюты`, `Продажа`, `Покупка`) VALUES (?, ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Название_валюты", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название валюты", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Продажа", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Продажа", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Покупка", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Покупка", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Курс` SET `Название валюты` = ?, `Продажа` = ?, `Покупка` = ? WHERE ((`Код` = ?) AND ((? = 1 AND `Название валюты` IS NULL) OR (`Название валюты` = ?)) AND ((? = 1 AND `Продажа` IS NULL) OR (`Продажа` = ?)) AND ((? = 1 AND `Покупка` IS NULL) OR (`Покупка` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Название_валюты", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название валюты", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Продажа", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Продажа", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Покупка", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Покупка", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Название_валюты", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название валюты", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Название_валюты", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название валюты", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Продажа", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Продажа", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Продажа", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Продажа", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Покупка", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Покупка", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Покупка", global::System.Data.OleDb.OleDbType.Currency, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Покупка", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::Main.Properties.Settings.Default.ExchangeConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Код, [Название валюты], Продажа, Покупка FROM Курс";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(ExchangeDataSet1.КурсDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual ExchangeDataSet1.КурсDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            ExchangeDataSet1.КурсDataTable dataTable = new ExchangeDataSet1.КурсDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1.КурсDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Курс");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код, string Original_Название_валюты, global::System.Nullable<decimal> Original_Продажа, global::System.Nullable<decimal> Original_Покупка) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код));
            if ((Original_Название_валюты == null)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Название_валюты));
            }
            if ((Original_Продажа.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((decimal)(Original_Продажа.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Original_Покупка.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((decimal)(Original_Покупка.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Название_валюты, global::System.Nullable<decimal> Продажа, global::System.Nullable<decimal> Покупка) {
            if ((Название_валюты == null)) {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Название_валюты));
            }
            if ((Продажа.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[1].Value = ((decimal)(Продажа.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Покупка.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[2].Value = ((decimal)(Покупка.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Название_валюты, global::System.Nullable<decimal> Продажа, global::System.Nullable<decimal> Покупка, int Original_Код, string Original_Название_валюты, global::System.Nullable<decimal> Original_Продажа, global::System.Nullable<decimal> Original_Покупка) {
            if ((Название_валюты == null)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Название_валюты));
            }
            if ((Продажа.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((decimal)(Продажа.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Покупка.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((decimal)(Покупка.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Original_Код));
            if ((Original_Название_валюты == null)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Original_Название_валюты));
            }
            if ((Original_Продажа.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[7].Value = ((decimal)(Original_Продажа.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Original_Покупка.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((decimal)(Original_Покупка.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class ExchangeDataSet1Список_операцийTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.OleDb.OleDbDataAdapter _adapter;
        
        private global::System.Data.OleDb.OleDbConnection _connection;
        
        private global::System.Data.OleDb.OleDbTransaction _transaction;
        
        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ExchangeDataSet1Список_операцийTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.OleDb.OleDbDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.OleDb.OleDbCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.OleDb.OleDbTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.OleDb.OleDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.OleDb.OleDbDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Список операций";
            tableMapping.ColumnMappings.Add("Код", "Код");
            tableMapping.ColumnMappings.Add("Фамилия клиента", "Фамилия клиента");
            tableMapping.ColumnMappings.Add("Фамилия кассира", "Фамилия кассира");
            tableMapping.ColumnMappings.Add("Дата", "Дата");
            tableMapping.ColumnMappings.Add("Сумма продажи", "Сумма продажи");
            tableMapping.ColumnMappings.Add("Сумма покупки", "Сумма покупки");
            tableMapping.ColumnMappings.Add("Валюта", "Валюта");
            tableMapping.ColumnMappings.Add("Номер паспорта", "Номер паспорта");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM `Список операций` WHERE ((`Код` = ?) AND ((? = 1 AND `Фамилия клиента` IS NULL) OR (`Фамилия клиента` = ?)) AND ((? = 1 AND `Фамилия кассира` IS NULL) OR (`Фамилия кассира` = ?)) AND ((? = 1 AND `Дата` IS NULL) OR (`Дата` = ?)) AND ((? = 1 AND `Сумма продажи` IS NULL) OR (`Сумма продажи` = ?)) AND ((? = 1 AND `Сумма покупки` IS NULL) OR (`Сумма покупки` = ?)) AND ((? = 1 AND `Валюта` IS NULL) OR (`Валюта` = ?)) AND ((? = 1 AND `Номер паспорта` IS NULL) OR (`Номер паспорта` = ?)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия_клиента", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия клиента", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия_клиента", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия клиента", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия_кассира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия кассира", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия_кассира", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия кассира", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Дата", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Дата", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Валюта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Валюта", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Валюта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Валюта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Номер_паспорта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.InsertCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO `Список операций` (`Фамилия клиента`, `Фамилия кассира`, `Дата`, `Сум" +
                "ма продажи`, `Сумма покупки`, `Валюта`, `Номер паспорта`) VALUES (?, ?, ?, ?, ?," +
                " ?, ?)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия_клиента", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия клиента", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия_кассира", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия кассира", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Дата", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Валюта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Валюта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand = new global::System.Data.OleDb.OleDbCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE `Список операций` SET `Фамилия клиента` = ?, `Фамилия кассира` = ?, `Дата` = ?, `Сумма продажи` = ?, `Сумма покупки` = ?, `Валюта` = ?, `Номер паспорта` = ? WHERE ((`Код` = ?) AND ((? = 1 AND `Фамилия клиента` IS NULL) OR (`Фамилия клиента` = ?)) AND ((? = 1 AND `Фамилия кассира` IS NULL) OR (`Фамилия кассира` = ?)) AND ((? = 1 AND `Дата` IS NULL) OR (`Дата` = ?)) AND ((? = 1 AND `Сумма продажи` IS NULL) OR (`Сумма продажи` = ?)) AND ((? = 1 AND `Сумма покупки` IS NULL) OR (`Сумма покупки` = ?)) AND ((? = 1 AND `Валюта` IS NULL) OR (`Валюта` = ?)) AND ((? = 1 AND `Номер паспорта` IS NULL) OR (`Номер паспорта` = ?)))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия_клиента", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия клиента", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Фамилия_кассира", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия кассира", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Дата", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Валюта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Валюта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Current, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Код", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия_клиента", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия клиента", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия_клиента", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия клиента", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Фамилия_кассира", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия кассира", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Фамилия_кассира", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Фамилия кассира", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Дата", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Дата", global::System.Data.OleDb.OleDbType.Date, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_продажи", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма продажи", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Сумма_покупки", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Сумма покупки", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Валюта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Валюта", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Валюта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Валюта", global::System.Data.DataRowVersion.Original, false, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("IsNull_Номер_паспорта", global::System.Data.OleDb.OleDbType.Integer, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Original, true, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.OleDb.OleDbParameter("Original_Номер_паспорта", global::System.Data.OleDb.OleDbType.VarWChar, 0, global::System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Номер паспорта", global::System.Data.DataRowVersion.Original, false, null));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.OleDb.OleDbConnection();
            this._connection.ConnectionString = global::Main.Properties.Settings.Default.ExchangeConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
            this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT Код, [Фамилия клиента], [Фамилия кассира], Дата, [Сумма продажи], [Сумма п" +
                "окупки], Валюта, [Номер паспорта] FROM [Список операций]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(ExchangeDataSet1.Список_операцийDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual ExchangeDataSet1.Список_операцийDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            ExchangeDataSet1.Список_операцийDataTable dataTable = new ExchangeDataSet1.Список_операцийDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1.Список_операцийDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(ExchangeDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Список операций");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_Код, string Original_Фамилия_клиента, string Original_Фамилия_кассира, System.DateTime Original_Дата, global::System.Nullable<int> Original_Сумма_продажи, global::System.Nullable<int> Original_Сумма_покупки, string Original_Валюта, string Original_Номер_паспорта) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_Код));
            if ((Original_Фамилия_клиента == null)) {
                throw new global::System.ArgumentNullException("Original_Фамилия_клиента");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_Фамилия_клиента));
            }
            if ((Original_Фамилия_кассира == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Фамилия_кассира));
            }
            this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
            this.Adapter.DeleteCommand.Parameters[6].Value = ((System.DateTime)(Original_Дата));
            if ((Original_Сумма_продажи.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((int)(Original_Сумма_продажи.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_Сумма_покупки.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((int)(Original_Сумма_покупки.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_Валюта == null)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((string)(Original_Валюта));
            }
            if ((Original_Номер_паспорта == null)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((string)(Original_Номер_паспорта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Фамилия_клиента, string Фамилия_кассира, System.DateTime Дата, global::System.Nullable<int> Сумма_продажи, global::System.Nullable<int> Сумма_покупки, string Валюта, string Номер_паспорта) {
            if ((Фамилия_клиента == null)) {
                throw new global::System.ArgumentNullException("Фамилия_клиента");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Фамилия_клиента));
            }
            if ((Фамилия_кассира == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Фамилия_кассира));
            }
            this.Adapter.InsertCommand.Parameters[2].Value = ((System.DateTime)(Дата));
            if ((Сумма_продажи.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((int)(Сумма_продажи.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Сумма_покупки.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((int)(Сумма_покупки.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Валюта == null)) {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Валюта));
            }
            if ((Номер_паспорта == null)) {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(Номер_паспорта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Фамилия_клиента, string Фамилия_кассира, System.DateTime Дата, global::System.Nullable<int> Сумма_продажи, global::System.Nullable<int> Сумма_покупки, string Валюта, string Номер_паспорта, int Original_Код, string Original_Фамилия_клиента, string Original_Фамилия_кассира, System.DateTime Original_Дата, global::System.Nullable<int> Original_Сумма_продажи, global::System.Nullable<int> Original_Сумма_покупки, string Original_Валюта, string Original_Номер_паспорта) {
            if ((Фамилия_клиента == null)) {
                throw new global::System.ArgumentNullException("Фамилия_клиента");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Фамилия_клиента));
            }
            if ((Фамилия_кассира == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Фамилия_кассира));
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = ((System.DateTime)(Дата));
            if ((Сумма_продажи.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(Сумма_продажи.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Сумма_покупки.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Сумма_покупки.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Валюта == null)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Валюта));
            }
            if ((Номер_паспорта == null)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Номер_паспорта));
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_Код));
            if ((Original_Фамилия_клиента == null)) {
                throw new global::System.ArgumentNullException("Original_Фамилия_клиента");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_Фамилия_клиента));
            }
            if ((Original_Фамилия_кассира == null)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((string)(Original_Фамилия_кассира));
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
            this.Adapter.UpdateCommand.Parameters[13].Value = ((System.DateTime)(Original_Дата));
            if ((Original_Сумма_продажи.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((int)(Original_Сумма_продажи.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Original_Сумма_покупки.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((int)(Original_Сумма_покупки.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Original_Валюта == null)) {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[19].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[19].Value = ((string)(Original_Валюта));
            }
            if ((Original_Номер_паспорта == null)) {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[21].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[21].Value = ((string)(Original_Номер_паспорта));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }
    
    /// <summary>
    ///TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class ExchangeDataSet1TableAdapterManager : global::System.ComponentModel.Component {
        
        private UpdateOrderOption _updateOrder;
        
        private КассирTableAdapter _кассирTableAdapter;
        
        private КлиентTableAdapter _клиентTableAdapter;
        
        private КурсTableAdapter _курсTableAdapter;
        
        private Список_операцийTableAdapter _список_операцийTableAdapter;
        
        private bool _backupDataSetBeforeUpdate;
        
        private global::System.Data.IDbConnection _connection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public UpdateOrderOption UpdateOrder {
            get {
                return this._updateOrder;
            }
            set {
                this._updateOrder = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public КассирTableAdapter КассирTableAdapter {
            get {
                return this._кассирTableAdapter;
            }
            set {
                this._кассирTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public КлиентTableAdapter КлиентTableAdapter {
            get {
                return this._клиентTableAdapter;
            }
            set {
                this._клиентTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public КурсTableAdapter КурсTableAdapter {
            get {
                return this._курсTableAdapter;
            }
            set {
                this._курсTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public Список_операцийTableAdapter Список_операцийTableAdapter {
            get {
                return this._список_операцийTableAdapter;
            }
            set {
                this._список_операцийTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool BackupDataSetBeforeUpdate {
            get {
                return this._backupDataSetBeforeUpdate;
            }
            set {
                this._backupDataSetBeforeUpdate = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection {
            get {
                if ((this._connection != null)) {
                    return this._connection;
                }
                if (((this._кассирTableAdapter != null) 
                            && (this._кассирTableAdapter.Connection != null))) {
                    return this._кассирTableAdapter.Connection;
                }
                if (((this._клиентTableAdapter != null) 
                            && (this._клиентTableAdapter.Connection != null))) {
                    return this._клиентTableAdapter.Connection;
                }
                if (((this._курсTableAdapter != null) 
                            && (this._курсTableAdapter.Connection != null))) {
                    return this._курсTableAdapter.Connection;
                }
                if (((this._список_операцийTableAdapter != null) 
                            && (this._список_операцийTableAdapter.Connection != null))) {
                    return this._список_операцийTableAdapter.Connection;
                }
                return null;
            }
            set {
                this._connection = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount {
            get {
                int count = 0;
                if ((this._кассирTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._клиентTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._курсTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._список_операцийTableAdapter != null)) {
                    count = (count + 1);
                }
                return count;
            }
        }
        
        /// <summary>
        ///Update rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateUpdatedRows(ExchangeDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._кассирTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Кассир.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._кассирTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._клиентTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Клиент.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._клиентTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._курсTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Курс.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._курсTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._список_операцийTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Список_операций.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._список_операцийTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Insert rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateInsertedRows(ExchangeDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._кассирTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Кассир.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._кассирTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._клиентTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Клиент.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._клиентTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._курсTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Курс.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._курсTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._список_операцийTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Список_операций.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._список_операцийTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Delete rows in bottom-up order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateDeletedRows(ExchangeDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows) {
            int result = 0;
            if ((this._список_операцийTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Список_операций.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._список_операцийTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._курсTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Курс.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._курсTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._клиентTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Клиент.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._клиентTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._кассирTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Кассир.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._кассирTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            if (((updatedRows == null) 
                        || (updatedRows.Length < 1))) {
                return updatedRows;
            }
            if (((allAddedRows == null) 
                        || (allAddedRows.Count < 1))) {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1)) {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false)) {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }
        
        /// <summary>
        ///Update all changes to the dataset.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int UpdateAll(ExchangeDataSet1 dataSet) {
            if ((dataSet == null)) {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false)) {
                return 0;
            }
            if (((this._кассирTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._кассирTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._клиентTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._клиентTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._курсTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._курсTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._список_операцийTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._список_операцийTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null)) {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) 
                        == global::System.Data.ConnectionState.Broken)) {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed)) {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null)) {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate) {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try {
                // ---- Prepare for update -----------
                //
                if ((this._кассирTableAdapter != null)) {
                    revertConnections.Add(this._кассирTableAdapter, this._кассирTableAdapter.Connection);
                    this._кассирTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._кассирTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._кассирTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._кассирTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._кассирTableAdapter.Adapter);
                    }
                }
                if ((this._клиентTableAdapter != null)) {
                    revertConnections.Add(this._клиентTableAdapter, this._клиентTableAdapter.Connection);
                    this._клиентTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._клиентTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._клиентTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._клиентTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._клиентTableAdapter.Adapter);
                    }
                }
                if ((this._курсTableAdapter != null)) {
                    revertConnections.Add(this._курсTableAdapter, this._курсTableAdapter.Connection);
                    this._курсTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._курсTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._курсTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._курсTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._курсTableAdapter.Adapter);
                    }
                }
                if ((this._список_операцийTableAdapter != null)) {
                    revertConnections.Add(this._список_операцийTableAdapter, this._список_операцийTableAdapter.Connection);
                    this._список_операцийTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(workConnection));
                    this._список_операцийTableAdapter.Transaction = ((global::System.Data.OleDb.OleDbTransaction)(workTransaction));
                    if (this._список_операцийTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._список_операцийTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._список_операцийTableAdapter.Adapter);
                    }
                }
                // 
                //---- Perform updates -----------
                //
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)) {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                // 
                //---- Commit updates -----------
                //
                workTransaction.Commit();
                if ((0 < allAddedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex) {
                workTransaction.Rollback();
                // ---- Restore the dataset -----------
                if (this.BackupDataSetBeforeUpdate) {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else {
                    if ((0 < allAddedRows.Count)) {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1)) {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally {
                if (workConnOpened) {
                    workConnection.Close();
                }
                if ((this._кассирTableAdapter != null)) {
                    this._кассирTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._кассирTableAdapter]));
                    this._кассирTableAdapter.Transaction = null;
                }
                if ((this._клиентTableAdapter != null)) {
                    this._клиентTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._клиентTableAdapter]));
                    this._клиентTableAdapter.Transaction = null;
                }
                if ((this._курсTableAdapter != null)) {
                    this._курсTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._курсTableAdapter]));
                    this._курсTableAdapter.Transaction = null;
                }
                if ((this._список_операцийTableAdapter != null)) {
                    this._список_операцийTableAdapter.Connection = ((global::System.Data.OleDb.OleDbConnection)(revertConnections[this._список_операцийTableAdapter]));
                    this._список_операцийTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count)) {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1)) {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst) {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection) {
            if ((this._connection != null)) {
                return true;
            }
            if (((this.Connection == null) 
                        || (inputConnection == null))) {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }
        
        /// <summary>
        ///Update Order Option
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption {
            
            InsertUpdateDelete = 0,
            
            UpdateInsertDelete = 1,
        }
        
        /// <summary>
        ///Used to sort self-referenced table's rows
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow> {
            
            private global::System.Data.DataRelation _relation;
            
            private int _childFirst;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst) {
                this._relation = relation;
                if (childFirst) {
                    this._childFirst = -1;
                }
                else {
                    this._childFirst = 1;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance) {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;

                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;

                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null) 
                            && (traversedRows.ContainsKey(parent) == false)); 
                ) {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }

                if ((distance == 0)) {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null) 
                                && (traversedRows.ContainsKey(parent) == false)); 
                    ) {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2) {
                if (object.ReferenceEquals(row1, row2)) {
                    return 0;
                }
                if ((row1 == null)) {
                    return -1;
                }
                if ((row2 == null)) {
                    return 1;
                }

                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                if (object.ReferenceEquals(root1, root2)) {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null) 
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591