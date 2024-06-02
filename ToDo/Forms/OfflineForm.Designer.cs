using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ToDo
{
    partial class OfflineForm : KryptonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.taskTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.removeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Calendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.searchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.StartDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.taskTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.removeAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.navigationBar = new System.Windows.Forms.MenuStrip();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.taskTable)).BeginInit();
            this.panel.SuspendLayout();
            this.navigationBar.SuspendLayout();
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
            // taskTextBox
            // 
            this.taskTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskTextBox.Location = new System.Drawing.Point(325, 9);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(202, 32);
            this.taskTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.taskTextBox.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.taskTextBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.taskTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.taskTextBox.StateCommon.Border.Rounding = 20;
            this.taskTextBox.StateCommon.Border.Width = 1;
            this.taskTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.taskTextBox.StateCommon.Content.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.taskTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.taskTextBox.TabIndex = 0;
            this.taskTextBox.Text = "Enter your task";
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(598, 7);
            this.addButton.Name = "addButton";
            this.addButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.OverrideDefault.Back.ColorAngle = 45F;
            this.addButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.OverrideDefault.Border.ColorAngle = 45F;
            this.addButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addButton.OverrideDefault.Border.Rounding = 20;
            this.addButton.OverrideDefault.Border.Width = 1;
            this.addButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addButton.Size = new System.Drawing.Size(51, 37);
            this.addButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.StateCommon.Back.ColorAngle = 45F;
            this.addButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.addButton.StateCommon.Border.ColorAngle = 45F;
            this.addButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addButton.StateCommon.Border.Rounding = 20;
            this.addButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.addButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addButton.TabIndex = 1;
            this.addButton.Values.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.HeaderStyles.HeaderCalendar.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCalendar.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCalendar.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCalendar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.HeaderStyles.HeaderCalendar.StateCommon.Border.Rounding = 0;
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Location = new System.Drawing.Point(702, 7);
            this.removeButton.Name = "removeButton";
            this.removeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.OverrideDefault.Back.ColorAngle = 45F;
            this.removeButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.OverrideDefault.Border.ColorAngle = 45F;
            this.removeButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.removeButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.removeButton.OverrideDefault.Border.Rounding = 20;
            this.removeButton.OverrideDefault.Border.Width = 1;
            this.removeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.removeButton.Size = new System.Drawing.Size(65, 37);
            this.removeButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.StateCommon.Back.ColorAngle = 45F;
            this.removeButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeButton.StateCommon.Border.ColorAngle = 45F;
            this.removeButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.removeButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.removeButton.StateCommon.Border.Rounding = 20;
            this.removeButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.removeButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.removeButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.removeButton.TabIndex = 4;
            this.removeButton.Values.Text = "Remove";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(29, 12);
            this.Calendar.Name = "Calendar";
            this.Calendar.Palette = this.kryptonPalette2;
            this.Calendar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Calendar.Size = new System.Drawing.Size(230, 184);
            this.Calendar.StateCheckedNormal.Day.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.Calendar.StateCheckedNormal.Day.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.Calendar.StateCheckedNormal.Day.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.Calendar.StateCheckedNormal.Day.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.Calendar.StateCheckedNormal.Day.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Calendar.StateCheckedNormal.Day.Border.Rounding = 10;
            this.Calendar.StateCheckedNormal.Day.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Calendar.StateCheckedNormal.Day.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Calendar.TabIndex = 2;
            this.Calendar.TodayDate = new System.DateTime(2024, 6, 2, 11, 34, 36, 972);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Location = new System.Drawing.Point(702, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.OverrideDefault.Back.ColorAngle = 45F;
            this.searchButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.OverrideDefault.Border.ColorAngle = 45F;
            this.searchButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchButton.OverrideDefault.Border.Rounding = 20;
            this.searchButton.OverrideDefault.Border.Width = 1;
            this.searchButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.searchButton.Size = new System.Drawing.Size(65, 37);
            this.searchButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.StateCommon.Back.ColorAngle = 45F;
            this.searchButton.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.searchButton.StateCommon.Border.ColorAngle = 45F;
            this.searchButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchButton.StateCommon.Border.Rounding = 20;
            this.searchButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.searchButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.searchButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchButton.TabIndex = 6;
            this.searchButton.Values.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "                   yyyy-MM-dd";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(325, 71);
            this.StartDateTimePicker.MinDate = new System.DateTime(2024, 6, 2, 11, 34, 36, 978);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Palette = this.kryptonPalette2;
            this.StartDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartDateTimePicker.Size = new System.Drawing.Size(202, 21);
            this.StartDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.StartDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.StartDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartDateTimePicker.TabIndex = 9;
            this.StartDateTimePicker.ValueNullable = new System.DateTime(2024, 6, 2, 11, 34, 36, 979);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold);
            this.StartDateLabel.ForeColor = System.Drawing.Color.White;
            this.StartDateLabel.Location = new System.Drawing.Point(382, 51);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(88, 17);
            this.StartDateLabel.TabIndex = 10;
            this.StartDateLabel.Text = "Start date";
            this.StartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold);
            this.EndDateLabel.ForeColor = System.Drawing.Color.White;
            this.EndDateLabel.Location = new System.Drawing.Point(390, 107);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(72, 17);
            this.EndDateLabel.TabIndex = 12;
            this.EndDateLabel.Text = "End date";
            this.EndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "                   yyyy-MM-dd";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(325, 127);
            this.EndDateTimePicker.MinDate = new System.DateTime(2024, 6, 2, 11, 34, 36, 983);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Palette = this.kryptonPalette2;
            this.EndDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.EndDateTimePicker.Size = new System.Drawing.Size(202, 21);
            this.EndDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.EndDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.EndDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EndDateTimePicker.TabIndex = 11;
            this.EndDateTimePicker.ValueNullable = new System.DateTime(2024, 6, 2, 11, 34, 36, 984);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold);
            this.EndTimeLabel.ForeColor = System.Drawing.Color.White;
            this.EndTimeLabel.Location = new System.Drawing.Point(390, 162);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(72, 17);
            this.EndTimeLabel.TabIndex = 14;
            this.EndTimeLabel.Text = "End time";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndTimeDateTimePicker
            // 
            this.EndTimeDateTimePicker.CustomFormat = "                         HH:mm";
            this.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimeDateTimePicker.Location = new System.Drawing.Point(325, 182);
            this.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker";
            this.EndTimeDateTimePicker.Palette = this.kryptonPalette2;
            this.EndTimeDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.EndTimeDateTimePicker.ShowUpDown = true;
            this.EndTimeDateTimePicker.Size = new System.Drawing.Size(202, 21);
            this.EndTimeDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.EndTimeDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.EndTimeDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EndTimeDateTimePicker.TabIndex = 13;
            this.EndTimeDateTimePicker.ValueNullable = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // taskTable
            // 
            this.taskTable.AllowUserToAddRows = false;
            this.taskTable.AllowUserToDeleteRows = false;
            this.taskTable.AllowUserToResizeColumns = false;
            this.taskTable.AllowUserToResizeRows = false;
            this.taskTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.task,
            this.start_date,
            this.end_date,
            this.end_time,
            this.completed});
            this.taskTable.Location = new System.Drawing.Point(233, 223);
            this.taskTable.MinimumSize = new System.Drawing.Size(100, 0);
            this.taskTable.Name = "taskTable";
            this.taskTable.RowHeadersVisible = false;
            this.taskTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskTable.ShowCellErrors = false;
            this.taskTable.ShowCellToolTips = false;
            this.taskTable.ShowEditingIcon = false;
            this.taskTable.ShowRowErrors = false;
            this.taskTable.Size = new System.Drawing.Size(457, 228);
            this.taskTable.StateCommon.Background.Color1 = System.Drawing.Color.MidnightBlue;
            this.taskTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.taskTable.StateNormal.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.taskTable.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.taskTable.StateNormal.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.taskTable.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.taskTable.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.taskTable.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskTable.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.taskTable.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.taskTable.StateNormal.HeaderColumn.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.taskTable.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.taskTable.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.taskTable.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskTable.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.taskTable.StateNormal.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.taskTable.StateSelected.DataCell.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.taskTable.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.taskTable.StateSelected.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.taskTable.StateSelected.DataCell.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.taskTable.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.taskTable.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.taskTable.StateSelected.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.taskTable.StateSelected.DataCell.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.taskTable.TabIndex = 15;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 27;
            // 
            // task
            // 
            this.task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.task.HeaderText = "Task";
            this.task.MinimumWidth = 100;
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // start_date
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.start_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.start_date.HeaderText = "Start date";
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            this.start_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.start_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.start_date.Width = 90;
            // 
            // end_date
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.end_date.DefaultCellStyle = dataGridViewCellStyle5;
            this.end_date.HeaderText = "End date";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            this.end_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.end_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.end_date.Width = 90;
            // 
            // end_time
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.end_time.DefaultCellStyle = dataGridViewCellStyle6;
            this.end_time.HeaderText = "End time";
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            this.end_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.end_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.end_time.Width = 90;
            // 
            // completed
            // 
            this.completed.DataPropertyName = "completed";
            this.completed.HeaderText = "Completed";
            this.completed.Name = "completed";
            this.completed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.completed.Width = 69;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.removeAll);
            this.panel.Controls.Add(this.searchTextBox);
            this.panel.Controls.Add(this.searchButton);
            this.panel.Controls.Add(this.removeButton);
            this.panel.Controls.Add(this.navigationBar);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 450);
            this.panel.TabIndex = 16;
            // 
            // removeAll
            // 
            this.removeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAll.Location = new System.Drawing.Point(626, 62);
            this.removeAll.Name = "removeAll";
            this.removeAll.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.OverrideDefault.Back.ColorAngle = 45F;
            this.removeAll.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.OverrideDefault.Border.ColorAngle = 45F;
            this.removeAll.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.removeAll.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.removeAll.OverrideDefault.Border.Rounding = 20;
            this.removeAll.OverrideDefault.Border.Width = 1;
            this.removeAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.removeAll.Size = new System.Drawing.Size(97, 37);
            this.removeAll.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.StateCommon.Back.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.StateCommon.Back.ColorAngle = 45F;
            this.removeAll.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.removeAll.StateCommon.Border.ColorAngle = 45F;
            this.removeAll.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.removeAll.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.removeAll.StateCommon.Border.Rounding = 20;
            this.removeAll.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.removeAll.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.removeAll.StateCommon.Content.ShortText.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.removeAll.TabIndex = 8;
            this.removeAll.Values.Text = "Remove all";
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Location = new System.Drawing.Point(582, 121);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(114, 32);
            this.searchTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.searchTextBox.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateBlue;
            this.searchTextBox.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.searchTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchTextBox.StateCommon.Border.Rounding = 20;
            this.searchTextBox.StateCommon.Border.Width = 1;
            this.searchTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.searchTextBox.StateCommon.Content.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // navigationBar
            // 
            this.navigationBar.AutoSize = false;
            this.navigationBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.None;
            this.navigationBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navigationBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.inProgressToolStripMenuItem,
            this.completedToolStripMenuItem});
            this.navigationBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.navigationBar.Location = new System.Drawing.Point(29, 223);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(131, 228);
            this.navigationBar.TabIndex = 9;
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold);
            this.allToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.allToolStripMenuItem.Image = global::ToDo.Properties.Resources.all;
            this.allToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20);
            this.allToolStripMenuItem.Size = new System.Drawing.Size(124, 69);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // inProgressToolStripMenuItem
            // 
            this.inProgressToolStripMenuItem.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold);
            this.inProgressToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.inProgressToolStripMenuItem.Image = global::ToDo.Properties.Resources.planning;
            this.inProgressToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inProgressToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inProgressToolStripMenuItem.Name = "inProgressToolStripMenuItem";
            this.inProgressToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20);
            this.inProgressToolStripMenuItem.ShowShortcutKeys = false;
            this.inProgressToolStripMenuItem.Size = new System.Drawing.Size(124, 69);
            this.inProgressToolStripMenuItem.Text = "In progress";
            this.inProgressToolStripMenuItem.Click += new System.EventHandler(this.inProgressToolStripMenuItem_Click);
            // 
            // completedToolStripMenuItem
            // 
            this.completedToolStripMenuItem.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 11.25F, System.Drawing.FontStyle.Bold);
            this.completedToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.completedToolStripMenuItem.Image = global::ToDo.Properties.Resources._checked;
            this.completedToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.completedToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            this.completedToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20);
            this.completedToolStripMenuItem.Size = new System.Drawing.Size(124, 69);
            this.completedToolStripMenuItem.Text = "Completed";
            this.completedToolStripMenuItem.Click += new System.EventHandler(this.completedToolStripMenuItem_Click);
            // 
            // OfflineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskTable);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.EndTimeDateTimePicker);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.navigationBar;
            this.Name = "OfflineForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do";
            ((System.ComponentModel.ISupportInitialize)(this.taskTable)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox taskTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton removeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar Calendar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchButton;
        private KryptonDateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private KryptonDateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label EndTimeLabel;
        private KryptonDateTimePicker EndTimeDateTimePicker;
        private KryptonDataGridView taskTable;
        private Panel panel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn task;
        private DataGridViewTextBoxColumn start_date;
        private DataGridViewTextBoxColumn end_date;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewCheckBoxColumn completed;
        private KryptonTextBox searchTextBox;
        private KryptonButton removeAll;
        private MenuStrip navigationBar;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem inProgressToolStripMenuItem;
        private ToolStripMenuItem completedToolStripMenuItem;
    }
}