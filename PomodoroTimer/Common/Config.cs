using System;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class Config
    {
        public static IniFiles iniFiles = new IniFiles(Application.StartupPath + "\\settings.ini");

        public static void LoadConfig()
        {
            IniFiles iniFiles = new IniFiles(Application.StartupPath + "\\settings.ini");

            Globals.pomodoroTime = Convert.ToInt32(iniFiles.Read("pomodoroTime"));
            Globals.shortBreakTime = Convert.ToInt32(iniFiles.Read("shortBreakTime"));
            Globals.longBreakTime = Convert.ToInt32(iniFiles.Read("longBreakTime"));

            Globals.pomodoroAlarm = iniFiles.Read("pomodoroAlarm");
            Globals.shortBreakAlarm = iniFiles.Read("shortBreakAlarm");
            Globals.longBreakAlarm = iniFiles.Read("longBreakAlarm");
            Globals.workMusic = iniFiles.Read("pomodoroMusic");
        }
    }
}
