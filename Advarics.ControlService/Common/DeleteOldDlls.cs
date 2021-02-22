using System;
using System.IO;
using System.Linq;

namespace Advarics.ControlService.Common
{
	public class DeleteOldDlls
	{

		public static void Delete(string customerBaseDir)
		{


			var binDir = Directory.GetDirectories(customerBaseDir);


			foreach (string fileSource in binDir)
			{
				if (fileSource.Contains("v12.2") || fileSource.Contains("IdeaBlade.EntityModel.Edm.dll"))
				{
					Log.LogEntry(DateTime.Now, "-", "-", null, "Delete Old File: " + fileSource, "0", false, false, DateTime.Now, 0, "Server", "-", Log.LogStatus.OK);
					File.Delete(fileSource);
				}
			}

		}

		internal static void DeleteJS(string customerWebAppDir)
		{
			Log.LogEntry(DateTime.Now, "-", "-", null, "Start Delete Old Folder: " + customerWebAppDir, "0", false, false, DateTime.Now, 0, "Server", "-", Log.LogStatus.OK);

			if (Directory.Exists(customerWebAppDir))
			{

				var allFiles = Directory.GetFiles(customerWebAppDir);

				//Die config.json sollte ausgeschlossen werden, damit immer eine funktionierende Version der config.json für die webapp  für den Fall, das der DBUpdater scheitert
				var filesToExclude = Directory.GetFiles(customerWebAppDir, "config.json", 0);

				var files = allFiles.Except(filesToExclude);


				if (files != null)
				{
					foreach (string fileSource in files)
					{
						try
						{
							if (File.Exists(fileSource) == true)
							{
								Log.LogEntry(DateTime.Now, "-", "-", null, "Delete Old File: " + fileSource, "0", false, false, DateTime.Now, 0, "Server", "-", Log.LogStatus.OK);
								File.Delete(fileSource);
							}
						}
						catch (Exception)
						{

							Log.LogEntry(DateTime.Now, "-", "-", null, "Delete Old File: " + fileSource, "0", false, false, DateTime.Now, 0, "Server", "-", Log.LogStatus.ERROR);
						}


					}
				}
			}
		}
	}
}