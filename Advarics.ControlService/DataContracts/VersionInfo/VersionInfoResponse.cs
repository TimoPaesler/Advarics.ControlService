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
		public string RetailPakNo;

		[DataMember]
		public string SecuDataServicePakNo;

		[DataMember]
		public string StatisticServicePakNo;

		[DataMember]
		public string WebShopServicePakNo;

		[DataMember]
		public string RentalServicePakNo;

		[DataMember]
		public LogResponse[] Logs;

	}
}