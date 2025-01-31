# Org.OpenAPITools.Api.WebApi

All URIs are relative to *https://talent.kruzhok.org/berloga-idp*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplicationsList**](WebApi.md#applicationslist) | **GET** /applications | Список приложений |
| [**TalentOAuthAuthorize**](WebApi.md#talentoauthauthorize) | **POST** /talent-oauth/authorize | Авторизация существующим токеном |

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
            var apiInstance = new WebApi(config);
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
                Debug.Print("Exception when calling WebApi.ApplicationsList: " + e.Message);
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
    Debug.Print("Exception when calling WebApi.ApplicationsListWithHttpInfo: " + e.Message);
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

<a id="talentoauthauthorize"></a>
# **TalentOAuthAuthorize**
> void TalentOAuthAuthorize (string xToken)

Авторизация существующим токеном

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TalentOAuthAuthorizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://talent.kruzhok.org/berloga-idp";
            // Configure API key authorization: BerlogaJWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebApi(config);
            var xToken = "xToken_example";  // string | TalentOAuth access_token

            try
            {
                // Авторизация существующим токеном
                apiInstance.TalentOAuthAuthorize(xToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebApi.TalentOAuthAuthorize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TalentOAuthAuthorizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Авторизация существующим токеном
    apiInstance.TalentOAuthAuthorizeWithHttpInfo(xToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebApi.TalentOAuthAuthorizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xToken** | **string** | TalentOAuth access_token |  |

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
| **0** | Ошибка обработки запроса |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

