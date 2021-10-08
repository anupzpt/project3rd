
namespace TravelManagement
{
    partial class afterloggedadmin
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
            this.components = new System.ComponentModel.Container();
            this.admindetail = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.addadmin = new Guna.UI.WinForms.GunaButton();
            this.adminlabel = new System.Windows.Forms.Label();
            this.logoutbutton = new Guna.UI.WinForms.GunaButton();
            this.passwordbutton = new Guna.UI.WinForms.GunaButton();
            this.emailbutton = new Guna.UI.WinForms.GunaButton();
            this.bookeddatabutton = new Guna.UI.WinForms.GunaButton();
            this.Refreshhtimer = new System.Windows.Forms.Timer(this.components);
            this.admindetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // admindetail
            // 
            this.admindetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admindetail.BackColor = System.Drawing.Color.Transparent;
            this.admindetail.Controls.Add(this.addadmin);
            this.admindetail.Controls.Add(this.adminlabel);
            this.admindetail.Controls.Add(this.logoutbutton);
            this.admindetail.Controls.Add(this.passwordbutton);
            this.admindetail.Controls.Add(this.emailbutton);
            this.admindetail.Controls.Add(this.bookeddatabutton);
            this.admindetail.FillColor = System.Drawing.Color.Lavender;
            this.admindetail.Location = new System.Drawing.Point(0, 3);
            this.admindetail.Name = "admindetail";
            this.admindetail.ShadowColor = System.Drawing.Color.Black;
            this.admindetail.Size = new System.Drawing.Size(291, 330);
            this.admindetail.TabIndex = 17;
            // 
            // addadmin
            // 
            this.addadmin.AnimationHoverSpeed = 0.07F;
            this.addadmin.AnimationSpeed = 0.03F;
            this.addadmin.BackColor = System.Drawing.Color.Transparent;
            this.addadmin.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.addadmin.BorderColor = System.Drawing.Color.Transparent;
            this.addadmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addadmin.FocusedColor = System.Drawing.Color.Empty;
            this.addadmin.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addadmin.ForeColor = System.Drawing.Color.White;
            this.addadmin.Image = global::TravelManagement.Properties.Resources.addadmin;
            this.addadmin.ImageSize = new System.Drawing.Size(20, 20);
            this.addadmin.Location = new System.Drawing.Point(29, 64);
            this.addadmin.Name = "addadmin";
            this.addadmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addadmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addadmin.OnHoverForeColor = System.Drawing.Color.White;
            this.addadmin.OnHoverImage = null;
            this.addadmin.OnPressedColor = System.Drawing.Color.Black;
            this.addadmin.Radius = 2;
            this.addadmin.Size = new System.Drawing.Size(230, 42);
            this.addadmin.TabIndex = 5;
            this.addadmin.Text = "ADD ADMIN";
            this.addadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adminlabel
            // 
            this.adminlabel.AutoSize = true;
            this.adminlabel.Font = new System.Drawing.Font("Playfair Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlabel.Location = new System.Drawing.Point(83, 14);
            this.adminlabel.Name = "adminlabel";
            this.adminlabel.Size = new System.Drawing.Size(98, 32);
            this.adminlabel.TabIndex = 4;
            this.adminlabel.Text = "ADMIN";
            // 
            // logoutbutton
            // 
            this.logoutbutton.AnimationHoverSpeed = 0.07F;
            this.logoutbutton.AnimationSpeed = 0.03F;
            this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.logoutbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutbutton.BorderColor = System.Drawing.Color.Transparent;
            this.logoutbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutbutton.FocusedColor = System.Drawing.Color.Empty;
            this.logoutbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Image = global::TravelManagement.Properties.Resources.logout;
            this.logoutbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.logoutbutton.Location = new System.Drawing.Point(29, 273);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.logoutbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.logoutbutton.OnHoverImage = null;
            this.logoutbutton.OnPressedColor = System.Drawing.Color.Black;
            this.logoutbutton.Radius = 2;
            this.logoutbutton.Size = new System.Drawing.Size(230, 42);
            this.logoutbutton.TabIndex = 3;
            this.logoutbutton.Text = "LOG OUT";
            this.logoutbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordbutton
            // 
            this.passwordbutton.AnimationHoverSpeed = 0.07F;
            this.passwordbutton.AnimationSpeed = 0.03F;
            this.passwordbutton.BackColor = System.Drawing.Color.Transparent;
            this.passwordbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.passwordbutton.BorderColor = System.Drawing.Color.Transparent;
            this.passwordbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.passwordbutton.FocusedColor = System.Drawing.Color.Empty;
            this.passwordbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbutton.ForeColor = System.Drawing.Color.White;
            this.passwordbutton.Image = global::TravelManagement.Properties.Resources.key;
            this.passwordbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.passwordbutton.Location = new System.Drawing.Point(29, 222);
            this.passwordbutton.Name = "passwordbutton";
            this.passwordbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.passwordbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.passwordbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.passwordbutton.OnHoverImage = null;
            this.passwordbutton.OnPressedColor = System.Drawing.Color.Black;
            this.passwordbutton.Radius = 2;
            this.passwordbutton.Size = new System.Drawing.Size(230, 42);
            this.passwordbutton.TabIndex = 2;
            this.passwordbutton.Text = "PASSWORD";
            this.passwordbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordbutton.Click += new System.EventHandler(this.passwordbutton_Click);
            // 
            // emailbutton
            // 
            this.emailbutton.AnimationHoverSpeed = 0.07F;
            this.emailbutton.AnimationSpeed = 0.03F;
            this.emailbutton.BackColor = System.Drawing.Color.Transparent;
            this.emailbutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.emailbutton.BorderColor = System.Drawing.Color.Transparent;
            this.emailbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.emailbutton.FocusedColor = System.Drawing.Color.Empty;
            this.emailbutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbutton.ForeColor = System.Drawing.Color.White;
            this.emailbutton.Image = global::TravelManagement.Properties.Resources.sendemail;
            this.emailbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.emailbutton.Location = new System.Drawing.Point(29, 169);
            this.emailbutton.Name = "emailbutton";
            this.emailbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.emailbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.emailbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.emailbutton.OnHoverImage = null;
            this.emailbutton.OnPressedColor = System.Drawing.Color.Black;
            this.emailbutton.Radius = 2;
            this.emailbutton.Size = new System.Drawing.Size(230, 42);
            this.emailbutton.TabIndex = 1;
            this.emailbutton.Text = "EMAIL";
            this.emailbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookeddatabutton
            // 
            this.bookeddatabutton.AnimationHoverSpeed = 0.07F;
            this.bookeddatabutton.AnimationSpeed = 0.03F;
            this.bookeddatabutton.BackColor = System.Drawing.Color.Transparent;
            this.bookeddatabutton.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.bookeddatabutton.BorderColor = System.Drawing.Color.Transparent;
            this.bookeddatabutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bookeddatabutton.FocusedColor = System.Drawing.Color.Empty;
            this.bookeddatabutton.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookeddatabutton.ForeColor = System.Drawing.Color.White;
            this.bookeddatabutton.Image = global::TravelManagement.Properties.Resources.viewdetail;
            this.bookeddatabutton.ImageSize = new System.Drawing.Size(20, 20);
            this.bookeddatabutton.Location = new System.Drawing.Point(29, 116);
            this.bookeddatabutton.Name = "bookeddatabutton";
            this.bookeddatabutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bookeddatabutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bookeddatabutton.OnHoverForeColor = System.Drawing.Color.White;
            this.bookeddatabutton.OnHoverImage = null;
            this.bookeddatabutton.OnPressedColor = System.Drawing.Color.Black;
            this.bookeddatabutton.Radius = 2;
            this.bookeddatabutton.Size = new System.Drawing.Size(230, 42);
            this.bookeddatabutton.TabIndex = 0;
            this.bookeddatabutton.Text = "BOOKED DATA";
            this.bookeddatabutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Refreshhtimer
            // 
            this.Refreshhtimer.Tick += new System.EventHandler(this.Refreshhtimer_Tick);
            // 
            // afterloggedadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.admindetail);
            this.Name = "afterloggedadmin";
            this.Size = new System.Drawing.Size(291, 333);
            this.Load += new System.EventHandler(this.afterloggedadmin_Load);
            this.admindetail.ResumeLayout(false);
            this.admindetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel admindetail;
        private Guna.UI.WinForms.GunaButton bookeddatabutton;
        private Guna.UI.WinForms.GunaButton logoutbutton;
        private Guna.UI.WinForms.GunaButton passwordbutton;
        private Guna.UI.WinForms.GunaButton emailbutton;
        private System.Windows.Forms.Label adminlabel;
        private Guna.UI.WinForms.GunaButton addadmin;
        private System.Windows.Forms.Timer Refreshhtimer;
    }
}
