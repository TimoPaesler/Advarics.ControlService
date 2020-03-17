using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.ServiceModel.Description;
using System.Security.Cryptography.X509Certificates;

namespace Advarics.ControlService.TestClient
{
	public class ServiceProxyProvider
	{
		public AdvaricsControlService.AdvaricsControlServiceClient GetProxyServer1(EndpointAddress endPointUri)
		{
			AdvaricsControlService.AdvaricsControlServiceClient proxy = null;

			WSHttpBinding binding = new WSHttpBinding();
			binding.Name = "BasicHttpBinding_IAdvaricsControlService";
			binding.MaxReceivedMessageSize = System.Int32.MaxValue;
			//  binding.MaxBufferSize = System.Int32.MaxValue;
			binding.MaxBufferPoolSize = System.Int32.MaxValue;
			binding.MessageEncoding = WSMessageEncoding.Text;
			binding.ReceiveTimeout = new TimeSpan(1, 10, 0);
			binding.OpenTimeout = new TimeSpan(1, 10, 0);
			binding.SendTimeout = new TimeSpan(1, 10, 0);
			binding.CloseTimeout = new TimeSpan(1, 10, 0);
			binding.TextEncoding = Encoding.UTF8;
			binding.AllowCookies = false;
			binding.BypassProxyOnLocal = false;
			binding.TransactionFlow = false;
			binding.UseDefaultWebProxy = true;
			binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
			binding.ReaderQuotas.MaxArrayLength = 16384;
			binding.ReaderQuotas.MaxBytesPerRead = 4096;
			binding.ReaderQuotas.MaxNameTableCharCount = 16384;
			binding.ReaderQuotas.MaxDepth = 32;
			binding.ReaderQuotas.MaxStringContentLength = 8192;
			binding.ReliableSession.Ordered = true;
			binding.ReliableSession.Enabled = false;
			binding.ReliableSession.InactivityTimeout = new TimeSpan(1, 10, 0);
			binding.Security.Mode = SecurityMode.Message;
			binding.Security.Transport.Realm = "";
			binding.Security.Message.AlgorithmSuite = SecurityAlgorithmSuite.Default;
			binding.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;
			binding.Security.Message.NegotiateServiceCredential = true;
			binding.Security.Message.EstablishSecurityContext = true;
			//ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
			//serviceBehavior.HttpGetEnabled = true;
			//serviceBehavior.HttpGetUrl = new Uri("");
			//ServiceDebugBehavior serviceDebugBehavior = new ServiceDebugBehavior();
			//serviceDebugBehavior.HttpHelpPageEnabled = true;
			//serviceDebugBehavior.IncludeExceptionDetailInFaults = true;

			proxy = new AdvaricsControlService.AdvaricsControlServiceClient(binding, endPointUri);
			proxy.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindBySubjectName, "*.advarics.net");
			proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.ChainTrust;
			proxy.ClientCredentials.ServiceCertificate.Authentication.TrustedStoreLocation = StoreLocation.LocalMachine;
			proxy.ClientCredentials.ServiceCertificate.Authentication.RevocationMode = X509RevocationMode.Online;
			// proxy.Endpoint.Address.
			//proxy.Endpoint.Behaviors.Add(serviceBehavior);
			proxy.Endpoint.Name = "BasicHttpBinding_IAdvaricsControlService";
			proxy.Endpoint.Binding = binding;
			proxy.Endpoint.Binding.SendTimeout = new TimeSpan(1, 10, 0);
			proxy.Endpoint.Binding.ReceiveTimeout = new TimeSpan(1, 10, 0);
			proxy.Endpoint.Binding.OpenTimeout = new TimeSpan(1, 10, 0);
			proxy.Endpoint.Binding.CloseTimeout = new TimeSpan(1, 10, 0);
			proxy.Endpoint.Binding.CloseTimeout = new TimeSpan(1, 10, 0);

			return proxy;
		}

	}
}
