using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Advarics.ControlService.Common
{
    public class FileProcess
    {

        public static string Read(String path)
        {
            string content = string.Empty;

            try
            {
                StreamReader myFile = new StreamReader(path, System.Text.Encoding.Default);
                content = myFile.ReadToEnd();
                myFile.Close();
            }
            catch
            {

            }
            return content;
        }
    }
}