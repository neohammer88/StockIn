namespace StockIn
{
    partial class Login
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtBoxPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.btnRegistMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(135, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtBoxID
            // 
            this.txtBoxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxID.Location = new System.Drawing.Point(217, 97);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 21);
            this.txtBoxID.TabIndex = 0;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(135, 140);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(70, 12);
            this.lblPW.TabIndex = 0;
            this.lblPW.Text = "Password :";
            // 
            // txtBoxPW
            // 
            this.txtBoxPW.Location = new System.Drawing.Point(217, 137);
            this.txtBoxPW.Name = "txtBoxPW";
            this.txtBoxPW.Size = new System.Drawing.Size(100, 21);
            this.txtBoxPW.TabIndex = 1;
            this.txtBoxPW.TextChanged += new System.EventHandler(this.txtBoxPW_TextChanged);
            this.txtBoxPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPW_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(137, 182);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Location = new System.Drawing.Point(242, 182);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(75, 23);
            this.btnLoginExit.TabIndex = 3;
            this.btnLoginExit.Text = "EXIT";
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // btnRegistMember
            // 
            this.btnRegistMember.Location = new System.Drawing.Point(186, 226);
            this.btnRegistMember.Name = "btnRegistMember";
            this.btnRegistMember.Size = new System.Drawing.Size(75, 23);
            this.btnRegistMember.TabIndex = 4;
            this.btnRegistMember.Text = "Regist";
            this.btnRegistMember.UseVisualStyleBackColor = true;
            this.btnRegistMember.Click += new System.EventHandler(this.btnRegistMember_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistMember);
            this.Controls.Add(this.btnLoginExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPW);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblName);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtBoxPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginExit;
        private System.Windows.Forms.Button btnRegistMember;
    }
}