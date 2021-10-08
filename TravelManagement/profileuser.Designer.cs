
namespace TravelManagement
{
    partial class profileuser
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
            this.adminmainpanel = new System.Windows.Forms.Panel();
            this.Crossbutton = new System.Windows.Forms.Button();
            this.panelforbutton = new System.Windows.Forms.Panel();
            this.Deletebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.Updatebutton = new Guna.UI.WinForms.GunaGradientButton();
            this.Booked = new Guna.UI.WinForms.GunaGradientButton();
            this.bookeduser = new TravelManagement.bookeduser();
            this.updateuser = new TravelManagement.updateuser();
            this.deleteuser = new TravelManagement.deleteuser();
            this.adminmainpanel.SuspendLayout();
            this.panelforbutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminmainpanel
            // 
            this.adminmainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminmainpanel.BackgroundImage = global::TravelManagement.Properties.Resources.admin;
            this.adminmainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminmainpanel.Controls.Add(this.bookeduser);
            this.adminmainpanel.Controls.Add(this.Crossbutton);
            this.adminmainpanel.Controls.Add(this.panelforbutton);
            this.adminmainpanel.Controls.Add(this.updateuser);
            this.adminmainpanel.Controls.Add(this.deleteuser);
            this.adminmainpanel.Location = new System.Drawing.Point(0, 0);
            this.adminmainpanel.Name = "adminmainpanel";
            this.adminmainpanel.Size = new System.Drawing.Size(857, 450);
            this.adminmainpanel.TabIndex = 1;
            // 
            // Crossbutton
            // 
            this.Crossbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Crossbutton.BackColor = System.Drawing.Color.Transparent;
            this.Crossbutton.FlatAppearance.BorderSize = 0;
            this.Crossbutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crossbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.Crossbutton.Location = new System.Drawing.Point(790, 5);
            this.Crossbutton.Name = "Crossbutton";
            this.Crossbutton.Size = new System.Drawing.Size(55, 39);
            this.Crossbutton.TabIndex = 10;
            this.Crossbutton.Text = "X";
            this.Crossbutton.UseVisualStyleBackColor = false;
            // 
            // panelforbutton
            // 
            this.panelforbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelforbutton.BackColor = System.Drawing.Color.Transparent;
            this.panelforbutton.Controls.Add(this.Deletebutton);
            this.panelforbutton.Controls.Add(this.Updatebutton);
            this.panelforbutton.Controls.Add(this.Booked);
            this.panelforbutton.Location = new System.Drawing.Point(0, 0);
            this.panelforbutton.Name = "panelforbutton";
            this.panelforbutton.Size = new System.Drawing.Size(784, 46);
            this.panelforbutton.TabIndex = 1;
            // 
            // Deletebutton
            // 
            this.Deletebutton.AnimationHoverSpeed = 0.07F;
            this.Deletebutton.AnimationSpeed = 0.03F;
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Deletebutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Deletebutton.BorderColor = System.Drawing.Color.Navy;
            this.Deletebutton.BorderSize = 1;
            this.Deletebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Deletebutton.FocusedColor = System.Drawing.Color.Empty;
            this.Deletebutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Image = null;
            this.Deletebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Deletebutton.Location = new System.Drawing.Point(347, 3);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Deletebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Deletebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Deletebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Deletebutton.OnHoverImage = null;
            this.Deletebutton.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebutton.Radius = 3;
            this.Deletebutton.Size = new System.Drawing.Size(121, 42);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.AnimationHoverSpeed = 0.07F;
            this.Updatebutton.AnimationSpeed = 0.03F;
            this.Updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.Updatebutton.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Updatebutton.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Updatebutton.BorderColor = System.Drawing.Color.Navy;
            this.Updatebutton.BorderSize = 1;
            this.Updatebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Updatebutton.FocusedColor = System.Drawing.Color.Empty;
            this.Updatebutton.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Image = null;
            this.Updatebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Updatebutton.Location = new System.Drawing.Point(178, 4);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Updatebutton.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Updatebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Updatebutton.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Updatebutton.OnHoverImage = null;
            this.Updatebutton.OnPressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.Radius = 3;
            this.Updatebutton.Size = new System.Drawing.Size(121, 42);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Booked
            // 
            this.Booked.AnimationHoverSpeed = 0.07F;
            this.Booked.AnimationSpeed = 0.03F;
            this.Booked.BackColor = System.Drawing.Color.Transparent;
            this.Booked.BaseColor1 = System.Drawing.SystemColors.AppWorkspace;
            this.Booked.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.Booked.BorderColor = System.Drawing.Color.Navy;
            this.Booked.BorderSize = 1;
            this.Booked.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Booked.FocusedColor = System.Drawing.Color.Empty;
            this.Booked.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked.ForeColor = System.Drawing.Color.White;
            this.Booked.Image = null;
            this.Booked.ImageSize = new System.Drawing.Size(20, 20);
            this.Booked.Location = new System.Drawing.Point(11, 3);
            this.Booked.Name = "Booked";
            this.Booked.OnHoverBaseColor1 = System.Drawing.Color.LightGray;
            this.Booked.OnHoverBaseColor2 = System.Drawing.Color.DarkGray;
            this.Booked.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Booked.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.Booked.OnHoverImage = null;
            this.Booked.OnPressedColor = System.Drawing.SystemColors.WindowFrame;
            this.Booked.Radius = 3;
            this.Booked.Size = new System.Drawing.Size(119, 42);
            this.Booked.TabIndex = 7;
            this.Booked.Text = "BOOKED";
            this.Booked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Booked.Click += new System.EventHandler(this.Booked_Click);
            // 
            // bookeduser
            // 
            this.bookeduser.Location = new System.Drawing.Point(7, 50);
            this.bookeduser.Name = "bookeduser";
            this.bookeduser.Size = new System.Drawing.Size(841, 392);
            this.bookeduser.TabIndex = 11;
            // 
            // updateuser
            // 
            this.updateuser.Location = new System.Drawing.Point(7, 50);
            this.updateuser.Name = "updateuser";
            this.updateuser.Size = new System.Drawing.Size(841, 392);
            this.updateuser.TabIndex = 12;
            // 
            // deleteuser
            // 
            this.deleteuser.Location = new System.Drawing.Point(7, 50);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(841, 392);
            this.deleteuser.TabIndex = 13;
            // 
            // profileuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminmainpanel);
            this.Name = "profileuser";
            this.Size = new System.Drawing.Size(857, 450);
            this.Load += new System.EventHandler(this.profileuser_Load);
            this.adminmainpanel.ResumeLayout(false);
            this.panelforbutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminmainpanel;
        private System.Windows.Forms.Button Crossbutton;
        private System.Windows.Forms.Panel panelforbutton;
        private Guna.UI.WinForms.GunaGradientButton Deletebutton;
        private Guna.UI.WinForms.GunaGradientButton Updatebutton;
        private Guna.UI.WinForms.GunaGradientButton Booked;
        private bookeduser bookeduser;
        private updateuser updateuser;
        private deleteuser deleteuser;
    }
}
