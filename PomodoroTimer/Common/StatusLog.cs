namespace PomodoroTimer
{
    internal class StatusLog
    {
        public static void StatusText(string Msg)
        {
            Globals.mainForm.LbMsg.Text = Msg;
        }
    }
}
