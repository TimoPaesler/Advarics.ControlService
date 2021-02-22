using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Advarics.ControlService.DataContracts.FileTransfer;

namespace Advarics.ControlService.Common
{
	public class Log
	{
		public Log()
		{
		}


		public static LogResponse LogEntry(DateTime date, string path, string customerName, Exception exception, string info, string workerPackageNo, bool error, bool workerSuccessful, DateTime workerStartTime, int workerErrorCount, string description, string serverName, LogStatus status)
		{
			LogResponse logEntry = new LogResponse();
			try
			{
				logEntry = WriteResponseLog(date, path, customerName, exception, info, workerPackageNo, error, workerSuccessful, workerStartTime, workerErrorCount, description, serverName);
				WriteFileLog(GetLogDateTimeString(date) + "\t" + status.ToString() + "\t" + info + "\t" + path + "\t" + exception);
			}
			catch (Exception e)
			{

			}

			return logEntry;
		}

		private static void WriteFileLog(string message)
		{
			try
			{
				string logFileName = AppDomain.CurrentDomain.BaseDirectory + "\\ControlServiceLog.txt";

				StreamWriter logStream;
				logStream = File.AppendText(logFileName);
				logStream.WriteLine(message);
				logStream.Close();

			}
			catch (Exception) { }
		}

		private static LogResponse WriteResponseLog(DateTime date, string path, string customerName, Exception exception, string info, string workerPackageNo, bool error, bool workerSuccessful, DateTime workerStartTime, int workerErrorCount, string description, string serverName)
		{
			LogResponse logEntry = new LogResponse();
			logEntry.CustomerName = customerName;
			logEntry.Date = date;
			logEntry.Description = description;
			logEntry.Error = error;
			logEntry.Exception = exception;
			logEntry.Info = info;
			logEntry.Path = path;
			logEntry.ServerName = serverName;
			logEntry.WorkerErrorCount = workerErrorCount;
			logEntry.workerPackageNo = workerPackageNo;
			logEntry.WorkerStartTime = workerStartTime;
			logEntry.WorkerSuccessful = workerSuccessful;




			return logEntry;
		}

		public enum LogStatus
		{
			OK,
			WARNING,
			ERROR
		}

		private static string GetLogDateTimeString(DateTime date)
		{
			return date.ToShortDateString() + " " + date.ToLongTimeString() + "\t";
		}
	}
}