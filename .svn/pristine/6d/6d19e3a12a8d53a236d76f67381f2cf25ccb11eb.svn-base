using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Advarics.ControlService.DataContracts.FileTransfer;

namespace Advarics.ControlService.DataContracts.VersionInfo
{
    [DataContract]
    public class VersionInfoResponse
    {

        [DataMember]
        public CashVersion[] CashVersions;

        [DataMember]
        public string RetailProgramVersion;

		[DataMember]
		public long RetailDBVersion;

        [DataMember]
        public long RetailPakNo;

        [DataMember]
        public long SecuDataServicePakNo;

        [DataMember]
        public long StatisticServicePakNo;

        [DataMember]
        public long WebShopServicePakNo;

        [DataMember]
        public long RentalServicePakNo;

		[DataMember]
		public LogResponse[] Logs;

    }
}