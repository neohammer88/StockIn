namespace StockIn
{
    partial class Search
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSearchBMSNo = new System.Windows.Forms.Label();
            this.txtBoxSearchBMSNo = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.btnSearchExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(22, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "?";
            // 
            // lblSearchBMSNo
            // 
            this.lblSearchBMSNo.AutoSize = true;
            this.lblSearchBMSNo.Location = new System.Drawing.Point(43, 66);
            this.lblSearchBMSNo.Name = "lblSearchBMSNo";
            this.lblSearchBMSNo.Size = new System.Drawing.Size(56, 13);
            this.lblSearchBMSNo.TabIndex = 1;
            this.lblSearchBMSNo.Text = "BMS No. :";
            // 
            // txtBoxSearchBMSNo
            // 
            this.txtBoxSearchBMSNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxSearchBMSNo.Location = new System.Drawing.Point(122, 63);
            this.txtBoxSearchBMSNo.Name = "txtBoxSearchBMSNo";
            this.txtBoxSearchBMSNo.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSearchBMSNo.TabIndex = 0;
            this.txtBoxSearchBMSNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearchBMSNo_KeyPress);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.Location = new System.Drawing.Point(45, 128);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(402, 298);
            this.dataGridViewSearch.TabIndex = 0;
            // 
            // btnSearchExit
            // 
            this.btnSearchExit.Location = new System.Drawing.Point(382, 61);
            this.btnSearchExit.Name = "btnSearchExit";
            this.btnSearchExit.Size = new System.Drawing.Size(64, 25);
            this.btnSearchExit.TabIndex = 2;
            this.btnSearchExit.Text = "EXIT";
            this.btnSearchExit.UseVisualStyleBackColor = true;
            this.btnSearchExit.Click += new System.EventHandler(this.btnSearchExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 488);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSearchExit);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.txtBoxSearchBMSNo);
            this.Controls.Add(this.lblSearchBMSNo);
            this.Controls.Add(this.lblUser);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSearchBMSNo;
        private System.Windows.Forms.TextBox txtBoxSearchBMSNo;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        //private masterDataSet masterDataSet;
        private System.Windows.Forms.Button btnSearchExit;
        private System.Windows.Forms.Button btnSearch;
    }
}