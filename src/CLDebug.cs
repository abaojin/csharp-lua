﻿using System;

namespace CsharpLua.Tools
{
	public class CLDebug
	{
		public static Action<object> Log = NoAction;
		public static Action<object> LogError = NoAction;

		private static void NoAction(object msg) { }

		static CLDebug()
		{
            Log = LogMessage;
            LogError = ErrorMessage;
        }

        private static void LogMessage(object msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private static void ErrorMessage(object msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}

