# APITemplateio.Api.TemplateManagementApi

All URIs are relative to *https://rest.apitemplate.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTemplate**](TemplateManagementApi.md#gettemplate) | **GET** /v2/get-template | Get PDF template |
| [**ListTemplates**](TemplateManagementApi.md#listtemplates) | **GET** /v2/list-templates | List Templates |
| [**UpdateTemplate**](TemplateManagementApi.md#updatetemplate) | **POST** /v2/update-template | Update PDF Template |

<a id="gettemplate"></a>
# **GetTemplate**
> ResponseSuccessTemplate GetTemplate (string? templateId = null)

Get PDF template

Retrieves information of the PDF template (**This is an experimental API, contact support to learn more**) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new TemplateManagementApi(config);
            var templateId = 00377b2b1e0ee394;  // string? | Your template id, it can be obtained in the web console(Manage Templates) (optional) 

            try
            {
                // Get PDF template
                ResponseSuccessTemplate result = apiInstance.GetTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateManagementApi.GetTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get PDF template
    ApiResponse<ResponseSuccessTemplate> response = apiInstance.GetTemplateWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateManagementApi.GetTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string?** | Your template id, it can be obtained in the web console(Manage Templates) | [optional]  |

### Return type

[**ResponseSuccessTemplate**](ResponseSuccessTemplate.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns status and template information |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtemplates"></a>
# **ListTemplates**
> ResponseSuccessListTemplates ListTemplates (string? limit = null, string? offset = null, string? format = null, string? templateId = null, string? groupName = null, string? withLayerInfo = null)

List Templates

Retrieves the information of templates 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class ListTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new TemplateManagementApi(config);
            var limit = 300;  // string? | Retrieve only the number of records specified. Default to 300 (optional) 
            var offset = 0;  // string? | Offset is used to skip the number of records from the results. Default to 0 (optional) 
            var format = JPEG;  // string? | To filter the templates by either 'PDF' or 'JPEG' (optional) 
            var templateId = 00377b2b1e0ee394;  // string? | To filter the templates by template id (optional) 
            var groupName = custom;  // string? | To filter the templates by the group name (optional) 
            var withLayerInfo = 0;  // string? | Return along with layer information for image templates, 0=false , 1=true. Default to '0' (optional) 

            try
            {
                // List Templates
                ResponseSuccessListTemplates result = apiInstance.ListTemplates(limit, offset, format, templateId, groupName, withLayerInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateManagementApi.ListTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Templates
    ApiResponse<ResponseSuccessListTemplates> response = apiInstance.ListTemplatesWithHttpInfo(limit, offset, format, templateId, groupName, withLayerInfo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateManagementApi.ListTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **string?** | Retrieve only the number of records specified. Default to 300 | [optional]  |
| **offset** | **string?** | Offset is used to skip the number of records from the results. Default to 0 | [optional]  |
| **format** | **string?** | To filter the templates by either &#39;PDF&#39; or &#39;JPEG&#39; | [optional]  |
| **templateId** | **string?** | To filter the templates by template id | [optional]  |
| **groupName** | **string?** | To filter the templates by the group name | [optional]  |
| **withLayerInfo** | **string?** | Return along with layer information for image templates, 0&#x3D;false , 1&#x3D;true. Default to &#39;0&#39; | [optional]  |

### Return type

[**ResponseSuccessListTemplates**](ResponseSuccessListTemplates.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns status and output file |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> ResponseSuccess UpdateTemplate (UpdateTemplateRequest updateTemplateRequest)

Update PDF Template

This endpoint updates PDF template (**This is an experimental API, contact support to learn more**)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class UpdateTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new TemplateManagementApi(config);
            var updateTemplateRequest = new UpdateTemplateRequest(); // UpdateTemplateRequest | 

            try
            {
                // Update PDF Template
                ResponseSuccess result = apiInstance.UpdateTemplate(updateTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateManagementApi.UpdateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update PDF Template
    ApiResponse<ResponseSuccess> response = apiInstance.UpdateTemplateWithHttpInfo(updateTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateManagementApi.UpdateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateTemplateRequest** | [**UpdateTemplateRequest**](UpdateTemplateRequest.md) |  |  |

### Return type

[**ResponseSuccess**](ResponseSuccess.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns status and output file |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

