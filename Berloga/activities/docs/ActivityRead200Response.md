# Org.OpenAPITools.Model.ActivityRead200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Идентификатор активности. | 
**CreatedAt** | **DateTime** | Дата записи активности. | 
**ContextId** | **Guid** | Идентификатор контекста активности. | 
**PlayerId** | **Guid** | Идентификатор игрока. | 
**AppVersion** | **string** | Версия приложения, в которой была произведена активность. | 
**Scores** | **decimal** | Балл эффективности активности. | 
**ArtefactId** | **Guid** |  | 
**Quarantine** | **string** |  | 
**ApplicationId** | **Guid** | Идентификатор приложения. | 
**TraditionId** | **int** | ID традиции. | 
**ContextProperties** | [**Dictionary&lt;string, ActivityRead200ResponseAllOfContextPropertiesValue&gt;**](ActivityRead200ResponseAllOfContextPropertiesValue.md) | Свойства контекста активности. | 
**Metrics** | **Dictionary&lt;string, decimal&gt;** | Метрики активности. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

