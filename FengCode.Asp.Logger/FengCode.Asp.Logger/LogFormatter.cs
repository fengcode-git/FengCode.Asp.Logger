using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace FengCode.Asp.Logger
{
    internal class LogFormatter
    {
        public static string Handle<TState>(string name, LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
			StringBuilder stringBuilder = new StringBuilder();
			string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			stringBuilder.Append("[" + str + "]\t");
			stringBuilder.Append("[" + logLevel.ToString() + "]\t");
			stringBuilder.Append("[" + name + "]\t");
			bool flag = exception != null;
			if (flag)
			{
				stringBuilder.Append(exception.ToString() + "\t");
			}
			string value = formatter(state, exception);
			stringBuilder.Append(value);
			return stringBuilder.ToString().Replace("\n", " ").Replace("\r", " ");
		}
    }
}
