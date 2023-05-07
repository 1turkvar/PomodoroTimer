using System;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            IniFiles myIni = new IniFiles(Application.StartupPath + "\\settings.ini");
            myIni.Write("PomodoroTimer", "pomodoroTime", tPomodoroTime.Text);
            myIni.Write("PomodoroTimer", "shortBreakTime", tShortBreakTime.Text);
            myIni.Write("PomodoroTimer", "pomodoroAlarm", cPomodoroAlarm.Text);
            myIni.Write("PomodoroTimer", "shortBreakAlarm", cShortBreakAlarm.Text);
            myIni.Write("PomodoroTimer", "longBreakAlarm", cLongBreakAlarm.Text);
            myIni.Write("PomodoroTimer", "pomodoroMusic", cMusic.Text);

            Config.LoadConfig();
            OpenForm.Form(new MainForm());
            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Globals.settingsForm = this;

            Mp3FileName.FillComboBoxWithFileNames(Application.StartupPath + "\\Sounds\\alarmSounds", cPomodoroAlarm);
            Mp3FileName.FillComboBoxWithFileNames(Application.StartupPath + "\\Sounds\\alarmSounds", cShortBreakAlarm);
            Mp3FileName.FillComboBoxWithFileNames(Application.StartupPath + "\\Sounds\\alarmSounds", cLongBreakAlarm);
            Mp3FileName.FillComboBoxWithFileNames(Application.StartupPath + "\\Sounds\\\\workingSounds", cMusic);

            tPomodoroTime.Text = Globals.pomodoroTime.ToString();
            tShortBreakTime.Text = Globals.shortBreakTime.ToString();
            tLongBreakTime.Text = Globals.longBreakTime.ToString();

            cPomodoroAlarm.Text = Globals.pomodoroAlarm;
            cShortBreakAlarm.Text = Globals.shortBreakAlarm;
            cLongBreakAlarm.Text = Globals.longBreakAlarm;
            cMusic.Text = Globals.workMusic;
        }

        private void BtnSina_Click(object sender, EventArgs e)
        {
            PlayMp3.PlayAlert(Application.StartupPath + "\\Sounds\\alarmSounds\\" + cPomodoroAlarm.Text);
        }

        private void BtnSinaShort_Click(object sender, EventArgs e)
        {
            PlayMp3.PlayAlert(Application.StartupPath + "\\Sounds\\alarmSounds\\" + cShortBreakAlarm.Text);
        }

        private void BtnSinaLong_Click(object sender, EventArgs e)
        {
            PlayMp3.PlayAlert(Application.StartupPath + "\\Sounds\\alarmSounds\\" + cLongBreakAlarm.Text);
        }

        private void BtnSinaMusic_Click(object sender, EventArgs e)
        {
            PlayMp3.PlayAlert(Application.StartupPath + "\\Sounds\\\\workingSounds\\" + cMusic.Text);
        }
    }
}
