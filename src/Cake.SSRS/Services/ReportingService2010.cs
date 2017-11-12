﻿namespace Cake.SSRS.Services
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", ConfigurationName="Cake.SSRS.Services.ReportingService2010Soap")]
    public interface ReportingService2010Soap
    {
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCa" +
            "talogItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateCatalogItemResponse> CreateCatalogItemAsync(Cake.SSRS.Services.CreateCatalogItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemD" +
            "efinition", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemDefinitionResponse> SetItemDefinitionAsync(Cake.SSRS.Services.SetItemDefinitionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemD" +
            "efinition", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDefinitionResponse> GetItemDefinitionAsync(Cake.SSRS.Services.GetItemDefinitionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemT" +
            "ype", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemTypeResponse> GetItemTypeAsync(Cake.SSRS.Services.GetItemTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteIt" +
            "em", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteItemResponse> DeleteItemAsync(Cake.SSRS.Services.DeleteItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/MoveItem" +
            "", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.MoveItemResponse> MoveItemAsync(Cake.SSRS.Services.MoveItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritP" +
            "arentSecurity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.InheritParentSecurityResponse> InheritParentSecurityAsync(Cake.SSRS.Services.InheritParentSecurityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItem" +
            "History", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListItemHistoryResponse> ListItemHistoryAsync(Cake.SSRS.Services.ListItemHistoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListChil" +
            "dren", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListChildrenResponse> ListChildrenAsync(Cake.SSRS.Services.ListChildrenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListDepe" +
            "ndentItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListDependentItemsResponse> ListDependentItemsAsync(Cake.SSRS.Services.ListDependentItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FindItem" +
            "s", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.FindItemsResponse> FindItemsAsync(Cake.SSRS.Services.FindItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListPare" +
            "nts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListParentsResponse> ListParentsAsync(Cake.SSRS.Services.ListParentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateFo" +
            "lder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateFolderResponse> CreateFolderAsync(Cake.SSRS.Services.CreateFolderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetPrope" +
            "rties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetPropertiesResponse> SetPropertiesAsync(Cake.SSRS.Services.SetPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPrope" +
            "rties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetPropertiesResponse> GetPropertiesAsync(Cake.SSRS.Services.GetPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemR" +
            "eferences", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemReferencesResponse> SetItemReferencesAsync(Cake.SSRS.Services.SetItemReferencesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemR" +
            "eferences", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemReferencesResponse> GetItemReferencesAsync(Cake.SSRS.Services.GetItemReferencesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListItem" +
            "Types", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListItemTypesResponse> ListItemTypesAsync(Cake.SSRS.Services.ListItemTypesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSubsc" +
            "riptionProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSubscriptionPropertiesResponse> SetSubscriptionPropertiesAsync(Cake.SSRS.Services.SetSubscriptionPropertiesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSubsc" +
            "riptionProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSubscriptionPropertiesResponse> GetSubscriptionPropertiesAsync(Cake.SSRS.Services.GetSubscriptionPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataD" +
            "rivenSubscriptionProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesResponse> SetDataDrivenSubscriptionPropertiesAsync(Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataD" +
            "rivenSubscriptionProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetDataDrivenSubscriptionPropertiesResponse> GetDataDrivenSubscriptionPropertiesAsync(Cake.SSRS.Services.GetDataDrivenSubscriptionPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableS" +
            "ubscription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DisableSubscriptionResponse> DisableSubscriptionAsync(Cake.SSRS.Services.DisableSubscriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableSu" +
            "bscription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.EnableSubscriptionResponse> EnableSubscriptionAsync(Cake.SSRS.Services.EnableSubscriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSu" +
            "bscription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteSubscriptionResponse> DeleteSubscriptionAsync(Cake.SSRS.Services.DeleteSubscriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSu" +
            "bscription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateSubscriptionResponse> CreateSubscriptionAsync(Cake.SSRS.Services.CreateSubscriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDa" +
            "taDrivenSubscription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateDataDrivenSubscriptionResponse> CreateDataDrivenSubscriptionAsync(Cake.SSRS.Services.CreateDataDrivenSubscriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExten" +
            "sionSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetExtensionSettingsResponse> GetExtensionSettingsAsync(Cake.SSRS.Services.GetExtensionSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Validate" +
            "ExtensionSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ValidateExtensionSettingsResponse> ValidateExtensionSettingsAsync(Cake.SSRS.Services.ValidateExtensionSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubs" +
            "criptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSubscriptionsResponse> ListSubscriptionsAsync(Cake.SSRS.Services.ListSubscriptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMySu" +
            "bscriptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListMySubscriptionsResponse> ListMySubscriptionsAsync(Cake.SSRS.Services.ListMySubscriptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSubs" +
            "criptionsUsingDataSource", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSubscriptionsUsingDataSourceResponse> ListSubscriptionsUsingDataSourceAsync(Cake.SSRS.Services.ListSubscriptionsUsingDataSourceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ChangeSu" +
            "bscriptionOwner", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ChangeSubscriptionOwnerResponse> ChangeSubscriptionOwnerAsync(Cake.SSRS.Services.ChangeSubscriptionOwnerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateDa" +
            "taSource", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateDataSourceResponse> CreateDataSourceAsync(Cake.SSRS.Services.CreateDataSourceRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PrepareQ" +
            "uery", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.PrepareQueryResponse> PrepareQueryAsync(Cake.SSRS.Services.PrepareQueryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/EnableDa" +
            "taSource", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.EnableDataSourceResponse> EnableDataSourceAsync(Cake.SSRS.Services.EnableDataSourceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DisableD" +
            "ataSource", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DisableDataSourceResponse> DisableDataSourceAsync(Cake.SSRS.Services.DisableDataSourceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetDataS" +
            "ourceContents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetDataSourceContentsResponse> SetDataSourceContentsAsync(Cake.SSRS.Services.SetDataSourceContentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetDataS" +
            "ourceContents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetDataSourceContentsResponse> GetDataSourceContentsAsync(Cake.SSRS.Services.GetDataSourceContentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListData" +
            "baseCredentialRetrievalOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsResponse> ListDatabaseCredentialRetrievalOptionsAsync(Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemD" +
            "ataSources", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemDataSourcesResponse> SetItemDataSourcesAsync(Cake.SSRS.Services.SetItemDataSourcesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemD" +
            "ataSources", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDataSourcesResponse> GetItemDataSourcesAsync(Cake.SSRS.Services.GetItemDataSourcesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConn" +
            "ectForDataSourceDefinition", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.TestConnectForDataSourceDefinitionResponse> TestConnectForDataSourceDefinitionAsync(Cake.SSRS.Services.TestConnectForDataSourceDefinitionRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/TestConn" +
            "ectForItemDataSource", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.TestConnectForItemDataSourceResponse> TestConnectForItemDataSourceAsync(Cake.SSRS.Services.TestConnectForItemDataSourceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateRo" +
            "le", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateRoleResponse> CreateRoleAsync(Cake.SSRS.Services.CreateRoleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetRoleP" +
            "roperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetRolePropertiesResponse> SetRolePropertiesAsync(Cake.SSRS.Services.SetRolePropertiesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetRoleP" +
            "roperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetRolePropertiesResponse> GetRolePropertiesAsync(Cake.SSRS.Services.GetRolePropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteRo" +
            "le", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteRoleResponse> DeleteRoleAsync(Cake.SSRS.Services.DeleteRoleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListRole" +
            "s", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListRolesResponse> ListRolesAsync(Cake.SSRS.Services.ListRolesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListTask" +
            "s", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListTasksResponse> ListTasksAsync(Cake.SSRS.Services.ListTasksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetPolic" +
            "ies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetPoliciesResponse> SetPoliciesAsync(Cake.SSRS.Services.SetPoliciesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPolic" +
            "ies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetPoliciesResponse> GetPoliciesAsync(Cake.SSRS.Services.GetPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemD" +
            "ataSourcePrompts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDataSourcePromptsResponse> GetItemDataSourcePromptsAsync(Cake.SSRS.Services.GetItemDataSourcePromptsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Generate" +
            "Model", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GenerateModelResponse> GenerateModelAsync(Cake.SSRS.Services.GenerateModelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModel" +
            "ItemPermissions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetModelItemPermissionsResponse> GetModelItemPermissionsAsync(Cake.SSRS.Services.GetModelItemPermissionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModel" +
            "ItemPolicies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetModelItemPoliciesResponse> SetModelItemPoliciesAsync(Cake.SSRS.Services.SetModelItemPoliciesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetModel" +
            "ItemPolicies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetModelItemPoliciesResponse> GetModelItemPoliciesAsync(Cake.SSRS.Services.GetModelItemPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserM" +
            "odel", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetUserModelResponse> GetUserModelAsync(Cake.SSRS.Services.GetUserModelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/InheritM" +
            "odelItemParentSecurity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.InheritModelItemParentSecurityResponse> InheritModelItemParentSecurityAsync(Cake.SSRS.Services.InheritModelItemParentSecurityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetModel" +
            "DrillthroughReports", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetModelDrillthroughReportsResponse> SetModelDrillthroughReportsAsync(Cake.SSRS.Services.SetModelDrillthroughReportsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lDrillthroughReports", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelDrillthroughReportsResponse> ListModelDrillthroughReportsAsync(Cake.SSRS.Services.ListModelDrillthroughReportsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lItemChildren", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelItemChildrenResponse> ListModelItemChildrenAsync(Cake.SSRS.Services.ListModelItemChildrenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lItemTypes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelItemTypesResponse> ListModelItemTypesAsync(Cake.SSRS.Services.ListModelItemTypesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListMode" +
            "lPerspectives", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelPerspectivesResponse> ListModelPerspectivesAsync(Cake.SSRS.Services.ListModelPerspectivesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Regenera" +
            "teModel", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.RegenerateModelResponse> RegenerateModelAsync(Cake.SSRS.Services.RegenerateModelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/RemoveAl" +
            "lModelItemPolicies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.RemoveAllModelItemPoliciesResponse> RemoveAllModelItemPoliciesAsync(Cake.SSRS.Services.RemoveAllModelItemPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateSc" +
            "hedule", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateScheduleResponse> CreateScheduleAsync(Cake.SSRS.Services.CreateScheduleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteSc" +
            "hedule", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteScheduleResponse> DeleteScheduleAsync(Cake.SSRS.Services.DeleteScheduleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSche" +
            "dules", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSchedulesResponse> ListSchedulesAsync(Cake.SSRS.Services.ListSchedulesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSched" +
            "uleProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSchedulePropertiesResponse> GetSchedulePropertiesAsync(Cake.SSRS.Services.GetSchedulePropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSche" +
            "duleStates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListScheduleStatesResponse> ListScheduleStatesAsync(Cake.SSRS.Services.ListScheduleStatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/PauseSch" +
            "edule", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.PauseScheduleResponse> PauseScheduleAsync(Cake.SSRS.Services.PauseScheduleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ResumeSc" +
            "hedule", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ResumeScheduleResponse> ResumeScheduleAsync(Cake.SSRS.Services.ResumeScheduleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSched" +
            "uleProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSchedulePropertiesResponse> SetSchedulePropertiesAsync(Cake.SSRS.Services.SetSchedulePropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSche" +
            "duledItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListScheduledItemsResponse> ListScheduledItemsAsync(Cake.SSRS.Services.ListScheduledItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemP" +
            "arameters", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemParametersResponse> SetItemParametersAsync(Cake.SSRS.Services.SetItemParametersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemP" +
            "arameters", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemParametersResponse> GetItemParametersAsync(Cake.SSRS.Services.GetItemParametersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListPara" +
            "meterTypes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListParameterTypesResponse> ListParameterTypesAsync(Cake.SSRS.Services.ListParameterTypesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListPara" +
            "meterStates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListParameterStatesResponse> ListParameterStatesAsync(Cake.SSRS.Services.ListParameterStatesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateRe" +
            "portEditSession", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateReportEditSessionResponse> CreateReportEditSessionAsync(Cake.SSRS.Services.CreateReportEditSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateLi" +
            "nkedItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateLinkedItemResponse> CreateLinkedItemAsync(Cake.SSRS.Services.CreateLinkedItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemL" +
            "ink", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemLinkResponse> SetItemLinkAsync(Cake.SSRS.Services.SetItemLinkRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemL" +
            "ink", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemLinkResponse> GetItemLinkAsync(Cake.SSRS.Services.GetItemLinkRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExec" +
            "utionSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListExecutionSettingsResponse> ListExecutionSettingsAsync(Cake.SSRS.Services.ListExecutionSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetExecu" +
            "tionOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetExecutionOptionsResponse> SetExecutionOptionsAsync(Cake.SSRS.Services.SetExecutionOptionsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetExecu" +
            "tionOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetExecutionOptionsResponse> GetExecutionOptionsAsync(Cake.SSRS.Services.GetExecutionOptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/UpdateIt" +
            "emExecutionSnapshot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.UpdateItemExecutionSnapshotResponse> UpdateItemExecutionSnapshotAsync(Cake.SSRS.Services.UpdateItemExecutionSnapshotRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCache" +
            "Options", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetCacheOptionsResponse> SetCacheOptionsAsync(Cake.SSRS.Services.SetCacheOptionsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCache" +
            "Options", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetCacheOptionsResponse> GetCacheOptionsAsync(Cake.SSRS.Services.GetCacheOptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FlushCac" +
            "he", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.FlushCacheResponse> FlushCacheAsync(Cake.SSRS.Services.FlushCacheRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateIt" +
            "emHistorySnapshot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateItemHistorySnapshotResponse> CreateItemHistorySnapshotAsync(Cake.SSRS.Services.CreateItemHistorySnapshotRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteIt" +
            "emHistorySnapshot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteItemHistorySnapshotResponse> DeleteItemHistorySnapshotAsync(Cake.SSRS.Services.DeleteItemHistorySnapshotRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemH" +
            "istoryLimit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemHistoryLimitResponse> SetItemHistoryLimitAsync(Cake.SSRS.Services.SetItemHistoryLimitRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemH" +
            "istoryLimit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemHistoryLimitResponse> GetItemHistoryLimitAsync(Cake.SSRS.Services.GetItemHistoryLimitRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetItemH" +
            "istoryOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemHistoryOptionsResponse> SetItemHistoryOptionsAsync(Cake.SSRS.Services.SetItemHistoryOptionsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetItemH" +
            "istoryOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemHistoryOptionsResponse> GetItemHistoryOptionsAsync(Cake.SSRS.Services.GetItemHistoryOptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetRepor" +
            "tServerConfigInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetReportServerConfigInfoResponse> GetReportServerConfigInfoAsync(Cake.SSRS.Services.GetReportServerConfigInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/IsSSLReq" +
            "uired", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.IsSSLRequiredResponse> IsSSLRequiredAsync(Cake.SSRS.Services.IsSSLRequiredRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSyste" +
            "mProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSystemPropertiesResponse> SetSystemPropertiesAsync(Cake.SSRS.Services.SetSystemPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSyste" +
            "mProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPropertiesResponse> GetSystemPropertiesAsync(Cake.SSRS.Services.GetSystemPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetUserS" +
            "ettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetUserSettingsResponse> SetUserSettingsAsync(Cake.SSRS.Services.SetUserSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetUserS" +
            "ettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetUserSettingsResponse> GetUserSettingsAsync(Cake.SSRS.Services.GetUserSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetSyste" +
            "mPolicies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSystemPoliciesResponse> SetSystemPoliciesAsync(Cake.SSRS.Services.SetSystemPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSyste" +
            "mPolicies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPoliciesResponse> GetSystemPoliciesAsync(Cake.SSRS.Services.GetSystemPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExte" +
            "nsions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListExtensionsResponse> ListExtensionsAsync(Cake.SSRS.Services.ListExtensionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListExte" +
            "nsionTypes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListExtensionTypesResponse> ListExtensionTypesAsync(Cake.SSRS.Services.ListExtensionTypesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListEven" +
            "ts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListEventsResponse> ListEventsAsync(Cake.SSRS.Services.ListEventsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/FireEven" +
            "t", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.FireEventResponse> FireEventAsync(Cake.SSRS.Services.FireEventRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobs" +
            "", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobsResponse> ListJobsAsync(Cake.SSRS.Services.ListJobsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobT" +
            "ypes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobTypesResponse> ListJobTypesAsync(Cake.SSRS.Services.ListJobTypesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobA" +
            "ctions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobActionsResponse> ListJobActionsAsync(Cake.SSRS.Services.ListJobActionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListJobS" +
            "tates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobStatesResponse> ListJobStatesAsync(Cake.SSRS.Services.ListJobStatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CancelJo" +
            "b", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CancelJobResponse> CancelJobAsync(Cake.SSRS.Services.CancelJobRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/CreateCa" +
            "cheRefreshPlan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateCacheRefreshPlanResponse> CreateCacheRefreshPlanAsync(Cake.SSRS.Services.CreateCacheRefreshPlanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/SetCache" +
            "RefreshPlanProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetCacheRefreshPlanPropertiesResponse> SetCacheRefreshPlanPropertiesAsync(Cake.SSRS.Services.SetCacheRefreshPlanPropertiesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetCache" +
            "RefreshPlanProperties", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetCacheRefreshPlanPropertiesResponse> GetCacheRefreshPlanPropertiesAsync(Cake.SSRS.Services.GetCacheRefreshPlanPropertiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/DeleteCa" +
            "cheRefreshPlan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteCacheRefreshPlanResponse> DeleteCacheRefreshPlanAsync(Cake.SSRS.Services.DeleteCacheRefreshPlanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListCach" +
            "eRefreshPlans", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListCacheRefreshPlansResponse> ListCacheRefreshPlansAsync(Cake.SSRS.Services.ListCacheRefreshPlansRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/LogonUse" +
            "r", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.LogonUserResponse> LogonUserAsync(Cake.SSRS.Services.LogonUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/Logoff", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.LogoffResponse> LogoffAsync(Cake.SSRS.Services.LogoffRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetPermi" +
            "ssions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetPermissionsResponse> GetPermissionsAsync(Cake.SSRS.Services.GetPermissionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/GetSyste" +
            "mPermissions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPermissionsResponse> GetSystemPermissionsAsync(Cake.SSRS.Services.GetSystemPermissionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/ListSecu" +
            "rityScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExpirationDefinition))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RecurrencePattern))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ScheduleDefinitionOrReference))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataSourceDefinitionOrReference))]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSecurityScopesResponse> ListSecurityScopesAsync(Cake.SSRS.Services.ListSecurityScopesRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class TrustedUserHeader
    {
        
        private string userNameField;
        
        private byte[] userTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=1)]
        public byte[] UserToken
        {
            get
            {
                return this.userTokenField;
            }
            set
            {
                this.userTokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CacheRefreshPlan
    {
        
        private string cacheRefreshPlanIDField;
        
        private string itemPathField;
        
        private string descriptionField;
        
        private CacheRefreshPlanState stateField;
        
        private System.DateTime lastExecutedField;
        
        private System.DateTime modifiedDateField;
        
        private string modifiedByField;
        
        private string lastRunStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CacheRefreshPlanID
        {
            get
            {
                return this.cacheRefreshPlanIDField;
            }
            set
            {
                this.cacheRefreshPlanIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ItemPath
        {
            get
            {
                return this.itemPathField;
            }
            set
            {
                this.itemPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public CacheRefreshPlanState State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime LastExecuted
        {
            get
            {
                return this.lastExecutedField;
            }
            set
            {
                this.lastExecutedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string LastRunStatus
        {
            get
            {
                return this.lastRunStatusField;
            }
            set
            {
                this.lastRunStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CacheRefreshPlanState
    {
        
        private bool missingParameterValueField;
        
        private bool invalidParameterValueField;
        
        private bool unknownItemParameterField;
        
        private bool cachingNotEnabledOnItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool MissingParameterValue
        {
            get
            {
                return this.missingParameterValueField;
            }
            set
            {
                this.missingParameterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool InvalidParameterValue
        {
            get
            {
                return this.invalidParameterValueField;
            }
            set
            {
                this.invalidParameterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool UnknownItemParameter
        {
            get
            {
                return this.unknownItemParameterField;
            }
            set
            {
                this.unknownItemParameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool CachingNotEnabledOnItem
        {
            get
            {
                return this.cachingNotEnabledOnItemField;
            }
            set
            {
                this.cachingNotEnabledOnItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Job
    {
        
        private string jobIDField;
        
        private string nameField;
        
        private string pathField;
        
        private string descriptionField;
        
        private string machineField;
        
        private string userField;
        
        private System.DateTime startDateTimeField;
        
        private string jobActionNameField;
        
        private string jobTypeNameField;
        
        private string jobStatusNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string JobID
        {
            get
            {
                return this.jobIDField;
            }
            set
            {
                this.jobIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Machine
        {
            get
            {
                return this.machineField;
            }
            set
            {
                this.machineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string JobActionName
        {
            get
            {
                return this.jobActionNameField;
            }
            set
            {
                this.jobActionNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string JobTypeName
        {
            get
            {
                return this.jobTypeNameField;
            }
            set
            {
                this.jobTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string JobStatusName
        {
            get
            {
                return this.jobStatusNameField;
            }
            set
            {
                this.jobStatusNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Event
    {
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Extension
    {
        
        private string extensionTypeNameField;
        
        private string nameField;
        
        private string localizedNameField;
        
        private bool visibleField;
        
        private bool isModelGenerationSupportedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ExtensionTypeName
        {
            get
            {
                return this.extensionTypeNameField;
            }
            set
            {
                this.extensionTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string LocalizedName
        {
            get
            {
                return this.localizedNameField;
            }
            set
            {
                this.localizedNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool IsModelGenerationSupported
        {
            get
            {
                return this.isModelGenerationSupportedField;
            }
            set
            {
                this.isModelGenerationSupportedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleExpiration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeExpiration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ExpirationDefinition
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleExpiration : ExpirationDefinition
    {
        
        private ScheduleDefinitionOrReference itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference), Order=0)]
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleDefinition : ScheduleDefinitionOrReference
    {
        
        private System.DateTime startDateTimeField;
        
        private System.DateTime endDateField;
        
        private bool endDateFieldSpecified;
        
        private RecurrencePattern itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DailyRecurrence", typeof(DailyRecurrence), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("MinuteRecurrence", typeof(MinuteRecurrence), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("MonthlyDOWRecurrence", typeof(MonthlyDOWRecurrence), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("MonthlyRecurrence", typeof(MonthlyRecurrence), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("WeeklyRecurrence", typeof(WeeklyRecurrence), Order=2)]
        public RecurrencePattern Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DailyRecurrence : RecurrencePattern
    {
        
        private int daysIntervalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int DaysInterval
        {
            get
            {
                return this.daysIntervalField;
            }
            set
            {
                this.daysIntervalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeeklyRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlyRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlyDOWRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinuteRecurrence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DailyRecurrence))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class RecurrencePattern
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class WeeklyRecurrence : RecurrencePattern
    {
        
        private int weeksIntervalField;
        
        private bool weeksIntervalFieldSpecified;
        
        private DaysOfWeekSelector daysOfWeekField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int WeeksInterval
        {
            get
            {
                return this.weeksIntervalField;
            }
            set
            {
                this.weeksIntervalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeeksIntervalSpecified
        {
            get
            {
                return this.weeksIntervalFieldSpecified;
            }
            set
            {
                this.weeksIntervalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DaysOfWeekSelector DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }
            set
            {
                this.daysOfWeekField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DaysOfWeekSelector
    {
        
        private bool sundayField;
        
        private bool mondayField;
        
        private bool tuesdayField;
        
        private bool wednesdayField;
        
        private bool thursdayField;
        
        private bool fridayField;
        
        private bool saturdayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Sunday
        {
            get
            {
                return this.sundayField;
            }
            set
            {
                this.sundayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Monday
        {
            get
            {
                return this.mondayField;
            }
            set
            {
                this.mondayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool Tuesday
        {
            get
            {
                return this.tuesdayField;
            }
            set
            {
                this.tuesdayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool Wednesday
        {
            get
            {
                return this.wednesdayField;
            }
            set
            {
                this.wednesdayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool Thursday
        {
            get
            {
                return this.thursdayField;
            }
            set
            {
                this.thursdayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool Friday
        {
            get
            {
                return this.fridayField;
            }
            set
            {
                this.fridayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool Saturday
        {
            get
            {
                return this.saturdayField;
            }
            set
            {
                this.saturdayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MonthlyRecurrence : RecurrencePattern
    {
        
        private string daysField;
        
        private MonthsOfYearSelector monthsOfYearField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Days
        {
            get
            {
                return this.daysField;
            }
            set
            {
                this.daysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MonthsOfYearSelector MonthsOfYear
        {
            get
            {
                return this.monthsOfYearField;
            }
            set
            {
                this.monthsOfYearField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MonthsOfYearSelector
    {
        
        private bool januaryField;
        
        private bool februaryField;
        
        private bool marchField;
        
        private bool aprilField;
        
        private bool mayField;
        
        private bool juneField;
        
        private bool julyField;
        
        private bool augustField;
        
        private bool septemberField;
        
        private bool octoberField;
        
        private bool novemberField;
        
        private bool decemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool January
        {
            get
            {
                return this.januaryField;
            }
            set
            {
                this.januaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool February
        {
            get
            {
                return this.februaryField;
            }
            set
            {
                this.februaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool March
        {
            get
            {
                return this.marchField;
            }
            set
            {
                this.marchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool April
        {
            get
            {
                return this.aprilField;
            }
            set
            {
                this.aprilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool May
        {
            get
            {
                return this.mayField;
            }
            set
            {
                this.mayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool June
        {
            get
            {
                return this.juneField;
            }
            set
            {
                this.juneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool July
        {
            get
            {
                return this.julyField;
            }
            set
            {
                this.julyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool August
        {
            get
            {
                return this.augustField;
            }
            set
            {
                this.augustField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool September
        {
            get
            {
                return this.septemberField;
            }
            set
            {
                this.septemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool October
        {
            get
            {
                return this.octoberField;
            }
            set
            {
                this.octoberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool November
        {
            get
            {
                return this.novemberField;
            }
            set
            {
                this.novemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool December
        {
            get
            {
                return this.decemberField;
            }
            set
            {
                this.decemberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MonthlyDOWRecurrence : RecurrencePattern
    {
        
        private WeekNumberEnum whichWeekField;
        
        private bool whichWeekFieldSpecified;
        
        private DaysOfWeekSelector daysOfWeekField;
        
        private MonthsOfYearSelector monthsOfYearField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WeekNumberEnum WhichWeek
        {
            get
            {
                return this.whichWeekField;
            }
            set
            {
                this.whichWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WhichWeekSpecified
        {
            get
            {
                return this.whichWeekFieldSpecified;
            }
            set
            {
                this.whichWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DaysOfWeekSelector DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }
            set
            {
                this.daysOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public MonthsOfYearSelector MonthsOfYear
        {
            get
            {
                return this.monthsOfYearField;
            }
            set
            {
                this.monthsOfYearField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum WeekNumberEnum
    {
        
        /// <remarks/>
        FirstWeek,
        
        /// <remarks/>
        SecondWeek,
        
        /// <remarks/>
        ThirdWeek,
        
        /// <remarks/>
        FourthWeek,
        
        /// <remarks/>
        LastWeek,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class MinuteRecurrence : RecurrencePattern
    {
        
        private int minutesIntervalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int MinutesInterval
        {
            get
            {
                return this.minutesIntervalField;
            }
            set
            {
                this.minutesIntervalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoSchedule))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleDefinitionOrReference
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class NoSchedule : ScheduleDefinitionOrReference
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ScheduleReference : ScheduleDefinitionOrReference
    {
        
        private string scheduleIDField;
        
        private ScheduleDefinition definitionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ScheduleID
        {
            get
            {
                return this.scheduleIDField;
            }
            set
            {
                this.scheduleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ScheduleDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class TimeExpiration : ExpirationDefinition
    {
        
        private int minutesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Minutes
        {
            get
            {
                return this.minutesField;
            }
            set
            {
                this.minutesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceCredentials
    {
        
        private string dataSourceNameField;
        
        private string userNameField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DataSourceName
        {
            get
            {
                return this.dataSourceNameField;
            }
            set
            {
                this.dataSourceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemParameter
    {
        
        private string nameField;
        
        private string parameterTypeNameField;
        
        private bool nullableField;
        
        private bool nullableFieldSpecified;
        
        private bool allowBlankField;
        
        private bool allowBlankFieldSpecified;
        
        private bool multiValueField;
        
        private bool multiValueFieldSpecified;
        
        private bool queryParameterField;
        
        private bool queryParameterFieldSpecified;
        
        private string promptField;
        
        private bool promptUserField;
        
        private bool promptUserFieldSpecified;
        
        private string[] dependenciesField;
        
        private bool validValuesQueryBasedField;
        
        private bool validValuesQueryBasedFieldSpecified;
        
        private ValidValue[] validValuesField;
        
        private bool defaultValuesQueryBasedField;
        
        private bool defaultValuesQueryBasedFieldSpecified;
        
        private string[] defaultValuesField;
        
        private string parameterStateNameField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ParameterTypeName
        {
            get
            {
                return this.parameterTypeNameField;
            }
            set
            {
                this.parameterTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }
            set
            {
                this.nullableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool AllowBlank
        {
            get
            {
                return this.allowBlankField;
            }
            set
            {
                this.allowBlankField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowBlankSpecified
        {
            get
            {
                return this.allowBlankFieldSpecified;
            }
            set
            {
                this.allowBlankFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool MultiValue
        {
            get
            {
                return this.multiValueField;
            }
            set
            {
                this.multiValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultiValueSpecified
        {
            get
            {
                return this.multiValueFieldSpecified;
            }
            set
            {
                this.multiValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool QueryParameter
        {
            get
            {
                return this.queryParameterField;
            }
            set
            {
                this.queryParameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueryParameterSpecified
        {
            get
            {
                return this.queryParameterFieldSpecified;
            }
            set
            {
                this.queryParameterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool PromptUser
        {
            get
            {
                return this.promptUserField;
            }
            set
            {
                this.promptUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromptUserSpecified
        {
            get
            {
                return this.promptUserFieldSpecified;
            }
            set
            {
                this.promptUserFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Dependency")]
        public string[] Dependencies
        {
            get
            {
                return this.dependenciesField;
            }
            set
            {
                this.dependenciesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool ValidValuesQueryBased
        {
            get
            {
                return this.validValuesQueryBasedField;
            }
            set
            {
                this.validValuesQueryBasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidValuesQueryBasedSpecified
        {
            get
            {
                return this.validValuesQueryBasedFieldSpecified;
            }
            set
            {
                this.validValuesQueryBasedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=10)]
        public ValidValue[] ValidValues
        {
            get
            {
                return this.validValuesField;
            }
            set
            {
                this.validValuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool DefaultValuesQueryBased
        {
            get
            {
                return this.defaultValuesQueryBasedField;
            }
            set
            {
                this.defaultValuesQueryBasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultValuesQueryBasedSpecified
        {
            get
            {
                return this.defaultValuesQueryBasedFieldSpecified;
            }
            set
            {
                this.defaultValuesQueryBasedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=12)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value")]
        public string[] DefaultValues
        {
            get
            {
                return this.defaultValuesField;
            }
            set
            {
                this.defaultValuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string ParameterStateName
        {
            get
            {
                return this.parameterStateNameField;
            }
            set
            {
                this.parameterStateNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ValidValue
    {
        
        private string labelField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Schedule
    {
        
        private string scheduleIDField;
        
        private string nameField;
        
        private ScheduleDefinition definitionField;
        
        private string descriptionField;
        
        private string creatorField;
        
        private System.DateTime nextRunTimeField;
        
        private bool nextRunTimeFieldSpecified;
        
        private System.DateTime lastRunTimeField;
        
        private bool lastRunTimeFieldSpecified;
        
        private bool referencesPresentField;
        
        private string scheduleStateNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ScheduleID
        {
            get
            {
                return this.scheduleIDField;
            }
            set
            {
                this.scheduleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ScheduleDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime NextRunTime
        {
            get
            {
                return this.nextRunTimeField;
            }
            set
            {
                this.nextRunTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NextRunTimeSpecified
        {
            get
            {
                return this.nextRunTimeFieldSpecified;
            }
            set
            {
                this.nextRunTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime LastRunTime
        {
            get
            {
                return this.lastRunTimeField;
            }
            set
            {
                this.lastRunTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastRunTimeSpecified
        {
            get
            {
                return this.lastRunTimeFieldSpecified;
            }
            set
            {
                this.lastRunTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool ReferencesPresent
        {
            get
            {
                return this.referencesPresentField;
            }
            set
            {
                this.referencesPresentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ScheduleStateName
        {
            get
            {
                return this.scheduleStateNameField;
            }
            set
            {
                this.scheduleStateNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelPerspective
    {
        
        private string idField;
        
        private string nameField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelCatalogItem
    {
        
        private string modelField;
        
        private string descriptionField;
        
        private ModelPerspective[] perspectivesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public ModelPerspective[] Perspectives
        {
            get
            {
                return this.perspectivesField;
            }
            set
            {
                this.perspectivesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelItem
    {
        
        private string idField;
        
        private string nameField;
        
        private string modelItemTypeNameField;
        
        private string descriptionField;
        
        private ModelItem[] modelItemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ModelItemTypeName
        {
            get
            {
                return this.modelItemTypeNameField;
            }
            set
            {
                this.modelItemTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        public ModelItem[] ModelItems
        {
            get
            {
                return this.modelItemsField;
            }
            set
            {
                this.modelItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ModelDrillthroughReport
    {
        
        private string pathField;
        
        private DrillthroughType typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DrillthroughType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum DrillthroughType
    {
        
        /// <remarks/>
        Detail,
        
        /// <remarks/>
        List,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourcePrompt
    {
        
        private string nameField;
        
        private string dataSourceIDField;
        
        private string promptField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DataSourceID
        {
            get
            {
                return this.dataSourceIDField;
            }
            set
            {
                this.dataSourceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Policy
    {
        
        private string groupUserNameField;
        
        private Role[] rolesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string GroupUserName
        {
            get
            {
                return this.groupUserNameField;
            }
            set
            {
                this.groupUserNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public Role[] Roles
        {
            get
            {
                return this.rolesField;
            }
            set
            {
                this.rolesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Role
    {
        
        private string nameField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Task
    {
        
        private string taskIDField;
        
        private string nameField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TaskID
        {
            get
            {
                return this.taskIDField;
            }
            set
            {
                this.taskIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSource
    {
        
        private string nameField;
        
        private DataSourceDefinitionOrReference itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSourceDefinition", typeof(DataSourceDefinition), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("DataSourceReference", typeof(DataSourceReference), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("InvalidDataSourceReference", typeof(InvalidDataSourceReference), Order=1)]
        public DataSourceDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceDefinition : DataSourceDefinitionOrReference
    {
        
        private string extensionField;
        
        private string connectStringField;
        
        private bool useOriginalConnectStringField;
        
        private bool originalConnectStringExpressionBasedField;
        
        private CredentialRetrievalEnum credentialRetrievalField;
        
        private bool windowsCredentialsField;
        
        private bool impersonateUserField;
        
        private bool impersonateUserFieldSpecified;
        
        private string promptField;
        
        private string userNameField;
        
        private string passwordField;
        
        private bool enabledField;
        
        private bool enabledFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ConnectString
        {
            get
            {
                return this.connectStringField;
            }
            set
            {
                this.connectStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool UseOriginalConnectString
        {
            get
            {
                return this.useOriginalConnectStringField;
            }
            set
            {
                this.useOriginalConnectStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool OriginalConnectStringExpressionBased
        {
            get
            {
                return this.originalConnectStringExpressionBasedField;
            }
            set
            {
                this.originalConnectStringExpressionBasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public CredentialRetrievalEnum CredentialRetrieval
        {
            get
            {
                return this.credentialRetrievalField;
            }
            set
            {
                this.credentialRetrievalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool WindowsCredentials
        {
            get
            {
                return this.windowsCredentialsField;
            }
            set
            {
                this.windowsCredentialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool ImpersonateUser
        {
            get
            {
                return this.impersonateUserField;
            }
            set
            {
                this.impersonateUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImpersonateUserSpecified
        {
            get
            {
                return this.impersonateUserFieldSpecified;
            }
            set
            {
                this.impersonateUserFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }
            set
            {
                this.enabledFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum CredentialRetrievalEnum
    {
        
        /// <remarks/>
        Prompt,
        
        /// <remarks/>
        Store,
        
        /// <remarks/>
        Integrated,
        
        /// <remarks/>
        None,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSourceReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidDataSourceReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSourceDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceDefinitionOrReference
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSourceReference : DataSourceDefinitionOrReference
    {
        
        private string referenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class InvalidDataSourceReference : DataSourceDefinitionOrReference
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Subscription
    {
        
        private string subscriptionIDField;
        
        private string ownerField;
        
        private string pathField;
        
        private string virtualPathField;
        
        private string reportField;
        
        private ExtensionSettings deliverySettingsField;
        
        private string descriptionField;
        
        private string statusField;
        
        private ActiveState activeField;
        
        private System.DateTime lastExecutedField;
        
        private bool lastExecutedFieldSpecified;
        
        private string modifiedByField;
        
        private System.DateTime modifiedDateField;
        
        private string eventTypeField;
        
        private bool isDataDrivenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SubscriptionID
        {
            get
            {
                return this.subscriptionIDField;
            }
            set
            {
                this.subscriptionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string VirtualPath
        {
            get
            {
                return this.virtualPathField;
            }
            set
            {
                this.virtualPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Report
        {
            get
            {
                return this.reportField;
            }
            set
            {
                this.reportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ExtensionSettings DeliverySettings
        {
            get
            {
                return this.deliverySettingsField;
            }
            set
            {
                this.deliverySettingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public ActiveState Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public System.DateTime LastExecuted
        {
            get
            {
                return this.lastExecutedField;
            }
            set
            {
                this.lastExecutedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastExecutedSpecified
        {
            get
            {
                return this.lastExecutedFieldSpecified;
            }
            set
            {
                this.lastExecutedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public bool IsDataDriven
        {
            get
            {
                return this.isDataDrivenField;
            }
            set
            {
                this.isDataDrivenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ExtensionSettings
    {
        
        private string extensionField;
        
        private ParameterValueOrFieldReference[] parameterValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(ParameterFieldReference))]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(ParameterValue))]
        public ParameterValueOrFieldReference[] ParameterValues
        {
            get
            {
                return this.parameterValuesField;
            }
            set
            {
                this.parameterValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ParameterFieldReference : ParameterValueOrFieldReference
    {
        
        private string parameterNameField;
        
        private string fieldAliasField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FieldAlias
        {
            get
            {
                return this.fieldAliasField;
            }
            set
            {
                this.fieldAliasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValue))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterFieldReference))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ParameterValueOrFieldReference
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ParameterValue : ParameterValueOrFieldReference
    {
        
        private string nameField;
        
        private string valueField;
        
        private string labelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ActiveState
    {
        
        private bool deliveryExtensionRemovedField;
        
        private bool deliveryExtensionRemovedFieldSpecified;
        
        private bool sharedDataSourceRemovedField;
        
        private bool sharedDataSourceRemovedFieldSpecified;
        
        private bool missingParameterValueField;
        
        private bool missingParameterValueFieldSpecified;
        
        private bool invalidParameterValueField;
        
        private bool invalidParameterValueFieldSpecified;
        
        private bool unknownReportParameterField;
        
        private bool unknownReportParameterFieldSpecified;
        
        private bool disabledByUserField;
        
        private bool disabledByUserFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool DeliveryExtensionRemoved
        {
            get
            {
                return this.deliveryExtensionRemovedField;
            }
            set
            {
                this.deliveryExtensionRemovedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryExtensionRemovedSpecified
        {
            get
            {
                return this.deliveryExtensionRemovedFieldSpecified;
            }
            set
            {
                this.deliveryExtensionRemovedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool SharedDataSourceRemoved
        {
            get
            {
                return this.sharedDataSourceRemovedField;
            }
            set
            {
                this.sharedDataSourceRemovedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SharedDataSourceRemovedSpecified
        {
            get
            {
                return this.sharedDataSourceRemovedFieldSpecified;
            }
            set
            {
                this.sharedDataSourceRemovedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool MissingParameterValue
        {
            get
            {
                return this.missingParameterValueField;
            }
            set
            {
                this.missingParameterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MissingParameterValueSpecified
        {
            get
            {
                return this.missingParameterValueFieldSpecified;
            }
            set
            {
                this.missingParameterValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool InvalidParameterValue
        {
            get
            {
                return this.invalidParameterValueField;
            }
            set
            {
                this.invalidParameterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvalidParameterValueSpecified
        {
            get
            {
                return this.invalidParameterValueFieldSpecified;
            }
            set
            {
                this.invalidParameterValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool UnknownReportParameter
        {
            get
            {
                return this.unknownReportParameterField;
            }
            set
            {
                this.unknownReportParameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnknownReportParameterSpecified
        {
            get
            {
                return this.unknownReportParameterFieldSpecified;
            }
            set
            {
                this.unknownReportParameterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool DisabledByUser
        {
            get
            {
                return this.disabledByUserField;
            }
            set
            {
                this.disabledByUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisabledByUserSpecified
        {
            get
            {
                return this.disabledByUserFieldSpecified;
            }
            set
            {
                this.disabledByUserFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ExtensionParameter
    {
        
        private string nameField;
        
        private string displayNameField;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        private bool readOnlyField;
        
        private string valueField;
        
        private string errorField;
        
        private bool encryptedField;
        
        private bool isPasswordField;
        
        private ValidValue[] validValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool Required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredSpecified
        {
            get
            {
                return this.requiredFieldSpecified;
            }
            set
            {
                this.requiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool Encrypted
        {
            get
            {
                return this.encryptedField;
            }
            set
            {
                this.encryptedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool IsPassword
        {
            get
            {
                return this.isPasswordField;
            }
            set
            {
                this.isPasswordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value")]
        public ValidValue[] ValidValues
        {
            get
            {
                return this.validValuesField;
            }
            set
            {
                this.validValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class QueryDefinition
    {
        
        private string commandTypeField;
        
        private string commandTextField;
        
        private int timeoutField;
        
        private bool timeoutFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CommandType
        {
            get
            {
                return this.commandTypeField;
            }
            set
            {
                this.commandTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CommandText
        {
            get
            {
                return this.commandTextField;
            }
            set
            {
                this.commandTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeoutSpecified
        {
            get
            {
                return this.timeoutFieldSpecified;
            }
            set
            {
                this.timeoutFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Field
    {
        
        private string aliasField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataSetDefinition
    {
        
        private Field[] fieldsField;
        
        private QueryDefinition queryField;
        
        private SensitivityEnum caseSensitivityField;
        
        private bool caseSensitivityFieldSpecified;
        
        private string collationField;
        
        private SensitivityEnum accentSensitivityField;
        
        private bool accentSensitivityFieldSpecified;
        
        private SensitivityEnum kanatypeSensitivityField;
        
        private bool kanatypeSensitivityFieldSpecified;
        
        private SensitivityEnum widthSensitivityField;
        
        private bool widthSensitivityFieldSpecified;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public Field[] Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public QueryDefinition Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SensitivityEnum CaseSensitivity
        {
            get
            {
                return this.caseSensitivityField;
            }
            set
            {
                this.caseSensitivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseSensitivitySpecified
        {
            get
            {
                return this.caseSensitivityFieldSpecified;
            }
            set
            {
                this.caseSensitivityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Collation
        {
            get
            {
                return this.collationField;
            }
            set
            {
                this.collationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public SensitivityEnum AccentSensitivity
        {
            get
            {
                return this.accentSensitivityField;
            }
            set
            {
                this.accentSensitivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccentSensitivitySpecified
        {
            get
            {
                return this.accentSensitivityFieldSpecified;
            }
            set
            {
                this.accentSensitivityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public SensitivityEnum KanatypeSensitivity
        {
            get
            {
                return this.kanatypeSensitivityField;
            }
            set
            {
                this.kanatypeSensitivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KanatypeSensitivitySpecified
        {
            get
            {
                return this.kanatypeSensitivityFieldSpecified;
            }
            set
            {
                this.kanatypeSensitivityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public SensitivityEnum WidthSensitivity
        {
            get
            {
                return this.widthSensitivityField;
            }
            set
            {
                this.widthSensitivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WidthSensitivitySpecified
        {
            get
            {
                return this.widthSensitivityFieldSpecified;
            }
            set
            {
                this.widthSensitivityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum SensitivityEnum
    {
        
        /// <remarks/>
        True,
        
        /// <remarks/>
        False,
        
        /// <remarks/>
        Auto,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class DataRetrievalPlan
    {
        
        private DataSourceDefinitionOrReference itemField;
        
        private DataSetDefinition dataSetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSourceDefinition", typeof(DataSourceDefinition), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DataSourceReference", typeof(DataSourceReference), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("InvalidDataSourceReference", typeof(InvalidDataSourceReference), Order=0)]
        public DataSourceDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DataSetDefinition DataSet
        {
            get
            {
                return this.dataSetField;
            }
            set
            {
                this.dataSetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemReferenceData
    {
        
        private string nameField;
        
        private string referenceField;
        
        private string referenceTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ReferenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemReference
    {
        
        private string nameField;
        
        private string referenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemNamespaceHeader
    {
        
        private ItemNamespaceEnum itemNamespaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ItemNamespaceEnum ItemNamespace
        {
            get
            {
                return this.itemNamespaceField;
            }
            set
            {
                this.itemNamespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum ItemNamespaceEnum
    {
        
        /// <remarks/>
        PathBased,
        
        /// <remarks/>
        GUIDBased,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SearchCondition
    {
        
        private ConditionEnum conditionField;
        
        private bool conditionFieldSpecified;
        
        private string[] valuesField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ConditionEnum Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConditionSpecified
        {
            get
            {
                return this.conditionFieldSpecified;
            }
            set
            {
                this.conditionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value")]
        public string[] Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum ConditionEnum
    {
        
        /// <remarks/>
        Contains,
        
        /// <remarks/>
        Equals,
        
        /// <remarks/>
        In,
        
        /// <remarks/>
        Between,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ItemHistorySnapshot
    {
        
        private string historyIDField;
        
        private System.DateTime creationDateField;
        
        private int sizeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string HistoryID
        {
            get
            {
                return this.historyIDField;
            }
            set
            {
                this.historyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SYSTEMTIME
    {
        
        private short yearField;
        
        private short monthField;
        
        private short dayOfWeekField;
        
        private short dayField;
        
        private short hourField;
        
        private short minuteField;
        
        private short secondField;
        
        private short millisecondsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public short year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public short month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public short dayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public short day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public short hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public short minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public short second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public short milliseconds
        {
            get
            {
                return this.millisecondsField;
            }
            set
            {
                this.millisecondsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class TimeZoneInformation
    {
        
        private int biasField;
        
        private int standardBiasField;
        
        private SYSTEMTIME standardDateField;
        
        private int daylightBiasField;
        
        private SYSTEMTIME daylightDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Bias
        {
            get
            {
                return this.biasField;
            }
            set
            {
                this.biasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int StandardBias
        {
            get
            {
                return this.standardBiasField;
            }
            set
            {
                this.standardBiasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SYSTEMTIME StandardDate
        {
            get
            {
                return this.standardDateField;
            }
            set
            {
                this.standardDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int DaylightBias
        {
            get
            {
                return this.daylightBiasField;
            }
            set
            {
                this.daylightBiasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public SYSTEMTIME DaylightDate
        {
            get
            {
                return this.daylightDateField;
            }
            set
            {
                this.daylightDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ServerInfoHeader
    {
        
        private string reportServerVersionNumberField;
        
        private string reportServerEditionField;
        
        private string reportServerVersionField;
        
        private string reportServerDateTimeField;
        
        private TimeZoneInformation reportServerTimeZoneInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ReportServerVersionNumber
        {
            get
            {
                return this.reportServerVersionNumberField;
            }
            set
            {
                this.reportServerVersionNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ReportServerEdition
        {
            get
            {
                return this.reportServerEditionField;
            }
            set
            {
                this.reportServerEditionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ReportServerVersion
        {
            get
            {
                return this.reportServerVersionField;
            }
            set
            {
                this.reportServerVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ReportServerDateTime
        {
            get
            {
                return this.reportServerDateTimeField;
            }
            set
            {
                this.reportServerDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public TimeZoneInformation ReportServerTimeZoneInfo
        {
            get
            {
                return this.reportServerTimeZoneInfoField;
            }
            set
            {
                this.reportServerTimeZoneInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Warning
    {
        
        private string codeField;
        
        private string severityField;
        
        private string objectNameField;
        
        private string objectTypeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ObjectName
        {
            get
            {
                return this.objectNameField;
            }
            set
            {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CatalogItem
    {
        
        private string idField;
        
        private string nameField;
        
        private string pathField;
        
        private string virtualPathField;
        
        private string typeNameField;
        
        private int sizeField;
        
        private bool sizeFieldSpecified;
        
        private string descriptionField;
        
        private bool hiddenField;
        
        private bool hiddenFieldSpecified;
        
        private System.DateTime creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private System.DateTime modifiedDateField;
        
        private bool modifiedDateFieldSpecified;
        
        private string createdByField;
        
        private string modifiedByField;
        
        private Property[] itemMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string VirtualPath
        {
            get
            {
                return this.virtualPathField;
            }
            set
            {
                this.virtualPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeSpecified
        {
            get
            {
                return this.sizeFieldSpecified;
            }
            set
            {
                this.sizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool Hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HiddenSpecified
        {
            get
            {
                return this.hiddenFieldSpecified;
            }
            set
            {
                this.hiddenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedDateSpecified
        {
            get
            {
                return this.modifiedDateFieldSpecified;
            }
            set
            {
                this.modifiedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=12)]
        public Property[] ItemMetadata
        {
            get
            {
                return this.itemMetadataField;
            }
            set
            {
                this.itemMetadataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class Property
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCatalogItem", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateCatalogItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Parent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public bool Overwrite;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Definition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public CreateCatalogItemRequest()
        {
        }
        
        public CreateCatalogItemRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemType, string Name, string Parent, bool Overwrite, byte[] Definition, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemType = ItemType;
            this.Name = Name;
            this.Parent = Parent;
            this.Overwrite = Overwrite;
            this.Definition = Definition;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCatalogItemResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateCatalogItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem ItemInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Warning[] Warnings;
        
        public CreateCatalogItemResponse()
        {
        }
        
        public CreateCatalogItemResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem ItemInfo, Cake.SSRS.Services.Warning[] Warnings)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ItemInfo = ItemInfo;
            this.Warnings = Warnings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemDefinition", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemDefinitionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Definition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public SetItemDefinitionRequest()
        {
        }
        
        public SetItemDefinitionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, byte[] Definition, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Definition = Definition;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemDefinitionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemDefinitionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Warning[] Warnings;
        
        public SetItemDefinitionResponse()
        {
        }
        
        public SetItemDefinitionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Warning[] Warnings)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Warnings = Warnings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemDefinition", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemDefinitionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemDefinitionRequest()
        {
        }
        
        public GetItemDefinitionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemDefinitionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemDefinitionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Definition;
        
        public GetItemDefinitionResponse()
        {
        }
        
        public GetItemDefinitionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, byte[] Definition)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Definition = Definition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemType", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemTypeRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemTypeRequest()
        {
        }
        
        public GetItemTypeRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemTypeResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemTypeResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Type;
        
        public GetItemTypeResponse()
        {
        }
        
        public GetItemTypeResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string Type)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Type = Type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteItem", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public DeleteItemRequest()
        {
        }
        
        public DeleteItemRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteItemResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DeleteItemResponse()
        {
        }
        
        public DeleteItemResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MoveItem", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class MoveItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Target;
        
        public MoveItemRequest()
        {
        }
        
        public MoveItemRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Target)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Target = Target;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MoveItemResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class MoveItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public MoveItemResponse()
        {
        }
        
        public MoveItemResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InheritParentSecurity", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class InheritParentSecurityRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public InheritParentSecurityRequest()
        {
        }
        
        public InheritParentSecurityRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InheritParentSecurityResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class InheritParentSecurityResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public InheritParentSecurityResponse()
        {
        }
        
        public InheritParentSecurityResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListItemHistory", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListItemHistoryRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public ListItemHistoryRequest()
        {
        }
        
        public ListItemHistoryRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListItemHistoryResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListItemHistoryResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ItemHistorySnapshot[] ItemHistory;
        
        public ListItemHistoryResponse()
        {
        }
        
        public ListItemHistoryResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ItemHistorySnapshot[] ItemHistory)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ItemHistory = ItemHistory;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListChildren", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListChildrenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool Recursive;
        
        public ListChildrenRequest()
        {
        }
        
        public ListChildrenRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool Recursive)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Recursive = Recursive;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListChildrenResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListChildrenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem[] CatalogItems;
        
        public ListChildrenResponse()
        {
        }
        
        public ListChildrenResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem[] CatalogItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.CatalogItems = CatalogItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListDependentItems", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListDependentItemsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public ListDependentItemsRequest()
        {
        }
        
        public ListDependentItemsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListDependentItemsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListDependentItemsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem[] CatalogItems;
        
        public ListDependentItemsResponse()
        {
        }
        
        public ListDependentItemsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem[] CatalogItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.CatalogItems = CatalogItems;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public enum BooleanOperatorEnum
    {
        
        /// <remarks/>
        And,
        
        /// <remarks/>
        Or,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindItems", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class FindItemsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Folder;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.BooleanOperatorEnum BooleanOperator;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.Property[] SearchOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public Cake.SSRS.Services.SearchCondition[] SearchConditions;
        
        public FindItemsRequest()
        {
        }
        
        public FindItemsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Folder, Cake.SSRS.Services.BooleanOperatorEnum BooleanOperator, Cake.SSRS.Services.Property[] SearchOptions, Cake.SSRS.Services.SearchCondition[] SearchConditions)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Folder = Folder;
            this.BooleanOperator = BooleanOperator;
            this.SearchOptions = SearchOptions;
            this.SearchConditions = SearchConditions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindItemsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class FindItemsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem[] Items;
        
        public FindItemsResponse()
        {
        }
        
        public FindItemsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem[] Items)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Items = Items;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListParents", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListParentsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public ListParentsRequest()
        {
        }
        
        public ListParentsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListParentsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListParentsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem[] ListParentsResult;
        
        public ListParentsResponse()
        {
        }
        
        public ListParentsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem[] ListParentsResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListParentsResult = ListParentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateFolder", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateFolderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Folder;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Parent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public CreateFolderRequest()
        {
        }
        
        public CreateFolderRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Folder, string Parent, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Folder = Folder;
            this.Parent = Parent;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateFolderResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateFolderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem ItemInfo;
        
        public CreateFolderResponse()
        {
        }
        
        public CreateFolderResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem ItemInfo)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ItemInfo = ItemInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public SetPropertiesRequest()
        {
        }
        
        public SetPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetPropertiesResponse()
        {
        }
        
        public SetPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ItemNamespaceHeader ItemNamespaceHeader;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public GetPropertiesRequest()
        {
        }
        
        public GetPropertiesRequest(Cake.SSRS.Services.ItemNamespaceHeader ItemNamespaceHeader, Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.Property[] Properties)
        {
            this.ItemNamespaceHeader = ItemNamespaceHeader;
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Values;
        
        public GetPropertiesResponse()
        {
        }
        
        public GetPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Property[] Values)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Values = Values;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemReferences", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemReferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ItemReference[] ItemReferences;
        
        public SetItemReferencesRequest()
        {
        }
        
        public SetItemReferencesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ItemReference[] ItemReferences)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.ItemReferences = ItemReferences;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemReferencesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemReferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetItemReferencesResponse()
        {
        }
        
        public SetItemReferencesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemReferences", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemReferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ReferenceItemType;
        
        public GetItemReferencesRequest()
        {
        }
        
        public GetItemReferencesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string ReferenceItemType)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.ReferenceItemType = ReferenceItemType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemReferencesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemReferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ItemReferenceData[] ItemReferences;
        
        public GetItemReferencesResponse()
        {
        }
        
        public GetItemReferencesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ItemReferenceData[] ItemReferences)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ItemReferences = ItemReferences;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListItemTypes", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListItemTypesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListItemTypesRequest()
        {
        }
        
        public ListItemTypesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListItemTypesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListItemTypesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListItemTypesResult;
        
        public ListItemTypesResponse()
        {
        }
        
        public ListItemTypesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListItemTypesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListItemTypesResult = ListItemTypesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSubscriptionProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSubscriptionPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ExtensionSettings ExtensionSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public Cake.SSRS.Services.ParameterValue[] Parameters;
        
        public SetSubscriptionPropertiesRequest()
        {
        }
        
        public SetSubscriptionPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SubscriptionID = SubscriptionID;
            this.ExtensionSettings = ExtensionSettings;
            this.Description = Description;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSubscriptionPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSubscriptionPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetSubscriptionPropertiesResponse()
        {
        }
        
        public SetSubscriptionPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSubscriptionProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSubscriptionPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        public GetSubscriptionPropertiesRequest()
        {
        }
        
        public GetSubscriptionPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SubscriptionID = SubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSubscriptionPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSubscriptionPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Owner;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ExtensionSettings ExtensionSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public Cake.SSRS.Services.ActiveState Active;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public string Status;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=6)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=7)]
        public Cake.SSRS.Services.ParameterValue[] Parameters;
        
        public GetSubscriptionPropertiesResponse()
        {
        }
        
        public GetSubscriptionPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string Owner, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, string Description, Cake.SSRS.Services.ActiveState Active, string Status, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Owner = Owner;
            this.ExtensionSettings = ExtensionSettings;
            this.Description = Description;
            this.Active = Active;
            this.Status = Status;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDataDrivenSubscriptionProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetDataDrivenSubscriptionPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataDrivenSubscriptionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ExtensionSettings ExtensionSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=6)]
        public Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters;
        
        public SetDataDrivenSubscriptionPropertiesRequest()
        {
        }
        
        public SetDataDrivenSubscriptionPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataDrivenSubscriptionID, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataDrivenSubscriptionID = DataDrivenSubscriptionID;
            this.ExtensionSettings = ExtensionSettings;
            this.DataRetrievalPlan = DataRetrievalPlan;
            this.Description = Description;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDataDrivenSubscriptionPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetDataDrivenSubscriptionPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetDataDrivenSubscriptionPropertiesResponse()
        {
        }
        
        public SetDataDrivenSubscriptionPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataDrivenSubscriptionProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetDataDrivenSubscriptionPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataDrivenSubscriptionID;
        
        public GetDataDrivenSubscriptionPropertiesRequest()
        {
        }
        
        public GetDataDrivenSubscriptionPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataDrivenSubscriptionID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataDrivenSubscriptionID = DataDrivenSubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataDrivenSubscriptionPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetDataDrivenSubscriptionPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Owner;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ExtensionSettings ExtensionSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public Cake.SSRS.Services.ActiveState Active;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public string Status;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=6)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=7)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=8)]
        public Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters;
        
        public GetDataDrivenSubscriptionPropertiesResponse()
        {
        }
        
        public GetDataDrivenSubscriptionPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string Owner, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan, string Description, Cake.SSRS.Services.ActiveState Active, string Status, string EventType, string MatchData, Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Owner = Owner;
            this.ExtensionSettings = ExtensionSettings;
            this.DataRetrievalPlan = DataRetrievalPlan;
            this.Description = Description;
            this.Active = Active;
            this.Status = Status;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DisableSubscription", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DisableSubscriptionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        public DisableSubscriptionRequest()
        {
        }
        
        public DisableSubscriptionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SubscriptionID = SubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DisableSubscriptionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DisableSubscriptionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DisableSubscriptionResponse()
        {
        }
        
        public DisableSubscriptionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EnableSubscription", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class EnableSubscriptionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        public EnableSubscriptionRequest()
        {
        }
        
        public EnableSubscriptionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SubscriptionID = SubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EnableSubscriptionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class EnableSubscriptionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public EnableSubscriptionResponse()
        {
        }
        
        public EnableSubscriptionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteSubscription", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteSubscriptionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        public DeleteSubscriptionRequest()
        {
        }
        
        public DeleteSubscriptionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SubscriptionID = SubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteSubscriptionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteSubscriptionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DeleteSubscriptionResponse()
        {
        }
        
        public DeleteSubscriptionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateSubscription", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateSubscriptionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ExtensionSettings ExtensionSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public Cake.SSRS.Services.ParameterValue[] Parameters;
        
        public CreateSubscriptionRequest()
        {
        }
        
        public CreateSubscriptionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.ExtensionSettings = ExtensionSettings;
            this.Description = Description;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateSubscriptionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateSubscriptionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        public CreateSubscriptionResponse()
        {
        }
        
        public CreateSubscriptionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string SubscriptionID)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.SubscriptionID = SubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateDataDrivenSubscription", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateDataDrivenSubscriptionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ExtensionSettings ExtensionSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=6)]
        public Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters;
        
        public CreateDataDrivenSubscriptionRequest()
        {
        }
        
        public CreateDataDrivenSubscriptionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.ExtensionSettings = ExtensionSettings;
            this.DataRetrievalPlan = DataRetrievalPlan;
            this.Description = Description;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateDataDrivenSubscriptionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateDataDrivenSubscriptionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        public CreateDataDrivenSubscriptionResponse()
        {
        }
        
        public CreateDataDrivenSubscriptionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string SubscriptionID)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.SubscriptionID = SubscriptionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetExtensionSettings", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetExtensionSettingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Extension;
        
        public GetExtensionSettingsRequest()
        {
        }
        
        public GetExtensionSettingsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Extension)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Extension = Extension;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetExtensionSettingsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetExtensionSettingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ExtensionParameter[] ExtensionParameters;
        
        public GetExtensionSettingsResponse()
        {
        }
        
        public GetExtensionSettingsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ExtensionParameter[] ExtensionParameters)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ExtensionParameters = ExtensionParameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateExtensionSettings", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ValidateExtensionSettingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Extension;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ParameterValueOrFieldReference[] ParameterValues;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string SiteUrl;
        
        public ValidateExtensionSettingsRequest()
        {
        }
        
        public ValidateExtensionSettingsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Extension, Cake.SSRS.Services.ParameterValueOrFieldReference[] ParameterValues, string SiteUrl)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Extension = Extension;
            this.ParameterValues = ParameterValues;
            this.SiteUrl = SiteUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidateExtensionSettingsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ValidateExtensionSettingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ExtensionParameter[] ParameterErrors;
        
        public ValidateExtensionSettingsResponse()
        {
        }
        
        public ValidateExtensionSettingsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ExtensionParameter[] ParameterErrors)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ParameterErrors = ParameterErrors;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSubscriptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSubscriptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPathOrSiteURL;
        
        public ListSubscriptionsRequest()
        {
        }
        
        public ListSubscriptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPathOrSiteURL = ItemPathOrSiteURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSubscriptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSubscriptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Subscription[] SubscriptionItems;
        
        public ListSubscriptionsResponse()
        {
        }
        
        public ListSubscriptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Subscription[] SubscriptionItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.SubscriptionItems = SubscriptionItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListMySubscriptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListMySubscriptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPathOrSiteURL;
        
        public ListMySubscriptionsRequest()
        {
        }
        
        public ListMySubscriptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPathOrSiteURL = ItemPathOrSiteURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListMySubscriptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListMySubscriptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Subscription[] SubscriptionItems;
        
        public ListMySubscriptionsResponse()
        {
        }
        
        public ListMySubscriptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Subscription[] SubscriptionItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.SubscriptionItems = SubscriptionItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSubscriptionsUsingDataSource", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSubscriptionsUsingDataSourceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        public ListSubscriptionsUsingDataSourceRequest()
        {
        }
        
        public ListSubscriptionsUsingDataSourceRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSubscriptionsUsingDataSourceResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSubscriptionsUsingDataSourceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Subscription[] SubscriptionItems;
        
        public ListSubscriptionsUsingDataSourceResponse()
        {
        }
        
        public ListSubscriptionsUsingDataSourceResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Subscription[] SubscriptionItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.SubscriptionItems = SubscriptionItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ChangeSubscriptionOwner", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ChangeSubscriptionOwnerRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SubscriptionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string NewOwner;
        
        public ChangeSubscriptionOwnerRequest()
        {
        }
        
        public ChangeSubscriptionOwnerRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID, string NewOwner)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SubscriptionID = SubscriptionID;
            this.NewOwner = NewOwner;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ChangeSubscriptionOwnerResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ChangeSubscriptionOwnerResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public ChangeSubscriptionOwnerResponse()
        {
        }
        
        public ChangeSubscriptionOwnerResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateDataSource", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateDataSourceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Parent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public bool Overwrite;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public Cake.SSRS.Services.DataSourceDefinition Definition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public CreateDataSourceRequest()
        {
        }
        
        public CreateDataSourceRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource, string Parent, bool Overwrite, Cake.SSRS.Services.DataSourceDefinition Definition, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
            this.Parent = Parent;
            this.Overwrite = Overwrite;
            this.Definition = Definition;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateDataSourceResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateDataSourceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem ItemInfo;
        
        public CreateDataSourceResponse()
        {
        }
        
        public CreateDataSourceResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem ItemInfo)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ItemInfo = ItemInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PrepareQuery", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class PrepareQueryRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.DataSource DataSource;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.DataSetDefinition DataSet;
        
        public PrepareQueryRequest()
        {
        }
        
        public PrepareQueryRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.DataSource DataSource, Cake.SSRS.Services.DataSetDefinition DataSet)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
            this.DataSet = DataSet;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PrepareQueryResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class PrepareQueryResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.DataSetDefinition DataSettings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool Changed;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string[] ParameterNames;
        
        public PrepareQueryResponse()
        {
        }
        
        public PrepareQueryResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.DataSetDefinition DataSettings, bool Changed, string[] ParameterNames)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.DataSettings = DataSettings;
            this.Changed = Changed;
            this.ParameterNames = ParameterNames;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EnableDataSource", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class EnableDataSourceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        public EnableDataSourceRequest()
        {
        }
        
        public EnableDataSourceRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EnableDataSourceResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class EnableDataSourceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public EnableDataSourceResponse()
        {
        }
        
        public EnableDataSourceResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DisableDataSource", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DisableDataSourceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        public DisableDataSourceRequest()
        {
        }
        
        public DisableDataSourceRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DisableDataSourceResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DisableDataSourceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DisableDataSourceResponse()
        {
        }
        
        public DisableDataSourceResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDataSourceContents", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetDataSourceContentsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.DataSourceDefinition Definition;
        
        public SetDataSourceContentsRequest()
        {
        }
        
        public SetDataSourceContentsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource, Cake.SSRS.Services.DataSourceDefinition Definition)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
            this.Definition = Definition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDataSourceContentsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetDataSourceContentsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetDataSourceContentsResponse()
        {
        }
        
        public SetDataSourceContentsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataSourceContents", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetDataSourceContentsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        public GetDataSourceContentsRequest()
        {
        }
        
        public GetDataSourceContentsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataSourceContentsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetDataSourceContentsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.DataSourceDefinition Definition;
        
        public GetDataSourceContentsResponse()
        {
        }
        
        public GetDataSourceContentsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.DataSourceDefinition Definition)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Definition = Definition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListDatabaseCredentialRetrievalOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListDatabaseCredentialRetrievalOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListDatabaseCredentialRetrievalOptionsRequest()
        {
        }
        
        public ListDatabaseCredentialRetrievalOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListDatabaseCredentialRetrievalOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListDatabaseCredentialRetrievalOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListDatabaseCredentialRetrievalOptionsResult;
        
        public ListDatabaseCredentialRetrievalOptionsResponse()
        {
        }
        
        public ListDatabaseCredentialRetrievalOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListDatabaseCredentialRetrievalOptionsResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListDatabaseCredentialRetrievalOptionsResult = ListDatabaseCredentialRetrievalOptionsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemDataSources", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemDataSourcesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.DataSource[] DataSources;
        
        public SetItemDataSourcesRequest()
        {
        }
        
        public SetItemDataSourcesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.DataSource[] DataSources)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.DataSources = DataSources;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemDataSourcesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemDataSourcesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetItemDataSourcesResponse()
        {
        }
        
        public SetItemDataSourcesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemDataSources", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemDataSourcesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemDataSourcesRequest()
        {
        }
        
        public GetItemDataSourcesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemDataSourcesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemDataSourcesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.DataSource[] DataSources;
        
        public GetItemDataSourcesResponse()
        {
        }
        
        public GetItemDataSourcesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.DataSource[] DataSources)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.DataSources = DataSources;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestConnectForDataSourceDefinition", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class TestConnectForDataSourceDefinitionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.DataSourceDefinition DataSourceDefinition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string UserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Password;
        
        public TestConnectForDataSourceDefinitionRequest()
        {
        }
        
        public TestConnectForDataSourceDefinitionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.DataSourceDefinition DataSourceDefinition, string UserName, string Password)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSourceDefinition = DataSourceDefinition;
            this.UserName = UserName;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestConnectForDataSourceDefinitionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class TestConnectForDataSourceDefinitionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool TestConnectForDataSourceDefinitionResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ConnectError;
        
        public TestConnectForDataSourceDefinitionResponse()
        {
        }
        
        public TestConnectForDataSourceDefinitionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, bool TestConnectForDataSourceDefinitionResult, string ConnectError)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.TestConnectForDataSourceDefinitionResult = TestConnectForDataSourceDefinitionResult;
            this.ConnectError = ConnectError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestConnectForItemDataSource", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class TestConnectForItemDataSourceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string DataSourceName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string UserName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string Password;
        
        public TestConnectForItemDataSourceRequest()
        {
        }
        
        public TestConnectForItemDataSourceRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string DataSourceName, string UserName, string Password)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.DataSourceName = DataSourceName;
            this.UserName = UserName;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestConnectForItemDataSourceResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class TestConnectForItemDataSourceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool TestConnectForItemDataSourceResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ConnectError;
        
        public TestConnectForItemDataSourceResponse()
        {
        }
        
        public TestConnectForItemDataSourceResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, bool TestConnectForItemDataSourceResult, string ConnectError)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.TestConnectForItemDataSourceResult = TestConnectForItemDataSourceResult;
            this.ConnectError = ConnectError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateRole", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateRoleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string[] TaskIDs;
        
        public CreateRoleRequest()
        {
        }
        
        public CreateRoleRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Name = Name;
            this.Description = Description;
            this.TaskIDs = TaskIDs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateRoleResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateRoleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public CreateRoleResponse()
        {
        }
        
        public CreateRoleResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetRoleProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetRolePropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string[] TaskIDs;
        
        public SetRolePropertiesRequest()
        {
        }
        
        public SetRolePropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Name = Name;
            this.Description = Description;
            this.TaskIDs = TaskIDs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetRolePropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetRolePropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetRolePropertiesResponse()
        {
        }
        
        public SetRolePropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRoleProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetRolePropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string SiteUrl;
        
        public GetRolePropertiesRequest()
        {
        }
        
        public GetRolePropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string SiteUrl)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Name = Name;
            this.SiteUrl = SiteUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRolePropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetRolePropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] TaskIDs;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Description;
        
        public GetRolePropertiesResponse()
        {
        }
        
        public GetRolePropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] TaskIDs, string Description)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.TaskIDs = TaskIDs;
            this.Description = Description;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteRole", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteRoleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Name;
        
        public DeleteRoleRequest()
        {
        }
        
        public DeleteRoleRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteRoleResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteRoleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DeleteRoleResponse()
        {
        }
        
        public DeleteRoleResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListRoles", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListRolesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SecurityScope;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string SiteUrl;
        
        public ListRolesRequest()
        {
        }
        
        public ListRolesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SecurityScope, string SiteUrl)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SecurityScope = SecurityScope;
            this.SiteUrl = SiteUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListRolesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListRolesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Role[] Roles;
        
        public ListRolesResponse()
        {
        }
        
        public ListRolesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Role[] Roles)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Roles = Roles;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListTasks", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListTasksRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SecurityScope;
        
        public ListTasksRequest()
        {
        }
        
        public ListTasksRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SecurityScope)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SecurityScope = SecurityScope;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListTasksResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListTasksResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Task[] Tasks;
        
        public ListTasksResponse()
        {
        }
        
        public ListTasksResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Task[] Tasks)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Tasks = Tasks;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Policy[] Policies;
        
        public SetPoliciesRequest()
        {
        }
        
        public SetPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.Policy[] Policies)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Policies = Policies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetPoliciesResponse()
        {
        }
        
        public SetPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetPoliciesRequest()
        {
        }
        
        public GetPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Policy[] Policies;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool InheritParent;
        
        public GetPoliciesResponse()
        {
        }
        
        public GetPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Policy[] Policies, bool InheritParent)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Policies = Policies;
            this.InheritParent = InheritParent;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemDataSourcePrompts", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemDataSourcePromptsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemDataSourcePromptsRequest()
        {
        }
        
        public GetItemDataSourcePromptsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemDataSourcePromptsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemDataSourcePromptsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.DataSourcePrompt[] DataSourcePrompts;
        
        public GetItemDataSourcePromptsResponse()
        {
        }
        
        public GetItemDataSourcePromptsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.DataSourcePrompt[] DataSourcePrompts)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.DataSourcePrompts = DataSourcePrompts;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenerateModel", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GenerateModelRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string DataSource;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Parent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public GenerateModelRequest()
        {
        }
        
        public GenerateModelRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource, string Model, string Parent, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.DataSource = DataSource;
            this.Model = Model;
            this.Parent = Parent;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenerateModelResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GenerateModelResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem ItemInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Warning[] Warnings;
        
        public GenerateModelResponse()
        {
        }
        
        public GenerateModelResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem ItemInfo, Cake.SSRS.Services.Warning[] Warnings)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ItemInfo = ItemInfo;
            this.Warnings = Warnings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetModelItemPermissions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetModelItemPermissionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        public GetModelItemPermissionsRequest()
        {
        }
        
        public GetModelItemPermissionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetModelItemPermissionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetModelItemPermissionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] Permissions;
        
        public GetModelItemPermissionsResponse()
        {
        }
        
        public GetModelItemPermissionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] Permissions)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Permissions = Permissions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetModelItemPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetModelItemPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.Policy[] Policies;
        
        public SetModelItemPoliciesRequest()
        {
        }
        
        public SetModelItemPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Cake.SSRS.Services.Policy[] Policies)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
            this.Policies = Policies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetModelItemPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetModelItemPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetModelItemPoliciesResponse()
        {
        }
        
        public SetModelItemPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetModelItemPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetModelItemPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        public GetModelItemPoliciesRequest()
        {
        }
        
        public GetModelItemPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetModelItemPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetModelItemPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Policy[] Policies;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool InheritParent;
        
        public GetModelItemPoliciesResponse()
        {
        }
        
        public GetModelItemPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Policy[] Policies, bool InheritParent)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Policies = Policies;
            this.InheritParent = InheritParent;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUserModel", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetUserModelRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Perspective;
        
        public GetUserModelRequest()
        {
        }
        
        public GetUserModelRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string Perspective)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.Perspective = Perspective;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUserModelResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetUserModelResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Definition;
        
        public GetUserModelResponse()
        {
        }
        
        public GetUserModelResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, byte[] Definition)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Definition = Definition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InheritModelItemParentSecurity", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class InheritModelItemParentSecurityRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        public InheritModelItemParentSecurityRequest()
        {
        }
        
        public InheritModelItemParentSecurityRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InheritModelItemParentSecurityResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class InheritModelItemParentSecurityResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public InheritModelItemParentSecurityResponse()
        {
        }
        
        public InheritModelItemParentSecurityResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetModelDrillthroughReports", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetModelDrillthroughReportsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.ModelDrillthroughReport[] Reports;
        
        public SetModelDrillthroughReportsRequest()
        {
        }
        
        public SetModelDrillthroughReportsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Cake.SSRS.Services.ModelDrillthroughReport[] Reports)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
            this.Reports = Reports;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetModelDrillthroughReportsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetModelDrillthroughReportsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetModelDrillthroughReportsResponse()
        {
        }
        
        public SetModelDrillthroughReportsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelDrillthroughReports", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelDrillthroughReportsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        public ListModelDrillthroughReportsRequest()
        {
        }
        
        public ListModelDrillthroughReportsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelDrillthroughReportsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelDrillthroughReportsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ModelDrillthroughReport[] Reports;
        
        public ListModelDrillthroughReportsResponse()
        {
        }
        
        public ListModelDrillthroughReportsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ModelDrillthroughReport[] Reports)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Reports = Reports;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelItemChildren", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelItemChildrenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ModelItemID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public bool Recursive;
        
        public ListModelItemChildrenRequest()
        {
        }
        
        public ListModelItemChildrenRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, bool Recursive)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
            this.ModelItemID = ModelItemID;
            this.Recursive = Recursive;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelItemChildrenResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelItemChildrenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ModelItem[] ModelItems;
        
        public ListModelItemChildrenResponse()
        {
        }
        
        public ListModelItemChildrenResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ModelItem[] ModelItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ModelItems = ModelItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelItemTypes", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelItemTypesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListModelItemTypesRequest()
        {
        }
        
        public ListModelItemTypesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelItemTypesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelItemTypesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListModelItemTypesResult;
        
        public ListModelItemTypesResponse()
        {
        }
        
        public ListModelItemTypesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListModelItemTypesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListModelItemTypesResult = ListModelItemTypesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelPerspectives", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelPerspectivesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        public ListModelPerspectivesRequest()
        {
        }
        
        public ListModelPerspectivesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListModelPerspectivesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListModelPerspectivesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ModelCatalogItem[] ModelCatalogItems;
        
        public ListModelPerspectivesResponse()
        {
        }
        
        public ListModelPerspectivesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ModelCatalogItem[] ModelCatalogItems)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ModelCatalogItems = ModelCatalogItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegenerateModel", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class RegenerateModelRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        public RegenerateModelRequest()
        {
        }
        
        public RegenerateModelRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegenerateModelResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class RegenerateModelResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Warning[] Warnings;
        
        public RegenerateModelResponse()
        {
        }
        
        public RegenerateModelResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Warning[] Warnings)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Warnings = Warnings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveAllModelItemPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class RemoveAllModelItemPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Model;
        
        public RemoveAllModelItemPoliciesRequest()
        {
        }
        
        public RemoveAllModelItemPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Model = Model;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveAllModelItemPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class RemoveAllModelItemPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public RemoveAllModelItemPoliciesResponse()
        {
        }
        
        public RemoveAllModelItemPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateSchedule", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateScheduleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ScheduleDefinition ScheduleDefinition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string SiteUrl;
        
        public CreateScheduleRequest()
        {
        }
        
        public CreateScheduleRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, Cake.SSRS.Services.ScheduleDefinition ScheduleDefinition, string SiteUrl)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Name = Name;
            this.ScheduleDefinition = ScheduleDefinition;
            this.SiteUrl = SiteUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateScheduleResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateScheduleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ScheduleID;
        
        public CreateScheduleResponse()
        {
        }
        
        public CreateScheduleResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string ScheduleID)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ScheduleID = ScheduleID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteSchedule", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteScheduleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ScheduleID;
        
        public DeleteScheduleRequest()
        {
        }
        
        public DeleteScheduleRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ScheduleID = ScheduleID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteScheduleResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteScheduleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DeleteScheduleResponse()
        {
        }
        
        public DeleteScheduleResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSchedules", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSchedulesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string SiteUrl;
        
        public ListSchedulesRequest()
        {
        }
        
        public ListSchedulesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SiteUrl)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.SiteUrl = SiteUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSchedulesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSchedulesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Schedule[] Schedules;
        
        public ListSchedulesResponse()
        {
        }
        
        public ListSchedulesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Schedule[] Schedules)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Schedules = Schedules;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScheduleProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSchedulePropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ScheduleID;
        
        public GetSchedulePropertiesRequest()
        {
        }
        
        public GetSchedulePropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ScheduleID = ScheduleID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSchedulePropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSchedulePropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Schedule Schedule;
        
        public GetSchedulePropertiesResponse()
        {
        }
        
        public GetSchedulePropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Schedule Schedule)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Schedule = Schedule;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListScheduleStates", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListScheduleStatesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListScheduleStatesRequest()
        {
        }
        
        public ListScheduleStatesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListScheduleStatesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListScheduleStatesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListScheduleStatesResult;
        
        public ListScheduleStatesResponse()
        {
        }
        
        public ListScheduleStatesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListScheduleStatesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListScheduleStatesResult = ListScheduleStatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PauseSchedule", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class PauseScheduleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ScheduleID;
        
        public PauseScheduleRequest()
        {
        }
        
        public PauseScheduleRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ScheduleID = ScheduleID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PauseScheduleResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class PauseScheduleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public PauseScheduleResponse()
        {
        }
        
        public PauseScheduleResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResumeSchedule", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ResumeScheduleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ScheduleID;
        
        public ResumeScheduleRequest()
        {
        }
        
        public ResumeScheduleRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ScheduleID = ScheduleID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResumeScheduleResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ResumeScheduleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public ResumeScheduleResponse()
        {
        }
        
        public ResumeScheduleResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetScheduleProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSchedulePropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ScheduleID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.ScheduleDefinition ScheduleDefinition;
        
        public SetSchedulePropertiesRequest()
        {
        }
        
        public SetSchedulePropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string ScheduleID, Cake.SSRS.Services.ScheduleDefinition ScheduleDefinition)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Name = Name;
            this.ScheduleID = ScheduleID;
            this.ScheduleDefinition = ScheduleDefinition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSchedulePropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSchedulePropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetSchedulePropertiesResponse()
        {
        }
        
        public SetSchedulePropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListScheduledItems", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListScheduledItemsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ScheduleID;
        
        public ListScheduledItemsRequest()
        {
        }
        
        public ListScheduledItemsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ScheduleID = ScheduleID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListScheduledItemsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListScheduledItemsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CatalogItem[] Items;
        
        public ListScheduledItemsResponse()
        {
        }
        
        public ListScheduledItemsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CatalogItem[] Items)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Items = Items;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemParameters", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemParametersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.ItemParameter[] Parameters;
        
        public SetItemParametersRequest()
        {
        }
        
        public SetItemParametersRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ItemParameter[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemParametersResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemParametersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetItemParametersResponse()
        {
        }
        
        public SetItemParametersResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemParameters", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemParametersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string HistoryID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public bool ForRendering;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public Cake.SSRS.Services.ParameterValue[] Values;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public Cake.SSRS.Services.DataSourceCredentials[] Credentials;
        
        public GetItemParametersRequest()
        {
        }
        
        public GetItemParametersRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID, bool ForRendering, Cake.SSRS.Services.ParameterValue[] Values, Cake.SSRS.Services.DataSourceCredentials[] Credentials)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.HistoryID = HistoryID;
            this.ForRendering = ForRendering;
            this.Values = Values;
            this.Credentials = Credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemParametersResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemParametersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.ItemParameter[] Parameters;
        
        public GetItemParametersResponse()
        {
        }
        
        public GetItemParametersResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.ItemParameter[] Parameters)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListParameterTypes", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListParameterTypesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListParameterTypesRequest()
        {
        }
        
        public ListParameterTypesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListParameterTypesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListParameterTypesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListParameterTypesResult;
        
        public ListParameterTypesResponse()
        {
        }
        
        public ListParameterTypesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListParameterTypesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListParameterTypesResult = ListParameterTypesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListParameterStates", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListParameterStatesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListParameterStatesRequest()
        {
        }
        
        public ListParameterStatesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListParameterStatesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListParameterStatesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListParameterStatesResult;
        
        public ListParameterStatesResponse()
        {
        }
        
        public ListParameterStatesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListParameterStatesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListParameterStatesResult = ListParameterStatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateReportEditSession", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateReportEditSessionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Report;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Parent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Definition;
        
        public CreateReportEditSessionRequest()
        {
        }
        
        public CreateReportEditSessionRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Report, string Parent, byte[] Definition)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Report = Report;
            this.Parent = Parent;
            this.Definition = Definition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateReportEditSessionResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateReportEditSessionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string EditSessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Warning[] Warnings;
        
        public CreateReportEditSessionResponse()
        {
        }
        
        public CreateReportEditSessionResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string EditSessionID, Cake.SSRS.Services.Warning[] Warnings)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.EditSessionID = EditSessionID;
            this.Warnings = Warnings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateLinkedItem", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateLinkedItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Parent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string Link;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public CreateLinkedItemRequest()
        {
        }
        
        public CreateLinkedItemRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Parent, string Link, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Parent = Parent;
            this.Link = Link;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateLinkedItemResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateLinkedItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public CreateLinkedItemResponse()
        {
        }
        
        public CreateLinkedItemResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemLink", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemLinkRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Link;
        
        public SetItemLinkRequest()
        {
        }
        
        public SetItemLinkRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Link)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Link = Link;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemLinkResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemLinkResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetItemLinkResponse()
        {
        }
        
        public SetItemLinkResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemLink", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemLinkRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemLinkRequest()
        {
        }
        
        public GetItemLinkRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemLinkResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemLinkResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Link;
        
        public GetItemLinkResponse()
        {
        }
        
        public GetItemLinkResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string Link)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Link = Link;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListExecutionSettings", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListExecutionSettingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListExecutionSettingsRequest()
        {
        }
        
        public ListExecutionSettingsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListExecutionSettingsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListExecutionSettingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListExecutionSettingsResult;
        
        public ListExecutionSettingsResponse()
        {
        }
        
        public ListExecutionSettingsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListExecutionSettingsResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListExecutionSettingsResult = ListExecutionSettingsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetExecutionOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetExecutionOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string ExecutionSetting;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))]
        public Cake.SSRS.Services.ScheduleDefinitionOrReference Item;
        
        public SetExecutionOptionsRequest()
        {
        }
        
        public SetExecutionOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string ExecutionSetting, Cake.SSRS.Services.ScheduleDefinitionOrReference Item)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.ExecutionSetting = ExecutionSetting;
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetExecutionOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetExecutionOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetExecutionOptionsResponse()
        {
        }
        
        public SetExecutionOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetExecutionOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetExecutionOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetExecutionOptionsRequest()
        {
        }
        
        public GetExecutionOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetExecutionOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetExecutionOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ExecutionSetting;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))]
        public Cake.SSRS.Services.ScheduleDefinitionOrReference Item;
        
        public GetExecutionOptionsResponse()
        {
        }
        
        public GetExecutionOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string ExecutionSetting, Cake.SSRS.Services.ScheduleDefinitionOrReference Item)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ExecutionSetting = ExecutionSetting;
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateItemExecutionSnapshot", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class UpdateItemExecutionSnapshotRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public UpdateItemExecutionSnapshotRequest()
        {
        }
        
        public UpdateItemExecutionSnapshotRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateItemExecutionSnapshotResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class UpdateItemExecutionSnapshotResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public UpdateItemExecutionSnapshotResponse()
        {
        }
        
        public UpdateItemExecutionSnapshotResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCacheOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetCacheOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool CacheItem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleExpiration", typeof(ScheduleExpiration))]
        [System.Xml.Serialization.XmlElementAttribute("TimeExpiration", typeof(TimeExpiration))]
        public Cake.SSRS.Services.ExpirationDefinition Item;
        
        public SetCacheOptionsRequest()
        {
        }
        
        public SetCacheOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool CacheItem, Cake.SSRS.Services.ExpirationDefinition Item)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.CacheItem = CacheItem;
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCacheOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetCacheOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetCacheOptionsResponse()
        {
        }
        
        public SetCacheOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCacheOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetCacheOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetCacheOptionsRequest()
        {
        }
        
        public GetCacheOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCacheOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetCacheOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool CacheItem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleExpiration", typeof(ScheduleExpiration))]
        [System.Xml.Serialization.XmlElementAttribute("TimeExpiration", typeof(TimeExpiration))]
        public Cake.SSRS.Services.ExpirationDefinition Item;
        
        public GetCacheOptionsResponse()
        {
        }
        
        public GetCacheOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, bool CacheItem, Cake.SSRS.Services.ExpirationDefinition Item)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.CacheItem = CacheItem;
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FlushCache", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class FlushCacheRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public FlushCacheRequest()
        {
        }
        
        public FlushCacheRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FlushCacheResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class FlushCacheResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public FlushCacheResponse()
        {
        }
        
        public FlushCacheResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateItemHistorySnapshot", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateItemHistorySnapshotRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public CreateItemHistorySnapshotRequest()
        {
        }
        
        public CreateItemHistorySnapshotRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateItemHistorySnapshotResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateItemHistorySnapshotResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string HistoryID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public Cake.SSRS.Services.Warning[] Warnings;
        
        public CreateItemHistorySnapshotResponse()
        {
        }
        
        public CreateItemHistorySnapshotResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string HistoryID, Cake.SSRS.Services.Warning[] Warnings)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.HistoryID = HistoryID;
            this.Warnings = Warnings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteItemHistorySnapshot", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteItemHistorySnapshotRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string HistoryID;
        
        public DeleteItemHistorySnapshotRequest()
        {
        }
        
        public DeleteItemHistorySnapshotRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.HistoryID = HistoryID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteItemHistorySnapshotResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteItemHistorySnapshotResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DeleteItemHistorySnapshotResponse()
        {
        }
        
        public DeleteItemHistorySnapshotResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemHistoryLimit", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemHistoryLimitRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool UseSystem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public int HistoryLimit;
        
        public SetItemHistoryLimitRequest()
        {
        }
        
        public SetItemHistoryLimitRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool UseSystem, int HistoryLimit)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.UseSystem = UseSystem;
            this.HistoryLimit = HistoryLimit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemHistoryLimitResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemHistoryLimitResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetItemHistoryLimitResponse()
        {
        }
        
        public SetItemHistoryLimitResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemHistoryLimit", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemHistoryLimitRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemHistoryLimitRequest()
        {
        }
        
        public GetItemHistoryLimitRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemHistoryLimitResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemHistoryLimitResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public int HistoryLimit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool IsSystem;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public int SystemLimit;
        
        public GetItemHistoryLimitResponse()
        {
        }
        
        public GetItemHistoryLimitResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, int HistoryLimit, bool IsSystem, int SystemLimit)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.HistoryLimit = HistoryLimit;
            this.IsSystem = IsSystem;
            this.SystemLimit = SystemLimit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemHistoryOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemHistoryOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool EnableManualSnapshotCreation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public bool KeepExecutionSnapshots;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))]
        public Cake.SSRS.Services.ScheduleDefinitionOrReference Item;
        
        public SetItemHistoryOptionsRequest()
        {
        }
        
        public SetItemHistoryOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, Cake.SSRS.Services.ScheduleDefinitionOrReference Item)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.EnableManualSnapshotCreation = EnableManualSnapshotCreation;
            this.KeepExecutionSnapshots = KeepExecutionSnapshots;
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetItemHistoryOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetItemHistoryOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetItemHistoryOptionsResponse()
        {
        }
        
        public SetItemHistoryOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemHistoryOptions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemHistoryOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetItemHistoryOptionsRequest()
        {
        }
        
        public GetItemHistoryOptionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetItemHistoryOptionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetItemHistoryOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool EnableManualSnapshotCreation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public bool KeepExecutionSnapshots;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("NoSchedule", typeof(NoSchedule))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleDefinition", typeof(ScheduleDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("ScheduleReference", typeof(ScheduleReference))]
        public Cake.SSRS.Services.ScheduleDefinitionOrReference Item;
        
        public GetItemHistoryOptionsResponse()
        {
        }
        
        public GetItemHistoryOptionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, Cake.SSRS.Services.ScheduleDefinitionOrReference Item)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.EnableManualSnapshotCreation = EnableManualSnapshotCreation;
            this.KeepExecutionSnapshots = KeepExecutionSnapshots;
            this.Item = Item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetReportServerConfigInfo", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetReportServerConfigInfoRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool ScaleOut;
        
        public GetReportServerConfigInfoRequest()
        {
        }
        
        public GetReportServerConfigInfoRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, bool ScaleOut)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ScaleOut = ScaleOut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetReportServerConfigInfoResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetReportServerConfigInfoResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ServerConfigInfo;
        
        public GetReportServerConfigInfoResponse()
        {
        }
        
        public GetReportServerConfigInfoResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string ServerConfigInfo)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ServerConfigInfo = ServerConfigInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsSSLRequired", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class IsSSLRequiredRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public IsSSLRequiredRequest()
        {
        }
        
        public IsSSLRequiredRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsSSLRequiredResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class IsSSLRequiredResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool IsSSLRequiredResult;
        
        public IsSSLRequiredResponse()
        {
        }
        
        public IsSSLRequiredResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, bool IsSSLRequiredResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.IsSSLRequiredResult = IsSSLRequiredResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSystemProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSystemPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public SetSystemPropertiesRequest()
        {
        }
        
        public SetSystemPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSystemPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSystemPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetSystemPropertiesResponse()
        {
        }
        
        public SetSystemPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSystemPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public GetSystemPropertiesRequest()
        {
        }
        
        public GetSystemPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSystemPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Values;
        
        public GetSystemPropertiesResponse()
        {
        }
        
        public GetSystemPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Property[] Values)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Values = Values;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetUserSettings", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetUserSettingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public SetUserSettingsRequest()
        {
        }
        
        public SetUserSettingsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetUserSettingsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetUserSettingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetUserSettingsResponse()
        {
        }
        
        public SetUserSettingsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUserSettings", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetUserSettingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Properties;
        
        public GetUserSettingsRequest()
        {
        }
        
        public GetUserSettingsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Properties = Properties;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUserSettingsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetUserSettingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Property[] Values;
        
        public GetUserSettingsResponse()
        {
        }
        
        public GetUserSettingsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Property[] Values)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Values = Values;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSystemPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSystemPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Policy[] Policies;
        
        public SetSystemPoliciesRequest()
        {
        }
        
        public SetSystemPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Policy[] Policies)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.Policies = Policies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetSystemPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetSystemPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetSystemPoliciesResponse()
        {
        }
        
        public SetSystemPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemPolicies", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSystemPoliciesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public GetSystemPoliciesRequest()
        {
        }
        
        public GetSystemPoliciesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemPoliciesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSystemPoliciesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Policy[] Policies;
        
        public GetSystemPoliciesResponse()
        {
        }
        
        public GetSystemPoliciesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Policy[] Policies)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Policies = Policies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListExtensions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListExtensionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ExtensionType;
        
        public ListExtensionsRequest()
        {
        }
        
        public ListExtensionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ExtensionType)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ExtensionType = ExtensionType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListExtensionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListExtensionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Extension[] Extensions;
        
        public ListExtensionsResponse()
        {
        }
        
        public ListExtensionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Extension[] Extensions)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Extensions = Extensions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListExtensionTypes", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListExtensionTypesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListExtensionTypesRequest()
        {
        }
        
        public ListExtensionTypesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListExtensionTypesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListExtensionTypesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListExtensionTypesResult;
        
        public ListExtensionTypesResponse()
        {
        }
        
        public ListExtensionTypesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListExtensionTypesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListExtensionTypesResult = ListExtensionTypesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListEvents", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListEventsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListEventsRequest()
        {
        }
        
        public ListEventsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListEventsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListEventsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Event[] Events;
        
        public ListEventsResponse()
        {
        }
        
        public ListEventsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Event[] Events)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Events = Events;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FireEvent", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class FireEventRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string EventData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string SiteUrl;
        
        public FireEventRequest()
        {
        }
        
        public FireEventRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string EventType, string EventData, string SiteUrl)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.EventType = EventType;
            this.EventData = EventData;
            this.SiteUrl = SiteUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FireEventResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class FireEventResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public FireEventResponse()
        {
        }
        
        public FireEventResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobs", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListJobsRequest()
        {
        }
        
        public ListJobsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.Job[] Jobs;
        
        public ListJobsResponse()
        {
        }
        
        public ListJobsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.Job[] Jobs)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Jobs = Jobs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobTypes", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobTypesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListJobTypesRequest()
        {
        }
        
        public ListJobTypesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobTypesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobTypesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListJobTypesResult;
        
        public ListJobTypesResponse()
        {
        }
        
        public ListJobTypesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListJobTypesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListJobTypesResult = ListJobTypesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobActions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobActionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListJobActionsRequest()
        {
        }
        
        public ListJobActionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobActionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobActionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListJobActionsResult;
        
        public ListJobActionsResponse()
        {
        }
        
        public ListJobActionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListJobActionsResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListJobActionsResult = ListJobActionsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobStates", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobStatesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListJobStatesRequest()
        {
        }
        
        public ListJobStatesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListJobStatesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListJobStatesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListJobStatesResult;
        
        public ListJobStatesResponse()
        {
        }
        
        public ListJobStatesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListJobStatesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListJobStatesResult = ListJobStatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CancelJob", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CancelJobRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string JobID;
        
        public CancelJobRequest()
        {
        }
        
        public CancelJobRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string JobID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.JobID = JobID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CancelJobResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CancelJobResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public bool CancelJobResult;
        
        public CancelJobResponse()
        {
        }
        
        public CancelJobResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, bool CancelJobResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.CancelJobResult = CancelJobResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCacheRefreshPlan", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateCacheRefreshPlanRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public Cake.SSRS.Services.ParameterValue[] Parameters;
        
        public CreateCacheRefreshPlanRequest()
        {
        }
        
        public CreateCacheRefreshPlanRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
            this.Description = Description;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCacheRefreshPlanResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class CreateCacheRefreshPlanResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string CacheRefreshPlanID;
        
        public CreateCacheRefreshPlanResponse()
        {
        }
        
        public CreateCacheRefreshPlanResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string CacheRefreshPlanID)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.CacheRefreshPlanID = CacheRefreshPlanID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCacheRefreshPlanProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetCacheRefreshPlanPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string CacheRefreshPlanID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public Cake.SSRS.Services.ParameterValue[] Parameters;
        
        public SetCacheRefreshPlanPropertiesRequest()
        {
        }
        
        public SetCacheRefreshPlanPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.CacheRefreshPlanID = CacheRefreshPlanID;
            this.Description = Description;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCacheRefreshPlanPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class SetCacheRefreshPlanPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public SetCacheRefreshPlanPropertiesResponse()
        {
        }
        
        public SetCacheRefreshPlanPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCacheRefreshPlanProperties", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetCacheRefreshPlanPropertiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string CacheRefreshPlanID;
        
        public GetCacheRefreshPlanPropertiesRequest()
        {
        }
        
        public GetCacheRefreshPlanPropertiesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.CacheRefreshPlanID = CacheRefreshPlanID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCacheRefreshPlanPropertiesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetCacheRefreshPlanPropertiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string LastRunStatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public Cake.SSRS.Services.CacheRefreshPlanState State;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=3)]
        public string EventType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=4)]
        public string MatchData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=5)]
        public Cake.SSRS.Services.ParameterValue[] Parameters;
        
        public GetCacheRefreshPlanPropertiesResponse()
        {
        }
        
        public GetCacheRefreshPlanPropertiesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string Description, string LastRunStatus, Cake.SSRS.Services.CacheRefreshPlanState State, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Description = Description;
            this.LastRunStatus = LastRunStatus;
            this.State = State;
            this.EventType = EventType;
            this.MatchData = MatchData;
            this.Parameters = Parameters;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCacheRefreshPlan", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteCacheRefreshPlanRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string CacheRefreshPlanID;
        
        public DeleteCacheRefreshPlanRequest()
        {
        }
        
        public DeleteCacheRefreshPlanRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.CacheRefreshPlanID = CacheRefreshPlanID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCacheRefreshPlanResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class DeleteCacheRefreshPlanResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public DeleteCacheRefreshPlanResponse()
        {
        }
        
        public DeleteCacheRefreshPlanResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListCacheRefreshPlans", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListCacheRefreshPlansRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public ListCacheRefreshPlansRequest()
        {
        }
        
        public ListCacheRefreshPlansRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListCacheRefreshPlansResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListCacheRefreshPlansResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public Cake.SSRS.Services.CacheRefreshPlan[] CacheRefreshPlans;
        
        public ListCacheRefreshPlansResponse()
        {
        }
        
        public ListCacheRefreshPlansResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, Cake.SSRS.Services.CacheRefreshPlan[] CacheRefreshPlans)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.CacheRefreshPlans = CacheRefreshPlans;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogonUser", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class LogonUserRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string userName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=2)]
        public string authority;
        
        public LogonUserRequest()
        {
        }
        
        public LogonUserRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string userName, string password, string authority)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.userName = userName;
            this.password = password;
            this.authority = authority;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogonUserResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class LogonUserResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public LogonUserResponse()
        {
        }
        
        public LogonUserResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Logoff", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class LogoffRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public LogoffRequest()
        {
        }
        
        public LogoffRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LogoffResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class LogoffResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        public LogoffResponse()
        {
        }
        
        public LogoffResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader)
        {
            this.ServerInfoHeader = ServerInfoHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPermissions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetPermissionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string ItemPath;
        
        public GetPermissionsRequest()
        {
        }
        
        public GetPermissionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            this.TrustedUserHeader = TrustedUserHeader;
            this.ItemPath = ItemPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPermissionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetPermissionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Operation")]
        public string[] Permissions;
        
        public GetPermissionsResponse()
        {
        }
        
        public GetPermissionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] Permissions)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Permissions = Permissions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemPermissions", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSystemPermissionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public GetSystemPermissionsRequest()
        {
        }
        
        public GetSystemPermissionsRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemPermissionsResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class GetSystemPermissionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Operation")]
        public string[] Permissions;
        
        public GetSystemPermissionsResponse()
        {
        }
        
        public GetSystemPermissionsResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] Permissions)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.Permissions = Permissions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSecurityScopes", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSecurityScopesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader;
        
        public ListSecurityScopesRequest()
        {
        }
        
        public ListSecurityScopesRequest(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            this.TrustedUserHeader = TrustedUserHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListSecurityScopesResponse", WrapperNamespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped=true)]
    public partial class ListSecurityScopesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order=0)]
        public string[] ListSecurityScopesResult;
        
        public ListSecurityScopesResponse()
        {
        }
        
        public ListSecurityScopesResponse(Cake.SSRS.Services.ServerInfoHeader ServerInfoHeader, string[] ListSecurityScopesResult)
        {
            this.ServerInfoHeader = ServerInfoHeader;
            this.ListSecurityScopesResult = ListSecurityScopesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface ReportingService2010SoapChannel : Cake.SSRS.Services.ReportingService2010Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class ReportingService2010SoapClient : System.ServiceModel.ClientBase<Cake.SSRS.Services.ReportingService2010Soap>, Cake.SSRS.Services.ReportingService2010Soap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ReportingService2010SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ReportingService2010SoapClient.GetBindingForEndpoint(endpointConfiguration), ReportingService2010SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportingService2010SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ReportingService2010SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportingService2010SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ReportingService2010SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportingService2010SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateCatalogItemResponse> CreateCatalogItemAsync(Cake.SSRS.Services.CreateCatalogItemRequest request)
        {
            return base.Channel.CreateCatalogItemAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemDefinitionResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemDefinitionAsync(Cake.SSRS.Services.SetItemDefinitionRequest request)
        {
            return base.Channel.SetItemDefinitionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemDefinitionResponse> SetItemDefinitionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, byte[] Definition, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.SetItemDefinitionRequest inValue = new Cake.SSRS.Services.SetItemDefinitionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Definition = Definition;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemDefinitionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDefinitionResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemDefinitionAsync(Cake.SSRS.Services.GetItemDefinitionRequest request)
        {
            return base.Channel.GetItemDefinitionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDefinitionResponse> GetItemDefinitionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.GetItemDefinitionRequest inValue = new Cake.SSRS.Services.GetItemDefinitionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemDefinitionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemTypeResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemTypeAsync(Cake.SSRS.Services.GetItemTypeRequest request)
        {
            return base.Channel.GetItemTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemTypeResponse> GetItemTypeAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.GetItemTypeRequest inValue = new Cake.SSRS.Services.GetItemTypeRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteItemResponse> Cake.SSRS.Services.ReportingService2010Soap.DeleteItemAsync(Cake.SSRS.Services.DeleteItemRequest request)
        {
            return base.Channel.DeleteItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteItemResponse> DeleteItemAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.DeleteItemRequest inValue = new Cake.SSRS.Services.DeleteItemRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DeleteItemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.MoveItemResponse> Cake.SSRS.Services.ReportingService2010Soap.MoveItemAsync(Cake.SSRS.Services.MoveItemRequest request)
        {
            return base.Channel.MoveItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.MoveItemResponse> MoveItemAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Target)
        {
            Cake.SSRS.Services.MoveItemRequest inValue = new Cake.SSRS.Services.MoveItemRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Target = Target;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).MoveItemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.InheritParentSecurityResponse> Cake.SSRS.Services.ReportingService2010Soap.InheritParentSecurityAsync(Cake.SSRS.Services.InheritParentSecurityRequest request)
        {
            return base.Channel.InheritParentSecurityAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.InheritParentSecurityResponse> InheritParentSecurityAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.InheritParentSecurityRequest inValue = new Cake.SSRS.Services.InheritParentSecurityRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).InheritParentSecurityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListItemHistoryResponse> Cake.SSRS.Services.ReportingService2010Soap.ListItemHistoryAsync(Cake.SSRS.Services.ListItemHistoryRequest request)
        {
            return base.Channel.ListItemHistoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListItemHistoryResponse> ListItemHistoryAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.ListItemHistoryRequest inValue = new Cake.SSRS.Services.ListItemHistoryRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListItemHistoryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListChildrenResponse> Cake.SSRS.Services.ReportingService2010Soap.ListChildrenAsync(Cake.SSRS.Services.ListChildrenRequest request)
        {
            return base.Channel.ListChildrenAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListChildrenResponse> ListChildrenAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool Recursive)
        {
            Cake.SSRS.Services.ListChildrenRequest inValue = new Cake.SSRS.Services.ListChildrenRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Recursive = Recursive;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListChildrenAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListDependentItemsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListDependentItemsAsync(Cake.SSRS.Services.ListDependentItemsRequest request)
        {
            return base.Channel.ListDependentItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListDependentItemsResponse> ListDependentItemsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.ListDependentItemsRequest inValue = new Cake.SSRS.Services.ListDependentItemsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListDependentItemsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.FindItemsResponse> Cake.SSRS.Services.ReportingService2010Soap.FindItemsAsync(Cake.SSRS.Services.FindItemsRequest request)
        {
            return base.Channel.FindItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.FindItemsResponse> FindItemsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Folder, Cake.SSRS.Services.BooleanOperatorEnum BooleanOperator, Cake.SSRS.Services.Property[] SearchOptions, Cake.SSRS.Services.SearchCondition[] SearchConditions)
        {
            Cake.SSRS.Services.FindItemsRequest inValue = new Cake.SSRS.Services.FindItemsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Folder = Folder;
            inValue.BooleanOperator = BooleanOperator;
            inValue.SearchOptions = SearchOptions;
            inValue.SearchConditions = SearchConditions;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).FindItemsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListParentsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListParentsAsync(Cake.SSRS.Services.ListParentsRequest request)
        {
            return base.Channel.ListParentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListParentsResponse> ListParentsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.ListParentsRequest inValue = new Cake.SSRS.Services.ListParentsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListParentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateFolderResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateFolderAsync(Cake.SSRS.Services.CreateFolderRequest request)
        {
            return base.Channel.CreateFolderAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateFolderResponse> CreateFolderAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Folder, string Parent, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.CreateFolderRequest inValue = new Cake.SSRS.Services.CreateFolderRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Folder = Folder;
            inValue.Parent = Parent;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateFolderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetPropertiesAsync(Cake.SSRS.Services.SetPropertiesRequest request)
        {
            return base.Channel.SetPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetPropertiesResponse> SetPropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.SetPropertiesRequest inValue = new Cake.SSRS.Services.SetPropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetPropertiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.GetPropertiesAsync(Cake.SSRS.Services.GetPropertiesRequest request)
        {
            return base.Channel.GetPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetPropertiesResponse> GetPropertiesAsync(Cake.SSRS.Services.ItemNamespaceHeader ItemNamespaceHeader, Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.GetPropertiesRequest inValue = new Cake.SSRS.Services.GetPropertiesRequest();
            inValue.ItemNamespaceHeader = ItemNamespaceHeader;
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetPropertiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemReferencesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemReferencesAsync(Cake.SSRS.Services.SetItemReferencesRequest request)
        {
            return base.Channel.SetItemReferencesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemReferencesResponse> SetItemReferencesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ItemReference[] ItemReferences)
        {
            Cake.SSRS.Services.SetItemReferencesRequest inValue = new Cake.SSRS.Services.SetItemReferencesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.ItemReferences = ItemReferences;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemReferencesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemReferencesResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemReferencesAsync(Cake.SSRS.Services.GetItemReferencesRequest request)
        {
            return base.Channel.GetItemReferencesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemReferencesResponse> GetItemReferencesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string ReferenceItemType)
        {
            Cake.SSRS.Services.GetItemReferencesRequest inValue = new Cake.SSRS.Services.GetItemReferencesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.ReferenceItemType = ReferenceItemType;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemReferencesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListItemTypesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListItemTypesAsync(Cake.SSRS.Services.ListItemTypesRequest request)
        {
            return base.Channel.ListItemTypesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListItemTypesResponse> ListItemTypesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListItemTypesRequest inValue = new Cake.SSRS.Services.ListItemTypesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListItemTypesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSubscriptionPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetSubscriptionPropertiesAsync(Cake.SSRS.Services.SetSubscriptionPropertiesRequest request)
        {
            return base.Channel.SetSubscriptionPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetSubscriptionPropertiesResponse> SetSubscriptionPropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            Cake.SSRS.Services.SetSubscriptionPropertiesRequest inValue = new Cake.SSRS.Services.SetSubscriptionPropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SubscriptionID = SubscriptionID;
            inValue.ExtensionSettings = ExtensionSettings;
            inValue.Description = Description;
            inValue.EventType = EventType;
            inValue.MatchData = MatchData;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetSubscriptionPropertiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetSubscriptionPropertiesResponse> GetSubscriptionPropertiesAsync(Cake.SSRS.Services.GetSubscriptionPropertiesRequest request)
        {
            return base.Channel.GetSubscriptionPropertiesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetDataDrivenSubscriptionPropertiesAsync(Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesRequest request)
        {
            return base.Channel.SetDataDrivenSubscriptionPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesResponse> SetDataDrivenSubscriptionPropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataDrivenSubscriptionID, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters)
        {
            Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesRequest inValue = new Cake.SSRS.Services.SetDataDrivenSubscriptionPropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataDrivenSubscriptionID = DataDrivenSubscriptionID;
            inValue.ExtensionSettings = ExtensionSettings;
            inValue.DataRetrievalPlan = DataRetrievalPlan;
            inValue.Description = Description;
            inValue.EventType = EventType;
            inValue.MatchData = MatchData;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetDataDrivenSubscriptionPropertiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetDataDrivenSubscriptionPropertiesResponse> GetDataDrivenSubscriptionPropertiesAsync(Cake.SSRS.Services.GetDataDrivenSubscriptionPropertiesRequest request)
        {
            return base.Channel.GetDataDrivenSubscriptionPropertiesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DisableSubscriptionResponse> Cake.SSRS.Services.ReportingService2010Soap.DisableSubscriptionAsync(Cake.SSRS.Services.DisableSubscriptionRequest request)
        {
            return base.Channel.DisableSubscriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DisableSubscriptionResponse> DisableSubscriptionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            Cake.SSRS.Services.DisableSubscriptionRequest inValue = new Cake.SSRS.Services.DisableSubscriptionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SubscriptionID = SubscriptionID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DisableSubscriptionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.EnableSubscriptionResponse> Cake.SSRS.Services.ReportingService2010Soap.EnableSubscriptionAsync(Cake.SSRS.Services.EnableSubscriptionRequest request)
        {
            return base.Channel.EnableSubscriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.EnableSubscriptionResponse> EnableSubscriptionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            Cake.SSRS.Services.EnableSubscriptionRequest inValue = new Cake.SSRS.Services.EnableSubscriptionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SubscriptionID = SubscriptionID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).EnableSubscriptionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteSubscriptionResponse> Cake.SSRS.Services.ReportingService2010Soap.DeleteSubscriptionAsync(Cake.SSRS.Services.DeleteSubscriptionRequest request)
        {
            return base.Channel.DeleteSubscriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteSubscriptionResponse> DeleteSubscriptionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID)
        {
            Cake.SSRS.Services.DeleteSubscriptionRequest inValue = new Cake.SSRS.Services.DeleteSubscriptionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SubscriptionID = SubscriptionID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DeleteSubscriptionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateSubscriptionResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateSubscriptionAsync(Cake.SSRS.Services.CreateSubscriptionRequest request)
        {
            return base.Channel.CreateSubscriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateSubscriptionResponse> CreateSubscriptionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            Cake.SSRS.Services.CreateSubscriptionRequest inValue = new Cake.SSRS.Services.CreateSubscriptionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.ExtensionSettings = ExtensionSettings;
            inValue.Description = Description;
            inValue.EventType = EventType;
            inValue.MatchData = MatchData;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateSubscriptionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateDataDrivenSubscriptionResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateDataDrivenSubscriptionAsync(Cake.SSRS.Services.CreateDataDrivenSubscriptionRequest request)
        {
            return base.Channel.CreateDataDrivenSubscriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateDataDrivenSubscriptionResponse> CreateDataDrivenSubscriptionAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ExtensionSettings ExtensionSettings, Cake.SSRS.Services.DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValueOrFieldReference[] Parameters)
        {
            Cake.SSRS.Services.CreateDataDrivenSubscriptionRequest inValue = new Cake.SSRS.Services.CreateDataDrivenSubscriptionRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.ExtensionSettings = ExtensionSettings;
            inValue.DataRetrievalPlan = DataRetrievalPlan;
            inValue.Description = Description;
            inValue.EventType = EventType;
            inValue.MatchData = MatchData;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateDataDrivenSubscriptionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetExtensionSettingsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetExtensionSettingsAsync(Cake.SSRS.Services.GetExtensionSettingsRequest request)
        {
            return base.Channel.GetExtensionSettingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetExtensionSettingsResponse> GetExtensionSettingsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Extension)
        {
            Cake.SSRS.Services.GetExtensionSettingsRequest inValue = new Cake.SSRS.Services.GetExtensionSettingsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Extension = Extension;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetExtensionSettingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ValidateExtensionSettingsResponse> Cake.SSRS.Services.ReportingService2010Soap.ValidateExtensionSettingsAsync(Cake.SSRS.Services.ValidateExtensionSettingsRequest request)
        {
            return base.Channel.ValidateExtensionSettingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ValidateExtensionSettingsResponse> ValidateExtensionSettingsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Extension, Cake.SSRS.Services.ParameterValueOrFieldReference[] ParameterValues, string SiteUrl)
        {
            Cake.SSRS.Services.ValidateExtensionSettingsRequest inValue = new Cake.SSRS.Services.ValidateExtensionSettingsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Extension = Extension;
            inValue.ParameterValues = ParameterValues;
            inValue.SiteUrl = SiteUrl;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ValidateExtensionSettingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSubscriptionsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListSubscriptionsAsync(Cake.SSRS.Services.ListSubscriptionsRequest request)
        {
            return base.Channel.ListSubscriptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListSubscriptionsResponse> ListSubscriptionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL)
        {
            Cake.SSRS.Services.ListSubscriptionsRequest inValue = new Cake.SSRS.Services.ListSubscriptionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPathOrSiteURL = ItemPathOrSiteURL;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListSubscriptionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListMySubscriptionsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListMySubscriptionsAsync(Cake.SSRS.Services.ListMySubscriptionsRequest request)
        {
            return base.Channel.ListMySubscriptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListMySubscriptionsResponse> ListMySubscriptionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPathOrSiteURL)
        {
            Cake.SSRS.Services.ListMySubscriptionsRequest inValue = new Cake.SSRS.Services.ListMySubscriptionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPathOrSiteURL = ItemPathOrSiteURL;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListMySubscriptionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSubscriptionsUsingDataSourceResponse> Cake.SSRS.Services.ReportingService2010Soap.ListSubscriptionsUsingDataSourceAsync(Cake.SSRS.Services.ListSubscriptionsUsingDataSourceRequest request)
        {
            return base.Channel.ListSubscriptionsUsingDataSourceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListSubscriptionsUsingDataSourceResponse> ListSubscriptionsUsingDataSourceAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            Cake.SSRS.Services.ListSubscriptionsUsingDataSourceRequest inValue = new Cake.SSRS.Services.ListSubscriptionsUsingDataSourceRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataSource = DataSource;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListSubscriptionsUsingDataSourceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ChangeSubscriptionOwnerResponse> Cake.SSRS.Services.ReportingService2010Soap.ChangeSubscriptionOwnerAsync(Cake.SSRS.Services.ChangeSubscriptionOwnerRequest request)
        {
            return base.Channel.ChangeSubscriptionOwnerAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ChangeSubscriptionOwnerResponse> ChangeSubscriptionOwnerAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SubscriptionID, string NewOwner)
        {
            Cake.SSRS.Services.ChangeSubscriptionOwnerRequest inValue = new Cake.SSRS.Services.ChangeSubscriptionOwnerRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SubscriptionID = SubscriptionID;
            inValue.NewOwner = NewOwner;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ChangeSubscriptionOwnerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateDataSourceResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateDataSourceAsync(Cake.SSRS.Services.CreateDataSourceRequest request)
        {
            return base.Channel.CreateDataSourceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateDataSourceResponse> CreateDataSourceAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource, string Parent, bool Overwrite, Cake.SSRS.Services.DataSourceDefinition Definition, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.CreateDataSourceRequest inValue = new Cake.SSRS.Services.CreateDataSourceRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataSource = DataSource;
            inValue.Parent = Parent;
            inValue.Overwrite = Overwrite;
            inValue.Definition = Definition;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateDataSourceAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.PrepareQueryResponse> PrepareQueryAsync(Cake.SSRS.Services.PrepareQueryRequest request)
        {
            return base.Channel.PrepareQueryAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.EnableDataSourceResponse> Cake.SSRS.Services.ReportingService2010Soap.EnableDataSourceAsync(Cake.SSRS.Services.EnableDataSourceRequest request)
        {
            return base.Channel.EnableDataSourceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.EnableDataSourceResponse> EnableDataSourceAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            Cake.SSRS.Services.EnableDataSourceRequest inValue = new Cake.SSRS.Services.EnableDataSourceRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataSource = DataSource;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).EnableDataSourceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DisableDataSourceResponse> Cake.SSRS.Services.ReportingService2010Soap.DisableDataSourceAsync(Cake.SSRS.Services.DisableDataSourceRequest request)
        {
            return base.Channel.DisableDataSourceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DisableDataSourceResponse> DisableDataSourceAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            Cake.SSRS.Services.DisableDataSourceRequest inValue = new Cake.SSRS.Services.DisableDataSourceRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataSource = DataSource;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DisableDataSourceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetDataSourceContentsResponse> Cake.SSRS.Services.ReportingService2010Soap.SetDataSourceContentsAsync(Cake.SSRS.Services.SetDataSourceContentsRequest request)
        {
            return base.Channel.SetDataSourceContentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetDataSourceContentsResponse> SetDataSourceContentsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource, Cake.SSRS.Services.DataSourceDefinition Definition)
        {
            Cake.SSRS.Services.SetDataSourceContentsRequest inValue = new Cake.SSRS.Services.SetDataSourceContentsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataSource = DataSource;
            inValue.Definition = Definition;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetDataSourceContentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetDataSourceContentsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetDataSourceContentsAsync(Cake.SSRS.Services.GetDataSourceContentsRequest request)
        {
            return base.Channel.GetDataSourceContentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetDataSourceContentsResponse> GetDataSourceContentsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string DataSource)
        {
            Cake.SSRS.Services.GetDataSourceContentsRequest inValue = new Cake.SSRS.Services.GetDataSourceContentsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.DataSource = DataSource;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetDataSourceContentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListDatabaseCredentialRetrievalOptionsAsync(Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsRequest request)
        {
            return base.Channel.ListDatabaseCredentialRetrievalOptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsResponse> ListDatabaseCredentialRetrievalOptionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsRequest inValue = new Cake.SSRS.Services.ListDatabaseCredentialRetrievalOptionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListDatabaseCredentialRetrievalOptionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemDataSourcesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemDataSourcesAsync(Cake.SSRS.Services.SetItemDataSourcesRequest request)
        {
            return base.Channel.SetItemDataSourcesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemDataSourcesResponse> SetItemDataSourcesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.DataSource[] DataSources)
        {
            Cake.SSRS.Services.SetItemDataSourcesRequest inValue = new Cake.SSRS.Services.SetItemDataSourcesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.DataSources = DataSources;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemDataSourcesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDataSourcesResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemDataSourcesAsync(Cake.SSRS.Services.GetItemDataSourcesRequest request)
        {
            return base.Channel.GetItemDataSourcesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDataSourcesResponse> GetItemDataSourcesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.GetItemDataSourcesRequest inValue = new Cake.SSRS.Services.GetItemDataSourcesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemDataSourcesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.TestConnectForDataSourceDefinitionResponse> TestConnectForDataSourceDefinitionAsync(Cake.SSRS.Services.TestConnectForDataSourceDefinitionRequest request)
        {
            return base.Channel.TestConnectForDataSourceDefinitionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.TestConnectForItemDataSourceResponse> TestConnectForItemDataSourceAsync(Cake.SSRS.Services.TestConnectForItemDataSourceRequest request)
        {
            return base.Channel.TestConnectForItemDataSourceAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateRoleResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateRoleAsync(Cake.SSRS.Services.CreateRoleRequest request)
        {
            return base.Channel.CreateRoleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateRoleResponse> CreateRoleAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
        {
            Cake.SSRS.Services.CreateRoleRequest inValue = new Cake.SSRS.Services.CreateRoleRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Name = Name;
            inValue.Description = Description;
            inValue.TaskIDs = TaskIDs;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateRoleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetRolePropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetRolePropertiesAsync(Cake.SSRS.Services.SetRolePropertiesRequest request)
        {
            return base.Channel.SetRolePropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetRolePropertiesResponse> SetRolePropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string Description, string[] TaskIDs)
        {
            Cake.SSRS.Services.SetRolePropertiesRequest inValue = new Cake.SSRS.Services.SetRolePropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Name = Name;
            inValue.Description = Description;
            inValue.TaskIDs = TaskIDs;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetRolePropertiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetRolePropertiesResponse> GetRolePropertiesAsync(Cake.SSRS.Services.GetRolePropertiesRequest request)
        {
            return base.Channel.GetRolePropertiesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteRoleResponse> Cake.SSRS.Services.ReportingService2010Soap.DeleteRoleAsync(Cake.SSRS.Services.DeleteRoleRequest request)
        {
            return base.Channel.DeleteRoleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteRoleResponse> DeleteRoleAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name)
        {
            Cake.SSRS.Services.DeleteRoleRequest inValue = new Cake.SSRS.Services.DeleteRoleRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Name = Name;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DeleteRoleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListRolesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListRolesAsync(Cake.SSRS.Services.ListRolesRequest request)
        {
            return base.Channel.ListRolesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListRolesResponse> ListRolesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SecurityScope, string SiteUrl)
        {
            Cake.SSRS.Services.ListRolesRequest inValue = new Cake.SSRS.Services.ListRolesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SecurityScope = SecurityScope;
            inValue.SiteUrl = SiteUrl;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListRolesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListTasksResponse> Cake.SSRS.Services.ReportingService2010Soap.ListTasksAsync(Cake.SSRS.Services.ListTasksRequest request)
        {
            return base.Channel.ListTasksAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListTasksResponse> ListTasksAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SecurityScope)
        {
            Cake.SSRS.Services.ListTasksRequest inValue = new Cake.SSRS.Services.ListTasksRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SecurityScope = SecurityScope;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListTasksAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetPoliciesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetPoliciesAsync(Cake.SSRS.Services.SetPoliciesRequest request)
        {
            return base.Channel.SetPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetPoliciesResponse> SetPoliciesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.Policy[] Policies)
        {
            Cake.SSRS.Services.SetPoliciesRequest inValue = new Cake.SSRS.Services.SetPoliciesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Policies = Policies;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetPoliciesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetPoliciesResponse> GetPoliciesAsync(Cake.SSRS.Services.GetPoliciesRequest request)
        {
            return base.Channel.GetPoliciesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDataSourcePromptsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemDataSourcePromptsAsync(Cake.SSRS.Services.GetItemDataSourcePromptsRequest request)
        {
            return base.Channel.GetItemDataSourcePromptsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemDataSourcePromptsResponse> GetItemDataSourcePromptsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.GetItemDataSourcePromptsRequest inValue = new Cake.SSRS.Services.GetItemDataSourcePromptsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemDataSourcePromptsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GenerateModelResponse> GenerateModelAsync(Cake.SSRS.Services.GenerateModelRequest request)
        {
            return base.Channel.GenerateModelAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetModelItemPermissionsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetModelItemPermissionsAsync(Cake.SSRS.Services.GetModelItemPermissionsRequest request)
        {
            return base.Channel.GetModelItemPermissionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetModelItemPermissionsResponse> GetModelItemPermissionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            Cake.SSRS.Services.GetModelItemPermissionsRequest inValue = new Cake.SSRS.Services.GetModelItemPermissionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.ModelItemID = ModelItemID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetModelItemPermissionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetModelItemPoliciesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetModelItemPoliciesAsync(Cake.SSRS.Services.SetModelItemPoliciesRequest request)
        {
            return base.Channel.SetModelItemPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetModelItemPoliciesResponse> SetModelItemPoliciesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Cake.SSRS.Services.Policy[] Policies)
        {
            Cake.SSRS.Services.SetModelItemPoliciesRequest inValue = new Cake.SSRS.Services.SetModelItemPoliciesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.ModelItemID = ModelItemID;
            inValue.Policies = Policies;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetModelItemPoliciesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetModelItemPoliciesResponse> GetModelItemPoliciesAsync(Cake.SSRS.Services.GetModelItemPoliciesRequest request)
        {
            return base.Channel.GetModelItemPoliciesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetUserModelResponse> Cake.SSRS.Services.ReportingService2010Soap.GetUserModelAsync(Cake.SSRS.Services.GetUserModelRequest request)
        {
            return base.Channel.GetUserModelAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetUserModelResponse> GetUserModelAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string Perspective)
        {
            Cake.SSRS.Services.GetUserModelRequest inValue = new Cake.SSRS.Services.GetUserModelRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.Perspective = Perspective;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetUserModelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.InheritModelItemParentSecurityResponse> Cake.SSRS.Services.ReportingService2010Soap.InheritModelItemParentSecurityAsync(Cake.SSRS.Services.InheritModelItemParentSecurityRequest request)
        {
            return base.Channel.InheritModelItemParentSecurityAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.InheritModelItemParentSecurityResponse> InheritModelItemParentSecurityAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            Cake.SSRS.Services.InheritModelItemParentSecurityRequest inValue = new Cake.SSRS.Services.InheritModelItemParentSecurityRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.ModelItemID = ModelItemID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).InheritModelItemParentSecurityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetModelDrillthroughReportsResponse> Cake.SSRS.Services.ReportingService2010Soap.SetModelDrillthroughReportsAsync(Cake.SSRS.Services.SetModelDrillthroughReportsRequest request)
        {
            return base.Channel.SetModelDrillthroughReportsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetModelDrillthroughReportsResponse> SetModelDrillthroughReportsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Cake.SSRS.Services.ModelDrillthroughReport[] Reports)
        {
            Cake.SSRS.Services.SetModelDrillthroughReportsRequest inValue = new Cake.SSRS.Services.SetModelDrillthroughReportsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.ModelItemID = ModelItemID;
            inValue.Reports = Reports;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetModelDrillthroughReportsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelDrillthroughReportsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListModelDrillthroughReportsAsync(Cake.SSRS.Services.ListModelDrillthroughReportsRequest request)
        {
            return base.Channel.ListModelDrillthroughReportsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelDrillthroughReportsResponse> ListModelDrillthroughReportsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID)
        {
            Cake.SSRS.Services.ListModelDrillthroughReportsRequest inValue = new Cake.SSRS.Services.ListModelDrillthroughReportsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.ModelItemID = ModelItemID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListModelDrillthroughReportsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelItemChildrenResponse> Cake.SSRS.Services.ReportingService2010Soap.ListModelItemChildrenAsync(Cake.SSRS.Services.ListModelItemChildrenRequest request)
        {
            return base.Channel.ListModelItemChildrenAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelItemChildrenResponse> ListModelItemChildrenAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, bool Recursive)
        {
            Cake.SSRS.Services.ListModelItemChildrenRequest inValue = new Cake.SSRS.Services.ListModelItemChildrenRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            inValue.ModelItemID = ModelItemID;
            inValue.Recursive = Recursive;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListModelItemChildrenAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelItemTypesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListModelItemTypesAsync(Cake.SSRS.Services.ListModelItemTypesRequest request)
        {
            return base.Channel.ListModelItemTypesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelItemTypesResponse> ListModelItemTypesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListModelItemTypesRequest inValue = new Cake.SSRS.Services.ListModelItemTypesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListModelItemTypesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelPerspectivesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListModelPerspectivesAsync(Cake.SSRS.Services.ListModelPerspectivesRequest request)
        {
            return base.Channel.ListModelPerspectivesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListModelPerspectivesResponse> ListModelPerspectivesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model)
        {
            Cake.SSRS.Services.ListModelPerspectivesRequest inValue = new Cake.SSRS.Services.ListModelPerspectivesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListModelPerspectivesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.RegenerateModelResponse> Cake.SSRS.Services.ReportingService2010Soap.RegenerateModelAsync(Cake.SSRS.Services.RegenerateModelRequest request)
        {
            return base.Channel.RegenerateModelAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.RegenerateModelResponse> RegenerateModelAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model)
        {
            Cake.SSRS.Services.RegenerateModelRequest inValue = new Cake.SSRS.Services.RegenerateModelRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).RegenerateModelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.RemoveAllModelItemPoliciesResponse> Cake.SSRS.Services.ReportingService2010Soap.RemoveAllModelItemPoliciesAsync(Cake.SSRS.Services.RemoveAllModelItemPoliciesRequest request)
        {
            return base.Channel.RemoveAllModelItemPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.RemoveAllModelItemPoliciesResponse> RemoveAllModelItemPoliciesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Model)
        {
            Cake.SSRS.Services.RemoveAllModelItemPoliciesRequest inValue = new Cake.SSRS.Services.RemoveAllModelItemPoliciesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Model = Model;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).RemoveAllModelItemPoliciesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateScheduleResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateScheduleAsync(Cake.SSRS.Services.CreateScheduleRequest request)
        {
            return base.Channel.CreateScheduleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateScheduleResponse> CreateScheduleAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, Cake.SSRS.Services.ScheduleDefinition ScheduleDefinition, string SiteUrl)
        {
            Cake.SSRS.Services.CreateScheduleRequest inValue = new Cake.SSRS.Services.CreateScheduleRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Name = Name;
            inValue.ScheduleDefinition = ScheduleDefinition;
            inValue.SiteUrl = SiteUrl;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateScheduleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteScheduleResponse> Cake.SSRS.Services.ReportingService2010Soap.DeleteScheduleAsync(Cake.SSRS.Services.DeleteScheduleRequest request)
        {
            return base.Channel.DeleteScheduleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteScheduleResponse> DeleteScheduleAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            Cake.SSRS.Services.DeleteScheduleRequest inValue = new Cake.SSRS.Services.DeleteScheduleRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ScheduleID = ScheduleID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DeleteScheduleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSchedulesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListSchedulesAsync(Cake.SSRS.Services.ListSchedulesRequest request)
        {
            return base.Channel.ListSchedulesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListSchedulesResponse> ListSchedulesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string SiteUrl)
        {
            Cake.SSRS.Services.ListSchedulesRequest inValue = new Cake.SSRS.Services.ListSchedulesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.SiteUrl = SiteUrl;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListSchedulesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSchedulePropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.GetSchedulePropertiesAsync(Cake.SSRS.Services.GetSchedulePropertiesRequest request)
        {
            return base.Channel.GetSchedulePropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetSchedulePropertiesResponse> GetSchedulePropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            Cake.SSRS.Services.GetSchedulePropertiesRequest inValue = new Cake.SSRS.Services.GetSchedulePropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ScheduleID = ScheduleID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetSchedulePropertiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListScheduleStatesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListScheduleStatesAsync(Cake.SSRS.Services.ListScheduleStatesRequest request)
        {
            return base.Channel.ListScheduleStatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListScheduleStatesResponse> ListScheduleStatesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListScheduleStatesRequest inValue = new Cake.SSRS.Services.ListScheduleStatesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListScheduleStatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.PauseScheduleResponse> Cake.SSRS.Services.ReportingService2010Soap.PauseScheduleAsync(Cake.SSRS.Services.PauseScheduleRequest request)
        {
            return base.Channel.PauseScheduleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.PauseScheduleResponse> PauseScheduleAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            Cake.SSRS.Services.PauseScheduleRequest inValue = new Cake.SSRS.Services.PauseScheduleRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ScheduleID = ScheduleID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).PauseScheduleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ResumeScheduleResponse> Cake.SSRS.Services.ReportingService2010Soap.ResumeScheduleAsync(Cake.SSRS.Services.ResumeScheduleRequest request)
        {
            return base.Channel.ResumeScheduleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ResumeScheduleResponse> ResumeScheduleAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            Cake.SSRS.Services.ResumeScheduleRequest inValue = new Cake.SSRS.Services.ResumeScheduleRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ScheduleID = ScheduleID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ResumeScheduleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSchedulePropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetSchedulePropertiesAsync(Cake.SSRS.Services.SetSchedulePropertiesRequest request)
        {
            return base.Channel.SetSchedulePropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetSchedulePropertiesResponse> SetSchedulePropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string Name, string ScheduleID, Cake.SSRS.Services.ScheduleDefinition ScheduleDefinition)
        {
            Cake.SSRS.Services.SetSchedulePropertiesRequest inValue = new Cake.SSRS.Services.SetSchedulePropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Name = Name;
            inValue.ScheduleID = ScheduleID;
            inValue.ScheduleDefinition = ScheduleDefinition;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetSchedulePropertiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListScheduledItemsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListScheduledItemsAsync(Cake.SSRS.Services.ListScheduledItemsRequest request)
        {
            return base.Channel.ListScheduledItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListScheduledItemsResponse> ListScheduledItemsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ScheduleID)
        {
            Cake.SSRS.Services.ListScheduledItemsRequest inValue = new Cake.SSRS.Services.ListScheduledItemsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ScheduleID = ScheduleID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListScheduledItemsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemParametersResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemParametersAsync(Cake.SSRS.Services.SetItemParametersRequest request)
        {
            return base.Channel.SetItemParametersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemParametersResponse> SetItemParametersAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, Cake.SSRS.Services.ItemParameter[] Parameters)
        {
            Cake.SSRS.Services.SetItemParametersRequest inValue = new Cake.SSRS.Services.SetItemParametersRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemParametersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemParametersResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemParametersAsync(Cake.SSRS.Services.GetItemParametersRequest request)
        {
            return base.Channel.GetItemParametersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemParametersResponse> GetItemParametersAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID, bool ForRendering, Cake.SSRS.Services.ParameterValue[] Values, Cake.SSRS.Services.DataSourceCredentials[] Credentials)
        {
            Cake.SSRS.Services.GetItemParametersRequest inValue = new Cake.SSRS.Services.GetItemParametersRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.HistoryID = HistoryID;
            inValue.ForRendering = ForRendering;
            inValue.Values = Values;
            inValue.Credentials = Credentials;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemParametersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListParameterTypesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListParameterTypesAsync(Cake.SSRS.Services.ListParameterTypesRequest request)
        {
            return base.Channel.ListParameterTypesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListParameterTypesResponse> ListParameterTypesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListParameterTypesRequest inValue = new Cake.SSRS.Services.ListParameterTypesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListParameterTypesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListParameterStatesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListParameterStatesAsync(Cake.SSRS.Services.ListParameterStatesRequest request)
        {
            return base.Channel.ListParameterStatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListParameterStatesResponse> ListParameterStatesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListParameterStatesRequest inValue = new Cake.SSRS.Services.ListParameterStatesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListParameterStatesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateReportEditSessionResponse> CreateReportEditSessionAsync(Cake.SSRS.Services.CreateReportEditSessionRequest request)
        {
            return base.Channel.CreateReportEditSessionAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateLinkedItemResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateLinkedItemAsync(Cake.SSRS.Services.CreateLinkedItemRequest request)
        {
            return base.Channel.CreateLinkedItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateLinkedItemResponse> CreateLinkedItemAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Parent, string Link, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.CreateLinkedItemRequest inValue = new Cake.SSRS.Services.CreateLinkedItemRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Parent = Parent;
            inValue.Link = Link;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateLinkedItemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemLinkResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemLinkAsync(Cake.SSRS.Services.SetItemLinkRequest request)
        {
            return base.Channel.SetItemLinkAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemLinkResponse> SetItemLinkAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Link)
        {
            Cake.SSRS.Services.SetItemLinkRequest inValue = new Cake.SSRS.Services.SetItemLinkRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Link = Link;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemLinkAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemLinkResponse> Cake.SSRS.Services.ReportingService2010Soap.GetItemLinkAsync(Cake.SSRS.Services.GetItemLinkRequest request)
        {
            return base.Channel.GetItemLinkAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemLinkResponse> GetItemLinkAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.GetItemLinkRequest inValue = new Cake.SSRS.Services.GetItemLinkRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetItemLinkAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListExecutionSettingsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListExecutionSettingsAsync(Cake.SSRS.Services.ListExecutionSettingsRequest request)
        {
            return base.Channel.ListExecutionSettingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListExecutionSettingsResponse> ListExecutionSettingsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListExecutionSettingsRequest inValue = new Cake.SSRS.Services.ListExecutionSettingsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListExecutionSettingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetExecutionOptionsResponse> Cake.SSRS.Services.ReportingService2010Soap.SetExecutionOptionsAsync(Cake.SSRS.Services.SetExecutionOptionsRequest request)
        {
            return base.Channel.SetExecutionOptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetExecutionOptionsResponse> SetExecutionOptionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string ExecutionSetting, Cake.SSRS.Services.ScheduleDefinitionOrReference Item)
        {
            Cake.SSRS.Services.SetExecutionOptionsRequest inValue = new Cake.SSRS.Services.SetExecutionOptionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.ExecutionSetting = ExecutionSetting;
            inValue.Item = Item;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetExecutionOptionsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetExecutionOptionsResponse> GetExecutionOptionsAsync(Cake.SSRS.Services.GetExecutionOptionsRequest request)
        {
            return base.Channel.GetExecutionOptionsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.UpdateItemExecutionSnapshotResponse> Cake.SSRS.Services.ReportingService2010Soap.UpdateItemExecutionSnapshotAsync(Cake.SSRS.Services.UpdateItemExecutionSnapshotRequest request)
        {
            return base.Channel.UpdateItemExecutionSnapshotAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.UpdateItemExecutionSnapshotResponse> UpdateItemExecutionSnapshotAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.UpdateItemExecutionSnapshotRequest inValue = new Cake.SSRS.Services.UpdateItemExecutionSnapshotRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).UpdateItemExecutionSnapshotAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetCacheOptionsResponse> Cake.SSRS.Services.ReportingService2010Soap.SetCacheOptionsAsync(Cake.SSRS.Services.SetCacheOptionsRequest request)
        {
            return base.Channel.SetCacheOptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetCacheOptionsResponse> SetCacheOptionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool CacheItem, Cake.SSRS.Services.ExpirationDefinition Item)
        {
            Cake.SSRS.Services.SetCacheOptionsRequest inValue = new Cake.SSRS.Services.SetCacheOptionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.CacheItem = CacheItem;
            inValue.Item = Item;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetCacheOptionsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetCacheOptionsResponse> GetCacheOptionsAsync(Cake.SSRS.Services.GetCacheOptionsRequest request)
        {
            return base.Channel.GetCacheOptionsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.FlushCacheResponse> Cake.SSRS.Services.ReportingService2010Soap.FlushCacheAsync(Cake.SSRS.Services.FlushCacheRequest request)
        {
            return base.Channel.FlushCacheAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.FlushCacheResponse> FlushCacheAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.FlushCacheRequest inValue = new Cake.SSRS.Services.FlushCacheRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).FlushCacheAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateItemHistorySnapshotResponse> CreateItemHistorySnapshotAsync(Cake.SSRS.Services.CreateItemHistorySnapshotRequest request)
        {
            return base.Channel.CreateItemHistorySnapshotAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteItemHistorySnapshotResponse> Cake.SSRS.Services.ReportingService2010Soap.DeleteItemHistorySnapshotAsync(Cake.SSRS.Services.DeleteItemHistorySnapshotRequest request)
        {
            return base.Channel.DeleteItemHistorySnapshotAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteItemHistorySnapshotResponse> DeleteItemHistorySnapshotAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string HistoryID)
        {
            Cake.SSRS.Services.DeleteItemHistorySnapshotRequest inValue = new Cake.SSRS.Services.DeleteItemHistorySnapshotRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.HistoryID = HistoryID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DeleteItemHistorySnapshotAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemHistoryLimitResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemHistoryLimitAsync(Cake.SSRS.Services.SetItemHistoryLimitRequest request)
        {
            return base.Channel.SetItemHistoryLimitAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemHistoryLimitResponse> SetItemHistoryLimitAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool UseSystem, int HistoryLimit)
        {
            Cake.SSRS.Services.SetItemHistoryLimitRequest inValue = new Cake.SSRS.Services.SetItemHistoryLimitRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.UseSystem = UseSystem;
            inValue.HistoryLimit = HistoryLimit;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemHistoryLimitAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemHistoryLimitResponse> GetItemHistoryLimitAsync(Cake.SSRS.Services.GetItemHistoryLimitRequest request)
        {
            return base.Channel.GetItemHistoryLimitAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemHistoryOptionsResponse> Cake.SSRS.Services.ReportingService2010Soap.SetItemHistoryOptionsAsync(Cake.SSRS.Services.SetItemHistoryOptionsRequest request)
        {
            return base.Channel.SetItemHistoryOptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetItemHistoryOptionsResponse> SetItemHistoryOptionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, Cake.SSRS.Services.ScheduleDefinitionOrReference Item)
        {
            Cake.SSRS.Services.SetItemHistoryOptionsRequest inValue = new Cake.SSRS.Services.SetItemHistoryOptionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.EnableManualSnapshotCreation = EnableManualSnapshotCreation;
            inValue.KeepExecutionSnapshots = KeepExecutionSnapshots;
            inValue.Item = Item;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetItemHistoryOptionsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetItemHistoryOptionsResponse> GetItemHistoryOptionsAsync(Cake.SSRS.Services.GetItemHistoryOptionsRequest request)
        {
            return base.Channel.GetItemHistoryOptionsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetReportServerConfigInfoResponse> Cake.SSRS.Services.ReportingService2010Soap.GetReportServerConfigInfoAsync(Cake.SSRS.Services.GetReportServerConfigInfoRequest request)
        {
            return base.Channel.GetReportServerConfigInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetReportServerConfigInfoResponse> GetReportServerConfigInfoAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, bool ScaleOut)
        {
            Cake.SSRS.Services.GetReportServerConfigInfoRequest inValue = new Cake.SSRS.Services.GetReportServerConfigInfoRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ScaleOut = ScaleOut;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetReportServerConfigInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.IsSSLRequiredResponse> Cake.SSRS.Services.ReportingService2010Soap.IsSSLRequiredAsync(Cake.SSRS.Services.IsSSLRequiredRequest request)
        {
            return base.Channel.IsSSLRequiredAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.IsSSLRequiredResponse> IsSSLRequiredAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.IsSSLRequiredRequest inValue = new Cake.SSRS.Services.IsSSLRequiredRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).IsSSLRequiredAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSystemPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetSystemPropertiesAsync(Cake.SSRS.Services.SetSystemPropertiesRequest request)
        {
            return base.Channel.SetSystemPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetSystemPropertiesResponse> SetSystemPropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.SetSystemPropertiesRequest inValue = new Cake.SSRS.Services.SetSystemPropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetSystemPropertiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.GetSystemPropertiesAsync(Cake.SSRS.Services.GetSystemPropertiesRequest request)
        {
            return base.Channel.GetSystemPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPropertiesResponse> GetSystemPropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.GetSystemPropertiesRequest inValue = new Cake.SSRS.Services.GetSystemPropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetSystemPropertiesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetUserSettingsResponse> Cake.SSRS.Services.ReportingService2010Soap.SetUserSettingsAsync(Cake.SSRS.Services.SetUserSettingsRequest request)
        {
            return base.Channel.SetUserSettingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetUserSettingsResponse> SetUserSettingsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.SetUserSettingsRequest inValue = new Cake.SSRS.Services.SetUserSettingsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetUserSettingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetUserSettingsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetUserSettingsAsync(Cake.SSRS.Services.GetUserSettingsRequest request)
        {
            return base.Channel.GetUserSettingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetUserSettingsResponse> GetUserSettingsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Property[] Properties)
        {
            Cake.SSRS.Services.GetUserSettingsRequest inValue = new Cake.SSRS.Services.GetUserSettingsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Properties = Properties;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetUserSettingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetSystemPoliciesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetSystemPoliciesAsync(Cake.SSRS.Services.SetSystemPoliciesRequest request)
        {
            return base.Channel.SetSystemPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetSystemPoliciesResponse> SetSystemPoliciesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, Cake.SSRS.Services.Policy[] Policies)
        {
            Cake.SSRS.Services.SetSystemPoliciesRequest inValue = new Cake.SSRS.Services.SetSystemPoliciesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.Policies = Policies;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetSystemPoliciesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPoliciesResponse> Cake.SSRS.Services.ReportingService2010Soap.GetSystemPoliciesAsync(Cake.SSRS.Services.GetSystemPoliciesRequest request)
        {
            return base.Channel.GetSystemPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPoliciesResponse> GetSystemPoliciesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.GetSystemPoliciesRequest inValue = new Cake.SSRS.Services.GetSystemPoliciesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetSystemPoliciesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListExtensionsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListExtensionsAsync(Cake.SSRS.Services.ListExtensionsRequest request)
        {
            return base.Channel.ListExtensionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListExtensionsResponse> ListExtensionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ExtensionType)
        {
            Cake.SSRS.Services.ListExtensionsRequest inValue = new Cake.SSRS.Services.ListExtensionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ExtensionType = ExtensionType;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListExtensionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListExtensionTypesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListExtensionTypesAsync(Cake.SSRS.Services.ListExtensionTypesRequest request)
        {
            return base.Channel.ListExtensionTypesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListExtensionTypesResponse> ListExtensionTypesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListExtensionTypesRequest inValue = new Cake.SSRS.Services.ListExtensionTypesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListExtensionTypesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListEventsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListEventsAsync(Cake.SSRS.Services.ListEventsRequest request)
        {
            return base.Channel.ListEventsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListEventsResponse> ListEventsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListEventsRequest inValue = new Cake.SSRS.Services.ListEventsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListEventsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.FireEventResponse> Cake.SSRS.Services.ReportingService2010Soap.FireEventAsync(Cake.SSRS.Services.FireEventRequest request)
        {
            return base.Channel.FireEventAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.FireEventResponse> FireEventAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string EventType, string EventData, string SiteUrl)
        {
            Cake.SSRS.Services.FireEventRequest inValue = new Cake.SSRS.Services.FireEventRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.EventType = EventType;
            inValue.EventData = EventData;
            inValue.SiteUrl = SiteUrl;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).FireEventAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListJobsAsync(Cake.SSRS.Services.ListJobsRequest request)
        {
            return base.Channel.ListJobsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobsResponse> ListJobsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListJobsRequest inValue = new Cake.SSRS.Services.ListJobsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListJobsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobTypesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListJobTypesAsync(Cake.SSRS.Services.ListJobTypesRequest request)
        {
            return base.Channel.ListJobTypesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobTypesResponse> ListJobTypesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListJobTypesRequest inValue = new Cake.SSRS.Services.ListJobTypesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListJobTypesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobActionsResponse> Cake.SSRS.Services.ReportingService2010Soap.ListJobActionsAsync(Cake.SSRS.Services.ListJobActionsRequest request)
        {
            return base.Channel.ListJobActionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobActionsResponse> ListJobActionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListJobActionsRequest inValue = new Cake.SSRS.Services.ListJobActionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListJobActionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobStatesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListJobStatesAsync(Cake.SSRS.Services.ListJobStatesRequest request)
        {
            return base.Channel.ListJobStatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListJobStatesResponse> ListJobStatesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListJobStatesRequest inValue = new Cake.SSRS.Services.ListJobStatesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListJobStatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CancelJobResponse> Cake.SSRS.Services.ReportingService2010Soap.CancelJobAsync(Cake.SSRS.Services.CancelJobRequest request)
        {
            return base.Channel.CancelJobAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CancelJobResponse> CancelJobAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string JobID)
        {
            Cake.SSRS.Services.CancelJobRequest inValue = new Cake.SSRS.Services.CancelJobRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.JobID = JobID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CancelJobAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.CreateCacheRefreshPlanResponse> Cake.SSRS.Services.ReportingService2010Soap.CreateCacheRefreshPlanAsync(Cake.SSRS.Services.CreateCacheRefreshPlanRequest request)
        {
            return base.Channel.CreateCacheRefreshPlanAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.CreateCacheRefreshPlanResponse> CreateCacheRefreshPlanAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            Cake.SSRS.Services.CreateCacheRefreshPlanRequest inValue = new Cake.SSRS.Services.CreateCacheRefreshPlanRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            inValue.Description = Description;
            inValue.EventType = EventType;
            inValue.MatchData = MatchData;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).CreateCacheRefreshPlanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.SetCacheRefreshPlanPropertiesResponse> Cake.SSRS.Services.ReportingService2010Soap.SetCacheRefreshPlanPropertiesAsync(Cake.SSRS.Services.SetCacheRefreshPlanPropertiesRequest request)
        {
            return base.Channel.SetCacheRefreshPlanPropertiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.SetCacheRefreshPlanPropertiesResponse> SetCacheRefreshPlanPropertiesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID, string Description, string EventType, string MatchData, Cake.SSRS.Services.ParameterValue[] Parameters)
        {
            Cake.SSRS.Services.SetCacheRefreshPlanPropertiesRequest inValue = new Cake.SSRS.Services.SetCacheRefreshPlanPropertiesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.CacheRefreshPlanID = CacheRefreshPlanID;
            inValue.Description = Description;
            inValue.EventType = EventType;
            inValue.MatchData = MatchData;
            inValue.Parameters = Parameters;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).SetCacheRefreshPlanPropertiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetCacheRefreshPlanPropertiesResponse> GetCacheRefreshPlanPropertiesAsync(Cake.SSRS.Services.GetCacheRefreshPlanPropertiesRequest request)
        {
            return base.Channel.GetCacheRefreshPlanPropertiesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteCacheRefreshPlanResponse> Cake.SSRS.Services.ReportingService2010Soap.DeleteCacheRefreshPlanAsync(Cake.SSRS.Services.DeleteCacheRefreshPlanRequest request)
        {
            return base.Channel.DeleteCacheRefreshPlanAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.DeleteCacheRefreshPlanResponse> DeleteCacheRefreshPlanAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID)
        {
            Cake.SSRS.Services.DeleteCacheRefreshPlanRequest inValue = new Cake.SSRS.Services.DeleteCacheRefreshPlanRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.CacheRefreshPlanID = CacheRefreshPlanID;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).DeleteCacheRefreshPlanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListCacheRefreshPlansResponse> Cake.SSRS.Services.ReportingService2010Soap.ListCacheRefreshPlansAsync(Cake.SSRS.Services.ListCacheRefreshPlansRequest request)
        {
            return base.Channel.ListCacheRefreshPlansAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListCacheRefreshPlansResponse> ListCacheRefreshPlansAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.ListCacheRefreshPlansRequest inValue = new Cake.SSRS.Services.ListCacheRefreshPlansRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListCacheRefreshPlansAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.LogonUserResponse> Cake.SSRS.Services.ReportingService2010Soap.LogonUserAsync(Cake.SSRS.Services.LogonUserRequest request)
        {
            return base.Channel.LogonUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.LogonUserResponse> LogonUserAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string userName, string password, string authority)
        {
            Cake.SSRS.Services.LogonUserRequest inValue = new Cake.SSRS.Services.LogonUserRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.userName = userName;
            inValue.password = password;
            inValue.authority = authority;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).LogonUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.LogoffResponse> Cake.SSRS.Services.ReportingService2010Soap.LogoffAsync(Cake.SSRS.Services.LogoffRequest request)
        {
            return base.Channel.LogoffAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.LogoffResponse> LogoffAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.LogoffRequest inValue = new Cake.SSRS.Services.LogoffRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).LogoffAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetPermissionsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetPermissionsAsync(Cake.SSRS.Services.GetPermissionsRequest request)
        {
            return base.Channel.GetPermissionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetPermissionsResponse> GetPermissionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader, string ItemPath)
        {
            Cake.SSRS.Services.GetPermissionsRequest inValue = new Cake.SSRS.Services.GetPermissionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            inValue.ItemPath = ItemPath;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetPermissionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPermissionsResponse> Cake.SSRS.Services.ReportingService2010Soap.GetSystemPermissionsAsync(Cake.SSRS.Services.GetSystemPermissionsRequest request)
        {
            return base.Channel.GetSystemPermissionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.GetSystemPermissionsResponse> GetSystemPermissionsAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.GetSystemPermissionsRequest inValue = new Cake.SSRS.Services.GetSystemPermissionsRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).GetSystemPermissionsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cake.SSRS.Services.ListSecurityScopesResponse> Cake.SSRS.Services.ReportingService2010Soap.ListSecurityScopesAsync(Cake.SSRS.Services.ListSecurityScopesRequest request)
        {
            return base.Channel.ListSecurityScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cake.SSRS.Services.ListSecurityScopesResponse> ListSecurityScopesAsync(Cake.SSRS.Services.TrustedUserHeader TrustedUserHeader)
        {
            Cake.SSRS.Services.ListSecurityScopesRequest inValue = new Cake.SSRS.Services.ListSecurityScopesRequest();
            inValue.TrustedUserHeader = TrustedUserHeader;
            return ((Cake.SSRS.Services.ReportingService2010Soap)(this)).ListSecurityScopesAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ReportingService2010Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ReportingService2010Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ReportingService2010Soap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/ReportServer/ReportService2010.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ReportingService2010Soap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/ReportServer/ReportService2010.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ReportingService2010Soap,
            
            ReportingService2010Soap12,
        }
    }
}
