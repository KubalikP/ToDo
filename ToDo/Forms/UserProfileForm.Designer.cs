using ComponentFactory.Krypton.Toolkit;

namespace ToDo
{
    public partial class UserProfileForm : KryptonForm
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
            this.newUsernameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.changeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.newPasswordTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::ToDo.Properties.Resources.icons8_close_241;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::ToDo.Properties.Resources.icons8_maximize_window_241;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::ToDo.Properties.Resources.icons8_minimize_241;
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
            // newUsernameTextBox
            // 
            this.newUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newUsernameTextBox.Location = new System.Drawing.Point(171, 136);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(230, 32);
            this.newUsernameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.newUsernameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.newUsernameTextBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.newUsernameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newUsernameTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.newUsernameTextBox.StateCommon.Border.Rounding = 20;
            this.newUsernameTextBox.StateCommon.Border.Width = 1;
            this.newUsernameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.newUsernameTextBox.StateCommon.Content.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newUsernameTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.newUsernameTextBox.TabIndex = 0;
            this.newUsernameTextBox.Text = "New username";
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Location = new System.Drawing.Point(220, 251);
            this.changeButton.Name = "changeButton";
            this.changeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.OverrideDefault.Back.ColorAngle = 45F;
            this.changeButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.OverrideDefault.Border.ColorAngle = 45F;
            this.changeButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.changeButton.OverrideDefault.Border.Rounding = 20;
            this.changeButton.OverrideDefault.Border.Width = 1;
            this.changeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.changeButton.Size = new System.Drawing.Size(130, 37);
            this.changeButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.StateCommon.Back.ColorAngle = 45F;
            this.changeButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.changeButton.StateCommon.Border.ColorAngle = 45F;
            this.changeButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.changeButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.changeButton.StateCommon.Border.Rounding = 20;
            this.changeButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.changeButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.changeButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.changeButton.TabIndex = 1;
            this.changeButton.Values.Text = "Change";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTextBox.Location = new System.Drawing.Point(171, 198);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(230, 32);
            this.newPasswordTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.newPasswordTextBox.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.newPasswordTextBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.newPasswordTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newPasswordTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.newPasswordTextBox.StateCommon.Border.Rounding = 20;
            this.newPasswordTextBox.StateCommon.Border.Width = 1;
            this.newPasswordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.newPasswordTextBox.StateCommon.Content.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newPasswordTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.newPasswordTextBox.TabIndex = 7;
            this.newPasswordTextBox.Text = "New password";
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.ErrorImage = null;
            this.userPicture.Image = global::ToDo.Properties.Resources.user11;
            this.userPicture.InitialImage = null;
            this.userPicture.Location = new System.Drawing.Point(246, 40);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(80, 80);
            this.userPicture.TabIndex = 8;
            this.userPicture.TabStop = false;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(577, 390);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newUsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserProfileForm";
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newUsernameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton changeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newPasswordTextBox;
        private System.Windows.Forms.PictureBox userPicture;
    }
}