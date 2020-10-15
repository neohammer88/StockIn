namespace StockIn
{
    partial class BackupExcel
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
            this.btnBackupToExcelFile = new System.Windows.Forms.Button();
            this.btnRestoreFromExcelFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRestoreFromExcel = new System.Windows.Forms.Button();
            this.btnBackupExcelExit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.dataGridViewRestoreExcel = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKLOCATORDataSet = new StockIn.STOCKLOCATORDataSet();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new StockIn.STOCKLOCATORDataSetTableAdapters.StockTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestoreExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackupToExcelFile
            // 
            this.btnBackupToExcelFile.Location = new System.Drawing.Point(66, 113);
            this.btnBackupToExcelFile.Name = "btnBackupToExcelFile";
            this.btnBackupToExcelFile.Size = new System.Drawing.Size(233, 41);
            this.btnBackupToExcelFile.TabIndex = 0;
            this.btnBackupToExcelFile.Text = "Backup to Excel File";
            this.btnBackupToExcelFile.UseVisualStyleBackColor = true;
            this.btnBackupToExcelFile.Click += new System.EventHandler(this.btnBackupToExcelFile_Click);
            // 
            // btnRestoreFromExcelFile
            // 
            this.btnRestoreFromExcelFile.Location = new System.Drawing.Point(66, 237);
            this.btnRestoreFromExcelFile.Name = "btnRestoreFromExcelFile";
            this.btnRestoreFromExcelFile.Size = new System.Drawing.Size(233, 41);
            this.btnRestoreFromExcelFile.TabIndex = 0;
            this.btnRestoreFromExcelFile.Text = "Restore from Excel File";
            this.btnRestoreFromExcelFile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Backup to Excel File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBackupToExcelFile_Click);
            // 
            // btnRestoreFromExcel
            // 
            this.btnRestoreFromExcel.Location = new System.Drawing.Point(66, 237);
            this.btnRestoreFromExcel.Name = "btnRestoreFromExcel";
            this.btnRestoreFromExcel.Size = new System.Drawing.Size(233, 41);
            this.btnRestoreFromExcel.TabIndex = 0;
            this.btnRestoreFromExcel.Text = "Restore from Excel File";
            this.btnRestoreFromExcel.UseVisualStyleBackColor = true;
            this.btnRestoreFromExcel.Click += new System.EventHandler(this.btnRestoreFromExcel_Click);
            // 
            // btnBackupExcelExit
            // 
            this.btnBackupExcelExit.Location = new System.Drawing.Point(139, 340);
            this.btnBackupExcelExit.Name = "btnBackupExcelExit";
            this.btnBackupExcelExit.Size = new System.Drawing.Size(91, 41);
            this.btnBackupExcelExit.TabIndex = 0;
            this.btnBackupExcelExit.Text = "EXIT";
            this.btnBackupExcelExit.UseVisualStyleBackColor = true;
            this.btnBackupExcelExit.Click += new System.EventHandler(this.btnBackupExcelExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(41, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "?";
            // 
            // dataGridViewRestoreExcel
            // 
            this.dataGridViewRestoreExcel.AllowUserToAddRows = false;
            this.dataGridViewRestoreExcel.AutoGenerateColumns = false;
            this.dataGridViewRestoreExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestoreExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewRestoreExcel.DataSource = this.stockBindingSource1;
            this.dataGridViewRestoreExcel.Location = new System.Drawing.Point(328, 237);
            this.dataGridViewRestoreExcel.Name = "dataGridViewRestoreExcel";
            this.dataGridViewRestoreExcel.RowTemplate.Height = 23;
            this.dataGridViewRestoreExcel.Size = new System.Drawing.Size(333, 163);
            this.dataGridViewRestoreExcel.TabIndex = 2;
            this.dataGridViewRestoreExcel.Visible = false;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            // 
            // sTOCKLOCATORDataSet
            // 
            this.sTOCKLOCATORDataSet.DataSetName = "STOCKLOCATORDataSet";
            this.sTOCKLOCATORDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "Stock";
            this.stockBindingSource1.DataSource = this.sTOCKLOCATORDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BMSNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "BMSNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn2.HeaderText = "Location";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn4.HeaderText = "User";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // BackupExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 488);
            this.Controls.Add(this.dataGridViewRestoreExcel);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnBackupExcelExit);
            this.Controls.Add(this.btnRestoreFromExcel);
            this.Controls.Add(this.btnRestoreFromExcelFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackupToExcelFile);
            this.Name = "BackupExcel";
            this.Text = "Excel";
            this.Load += new System.EventHandler(this.BackupExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestoreExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackupToExcelFile;
        private System.Windows.Forms.Button btnRestoreFromExcelFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRestoreFromExcel;
        private System.Windows.Forms.Button btnBackupExcelExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dataGridViewRestoreExcel;
        //private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        //private sql2DataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private STOCKLOCATORDataSet sTOCKLOCATORDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private STOCKLOCATORDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}