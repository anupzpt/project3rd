
namespace TravelManagement
{
    partial class Homepageusercontrol
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
            this.homepage = new TravelManagement.homepage();
            this.rara = new TravelManagement.rara();
            this.hiking = new TravelManagement.hiking();
            this.explorenepal = new TravelManagement.explorenepal();
            this.search = new TravelManagement.search();
            this.lastpanel = new TravelManagement.lastpanel();
            this.SuspendLayout();
            // 
            // homepage
            // 
            this.homepage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepage.Location = new System.Drawing.Point(0, 0);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(857, 400);
            this.homepage.TabIndex = 0;
            // 
            // rara
            // 
            this.rara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rara.Location = new System.Drawing.Point(0, 0);
            this.rara.Name = "rara";
            this.rara.Size = new System.Drawing.Size(857, 222);
            this.rara.TabIndex = 4;
            // 
            // hiking
            // 
            this.hiking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiking.Location = new System.Drawing.Point(0, 0);
            this.hiking.Name = "hiking";
            this.hiking.Size = new System.Drawing.Size(857, 376);
            this.hiking.TabIndex = 3;
            // 
            // explorenepal
            // 
            this.explorenepal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explorenepal.Location = new System.Drawing.Point(0, 0);
            this.explorenepal.Name = "explorenepal";
            this.explorenepal.Size = new System.Drawing.Size(872, 376);
            this.explorenepal.TabIndex = 2;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(857, 205);
            this.search.TabIndex = 1;
            // 
            // lastpanel
            // 
            this.lastpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastpanel.Location = new System.Drawing.Point(0, 0);
            this.lastpanel.Name = "lastpanel";
            this.lastpanel.Size = new System.Drawing.Size(840, 203);
            this.lastpanel.TabIndex = 5;
            // 
            // Homepageusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.homepage);
            this.Controls.Add(this.rara);
            this.Controls.Add(this.hiking);
            this.Controls.Add(this.explorenepal);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lastpanel);
            this.Name = "Homepageusercontrol";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.homepageusercontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private homepage homepage;
        private search search;
        private explorenepal explorenepal;
        private hiking hiking;
        private rara rara;
        private lastpanel lastpanel;
    }
}
