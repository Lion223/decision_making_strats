namespace VGLB_L
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.openBtn = new MetroFramework.Controls.MetroButton();
            this.fileLbl = new MetroFramework.Controls.MetroLabel();
            this.arr00 = new MetroFramework.Controls.MetroTextBox();
            this.arr01 = new MetroFramework.Controls.MetroTextBox();
            this.arr02 = new MetroFramework.Controls.MetroTextBox();
            this.arr12 = new MetroFramework.Controls.MetroTextBox();
            this.arr11 = new MetroFramework.Controls.MetroTextBox();
            this.arr10 = new MetroFramework.Controls.MetroTextBox();
            this.arr22 = new MetroFramework.Controls.MetroTextBox();
            this.arr21 = new MetroFramework.Controls.MetroTextBox();
            this.arr20 = new MetroFramework.Controls.MetroTextBox();
            this.laplas2 = new MetroFramework.Controls.MetroTextBox();
            this.gurvic2 = new MetroFramework.Controls.MetroTextBox();
            this.vald2 = new MetroFramework.Controls.MetroTextBox();
            this.laplas1 = new MetroFramework.Controls.MetroTextBox();
            this.gurvic1 = new MetroFramework.Controls.MetroTextBox();
            this.vald1 = new MetroFramework.Controls.MetroTextBox();
            this.laplas0 = new MetroFramework.Controls.MetroTextBox();
            this.gurvic0 = new MetroFramework.Controls.MetroTextBox();
            this.vald0 = new MetroFramework.Controls.MetroTextBox();
            this.bayla2 = new MetroFramework.Controls.MetroTextBox();
            this.bayla1 = new MetroFramework.Controls.MetroTextBox();
            this.bayla0 = new MetroFramework.Controls.MetroTextBox();
            this.resTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.optTb = new MetroFramework.Controls.MetroTextBox();
            this.ch1Tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ch2Tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.ch3Tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // openBtn
            // 
            this.openBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.openBtn.Location = new System.Drawing.Point(23, 87);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(195, 35);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open a text file with an array";
            this.openBtn.UseSelectable = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(224, 93);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(0, 0);
            this.fileLbl.TabIndex = 1;
            // 
            // arr00
            // 
            // 
            // 
            // 
            this.arr00.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr00.CustomButton.Image = null;
            this.arr00.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr00.CustomButton.Name = "";
            this.arr00.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr00.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr00.CustomButton.TabIndex = 1;
            this.arr00.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr00.CustomButton.UseSelectable = true;
            this.arr00.CustomButton.Visible = false;
            this.arr00.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr00.Lines = new string[0];
            this.arr00.Location = new System.Drawing.Point(445, 87);
            this.arr00.MaxLength = 32767;
            this.arr00.Name = "arr00";
            this.arr00.PasswordChar = '\0';
            this.arr00.ReadOnly = true;
            this.arr00.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr00.SelectedText = "";
            this.arr00.SelectionLength = 0;
            this.arr00.SelectionStart = 0;
            this.arr00.ShortcutsEnabled = true;
            this.arr00.Size = new System.Drawing.Size(41, 23);
            this.arr00.TabIndex = 2;
            this.arr00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr00.UseCustomForeColor = true;
            this.arr00.UseSelectable = true;
            this.arr00.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr00.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr01
            // 
            // 
            // 
            // 
            this.arr01.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr01.CustomButton.Image = null;
            this.arr01.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr01.CustomButton.Name = "";
            this.arr01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr01.CustomButton.TabIndex = 1;
            this.arr01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr01.CustomButton.UseSelectable = true;
            this.arr01.CustomButton.Visible = false;
            this.arr01.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr01.Lines = new string[0];
            this.arr01.Location = new System.Drawing.Point(492, 87);
            this.arr01.MaxLength = 32767;
            this.arr01.Name = "arr01";
            this.arr01.PasswordChar = '\0';
            this.arr01.ReadOnly = true;
            this.arr01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr01.SelectedText = "";
            this.arr01.SelectionLength = 0;
            this.arr01.SelectionStart = 0;
            this.arr01.ShortcutsEnabled = true;
            this.arr01.Size = new System.Drawing.Size(41, 23);
            this.arr01.TabIndex = 3;
            this.arr01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr01.UseCustomForeColor = true;
            this.arr01.UseSelectable = true;
            this.arr01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr01.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr02
            // 
            // 
            // 
            // 
            this.arr02.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr02.CustomButton.Image = null;
            this.arr02.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr02.CustomButton.Name = "";
            this.arr02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr02.CustomButton.TabIndex = 1;
            this.arr02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr02.CustomButton.UseSelectable = true;
            this.arr02.CustomButton.Visible = false;
            this.arr02.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr02.Lines = new string[0];
            this.arr02.Location = new System.Drawing.Point(539, 87);
            this.arr02.MaxLength = 32767;
            this.arr02.Name = "arr02";
            this.arr02.PasswordChar = '\0';
            this.arr02.ReadOnly = true;
            this.arr02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr02.SelectedText = "";
            this.arr02.SelectionLength = 0;
            this.arr02.SelectionStart = 0;
            this.arr02.ShortcutsEnabled = true;
            this.arr02.Size = new System.Drawing.Size(41, 23);
            this.arr02.TabIndex = 4;
            this.arr02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr02.UseCustomForeColor = true;
            this.arr02.UseSelectable = true;
            this.arr02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr02.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr12
            // 
            // 
            // 
            // 
            this.arr12.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr12.CustomButton.Image = null;
            this.arr12.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr12.CustomButton.Name = "";
            this.arr12.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr12.CustomButton.TabIndex = 1;
            this.arr12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr12.CustomButton.UseSelectable = true;
            this.arr12.CustomButton.Visible = false;
            this.arr12.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr12.Lines = new string[0];
            this.arr12.Location = new System.Drawing.Point(539, 116);
            this.arr12.MaxLength = 32767;
            this.arr12.Name = "arr12";
            this.arr12.PasswordChar = '\0';
            this.arr12.ReadOnly = true;
            this.arr12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr12.SelectedText = "";
            this.arr12.SelectionLength = 0;
            this.arr12.SelectionStart = 0;
            this.arr12.ShortcutsEnabled = true;
            this.arr12.Size = new System.Drawing.Size(41, 23);
            this.arr12.TabIndex = 7;
            this.arr12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr12.UseCustomForeColor = true;
            this.arr12.UseSelectable = true;
            this.arr12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr12.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr11
            // 
            // 
            // 
            // 
            this.arr11.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr11.CustomButton.Image = null;
            this.arr11.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr11.CustomButton.Name = "";
            this.arr11.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr11.CustomButton.TabIndex = 1;
            this.arr11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr11.CustomButton.UseSelectable = true;
            this.arr11.CustomButton.Visible = false;
            this.arr11.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr11.Lines = new string[0];
            this.arr11.Location = new System.Drawing.Point(492, 116);
            this.arr11.MaxLength = 32767;
            this.arr11.Name = "arr11";
            this.arr11.PasswordChar = '\0';
            this.arr11.ReadOnly = true;
            this.arr11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr11.SelectedText = "";
            this.arr11.SelectionLength = 0;
            this.arr11.SelectionStart = 0;
            this.arr11.ShortcutsEnabled = true;
            this.arr11.Size = new System.Drawing.Size(41, 23);
            this.arr11.TabIndex = 6;
            this.arr11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr11.UseCustomForeColor = true;
            this.arr11.UseSelectable = true;
            this.arr11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr11.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr10
            // 
            // 
            // 
            // 
            this.arr10.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr10.CustomButton.Image = null;
            this.arr10.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr10.CustomButton.Name = "";
            this.arr10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr10.CustomButton.TabIndex = 1;
            this.arr10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr10.CustomButton.UseSelectable = true;
            this.arr10.CustomButton.Visible = false;
            this.arr10.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr10.Lines = new string[0];
            this.arr10.Location = new System.Drawing.Point(445, 116);
            this.arr10.MaxLength = 32767;
            this.arr10.Name = "arr10";
            this.arr10.PasswordChar = '\0';
            this.arr10.ReadOnly = true;
            this.arr10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr10.SelectedText = "";
            this.arr10.SelectionLength = 0;
            this.arr10.SelectionStart = 0;
            this.arr10.ShortcutsEnabled = true;
            this.arr10.Size = new System.Drawing.Size(41, 23);
            this.arr10.TabIndex = 5;
            this.arr10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr10.UseCustomForeColor = true;
            this.arr10.UseSelectable = true;
            this.arr10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr10.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr22
            // 
            // 
            // 
            // 
            this.arr22.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr22.CustomButton.Image = null;
            this.arr22.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr22.CustomButton.Name = "";
            this.arr22.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr22.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr22.CustomButton.TabIndex = 1;
            this.arr22.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr22.CustomButton.UseSelectable = true;
            this.arr22.CustomButton.Visible = false;
            this.arr22.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr22.Lines = new string[0];
            this.arr22.Location = new System.Drawing.Point(539, 145);
            this.arr22.MaxLength = 32767;
            this.arr22.Name = "arr22";
            this.arr22.PasswordChar = '\0';
            this.arr22.ReadOnly = true;
            this.arr22.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr22.SelectedText = "";
            this.arr22.SelectionLength = 0;
            this.arr22.SelectionStart = 0;
            this.arr22.ShortcutsEnabled = true;
            this.arr22.Size = new System.Drawing.Size(41, 23);
            this.arr22.TabIndex = 10;
            this.arr22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr22.UseCustomForeColor = true;
            this.arr22.UseSelectable = true;
            this.arr22.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr22.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr21
            // 
            // 
            // 
            // 
            this.arr21.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr21.CustomButton.Image = null;
            this.arr21.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr21.CustomButton.Name = "";
            this.arr21.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr21.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr21.CustomButton.TabIndex = 1;
            this.arr21.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr21.CustomButton.UseSelectable = true;
            this.arr21.CustomButton.Visible = false;
            this.arr21.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr21.Lines = new string[0];
            this.arr21.Location = new System.Drawing.Point(492, 145);
            this.arr21.MaxLength = 32767;
            this.arr21.Name = "arr21";
            this.arr21.PasswordChar = '\0';
            this.arr21.ReadOnly = true;
            this.arr21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr21.SelectedText = "";
            this.arr21.SelectionLength = 0;
            this.arr21.SelectionStart = 0;
            this.arr21.ShortcutsEnabled = true;
            this.arr21.Size = new System.Drawing.Size(41, 23);
            this.arr21.TabIndex = 9;
            this.arr21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr21.UseCustomForeColor = true;
            this.arr21.UseSelectable = true;
            this.arr21.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr21.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // arr20
            // 
            // 
            // 
            // 
            this.arr20.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr20.CustomButton.Image = null;
            this.arr20.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.arr20.CustomButton.Name = "";
            this.arr20.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arr20.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arr20.CustomButton.TabIndex = 1;
            this.arr20.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arr20.CustomButton.UseSelectable = true;
            this.arr20.CustomButton.Visible = false;
            this.arr20.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.arr20.Lines = new string[0];
            this.arr20.Location = new System.Drawing.Point(445, 145);
            this.arr20.MaxLength = 32767;
            this.arr20.Name = "arr20";
            this.arr20.PasswordChar = '\0';
            this.arr20.ReadOnly = true;
            this.arr20.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arr20.SelectedText = "";
            this.arr20.SelectionLength = 0;
            this.arr20.SelectionStart = 0;
            this.arr20.ShortcutsEnabled = true;
            this.arr20.Size = new System.Drawing.Size(41, 23);
            this.arr20.TabIndex = 8;
            this.arr20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arr20.UseCustomForeColor = true;
            this.arr20.UseSelectable = true;
            this.arr20.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arr20.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // laplas2
            // 
            // 
            // 
            // 
            this.laplas2.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laplas2.CustomButton.Image = null;
            this.laplas2.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.laplas2.CustomButton.Name = "";
            this.laplas2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.laplas2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.laplas2.CustomButton.TabIndex = 1;
            this.laplas2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.laplas2.CustomButton.UseSelectable = true;
            this.laplas2.CustomButton.Visible = false;
            this.laplas2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.laplas2.Lines = new string[0];
            this.laplas2.Location = new System.Drawing.Point(492, 270);
            this.laplas2.MaxLength = 32767;
            this.laplas2.Name = "laplas2";
            this.laplas2.PasswordChar = '\0';
            this.laplas2.ReadOnly = true;
            this.laplas2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.laplas2.SelectedText = "";
            this.laplas2.SelectionLength = 0;
            this.laplas2.SelectionStart = 0;
            this.laplas2.ShortcutsEnabled = true;
            this.laplas2.Size = new System.Drawing.Size(41, 23);
            this.laplas2.TabIndex = 19;
            this.laplas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplas2.UseCustomForeColor = true;
            this.laplas2.UseSelectable = true;
            this.laplas2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.laplas2.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // gurvic2
            // 
            // 
            // 
            // 
            this.gurvic2.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gurvic2.CustomButton.Image = null;
            this.gurvic2.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.gurvic2.CustomButton.Name = "";
            this.gurvic2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gurvic2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gurvic2.CustomButton.TabIndex = 1;
            this.gurvic2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gurvic2.CustomButton.UseSelectable = true;
            this.gurvic2.CustomButton.Visible = false;
            this.gurvic2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.gurvic2.Lines = new string[0];
            this.gurvic2.Location = new System.Drawing.Point(445, 270);
            this.gurvic2.MaxLength = 32767;
            this.gurvic2.Name = "gurvic2";
            this.gurvic2.PasswordChar = '\0';
            this.gurvic2.ReadOnly = true;
            this.gurvic2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gurvic2.SelectedText = "";
            this.gurvic2.SelectionLength = 0;
            this.gurvic2.SelectionStart = 0;
            this.gurvic2.ShortcutsEnabled = true;
            this.gurvic2.Size = new System.Drawing.Size(41, 23);
            this.gurvic2.TabIndex = 18;
            this.gurvic2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gurvic2.UseCustomForeColor = true;
            this.gurvic2.UseSelectable = true;
            this.gurvic2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gurvic2.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // vald2
            // 
            // 
            // 
            // 
            this.vald2.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vald2.CustomButton.Image = null;
            this.vald2.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.vald2.CustomButton.Name = "";
            this.vald2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vald2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vald2.CustomButton.TabIndex = 1;
            this.vald2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vald2.CustomButton.UseSelectable = true;
            this.vald2.CustomButton.Visible = false;
            this.vald2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.vald2.Lines = new string[0];
            this.vald2.Location = new System.Drawing.Point(398, 270);
            this.vald2.MaxLength = 32767;
            this.vald2.Name = "vald2";
            this.vald2.PasswordChar = '\0';
            this.vald2.ReadOnly = true;
            this.vald2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vald2.SelectedText = "";
            this.vald2.SelectionLength = 0;
            this.vald2.SelectionStart = 0;
            this.vald2.ShortcutsEnabled = true;
            this.vald2.Size = new System.Drawing.Size(41, 23);
            this.vald2.TabIndex = 17;
            this.vald2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vald2.UseCustomForeColor = true;
            this.vald2.UseSelectable = true;
            this.vald2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vald2.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // laplas1
            // 
            // 
            // 
            // 
            this.laplas1.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laplas1.CustomButton.Image = null;
            this.laplas1.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.laplas1.CustomButton.Name = "";
            this.laplas1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.laplas1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.laplas1.CustomButton.TabIndex = 1;
            this.laplas1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.laplas1.CustomButton.UseSelectable = true;
            this.laplas1.CustomButton.Visible = false;
            this.laplas1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.laplas1.Lines = new string[0];
            this.laplas1.Location = new System.Drawing.Point(492, 241);
            this.laplas1.MaxLength = 32767;
            this.laplas1.Name = "laplas1";
            this.laplas1.PasswordChar = '\0';
            this.laplas1.ReadOnly = true;
            this.laplas1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.laplas1.SelectedText = "";
            this.laplas1.SelectionLength = 0;
            this.laplas1.SelectionStart = 0;
            this.laplas1.ShortcutsEnabled = true;
            this.laplas1.Size = new System.Drawing.Size(41, 23);
            this.laplas1.TabIndex = 16;
            this.laplas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplas1.UseCustomForeColor = true;
            this.laplas1.UseSelectable = true;
            this.laplas1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.laplas1.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // gurvic1
            // 
            // 
            // 
            // 
            this.gurvic1.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gurvic1.CustomButton.Image = null;
            this.gurvic1.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.gurvic1.CustomButton.Name = "";
            this.gurvic1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gurvic1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gurvic1.CustomButton.TabIndex = 1;
            this.gurvic1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gurvic1.CustomButton.UseSelectable = true;
            this.gurvic1.CustomButton.Visible = false;
            this.gurvic1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.gurvic1.Lines = new string[0];
            this.gurvic1.Location = new System.Drawing.Point(445, 241);
            this.gurvic1.MaxLength = 32767;
            this.gurvic1.Name = "gurvic1";
            this.gurvic1.PasswordChar = '\0';
            this.gurvic1.ReadOnly = true;
            this.gurvic1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gurvic1.SelectedText = "";
            this.gurvic1.SelectionLength = 0;
            this.gurvic1.SelectionStart = 0;
            this.gurvic1.ShortcutsEnabled = true;
            this.gurvic1.Size = new System.Drawing.Size(41, 23);
            this.gurvic1.TabIndex = 15;
            this.gurvic1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gurvic1.UseCustomForeColor = true;
            this.gurvic1.UseSelectable = true;
            this.gurvic1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gurvic1.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // vald1
            // 
            // 
            // 
            // 
            this.vald1.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vald1.CustomButton.Image = null;
            this.vald1.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.vald1.CustomButton.Name = "";
            this.vald1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vald1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vald1.CustomButton.TabIndex = 1;
            this.vald1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vald1.CustomButton.UseSelectable = true;
            this.vald1.CustomButton.Visible = false;
            this.vald1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.vald1.Lines = new string[0];
            this.vald1.Location = new System.Drawing.Point(398, 241);
            this.vald1.MaxLength = 32767;
            this.vald1.Name = "vald1";
            this.vald1.PasswordChar = '\0';
            this.vald1.ReadOnly = true;
            this.vald1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vald1.SelectedText = "";
            this.vald1.SelectionLength = 0;
            this.vald1.SelectionStart = 0;
            this.vald1.ShortcutsEnabled = true;
            this.vald1.Size = new System.Drawing.Size(41, 23);
            this.vald1.TabIndex = 14;
            this.vald1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vald1.UseCustomForeColor = true;
            this.vald1.UseSelectable = true;
            this.vald1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vald1.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // laplas0
            // 
            // 
            // 
            // 
            this.laplas0.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laplas0.CustomButton.Image = null;
            this.laplas0.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.laplas0.CustomButton.Name = "";
            this.laplas0.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.laplas0.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.laplas0.CustomButton.TabIndex = 1;
            this.laplas0.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.laplas0.CustomButton.UseSelectable = true;
            this.laplas0.CustomButton.Visible = false;
            this.laplas0.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.laplas0.Lines = new string[0];
            this.laplas0.Location = new System.Drawing.Point(492, 212);
            this.laplas0.MaxLength = 32767;
            this.laplas0.Name = "laplas0";
            this.laplas0.PasswordChar = '\0';
            this.laplas0.ReadOnly = true;
            this.laplas0.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.laplas0.SelectedText = "";
            this.laplas0.SelectionLength = 0;
            this.laplas0.SelectionStart = 0;
            this.laplas0.ShortcutsEnabled = true;
            this.laplas0.Size = new System.Drawing.Size(41, 23);
            this.laplas0.TabIndex = 13;
            this.laplas0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.laplas0.UseCustomForeColor = true;
            this.laplas0.UseSelectable = true;
            this.laplas0.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.laplas0.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // gurvic0
            // 
            // 
            // 
            // 
            this.gurvic0.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gurvic0.CustomButton.Image = null;
            this.gurvic0.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.gurvic0.CustomButton.Name = "";
            this.gurvic0.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gurvic0.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gurvic0.CustomButton.TabIndex = 1;
            this.gurvic0.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gurvic0.CustomButton.UseSelectable = true;
            this.gurvic0.CustomButton.Visible = false;
            this.gurvic0.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.gurvic0.Lines = new string[0];
            this.gurvic0.Location = new System.Drawing.Point(445, 212);
            this.gurvic0.MaxLength = 32767;
            this.gurvic0.Name = "gurvic0";
            this.gurvic0.PasswordChar = '\0';
            this.gurvic0.ReadOnly = true;
            this.gurvic0.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gurvic0.SelectedText = "";
            this.gurvic0.SelectionLength = 0;
            this.gurvic0.SelectionStart = 0;
            this.gurvic0.ShortcutsEnabled = true;
            this.gurvic0.Size = new System.Drawing.Size(41, 23);
            this.gurvic0.TabIndex = 12;
            this.gurvic0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gurvic0.UseCustomForeColor = true;
            this.gurvic0.UseSelectable = true;
            this.gurvic0.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gurvic0.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // vald0
            // 
            // 
            // 
            // 
            this.vald0.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vald0.CustomButton.Image = null;
            this.vald0.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.vald0.CustomButton.Name = "";
            this.vald0.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vald0.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vald0.CustomButton.TabIndex = 1;
            this.vald0.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vald0.CustomButton.UseSelectable = true;
            this.vald0.CustomButton.Visible = false;
            this.vald0.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.vald0.Lines = new string[0];
            this.vald0.Location = new System.Drawing.Point(398, 212);
            this.vald0.MaxLength = 32767;
            this.vald0.Name = "vald0";
            this.vald0.PasswordChar = '\0';
            this.vald0.ReadOnly = true;
            this.vald0.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vald0.SelectedText = "";
            this.vald0.SelectionLength = 0;
            this.vald0.SelectionStart = 0;
            this.vald0.ShortcutsEnabled = true;
            this.vald0.Size = new System.Drawing.Size(41, 23);
            this.vald0.TabIndex = 11;
            this.vald0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vald0.UseCustomForeColor = true;
            this.vald0.UseSelectable = true;
            this.vald0.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vald0.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bayla2
            // 
            // 
            // 
            // 
            this.bayla2.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bayla2.CustomButton.Image = null;
            this.bayla2.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.bayla2.CustomButton.Name = "";
            this.bayla2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bayla2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bayla2.CustomButton.TabIndex = 1;
            this.bayla2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bayla2.CustomButton.UseSelectable = true;
            this.bayla2.CustomButton.Visible = false;
            this.bayla2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bayla2.Lines = new string[0];
            this.bayla2.Location = new System.Drawing.Point(539, 270);
            this.bayla2.MaxLength = 32767;
            this.bayla2.Name = "bayla2";
            this.bayla2.PasswordChar = '\0';
            this.bayla2.ReadOnly = true;
            this.bayla2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bayla2.SelectedText = "";
            this.bayla2.SelectionLength = 0;
            this.bayla2.SelectionStart = 0;
            this.bayla2.ShortcutsEnabled = true;
            this.bayla2.Size = new System.Drawing.Size(41, 23);
            this.bayla2.TabIndex = 22;
            this.bayla2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bayla2.UseCustomForeColor = true;
            this.bayla2.UseSelectable = true;
            this.bayla2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bayla2.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bayla1
            // 
            // 
            // 
            // 
            this.bayla1.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bayla1.CustomButton.Image = null;
            this.bayla1.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.bayla1.CustomButton.Name = "";
            this.bayla1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bayla1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bayla1.CustomButton.TabIndex = 1;
            this.bayla1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bayla1.CustomButton.UseSelectable = true;
            this.bayla1.CustomButton.Visible = false;
            this.bayla1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bayla1.Lines = new string[0];
            this.bayla1.Location = new System.Drawing.Point(539, 241);
            this.bayla1.MaxLength = 32767;
            this.bayla1.Name = "bayla1";
            this.bayla1.PasswordChar = '\0';
            this.bayla1.ReadOnly = true;
            this.bayla1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bayla1.SelectedText = "";
            this.bayla1.SelectionLength = 0;
            this.bayla1.SelectionStart = 0;
            this.bayla1.ShortcutsEnabled = true;
            this.bayla1.Size = new System.Drawing.Size(41, 23);
            this.bayla1.TabIndex = 21;
            this.bayla1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bayla1.UseCustomForeColor = true;
            this.bayla1.UseSelectable = true;
            this.bayla1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bayla1.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bayla0
            // 
            // 
            // 
            // 
            this.bayla0.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bayla0.CustomButton.Image = null;
            this.bayla0.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.bayla0.CustomButton.Name = "";
            this.bayla0.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bayla0.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bayla0.CustomButton.TabIndex = 1;
            this.bayla0.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bayla0.CustomButton.UseSelectable = true;
            this.bayla0.CustomButton.Visible = false;
            this.bayla0.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bayla0.Lines = new string[0];
            this.bayla0.Location = new System.Drawing.Point(539, 212);
            this.bayla0.MaxLength = 32767;
            this.bayla0.Name = "bayla0";
            this.bayla0.PasswordChar = '\0';
            this.bayla0.ReadOnly = true;
            this.bayla0.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bayla0.SelectedText = "";
            this.bayla0.SelectionLength = 0;
            this.bayla0.SelectionStart = 0;
            this.bayla0.ShortcutsEnabled = true;
            this.bayla0.Size = new System.Drawing.Size(41, 23);
            this.bayla0.TabIndex = 20;
            this.bayla0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bayla0.UseCustomForeColor = true;
            this.bayla0.UseSelectable = true;
            this.bayla0.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bayla0.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // resTb
            // 
            // 
            // 
            // 
            this.resTb.CustomButton.Image = null;
            this.resTb.CustomButton.Location = new System.Drawing.Point(442, 1);
            this.resTb.CustomButton.Name = "";
            this.resTb.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.resTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resTb.CustomButton.TabIndex = 1;
            this.resTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resTb.CustomButton.UseSelectable = true;
            this.resTb.CustomButton.Visible = false;
            this.resTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.resTb.Lines = new string[0];
            this.resTb.Location = new System.Drawing.Point(23, 327);
            this.resTb.MaxLength = 32767;
            this.resTb.Multiline = true;
            this.resTb.Name = "resTb";
            this.resTb.PasswordChar = '\0';
            this.resTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resTb.SelectedText = "";
            this.resTb.SelectionLength = 0;
            this.resTb.SelectionStart = 0;
            this.resTb.ShortcutsEnabled = true;
            this.resTb.Size = new System.Drawing.Size(558, 117);
            this.resTb.TabIndex = 23;
            this.resTb.UseSelectable = true;
            this.resTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(416, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(23, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "A1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(416, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(25, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "A2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(416, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(25, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "A3";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(165, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Optimism coefficient (opt):";
            // 
            // optTb
            // 
            // 
            // 
            // 
            this.optTb.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optTb.CustomButton.Image = null;
            this.optTb.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.optTb.CustomButton.Name = "";
            this.optTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.optTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.optTb.CustomButton.TabIndex = 1;
            this.optTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.optTb.CustomButton.UseSelectable = true;
            this.optTb.CustomButton.Visible = false;
            this.optTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.optTb.Lines = new string[] {
        "0.4"};
            this.optTb.Location = new System.Drawing.Point(194, 157);
            this.optTb.MaxLength = 32767;
            this.optTb.Name = "optTb";
            this.optTb.PasswordChar = '\0';
            this.optTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.optTb.SelectedText = "";
            this.optTb.SelectionLength = 0;
            this.optTb.SelectionStart = 0;
            this.optTb.ShortcutsEnabled = true;
            this.optTb.Size = new System.Drawing.Size(41, 23);
            this.optTb.TabIndex = 28;
            this.optTb.Text = "0.4";
            this.optTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.optTb.UseCustomForeColor = true;
            this.optTb.UseSelectable = true;
            this.optTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.optTb.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optTb_KeyPress);
            // 
            // ch1Tb
            // 
            // 
            // 
            // 
            this.ch1Tb.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch1Tb.CustomButton.Image = null;
            this.ch1Tb.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.ch1Tb.CustomButton.Name = "";
            this.ch1Tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ch1Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ch1Tb.CustomButton.TabIndex = 1;
            this.ch1Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ch1Tb.CustomButton.UseSelectable = true;
            this.ch1Tb.CustomButton.Visible = false;
            this.ch1Tb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ch1Tb.Lines = new string[] {
        "0.5"};
            this.ch1Tb.Location = new System.Drawing.Point(224, 195);
            this.ch1Tb.MaxLength = 32767;
            this.ch1Tb.Name = "ch1Tb";
            this.ch1Tb.PasswordChar = '\0';
            this.ch1Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ch1Tb.SelectedText = "";
            this.ch1Tb.SelectionLength = 0;
            this.ch1Tb.SelectionStart = 0;
            this.ch1Tb.ShortcutsEnabled = true;
            this.ch1Tb.Size = new System.Drawing.Size(41, 23);
            this.ch1Tb.TabIndex = 30;
            this.ch1Tb.Text = "0.5";
            this.ch1Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch1Tb.UseCustomForeColor = true;
            this.ch1Tb.UseSelectable = true;
            this.ch1Tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ch1Tb.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch1Tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ch1Tb_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 195);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(195, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Est. of probabilities of a EC (p1):";
            // 
            // ch2Tb
            // 
            // 
            // 
            // 
            this.ch2Tb.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch2Tb.CustomButton.Image = null;
            this.ch2Tb.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.ch2Tb.CustomButton.Name = "";
            this.ch2Tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ch2Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ch2Tb.CustomButton.TabIndex = 1;
            this.ch2Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ch2Tb.CustomButton.UseSelectable = true;
            this.ch2Tb.CustomButton.Visible = false;
            this.ch2Tb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ch2Tb.Lines = new string[] {
        "0.35"};
            this.ch2Tb.Location = new System.Drawing.Point(224, 233);
            this.ch2Tb.MaxLength = 32767;
            this.ch2Tb.Name = "ch2Tb";
            this.ch2Tb.PasswordChar = '\0';
            this.ch2Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ch2Tb.SelectedText = "";
            this.ch2Tb.SelectionLength = 0;
            this.ch2Tb.SelectionStart = 0;
            this.ch2Tb.ShortcutsEnabled = true;
            this.ch2Tb.Size = new System.Drawing.Size(41, 23);
            this.ch2Tb.TabIndex = 32;
            this.ch2Tb.Text = "0.35";
            this.ch2Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch2Tb.UseCustomForeColor = true;
            this.ch2Tb.UseSelectable = true;
            this.ch2Tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ch2Tb.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch2Tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ch2Tb_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(197, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Est. of probabilities of a EC (p2):";
            // 
            // ch3Tb
            // 
            // 
            // 
            // 
            this.ch3Tb.CustomButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch3Tb.CustomButton.Image = null;
            this.ch3Tb.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.ch3Tb.CustomButton.Name = "";
            this.ch3Tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ch3Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ch3Tb.CustomButton.TabIndex = 1;
            this.ch3Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ch3Tb.CustomButton.UseSelectable = true;
            this.ch3Tb.CustomButton.Visible = false;
            this.ch3Tb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ch3Tb.Lines = new string[] {
        "0.15"};
            this.ch3Tb.Location = new System.Drawing.Point(224, 270);
            this.ch3Tb.MaxLength = 32767;
            this.ch3Tb.Name = "ch3Tb";
            this.ch3Tb.PasswordChar = '\0';
            this.ch3Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ch3Tb.SelectedText = "";
            this.ch3Tb.SelectionLength = 0;
            this.ch3Tb.SelectionStart = 0;
            this.ch3Tb.ShortcutsEnabled = true;
            this.ch3Tb.Size = new System.Drawing.Size(41, 23);
            this.ch3Tb.TabIndex = 34;
            this.ch3Tb.Text = "0.15";
            this.ch3Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch3Tb.UseCustomForeColor = true;
            this.ch3Tb.UseSelectable = true;
            this.ch3Tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ch3Tb.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch3Tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ch3Tb_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 270);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(197, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Est. of probabilities of a EC (p3):";
            // 
            // startBtn
            // 
            this.startBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.startBtn.Location = new System.Drawing.Point(230, 479);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(196, 35);
            this.startBtn.TabIndex = 35;
            this.startBtn.Text = "Calculate";
            this.startBtn.UseSelectable = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(409, 190);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(17, 19);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "V";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(457, 190);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(18, 19);
            this.metroLabel9.TabIndex = 37;
            this.metroLabel9.Text = "G";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(503, 190);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(15, 19);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "L";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(543, 190);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(29, 19);
            this.metroLabel11.TabIndex = 39;
            this.metroLabel11.Text = "B-L";
            // 
            // MainForm
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 540);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.ch3Tb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.ch2Tb);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.ch1Tb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.optTb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.resTb);
            this.Controls.Add(this.bayla2);
            this.Controls.Add(this.bayla1);
            this.Controls.Add(this.bayla0);
            this.Controls.Add(this.laplas2);
            this.Controls.Add(this.gurvic2);
            this.Controls.Add(this.vald2);
            this.Controls.Add(this.laplas1);
            this.Controls.Add(this.gurvic1);
            this.Controls.Add(this.vald1);
            this.Controls.Add(this.laplas0);
            this.Controls.Add(this.gurvic0);
            this.Controls.Add(this.vald0);
            this.Controls.Add(this.arr22);
            this.Controls.Add(this.arr21);
            this.Controls.Add(this.arr20);
            this.Controls.Add(this.arr12);
            this.Controls.Add(this.arr11);
            this.Controls.Add(this.arr10);
            this.Controls.Add(this.arr02);
            this.Controls.Add(this.arr01);
            this.Controls.Add(this.arr00);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.openBtn);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Decision making under uncertainty and risk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroButton openBtn;
        private MetroFramework.Controls.MetroLabel fileLbl;
        private MetroFramework.Controls.MetroTextBox arr00;
        private MetroFramework.Controls.MetroTextBox arr01;
        private MetroFramework.Controls.MetroTextBox arr02;
        private MetroFramework.Controls.MetroTextBox arr12;
        private MetroFramework.Controls.MetroTextBox arr11;
        private MetroFramework.Controls.MetroTextBox arr10;
        private MetroFramework.Controls.MetroTextBox arr22;
        private MetroFramework.Controls.MetroTextBox arr21;
        private MetroFramework.Controls.MetroTextBox arr20;
        private MetroFramework.Controls.MetroTextBox laplas2;
        private MetroFramework.Controls.MetroTextBox gurvic2;
        private MetroFramework.Controls.MetroTextBox vald2;
        private MetroFramework.Controls.MetroTextBox laplas1;
        private MetroFramework.Controls.MetroTextBox gurvic1;
        private MetroFramework.Controls.MetroTextBox vald1;
        private MetroFramework.Controls.MetroTextBox laplas0;
        private MetroFramework.Controls.MetroTextBox gurvic0;
        private MetroFramework.Controls.MetroTextBox vald0;
        private MetroFramework.Controls.MetroTextBox bayla2;
        private MetroFramework.Controls.MetroTextBox bayla1;
        private MetroFramework.Controls.MetroTextBox bayla0;
        private MetroFramework.Controls.MetroTextBox resTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox optTb;
        private MetroFramework.Controls.MetroTextBox ch1Tb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox ch2Tb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox ch3Tb;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton startBtn;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}

