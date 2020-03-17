using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Advarics.ControlService.Common
{
    public class IgnoreFileList
    {
        static List<String> retailList = new List<string>();



        public static bool Retail(FileInfo fileInfo)
        {
            retailList.Add("*.config");
            retailList.Add("*.xml");
            retailList.Add("*.pdb");
            retailList.Add("*.json");

            bool FileCopyOk = true;

            if (retailList.Where(x => x.Contains(fileInfo.Name.ToLower().Substring(fileInfo.Name.LastIndexOf(@".")))).Count() > 0)
                FileCopyOk = false;

            if (fileInfo.DirectoryName.ToLower().Contains("webapp") && fileInfo.Name.ToLower().Contains("web.config"))
                FileCopyOk = true;

            if (fileInfo.Name.ToLower().Contains("*.js"))
                FileCopyOk = true;

            if (fileInfo.Name.ToLower().Contains("version.xml"))
                FileCopyOk = true;

            if (fileInfo.Name.ToLower().Contains("clientaccesspolicy.xml"))
                FileCopyOk = true;

            if (fileInfo.DirectoryName.ToLower().Contains("advarics.external.api.core"))
                FileCopyOk = true;

            if (fileInfo.DirectoryName.ToLower().Contains("advarics.internal.api"))
                FileCopyOk = true;

            return FileCopyOk;
        }




    }
}