namespace StockIn
{
    partial class BulkIn
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
            this.lblBulkTitle = new System.Windows.Forms.Label();
            this.txtBoxBulkTitle = new System.Windows.Forms.TextBox();
            this.lblBulkStartNo = new System.Windows.Forms.Label();
            this.txtBoxBulkStartNo = new System.Windows.Forms.TextBox();
            this.lblBulkCount = new System.Windows.Forms.Label();
            this.txtBoxBulkCount = new System.Windows.Forms.TextBox();
            this.lblBulkLocation = new System.Windows.Forms.Label();
            this.txtBoxBulkLocation = new System.Windows.Forms.TextBox();
            this.btnBulkSave = new System.Windows.Forms.Button();
            this.btnBulkExit = new System.Windows.Forms.Button();
            this.dataGridViewBulk = new System.Windows.Forms.DataGridView();
            this.btnBulkList = new System.Windows.Forms.Button();
            this.dateTimePickerBulk = new System.Windows.Forms.DateTimePicker();
            this.sTOCKLOCATORDataSet = new StockIn.STOCKLOCATORDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new StockIn.STOCKLOCATORDataSetTableAdapters.StockTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBulk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(32, 33);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "?";
            // 
            // lblBulkTitle
            // 
            this.lblBulkTitle.AutoSize = true;
            this.lblBulkTitle.Location = new System.Drawing.Point(50, 90);
            this.lblBulkTitle.Name = "lblBulkTitle";
            this.lblBulkTitle.Size = new System.Drawing.Size(37, 13);
            this.lblBulkTitle.TabIndex = 1;
            this.lblBulkTitle.Text = "TITLE";
            // 
            // txtBoxBulkTitle
            // 
            this.txtBoxBulkTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxBulkTitle.Location = new System.Drawing.Point(51, 116);
            this.txtBoxBulkTitle.Name = "txtBoxBulkTitle";
            this.txtBoxBulkTitle.Size = new System.Drawing.Size(32, 20);
            this.txtBoxBulkTitle.TabIndex = 2;
            this.txtBoxBulkTitle.Text = "BMS";
            // 
            // lblBulkStartNo
            // 
            this.lblBulkStartNo.AutoSize = true;
            this.lblBulkStartNo.Location = new System.Drawing.Point(99, 90);
            this.lblBulkStartNo.Name = "lblBulkStartNo";
            this.lblBulkStartNo.Size = new System.Drawing.Size(65, 13);
            this.lblBulkStartNo.TabIndex = 1;
            this.lblBulkStartNo.Text = "START NO.";
            // 
            // txtBoxBulkStartNo
            // 
            this.txtBoxBulkStartNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxBulkStartNo.Location = new System.Drawing.Point(88, 116);
            this.txtBoxBulkStartNo.Name = "txtBoxBulkStartNo";
            this.txtBoxBulkStartNo.Size = new System.Drawing.Size(91, 20);
            this.txtBoxBulkStartNo.TabIndex = 1;
            // 
            // lblBulkCount
            // 
            this.lblBulkCount.AutoSize = true;
            this.lblBulkCount.Location = new System.Drawing.Point(188, 90);
            this.lblBulkCount.Name = "lblBulkCount";
            this.lblBulkCount.Size = new System.Drawing.Size(83, 13);
            this.lblBulkCount.TabIndex = 1;
            this.lblBulkCount.Text = "TOTAL COUNT";
            // 
            // txtBoxBulkCount
            // 
            this.txtBoxBulkCount.Location = new System.Drawing.Point(189, 116);
            this.txtBoxBulkCount.Name = "txtBoxBulkCount";
            this.txtBoxBulkCount.Size = new System.Drawing.Size(78, 20);
            this.txtBoxBulkCount.TabIndex = 2;
            this.txtBoxBulkCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBulkCount_KeyPress);
            // 
            // lblBulkLocation
            // 
            this.lblBulkLocation.AutoSize = true;
            this.lblBulkLocation.Location = new System.Drawing.Point(285, 90);
            this.lblBulkLocation.Name = "lblBulkLocation";
            this.lblBulkLocation.Size = new System.Drawing.Size(61, 13);
            this.lblBulkLocation.TabIndex = 1;
            this.lblBulkLocation.Text = "LOCATION";
            // 
            // txtBoxBulkLocation
            // 
            this.txtBoxBulkLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxBulkLocation.Location = new System.Drawing.Point(287, 116);
            this.txtBoxBulkLocation.Name = "txtBoxBulkLocation";
            this.txtBoxBulkLocation.Size = new System.Drawing.Size(56, 20);
            this.txtBoxBulkLocation.TabIndex = 0;
            // 
            // btnBulkSave
            // 
            this.btnBulkSave.Location = new System.Drawing.Point(445, 114);
            this.btnBulkSave.Name = "btnBulkSave";
            this.btnBulkSave.Size = new System.Drawing.Size(64, 25);
            this.btnBulkSave.TabIndex = 3;
            this.btnBulkSave.Text = "SAVE";
            this.btnBulkSave.UseVisualStyleBackColor = true;
            this.btnBulkSave.Click += new System.EventHandler(this.btnBulkSave_Click);
            // 
            // btnBulkExit
            // 
            this.btnBulkExit.Location = new System.Drawing.Point(363, 385);
            this.btnBulkExit.Name = "btnBulkExit";
            this.btnBulkExit.Size = new System.Drawing.Size(64, 25);
            this.btnBulkExit.TabIndex = 4;
            this.btnBulkExit.Text = "EXIT";
            this.btnBulkExit.UseVisualStyleBackColor = true;
            this.btnBulkExit.Click += new System.EventHandler(this.btnBulkExit_Click);
            // 
            // dataGridViewBulk
            // 
            this.dataGridViewBulk.AllowUserToAddRows = false;
            this.dataGridViewBulk.AutoGenerateColumns = false;
            this.dataGridViewBulk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBulk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewBulk.DataSource = this.stockBindingSource;
            this.dataGridViewBulk.Location = new System.Drawing.Point(45, 169);
            this.dataGridViewBulk.Name = "dataGridViewBulk";
            this.dataGridViewBulk.RowTemplate.Height = 23;
            this.dataGridViewBulk.Size = new System.Drawing.Size(382, 183);
            this.dataGridViewBulk.TabIndex = 4;
            // 
            // btnBulkList
            // 
            this.btnBulkList.Location = new System.Drawing.Point(363, 114);
            this.btnBulkList.Name = "btnBulkList";
            this.btnBulkList.Size = new System.Drawing.Size(64, 25);
            this.btnBulkList.TabIndex = 5;
            this.btnBulkList.Text = "LIST";
            this.btnBulkList.UseVisualStyleBackColor = true;
            this.btnBulkList.Click += new System.EventHandler(this.btnBulkList_Click);
            // 
            // dateTimePickerBulk
            // 
            this.dateTimePickerBulk.Location = new System.Drawing.Point(363, 80);
            this.dateTimePickerBulk.Name = "dateTimePickerBulk";
            this.dateTimePickerBulk.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerBulk.TabIndex = 6;
            this.dateTimePickerBulk.Visible = false;
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
            // BulkIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 488);
            this.Controls.Add(this.dateTimePickerBulk);
            this.Controls.Add(this.btnBulkList);
            this.Controls.Add(this.dataGridViewBulk);
            this.Controls.Add(this.btnBulkExit);
            this.Controls.Add(this.btnBulkSave);
            this.Controls.Add(this.txtBoxBulkLocation);
            this.Controls.Add(this.txtBoxBulkCount);
            this.Controls.Add(this.txtBoxBulkStartNo);
            this.Controls.Add(this.txtBoxBulkTitle);
            this.Controls.Add(this.lblBulkLocation);
            this.Controls.Add(this.lblBulkCount);
            this.Controls.Add(this.lblBulkStartNo);
            this.Controls.Add(this.lblBulkTitle);
            this.Controls.Add(this.lblUser);
            this.Name = "BulkIn";
            this.Text = "BulkIn";
            this.Load += new System.EventHandler(this.BulkIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBulk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBulkTitle;
        private System.Windows.Forms.TextBox txtBoxBulkTitle;
        private System.Windows.Forms.Label lblBulkStartNo;
        private System.Windows.Forms.TextBox txtBoxBulkStartNo;
        private System.Windows.Forms.Label lblBulkCount;
        private System.Windows.Forms.TextBox txtBoxBulkCount;
        private System.Windows.Forms.Label lblBulkLocation;
        private System.Windows.Forms.TextBox txtBoxBulkLocation;
        private System.Windows.Forms.Button btnBulkSave;
        private System.Windows.Forms.Button btnBulkExit;
        private System.Windows.Forms.DataGridView dataGridViewBulk;
        //private masterDataSet masterDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBulkList;
        private System.Windows.Forms.DateTimePicker dateTimePickerBulk;
        private STOCKLOCATORDataSet sTOCKLOCATORDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private STOCKLOCATORDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}