using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Advarics.ControlService.DataContracts.VersionInfo;

namespace Advarics.ControlService.DataContracts.UpdateInfo
{
	[DataContract]
	public class UpdateRequest
	{
		[DataMember]
		public CustomerInfo Customer;

		[DataMember]
		public Guid IdToken;

		[DataMember]
		public string PackageNo;

		[DataMember]
		public string UpdateServerPath;

		[DataMember]
		public string AdvProgramPath;

	}
}