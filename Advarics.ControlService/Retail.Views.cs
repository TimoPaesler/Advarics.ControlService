//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34003
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets745C557C98C0BC47B4B6748230BB951BB4CA6A0044FDDC0A8257774C12D7638D))]

namespace Edm_EntityMappingGeneratedViews
{
    
    
    /// <Summary>
    /// Der Typ enthält Sichten für EntitySets und AssociationSets, die zum Entwurfszeitpunkt generiert wurden.
    /// </Summary>
    public sealed class ViewsForBaseEntitySets745C557C98C0BC47B4B6748230BB951BB4CA6A0044FDDC0A8257774C12D7638D : System.Data.Mapping.EntityViewContainer
    {
        
        /// <Summary>
        /// Der Konstruktor speichert die Sichten für die Erweiterungen und außerdem die auf der Grundlage der Metadaten sowie des Mappingschlusses und der Mappingsichten generierten Hashwerte.
        /// </Summary>
        public ViewsForBaseEntitySets745C557C98C0BC47B4B6748230BB951BB4CA6A0044FDDC0A8257774C12D7638D()
        {
            this.EdmEntityContainerName = "RetailEntities";
            this.StoreEntityContainerName = "RetailEntitiesModelStoreContainer";
            this.HashOverMappingClosure = "d73c753d150e6e1e2f60f0b354459dd76c16fce46a0ac913da41ac166777f179";
            this.HashOverAllExtentViews = "5a2219c7f81d3dda80983098b44c49b16a8765a2b860600d8a9e91841dae9f43";
            this.ViewCount = 9;
        }
        
        /// <Summary>
        /// Die Methode gibt die Sicht für den angegebenen Index zurück.
        /// </Summary>
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                return GetView0();
            }
            if ((index == 1))
            {
                return GetView1();
            }
            if ((index == 2))
            {
                return GetView2();
            }
            if ((index == 3))
            {
                return GetView3();
            }
            if ((index == 4))
            {
                return GetView4();
            }
            if ((index == 5))
            {
                return GetView5();
            }
            if ((index == 6))
            {
                return GetView6();
            }
            if ((index == 7))
            {
                return GetView7();
            }
            if ((index == 8))
            {
                return GetView8();
            }
            throw new System.IndexOutOfRangeException();
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntitiesModelStoreContainer.CashPoint
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView0()
        {
            System.Text.StringBuilder viewString = new System.Text.StringBuilder(3171);
            viewString.Append("\r\n    SELECT VALUE -- Constructing CashPoint\r\n        [RetailEntitiesModel.Store");
            viewString.Append(".CashPoint](T1.CashPoint_Id, T1.CashPoint_No, T1.CashPoint_StoreId, T1.CashPoint");
            viewString.Append("_Name, T1.CashPoint_DoSynchronize, T1.CashPoint_MacAddress, T1.CashPoint_SyncNam");
            viewString.Append("e, T1.CashPoint_CashConfigId, T1.CashPoint_LastSync, T1.CashPoint_UpdatePackageC");
            viewString.Append("ashPoint, T1.CashPoint_UpdatePackageSyncService, T1.CashPoint_ItemSyncTimeStamp,");
            viewString.Append(" T1.CashPoint_ItemSyncMaxId, T1.CashPoint_CustomerSyncTimeStamp, T1.CashPoint_Cu");
            viewString.Append("stomerSyncMaxId, T1.CashPoint_VoucherSyncTimeStamp, T1.CashPoint_VoucherSyncMaxI");
            viewString.Append("d, T1.CashPoint_CustomerSalesSyncTimeStamp, T1.CashPoint_CustomerSalesSyncMaxId,");
            viewString.Append(" T1.CashPoint_SalesOnApprovalSyncTimeStamp, T1.CashPoint_SalesOnApprovalSyncMaxI");
            viewString.Append("d, T1.CashPoint_StartNoBilling, T1.CashPoint_EndNoBilling, T1.CashPoint_StartNoC");
            viewString.Append("ustomer, T1.CashPoint_EndNoCustomer, T1.CashPoint_VoucherDeletedSyncTimeStamp, T");
            viewString.Append("1.CashPoint_VoucherDeletedSyncMaxId, T1.CashPoint_BillingSyncTimeStamp, T1.CashP");
            viewString.Append("oint_BillingSyncMaxId, T1.CashPoint_Password1, T1.CashPoint_Password2, T1.CashPo");
            viewString.Append("int_SlowSpeedSync)\r\n    FROM (\r\n        SELECT \r\n            T.Id AS CashPoint_I");
            viewString.Append("d, \r\n            T.No AS CashPoint_No, \r\n            T.StoreId AS CashPoint_Stor");
            viewString.Append("eId, \r\n            T.Name AS CashPoint_Name, \r\n            T.DoSynchronize AS Ca");
            viewString.Append("shPoint_DoSynchronize, \r\n            T.MacAddress AS CashPoint_MacAddress, \r\n   ");
            viewString.Append("         T.SyncName AS CashPoint_SyncName, \r\n            T.CashConfigId AS CashP");
            viewString.Append("oint_CashConfigId, \r\n            T.LastSync AS CashPoint_LastSync, \r\n           ");
            viewString.Append(" T.UpdatePackageCashPoint AS CashPoint_UpdatePackageCashPoint, \r\n            T.U");
            viewString.Append("pdatePackageSyncService AS CashPoint_UpdatePackageSyncService, \r\n            T.I");
            viewString.Append("temSyncTimeStamp AS CashPoint_ItemSyncTimeStamp, \r\n            T.ItemSyncMaxId A");
            viewString.Append("S CashPoint_ItemSyncMaxId, \r\n            T.CustomerSyncTimeStamp AS CashPoint_Cu");
            viewString.Append("stomerSyncTimeStamp, \r\n            T.CustomerSyncMaxId AS CashPoint_CustomerSync");
            viewString.Append("MaxId, \r\n            T.VoucherSyncTimeStamp AS CashPoint_VoucherSyncTimeStamp, \r");
            viewString.Append("\n            T.VoucherSyncMaxId AS CashPoint_VoucherSyncMaxId, \r\n            T.C");
            viewString.Append("ustomerSalesSyncTimeStamp AS CashPoint_CustomerSalesSyncTimeStamp, \r\n           ");
            viewString.Append(" T.CustomerSalesSyncMaxId AS CashPoint_CustomerSalesSyncMaxId, \r\n            T.S");
            viewString.Append("alesOnApprovalSyncTimeStamp AS CashPoint_SalesOnApprovalSyncTimeStamp, \r\n       ");
            viewString.Append("     T.SalesOnApprovalSyncMaxId AS CashPoint_SalesOnApprovalSyncMaxId, \r\n       ");
            viewString.Append("     T.StartNoBilling AS CashPoint_StartNoBilling, \r\n            T.EndNoBilling ");
            viewString.Append("AS CashPoint_EndNoBilling, \r\n            T.StartNoCustomer AS CashPoint_StartNoC");
            viewString.Append("ustomer, \r\n            T.EndNoCustomer AS CashPoint_EndNoCustomer, \r\n           ");
            viewString.Append(" T.VoucherDeletedSyncTimeStamp AS CashPoint_VoucherDeletedSyncTimeStamp, \r\n     ");
            viewString.Append("       T.VoucherDeletedSyncMaxId AS CashPoint_VoucherDeletedSyncMaxId, \r\n       ");
            viewString.Append("     T.BillingSyncTimeStamp AS CashPoint_BillingSyncTimeStamp, \r\n            T.B");
            viewString.Append("illingSyncMaxId AS CashPoint_BillingSyncMaxId, \r\n            T.Password1 AS Cash");
            viewString.Append("Point_Password1, \r\n            T.Password2 AS CashPoint_Password2, \r\n           ");
            viewString.Append(" T.SlowSpeedSync AS CashPoint_SlowSpeedSync, \r\n            True AS _from0\r\n     ");
            viewString.Append("   FROM RetailEntities.CashPoints AS T\r\n    ) AS T1");
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntitiesModelStoreContainer.CashPoint", viewString.ToString());
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntitiesModelStoreContainer.UpdateStatus
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView1()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntitiesModelStoreContainer.UpdateStatus", @"
    SELECT VALUE -- Constructing UpdateStatus
        [RetailEntitiesModel.Store.UpdateStatus](T1.UpdateStatus_Id, T1.UpdateStatus_CurrentProgramVersion, T1.UpdateStatus_CurrentUpdatePackage)
    FROM (
        SELECT 
            T.Id AS UpdateStatus_Id, 
            T.CurrentProgramVersion AS UpdateStatus_CurrentProgramVersion, 
            T.CurrentUpdatePackage AS UpdateStatus_CurrentUpdatePackage, 
            True AS _from0
        FROM RetailEntities.UpdateStatus AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntities.UpdateStatus
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView2()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntities.UpdateStatus", @"
    SELECT VALUE -- Constructing UpdateStatus
        [RetailEntitiesModel.UpdateStatu](T1.UpdateStatu_Id, T1.UpdateStatu_CurrentProgramVersion, T1.UpdateStatu_CurrentUpdatePackage)
    FROM (
        SELECT 
            T.Id AS UpdateStatu_Id, 
            T.CurrentProgramVersion AS UpdateStatu_CurrentProgramVersion, 
            T.CurrentUpdatePackage AS UpdateStatu_CurrentUpdatePackage, 
            True AS _from0
        FROM RetailEntitiesModelStoreContainer.UpdateStatus AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntitiesModelStoreContainer.DbVersion
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView3()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntitiesModelStoreContainer.DbVersion", @"
    SELECT VALUE -- Constructing DbVersion
        [RetailEntitiesModel.Store.DbVersion](T1.DbVersion_Id, T1.DbVersion_VersionNo)
    FROM (
        SELECT 
            T.Id AS DbVersion_Id, 
            T.VersionNo AS DbVersion_VersionNo, 
            True AS _from0
        FROM RetailEntities.DbVersions AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntities.DbVersions
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView4()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntities.DbVersions", @"
    SELECT VALUE -- Constructing DbVersions
        [RetailEntitiesModel.DbVersion](T1.DbVersion_Id, T1.DbVersion_VersionNo)
    FROM (
        SELECT 
            T.Id AS DbVersion_Id, 
            T.VersionNo AS DbVersion_VersionNo, 
            True AS _from0
        FROM RetailEntitiesModelStoreContainer.DbVersion AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntitiesModelStoreContainer.LogCommon
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView5()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntitiesModelStoreContainer.LogCommon", @"
    SELECT VALUE -- Constructing LogCommon
        [RetailEntitiesModel.Store.LogCommon](T1.LogCommon_Id, T1.LogCommon_Date, T1.LogCommon_Category, T1.LogCommon_Status, T1.LogCommon_Message)
    FROM (
        SELECT 
            T.Id AS LogCommon_Id, 
            T.Date AS LogCommon_Date, 
            T.Category AS LogCommon_Category, 
            T.Status AS LogCommon_Status, 
            T.Message AS LogCommon_Message, 
            True AS _from0
        FROM RetailEntities.LogCommons AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntities.LogCommons
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView6()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntities.LogCommons", @"
    SELECT VALUE -- Constructing LogCommons
        [RetailEntitiesModel.LogCommon](T1.LogCommon_Id, T1.LogCommon_Date, T1.LogCommon_Category, T1.LogCommon_Status, T1.LogCommon_Message)
    FROM (
        SELECT 
            T.Id AS LogCommon_Id, 
            T.Date AS LogCommon_Date, 
            T.Category AS LogCommon_Category, 
            T.Status AS LogCommon_Status, 
            T.Message AS LogCommon_Message, 
            True AS _from0
        FROM RetailEntitiesModelStoreContainer.LogCommon AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntitiesModelStoreContainer.BackgroundWorkerStatus
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView7()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntitiesModelStoreContainer.BackgroundWorkerStatus", @"
    SELECT VALUE -- Constructing BackgroundWorkerStatus
        [RetailEntitiesModel.Store.BackgroundWorkerStatus](T1.BackgroundWorkerStatus_Id, T1.BackgroundWorkerStatus_PID)
    FROM (
        SELECT 
            T.Id AS BackgroundWorkerStatus_Id, 
            T.PID AS BackgroundWorkerStatus_PID, 
            True AS _from0
        FROM RetailEntities.BackgroundWorkerStatus AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// Sicht zurückgeben für RetailEntities.BackgroundWorkerStatus
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView8()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("RetailEntities.BackgroundWorkerStatus", @"
    SELECT VALUE -- Constructing BackgroundWorkerStatus
        [RetailEntitiesModel.BackgroundWorkerStatu](T1.BackgroundWorkerStatu_Id, T1.BackgroundWorkerStatu_PID)
    FROM (
        SELECT 
            T.Id AS BackgroundWorkerStatu_Id, 
            T.PID AS BackgroundWorkerStatu_PID, 
            True AS _from0
        FROM RetailEntitiesModelStoreContainer.BackgroundWorkerStatus AS T
    ) AS T1");
        }
    }
}
