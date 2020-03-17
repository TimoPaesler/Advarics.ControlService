using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Advarics.ControlService.DataContracts.VersionInfo
{
    [DataContract]
    public class VersionRequest
    {
        [DataMember]
        public CustomerInfo Customer ;

        [DataMember]
        public Guid IdToken;

        [DataMember]
        public string BaseProgramPath;

    }
}