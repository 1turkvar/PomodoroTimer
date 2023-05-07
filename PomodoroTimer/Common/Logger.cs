using System;
using System.IO;

namespace PomodoroTimer
{
    internal class Logger
    {
        /// <summary>
        /// Hata yakalayıp kayıt etmek
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="kaynak"></param>
        public static void WriteError(string msg, string kaynak)
        {
            try
            {
                FileStream stream = new FileStream("Pomodoro_ErrorLog.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(stream);
                streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
                streamWriter.WriteLine(">>> " + DateTime.Now.ToString() + " KAYNAK: [" + kaynak + "]\n{");
                streamWriter.WriteLine(msg);
                streamWriter.WriteLine("}\n\n");
                streamWriter.Close();
            }
            catch { }
        }
    }
}
