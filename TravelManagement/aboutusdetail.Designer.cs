
namespace TravelManagement
{
    partial class aboutusdetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutusdetail));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.aboutustext = new System.Windows.Forms.Label();
            this.imagepanel = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.imagepanel);
            this.guna2ShadowPanel1.Controls.Add(this.aboutustext);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(20, 20);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DarkGreen;
            this.guna2ShadowPanel1.ShadowDepth = 200;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(743, 389);
            this.guna2ShadowPanel1.TabIndex = 14;
            // 
            // aboutustext
            // 
            this.aboutustext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutustext.AutoSize = true;
            this.aboutustext.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutustext.Location = new System.Drawing.Point(20, 50);
            this.aboutustext.Name = "aboutustext";
            this.aboutustext.Size = new System.Drawing.Size(718, 286);
            this.aboutustext.TabIndex = 0;
            this.aboutustext.Text = resources.GetString("aboutustext.Text");
            // 
            // imagepanel
            // 
            this.imagepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagepanel.BackgroundImage = global::TravelManagement.Properties.Resources.team;
            this.imagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagepanel.Location = new System.Drawing.Point(269, 3);
            this.imagepanel.Name = "imagepanel";
            this.imagepanel.Size = new System.Drawing.Size(469, 372);
            this.imagepanel.TabIndex = 1;
            // 
            // aboutusdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "aboutusdetail";
            this.Size = new System.Drawing.Size(840, 430);
            this.Load += new System.EventHandler(this.aboutusdetail_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label aboutustext;
        private System.Windows.Forms.Panel imagepanel;
    }
}
