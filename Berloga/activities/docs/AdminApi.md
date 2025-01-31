# Org.OpenAPITools.Api.AdminApi

All URIs are relative to *https://talent.kruzhok.org/berloga-activities*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContextsImport**](AdminApi.md#contextsimport) | **POST** /contexts/import | Импорт контекстов со свойствами |
| [**ContextsList**](AdminApi.md#contextslist) | **GET** /contexts | Список контекстов |

<a id="contextsimport"></a>
# **ContextsImport**
> void ContextsImport (Guid xApplication, System.IO.Stream body)

Импорт контекстов со свойствами

Импортируемая таблица должна содержать колонки `id` и `description`. Содержащие в ячейках идентификатор (UUID) и описание контекста соответственно.  Оставшиеся колонки таблицы будут восприняты как свойства контекстов. Тип значения для свойства определяется на основе значений в ячейках колонки. Если все значения можно интерпретировать как числовые, то тип значения у свойства будет числовой. Если хоть одно значение не приводится к числу, то тип значения определяется как строковый.  В заголовках запроса так же необходимо указать ID приложения с контекстами которого будет выполнятся работа.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContextsImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminApi(config);
            var xApplication = "xApplication_example";  // Guid | ID приложения, для которого импортируются контексты.
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Таблица контекстов для импорта.

            try
            {
                // Импорт контекстов со свойствами
                apiInstance.ContextsImport(xApplication, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.ContextsImport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContextsImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Импорт контекстов со свойствами
    apiInstance.ContextsImportWithHttpInfo(xApplication, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.ContextsImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApplication** | **Guid** | ID приложения, для которого импортируются контексты. |  |
| **body** | **System.IO.Stream****System.IO.Stream** | Таблица контекстов для импорта. |  |

### Return type

void (empty response body)

### Authorization

[TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: text/tsv, text/csv
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Успешно выполнена запись |  -  |
| **400** | Ошибка |  -  |
| **403** | Ошибка |  -  |
| **422** | Переданы невалидные данные |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contextslist"></a>
# **ContextsList**
> List&lt;Context&gt; ContextsList (int? offset = null, int? limit = null, List<Guid>? id = null, List<int>? tId = null, List<Guid>? appId = null, string? desc = null)

Список контекстов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ContextsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminApi(config);
            var offset = 0;  // int? |  (optional)  (default to 0)
            var limit = 20;  // int? |  (optional)  (default to 20)
            var id = new List<Guid>?(); // List<Guid>? | Фильтрация по ID контекстов. (optional) 
            var tId = new List<int>?(); // List<int>? | Фильтрация по ID традиций. (optional) 
            var appId = new List<Guid>?(); // List<Guid>? | Фильтрация по ID приложения. (optional) 
            var desc = "desc_example";  // string? | Фильтрация по вхождению подстроки в описание контекста. (optional) 

            try
            {
                // Список контекстов
                List<Context> result = apiInstance.ContextsList(offset, limit, id, tId, appId, desc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.ContextsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContextsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список контекстов
    ApiResponse<List<Context>> response = apiInstance.ContextsListWithHttpInfo(offset, limit, id, tId, appId, desc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.ContextsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional] [default to 0] |
| **limit** | **int?** |  | [optional] [default to 20] |
| **id** | [**List&lt;Guid&gt;?**](Guid.md) | Фильтрация по ID контекстов. | [optional]  |
| **tId** | [**List&lt;int&gt;?**](int.md) | Фильтрация по ID традиций. | [optional]  |
| **appId** | [**List&lt;Guid&gt;?**](Guid.md) | Фильтрация по ID приложения. | [optional]  |
| **desc** | **string?** | Фильтрация по вхождению подстроки в описание контекста. | [optional]  |

### Return type

[**List&lt;Context&gt;**](Context.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Count -  <br>  |
| **403** | Ошибка |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

