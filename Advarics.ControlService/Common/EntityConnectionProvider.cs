using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Configuration;
using IdeaBlade.Core;

namespace Advarics.ControlService.Common
{
	public class EntityConnectionProvider
	{

		public static void GetRetailEntityConnection(string dataBaseName)
		{

			EntityConnection entityConnection = null;
			EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
			//var connection = ConfigurationManager.ConnectionStrings["RetailEntities"].ConnectionString;

			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();

			sb.DataSource = ".";
			sb.InitialCatalog = dataBaseName;

			sb.IntegratedSecurity = false;
			sb.UserID = "AdvUser";
			sb.Password = "$Atfarix09";

			entityBuilder.ProviderConnectionString = sb.ConnectionString;
			entityBuilder.Metadata = "res://*/Retail.csdl|res://*/Retail.ssdl|res://*/Retail.msl";
			entityBuilder.Provider = "System.Data.SqlClient";

			entityConnection = new EntityConnection(entityBuilder.ToString());

			ConnectionStringSettings t = new ConnectionStringSettings("RetailEntities_" + dataBaseName, entityConnection.ConnectionString);
			IdeaBladeConfig.Instance.Configuration.ConnectionStrings.ConnectionStrings.Add(t);

		}

	}
}