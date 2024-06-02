using ComponentFactory.Krypton.Toolkit;

namespace ToDo
{
    public partial class LoginForm : KryptonForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.usernameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.loginButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.registerButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.passwordTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rememberMeCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.offlineButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::ToDo.Properties.Resources.icons8_close_24;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::ToDo.Properties.Resources.icons8_maximize_window_24;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::ToDo.Properties.Resources.icons8_minimize_24;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 0F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 8, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Location = new System.Drawing.Point(291, 158);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(230, 32);
            this.usernameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.usernameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.usernameTextBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.usernameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.usernameTextBox.StateCommon.Border.Rounding = 20;
            this.usernameTextBox.StateCommon.Border.Width = 1;
            this.usernameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.usernameTextBox.StateCommon.Content.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.usernameTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Location = new System.Drawing.Point(291, 287);
            this.loginButton.Name = "loginButton";
            this.loginButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.OverrideDefault.Back.ColorAngle = 45F;
            this.loginButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.OverrideDefault.Border.ColorAngle = 45F;
            this.loginButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.OverrideDefault.Border.Rounding = 20;
            this.loginButton.OverrideDefault.Border.Width = 1;
            this.loginButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.loginButton.Size = new System.Drawing.Size(80, 37);
            this.loginButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.StateCommon.Back.ColorAngle = 45F;
            this.loginButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.StateCommon.Border.ColorAngle = 45F;
            this.loginButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginButton.StateCommon.Border.Rounding = 20;
            this.loginButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.loginButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.loginButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginButton.TabIndex = 1;
            this.loginButton.Values.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Location = new System.Drawing.Point(441, 287);
            this.registerButton.Name = "registerButton";
            this.registerButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.OverrideDefault.Back.ColorAngle = 45F;
            this.registerButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.OverrideDefault.Border.ColorAngle = 45F;
            this.registerButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registerButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registerButton.OverrideDefault.Border.Rounding = 20;
            this.registerButton.OverrideDefault.Border.Width = 1;
            this.registerButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.registerButton.Size = new System.Drawing.Size(80, 37);
            this.registerButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.StateCommon.Back.ColorAngle = 45F;
            this.registerButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.registerButton.StateCommon.Border.ColorAngle = 45F;
            this.registerButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registerButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registerButton.StateCommon.Border.Rounding = 20;
            this.registerButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.registerButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.registerButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerButton.TabIndex = 6;
            this.registerButton.Values.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Location = new System.Drawing.Point(291, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(230, 32);
            this.passwordTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordTextBox.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.passwordTextBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.passwordTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordTextBox.StateCommon.Border.Rounding = 20;
            this.passwordTextBox.StateCommon.Border.Width = 1;
            this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordTextBox.StateCommon.Content.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "Password";
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.Location = new System.Drawing.Point(359, 259);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(104, 20);
            this.rememberMeCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.rememberMeCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.rememberMeCheckBox.TabIndex = 9;
            this.rememberMeCheckBox.Values.Text = "Remember me";
            this.rememberMeCheckBox.CheckedChanged += new System.EventHandler(this.rememberMeCheckBox_CheckedChanged);
            // 
            // userPicture
            // 
            this.userPicture.ErrorImage = null;
            this.userPicture.Image = global::ToDo.Properties.Resources.user14;
            this.userPicture.InitialImage = null;
            this.userPicture.Location = new System.Drawing.Point(366, 62);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(80, 80);
            this.userPicture.TabIndex = 8;
            this.userPicture.TabStop = false;
            // 
            // offlineButton
            // 
            this.offlineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offlineButton.Location = new System.Drawing.Point(682, 12);
            this.offlineButton.Name = "offlineButton";
            this.offlineButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.OverrideDefault.Back.ColorAngle = 45F;
            this.offlineButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.OverrideDefault.Border.ColorAngle = 45F;
            this.offlineButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.offlineButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.offlineButton.OverrideDefault.Border.Rounding = 20;
            this.offlineButton.OverrideDefault.Border.Width = 1;
            this.offlineButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.offlineButton.Size = new System.Drawing.Size(106, 37);
            this.offlineButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.StateCommon.Back.ColorAngle = 45F;
            this.offlineButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.offlineButton.StateCommon.Border.ColorAngle = 45F;
            this.offlineButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.offlineButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.offlineButton.StateCommon.Border.Rounding = 20;
            this.offlineButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.offlineButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.offlineButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.offlineButton.TabIndex = 10;
            this.offlineButton.Values.Text = "Offline mode";
            this.offlineButton.Click += new System.EventHandler(this.offlineButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.offlineButton);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do";
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton registerButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordTextBox;
        private System.Windows.Forms.PictureBox userPicture;
        private KryptonCheckBox rememberMeCheckBox;
        private KryptonButton offlineButton;
    }
}