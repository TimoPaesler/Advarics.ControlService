﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using Advarics.ControlService.DataContracts.FileTransfer;

namespace Advarics.ControlService.Common
{
    public class Copy
    {



        public static void CopyDirectoryWithIncludedFiles(string dirCopySource, string dirCopyTarget, bool action)
        {
            List<LogResponse> logResponse = new List<LogResponse>();

            // alle Unterverzeichnisse des aktuellen Verzeichnisses ermitteln
            string[] subDirectories = Directory.GetDirectories(dirCopySource);
            if (action == true)
            {
                List<string> subList = new List<string>();
                string[] subTargetDirectories = Directory.GetDirectories(dirCopyTarget);

                foreach (var item in subDirectories.ToList())
                {
                    if (subTargetDirectories.Where(x => x.Contains(item.Substring(item.LastIndexOf(@"\")))).Count() >= 1)
                    {
                        subList.Add(item);
                    }
                }
                subDirectories = subList.ToArray();
            }


            // Zielpfad erzeugen
            StringBuilder newTargetPath = new StringBuilder();
            {
                newTargetPath.Append(dirCopyTarget);
                if (action == false)
                {
                    newTargetPath.Append(dirCopySource.Substring(dirCopySource.LastIndexOf(@"\")));
                }
            }

            // wenn aktueller Ordner nicht existiert -> erstellen
            if (!Directory.Exists(newTargetPath.ToString()))
                Directory.CreateDirectory(newTargetPath.ToString());

            // Unterverzeichnise durchlaufen und Funktion mit dazu gehörigen Zielpfad erneut aufrufen (Rekursion)
            foreach (string subDirectory in subDirectories)
            {
                string newDirectoryPath = subDirectory;

                // wenn ''/'' an letzter Stelle dann entfernen
                if (newDirectoryPath.LastIndexOf(@"\") == (newDirectoryPath.Length - 1))
                    newDirectoryPath = newDirectoryPath.Substring(0, newDirectoryPath.Length - 1);

                //hatte keine Auswirkungen gezeigt..
                //File.SetAttributes(newDirectoryPath, FileAttributes.Normal);

                // rekursiever Aufruf
                CopyDirectoryWithIncludedFiles(newDirectoryPath, newTargetPath.ToString(), false);
            }

            // alle enthaltenden Dateien des aktuellen Verzeichnisses ermitteln
            string[] fileNames = Directory.GetFiles(dirCopySource);
            foreach (string fileSource in fileNames)
            {
                // Zielpfad + Dateiname
                StringBuilder fileTarget = new StringBuilder();
                {
                    fileTarget.Append(newTargetPath);
                    fileTarget.Append(fileSource.Substring(fileSource.LastIndexOf(@"\")));
                }

                // Datei kopieren, wenn schon vorhanden überschreiben
                if ((IgnoreFileList.Retail(new FileInfo(fileSource)) == true) || fileSource.Contains(@"\webapp\")) //@"\..\" eingefügt zum Testen
                {
                    try
                    {

                        File.Copy(fileSource, fileTarget.ToString(), true);
                    }
                    catch (Exception e)
                    {
                        logResponse.Add(Log.LogEntry(DateTime.Now, "-", "-", null, "Error by copying File:" + fileTarget.ToString() + e.Message + e.InnerException?.ToString(), 0, false, false, DateTime.Now, 0, "Server", "-", Log.LogStatus.ERROR));
                    }
                }
            }

        }





        #region -CopyDirectoryWithIncludedFiles(string dirCopySource, string dirCopyTarget)
        #region XML-Doku
        /// <summary>
        ///     Kopiert das angegebene Quellverzeichnis mit den beinhaltenden Verzeichnissen und Dateien in das angegebene Zielverzeichnis.
        /// </summary>
        /// <param name="dirCopySource">
        ///     Verzeichnis das kopiert werden soll mit dem gesamten Inhalt
        /// </param>
        /// <param name="dirCopyTarget">
        ///     Verzeichnis in dem das Quellverzeichnis kopiert werden soll
        /// </param>
        #endregion
        public static void CopyDirectoryWithIncludedFilesAll(string dirCopySource, string dirCopyTarget)
        {
            // alle Unterverzeichnisse des aktuellen Verzeichnisses ermitteln
            string[] subDirectories = Directory.GetDirectories(dirCopySource);

            // Zielpfad erzeugen
            StringBuilder newTargetPath = new StringBuilder();

            {
                newTargetPath.Append(dirCopyTarget);
                newTargetPath.Append(dirCopySource.Substring(dirCopySource.LastIndexOf(@"\")));
            }

            // wenn aktueller Ordner nicht existiert -> erstellen
            if (!Directory.Exists(newTargetPath.ToString()))
                Directory.CreateDirectory(newTargetPath.ToString());


            // Unterverzeichnise durchlaufen und Funktion mit dazu gehörigen Zielpfad erneut aufrufen (Rekursion)
            foreach (string subDirectory in subDirectories)
            {
                string newDirectoryPath = subDirectory;

                // wenn ''/'' an letzter Stelle dann entfernen
                if (newDirectoryPath.LastIndexOf(@"\") == (newDirectoryPath.Length - 1))
                    newDirectoryPath = newDirectoryPath.Substring(0, newDirectoryPath.Length - 1);

                // rekursiever Aufruf
                CopyDirectoryWithIncludedFilesAll(newDirectoryPath, newTargetPath.ToString());
            }


            // alle enthaltenden Dateien des aktuellen Verzeichnisses ermitteln
            string[] fileNames = Directory.GetFiles(dirCopySource);
            foreach (string fileSource in fileNames)
            {
                // Zielpfad + Dateiname
                StringBuilder fileTarget = new StringBuilder();
                {
                    fileTarget.Append(newTargetPath);
                    fileTarget.Append(fileSource.Substring(fileSource.LastIndexOf(@"\")));
                }

                // Datei kopieren, wenn schon vorhanden überschreiben
                File.Copy(fileSource, fileTarget.ToString(), true);
            }
        }
        #endregion

        public static void CopyOneFile(string sourceFile, string destinationFile)
        {
            if (!Directory.Exists(Path.GetDirectoryName(destinationFile)))
                Directory.CreateDirectory(Path.GetDirectoryName(destinationFile));

            File.Copy(sourceFile, destinationFile, true);
        }

    }
}