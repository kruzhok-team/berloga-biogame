# Org.OpenAPITools.Api.ServiceApi

All URIs are relative to *https://talent.kruzhok.org/berloga-idp*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PlayerGet**](ServiceApi.md#playerget) | **GET** /player/{player_id} | Чтение информации об игроке |
| [**TalentUserPlayers**](ServiceApi.md#talentuserplayers) | **GET** /talent/{talent_id}/players | Список PlayerID пользователя Таланта |
| [**TalentUserTokenGet**](ServiceApi.md#talentusertokenget) | **GET** /talent/{talent_id}/token | TalentOAuth токен пользователя |

<a id="playerget"></a>
# **PlayerGet**
> PlayerGet200Response PlayerGet (Guid playerId, bool? getTalentId = null, bool? getPlayerIds = null)

Чтение информации об игроке

Чтение информации об игроке.  По-умолчанию ответ не содержит каких-либо данных. Для того чтобы добавить в ответ какие-то из параметров игрока, нужно указать их соотвествующими параметрами запроса `get_*`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlayerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: ServiceKey
            config.AddApiKey("X-Service-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Service-Key", "Bearer");

            var apiInstance = new ServiceApi(config);
            var playerId = "playerId_example";  // Guid | PlayerID игрока
            var getTalentId = false;  // bool? | Включить в ответ `talent_id` (optional)  (default to false)
            var getPlayerIds = false;  // bool? | Включить в ответ `player_ids` (optional)  (default to false)

            try
            {
                // Чтение информации об игроке
                PlayerGet200Response result = apiInstance.PlayerGet(playerId, getTalentId, getPlayerIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.PlayerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Чтение информации об игроке
    ApiResponse<PlayerGet200Response> response = apiInstance.PlayerGetWithHttpInfo(playerId, getTalentId, getPlayerIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.PlayerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playerId** | **Guid** | PlayerID игрока |  |
| **getTalentId** | **bool?** | Включить в ответ &#x60;talent_id&#x60; | [optional] [default to false] |
| **getPlayerIds** | **bool?** | Включить в ответ &#x60;player_ids&#x60; | [optional] [default to false] |

### Return type

[**PlayerGet200Response**](PlayerGet200Response.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT), [ServiceKey](../README.md#ServiceKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **403** | Ошибка обработки запроса |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="talentuserplayers"></a>
# **TalentUserPlayers**
> List&lt;Guid&gt; TalentUserPlayers (int talentId)

Список PlayerID пользователя Таланта

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TalentUserPlayersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: ServiceKey
            config.AddApiKey("X-Service-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Service-Key", "Bearer");

            var apiInstance = new ServiceApi(config);
            var talentId = 56;  // int | ID пользователя Таланта

            try
            {
                // Список PlayerID пользователя Таланта
                List<Guid> result = apiInstance.TalentUserPlayers(talentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.TalentUserPlayers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TalentUserPlayersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список PlayerID пользователя Таланта
    ApiResponse<List<Guid>> response = apiInstance.TalentUserPlayersWithHttpInfo(talentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.TalentUserPlayersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **talentId** | **int** | ID пользователя Таланта |  |

### Return type

**List<Guid>**

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [ServiceKey](../README.md#ServiceKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="talentusertokenget"></a>
# **TalentUserTokenGet**
> string TalentUserTokenGet (int talentId)

TalentOAuth токен пользователя

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TalentUserTokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            // Configure API key authorization: ServiceKey
            config.AddApiKey("X-Service-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Service-Key", "Bearer");

            var apiInstance = new ServiceApi(config);
            var talentId = 56;  // int | ID пользователя Таланта

            try
            {
                // TalentOAuth токен пользователя
                string result = apiInstance.TalentUserTokenGet(talentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.TalentUserTokenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TalentUserTokenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // TalentOAuth токен пользователя
    ApiResponse<string> response = apiInstance.TalentUserTokenGetWithHttpInfo(talentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.TalentUserTokenGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **talentId** | **int** | ID пользователя Таланта |  |

### Return type

**string**

### Authorization

[ServiceKey](../README.md#ServiceKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

