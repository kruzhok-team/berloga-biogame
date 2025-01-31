# Org.OpenAPITools.Api.ApplicationApi

All URIs are relative to *https://talent.kruzhok.org/berloga-awards*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AwardsList**](ApplicationApi.md#awardslist) | **GET** /awards | Список наград |
| [**ChallengesList**](ApplicationApi.md#challengeslist) | **GET** /challenges | Список испытаний |
| [**InstrumentsList**](ApplicationApi.md#instrumentslist) | **GET** /instruments | Список инструментов |
| [**PassedChallengesList**](ApplicationApi.md#passedchallengeslist) | **GET** /challenges/passed | Список пройденных испытаний |
| [**TraditionInstrumentsList**](ApplicationApi.md#traditioninstrumentslist) | **GET** /traditions/{tradition_id}/instruments | Список инструментов традиции |
| [**TraditionsList**](ApplicationApi.md#traditionslist) | **GET** /traditions | Список традиций |
| [**UserAwardDisplayed**](ApplicationApi.md#userawarddisplayed) | **POST** /user-awards/{award_id}/displayed | Отметка награды продемонстрированной |
| [**UserAwardsList**](ApplicationApi.md#userawardslist) | **GET** /user-awards | Список наград пользователя |
| [**UserProgressList**](ApplicationApi.md#userprogresslist) | **GET** /user-progress | Прогресс пользователя |

<a id="awardslist"></a>
# **AwardsList**
> List&lt;AwardsList200ResponseInner&gt; AwardsList (int? offset = null, int? limit = null, int? traditionId = null, int? instrumentId = null, string? orderBy = null, bool? withApplications = null)

Список наград

Список наград, выдаваемых за достижение уровеней по традициям и инструментам.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AwardsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new ApplicationApi(config);
            var offset = 0;  // int? | Кол-во объектов выборки для пропуска. (optional)  (default to 0)
            var limit = 20;  // int? | Максимум объектов возвращаемых в теле ответа. (optional)  (default to 20)
            var traditionId = 56;  // int? | Фильтрация по ID традиции. (optional) 
            var instrumentId = 56;  // int? | Фильтрация по ID инструмента. (optional) 
            var orderBy = "award_level";  // string? | Порядок сортировки (optional)  (default to award_level)
            var withApplications = false;  // bool? | Включить в ответ свойство `applications`. (optional)  (default to false)

            try
            {
                // Список наград
                List<AwardsList200ResponseInner> result = apiInstance.AwardsList(offset, limit, traditionId, instrumentId, orderBy, withApplications);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.AwardsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AwardsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список наград
    ApiResponse<List<AwardsList200ResponseInner>> response = apiInstance.AwardsListWithHttpInfo(offset, limit, traditionId, instrumentId, orderBy, withApplications);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.AwardsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Кол-во объектов выборки для пропуска. | [optional] [default to 0] |
| **limit** | **int?** | Максимум объектов возвращаемых в теле ответа. | [optional] [default to 20] |
| **traditionId** | **int?** | Фильтрация по ID традиции. | [optional]  |
| **instrumentId** | **int?** | Фильтрация по ID инструмента. | [optional]  |
| **orderBy** | **string?** | Порядок сортировки | [optional] [default to award_level] |
| **withApplications** | **bool?** | Включить в ответ свойство &#x60;applications&#x60;. | [optional] [default to false] |

### Return type

[**List&lt;AwardsList200ResponseInner&gt;**](AwardsList200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="challengeslist"></a>
# **ChallengesList**
> List&lt;ChallengesList200ResponseInner&gt; ChallengesList (int? offset = null, int? limit = null)

Список испытаний

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChallengesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new ApplicationApi(config);
            var offset = 0;  // int? | Кол-во объектов выборки для пропуска. (optional)  (default to 0)
            var limit = 20;  // int? | Максимум объектов возвращаемых в теле ответа. (optional)  (default to 20)

            try
            {
                // Список испытаний
                List<ChallengesList200ResponseInner> result = apiInstance.ChallengesList(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ChallengesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChallengesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список испытаний
    ApiResponse<List<ChallengesList200ResponseInner>> response = apiInstance.ChallengesListWithHttpInfo(offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ChallengesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Кол-во объектов выборки для пропуска. | [optional] [default to 0] |
| **limit** | **int?** | Максимум объектов возвращаемых в теле ответа. | [optional] [default to 20] |

### Return type

[**List&lt;ChallengesList200ResponseInner&gt;**](ChallengesList200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="instrumentslist"></a>
# **InstrumentsList**
> List&lt;Instrument&gt; InstrumentsList (long? after = null, int? offset = null, int? limit = null, string? isActive = null, List<int>? id = null, List<int>? tId = null, List<int>? cId = null, string? name = null, string? orderBy = null)

Список инструментов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstrumentsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new ApplicationApi(config);
            var after = 789L;  // long? | Пропуск объектов с идентификатором равном или менее указанного. (optional) 
            var offset = 0;  // int? | Кол-во объектов выборки для пропуска. (optional)  (default to 0)
            var limit = 20;  // int? | Максимум объектов возвращаемых в теле ответа. (optional)  (default to 20)
            var isActive = "true";  // string? | Фильтрация по признаку активности объектов выборки. По умолчанию возвращаются только активные. (optional)  (default to true)
            var id = new List<int>?(); // List<int>? | Идентификаторы инструментов. (optional) 
            var tId = new List<int>?(); // List<int>? | Фильтрация по ID традиций. (optional) 
            var cId = new List<int>?(); // List<int>? | Фильтрация по ID компетенций. (optional) 
            var name = "name_example";  // string? | Фильтрация по названию инструмента. (optional) 
            var orderBy = "id_asc";  // string? | Очереднось выдачи. (optional)  (default to id_asc)

            try
            {
                // Список инструментов
                List<Instrument> result = apiInstance.InstrumentsList(after, offset, limit, isActive, id, tId, cId, name, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.InstrumentsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstrumentsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список инструментов
    ApiResponse<List<Instrument>> response = apiInstance.InstrumentsListWithHttpInfo(after, offset, limit, isActive, id, tId, cId, name, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.InstrumentsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **after** | **long?** | Пропуск объектов с идентификатором равном или менее указанного. | [optional]  |
| **offset** | **int?** | Кол-во объектов выборки для пропуска. | [optional] [default to 0] |
| **limit** | **int?** | Максимум объектов возвращаемых в теле ответа. | [optional] [default to 20] |
| **isActive** | **string?** | Фильтрация по признаку активности объектов выборки. По умолчанию возвращаются только активные. | [optional] [default to true] |
| **id** | [**List&lt;int&gt;?**](int.md) | Идентификаторы инструментов. | [optional]  |
| **tId** | [**List&lt;int&gt;?**](int.md) | Фильтрация по ID традиций. | [optional]  |
| **cId** | [**List&lt;int&gt;?**](int.md) | Фильтрация по ID компетенций. | [optional]  |
| **name** | **string?** | Фильтрация по названию инструмента. | [optional]  |
| **orderBy** | **string?** | Очереднось выдачи. | [optional] [default to id_asc] |

### Return type

[**List&lt;Instrument&gt;**](Instrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="passedchallengeslist"></a>
# **PassedChallengesList**
> List&lt;PassedChallengesList200ResponseInner&gt; PassedChallengesList (Guid? playerId = null, int? talentId = null, int? offset = null, int? limit = null)

Список пройденных испытаний

Параметры `player_id` и `talent_id` взаимоисключаемы. При аутентификации токеном `TalentOAuth`, предустанавливается параметр `talent_id`. При аутентификации токеном `BerlogaJWT`, предустанавливается параметр `player_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PassedChallengesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApplicationApi(config);
            var playerId = "playerId_example";  // Guid? | Испытания пройденные игроками, объединенными пользователем, привязанным к указанному игроку. При отсутствии привязанного пользователя, возвращаются испытания указанного игрока. (optional) 
            var talentId = 56;  // int? | Испытания пройденные игроками указанного пользователя. (optional) 
            var offset = 0;  // int? | Кол-во объектов выборки для пропуска. (optional)  (default to 0)
            var limit = 20;  // int? | Максимум объектов возвращаемых в теле ответа. (optional)  (default to 20)

            try
            {
                // Список пройденных испытаний
                List<PassedChallengesList200ResponseInner> result = apiInstance.PassedChallengesList(playerId, talentId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.PassedChallengesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PassedChallengesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список пройденных испытаний
    ApiResponse<List<PassedChallengesList200ResponseInner>> response = apiInstance.PassedChallengesListWithHttpInfo(playerId, talentId, offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.PassedChallengesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playerId** | **Guid?** | Испытания пройденные игроками, объединенными пользователем, привязанным к указанному игроку. При отсутствии привязанного пользователя, возвращаются испытания указанного игрока. | [optional]  |
| **talentId** | **int?** | Испытания пройденные игроками указанного пользователя. | [optional]  |
| **offset** | **int?** | Кол-во объектов выборки для пропуска. | [optional] [default to 0] |
| **limit** | **int?** | Максимум объектов возвращаемых в теле ответа. | [optional] [default to 20] |

### Return type

[**List&lt;PassedChallengesList200ResponseInner&gt;**](PassedChallengesList200ResponseInner.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT), [TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="traditioninstrumentslist"></a>
# **TraditionInstrumentsList**
> List&lt;Instrument&gt; TraditionInstrumentsList (int traditionId)

Список инструментов традиции

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TraditionInstrumentsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new ApplicationApi(config);
            var traditionId = 56;  // int | Идентификатор традиции в адресе.

            try
            {
                // Список инструментов традиции
                List<Instrument> result = apiInstance.TraditionInstrumentsList(traditionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.TraditionInstrumentsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TraditionInstrumentsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список инструментов традиции
    ApiResponse<List<Instrument>> response = apiInstance.TraditionInstrumentsListWithHttpInfo(traditionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.TraditionInstrumentsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **traditionId** | **int** | Идентификатор традиции в адресе. |  |

### Return type

[**List&lt;Instrument&gt;**](Instrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="traditionslist"></a>
# **TraditionsList**
> List&lt;Tradition&gt; TraditionsList (string? name = null, string? isActive = null)

Список традиций

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TraditionsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new ApplicationApi(config);
            var name = "name_example";  // string? | Фильтрация по названию традиции. (optional) 
            var isActive = "true";  // string? | Фильтрация по признаку активности объектов выборки. По умолчанию возвращаются только активные. (optional)  (default to true)

            try
            {
                // Список традиций
                List<Tradition> result = apiInstance.TraditionsList(name, isActive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.TraditionsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TraditionsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список традиций
    ApiResponse<List<Tradition>> response = apiInstance.TraditionsListWithHttpInfo(name, isActive);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.TraditionsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | Фильтрация по названию традиции. | [optional]  |
| **isActive** | **string?** | Фильтрация по признаку активности объектов выборки. По умолчанию возвращаются только активные. | [optional] [default to true] |

### Return type

[**List&lt;Tradition&gt;**](Tradition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userawarddisplayed"></a>
# **UserAwardDisplayed**
> void UserAwardDisplayed (int awardId)

Отметка награды продемонстрированной

Отметка награды как продемонстрированной пользователю в приложении.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserAwardDisplayedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var awardId = 56;  // int | 

            try
            {
                // Отметка награды продемонстрированной
                apiInstance.UserAwardDisplayed(awardId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.UserAwardDisplayed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAwardDisplayedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Отметка награды продемонстрированной
    apiInstance.UserAwardDisplayedWithHttpInfo(awardId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.UserAwardDisplayedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **awardId** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userawardslist"></a>
# **UserAwardsList**
> List&lt;UserAwardsList200ResponseInner&gt; UserAwardsList (int? offset = null, int? limit = null)

Список наград пользователя

Формат возвращаемых объектов в массиве зависит от типа используемой авторизации. Для `BerlogaJWT` возращаются `PlayerAward`, для `TalentOAuth` - `TalentUserAward`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserAwardsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApplicationApi(config);
            var offset = 0;  // int? | Кол-во объектов выборки для пропуска. (optional)  (default to 0)
            var limit = 20;  // int? | Максимум объектов возвращаемых в теле ответа. (optional)  (default to 20)

            try
            {
                // Список наград пользователя
                List<UserAwardsList200ResponseInner> result = apiInstance.UserAwardsList(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.UserAwardsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAwardsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список наград пользователя
    ApiResponse<List<UserAwardsList200ResponseInner>> response = apiInstance.UserAwardsListWithHttpInfo(offset, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.UserAwardsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Кол-во объектов выборки для пропуска. | [optional] [default to 0] |
| **limit** | **int?** | Максимум объектов возвращаемых в теле ответа. | [optional] [default to 20] |

### Return type

[**List&lt;UserAwardsList200ResponseInner&gt;**](UserAwardsList200ResponseInner.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT), [TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userprogresslist"></a>
# **UserProgressList**
> List&lt;Progress&gt; UserProgressList (int? offset = null, int? limit = null, bool? traditionsOnly = null, int? traditionInstruments = null, List<int>? traditionIds = null, List<int>? instrumentIds = null, string? orderBy = null)

Прогресс пользователя

Прогресс пользователя по традициям и инструментам.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserProgressListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ApplicationApi(config);
            var offset = 0;  // int? | Кол-во объектов выборки для пропуска. (optional)  (default to 0)
            var limit = 20;  // int? | Максимум объектов возвращаемых в теле ответа. (optional)  (default to 20)
            var traditionsOnly = false;  // bool? | Прогресс только по традициям (optional)  (default to false)
            var traditionInstruments = 56;  // int? | Прогресс по инструментам традиции (optional) 
            var traditionIds = new List<int>?(); // List<int>? | Прогресс по определенным традициям (optional) 
            var instrumentIds = new List<int>?(); // List<int>? | Прогресс по определенным инструментам (optional) 
            var orderBy = "created_at_desc";  // string? | Порядок сортировки (optional)  (default to created_at_desc)

            try
            {
                // Прогресс пользователя
                List<Progress> result = apiInstance.UserProgressList(offset, limit, traditionsOnly, traditionInstruments, traditionIds, instrumentIds, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.UserProgressList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserProgressListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Прогресс пользователя
    ApiResponse<List<Progress>> response = apiInstance.UserProgressListWithHttpInfo(offset, limit, traditionsOnly, traditionInstruments, traditionIds, instrumentIds, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.UserProgressListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Кол-во объектов выборки для пропуска. | [optional] [default to 0] |
| **limit** | **int?** | Максимум объектов возвращаемых в теле ответа. | [optional] [default to 20] |
| **traditionsOnly** | **bool?** | Прогресс только по традициям | [optional] [default to false] |
| **traditionInstruments** | **int?** | Прогресс по инструментам традиции | [optional]  |
| **traditionIds** | [**List&lt;int&gt;?**](int.md) | Прогресс по определенным традициям | [optional]  |
| **instrumentIds** | [**List&lt;int&gt;?**](int.md) | Прогресс по определенным инструментам | [optional]  |
| **orderBy** | **string?** | Порядок сортировки | [optional] [default to created_at_desc] |

### Return type

[**List&lt;Progress&gt;**](Progress.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT), [TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

