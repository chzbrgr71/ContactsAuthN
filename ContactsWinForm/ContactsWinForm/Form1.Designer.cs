namespace ContactsWinForm
{
    partial class frmContacts
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
            this.btnContacts = new System.Windows.Forms.Button();
            this.txtContacts = new System.Windows.Forms.TextBox();
            this.browser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(29, 13);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(123, 35);
            this.btnContacts.TabIndex = 0;
            this.btnContacts.Text = "Get Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // txtContacts
            // 
            this.txtContacts.Location = new System.Drawing.Point(29, 67);
            this.txtContacts.Multiline = true;
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(262, 93);
            this.txtContacts.TabIndex = 1;
            // 
            // browser1
            // 
            this.browser1.Location = new System.Drawing.Point(29, 180);
            this.browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser1.Name = "browser1";
            this.browser1.Size = new System.Drawing.Size(332, 250);
            this.browser1.TabIndex = 2;
            this.browser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser1_DocumentCompleted);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 470);
            this.Controls.Add(this.browser1);
            this.Controls.Add(this.txtContacts);
            this.Controls.Add(this.btnContacts);
            this.Name = "frmContacts";
            this.Text = "Brian\'s Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.TextBox txtContacts;
        private System.Windows.Forms.WebBrowser browser1;
    }
}

