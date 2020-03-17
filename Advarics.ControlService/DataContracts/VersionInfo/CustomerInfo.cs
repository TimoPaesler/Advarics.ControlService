using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Advarics.ControlService.DataContracts.VersionInfo
{
    [DataContract]
    public class CustomerInfo
    {
        [DataMember]
        public long No;

        [DataMember]
        public string Name;

        [DataMember]
        public string DBName;

        [DataMember]
        public string BaseCustomerPath;
    }
}