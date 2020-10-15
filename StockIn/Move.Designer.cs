namespace StockIn
{
    partial class Move
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
            this.lblMoveFrom = new System.Windows.Forms.Label();
            this.lblMoveFromLocation = new System.Windows.Forms.Label();
            this.txtBoxMoveFromLocation = new System.Windows.Forms.TextBox();
            this.lblMoveFromCount = new System.Windows.Forms.Label();
            this.txtBoxMoveFromCount = new System.Windows.Forms.TextBox();
            this.lblMoveTo = new System.Windows.Forms.Label();
            this.lblMoveToLocation = new System.Windows.Forms.Label();
            this.txtBoxMoveToLocation = new System.Windows.Forms.TextBox();
            this.lblMoveToCount = new System.Windows.Forms.Label();
            this.txtBoxMoveToCount = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnMoveExit = new System.Windows.Forms.Button();
            this.pBoxArrow = new System.Windows.Forms.PictureBox();
            this.dataGridViewMove = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.dateTimePickerMove = new System.Windows.Forms.DateTimePicker();
            this.sTOCKLOCATORDataSet = new StockIn.STOCKLOCATORDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new StockIn.STOCKLOCATORDataSetTableAdapters.StockTableAdapter();
            this.bMSNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoveFrom
            // 
            this.lblMoveFrom.AutoSize = true;
            this.lblMoveFrom.Location = new System.Drawing.Point(111, 93);
            this.lblMoveFrom.Name = "lblMoveFrom";
            this.lblMoveFrom.Size = new System.Drawing.Size(38, 13);
            this.lblMoveFrom.TabIndex = 0;
            this.lblMoveFrom.Text = "FROM";
            // 
            // lblMoveFromLocation
            // 
            this.lblMoveFromLocation.AutoSize = true;
            this.lblMoveFromLocation.Location = new System.Drawing.Point(51, 153);
            this.lblMoveFromLocation.Name = "lblMoveFromLocation";
            this.lblMoveFromLocation.Size = new System.Drawing.Size(54, 13);
            this.lblMoveFromLocation.TabIndex = 1;
            this.lblMoveFromLocation.Text = "Location :";
            // 
            // txtBoxMoveFromLocation
            // 
            this.txtBoxMoveFromLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxMoveFromLocation.Location = new System.Drawing.Point(108, 150);
            this.txtBoxMoveFromLocation.Name = "txtBoxMoveFromLocation";
            this.txtBoxMoveFromLocation.Size = new System.Drawing.Size(86, 20);
            this.txtBoxMoveFromLocation.TabIndex = 0;
            this.txtBoxMoveFromLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMoveFromLocation_KeyPress);
            // 
            // lblMoveFromCount
            // 
            this.lblMoveFromCount.AutoSize = true;
            this.lblMoveFromCount.Location = new System.Drawing.Point(51, 207);
            this.lblMoveFromCount.Name = "lblMoveFromCount";
            this.lblMoveFromCount.Size = new System.Drawing.Size(37, 13);
            this.lblMoveFromCount.TabIndex = 1;
            this.lblMoveFromCount.Text = "Total :";
            // 
            // txtBoxMoveFromCount
            // 
            this.txtBoxMoveFromCount.Location = new System.Drawing.Point(108, 204);
            this.txtBoxMoveFromCount.Name = "txtBoxMoveFromCount";
            this.txtBoxMoveFromCount.Size = new System.Drawing.Size(86, 20);
            this.txtBoxMoveFromCount.TabIndex = 2;
            this.txtBoxMoveFromCount.TextChanged += new System.EventHandler(this.txtBoxMoveFromCount_TextChanged);
            // 
            // lblMoveTo
            // 
            this.lblMoveTo.AutoSize = true;
            this.lblMoveTo.Location = new System.Drawing.Point(378, 93);
            this.lblMoveTo.Name = "lblMoveTo";
            this.lblMoveTo.Size = new System.Drawing.Size(22, 13);
            this.lblMoveTo.TabIndex = 0;
            this.lblMoveTo.Text = "TO";
            // 
            // lblMoveToLocation
            // 
            this.lblMoveToLocation.AutoSize = true;
            this.lblMoveToLocation.Location = new System.Drawing.Point(318, 153);
            this.lblMoveToLocation.Name = "lblMoveToLocation";
            this.lblMoveToLocation.Size = new System.Drawing.Size(54, 13);
            this.lblMoveToLocation.TabIndex = 1;
            this.lblMoveToLocation.Text = "Location :";
            // 
            // txtBoxMoveToLocation
            // 
            this.txtBoxMoveToLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxMoveToLocation.Location = new System.Drawing.Point(375, 150);
            this.txtBoxMoveToLocation.Name = "txtBoxMoveToLocation";
            this.txtBoxMoveToLocation.Size = new System.Drawing.Size(86, 20);
            this.txtBoxMoveToLocation.TabIndex = 1;
            this.txtBoxMoveToLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMoveToLocation_KeyPress);
            // 
            // lblMoveToCount
            // 
            this.lblMoveToCount.AutoSize = true;
            this.lblMoveToCount.Location = new System.Drawing.Point(318, 207);
            this.lblMoveToCount.Name = "lblMoveToCount";
            this.lblMoveToCount.Size = new System.Drawing.Size(37, 13);
            this.lblMoveToCount.TabIndex = 1;
            this.lblMoveToCount.Text = "Total :";
            // 
            // txtBoxMoveToCount
            // 
            this.txtBoxMoveToCount.Location = new System.Drawing.Point(375, 204);
            this.txtBoxMoveToCount.Name = "txtBoxMoveToCount";
            this.txtBoxMoveToCount.Size = new System.Drawing.Size(86, 20);
            this.txtBoxMoveToCount.TabIndex = 2;
            this.txtBoxMoveToCount.TextChanged += new System.EventHandler(this.txtBoxMoveToCount_TextChanged);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(177, 286);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(64, 25);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "MOVE";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveExit
            // 
            this.btnMoveExit.Location = new System.Drawing.Point(272, 286);
            this.btnMoveExit.Name = "btnMoveExit";
            this.btnMoveExit.Size = new System.Drawing.Size(64, 25);
            this.btnMoveExit.TabIndex = 3;
            this.btnMoveExit.Text = "EXIT";
            this.btnMoveExit.UseVisualStyleBackColor = true;
            this.btnMoveExit.Click += new System.EventHandler(this.btnMoveExit_Click);
            // 
            // pBoxArrow
            // 
            this.pBoxArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBoxArrow.Image = global::StockIn.Properties.Resources.arrow1;
            this.pBoxArrow.Location = new System.Drawing.Point(219, 146);
            this.pBoxArrow.Name = "pBoxArrow";
            this.pBoxArrow.Size = new System.Drawing.Size(76, 77);
            this.pBoxArrow.TabIndex = 5;
            this.pBoxArrow.TabStop = false;
            // 
            // dataGridViewMove
            // 
            this.dataGridViewMove.AllowUserToAddRows = false;
            this.dataGridViewMove.AutoGenerateColumns = false;
            this.dataGridViewMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bMSNoDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dataGridViewMove.DataSource = this.stockBindingSource;
            this.dataGridViewMove.Location = new System.Drawing.Point(75, 332);
            this.dataGridViewMove.Name = "dataGridViewMove";
            this.dataGridViewMove.RowTemplate.Height = 23;
            this.dataGridViewMove.Size = new System.Drawing.Size(386, 101);
            this.dataGridViewMove.TabIndex = 6;
            this.dataGridViewMove.VirtualMode = true;
            this.dataGridViewMove.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(33, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "?";
            // 
            // dateTimePickerMove
            // 
            this.dateTimePickerMove.Location = new System.Drawing.Point(206, 87);
            this.dateTimePickerMove.Name = "dateTimePickerMove";
            this.dateTimePickerMove.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerMove.TabIndex = 8;
            this.dateTimePickerMove.Visible = false;
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
            // Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 488);
            this.Controls.Add(this.dateTimePickerMove);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dataGridViewMove);
            this.Controls.Add(this.pBoxArrow);
            this.Controls.Add(this.btnMoveExit);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtBoxMoveToCount);
            this.Controls.Add(this.txtBoxMoveFromCount);
            this.Controls.Add(this.lblMoveToCount);
            this.Controls.Add(this.lblMoveFromCount);
            this.Controls.Add(this.txtBoxMoveToLocation);
            this.Controls.Add(this.lblMoveToLocation);
            this.Controls.Add(this.txtBoxMoveFromLocation);
            this.Controls.Add(this.lblMoveTo);
            this.Controls.Add(this.lblMoveFromLocation);
            this.Controls.Add(this.lblMoveFrom);
            this.Name = "Move";
            this.Text = "Move";
            this.Load += new System.EventHandler(this.Move_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKLOCATORDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoveFrom;
        private System.Windows.Forms.Label lblMoveFromLocation;
        private System.Windows.Forms.TextBox txtBoxMoveFromLocation;
        private System.Windows.Forms.Label lblMoveFromCount;
        private System.Windows.Forms.TextBox txtBoxMoveFromCount;
        private System.Windows.Forms.Label lblMoveTo;
        private System.Windows.Forms.Label lblMoveToLocation;
        private System.Windows.Forms.TextBox txtBoxMoveToLocation;
        private System.Windows.Forms.Label lblMoveToCount;
        private System.Windows.Forms.TextBox txtBoxMoveToCount;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnMoveExit;
        private System.Windows.Forms.PictureBox pBoxArrow;
        private System.Windows.Forms.DataGridView dataGridViewMove;
        //private sql2DataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerMove;
        private STOCKLOCATORDataSet sTOCKLOCATORDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private STOCKLOCATORDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
    }
}