# Org.OpenAPITools.Api.ServiceApi

All URIs are relative to *https://talent.kruzhok.org/berloga-activities*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivitiesMetricsList**](ServiceApi.md#activitiesmetricslist) | **GET** /activities/metrics | Список активностей с метриками |
| [**ActivitiesScores**](ServiceApi.md#activitiesscores) | **GET** /activities/scores | Балл за активности |
| [**ActivitiesScoresByTraditions**](ServiceApi.md#activitiesscoresbytraditions) | **GET** /activities/scores/traditions | Баллы сгруппированные по традициям |
| [**ActivityRead**](ServiceApi.md#activityread) | **GET** /activities/{activity_id} | Чтение активности |
| [**ContextTraditionID**](ServiceApi.md#contexttraditionid) | **GET** /contexts/{context_id}/tradition-id | Традиция контекста |

<a id="activitiesmetricslist"></a>
# **ActivitiesMetricsList**
> List&lt;ActivitiesMetricsList200ResponseInner&gt; ActivitiesMetricsList (int? offset = null, int? limit = null, Guid? applicationId = null, List<string>? contextProperty = null, List<Guid>? contextIds = null, DateTime? since = null, DateTime? until = null, List<Guid>? playerIds = null)

Список активностей с метриками

Обязательно указание либо идентификаторов контекстов `context_ids`, либо идентификатора приложения и свойств контекстов `context_property`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitiesMetricsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: ServiceKey
            config.AddApiKey("X-Service-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Service-Key", "Bearer");

            var apiInstance = new ServiceApi(config);
            var offset = 0;  // int? |  (optional)  (default to 0)
            var limit = 100;  // int? |  (optional)  (default to 100)
            var applicationId = "applicationId_example";  // Guid? | ID приложения. Необходимо указывать при использовании фильтра `context_property`. (optional) 
            var contextProperty = new List<string>?(); // List<string>? | Свойства контекстов приложения. Заполняются в формате имени и значения объединенных пробелом (кодируется как `+` или `%20`). На каждое свойство допускается указывать до 5 значений. Множественные значения учитываются как `допустим любой из вариантов`, или же еще можно сказать что они объединяются логическим ИЛИ. В запросе можноственные значения нужно разделять вертикальной чертой. Пример фильтра по свойству `instrument` с тремя допустимыми значениями: `instrument+piano|guitar|drums`. (optional) 
            var contextIds = new List<Guid>?(); // List<Guid>? | Список идентификаторов контекстов. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var until = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var playerIds = new List<Guid>?(); // List<Guid>? | Список игроков, активности которых попадут в выборку. (optional) 

            try
            {
                // Список активностей с метриками
                List<ActivitiesMetricsList200ResponseInner> result = apiInstance.ActivitiesMetricsList(offset, limit, applicationId, contextProperty, contextIds, since, until, playerIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.ActivitiesMetricsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesMetricsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список активностей с метриками
    ApiResponse<List<ActivitiesMetricsList200ResponseInner>> response = apiInstance.ActivitiesMetricsListWithHttpInfo(offset, limit, applicationId, contextProperty, contextIds, since, until, playerIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.ActivitiesMetricsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional] [default to 0] |
| **limit** | **int?** |  | [optional] [default to 100] |
| **applicationId** | **Guid?** | ID приложения. Необходимо указывать при использовании фильтра &#x60;context_property&#x60;. | [optional]  |
| **contextProperty** | [**List&lt;string&gt;?**](string.md) | Свойства контекстов приложения. Заполняются в формате имени и значения объединенных пробелом (кодируется как &#x60;+&#x60; или &#x60;%20&#x60;). На каждое свойство допускается указывать до 5 значений. Множественные значения учитываются как &#x60;допустим любой из вариантов&#x60;, или же еще можно сказать что они объединяются логическим ИЛИ. В запросе можноственные значения нужно разделять вертикальной чертой. Пример фильтра по свойству &#x60;instrument&#x60; с тремя допустимыми значениями: &#x60;instrument+piano|guitar|drums&#x60;. | [optional]  |
| **contextIds** | [**List&lt;Guid&gt;?**](Guid.md) | Список идентификаторов контекстов. | [optional]  |
| **since** | **DateTime?** |  | [optional]  |
| **until** | **DateTime?** |  | [optional]  |
| **playerIds** | [**List&lt;Guid&gt;?**](Guid.md) | Список игроков, активности которых попадут в выборку. | [optional]  |

### Return type

[**List&lt;ActivitiesMetricsList200ResponseInner&gt;**](ActivitiesMetricsList200ResponseInner.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [ServiceKey](../README.md#ServiceKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |
| **403** | Ошибка доступа |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activitiesscores"></a>
# **ActivitiesScores**
> decimal ActivitiesScores (int? traditionId = null, List<Guid>? contextIds = null, List<Guid>? playerIds = null)

Балл за активности

**Обязательно** указание либо `tradition_id`, либо `context_ids`; эти параметры взаимоисключающие.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitiesScoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: ServiceKey
            config.AddApiKey("X-Service-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Service-Key", "Bearer");

            var apiInstance = new ServiceApi(config);
            var traditionId = 56;  // int? | Идентификатор традиции (optional) 
            var contextIds = new List<Guid>?(); // List<Guid>? | Список идентификаторов контекстов (optional) 
            var playerIds = new List<Guid>?(); // List<Guid>? | Список игроков, активности которых попадут в выборку. Параметр доступен только при использовании авторизации `ServiceKey`. (optional) 

            try
            {
                // Балл за активности
                decimal result = apiInstance.ActivitiesScores(traditionId, contextIds, playerIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.ActivitiesScores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesScoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Балл за активности
    ApiResponse<decimal> response = apiInstance.ActivitiesScoresWithHttpInfo(traditionId, contextIds, playerIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.ActivitiesScoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **traditionId** | **int?** | Идентификатор традиции | [optional]  |
| **contextIds** | [**List&lt;Guid&gt;?**](Guid.md) | Список идентификаторов контекстов | [optional]  |
| **playerIds** | [**List&lt;Guid&gt;?**](Guid.md) | Список игроков, активности которых попадут в выборку. Параметр доступен только при использовании авторизации &#x60;ServiceKey&#x60;. | [optional]  |

### Return type

**decimal**

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT), [ServiceKey](../README.md#ServiceKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Ошибка доступа |  -  |
| **422** | Ошибка в параметрах запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activitiesscoresbytraditions"></a>
# **ActivitiesScoresByTraditions**
> List&lt;ActivitiesScoresByTraditions200ResponseInner&gt; ActivitiesScoresByTraditions (int talentId)

Баллы сгруппированные по традициям

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitiesScoresByTraditionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: ServiceKey
            config.AddApiKey("X-Service-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Service-Key", "Bearer");

            var apiInstance = new ServiceApi(config);
            var talentId = 56;  // int | Получение баллов по всем PlayerID пользователя

            try
            {
                // Баллы сгруппированные по традициям
                List<ActivitiesScoresByTraditions200ResponseInner> result = apiInstance.ActivitiesScoresByTraditions(talentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.ActivitiesScoresByTraditions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesScoresByTraditionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Баллы сгруппированные по традициям
    ApiResponse<List<ActivitiesScoresByTraditions200ResponseInner>> response = apiInstance.ActivitiesScoresByTraditionsWithHttpInfo(talentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.ActivitiesScoresByTraditionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **talentId** | **int** | Получение баллов по всем PlayerID пользователя |  |

### Return type

[**List&lt;ActivitiesScoresByTraditions200ResponseInner&gt;**](ActivitiesScoresByTraditions200ResponseInner.md)

### Authorization

[ServiceKey](../README.md#ServiceKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Ошибка доступа |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activityread"></a>
# **ActivityRead**
> ActivityRead200Response ActivityRead (Guid activityId)

Чтение активности

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            var apiInstance = new ServiceApi(config);
            var activityId = "activityId_example";  // Guid | 

            try
            {
                // Чтение активности
                ActivityRead200Response result = apiInstance.ActivityRead(activityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.ActivityRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivityReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Чтение активности
    ApiResponse<ActivityRead200Response> response = apiInstance.ActivityReadWithHttpInfo(activityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.ActivityReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activityId** | **Guid** |  |  |

### Return type

[**ActivityRead200Response**](ActivityRead200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Активность не найдена |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contexttraditionid"></a>
# **ContextTraditionID**
> int ContextTraditionID (Guid contextId)

Традиция контекста

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContextTraditionIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            var apiInstance = new ServiceApi(config);
            var contextId = "contextId_example";  // Guid | 

            try
            {
                // Традиция контекста
                int result = apiInstance.ContextTraditionID(contextId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.ContextTraditionID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContextTraditionIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Традиция контекста
    ApiResponse<int> response = apiInstance.ContextTraditionIDWithHttpInfo(contextId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.ContextTraditionIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contextId** | **Guid** |  |  |

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Контекст не найден |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

