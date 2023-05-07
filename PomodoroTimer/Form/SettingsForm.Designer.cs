namespace PomodoroTimer
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSave = new TulparUI.Controls.TulparButton();
            this.tPomodoroTime = new TulparUI.Controls.TulparTextBox();
            this.tShortBreakTime = new TulparUI.Controls.TulparTextBox();
            this.tLongBreakTime = new TulparUI.Controls.TulparTextBox();
            this.cPomodoroAlarm = new TulparUI.Controls.TulparComboBox();
            this.cShortBreakAlarm = new TulparUI.Controls.TulparComboBox();
            this.cLongBreakAlarm = new TulparUI.Controls.TulparComboBox();
            this.BtnSina = new TulparUI.Controls.TulparButton();
            this.BtnSinaShort = new TulparUI.Controls.TulparButton();
            this.BtnSinaLong = new TulparUI.Controls.TulparButton();
            this.cMusic = new TulparUI.Controls.TulparComboBox();
            this.BtnSinaMusic = new TulparUI.Controls.TulparButton();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnSave.Depth = 0;
            this.BtnSave.HighEmphasis = true;
            this.BtnSave.Icon = null;
            this.BtnSave.Location = new System.Drawing.Point(1119, 549);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = TulparUI.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSave.Size = new System.Drawing.Size(68, 36);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnSave.UseAccentColor = false;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tPomodoroTime
            // 
            this.tPomodoroTime.AnimateReadOnly = false;
            this.tPomodoroTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tPomodoroTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tPomodoroTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tPomodoroTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tPomodoroTime.Depth = 0;
            this.tPomodoroTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tPomodoroTime.HideSelection = true;
            this.tPomodoroTime.Hint = "Pomodoro Time";
            this.tPomodoroTime.LeadingIcon = null;
            this.tPomodoroTime.Location = new System.Drawing.Point(12, 12);
            this.tPomodoroTime.MaxLength = 32767;
            this.tPomodoroTime.MouseState = TulparUI.MouseState.OUT;
            this.tPomodoroTime.Name = "tPomodoroTime";
            this.tPomodoroTime.PasswordChar = '\0';
            this.tPomodoroTime.PrefixSuffixText = null;
            this.tPomodoroTime.ReadOnly = false;
            this.tPomodoroTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tPomodoroTime.SelectedText = "";
            this.tPomodoroTime.SelectionLength = 0;
            this.tPomodoroTime.SelectionStart = 0;
            this.tPomodoroTime.ShortcutsEnabled = true;
            this.tPomodoroTime.Size = new System.Drawing.Size(154, 48);
            this.tPomodoroTime.TabIndex = 1;
            this.tPomodoroTime.TabStop = false;
            this.tPomodoroTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tPomodoroTime.TrailingIcon = null;
            this.tPomodoroTime.UseSystemPasswordChar = false;
            // 
            // tShortBreakTime
            // 
            this.tShortBreakTime.AnimateReadOnly = false;
            this.tShortBreakTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tShortBreakTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tShortBreakTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tShortBreakTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tShortBreakTime.Depth = 0;
            this.tShortBreakTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tShortBreakTime.HideSelection = true;
            this.tShortBreakTime.Hint = "Short Break Time";
            this.tShortBreakTime.LeadingIcon = null;
            this.tShortBreakTime.Location = new System.Drawing.Point(12, 66);
            this.tShortBreakTime.MaxLength = 32767;
            this.tShortBreakTime.MouseState = TulparUI.MouseState.OUT;
            this.tShortBreakTime.Name = "tShortBreakTime";
            this.tShortBreakTime.PasswordChar = '\0';
            this.tShortBreakTime.PrefixSuffixText = null;
            this.tShortBreakTime.ReadOnly = false;
            this.tShortBreakTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tShortBreakTime.SelectedText = "";
            this.tShortBreakTime.SelectionLength = 0;
            this.tShortBreakTime.SelectionStart = 0;
            this.tShortBreakTime.ShortcutsEnabled = true;
            this.tShortBreakTime.Size = new System.Drawing.Size(154, 48);
            this.tShortBreakTime.TabIndex = 2;
            this.tShortBreakTime.TabStop = false;
            this.tShortBreakTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tShortBreakTime.TrailingIcon = null;
            this.tShortBreakTime.UseSystemPasswordChar = false;
            // 
            // tLongBreakTime
            // 
            this.tLongBreakTime.AnimateReadOnly = false;
            this.tLongBreakTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tLongBreakTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tLongBreakTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tLongBreakTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tLongBreakTime.Depth = 0;
            this.tLongBreakTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tLongBreakTime.HideSelection = true;
            this.tLongBreakTime.Hint = "Long Break Time";
            this.tLongBreakTime.LeadingIcon = null;
            this.tLongBreakTime.Location = new System.Drawing.Point(12, 120);
            this.tLongBreakTime.MaxLength = 32767;
            this.tLongBreakTime.MouseState = TulparUI.MouseState.OUT;
            this.tLongBreakTime.Name = "tLongBreakTime";
            this.tLongBreakTime.PasswordChar = '\0';
            this.tLongBreakTime.PrefixSuffixText = null;
            this.tLongBreakTime.ReadOnly = false;
            this.tLongBreakTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tLongBreakTime.SelectedText = "";
            this.tLongBreakTime.SelectionLength = 0;
            this.tLongBreakTime.SelectionStart = 0;
            this.tLongBreakTime.ShortcutsEnabled = true;
            this.tLongBreakTime.Size = new System.Drawing.Size(154, 48);
            this.tLongBreakTime.TabIndex = 3;
            this.tLongBreakTime.TabStop = false;
            this.tLongBreakTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tLongBreakTime.TrailingIcon = null;
            this.tLongBreakTime.UseSystemPasswordChar = false;
            // 
            // cPomodoroAlarm
            // 
            this.cPomodoroAlarm.AutoResize = false;
            this.cPomodoroAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cPomodoroAlarm.Depth = 0;
            this.cPomodoroAlarm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cPomodoroAlarm.DropDownHeight = 174;
            this.cPomodoroAlarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cPomodoroAlarm.DropDownWidth = 121;
            this.cPomodoroAlarm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cPomodoroAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cPomodoroAlarm.FormattingEnabled = true;
            this.cPomodoroAlarm.Hint = "Pomodoro Alarm";
            this.cPomodoroAlarm.IntegralHeight = false;
            this.cPomodoroAlarm.ItemHeight = 43;
            this.cPomodoroAlarm.Location = new System.Drawing.Point(172, 11);
            this.cPomodoroAlarm.MaxDropDownItems = 4;
            this.cPomodoroAlarm.MouseState = TulparUI.MouseState.OUT;
            this.cPomodoroAlarm.Name = "cPomodoroAlarm";
            this.cPomodoroAlarm.Size = new System.Drawing.Size(293, 49);
            this.cPomodoroAlarm.StartIndex = 0;
            this.cPomodoroAlarm.TabIndex = 4;
            // 
            // cShortBreakAlarm
            // 
            this.cShortBreakAlarm.AutoResize = false;
            this.cShortBreakAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cShortBreakAlarm.Depth = 0;
            this.cShortBreakAlarm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cShortBreakAlarm.DropDownHeight = 174;
            this.cShortBreakAlarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cShortBreakAlarm.DropDownWidth = 121;
            this.cShortBreakAlarm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cShortBreakAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cShortBreakAlarm.FormattingEnabled = true;
            this.cShortBreakAlarm.Hint = "Short Break Alarm";
            this.cShortBreakAlarm.IntegralHeight = false;
            this.cShortBreakAlarm.ItemHeight = 43;
            this.cShortBreakAlarm.Location = new System.Drawing.Point(172, 66);
            this.cShortBreakAlarm.MaxDropDownItems = 4;
            this.cShortBreakAlarm.MouseState = TulparUI.MouseState.OUT;
            this.cShortBreakAlarm.Name = "cShortBreakAlarm";
            this.cShortBreakAlarm.Size = new System.Drawing.Size(293, 49);
            this.cShortBreakAlarm.StartIndex = 0;
            this.cShortBreakAlarm.TabIndex = 5;
            // 
            // cLongBreakAlarm
            // 
            this.cLongBreakAlarm.AutoResize = false;
            this.cLongBreakAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cLongBreakAlarm.Depth = 0;
            this.cLongBreakAlarm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cLongBreakAlarm.DropDownHeight = 174;
            this.cLongBreakAlarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLongBreakAlarm.DropDownWidth = 121;
            this.cLongBreakAlarm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cLongBreakAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cLongBreakAlarm.FormattingEnabled = true;
            this.cLongBreakAlarm.Hint = "Long Break Alarm";
            this.cLongBreakAlarm.IntegralHeight = false;
            this.cLongBreakAlarm.ItemHeight = 43;
            this.cLongBreakAlarm.Location = new System.Drawing.Point(172, 121);
            this.cLongBreakAlarm.MaxDropDownItems = 4;
            this.cLongBreakAlarm.MouseState = TulparUI.MouseState.OUT;
            this.cLongBreakAlarm.Name = "cLongBreakAlarm";
            this.cLongBreakAlarm.Size = new System.Drawing.Size(293, 49);
            this.cLongBreakAlarm.StartIndex = 0;
            this.cLongBreakAlarm.TabIndex = 6;
            // 
            // BtnSina
            // 
            this.BtnSina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSina.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnSina.Depth = 0;
            this.BtnSina.HighEmphasis = true;
            this.BtnSina.Icon = null;
            this.BtnSina.Location = new System.Drawing.Point(472, 24);
            this.BtnSina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSina.MouseState = TulparUI.MouseState.HOVER;
            this.BtnSina.Name = "BtnSina";
            this.BtnSina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSina.Size = new System.Drawing.Size(64, 36);
            this.BtnSina.TabIndex = 7;
            this.BtnSina.Text = "Sına";
            this.BtnSina.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnSina.UseAccentColor = false;
            this.BtnSina.UseVisualStyleBackColor = true;
            this.BtnSina.Click += new System.EventHandler(this.BtnSina_Click);
            // 
            // BtnSinaShort
            // 
            this.BtnSinaShort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSinaShort.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnSinaShort.Depth = 0;
            this.BtnSinaShort.HighEmphasis = true;
            this.BtnSinaShort.Icon = null;
            this.BtnSinaShort.Location = new System.Drawing.Point(472, 79);
            this.BtnSinaShort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSinaShort.MouseState = TulparUI.MouseState.HOVER;
            this.BtnSinaShort.Name = "BtnSinaShort";
            this.BtnSinaShort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSinaShort.Size = new System.Drawing.Size(64, 36);
            this.BtnSinaShort.TabIndex = 8;
            this.BtnSinaShort.Text = "Sına";
            this.BtnSinaShort.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnSinaShort.UseAccentColor = false;
            this.BtnSinaShort.UseVisualStyleBackColor = true;
            this.BtnSinaShort.Click += new System.EventHandler(this.BtnSinaShort_Click);
            // 
            // BtnSinaLong
            // 
            this.BtnSinaLong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSinaLong.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnSinaLong.Depth = 0;
            this.BtnSinaLong.HighEmphasis = true;
            this.BtnSinaLong.Icon = null;
            this.BtnSinaLong.Location = new System.Drawing.Point(472, 134);
            this.BtnSinaLong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSinaLong.MouseState = TulparUI.MouseState.HOVER;
            this.BtnSinaLong.Name = "BtnSinaLong";
            this.BtnSinaLong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSinaLong.Size = new System.Drawing.Size(64, 36);
            this.BtnSinaLong.TabIndex = 9;
            this.BtnSinaLong.Text = "Sına";
            this.BtnSinaLong.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnSinaLong.UseAccentColor = false;
            this.BtnSinaLong.UseVisualStyleBackColor = true;
            this.BtnSinaLong.Click += new System.EventHandler(this.BtnSinaLong_Click);
            // 
            // cMusic
            // 
            this.cMusic.AutoResize = false;
            this.cMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cMusic.Depth = 0;
            this.cMusic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cMusic.DropDownHeight = 174;
            this.cMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMusic.DropDownWidth = 121;
            this.cMusic.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cMusic.FormattingEnabled = true;
            this.cMusic.Hint = "Çalışma Müziği";
            this.cMusic.IntegralHeight = false;
            this.cMusic.ItemHeight = 43;
            this.cMusic.Location = new System.Drawing.Point(543, 11);
            this.cMusic.MaxDropDownItems = 4;
            this.cMusic.MouseState = TulparUI.MouseState.OUT;
            this.cMusic.Name = "cMusic";
            this.cMusic.Size = new System.Drawing.Size(293, 49);
            this.cMusic.StartIndex = 0;
            this.cMusic.TabIndex = 10;
            // 
            // BtnSinaMusic
            // 
            this.BtnSinaMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSinaMusic.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnSinaMusic.Depth = 0;
            this.BtnSinaMusic.HighEmphasis = true;
            this.BtnSinaMusic.Icon = null;
            this.BtnSinaMusic.Location = new System.Drawing.Point(843, 24);
            this.BtnSinaMusic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSinaMusic.MouseState = TulparUI.MouseState.HOVER;
            this.BtnSinaMusic.Name = "BtnSinaMusic";
            this.BtnSinaMusic.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSinaMusic.Size = new System.Drawing.Size(64, 36);
            this.BtnSinaMusic.TabIndex = 11;
            this.BtnSinaMusic.Text = "Sına";
            this.BtnSinaMusic.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnSinaMusic.UseAccentColor = false;
            this.BtnSinaMusic.UseVisualStyleBackColor = true;
            this.BtnSinaMusic.Click += new System.EventHandler(this.BtnSinaMusic_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.BtnSinaMusic);
            this.Controls.Add(this.cMusic);
            this.Controls.Add(this.BtnSinaLong);
            this.Controls.Add(this.BtnSinaShort);
            this.Controls.Add(this.BtnSina);
            this.Controls.Add(this.cLongBreakAlarm);
            this.Controls.Add(this.cShortBreakAlarm);
            this.Controls.Add(this.cPomodoroAlarm);
            this.Controls.Add(this.tLongBreakTime);
            this.Controls.Add(this.tShortBreakTime);
            this.Controls.Add(this.tPomodoroTime);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TulparUI.Controls.TulparButton BtnSave;
        public TulparUI.Controls.TulparTextBox tPomodoroTime;
        public TulparUI.Controls.TulparTextBox tShortBreakTime;
        public TulparUI.Controls.TulparTextBox tLongBreakTime;
        private TulparUI.Controls.TulparComboBox cPomodoroAlarm;
        private TulparUI.Controls.TulparComboBox cShortBreakAlarm;
        private TulparUI.Controls.TulparComboBox cLongBreakAlarm;
        private TulparUI.Controls.TulparButton BtnSina;
        private TulparUI.Controls.TulparButton BtnSinaShort;
        private TulparUI.Controls.TulparButton BtnSinaLong;
        private TulparUI.Controls.TulparComboBox cMusic;
        private TulparUI.Controls.TulparButton BtnSinaMusic;
    }
}