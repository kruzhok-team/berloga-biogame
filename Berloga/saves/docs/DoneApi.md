# Org.OpenAPITools.Api.DoneApi

All URIs are relative to *https://talent.kruzhok.org/gamesaves*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GamesaveLatestDelete**](DoneApi.md#gamesavelatestdelete) | **DELETE** /saves/latest | Удаление последнего сохранения |
| [**GamesaveLatestGamedata**](DoneApi.md#gamesavelatestgamedata) | **GET** /saves/latest/gamedata | Чтение игровых данных последнего сохранения |
| [**GamesaveLatestMetadata**](DoneApi.md#gamesavelatestmetadata) | **GET** /saves/latest | Чтение мета-данных последнего сохранения |

<a id="gamesavelatestdelete"></a>
# **GamesaveLatestDelete**
> void GamesaveLatestDelete ()

Удаление последнего сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveLatestDeleteExample
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

            var apiInstance = new DoneApi(config);

            try
            {
                // Удаление последнего сохранения
                apiInstance.GamesaveLatestDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DoneApi.GamesaveLatestDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveLatestDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Удаление последнего сохранения
    apiInstance.GamesaveLatestDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DoneApi.GamesaveLatestDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **404** | Сохранения отсуствуют |  -  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesavelatestgamedata"></a>
# **GamesaveLatestGamedata**
> Dictionary&lt;string, Object&gt; GamesaveLatestGamedata ()

Чтение игровых данных последнего сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveLatestGamedataExample
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

            var apiInstance = new DoneApi(config);

            try
            {
                // Чтение игровых данных последнего сохранения
                Dictionary<string, Object> result = apiInstance.GamesaveLatestGamedata();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DoneApi.GamesaveLatestGamedata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveLatestGamedataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Чтение игровых данных последнего сохранения
    ApiResponse<Dictionary<string, Object>> response = apiInstance.GamesaveLatestGamedataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DoneApi.GamesaveLatestGamedataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **404** | Сохранения отсуствуют |  -  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamesavelatestmetadata"></a>
# **GamesaveLatestMetadata**
> GamesaveMeta GamesaveLatestMetadata ()

Чтение мета-данных последнего сохранения

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GamesaveLatestMetadataExample
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

            var apiInstance = new DoneApi(config);

            try
            {
                // Чтение мета-данных последнего сохранения
                GamesaveMeta result = apiInstance.GamesaveLatestMetadata();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DoneApi.GamesaveLatestMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GamesaveLatestMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Чтение мета-данных последнего сохранения
    ApiResponse<GamesaveMeta> response = apiInstance.GamesaveLatestMetadataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DoneApi.GamesaveLatestMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **404** | Сохранения отсуствуют |  -  |
| **0** | Клиентская или серверная ошибка. Ответ со статусом &#x60;4xx&#x60; / &#x60;5xx&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

