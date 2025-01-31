# Org.OpenAPITools.Api.AdminApi

All URIs are relative to *https://talent.kruzhok.org/berloga-awards*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InstrumentCreate**](AdminApi.md#instrumentcreate) | **POST** /instruments | Добавление инструмента |
| [**InstrumentRead**](AdminApi.md#instrumentread) | **GET** /instruments/{instrument_id} | Инструмент |
| [**InstrumentUpdate**](AdminApi.md#instrumentupdate) | **PATCH** /instruments/{instrument_id} | Обновление инструмента |
| [**InstrumentsList**](AdminApi.md#instrumentslist) | **GET** /instruments | Список инструментов |
| [**TraditionCreate**](AdminApi.md#traditioncreate) | **POST** /traditions | Добавление традиции |
| [**TraditionRead**](AdminApi.md#traditionread) | **GET** /traditions/{tradition_id} | Традиция |
| [**TraditionUpdate**](AdminApi.md#traditionupdate) | **PATCH** /traditions/{tradition_id} | Обновление традиции |
| [**TraditionsList**](AdminApi.md#traditionslist) | **GET** /traditions | Список традиций |

<a id="instrumentcreate"></a>
# **InstrumentCreate**
> Instrument InstrumentCreate (InstrumentCreateRequest instrumentCreateRequest)

Добавление инструмента

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstrumentCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminApi(config);
            var instrumentCreateRequest = new InstrumentCreateRequest(); // InstrumentCreateRequest | 

            try
            {
                // Добавление инструмента
                Instrument result = apiInstance.InstrumentCreate(instrumentCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.InstrumentCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstrumentCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Добавление инструмента
    ApiResponse<Instrument> response = apiInstance.InstrumentCreateWithHttpInfo(instrumentCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.InstrumentCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentCreateRequest** | [**InstrumentCreateRequest**](InstrumentCreateRequest.md) |  |  |

### Return type

[**Instrument**](Instrument.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Инструмент создан |  -  |
| **403** | Для доступа нужны права администратора |  -  |
| **409** | Инструмент с таким ID компетенции уже существует |  -  |
| **422** | Необходимо использовать существующий ID традиции |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="instrumentread"></a>
# **InstrumentRead**
> Instrument InstrumentRead (int instrumentId)

Инструмент

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstrumentReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new AdminApi(config);
            var instrumentId = 56;  // int | Идентификатор инструмента в адресе.

            try
            {
                // Инструмент
                Instrument result = apiInstance.InstrumentRead(instrumentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.InstrumentRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstrumentReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Инструмент
    ApiResponse<Instrument> response = apiInstance.InstrumentReadWithHttpInfo(instrumentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.InstrumentReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentId** | **int** | Идентификатор инструмента в адресе. |  |

### Return type

[**Instrument**](Instrument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Инструмент не найден |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="instrumentupdate"></a>
# **InstrumentUpdate**
> Instrument InstrumentUpdate (int instrumentId, InstrumentUpdateRequest instrumentUpdateRequest)

Обновление инструмента

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstrumentUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminApi(config);
            var instrumentId = 56;  // int | Идентификатор инструмента в адресе.
            var instrumentUpdateRequest = new InstrumentUpdateRequest(); // InstrumentUpdateRequest | 

            try
            {
                // Обновление инструмента
                Instrument result = apiInstance.InstrumentUpdate(instrumentId, instrumentUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.InstrumentUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstrumentUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Обновление инструмента
    ApiResponse<Instrument> response = apiInstance.InstrumentUpdateWithHttpInfo(instrumentId, instrumentUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.InstrumentUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentId** | **int** | Идентификатор инструмента в адресе. |  |
| **instrumentUpdateRequest** | [**InstrumentUpdateRequest**](InstrumentUpdateRequest.md) |  |  |

### Return type

[**Instrument**](Instrument.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Инструмент обновлен |  -  |
| **403** | Для доступа нужны права администратора |  -  |
| **404** | Инструмент не найден |  -  |
| **409** | Инструмент с таким ID компетенции уже существует |  -  |
| **422** | Необходимо использовать существующий ID традиции |  -  |

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
            var apiInstance = new AdminApi(config);
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
                Debug.Print("Exception when calling AdminApi.InstrumentsList: " + e.Message);
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
    Debug.Print("Exception when calling AdminApi.InstrumentsListWithHttpInfo: " + e.Message);
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

<a id="traditioncreate"></a>
# **TraditionCreate**
> Tradition TraditionCreate (TraditionCreateRequest traditionCreateRequest)

Добавление традиции

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TraditionCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminApi(config);
            var traditionCreateRequest = new TraditionCreateRequest(); // TraditionCreateRequest | 

            try
            {
                // Добавление традиции
                Tradition result = apiInstance.TraditionCreate(traditionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.TraditionCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TraditionCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Добавление традиции
    ApiResponse<Tradition> response = apiInstance.TraditionCreateWithHttpInfo(traditionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.TraditionCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **traditionCreateRequest** | [**TraditionCreateRequest**](TraditionCreateRequest.md) |  |  |

### Return type

[**Tradition**](Tradition.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Традиция создана |  -  |
| **403** | Для доступа нужны права администратора |  -  |
| **409** | Традиция с таким названием уже существует |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="traditionread"></a>
# **TraditionRead**
> Tradition TraditionRead (int traditionId)

Традиция

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TraditionReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            var apiInstance = new AdminApi(config);
            var traditionId = 56;  // int | Идентификатор традиции в адресе.

            try
            {
                // Традиция
                Tradition result = apiInstance.TraditionRead(traditionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.TraditionRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TraditionReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Традиция
    ApiResponse<Tradition> response = apiInstance.TraditionReadWithHttpInfo(traditionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.TraditionReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **traditionId** | **int** | Идентификатор традиции в адресе. |  |

### Return type

[**Tradition**](Tradition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Традиция не найдена |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="traditionupdate"></a>
# **TraditionUpdate**
> Tradition TraditionUpdate (int traditionId, TraditionUpdateRequest traditionUpdateRequest)

Обновление традиции

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TraditionUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-awards";
            // Configure Bearer token for authorization: TalentOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AdminApi(config);
            var traditionId = 56;  // int | Идентификатор традиции в адресе.
            var traditionUpdateRequest = new TraditionUpdateRequest(); // TraditionUpdateRequest | 

            try
            {
                // Обновление традиции
                Tradition result = apiInstance.TraditionUpdate(traditionId, traditionUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdminApi.TraditionUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TraditionUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Обновление традиции
    ApiResponse<Tradition> response = apiInstance.TraditionUpdateWithHttpInfo(traditionId, traditionUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdminApi.TraditionUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **traditionId** | **int** | Идентификатор традиции в адресе. |  |
| **traditionUpdateRequest** | [**TraditionUpdateRequest**](TraditionUpdateRequest.md) |  |  |

### Return type

[**Tradition**](Tradition.md)

### Authorization

[TalentOAuth](../README.md#TalentOAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Традиция обновлена |  -  |
| **403** | Для доступа нужны права администратора |  -  |
| **404** | Традиция не найдена |  -  |
| **409** | Традиция с таким названием уже существует |  -  |

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
            var apiInstance = new AdminApi(config);
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
                Debug.Print("Exception when calling AdminApi.TraditionsList: " + e.Message);
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
    Debug.Print("Exception when calling AdminApi.TraditionsListWithHttpInfo: " + e.Message);
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

