namespace TravelManagement
{
    partial class Contactus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contactustext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::TravelManagement.Properties.Resources.planning__a_group_trip;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.contactustext);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 400);
            this.panel1.TabIndex = 0;
            // 
            // contactustext
            // 
            this.contactustext.AutoSize = true;
            this.contactustext.BackColor = System.Drawing.Color.Transparent;
            this.contactustext.Font = new System.Drawing.Font("Franklin Gothic Demi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactustext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.contactustext.Location = new System.Drawing.Point(323, 169);
            this.contactustext.Name = "contactustext";
            this.contactustext.Size = new System.Drawing.Size(245, 47);
            this.contactustext.TabIndex = 0;
            this.contactustext.Text = "CONTACT US";
            // 
            // Contactus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Contactus";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.Contactus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label contactustext;
    }
}
