namespace StockIn
{
    partial class History
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
            this.dateTimePickerHistoryFrom = new System.Windows.Forms.DateTimePicker();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHistoryFrom = new System.Windows.Forms.Label();
            this.dateTimePickerHistoryTo = new System.Windows.Forms.DateTimePicker();
            this.lblSearchTo = new System.Windows.Forms.Label();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.btnHistoryDelete = new System.Windows.Forms.Button();
            this.btnHistorySearch = new System.Windows.Forms.Button();
            this.btnHistoryExit = new System.Windows.Forms.Button();
            this.sTOCKLOCATORDataSet = new StockIn.STOCKLOCATORDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new StockIn.STOCKLOCATORDataSetTableAdapters.HistoryTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerHistoryFrom
            // 
            this.dateTimePickerHistoryFrom.Location = new System.Drawing.Point(78, 75);
            this.dateTimePickerHistoryFrom.Name = "dateTimePickerHistoryFrom";
            this.dateTimePickerHistoryFrom.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerHistoryFrom.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(42, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "?";
            // 
            // lblHistoryFrom
            // 
            this.lblHistoryFrom.AutoSize = true;
            this.lblHistoryFrom.Location = new System.Drawing.Point(38, 81);
            this.lblHistoryFrom.Name = "lblHistoryFrom";
            this.lblHistoryFrom.Size = new System.Drawing.Size(36, 13);
            this.lblHistoryFrom.TabIndex = 2;
            this.lblHistoryFrom.Text = "From :";
            // 
            // dateTimePickerHistoryTo
            // 
            this.dateTimePickerHistoryTo.Location = new System.Drawing.Point(267, 75);
            this.dateTimePickerHistoryTo.Name = "dateTimePickerHistoryTo";
            this.dateTimePickerHistoryTo.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerHistoryTo.TabIndex = 0;
            // 
            // lblSearchTo
            // 
            this.lblSearchTo.AutoSize = true;
            this.lblSearchTo.Location = new System.Drawing.Point(237, 81);
            this.lblSearchTo.Name = "lblSearchTo";
            this.lblSearchTo.Size = new System.Drawing.Size(26, 13);
            this.lblSearchTo.TabIndex = 2;
            this.lblSearchTo.Text = "To :";
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AutoGenerateColumns = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewHistory.DataSource = this.historyBindingSource;
            this.dataGridViewHistory.Location = new System.Drawing.Point(44, 183);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowTemplate.Height = 23;
            this.dataGridViewHistory.Size = new System.Drawing.Size(449, 261);
            this.dataGridViewHistory.TabIndex = 3;
            // 
            // btnHistoryDelete
            // 
            this.btnHistoryDelete.Location = new System.Drawing.Point(273, 132);
            this.btnHistoryDelete.Name = "btnHistoryDelete";
            this.btnHistoryDelete.Size = new System.Drawing.Size(119, 25);
            this.btnHistoryDelete.TabIndex = 4;
            this.btnHistoryDelete.Text = "DELETE HISTORY";
            this.btnHistoryDelete.UseVisualStyleBackColor = true;
            this.btnHistoryDelete.Click += new System.EventHandler(this.btnHistoryDelete_Click);
            // 
            // btnHistorySearch
            // 
            this.btnHistorySearch.Location = new System.Drawing.Point(106, 132);
            this.btnHistorySearch.Name = "btnHistorySearch";
            this.btnHistorySearch.Size = new System.Drawing.Size(64, 25);
            this.btnHistorySearch.TabIndex = 5;
            this.btnHistorySearch.Text = "SEARCH";
            this.btnHistorySearch.UseVisualStyleBackColor = true;
            this.btnHistorySearch.Click += new System.EventHandler(this.btnHistorySearch_Click);
            // 
            // btnHistoryExit
            // 
            this.btnHistoryExit.Location = new System.Drawing.Point(429, 75);
            this.btnHistoryExit.Name = "btnHistoryExit";
            this.btnHistoryExit.Size = new System.Drawing.Size(64, 25);
            this.btnHistoryExit.TabIndex = 6;
            this.btnHistoryExit.Text = "EXIT";
            this.btnHistoryExit.UseVisualStyleBackColor = true;
            this.btnHistoryExit.Click += new System.EventHandler(this.btnHistoryExit_Click);
            // 
            // sTOCKLOCATORDataSet
            // 
            this.sTOCKLOCATORDataSet.DataSetName = "STOCKLOCATORDataSet";
            this.sTOCKLOCATORDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.sTOCKLOCATORDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BMSNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "BMSNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn5.HeaderText = "User";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn6.HeaderText = "State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 488);
            this.Controls.Add(this.btnHistoryExit);
            this.Controls.Add(this.btnHistorySearch);
            this.Controls.Add(this.btnHistoryDelete);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.lblSearchTo);
            this.Controls.Add(this.lblHistoryFrom);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dateTimePickerHistoryTo);
            this.Controls.Add(this.dateTimePickerHistoryFrom);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerHistoryFrom;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHistoryFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerHistoryTo;
        private System.Windows.Forms.Label lblSearchTo;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        //private masterDataSet masterDataSet;
        private System.Windows.Forms.Button btnHistoryDelete;
        private System.Windows.Forms.Button btnHistorySearch;
        private System.Windows.Forms.Button btnHistoryExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private STOCKLOCATORDataSet sTOCKLOCATORDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private STOCKLOCATORDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private sql2DataSet sql2DataSet;
    }
}