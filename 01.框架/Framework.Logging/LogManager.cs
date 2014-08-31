using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace Framework.Logging {
	public class LogManager {
		public static void Log(LogLevel level, object message, Exception exception, MethodBase method) {
			throw new NotImplementedException();
			/*
			Console.Write("Level:\t");
			Console.WriteLine(level);
			Console.Write("Message:\t");
			Console.WriteLine(message);
			Console.Write("Exception:\t");
			Console.WriteLine(exception == null ? "null" : exception.StackTrace);
			Console.Write("Type:\t");
			Console.WriteLine(method.DeclaringType.FullName);
			Console.Write("Method:\t");
			Console.WriteLine(method.Name);
			 * */
		}
		public static void Fatal(object message, Exception exception, MethodBase method) {
			Log(LogLevel.Fatal, message, exception, method);
		}
		public static void Fatal(object message, Exception exception) {
			Log(LogLevel.Fatal, message, exception, (new StackTrace()).GetFrame(1).GetMethod());
		}
		public static void Fatal(object message, MethodBase method) {
			Log(LogLevel.Fatal, message, null, method);
		}
		public static void Fatal(object message) {
			Log(LogLevel.Fatal, message, null, (new StackTrace()).GetFrame(1).GetMethod());
		}

		public static void Error(object message, Exception exception, MethodBase method) {
			Log(LogLevel.Error, message, exception, method);
		}
		public static void Error(object message, Exception exception) {
			Log(LogLevel.Error, message, exception, (new StackTrace()).GetFrame(1).GetMethod());
		}
		public static void Error(object message, MethodBase method) {
			Log(LogLevel.Error, message, null, method);
		}
		public static void Error(object message) {
			Log(LogLevel.Error, message, null, (new StackTrace()).GetFrame(1).GetMethod());
		}

		public static void Warn(object message, Exception exception, MethodBase method) {
			Log(LogLevel.Warn, message, exception, method);
		}
		public static void Warn(object message, Exception exception) {
			Log(LogLevel.Warn, message, exception, (new StackTrace()).GetFrame(1).GetMethod());
		}
		public static void Warn(object message, MethodBase method) {
			Log(LogLevel.Warn, message, null, method);
		}
		public static void Warn(object message) {
			Log(LogLevel.Warn, message, null, (new StackTrace()).GetFrame(1).GetMethod());
		}

		public static void Info(object message, Exception exception, MethodBase method) {
			Log(LogLevel.Info, message, exception, method);
		}
		public static void Info(object message, Exception exception) {
			Log(LogLevel.Info, message, exception, (new StackTrace()).GetFrame(1).GetMethod());
		}
		public static void Info(object message, MethodBase method) {
			Log(LogLevel.Info, message, null, method);
		}
		public static void Info(object message) {
			Log(LogLevel.Info, message, null, (new StackTrace()).GetFrame(1).GetMethod());
		}

		public static void Debug(object message, Exception exception, MethodBase method) {
			Log(LogLevel.Debug, message, exception, method);
		}
		public static void Debug(object message, Exception exception) {
			Log(LogLevel.Debug, message, exception, (new StackTrace()).GetFrame(1).GetMethod());
		}
		public static void Debug(object message, MethodBase method) {
			Log(LogLevel.Debug, message, null, method);
		}
		public static void Debug(object message) {
			Log(LogLevel.Debug, message, null, (new StackTrace()).GetFrame(1).GetMethod());
		}

		public static void All(object message, Exception exception, MethodBase method) {
			Log(LogLevel.All, message, exception, method);
		}
		public static void All(object message, Exception exception) {
			Log(LogLevel.All, message, exception, (new StackTrace()).GetFrame(1).GetMethod());
		}
		public static void All(object message, MethodBase method) {
			Log(LogLevel.All, message, null, method);
		}
		public static void All(object message) {
			Log(LogLevel.All, message, null, (new StackTrace()).GetFrame(1).GetMethod());
		}

	}
}
