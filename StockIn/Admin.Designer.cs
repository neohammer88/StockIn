namespace StockIn
{
    partial class Admin
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
            this.lblAdminID = new System.Windows.Forms.Label();
            this.txtBoxAdminID = new System.Windows.Forms.TextBox();
            this.lblAdminPW = new System.Windows.Forms.Label();
            this.txtBoxAdminPW = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnAdminExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Location = new System.Drawing.Point(172, 112);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(64, 12);
            this.lblAdminID.TabIndex = 0;
            this.lblAdminID.Text = "Admin ID :";
            // 
            // txtBoxAdminID
            // 
            this.txtBoxAdminID.Location = new System.Drawing.Point(274, 109);
            this.txtBoxAdminID.Name = "txtBoxAdminID";
            this.txtBoxAdminID.Size = new System.Drawing.Size(100, 21);
            this.txtBoxAdminID.TabIndex = 0;
            // 
            // lblAdminPW
            // 
            this.lblAdminPW.AutoSize = true;
            this.lblAdminPW.Location = new System.Drawing.Point(172, 155);
            this.lblAdminPW.Name = "lblAdminPW";
            this.lblAdminPW.Size = new System.Drawing.Size(71, 12);
            this.lblAdminPW.TabIndex = 0;
            this.lblAdminPW.Text = "Admin PW :";
            // 
            // txtBoxAdminPW
            // 
            this.txtBoxAdminPW.Location = new System.Drawing.Point(274, 152);
            this.txtBoxAdminPW.Name = "txtBoxAdminPW";
            this.txtBoxAdminPW.Size = new System.Drawing.Size(100, 21);
            this.txtBoxAdminPW.TabIndex = 1;
            this.txtBoxAdminPW.TextChanged += new System.EventHandler(this.txtBoxAdminPW_TextChanged);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(185, 218);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "LOG IN";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnAdminExit
            // 
            this.btnAdminExit.Location = new System.Drawing.Point(287, 218);
            this.btnAdminExit.Name = "btnAdminExit";
            this.btnAdminExit.Size = new System.Drawing.Size(75, 23);
            this.btnAdminExit.TabIndex = 3;
            this.btnAdminExit.Text = "EXIT";
            this.btnAdminExit.UseVisualStyleBackColor = true;
            this.btnAdminExit.Click += new System.EventHandler(this.btnAdminExit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminExit);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.txtBoxAdminPW);
            this.Controls.Add(this.lblAdminPW);
            this.Controls.Add(this.txtBoxAdminID);
            this.Controls.Add(this.lblAdminID);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.TextBox txtBoxAdminID;
        private System.Windows.Forms.Label lblAdminPW;
        private System.Windows.Forms.TextBox txtBoxAdminPW;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnAdminExit;
    }
}