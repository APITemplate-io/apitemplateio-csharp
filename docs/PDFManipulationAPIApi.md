# APITemplateio.Api.PDFManipulationAPIApi

All URIs are relative to *https://rest.apitemplate.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MergePdfs**](PDFManipulationAPIApi.md#mergepdfs) | **POST** /v2/merge-pdfs | Join/Merge multiple PDFs |

<a id="mergepdfs"></a>
# **MergePdfs**
> ResponseSuccessSingleFile MergePdfs (MergePdfsRequest mergePdfsRequest, string? postactionS3Filekey = null, string? postactionS3Bucket = null, string? meta = null)

Join/Merge multiple PDFs

This endpoint merges/joins multiple PDF URLs into a single PDF file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class MergePdfsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PDFManipulationAPIApi(config);
            var mergePdfsRequest = new MergePdfsRequest(); // MergePdfsRequest | 
            var postactionS3Filekey = "postactionS3Filekey_example";  // string? | - This is to specify the file name for `Post Action(S3 Storage)`. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  (optional) 
            var postactionS3Bucket = "postactionS3Bucket_example";  // string? | - This is to overwrite the AWS Bucket for `Post Action(S3 Storage)`.  (optional) 
            var meta = inv-iwj343jospig;  // string? | - Specify an external reference ID for your own reference. It appears in the `list-objects` API.  (optional) 

            try
            {
                // Join/Merge multiple PDFs
                ResponseSuccessSingleFile result = apiInstance.MergePdfs(mergePdfsRequest, postactionS3Filekey, postactionS3Bucket, meta);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PDFManipulationAPIApi.MergePdfs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MergePdfsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Join/Merge multiple PDFs
    ApiResponse<ResponseSuccessSingleFile> response = apiInstance.MergePdfsWithHttpInfo(mergePdfsRequest, postactionS3Filekey, postactionS3Bucket, meta);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PDFManipulationAPIApi.MergePdfsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mergePdfsRequest** | [**MergePdfsRequest**](MergePdfsRequest.md) |  |  |
| **postactionS3Filekey** | **string?** | - This is to specify the file name for &#x60;Post Action(S3 Storage)&#x60;. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  | [optional]  |
| **postactionS3Bucket** | **string?** | - This is to overwrite the AWS Bucket for &#x60;Post Action(S3 Storage)&#x60;.  | [optional]  |
| **meta** | **string?** | - Specify an external reference ID for your own reference. It appears in the &#x60;list-objects&#x60; API.  | [optional]  |

### Return type

[**ResponseSuccessSingleFile**](ResponseSuccessSingleFile.md)

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

