namespace StockIn
{
    partial class Save
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
            this.lblBMSNo = new System.Windows.Forms.Label();
            this.txtBoxSaveBMSNo = new System.Windows.Forms.TextBox();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.txtBoxSaveLocation = new System.Windows.Forms.TextBox();
            this.lblSaveTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSaveSum = new System.Windows.Forms.Label();
            this.txtBoxSaveSum = new System.Windows.Forms.TextBox();
            this.dtPickerSaveTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBMSNo
            // 
            this.lblBMSNo.AutoSize = true;
            this.lblBMSNo.Location = new System.Drawing.Point(83, 118);
            this.lblBMSNo.Name = "lblBMSNo";
            this.lblBMSNo.Size = new System.Drawing.Size(64, 12);
            this.lblBMSNo.TabIndex = 0;
            this.lblBMSNo.Text = "BMS No. :";
            // 
            // txtBoxSaveBMSNo
            // 
            this.txtBoxSaveBMSNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxSaveBMSNo.Location = new System.Drawing.Point(174, 118);
            this.txtBoxSaveBMSNo.Name = "txtBoxSaveBMSNo";
            this.txtBoxSaveBMSNo.Size = new System.Drawing.Size(100, 21);
            this.txtBoxSaveBMSNo.TabIndex = 1;
            this.txtBoxSaveBMSNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSaveBMSNo_KeyPress);
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(83, 155);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(61, 12);
            this.lblSaveLocation.TabIndex = 0;
            this.lblSaveLocation.Text = "Location :";
            // 
            // txtBoxSaveLocation
            // 
            this.txtBoxSaveLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxSaveLocation.Location = new System.Drawing.Point(174, 155);
            this.txtBoxSaveLocation.Name = "txtBoxSaveLocation";
            this.txtBoxSaveLocation.Size = new System.Drawing.Size(100, 21);
            this.txtBoxSaveLocation.TabIndex = 0;
            this.txtBoxSaveLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSaveLocation_KeyPress);
            // 
            // lblSaveTime
            // 
            this.lblSaveTime.AutoSize = true;
            this.lblSaveTime.Location = new System.Drawing.Point(83, 246);
            this.lblSaveTime.Name = "lblSaveTime";
            this.lblSaveTime.Size = new System.Drawing.Size(42, 12);
            this.lblSaveTime.TabIndex = 0;
            this.lblSaveTime.Text = "Time :";
            this.lblSaveTime.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(40, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(11, 12);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "?";
            // 
            // lblSaveSum
            // 
            this.lblSaveSum.AutoSize = true;
            this.lblSaveSum.Location = new System.Drawing.Point(83, 196);
            this.lblSaveSum.Name = "lblSaveSum";
            this.lblSaveSum.Size = new System.Drawing.Size(78, 12);
            this.lblSaveSum.TabIndex = 0;
            this.lblSaveSum.Text = "Total Count :";
            // 
            // txtBoxSaveSum
            // 
            this.txtBoxSaveSum.Location = new System.Drawing.Point(174, 193);
            this.txtBoxSaveSum.Name = "txtBoxSaveSum";
            this.txtBoxSaveSum.Size = new System.Drawing.Size(100, 21);
            this.txtBoxSaveSum.TabIndex = 4;
            this.txtBoxSaveSum.TextChanged += new System.EventHandler(this.txtBoxSaveSum_TextChanged);
            // 
            // dtPickerSaveTime
            // 
            this.dtPickerSaveTime.Location = new System.Drawing.Point(174, 236);
            this.dtPickerSaveTime.Name = "dtPickerSaveTime";
            this.dtPickerSaveTime.Size = new System.Drawing.Size(200, 21);
            this.dtPickerSaveTime.TabIndex = 5;
            this.dtPickerSaveTime.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(203, 294);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExit.TabIndex = 3;
            this.btnSaveExit.Text = "EXIT";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtPickerSaveTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxSaveSum);
            this.Controls.Add(this.txtBoxSaveLocation);
            this.Controls.Add(this.lblSaveSum);
            this.Controls.Add(this.lblSaveTime);
            this.Controls.Add(this.lblSaveLocation);
            this.Controls.Add(this.txtBoxSaveBMSNo);
            this.Controls.Add(this.lblBMSNo);
            this.Name = "Save";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Save_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBMSNo;
        private System.Windows.Forms.TextBox txtBoxSaveBMSNo;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.TextBox txtBoxSaveLocation;
        private System.Windows.Forms.Label lblSaveTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSaveSum;
        private System.Windows.Forms.TextBox txtBoxSaveSum;
        private System.Windows.Forms.DateTimePicker dtPickerSaveTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveExit;
    }
}