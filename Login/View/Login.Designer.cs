using System;

namespace Login
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
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.txtboxPassWord = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labeliRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.Location = new System.Drawing.Point(192, 117);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(210, 20);
            this.txtboxUserName.TabIndex = 0;
            // 
            // txtboxPassWord
            // 
            this.txtboxPassWord.Location = new System.Drawing.Point(192, 169);
            this.txtboxPassWord.Name = "txtboxPassWord";
            this.txtboxPassWord.PasswordChar = '*';
            this.txtboxPassWord.Size = new System.Drawing.Size(210, 20);
            this.txtboxPassWord.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(115, 117);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(55, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Username";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Location = new System.Drawing.Point(115, 169);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(53, 13);
            this.labelPassWord.TabIndex = 3;
            this.labelPassWord.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(249, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
            // 
            // labeliRes
            // 
            this.labeliRes.AutoSize = true;
            this.labeliRes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.labeliRes.Location = new System.Drawing.Point(258, 45);
            this.labeliRes.Name = "labeliRes";
            this.labeliRes.Size = new System.Drawing.Size(85, 37);
            this.labeliRes.TabIndex = 5;
            this.labeliRes.Text = "iRes";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 355);
            this.Controls.Add(this.labeliRes);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.txtboxPassWord);
            this.Controls.Add(this.txtboxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iRes";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.TextBox txtboxPassWord;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labeliRes;
    }
}

