﻿namespace Main.include.GUI
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.списокОперацийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.списокОперацийBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.exchangeDataSet = new Main.ExchangeDataSet();
            this.списокОперацийBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.списокОперацийBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.список_операцийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокОперацийBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.exchangeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_операцийTableAdapter = new Main.ExchangeDataSetTableAdapters.Список_операцийTableAdapter();
            this.tableAdapterManager = new Main.ExchangeDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.списокОперацийBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.списокОперацийBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.списокОперацийBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeDataSet1 = new Main.ExchangeDataSet1();
            this.списокОперацийBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.список_операцийTableAdapter1 = new Main.ExchangeDataSet1TableAdapters.Список_операцийTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_операцийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource8)).BeginInit();
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
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.Value = new System.DateTime(2016, 11, 16, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // списокОперацийBindingSource
            // 
            this.списокОперацийBindingSource.DataMember = "Список операций";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // списокОперацийBindingSource7
            // 
            this.списокОперацийBindingSource7.DataMember = "Список операций";
            this.списокОперацийBindingSource7.DataSource = this.exchangeDataSet;
            // 
            // exchangeDataSet
            // 
            this.exchangeDataSet.DataSetName = "ExchangeDataSet";
            this.exchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокОперацийBindingSource2
            // 
            this.списокОперацийBindingSource2.DataMember = "Список операций";
            this.списокОперацийBindingSource2.DataSource = this.exchangeDataSet;
            // 
            // список_операцийBindingSource
            // 
            this.список_операцийBindingSource.DataMember = "Список операций";
            this.список_операцийBindingSource.DataSource = this.exchangeDataSet;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 16, 0, 0, 0, 0);
            // 
            // exchangeDataSetBindingSource
            // 
            this.exchangeDataSetBindingSource.DataSource = this.exchangeDataSet;
            this.exchangeDataSetBindingSource.Position = 0;
            // 
            // список_операцийTableAdapter
            // 
            this.список_операцийTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Main.ExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КассирTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.КурсTableAdapter = null;
            this.tableAdapterManager.Список_операцийTableAdapter = this.список_операцийTableAdapter;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // списокОперацийBindingSource3
            // 
            this.списокОперацийBindingSource3.DataMember = "Список операций";
            this.списокОперацийBindingSource3.DataSource = this.exchangeDataSet;
            // 
            // списокОперацийBindingSource4
            // 
            this.списокОперацийBindingSource4.DataMember = "Список операций";
            this.списокОперацийBindingSource4.DataSource = this.exchangeDataSet;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            resources.ApplyResources(this.кодDataGridViewTextBoxColumn, "кодDataGridViewTextBoxColumn");
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияКлиентаDataGridViewTextBoxColumn
            // 
            this.фамилияКлиентаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия клиента";
            resources.ApplyResources(this.фамилияКлиентаDataGridViewTextBoxColumn, "фамилияКлиентаDataGridViewTextBoxColumn");
            this.фамилияКлиентаDataGridViewTextBoxColumn.Name = "фамилияКлиентаDataGridViewTextBoxColumn";
            // 
            // Код
            // 
            this.Код.DataPropertyName = "Код";
            resources.ApplyResources(this.Код, "Код");
            this.Код.Name = "Код";
            // 
            // exchangeDataSet1
            // 
            this.exchangeDataSet1.DataSetName = "ExchangeDataSet1";
            this.exchangeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокОперацийBindingSource8
            // 
            this.списокОперацийBindingSource8.DataMember = "Список операций";
            this.списокОперацийBindingSource8.DataSource = this.exchangeDataSet1;
            // 
            // список_операцийTableAdapter1
            // 
            this.список_операцийTableAdapter1.ClearBeforeFill = true;
            // 
            // FormStat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormStat";
            this.Load += new System.EventHandler(this.Stat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_операцийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОперацийBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ExchangeDataSet exchangeDataSet;
        private System.Windows.Forms.BindingSource exchangeDataSetBindingSource;
        private System.Windows.Forms.BindingSource список_операцийBindingSource;
        private ExchangeDataSetTableAdapters.Список_операцийTableAdapter список_операцийTableAdapter;
        private ExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource2;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource4;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource3;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource7;
        private ExchangeDataSet1 exchangeDataSet1;
        private System.Windows.Forms.BindingSource списокОперацийBindingSource8;
        private ExchangeDataSet1TableAdapters.Список_операцийTableAdapter список_операцийTableAdapter1;
    }
}