
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logincircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Admin = new Guna.UI2.WinForms.Guna2Button();
            this.User = new Guna.UI2.WinForms.Guna2Button();
            this.crossbutton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.loggedin = new TravelManagement.loggedin();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::TravelManagement.Properties.Resources.icons8_user_96;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(130, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 94);
            this.panel1.TabIndex = 1;
            // 
            // logincircle
            // 
            this.logincircle.BorderThickness = 1;
            this.logincircle.CheckedState.Parent = this.logincircle;
            this.logincircle.CustomImages.Parent = this.logincircle;
            this.logincircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logincircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logincircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logincircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logincircle.DisabledState.Parent = this.logincircle;
            this.logincircle.FillColor = System.Drawing.Color.White;
            this.logincircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logincircle.ForeColor = System.Drawing.Color.White;
            this.logincircle.HoverState.Parent = this.logincircle;
            this.logincircle.Location = new System.Drawing.Point(105, 24);
            this.logincircle.Name = "logincircle";
            this.logincircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logincircle.ShadowDecoration.Parent = this.logincircle;
            this.logincircle.Size = new System.Drawing.Size(148, 148);
            this.logincircle.TabIndex = 0;
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.BorderColor = System.Drawing.Color.White;
            this.Admin.BorderRadius = 10;
            this.Admin.BorderThickness = 2;
            this.Admin.CheckedState.Parent = this.Admin;
            this.Admin.CustomImages.Parent = this.Admin;
            this.Admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Admin.DisabledState.Parent = this.Admin;
            this.Admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Admin.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.HoverState.Parent = this.Admin;
            this.Admin.Location = new System.Drawing.Point(26, 238);
            this.Admin.Name = "Admin";
            this.Admin.ShadowDecoration.Parent = this.Admin;
            this.Admin.Size = new System.Drawing.Size(138, 46);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Admin";
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.BorderColor = System.Drawing.Color.White;
            this.User.BorderRadius = 10;
            this.User.BorderThickness = 2;
            this.User.CheckedState.Parent = this.User;
            this.User.CustomImages.Parent = this.User;
            this.User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.User.DisabledState.Parent = this.User;
            this.User.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.User.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.HoverState.Parent = this.User;
            this.User.Location = new System.Drawing.Point(192, 237);
            this.User.Name = "User";
            this.User.ShadowDecoration.Parent = this.User;
            this.User.Size = new System.Drawing.Size(138, 46);
            this.User.TabIndex = 5;
            this.User.Text = "User";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // crossbutton
            // 
            this.crossbutton.CheckedState.Parent = this.crossbutton;
            this.crossbutton.CustomImages.Parent = this.crossbutton;
            this.crossbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.crossbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.crossbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.crossbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.crossbutton.DisabledState.Parent = this.crossbutton;
            this.crossbutton.FillColor = System.Drawing.Color.Gainsboro;
            this.crossbutton.Font = new System.Drawing.Font("Playfair Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossbutton.ForeColor = System.Drawing.Color.Red;
            this.crossbutton.HoverState.Parent = this.crossbutton;
            this.crossbutton.Location = new System.Drawing.Point(326, 3);
            this.crossbutton.Name = "crossbutton";
            this.crossbutton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crossbutton.ShadowDecoration.Parent = this.crossbutton;
            this.crossbutton.Size = new System.Drawing.Size(36, 34);
            this.crossbutton.TabIndex = 7;
            this.crossbutton.Text = "X";
            this.crossbutton.Click += new System.EventHandler(this.crossbutton_Click);
            // 
            // loggedin
            // 
            this.loggedin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedin.BackColor = System.Drawing.Color.Silver;
            this.loggedin.Location = new System.Drawing.Point(0, 0);
            this.loggedin.Name = "loggedin";
            this.loggedin.Size = new System.Drawing.Size(370, 355);
            this.loggedin.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.crossbutton);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logincircle);
            this.Controls.Add(this.loggedin);
            this.Name = "login";
            this.Size = new System.Drawing.Size(370, 355);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton logincircle;
        private Guna.UI2.WinForms.Guna2Button Admin;
        private Guna.UI2.WinForms.Guna2Button User;
        private loggedin loggedin;
        private Guna.UI2.WinForms.Guna2CircleButton crossbutton;
    }
}
