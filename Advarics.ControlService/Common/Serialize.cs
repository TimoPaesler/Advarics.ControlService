using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml.Serialization;

namespace Advarics.ControlService.Common
{
    public class Serialize
    {
        #region serialisierung


        public static string SerializeToXml<T>(T instanceToSerialize)
        {
            string xml = string.Empty;
            using (StringWriter w = new StringWriter())
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Serialize(w, instanceToSerialize);
                xml = w.ToString();
            }
            return xml;
        }


        public static T DeSerializeFromXml<T>(string xml)
        {
            T returnObj = default(T);

            using (StringReader r = new StringReader(xml))
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                returnObj = (T)s.Deserialize(r);
            }

            return returnObj;
        }


        #endregion

    }
}