
namespace TravelManagement
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loggedin1 = new TravelManagement.loggedin();
            this.SuspendLayout();
            // 
            // loggedin1
            // 
            this.loggedin1.BackColor = System.Drawing.Color.Silver;
            this.loggedin1.Location = new System.Drawing.Point(0, 0);
            this.loggedin1.Name = "loggedin1";
            this.loggedin1.Size = new System.Drawing.Size(370, 355);
            this.loggedin1.TabIndex = 0;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.loggedin1);
            this.Name = "login";
            this.Size = new System.Drawing.Size(370, 355);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private loggedin loggedin1;
    }
}
