using System.ServiceModel;
using Advarics.ControlService.DataContracts.FileTransfer;
using Advarics.ControlService.DataContracts.VersionInfo;
using Advarics.ControlService.DataContracts.UpdateInfo;

namespace Advarics.ControlService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IAdvaricsControlService
	{
		[OperationContract]
        UploadInfoResponse UploadFile(UploadFileRequest request);

        [OperationContract]
        VersionInfoResponse GetVersions(VersionRequest request);

        [OperationContract]
        UpdateInfoResponse UpdateCustomer(UpdateRequest request);


	}
}
