using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Advarics.ControlService.DataContracts.FileTransfer
{
	[DataContract]
	public class UploadFileRequest
	{

		[DataMember]
		public string FileName { get; set; }


		[DataMember]
		public string UpdateOrdner { get; set; }


		[DataMember]
		public Guid IdToken { get; set; }


		[DataMember]
		public string AzurePrefix { get; set; }



	}
}