﻿namespace StockIn
{
    partial class Delete
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBMSNo = new System.Windows.Forms.Label();
            this.txtBoxDeleteBMSNo = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBoxDeleteLocation = new System.Windows.Forms.TextBox();
            this.lblDeleteTime = new System.Windows.Forms.Label();
            this.dtPickerDelete = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtBoxLocationCount = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteExit = new System.Windows.Forms.Button();
            this.btnDeleteAllStock = new System.Windows.Forms.Button();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.sTOCKLOCATORDataSet = new StockIn.STOCKLOCATORDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new StockIn.STOCKLOCATORDataSetTableAdapters.StockTableAdapter();
            this.bMSNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(27, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "?";
            // 
            // lblBMSNo
            // 
            this.lblBMSNo.AutoSize = true;
            this.lblBMSNo.Location = new System.Drawing.Point(78, 96);
            this.lblBMSNo.Name = "lblBMSNo";
            this.lblBMSNo.Size = new System.Drawing.Size(56, 13);
            this.lblBMSNo.TabIndex = 1;
            this.lblBMSNo.Text = "BMS No. :";
            // 
            // txtBoxDeleteBMSNo
            // 
            this.txtBoxDeleteBMSNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDeleteBMSNo.Location = new System.Drawing.Point(173, 96);
            this.txtBoxDeleteBMSNo.Name = "txtBoxDeleteBMSNo";
            this.txtBoxDeleteBMSNo.Size = new System.Drawing.Size(131, 20);
            this.txtBoxDeleteBMSNo.TabIndex = 0;
            this.txtBoxDeleteBMSNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDeleteBMSNo_KeyPress);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(78, 137);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location :";
            // 
            // txtBoxDeleteLocation
            // 
            this.txtBoxDeleteLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDeleteLocation.Location = new System.Drawing.Point(173, 137);
            this.txtBoxDeleteLocation.Name = "txtBoxDeleteLocation";
            this.txtBoxDeleteLocation.Size = new System.Drawing.Size(131, 20);
            this.txtBoxDeleteLocation.TabIndex = 1;
            this.txtBoxDeleteLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDeleteLocation_KeyPress);
            // 
            // lblDeleteTime
            // 
            this.lblDeleteTime.AutoSize = true;
            this.lblDeleteTime.Location = new System.Drawing.Point(78, 222);
            this.lblDeleteTime.Name = "lblDeleteTime";
            this.lblDeleteTime.Size = new System.Drawing.Size(36, 13);
            this.lblDeleteTime.TabIndex = 1;
            this.lblDeleteTime.Text = "Time :";
            this.lblDeleteTime.Visible = false;
            // 
            // dtPickerDelete
            // 
            this.dtPickerDelete.Location = new System.Drawing.Point(173, 222);
            this.dtPickerDelete.Name = "dtPickerDelete";
            this.dtPickerDelete.Size = new System.Drawing.Size(131, 20);
            this.dtPickerDelete.TabIndex = 3;
            this.dtPickerDelete.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(78, 178);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 13);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Total Count :";
            // 
            // txtBoxLocationCount
            // 
            this.txtBoxLocationCount.Location = new System.Drawing.Point(173, 178);
            this.txtBoxLocationCount.Name = "txtBoxLocationCount";
            this.txtBoxLocationCount.Size = new System.Drawing.Size(131, 20);
            this.txtBoxLocationCount.TabIndex = 2;
            this.txtBoxLocationCount.TextChanged += new System.EventHandler(this.txtBoxLocationCount_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteExit
            // 
            this.btnDeleteExit.Location = new System.Drawing.Point(215, 283);
            this.btnDeleteExit.Name = "btnDeleteExit";
            this.btnDeleteExit.Size = new System.Drawing.Size(64, 25);
            this.btnDeleteExit.TabIndex = 6;
            this.btnDeleteExit.Text = "EXIT";
            this.btnDeleteExit.UseVisualStyleBackColor = true;
            this.btnDeleteExit.Click += new System.EventHandler(this.btnDeleteExit_Click);
            // 
            // btnDeleteAllStock
            // 
            this.btnDeleteAllStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteAllStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeleteAllStock.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAllStock.Location = new System.Drawing.Point(120, 365);
            this.btnDeleteAllStock.Name = "btnDeleteAllStock";
            this.btnDeleteAllStock.Size = new System.Drawing.Size(135, 30);
            this.btnDeleteAllStock.TabIndex = 9;
            this.btnDeleteAllStock.Text = "Delete All Stocks";
            this.btnDeleteAllStock.UseVisualStyleBackColor = false;
            this.btnDeleteAllStock.Click += new System.EventHandler(this.btnDeleteAllStock_Click);
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AllowUserToAddRows = false;
            this.dataGridViewDelete.AutoGenerateColumns = false;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bMSNoDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dataGridViewDelete.DataSource = this.stockBindingSource;
            this.dataGridViewDelete.Location = new System.Drawing.Point(369, 168);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.RowTemplate.Height = 23;
            this.dataGridViewDelete.Size = new System.Drawing.Size(335, 163);
            this.dataGridViewDelete.TabIndex = 10;
            this.dataGridViewDelete.Visible = false;
            // 
            // sTOCKLOCATORDataSet
            // 
            this.sTOCKLOCATORDataSet.DataSetName = "STOCKLOCATORDataSet";
            this.sTOCKLOCATORDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.sTOCKLOCATORDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // bMSNoDataGridViewTextBoxColumn
            // 
            this.bMSNoDataGridViewTextBoxColumn.DataPropertyName = "BMSNo";
            this.bMSNoDataGridViewTextBoxColumn.HeaderText = "BMSNo";
            this.bMSNoDataGridViewTextBoxColumn.Name = "bMSNoDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 488);
            this.Controls.Add(this.dataGridViewDelete);
            this.Controls.Add(this.btnDeleteAllStock);
            this.Controls.Add(this.btnDeleteExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtPickerDelete);
            this.Controls.Add(this.txtBoxLocationCount);
            this.Controls.Add(this.txtBoxDeleteLocation);
            this.Controls.Add(this.txtBoxDeleteBMSNo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDeleteTime);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblBMSNo);
            this.Controls.Add(this.lblUser);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBMSNo;
        private System.Windows.Forms.TextBox txtBoxDeleteBMSNo;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBoxDeleteLocation;
        private System.Windows.Forms.Label lblDeleteTime;
        private System.Windows.Forms.DateTimePicker dtPickerDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtBoxLocationCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteExit;
        private System.Windows.Forms.Button btnDeleteAllStock;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private STOCKLOCATORDataSet sTOCKLOCATORDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private STOCKLOCATORDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
    }
}