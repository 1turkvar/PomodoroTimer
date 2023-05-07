using PomodoroTimer;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class MainForm : Form
    {
        public int pomodoroDuration = (Convert.ToInt32(Globals.pomodoroTime) * 60);
        public int pomodoroBreak = (Convert.ToInt32(Globals.shortBreakTime) * 60);
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Globals.mainForm = this;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Config.LoadConfig();
            OpenForm.Form(new SettingsForm());
        }

        private void WorkTimer_Tick(object sender, EventArgs e)
        {
            if (switchMusic.Checked == true)
            {
                PlayMp3.audioThread = new Thread(() => PlayMp3.PlayMP3(Application.StartupPath + "\\Sounds\\\\workingSounds\\" + Globals.workMusic, pomodoroDuration));
                PlayMp3.audioThread.Start();
            }

            if (pomodoroDuration > 0)
            {
                pomodoroDuration--;
                lbPomodoroTime.Text = TimeSpan.FromSeconds(pomodoroDuration).ToString(@"hh\:mm\:ss");
            }
            else
            {
                PlayMp3.PlayAlert(Application.StartupPath + "\\Sounds\\alarmSounds\\" + Globals.pomodoroAlarm);
                workTimer.Stop();
                LbMsg.Text = ("Pomodoro tamamlandı. Mola verin!");
                BtnStart.Enabled = false;
                BtnShortBreakStart.Enabled = true;
                pomodoroDuration = (Convert.ToInt32(Globals.settingsForm.tPomodoroTime.Text) * 60);
            }
        }

        private void BreakTimer_Tick(object sender, EventArgs e)
        {
            LbMsg.Text = ("Mola başladı!");

            if (pomodoroBreak > 0)
            {
                pomodoroBreak--;
                lbPomodoroTime.Text = TimeSpan.FromSeconds(pomodoroBreak).ToString(@"hh\:mm\:ss");
            }
            else
            {
                PlayMp3.PlayAlert(Application.StartupPath + "\\Sounds\\alarmSounds\\" + Globals.shortBreakAlarm);
                breakTimer.Stop();
                BtnStart.Enabled = true;
                BtnShortBreakStart.Enabled = false;
                pomodoroBreak = (Convert.ToInt32(Globals.settingsForm.tShortBreakTime.Text) * 60);
                LbMsg.Text = ("Mola tamamlandı!");
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            workTimer.Start();
            StatusLog.StatusText("Çalışma Süresi Başaldı!");
        }

        private void BtnBreakStart_Click(object sender, EventArgs e)
        {
            breakTimer.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            workTimer.Stop();
            breakTimer.Stop();
            pomodoroDuration = (Convert.ToInt32(Globals.pomodoroTime) * 60);
            pomodoroBreak = (Convert.ToInt32(Globals.shortBreakTime) * 60);

            PlayMp3.StopPlayingMP3();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.settingsForm.Close();
        }

        private void BtnDuraklat_Click(object sender, EventArgs e)
        {
            workTimer.Stop();
            breakTimer.Stop();
        }
    }
}
