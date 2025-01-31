# Org.OpenAPITools.Api.WipApi

All URIs are relative to *https://talent.kruzhok.org/gamesaves*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GamesaveCreate**](WipApi.md#gamesavecreate) | **POST** /saves | Запись нового сохранения |
| [**GamesaveDelete**](WipApi.md#gamesavedelete) | **DELETE** /saves/{save_id} | Удаление определенного сохранения |
| [**GamesaveGamedata**](WipApi.md#gamesavegamedata) | **GET** /saves/{save_id}/gamedata | Чтение игровых данных указанного сохранения |
| [**GamesaveList**](WipApi.md#gamesavelist) | **GET** /saves | Список игровых сохранений пользователя |
| [**GamesaveMetadata**](WipApi.md#gamesavemetadata) | **GET** /saves/{save_id} | Чтение мета-данных указанного сохранения |
| [**GamesaveOverwrite**](WipApi.md#gamesaveoverwrite) | **PUT** /saves/{save_id}/gamedata | Перезапись игровых данных сохранения |

<a id="gamesavecreate"></a>
# **GamesaveCreate**
> long GamesaveCreate (string? saveTitle = null, Dictionary<string, Object>? requestBody = null)

Запись нового сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/gamesaves";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: Application
            config.AddApiKey("Application", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Application", "Bearer");

            var apiInstance = new WipApi(config);
            var saveTitle = "saveTitle_example";  // string? | Опциональное имя сохранения (optional) 
            var requestBody = new Dictionary<string, Object>?(); // Dictionary<string, Object>? | Данные создаваемого JSON-сохранения (optional) 

            try
            {
                // Запись нового сохранения
                long result = apiInstance.GamesaveCreate(saveTitle, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WipApi.GamesaveCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Запись нового сохранения
    ApiResponse<long> response = apiInstance.GamesaveCreateWithHttpInfo(saveTitle, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WipApi.GamesaveCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveTitle** | **string?** | Опциональное имя сохранения | [optional]  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;?**](Object.md) | Данные создаваемого JSON-сохранения | [optional]  |

### Return type

**long**

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Создано JSON-сохранение |  -  |
| **400** | Для используемой игры принят другой формат сохранения |  -  |
| **302** | Перенаправление в хранилище для загрузки игровых данных |  * Location -  <br>  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesavedelete"></a>
# **GamesaveDelete**
> void GamesaveDelete (long saveId)

Удаление определенного сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/gamesaves";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: Application
            config.AddApiKey("Application", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Application", "Bearer");

            var apiInstance = new WipApi(config);
            var saveId = 789L;  // long | 

            try
            {
                // Удаление определенного сохранения
                apiInstance.GamesaveDelete(saveId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WipApi.GamesaveDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Удаление определенного сохранения
    apiInstance.GamesaveDeleteWithHttpInfo(saveId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WipApi.GamesaveDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveId** | **long** |  |  |

### Return type

void (empty response body)

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Сохранение удалено |  -  |
| **404** | Сохранение не найдено |  -  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesavegamedata"></a>
# **GamesaveGamedata**
> Dictionary&lt;string, Object&gt; GamesaveGamedata (long saveId)

Чтение игровых данных указанного сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveGamedataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/gamesaves";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: Application
            config.AddApiKey("Application", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Application", "Bearer");

            var apiInstance = new WipApi(config);
            var saveId = 789L;  // long | 

            try
            {
                // Чтение игровых данных указанного сохранения
                Dictionary<string, Object> result = apiInstance.GamesaveGamedata(saveId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WipApi.GamesaveGamedata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveGamedataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Чтение игровых данных указанного сохранения
    ApiResponse<Dictionary<string, Object>> response = apiInstance.GamesaveGamedataWithHttpInfo(saveId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WipApi.GamesaveGamedataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveId** | **long** |  |  |

### Return type

**Dictionary<string, Object>**

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Данные сохранения в формате JSON |  -  |
| **302** | Перенаправление на скачивание файла |  * Location -  <br>  |
| **404** | Сохранение не найдено |  -  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesavelist"></a>
# **GamesaveList**
> List&lt;GamesaveMeta&gt; GamesaveList (int? limit = null, int? offset = null, string? orderBy = null)

Список игровых сохранений пользователя

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/gamesaves";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: Application
            config.AddApiKey("Application", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Application", "Bearer");

            var apiInstance = new WipApi(config);
            var limit = 20;  // int? |  (optional)  (default to 20)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "id_asc";  // string? |  (optional)  (default to id_desc)

            try
            {
                // Список игровых сохранений пользователя
                List<GamesaveMeta> result = apiInstance.GamesaveList(limit, offset, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WipApi.GamesaveList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список игровых сохранений пользователя
    ApiResponse<List<GamesaveMeta>> response = apiInstance.GamesaveListWithHttpInfo(limit, offset, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WipApi.GamesaveListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 20] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to id_desc] |

### Return type

[**List&lt;GamesaveMeta&gt;**](GamesaveMeta.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  * X-Count -  <br>  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesavemetadata"></a>
# **GamesaveMetadata**
> GamesaveMeta GamesaveMetadata (long saveId)

Чтение мета-данных указанного сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/gamesaves";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: Application
            config.AddApiKey("Application", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Application", "Bearer");

            var apiInstance = new WipApi(config);
            var saveId = 789L;  // long | 

            try
            {
                // Чтение мета-данных указанного сохранения
                GamesaveMeta result = apiInstance.GamesaveMetadata(saveId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WipApi.GamesaveMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Чтение мета-данных указанного сохранения
    ApiResponse<GamesaveMeta> response = apiInstance.GamesaveMetadataWithHttpInfo(saveId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WipApi.GamesaveMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveId** | **long** |  |  |

### Return type

[**GamesaveMeta**](GamesaveMeta.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Мета-данные сохранения |  -  |
| **404** | Сохранение не найдено |  -  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesaveoverwrite"></a>
# **GamesaveOverwrite**
> void GamesaveOverwrite (long saveId, Dictionary<string, Object>? requestBody = null)

Перезапись игровых данных сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveOverwriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/gamesaves";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: Application
            config.AddApiKey("Application", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Application", "Bearer");

            var apiInstance = new WipApi(config);
            var saveId = 789L;  // long | 
            var requestBody = new Dictionary<string, Object>?(); // Dictionary<string, Object>? | Данные создаваемого JSON-сохранения (optional) 

            try
            {
                // Перезапись игровых данных сохранения
                apiInstance.GamesaveOverwrite(saveId, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WipApi.GamesaveOverwrite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveOverwriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Перезапись игровых данных сохранения
    apiInstance.GamesaveOverwriteWithHttpInfo(saveId, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WipApi.GamesaveOverwriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveId** | **long** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;?**](Object.md) | Данные создаваемого JSON-сохранения | [optional]  |

### Return type

void (empty response body)

### Authorization

[TalentOAuth](../README.md#TalentOAuth), [Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON-сохранение обновлено |  -  |
| **400** | Для используемой игры принят другой формат сохранения |  -  |
| **302** | Перенаправление в хранилище для загрузки игровых данных |  * Location -  <br>  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

