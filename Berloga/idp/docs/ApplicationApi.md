# Org.OpenAPITools.Api.ApplicationApi

All URIs are relative to *https://talent.kruzhok.org/berloga-idp*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplicationsList**](ApplicationApi.md#applicationslist) | **GET** /applications | Список приложений |
| [**IssueToken**](ApplicationApi.md#issuetoken) | **POST** /issue-token | Запрос аутентификационного токена |
| [**PlayerGet**](ApplicationApi.md#playerget) | **GET** /player/{player_id} | Чтение информации об игроке |
| [**PlayersCreate**](ApplicationApi.md#playerscreate) | **POST** /players | Регистрация нового игрока |
| [**PlayersMigrate**](ApplicationApi.md#playersmigrate) | **POST** /players/migrate | Миграция legacy PlayerID |
| [**TalentOAuthComplete**](ApplicationApi.md#talentoauthcomplete) | **GET** /talent-oauth/complete | Завершение авторизации в Таланте |
| [**TalentOAuthConnect**](ApplicationApi.md#talentoauthconnect) | **GET** /talent-oauth/connect | Перенаправление на авторизацию |
| [**TalentOAuthDisconnect**](ApplicationApi.md#talentoauthdisconnect) | **POST** /talent-oauth/disconnect | Отсоединение учетной записи Таланта |

<a id="applicationslist"></a>
# **ApplicationsList**
> List&lt;Application&gt; ApplicationsList (int? offset = null, int? limit = null, string? isPublic = null, string? orderBy = null)

Список приложений

Список приложений.  По-умолчанию сортируется по дате создания от новых к старым (`order_by=created_at_desc`) и включает в себя только опубликованные приложения (`is_public=true`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApplicationsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            var apiInstance = new ApplicationApi(config);
            var offset = 0;  // int? |  (optional)  (default to 0)
            var limit = 20;  // int? |  (optional)  (default to 20)
            var isPublic = "true";  // string? | Фильтрация по публичности приложений.  - true - только опубликованные - false - только не опубликованные - all - все (optional)  (default to true)
            var orderBy = "created_at_asc";  // string? | Порядок сортировки результатов. (optional) 

            try
            {
                // Список приложений
                List<Application> result = apiInstance.ApplicationsList(offset, limit, isPublic, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApplicationsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplicationsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список приложений
    ApiResponse<List<Application>> response = apiInstance.ApplicationsListWithHttpInfo(offset, limit, isPublic, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ApplicationsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional] [default to 0] |
| **limit** | **int?** |  | [optional] [default to 20] |
| **isPublic** | **string?** | Фильтрация по публичности приложений.  - true - только опубликованные - false - только не опубликованные - all - все | [optional] [default to true] |
| **orderBy** | **string?** | Порядок сортировки результатов. | [optional]  |

### Return type

[**List&lt;Application&gt;**](Application.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count - Общее кол-во приложений входящих в выборку без учета пагинации. <br>  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuetoken"></a>
# **IssueToken**
> IssueToken201Response IssueToken (IssueTokenRequest issueTokenRequest)

Запрос аутентификационного токена

Запрос аутентфикационного токена игрока.  Токен имеет ограниченное непродолжительное время жизни.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            var apiInstance = new ApplicationApi(config);
            var issueTokenRequest = new IssueTokenRequest(); // IssueTokenRequest | 

            try
            {
                // Запрос аутентификационного токена
                IssueToken201Response result = apiInstance.IssueToken(issueTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.IssueToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Запрос аутентификационного токена
    ApiResponse<IssueToken201Response> response = apiInstance.IssueTokenWithHttpInfo(issueTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.IssueTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **issueTokenRequest** | [**IssueTokenRequest**](IssueTokenRequest.md) |  |  |

### Return type

[**IssueToken201Response**](IssueToken201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new ApplicationApi(config);
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
                Debug.Print("Exception when calling ApplicationApi.PlayerGet: " + e.Message);
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
    Debug.Print("Exception when calling ApplicationApi.PlayerGetWithHttpInfo: " + e.Message);
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

<a id="playerscreate"></a>
# **PlayersCreate**
> PlayersCreate201Response PlayersCreate (PlayersCreateRequest playersCreateRequest)

Регистрация нового игрока

Регистрация нового PlayerID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlayersCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            var apiInstance = new ApplicationApi(config);
            var playersCreateRequest = new PlayersCreateRequest(); // PlayersCreateRequest | 

            try
            {
                // Регистрация нового игрока
                PlayersCreate201Response result = apiInstance.PlayersCreate(playersCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.PlayersCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayersCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Регистрация нового игрока
    ApiResponse<PlayersCreate201Response> response = apiInstance.PlayersCreateWithHttpInfo(playersCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.PlayersCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playersCreateRequest** | [**PlayersCreateRequest**](PlayersCreateRequest.md) |  |  |

### Return type

[**PlayersCreate201Response**](PlayersCreate201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Зарегистрирован |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="playersmigrate"></a>
# **PlayersMigrate**
> PlayersMigrate200Response PlayersMigrate (PlayersMigrateRequest playersMigrateRequest)

Миграция legacy PlayerID

Миграция имеющихся данных о PlayerID под актуальное API сервисов Берлоги.  В ответе возвращается PlayerSecret, который обязательно нужно сохранить на клиенте. Без него не получится пройти авторизацию клиентского API и они станут не доступны для этого PlayerID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlayersMigrateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            var apiInstance = new ApplicationApi(config);
            var playersMigrateRequest = new PlayersMigrateRequest(); // PlayersMigrateRequest | 

            try
            {
                // Миграция legacy PlayerID
                PlayersMigrate200Response result = apiInstance.PlayersMigrate(playersMigrateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.PlayersMigrate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayersMigrateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Миграция legacy PlayerID
    ApiResponse<PlayersMigrate200Response> response = apiInstance.PlayersMigrateWithHttpInfo(playersMigrateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.PlayersMigrateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playersMigrateRequest** | [**PlayersMigrateRequest**](PlayersMigrateRequest.md) |  |  |

### Return type

[**PlayersMigrate200Response**](PlayersMigrate200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="talentoauthcomplete"></a>
# **TalentOAuthComplete**
> InlineObject TalentOAuthComplete (string code, Guid state)

Завершение авторизации в Таланте

Эндпоинт завершения авторизации Берлоги и перенаправление в приложение.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TalentOAuthCompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            var apiInstance = new ApplicationApi(config);
            var code = "code_example";  // string | 
            var state = "state_example";  // Guid | 

            try
            {
                // Завершение авторизации в Таланте
                InlineObject result = apiInstance.TalentOAuthComplete(code, state);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.TalentOAuthComplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TalentOAuthCompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Завершение авторизации в Таланте
    ApiResponse<InlineObject> response = apiInstance.TalentOAuthCompleteWithHttpInfo(code, state);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.TalentOAuthCompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |
| **state** | **Guid** |  |  |

### Return type

[**InlineObject**](InlineObject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | OK |  * Location -  <br>  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="talentoauthconnect"></a>
# **TalentOAuthConnect**
> InlineObject TalentOAuthConnect (string? redirectUri = null)

Перенаправление на авторизацию

Перенаправление на клиентский эндпонит OAuth авторизации Берлоги в Таланте.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TalentOAuthConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var redirectUri = "redirectUri_example";  // string? | URI перенаправления пользователя после авторизации Берлоги в Таланте. (optional) 

            try
            {
                // Перенаправление на авторизацию
                InlineObject result = apiInstance.TalentOAuthConnect(redirectUri);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.TalentOAuthConnect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TalentOAuthConnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Перенаправление на авторизацию
    ApiResponse<InlineObject> response = apiInstance.TalentOAuthConnectWithHttpInfo(redirectUri);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.TalentOAuthConnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **redirectUri** | **string?** | URI перенаправления пользователя после авторизации Берлоги в Таланте. | [optional]  |

### Return type

[**InlineObject**](InlineObject.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | OK |  * Location -  <br>  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="talentoauthdisconnect"></a>
# **TalentOAuthDisconnect**
> void TalentOAuthDisconnect ()

Отсоединение учетной записи Таланта

Если у игрока и так (уже) нет авторизованной учетной записи Таланта, то метод вернет `204` ответ так же как при успешном отсоединении оной.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TalentOAuthDisconnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);

            try
            {
                // Отсоединение учетной записи Таланта
                apiInstance.TalentOAuthDisconnect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.TalentOAuthDisconnect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TalentOAuthDisconnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Отсоединение учетной записи Таланта
    apiInstance.TalentOAuthDisconnectWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.TalentOAuthDisconnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | OK |  -  |
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

