﻿
namespace TravelManagement
{
    partial class special
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
            this.panel = new System.Windows.Forms.Panel();
            this.left = new Guna.UI.WinForms.GunaImageButton();
            this.right = new Guna.UI.WinForms.GunaImageButton();
            this.experiencetext = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.left);
            this.panel.Controls.Add(this.right);
            this.panel.Controls.Add(this.experiencetext);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(840, 400);
            this.panel.TabIndex = 1;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.BackgroundImage = global::TravelManagement.Properties.Resources.left;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left.DialogResult = System.Windows.Forms.DialogResult.None;
            this.left.Image = null;
            this.left.ImageSize = new System.Drawing.Size(64, 64);
            this.left.Location = new System.Drawing.Point(12, 181);
            this.left.Name = "left";
            this.left.OnHoverImage = null;
            this.left.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.left.Size = new System.Drawing.Size(36, 39);
            this.left.TabIndex = 29;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.BackgroundImage = global::TravelManagement.Properties.Resources.right;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right.DialogResult = System.Windows.Forms.DialogResult.None;
            this.right.Image = null;
            this.right.ImageSize = new System.Drawing.Size(64, 64);
            this.right.Location = new System.Drawing.Point(792, 181);
            this.right.Name = "right";
            this.right.OnHoverImage = null;
            this.right.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.right.Size = new System.Drawing.Size(36, 39);
            this.right.TabIndex = 28;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // experiencetext
            // 
            this.experiencetext.AutoSize = true;
            this.experiencetext.BackColor = System.Drawing.Color.Transparent;
            this.experiencetext.Font = new System.Drawing.Font("Franklin Gothic Demi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experiencetext.ForeColor = System.Drawing.Color.White;
            this.experiencetext.Location = new System.Drawing.Point(302, 206);
            this.experiencetext.Name = "experiencetext";
            this.experiencetext.Size = new System.Drawing.Size(300, 366);
            this.experiencetext.TabIndex = 0;
            this.experiencetext.Text = "EXPERIENCE\r\n    WORLD\r\n   WITH US\r\n   \r\n\r\n           ";
            // 
            // special
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "special";
            this.Size = new System.Drawing.Size(840, 400);
            this.Load += new System.EventHandler(this.special_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label experiencetext;
        private Guna.UI.WinForms.GunaImageButton left;
        private Guna.UI.WinForms.GunaImageButton right;
    }
}
