﻿using System.Text;

namespace PomodoroTimer
{
    public class UTF8String
    {
        public static string ConvertUTF8String(string Value)
        {
            byte[] bytes = Encoding.Default.GetBytes(Value);
            Value = Encoding.UTF8.GetString(bytes);
            return Value;
        }
    }
}
