namespace PomodoroTimer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lbPomodoroTime = new System.Windows.Forms.Label();
            this.BtnSettings = new TulparUI.Controls.TulparButton();
            this.BtnStart = new TulparUI.Controls.TulparButton();
            this.BtnStop = new TulparUI.Controls.TulparButton();
            this.CardStartStop = new TulparUI.Controls.TulparCard();
            this.switchMusic = new TulparUI.Controls.TulparSwitch();
            this.BtnLongBreakStart = new TulparUI.Controls.TulparButton();
            this.BtnDuraklat = new TulparUI.Controls.TulparButton();
            this.BtnShortBreakStart = new TulparUI.Controls.TulparButton();
            this.CardSettings = new TulparUI.Controls.TulparCard();
            this.tulparCard1 = new TulparUI.Controls.TulparCard();
            this.BtnExit = new TulparUI.Controls.TulparButton();
            this.LbMsg = new System.Windows.Forms.Label();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CardStartStop.SuspendLayout();
            this.CardSettings.SuspendLayout();
            this.tulparCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPomodoroTime
            // 
            this.lbPomodoroTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPomodoroTime.Font = new System.Drawing.Font("Tempus Sans ITC", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPomodoroTime.Location = new System.Drawing.Point(0, 0);
            this.lbPomodoroTime.Name = "lbPomodoroTime";
            this.lbPomodoroTime.Size = new System.Drawing.Size(1200, 173);
            this.lbPomodoroTime.TabIndex = 0;
            this.lbPomodoroTime.Text = "00.00.00";
            this.lbPomodoroTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.AutoSize = false;
            this.BtnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSettings.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnSettings.Depth = 0;
            this.BtnSettings.HighEmphasis = true;
            this.BtnSettings.Icon = null;
            this.BtnSettings.Location = new System.Drawing.Point(18, 20);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSettings.MouseState = TulparUI.MouseState.HOVER;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSettings.Size = new System.Drawing.Size(80, 80);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "Ayarlar";
            this.BtnSettings.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnSettings.UseAccentColor = false;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.AutoSize = false;
            this.BtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStart.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnStart.Depth = 0;
            this.BtnStart.HighEmphasis = true;
            this.BtnStart.Icon = null;
            this.BtnStart.Location = new System.Drawing.Point(18, 22);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnStart.MouseState = TulparUI.MouseState.HOVER;
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnStart.Size = new System.Drawing.Size(80, 80);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Çalışmaya Başla";
            this.BtnStart.Type = TulparUI.Controls.TulparButton.TulparButtonType.Outlined;
            this.BtnStart.UseAccentColor = false;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.AutoSize = false;
            this.BtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStop.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnStop.Depth = 0;
            this.BtnStop.HighEmphasis = true;
            this.BtnStop.Icon = null;
            this.BtnStop.Location = new System.Drawing.Point(370, 20);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnStop.MouseState = TulparUI.MouseState.HOVER;
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnStop.Size = new System.Drawing.Size(80, 80);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Dur";
            this.BtnStop.Type = TulparUI.Controls.TulparButton.TulparButtonType.Outlined;
            this.BtnStop.UseAccentColor = false;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // CardStartStop
            // 
            this.CardStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardStartStop.Controls.Add(this.switchMusic);
            this.CardStartStop.Controls.Add(this.BtnLongBreakStart);
            this.CardStartStop.Controls.Add(this.BtnDuraklat);
            this.CardStartStop.Controls.Add(this.BtnShortBreakStart);
            this.CardStartStop.Controls.Add(this.BtnStart);
            this.CardStartStop.Controls.Add(this.BtnStop);
            this.CardStartStop.Depth = 0;
            this.CardStartStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardStartStop.Location = new System.Drawing.Point(353, 187);
            this.CardStartStop.Margin = new System.Windows.Forms.Padding(14);
            this.CardStartStop.MouseState = TulparUI.MouseState.HOVER;
            this.CardStartStop.Name = "CardStartStop";
            this.CardStartStop.Padding = new System.Windows.Forms.Padding(14);
            this.CardStartStop.Size = new System.Drawing.Size(471, 159);
            this.CardStartStop.TabIndex = 4;
            // 
            // switchMusic
            // 
            this.switchMusic.AutoSize = true;
            this.switchMusic.Depth = 0;
            this.switchMusic.Location = new System.Drawing.Point(14, 108);
            this.switchMusic.Margin = new System.Windows.Forms.Padding(0);
            this.switchMusic.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchMusic.MouseState = TulparUI.MouseState.HOVER;
            this.switchMusic.Name = "switchMusic";
            this.switchMusic.Ripple = true;
            this.switchMusic.Size = new System.Drawing.Size(90, 37);
            this.switchMusic.TabIndex = 8;
            this.switchMusic.Text = "Müzik";
            this.switchMusic.UseVisualStyleBackColor = true;
            this.switchMusic.Visible = false;
            // 
            // BtnLongBreakStart
            // 
            this.BtnLongBreakStart.AutoSize = false;
            this.BtnLongBreakStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLongBreakStart.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnLongBreakStart.Depth = 0;
            this.BtnLongBreakStart.Enabled = false;
            this.BtnLongBreakStart.HighEmphasis = true;
            this.BtnLongBreakStart.Icon = null;
            this.BtnLongBreakStart.Location = new System.Drawing.Point(194, 22);
            this.BtnLongBreakStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLongBreakStart.MouseState = TulparUI.MouseState.HOVER;
            this.BtnLongBreakStart.Name = "BtnLongBreakStart";
            this.BtnLongBreakStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnLongBreakStart.Size = new System.Drawing.Size(80, 80);
            this.BtnLongBreakStart.TabIndex = 10;
            this.BtnLongBreakStart.Text = "Uzun Molaya Başla";
            this.BtnLongBreakStart.Type = TulparUI.Controls.TulparButton.TulparButtonType.Outlined;
            this.BtnLongBreakStart.UseAccentColor = false;
            this.BtnLongBreakStart.UseVisualStyleBackColor = true;
            // 
            // BtnDuraklat
            // 
            this.BtnDuraklat.AutoSize = false;
            this.BtnDuraklat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDuraklat.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnDuraklat.Depth = 0;
            this.BtnDuraklat.HighEmphasis = true;
            this.BtnDuraklat.Icon = null;
            this.BtnDuraklat.Location = new System.Drawing.Point(282, 22);
            this.BtnDuraklat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDuraklat.MouseState = TulparUI.MouseState.HOVER;
            this.BtnDuraklat.Name = "BtnDuraklat";
            this.BtnDuraklat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDuraklat.Size = new System.Drawing.Size(80, 80);
            this.BtnDuraklat.TabIndex = 9;
            this.BtnDuraklat.Text = "Duraklat";
            this.BtnDuraklat.Type = TulparUI.Controls.TulparButton.TulparButtonType.Outlined;
            this.BtnDuraklat.UseAccentColor = false;
            this.BtnDuraklat.UseVisualStyleBackColor = true;
            this.BtnDuraklat.Click += new System.EventHandler(this.BtnDuraklat_Click);
            // 
            // BtnShortBreakStart
            // 
            this.BtnShortBreakStart.AutoSize = false;
            this.BtnShortBreakStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnShortBreakStart.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnShortBreakStart.Depth = 0;
            this.BtnShortBreakStart.Enabled = false;
            this.BtnShortBreakStart.HighEmphasis = true;
            this.BtnShortBreakStart.Icon = null;
            this.BtnShortBreakStart.Location = new System.Drawing.Point(106, 22);
            this.BtnShortBreakStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnShortBreakStart.MouseState = TulparUI.MouseState.HOVER;
            this.BtnShortBreakStart.Name = "BtnShortBreakStart";
            this.BtnShortBreakStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnShortBreakStart.Size = new System.Drawing.Size(80, 80);
            this.BtnShortBreakStart.TabIndex = 8;
            this.BtnShortBreakStart.Text = "Kısa Molaya Başla";
            this.BtnShortBreakStart.Type = TulparUI.Controls.TulparButton.TulparButtonType.Outlined;
            this.BtnShortBreakStart.UseAccentColor = false;
            this.BtnShortBreakStart.UseVisualStyleBackColor = true;
            this.BtnShortBreakStart.Click += new System.EventHandler(this.BtnBreakStart_Click);
            // 
            // CardSettings
            // 
            this.CardSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardSettings.Controls.Add(this.BtnSettings);
            this.CardSettings.Depth = 0;
            this.CardSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardSettings.Location = new System.Drawing.Point(23, 187);
            this.CardSettings.Margin = new System.Windows.Forms.Padding(14);
            this.CardSettings.MouseState = TulparUI.MouseState.HOVER;
            this.CardSettings.Name = "CardSettings";
            this.CardSettings.Padding = new System.Windows.Forms.Padding(14);
            this.CardSettings.Size = new System.Drawing.Size(120, 122);
            this.CardSettings.TabIndex = 5;
            // 
            // tulparCard1
            // 
            this.tulparCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tulparCard1.Controls.Add(this.BtnExit);
            this.tulparCard1.Depth = 0;
            this.tulparCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tulparCard1.Location = new System.Drawing.Point(1057, 187);
            this.tulparCard1.Margin = new System.Windows.Forms.Padding(14);
            this.tulparCard1.MouseState = TulparUI.MouseState.HOVER;
            this.tulparCard1.Name = "tulparCard1";
            this.tulparCard1.Padding = new System.Windows.Forms.Padding(14);
            this.tulparCard1.Size = new System.Drawing.Size(120, 122);
            this.tulparCard1.TabIndex = 6;
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = false;
            this.BtnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExit.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtnExit.Depth = 0;
            this.BtnExit.HighEmphasis = true;
            this.BtnExit.Icon = null;
            this.BtnExit.Location = new System.Drawing.Point(22, 22);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExit.MouseState = TulparUI.MouseState.HOVER;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnExit.Size = new System.Drawing.Size(80, 80);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Kapat";
            this.BtnExit.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtnExit.UseAccentColor = false;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbMsg
            // 
            this.LbMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbMsg.Font = new System.Drawing.Font("Tw Cen MT Condensed", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMsg.Location = new System.Drawing.Point(0, 360);
            this.LbMsg.Name = "LbMsg";
            this.LbMsg.Size = new System.Drawing.Size(1200, 173);
            this.LbMsg.TabIndex = 7;
            this.LbMsg.Text = "Pomodoro Timer";
            this.LbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workTimer
            // 
            this.workTimer.Interval = 1000;
            this.workTimer.Tick += new System.EventHandler(this.WorkTimer_Tick);
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.BreakTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbMsg);
            this.Controls.Add(this.tulparCard1);
            this.Controls.Add(this.CardSettings);
            this.Controls.Add(this.CardStartStop);
            this.Controls.Add(this.lbPomodoroTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CardStartStop.ResumeLayout(false);
            this.CardStartStop.PerformLayout();
            this.CardSettings.ResumeLayout(false);
            this.tulparCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPomodoroTime;
        private TulparUI.Controls.TulparButton BtnSettings;
        private TulparUI.Controls.TulparButton BtnStart;
        private TulparUI.Controls.TulparButton BtnStop;
        private TulparUI.Controls.TulparCard CardStartStop;
        private TulparUI.Controls.TulparCard CardSettings;
        private TulparUI.Controls.TulparCard tulparCard1;
        private TulparUI.Controls.TulparButton BtnExit;
        private System.Windows.Forms.Timer workTimer;
        private System.Windows.Forms.Timer breakTimer;
        private TulparUI.Controls.TulparButton BtnShortBreakStart;
        public System.Windows.Forms.Label LbMsg;
        private TulparUI.Controls.TulparButton BtnDuraklat;
        private TulparUI.Controls.TulparButton BtnLongBreakStart;
        private TulparUI.Controls.TulparSwitch switchMusic;
        private System.Windows.Forms.Label label1;
    }
}