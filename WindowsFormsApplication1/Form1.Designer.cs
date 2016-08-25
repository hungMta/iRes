namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.clickme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickme
            // 
            this.clickme.Location = new System.Drawing.Point(149, 245);
            this.clickme.Name = "clickme";
            this.clickme.Size = new System.Drawing.Size(75, 23);
            this.clickme.TabIndex = 0;
            this.clickme.Text = "Click me!";
            this.clickme.UseVisualStyleBackColor = true;
            this.clickme.Click += new System.EventHandler(this.clickme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 355);
            this.Controls.Add(this.clickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickme;
    }
}

