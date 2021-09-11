
namespace TravelManagement
{
    partial class loggedin
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.passwordtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.usertextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.loginbutton = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaPanel1);
            this.panel1.Controls.Add(this.passwordtextbox);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaCircleButton1);
            this.panel1.Controls.Add(this.usertextbox);
            this.panel1.Controls.Add(this.gunaShadowPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 355);
            this.panel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLinkLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(2, 318);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(367, 36);
            this.gunaPanel1.TabIndex = 7;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.Location = new System.Drawing.Point(88, 10);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(189, 15);
            this.gunaLinkLabel1.TabIndex = 0;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Dont Have Account? Register Here";
            this.gunaLinkLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaLinkLabel1_MouseDown);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtextbox.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordtextbox.HintText = "";
            this.passwordtextbox.isPassword = true;
            this.passwordtextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passwordtextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.passwordtextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passwordtextbox.LineThickness = 2;
            this.passwordtextbox.Location = new System.Drawing.Point(100, 175);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(225, 44);
            this.passwordtextbox.TabIndex = 4;
            this.passwordtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(135, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "LOGIN";
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.SystemColors.Info;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::TravelManagement.Properties.Resources.icons8_user_96;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(28, 96);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.TabIndex = 2;
            // 
            // usertextbox
            // 
            this.usertextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertextbox.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usertextbox.HintForeColor = System.Drawing.Color.Empty;
            this.usertextbox.HintText = "";
            this.usertextbox.isPassword = false;
            this.usertextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.usertextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.usertextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usertextbox.LineThickness = 2;
            this.usertextbox.Location = new System.Drawing.Point(100, 98);
            this.usertextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(225, 44);
            this.usertextbox.TabIndex = 1;
            this.usertextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.Controls.Add(this.loginbutton);
            this.gunaShadowPanel1.Controls.Add(this.gunaCircleButton2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(18, 79);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Navy;
            this.gunaShadowPanel1.ShadowDepth = 200;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(331, 233);
            this.gunaShadowPanel1.TabIndex = 6;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.SystemColors.Info;
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = global::TravelManagement.Properties.Resources.locked;
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.Location = new System.Drawing.Point(13, 90);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.TabIndex = 3;
            // 
            // loginbutton
            // 
            this.loginbutton.AnimationHoverSpeed = 0.07F;
            this.loginbutton.AnimationSpeed = 0.03F;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbutton.BaseColor = System.Drawing.Color.Gray;
            this.loginbutton.BorderColor = System.Drawing.Color.Black;
            this.loginbutton.BorderSize = 3;
            this.loginbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginbutton.FocusedColor = System.Drawing.Color.Empty;
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Image = null;
            this.loginbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginbutton.Location = new System.Drawing.Point(118, 165);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginbutton.OnHoverImage = null;
            this.loginbutton.OnPressedColor = System.Drawing.Color.Black;
            this.loginbutton.Radius = 5;
            this.loginbutton.Size = new System.Drawing.Size(94, 45);
            this.loginbutton.TabIndex = 9;
            this.loginbutton.Text = "Login";
            this.loginbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // loggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "loggedin";
            this.Size = new System.Drawing.Size(370, 355);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usertextbox;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordtextbox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaButton loginbutton;
    }
}
