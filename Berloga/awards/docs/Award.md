# Org.OpenAPITools.Model.Award
Награда, выдаваемая за получение уровня по традиции или инструменту.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Идентификатор награды. | 
**CreatedAt** | **DateTime** | Дата создания | 
**UpdatedAt** | **DateTime** | Дата обновления | 
**TraditionId** | **int** | ID традиции. | 
**InstrumentId** | **int** | ID инструмента. | 
**AwardLevel** | **int** | Уровень традиции/инструмента ассоциированный с этой наградой. | 
**DependencyLevel** | **int** | Опциональный уровень зависимой традиции/инструмента, без которого нельзя получить награду. При отсутствии зависимости, содержит &#x60;0&#x60;. | 
**RequiredScores** | **decimal** | Кол-во баллов необходимое для достижения &#x60;award_level&#x60; и получения этой награды. | 
**Name** | **string** | Название награды. | 
**Description** | **string** | Описание награды. | 
**IconUrl** | **string** | URL иконки награды. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

