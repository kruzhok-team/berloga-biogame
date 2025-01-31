# Org.OpenAPITools.Api.ApplicationApi

All URIs are relative to *https://talent.kruzhok.org/berloga-activities*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivitiesCreate**](ApplicationApi.md#activitiescreate) | **POST** /activities | Запись активностей |
| [**ActivitiesList**](ApplicationApi.md#activitieslist) | **GET** /activities | Список активностей |
| [**ActivitiesScores**](ApplicationApi.md#activitiesscores) | **GET** /activities/scores | Балл за активности |
| [**ArtefactSetUploaded**](ApplicationApi.md#artefactsetuploaded) | **POST** /artefacts/{artefact_id}/set-uploaded | Подтверждение загрузки артефакта |
| [**ArtefactTypesList**](ApplicationApi.md#artefacttypeslist) | **GET** /artefact-types | Справочник типов артефактов |
| [**ArtefactUploadURL**](ApplicationApi.md#artefactuploadurl) | **GET** /artefacts/{artefact_id}/upload-url | Запрос новой ссылки для загрузки |
| [**ArtefactsCreate**](ApplicationApi.md#artefactscreate) | **POST** /artefacts | Загрузка артефакта |

<a id="activitiescreate"></a>
# **ActivitiesCreate**
> ActivitiesCreate201Response ActivitiesCreate (ActivitiesCreateRequest activitiesCreateRequest)

Запись активностей

Каждая из активностей опционально может иметь метрики и артефакт.  Запись активностей доступна в коротком и расширенном форматах.  #### Короткий формат  Передается только массив активностей. Если они ссылаются на артефакты, эти артефакты должны быть предварительно [загружены](#operation/ArtefactsCreate). Ответ на такой запрос тоже включает в себя только массив с активностями.  #### Расширенный формат  В этом формате передается объект, который должен содержать активности в массиве, аналогичном короткому формату, и опционально может включать в себя еще артефакты для создания. В ответе на такой запрос, аналогично, возвращается объект, содержащий те же ключи. В возвращаемом массиве артефактов будут ссылки, по которым эти артефакты должны быть загружены.  > Ссылки имеют ограниченный срок жизни. Если данные артефакта не были загружены в рамках этого периода, то нужно [запросить новую ссылку](#operation/ArtefactUploadURL).  > До тех пор, пока указанные в активности артефакты не будут загружены, эта активность с ее баллами не будет учитываться в прогрессе традиции игрока.  После загрузки данных артефакта по полученной ссылке, нужно [подтвердить что загрузка завершена](#operation/ArtefactSetUploaded).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitiesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var activitiesCreateRequest = new ActivitiesCreateRequest(); // ActivitiesCreateRequest | 

            try
            {
                // Запись активностей
                ActivitiesCreate201Response result = apiInstance.ActivitiesCreate(activitiesCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ActivitiesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Запись активностей
    ApiResponse<ActivitiesCreate201Response> response = apiInstance.ActivitiesCreateWithHttpInfo(activitiesCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ActivitiesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activitiesCreateRequest** | [**ActivitiesCreateRequest**](ActivitiesCreateRequest.md) |  |  |

### Return type

[**ActivitiesCreate201Response**](ActivitiesCreate201Response.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **422** | Ошибка валидации данных в запросе |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activitieslist"></a>
# **ActivitiesList**
> List&lt;Activity&gt; ActivitiesList (List<Guid> ids)

Список активностей

Если какие-то из указанных активностей не будут найдены, то они просто будут отсутствовать в ответе.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitiesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var ids = new List<Guid>(); // List<Guid> | Идентификаторы активностей

            try
            {
                // Список активностей
                List<Activity> result = apiInstance.ActivitiesList(ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ActivitiesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivitiesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Список активностей
    ApiResponse<List<Activity>> response = apiInstance.ActivitiesListWithHttpInfo(ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ActivitiesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;Guid&gt;**](Guid.md) | Идентификаторы активностей |  |

### Return type

[**List&lt;Activity&gt;**](Activity.md)

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

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

            var apiInstance = new ApplicationApi(config);
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
                Debug.Print("Exception when calling ApplicationApi.ActivitiesScores: " + e.Message);
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
    Debug.Print("Exception when calling ApplicationApi.ActivitiesScoresWithHttpInfo: " + e.Message);
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

<a id="artefactsetuploaded"></a>
# **ArtefactSetUploaded**
> void ArtefactSetUploaded (Guid artefactId)

Подтверждение загрузки артефакта

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtefactSetUploadedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var artefactId = "artefactId_example";  // Guid | 

            try
            {
                // Подтверждение загрузки артефакта
                apiInstance.ArtefactSetUploaded(artefactId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ArtefactSetUploaded: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtefactSetUploadedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Подтверждение загрузки артефакта
    apiInstance.ArtefactSetUploadedWithHttpInfo(artefactId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ArtefactSetUploadedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **artefactId** | **Guid** |  |  |

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
| **200** | OK |  -  |
| **404** | Артефакт не найден |  -  |
| **422** | Данные артефакта уже загружены |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="artefacttypeslist"></a>
# **ArtefactTypesList**
> List&lt;ArtefactTypesList200ResponseInner&gt; ArtefactTypesList ()

Справочник типов артефактов

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtefactTypesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            var apiInstance = new ApplicationApi(config);

            try
            {
                // Справочник типов артефактов
                List<ArtefactTypesList200ResponseInner> result = apiInstance.ArtefactTypesList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ArtefactTypesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtefactTypesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Справочник типов артефактов
    ApiResponse<List<ArtefactTypesList200ResponseInner>> response = apiInstance.ArtefactTypesListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ArtefactTypesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ArtefactTypesList200ResponseInner&gt;**](ArtefactTypesList200ResponseInner.md)

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

<a id="artefactuploadurl"></a>
# **ArtefactUploadURL**
> string ArtefactUploadURL (Guid artefactId)

Запрос новой ссылки для загрузки

Ссылка для загрузки данных артефактом имеет ограниченный срок жизни. После его завершения, если данные артефакта еще не были успешно загружены, нужно запрашивать новую ссылку. Загрузку данных по ссылке нужно выполнять методом PUT.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtefactUploadURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var artefactId = "artefactId_example";  // Guid | 

            try
            {
                // Запрос новой ссылки для загрузки
                string result = apiInstance.ArtefactUploadURL(artefactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ArtefactUploadURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtefactUploadURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Запрос новой ссылки для загрузки
    ApiResponse<string> response = apiInstance.ArtefactUploadURLWithHttpInfo(artefactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ArtefactUploadURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **artefactId** | **Guid** |  |  |

### Return type

**string**

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Артефакт не найден |  -  |
| **422** | Данные артефакта уже загружены |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="artefactscreate"></a>
# **ArtefactsCreate**
> Guid ArtefactsCreate (int xArtefactType, string xChecksum, System.IO.Stream body)

Загрузка артефакта

Артефакт предварительно загружается для передачи его в активности.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArtefactsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-activities";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi(config);
            var xArtefactType = 56;  // int | ID типа артефакта из [справочника](#operation/ArtefactTypesList).
            var xChecksum = "xChecksum_example";  // string | SHA-1 контрольная сумма
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Содержимое артефакта. Поддерживаемые типы:    - application/cyberiada-graphml   - application/json   - application/xml

            try
            {
                // Загрузка артефакта
                Guid result = apiInstance.ArtefactsCreate(xArtefactType, xChecksum, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationApi.ArtefactsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArtefactsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Загрузка артефакта
    ApiResponse<Guid> response = apiInstance.ArtefactsCreateWithHttpInfo(xArtefactType, xChecksum, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationApi.ArtefactsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xArtefactType** | **int** | ID типа артефакта из [справочника](#operation/ArtefactTypesList). |  |
| **xChecksum** | **string** | SHA-1 контрольная сумма |  |
| **body** | **System.IO.Stream****System.IO.Stream** | Содержимое артефакта. Поддерживаемые типы:    - application/cyberiada-graphml   - application/json   - application/xml |  |

### Return type

**Guid**

### Authorization

[BerlogaJWT](../README.md#BerlogaJWT)

### HTTP request headers

 - **Content-Type**: application/*
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **422** | Не найден указанный тип артефакта |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

