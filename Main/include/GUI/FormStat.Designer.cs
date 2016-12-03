namespace Main.include.GUI
{
    partial class FormStat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.списокОперацийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSetExchange = new Main.DSetExchange();
            this.список_операцийTableAdapter = new Main.DSetExchangeTableAdapters.Список_операцийTableAdapter();
            this.списокОперацийBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.списокОперацийBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаПокупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.валютаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКассираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSetExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияКлиентаDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.суммаПродажиDataGridViewTextBoxColumn,
            this.суммаПокупкиDataGridViewTextBoxColumn,
            this.валютаDataGridViewTextBoxColumn,
            this.фамилияКассираDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.списокОперацийBindingSource, "Дата", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "dateTimePicker"));
            this.dataGridView1.DataSource = this.списокОперацийBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 16, 0, 0, 0, 0);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // списокОперацийBindingSource
            // 
            this.списокОперацийBindingSource.DataMember = "Список операций";
            this.списокОперацийBindingSource.DataSource = this.dSetExchange;
            // 
            // dSetExchange
            // 
            this.dSetExchange.DataSetName = "DSetExchange";
            this.dSetExchange.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_операцийTableAdapter
            // 
            this.список_операцийTableAdapter.ClearBeforeFill = true;
            // 
            // списокОперацийBindingSource1
            // 
            this.списокОперацийBindingSource1.DataMember = "Список операций";
            this.списокОперацийBindingSource1.DataSource = this.dSetExchange;
            // 
            // списокОперацийBindingSource2
            // 
            this.списокОперацийBindingSource2.DataMember = "Список операций";
            this.списокОперацийBindingSource2.DataSource = this.dSetExchange;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            resources.ApplyResources(this.кодDataGridViewTextBoxColumn, "кодDataGridViewTextBoxColumn");
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияКлиентаDataGridViewTextBoxColumn
            // 
            this.фамилияКлиентаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия клиента";
            resources.ApplyResources(this.фамилияКлиентаDataGridViewTextBoxColumn, "фамилияКлиентаDataGridViewTextBoxColumn");
            this.фамилияКлиентаDataGridViewTextBoxColumn.Name = "фамилияКлиентаDataGridViewTextBoxColumn";
            this.фамилияКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерПаспортаDataGridViewTextBoxColumn
            // 
            this.номерПаспортаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
            resources.ApplyResources(this.номерПаспортаDataGridViewTextBoxColumn, "номерПаспортаDataGridViewTextBoxColumn");
            this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
            this.номерПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            resources.ApplyResources(this.датаDataGridViewTextBoxColumn, "датаDataGridViewTextBoxColumn");
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаПродажиDataGridViewTextBoxColumn
            // 
            this.суммаПродажиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.суммаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Сумма продажи";
            resources.ApplyResources(this.суммаПродажиDataGridViewTextBoxColumn, "суммаПродажиDataGridViewTextBoxColumn");
            this.суммаПродажиDataGridViewTextBoxColumn.Name = "суммаПродажиDataGridViewTextBoxColumn";
            this.суммаПродажиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаПокупкиDataGridViewTextBoxColumn
            // 
            this.суммаПокупкиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.суммаПокупкиDataGridViewTextBoxColumn.DataPropertyName = "Сумма покупки";
            resources.ApplyResources(this.суммаПокупкиDataGridViewTextBoxColumn, "суммаПокупкиDataGridViewTextBoxColumn");
            this.суммаПокупкиDataGridViewTextBoxColumn.Name = "суммаПокупкиDataGridViewTextBoxColumn";
            this.суммаПокупкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // валютаDataGridViewTextBoxColumn
            // 
            this.валютаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.валютаDataGridViewTextBoxColumn.DataPropertyName = "Валюта";
            resources.ApplyResources(this.валютаDataGridViewTextBoxColumn, "валютаDataGridViewTextBoxColumn");
            this.валютаDataGridViewTextBoxColumn.Name = "валютаDataGridViewTextBoxColumn";
            this.валютаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияКассираDataGridViewTextBoxColumn
            // 
            this.фамилияКассираDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияКассираDataGridViewTextBoxColumn.DataPropertyName = "Фамилия кассира";
            resources.ApplyResources(this.фамилияКассираDataGridViewTextBoxColumn, "фамилияКассираDataGridViewTextBoxColumn");
            this.фамилияКассираDataGridViewTextBoxColumn.Name = "фамилияКассираDataGridViewTextBoxColumn";
            this.фамилияКассираDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormStat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormStat";
            this.Load += new System.EventHandler(this.FormStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSetExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private DSetExchange dSetExchange;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource;
        private DSetExchangeTableAdapters.Список_операцийTableAdapter список_операцийTableAdapter;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource1;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаПокупкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn валютаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКассираDataGridViewTextBoxColumn;
    }
}