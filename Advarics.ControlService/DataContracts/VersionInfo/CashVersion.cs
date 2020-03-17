using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Advarics.ControlService.DataContracts.VersionInfo
{
    [DataContract]
    public class CashVersion
    {
        [DataMember]
        public long No;

        [DataMember]
        public string Name;

        [DataMember]
        public long UpdatePackageCashPoint;

        [DataMember]
        public long UpdatePackageSyncService;

        [DataMember]
        public long StoreNo;

		[DataMember]
		public bool Sync;

		[DataMember]
		public DateTime LastSync;

    }
}