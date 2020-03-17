using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Advarics.ControlService.DataContracts.FileTransfer
{
	[DataContract]
	public class UpdateInfoResponse
	{
		[DataMember]
		public LogResponse[] Logs;

	}
}