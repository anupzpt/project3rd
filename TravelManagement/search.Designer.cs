﻿
namespace TravelManagement
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.findyourdestination = new System.Windows.Forms.Label();
            this.searchbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::TravelManagement.Properties.Resources.Untitled_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.findyourdestination);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 205);
            this.panel1.TabIndex = 0;
            // 
            // findyourdestination
            // 
            this.findyourdestination.AutoSize = true;
            this.findyourdestination.BackColor = System.Drawing.Color.Transparent;
            this.findyourdestination.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findyourdestination.Location = new System.Drawing.Point(267, 33);
            this.findyourdestination.Name = "findyourdestination";
            this.findyourdestination.Size = new System.Drawing.Size(252, 26);
            this.findyourdestination.TabIndex = 5;
            this.findyourdestination.Text = "FIND YOUR DESTINATON";
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Silver;
            this.searchbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbox.BackgroundImage")));
            this.searchbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.searchbox.Icon = ((System.Drawing.Image)(resources.GetObject("searchbox.Icon")));
            this.searchbox.Location = new System.Drawing.Point(269, 116);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(250, 42);
            this.searchbox.TabIndex = 6;
            this.searchbox.text = "Search By Location";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "search";
            this.Size = new System.Drawing.Size(840, 205);
            this.Load += new System.EventHandler(this.search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox searchbox;
        private System.Windows.Forms.Label findyourdestination;
    }
}
