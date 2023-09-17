# APITemplateio.Api.APIIntegrationApi

All URIs are relative to *https://rest.apitemplate.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateImage**](APIIntegrationApi.md#createimage) | **POST** /v2/create-image | Create an Image |
| [**CreatePdf**](APIIntegrationApi.md#createpdf) | **POST** /v2/create-pdf | Create a PDF |
| [**CreatePdfFromHtml**](APIIntegrationApi.md#createpdffromhtml) | **POST** /v2/create-pdf-from-html | Create a PDF from HTML |
| [**CreatePdfFromUrl**](APIIntegrationApi.md#createpdffromurl) | **POST** /v2/create-pdf-from-url | Create a PDF from URL |
| [**DeleteObject**](APIIntegrationApi.md#deleteobject) | **GET** /v2/delete-object | Delete an Object |
| [**ListObjects**](APIIntegrationApi.md#listobjects) | **GET** /v2/list-objects | List Generated Objects |

<a id="createimage"></a>
# **CreateImage**
> ResponseSuccessImageFile CreateImage (string templateId, Object body, string? outputImageType = null, int? expiration = null, int? cloudStorage = null, string? postactionS3Filekey = null, string? postactionS3Bucket = null, string? meta = null)

Create an Image

This endpoint creates a JPEG file(along with PNG) with JSON data and your template 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class CreateImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new APIIntegrationApi(config);
            var templateId = 00377b2b1e0ee394;  // string | Your template id, it can be obtained in the web console
            var body = null;  // Object | 
            var outputImageType = 1;  // string? | - Output image type(JPEG or PNG format), default to `all`. Options are `all`, `jpegOnly`,`pngOnly`.  (optional) 
            var expiration = 5;  // int? | - Expiration of the generated PDF in minutes(default to `0`, store permanently)   - Use `0` to store on cdn permanently   - Or use the range between `1` minute and `10080` minutes(7 days) to specify the expiration of the generated PDF  (optional) 
            var cloudStorage = 1;  // int? | - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.  (optional) 
            var postactionS3Filekey = "postactionS3Filekey_example";  // string? | - This is to specify the file name for `Post Action(S3 Storage)`. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  (optional) 
            var postactionS3Bucket = "postactionS3Bucket_example";  // string? | - This is to overwrite the AWS Bucket for `Post Action(S3 Storage)`.  (optional) 
            var meta = inv-iwj343jospig;  // string? | - Specify an external reference ID for your own reference. It appears in the `list-objects` API.  (optional) 

            try
            {
                // Create an Image
                ResponseSuccessImageFile result = apiInstance.CreateImage(templateId, body, outputImageType, expiration, cloudStorage, postactionS3Filekey, postactionS3Bucket, meta);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIIntegrationApi.CreateImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an Image
    ApiResponse<ResponseSuccessImageFile> response = apiInstance.CreateImageWithHttpInfo(templateId, body, outputImageType, expiration, cloudStorage, postactionS3Filekey, postactionS3Bucket, meta);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIIntegrationApi.CreateImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | Your template id, it can be obtained in the web console |  |
| **body** | **Object** |  |  |
| **outputImageType** | **string?** | - Output image type(JPEG or PNG format), default to &#x60;all&#x60;. Options are &#x60;all&#x60;, &#x60;jpegOnly&#x60;,&#x60;pngOnly&#x60;.  | [optional]  |
| **expiration** | **int?** | - Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;10080&#x60; minutes(7 days) to specify the expiration of the generated PDF  | [optional]  |
| **cloudStorage** | **int?** | - Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;.  | [optional]  |
| **postactionS3Filekey** | **string?** | - This is to specify the file name for &#x60;Post Action(S3 Storage)&#x60;. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  | [optional]  |
| **postactionS3Bucket** | **string?** | - This is to overwrite the AWS Bucket for &#x60;Post Action(S3 Storage)&#x60;.  | [optional]  |
| **meta** | **string?** | - Specify an external reference ID for your own reference. It appears in the &#x60;list-objects&#x60; API.  | [optional]  |

### Return type

[**ResponseSuccessImageFile**](ResponseSuccessImageFile.md)

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

<a id="createpdf"></a>
# **CreatePdf**
> ResponseSuccessPDFFile CreatePdf (string templateId, Object body, string? exportType = null, int? expiration = null, string? outputHtml = null, string? outputFormat = null, string? filename = null, string? imageResampleRes = null, string? isCmyk = null, int? cloudStorage = null, string? pdfStandard = null, string? postactionS3Filekey = null, string? postactionS3Bucket = null, string? meta = null, string? async = null, string? webhookUrl = null)

Create a PDF

This endpoint creates a PDF file with JSON data and your template. We support synchoronus and asynchronous PDF generation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class CreatePdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new APIIntegrationApi(config);
            var templateId = 00377b2b1e0ee394;  // string | Your template id, it can be obtained in the web console
            var body = null;  // Object | 
            var exportType = json;  // string? | - Either `file` or `json`(Default).   - The option `json` returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter `expiration`   - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.  (optional) 
            var expiration = 5;  // int? | - Expiration of the generated PDF in minutes(default to `0`, store permanently)   - Use `0` to store on cdn permanently   - Or use the range between `1` minute and `10080` minutes(7 days) to specify the expiration of the generated PDF  (optional) 
            var outputHtml = 0;  // string? | - Either `1` or `0`(Default). - To enable output of html content, set the value to `1` and it will return in the JSON response as html_url field (as a URL)  (optional) 
            var outputFormat = pdf;  // string? | - Either `pdf`(Default) or `html`. - It's generating PDF by default. However, you can specify output_format=html to generate only HTML(It will return in the JSON response as download_url field as a URL).  (optional) 
            var filename = invoice_89326.pdf;  // string? | - Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with `.pdf`  (optional) 
            var imageResampleRes = 150;  // string? | - We embed the original images by default, meaning large PDF file sizes. Specifying the option 'image_resample_res' helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.  (optional) 
            var isCmyk = 0;  // string? | - Use CMYK color profile, 1=true, 0=false. Default to '0'  (optional) 
            var cloudStorage = 1;  // int? | - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.  (optional) 
            var pdfStandard = "pdfStandard_example";  // string? | Default to PDF1.4. Options are PDFA1B, PDFA2 and PDFA3 (This is an experimental feature)  (optional) 
            var postactionS3Filekey = "postactionS3Filekey_example";  // string? | - This is to specify the file name for `Post Action(S3 Storage)`. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  (optional) 
            var postactionS3Bucket = "postactionS3Bucket_example";  // string? | - This is to overwrite the AWS Bucket for `Post Action(S3 Storage)`.  (optional) 
            var meta = inv-iwj343jospig;  // string? | - Specify an external reference ID for your own reference. It appears in the `list-objects` API.  (optional) 
            var async = 0;  // string? | - Either `1` or `0`(Default).  `0` is synchronous call(default), `1` is asynchronous call - To generate PDF asynchronously, set the value to `1` and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up. - If `async` is set to `1`, then `webhook_url` is mandatory  (optional) 
            var webhookUrl = https://yourwebserver.com;  // string? | - It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded. - If `async` is set to `1`, then you have to specify the `webhook_url`.   #### Format of Webhook callback  Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:  https://`[yourwebserver.com]`?&primary_url=`[primary_url]`&transaction_ref=`[transaction_ref]`&status=`[status]`&message=`[message]`  - `[yourwebserver.com]`: The web services to handle the callback, which is the `webhook_url` - `[primary_url]`: The URL to the PDF document - `[transaction_ref]`: The transaction reference number - `[status]` : Status of the transaction, either `success` or `error` - `[message]` : Status message  ***The following is a sample webhook call back to your server***  https://yourwebserver.com?&primary_url=https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&transaction_ref=b692183d-46d7-3213-891a-460a5814ad3f&status=success  (optional) 

            try
            {
                // Create a PDF
                ResponseSuccessPDFFile result = apiInstance.CreatePdf(templateId, body, exportType, expiration, outputHtml, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIIntegrationApi.CreatePdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a PDF
    ApiResponse<ResponseSuccessPDFFile> response = apiInstance.CreatePdfWithHttpInfo(templateId, body, exportType, expiration, outputHtml, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIIntegrationApi.CreatePdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | Your template id, it can be obtained in the web console |  |
| **body** | **Object** |  |  |
| **exportType** | **string?** | - Either &#x60;file&#x60; or &#x60;json&#x60;(Default).   - The option &#x60;json&#x60; returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter &#x60;expiration&#x60;   - The option &#x60;file&#x60; returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.  | [optional]  |
| **expiration** | **int?** | - Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;10080&#x60; minutes(7 days) to specify the expiration of the generated PDF  | [optional]  |
| **outputHtml** | **string?** | - Either &#x60;1&#x60; or &#x60;0&#x60;(Default). - To enable output of html content, set the value to &#x60;1&#x60; and it will return in the JSON response as html_url field (as a URL)  | [optional]  |
| **outputFormat** | **string?** | - Either &#x60;pdf&#x60;(Default) or &#x60;html&#x60;. - It&#39;s generating PDF by default. However, you can specify output_format&#x3D;html to generate only HTML(It will return in the JSON response as download_url field as a URL).  | [optional]  |
| **filename** | **string?** | - Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with &#x60;.pdf&#x60;  | [optional]  |
| **imageResampleRes** | **string?** | - We embed the original images by default, meaning large PDF file sizes. Specifying the option &#39;image_resample_res&#39; helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.  | [optional]  |
| **isCmyk** | **string?** | - Use CMYK color profile, 1&#x3D;true, 0&#x3D;false. Default to &#39;0&#39;  | [optional]  |
| **cloudStorage** | **int?** | - Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;.  | [optional]  |
| **pdfStandard** | **string?** | Default to PDF1.4. Options are PDFA1B, PDFA2 and PDFA3 (This is an experimental feature)  | [optional]  |
| **postactionS3Filekey** | **string?** | - This is to specify the file name for &#x60;Post Action(S3 Storage)&#x60;. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  | [optional]  |
| **postactionS3Bucket** | **string?** | - This is to overwrite the AWS Bucket for &#x60;Post Action(S3 Storage)&#x60;.  | [optional]  |
| **meta** | **string?** | - Specify an external reference ID for your own reference. It appears in the &#x60;list-objects&#x60; API.  | [optional]  |
| **async** | **string?** | - Either &#x60;1&#x60; or &#x60;0&#x60;(Default).  &#x60;0&#x60; is synchronous call(default), &#x60;1&#x60; is asynchronous call - To generate PDF asynchronously, set the value to &#x60;1&#x60; and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up. - If &#x60;async&#x60; is set to &#x60;1&#x60;, then &#x60;webhook_url&#x60; is mandatory  | [optional]  |
| **webhookUrl** | **string?** | - It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded. - If &#x60;async&#x60; is set to &#x60;1&#x60;, then you have to specify the &#x60;webhook_url&#x60;.   #### Format of Webhook callback  Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:  https://&#x60;[yourwebserver.com]&#x60;?&amp;primary_url&#x3D;&#x60;[primary_url]&#x60;&amp;transaction_ref&#x3D;&#x60;[transaction_ref]&#x60;&amp;status&#x3D;&#x60;[status]&#x60;&amp;message&#x3D;&#x60;[message]&#x60;  - &#x60;[yourwebserver.com]&#x60;: The web services to handle the callback, which is the &#x60;webhook_url&#x60; - &#x60;[primary_url]&#x60;: The URL to the PDF document - &#x60;[transaction_ref]&#x60;: The transaction reference number - &#x60;[status]&#x60; : Status of the transaction, either &#x60;success&#x60; or &#x60;error&#x60; - &#x60;[message]&#x60; : Status message  ***The following is a sample webhook call back to your server***  https://yourwebserver.com?&amp;primary_url&#x3D;https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&amp;transaction_ref&#x3D;b692183d-46d7-3213-891a-460a5814ad3f&amp;status&#x3D;success  | [optional]  |

### Return type

[**ResponseSuccessPDFFile**](ResponseSuccessPDFFile.md)

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

<a id="createpdffromhtml"></a>
# **CreatePdfFromHtml**
> ResponseSuccessPDFFile CreatePdfFromHtml (CreatePdfFromHtmlRequest createPdfFromHtmlRequest, string? exportType = null, int? expiration = null, string? outputFormat = null, string? filename = null, string? imageResampleRes = null, string? isCmyk = null, int? cloudStorage = null, string? pdfStandard = null, string? postactionS3Filekey = null, string? postactionS3Bucket = null, string? meta = null, string? async = null, string? webhookUrl = null)

Create a PDF from HTML

- This endpoint creates a PDF file from HTML with JSON data 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class CreatePdfFromHtmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new APIIntegrationApi(config);
            var createPdfFromHtmlRequest = new CreatePdfFromHtmlRequest(); // CreatePdfFromHtmlRequest | 
            var exportType = json;  // string? | - Either `file` or `json`(Default).   - The option `json` returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter `expiration`   - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.  (optional) 
            var expiration = 5;  // int? | - Expiration of the generated PDF in minutes(default to `0`, store permanently)   - Use `0` to store on cdn permanently   - Or use the range between `1` minute and `10080` minutes(7 days) to specify the expiration of the generated PDF  (optional) 
            var outputFormat = pdf;  // string? | - Either `pdf`(Default) or `html`. - It's generating PDF by default. However, you can specify output_format=html to generate only HTML(It will return in the JSON response as download_url field as a URL).  (optional) 
            var filename = invoice_89326.pdf;  // string? | - Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with `.pdf`  (optional) 
            var imageResampleRes = 150;  // string? | - We embed the original images by default, meaning large PDF file sizes. Specifying the option 'image_resample_res' helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.  (optional) 
            var isCmyk = 0;  // string? | - Use CMYK color profile, 1=true, 0=false. Default to '0'  (optional) 
            var cloudStorage = 1;  // int? | - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.  (optional) 
            var pdfStandard = "pdfStandard_example";  // string? | Default to PDF1.4. Options are PDFA1B, PDFA2 and PDFA3 (This is an experimental feature)  (optional) 
            var postactionS3Filekey = "postactionS3Filekey_example";  // string? | - This is to specify the file name for `Post Action(S3 Storage)`. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  (optional) 
            var postactionS3Bucket = "postactionS3Bucket_example";  // string? | - This is to overwrite the AWS Bucket for `Post Action(S3 Storage)`.  (optional) 
            var meta = inv-iwj343jospig;  // string? | - Specify an external reference ID for your own reference. It appears in the `list-objects` API.  (optional) 
            var async = 0;  // string? | - Either `1` or `0`(Default).  `0` is synchronous call(default), `1` is asynchronous call - To generate PDF asynchronously, set the value to `1` and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up. - If `async` is set to `1`, then `webhook_url` is mandatory  (optional) 
            var webhookUrl = https://yourwebserver.com;  // string? | - It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded. - If `async` is set to `1`, then you have to specify the `webhook_url`.   #### Format of Webhook callback  Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:  https://`[yourwebserver.com]`?&primary_url=`[primary_url]`&transaction_ref=`[transaction_ref]`&status=`[status]`&message=`[message]`  - `[yourwebserver.com]`: The web services to handle the callback, which is the `webhook_url` - `[primary_url]`: The URL to the PDF document - `[transaction_ref]`: The transaction reference number - `[status]` : Status of the transaction, either `success` or `error` - `[message]` : Status message  ***The following is a sample webhook call back to your server***  https://yourwebserver.com?&primary_url=https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&transaction_ref=b692183d-46d7-3213-891a-460a5814ad3f&status=success  (optional) 

            try
            {
                // Create a PDF from HTML
                ResponseSuccessPDFFile result = apiInstance.CreatePdfFromHtml(createPdfFromHtmlRequest, exportType, expiration, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIIntegrationApi.CreatePdfFromHtml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePdfFromHtmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a PDF from HTML
    ApiResponse<ResponseSuccessPDFFile> response = apiInstance.CreatePdfFromHtmlWithHttpInfo(createPdfFromHtmlRequest, exportType, expiration, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIIntegrationApi.CreatePdfFromHtmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPdfFromHtmlRequest** | [**CreatePdfFromHtmlRequest**](CreatePdfFromHtmlRequest.md) |  |  |
| **exportType** | **string?** | - Either &#x60;file&#x60; or &#x60;json&#x60;(Default).   - The option &#x60;json&#x60; returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter &#x60;expiration&#x60;   - The option &#x60;file&#x60; returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.  | [optional]  |
| **expiration** | **int?** | - Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;10080&#x60; minutes(7 days) to specify the expiration of the generated PDF  | [optional]  |
| **outputFormat** | **string?** | - Either &#x60;pdf&#x60;(Default) or &#x60;html&#x60;. - It&#39;s generating PDF by default. However, you can specify output_format&#x3D;html to generate only HTML(It will return in the JSON response as download_url field as a URL).  | [optional]  |
| **filename** | **string?** | - Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with &#x60;.pdf&#x60;  | [optional]  |
| **imageResampleRes** | **string?** | - We embed the original images by default, meaning large PDF file sizes. Specifying the option &#39;image_resample_res&#39; helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.  | [optional]  |
| **isCmyk** | **string?** | - Use CMYK color profile, 1&#x3D;true, 0&#x3D;false. Default to &#39;0&#39;  | [optional]  |
| **cloudStorage** | **int?** | - Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;.  | [optional]  |
| **pdfStandard** | **string?** | Default to PDF1.4. Options are PDFA1B, PDFA2 and PDFA3 (This is an experimental feature)  | [optional]  |
| **postactionS3Filekey** | **string?** | - This is to specify the file name for &#x60;Post Action(S3 Storage)&#x60;. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  | [optional]  |
| **postactionS3Bucket** | **string?** | - This is to overwrite the AWS Bucket for &#x60;Post Action(S3 Storage)&#x60;.  | [optional]  |
| **meta** | **string?** | - Specify an external reference ID for your own reference. It appears in the &#x60;list-objects&#x60; API.  | [optional]  |
| **async** | **string?** | - Either &#x60;1&#x60; or &#x60;0&#x60;(Default).  &#x60;0&#x60; is synchronous call(default), &#x60;1&#x60; is asynchronous call - To generate PDF asynchronously, set the value to &#x60;1&#x60; and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up. - If &#x60;async&#x60; is set to &#x60;1&#x60;, then &#x60;webhook_url&#x60; is mandatory  | [optional]  |
| **webhookUrl** | **string?** | - It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded. - If &#x60;async&#x60; is set to &#x60;1&#x60;, then you have to specify the &#x60;webhook_url&#x60;.   #### Format of Webhook callback  Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:  https://&#x60;[yourwebserver.com]&#x60;?&amp;primary_url&#x3D;&#x60;[primary_url]&#x60;&amp;transaction_ref&#x3D;&#x60;[transaction_ref]&#x60;&amp;status&#x3D;&#x60;[status]&#x60;&amp;message&#x3D;&#x60;[message]&#x60;  - &#x60;[yourwebserver.com]&#x60;: The web services to handle the callback, which is the &#x60;webhook_url&#x60; - &#x60;[primary_url]&#x60;: The URL to the PDF document - &#x60;[transaction_ref]&#x60;: The transaction reference number - &#x60;[status]&#x60; : Status of the transaction, either &#x60;success&#x60; or &#x60;error&#x60; - &#x60;[message]&#x60; : Status message  ***The following is a sample webhook call back to your server***  https://yourwebserver.com?&amp;primary_url&#x3D;https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&amp;transaction_ref&#x3D;b692183d-46d7-3213-891a-460a5814ad3f&amp;status&#x3D;success  | [optional]  |

### Return type

[**ResponseSuccessPDFFile**](ResponseSuccessPDFFile.md)

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

<a id="createpdffromurl"></a>
# **CreatePdfFromUrl**
> ResponseSuccessPDFFile CreatePdfFromUrl (CreatePdfFromUrlRequest createPdfFromUrlRequest, string? exportType = null, int? expiration = null, string? outputFormat = null, string? filename = null, string? imageResampleRes = null, string? isCmyk = null, int? cloudStorage = null, string? pdfStandard = null, string? postactionS3Filekey = null, string? postactionS3Bucket = null, string? meta = null, string? async = null, string? webhookUrl = null)

Create a PDF from URL

- This endpoint creates a PDF file from a URL 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class CreatePdfFromUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new APIIntegrationApi(config);
            var createPdfFromUrlRequest = new CreatePdfFromUrlRequest(); // CreatePdfFromUrlRequest | 
            var exportType = json;  // string? | - Either `file` or `json`(Default).   - The option `json` returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter `expiration`   - The option `file` returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.  (optional) 
            var expiration = 5;  // int? | - Expiration of the generated PDF in minutes(default to `0`, store permanently)   - Use `0` to store on cdn permanently   - Or use the range between `1` minute and `10080` minutes(7 days) to specify the expiration of the generated PDF  (optional) 
            var outputFormat = pdf;  // string? | - Either `pdf`(Default) or `html`. - It's generating PDF by default. However, you can specify output_format=html to generate only HTML(It will return in the JSON response as download_url field as a URL).  (optional) 
            var filename = invoice_89326.pdf;  // string? | - Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with `.pdf`  (optional) 
            var imageResampleRes = 150;  // string? | - We embed the original images by default, meaning large PDF file sizes. Specifying the option 'image_resample_res' helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.  (optional) 
            var isCmyk = 0;  // string? | - Use CMYK color profile, 1=true, 0=false. Default to '0'  (optional) 
            var cloudStorage = 1;  // int? | - Upload the generated PDFs/images to our storage CDN, default to `1`. If you have configured `Post Action` to upload the PDFs/Images to your own S3, please set it to `0`.  (optional) 
            var pdfStandard = "pdfStandard_example";  // string? | Default to PDF1.4. Options are PDFA1B, PDFA2 and PDFA3 (This is an experimental feature)  (optional) 
            var postactionS3Filekey = "postactionS3Filekey_example";  // string? | - This is to specify the file name for `Post Action(S3 Storage)`. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  (optional) 
            var postactionS3Bucket = "postactionS3Bucket_example";  // string? | - This is to overwrite the AWS Bucket for `Post Action(S3 Storage)`.  (optional) 
            var meta = inv-iwj343jospig;  // string? | - Specify an external reference ID for your own reference. It appears in the `list-objects` API.  (optional) 
            var async = 0;  // string? | - Either `1` or `0`(Default).  `0` is synchronous call(default), `1` is asynchronous call - To generate PDF asynchronously, set the value to `1` and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up. - If `async` is set to `1`, then `webhook_url` is mandatory  (optional) 
            var webhookUrl = https://yourwebserver.com;  // string? | - It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded. - If `async` is set to `1`, then you have to specify the `webhook_url`.   #### Format of Webhook callback  Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:  https://`[yourwebserver.com]`?&primary_url=`[primary_url]`&transaction_ref=`[transaction_ref]`&status=`[status]`&message=`[message]`  - `[yourwebserver.com]`: The web services to handle the callback, which is the `webhook_url` - `[primary_url]`: The URL to the PDF document - `[transaction_ref]`: The transaction reference number - `[status]` : Status of the transaction, either `success` or `error` - `[message]` : Status message  ***The following is a sample webhook call back to your server***  https://yourwebserver.com?&primary_url=https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&transaction_ref=b692183d-46d7-3213-891a-460a5814ad3f&status=success  (optional) 

            try
            {
                // Create a PDF from URL
                ResponseSuccessPDFFile result = apiInstance.CreatePdfFromUrl(createPdfFromUrlRequest, exportType, expiration, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIIntegrationApi.CreatePdfFromUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePdfFromUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a PDF from URL
    ApiResponse<ResponseSuccessPDFFile> response = apiInstance.CreatePdfFromUrlWithHttpInfo(createPdfFromUrlRequest, exportType, expiration, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIIntegrationApi.CreatePdfFromUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPdfFromUrlRequest** | [**CreatePdfFromUrlRequest**](CreatePdfFromUrlRequest.md) |  |  |
| **exportType** | **string?** | - Either &#x60;file&#x60; or &#x60;json&#x60;(Default).   - The option &#x60;json&#x60; returns a JSON object, and the output PDF is stored on a CDN. Use this with the parameter &#x60;expiration&#x60;   - The option &#x60;file&#x60; returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment.  | [optional]  |
| **expiration** | **int?** | - Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;10080&#x60; minutes(7 days) to specify the expiration of the generated PDF  | [optional]  |
| **outputFormat** | **string?** | - Either &#x60;pdf&#x60;(Default) or &#x60;html&#x60;. - It&#39;s generating PDF by default. However, you can specify output_format&#x3D;html to generate only HTML(It will return in the JSON response as download_url field as a URL).  | [optional]  |
| **filename** | **string?** | - Default to UUID (e.g 0c93bd9e-9ebb-4634-a70f-de9131848416.pdf). Use this to specify custom file name, it should end with &#x60;.pdf&#x60;  | [optional]  |
| **imageResampleRes** | **string?** | - We embed the original images by default, meaning large PDF file sizes. Specifying the option &#39;image_resample_res&#39; helps reduce the PDF file size by downsampling the images of the current PDF to a resolution(in DPI). Common values are 72, 96, 150, 300 and 600.  | [optional]  |
| **isCmyk** | **string?** | - Use CMYK color profile, 1&#x3D;true, 0&#x3D;false. Default to &#39;0&#39;  | [optional]  |
| **cloudStorage** | **int?** | - Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;.  | [optional]  |
| **pdfStandard** | **string?** | Default to PDF1.4. Options are PDFA1B, PDFA2 and PDFA3 (This is an experimental feature)  | [optional]  |
| **postactionS3Filekey** | **string?** | - This is to specify the file name for &#x60;Post Action(S3 Storage)&#x60;. - Please do not specify the file extension - Please make sure the file name is unique - You might use slash (/) as the folder delimiter  | [optional]  |
| **postactionS3Bucket** | **string?** | - This is to overwrite the AWS Bucket for &#x60;Post Action(S3 Storage)&#x60;.  | [optional]  |
| **meta** | **string?** | - Specify an external reference ID for your own reference. It appears in the &#x60;list-objects&#x60; API.  | [optional]  |
| **async** | **string?** | - Either &#x60;1&#x60; or &#x60;0&#x60;(Default).  &#x60;0&#x60; is synchronous call(default), &#x60;1&#x60; is asynchronous call - To generate PDF asynchronously, set the value to &#x60;1&#x60; and the API call returns immediately. Once the PDF document is generated, we will make a HTTP/HTTPS GET to your URL(webhook_url) and will retry for 3 times before giving up. - If &#x60;async&#x60; is set to &#x60;1&#x60;, then &#x60;webhook_url&#x60; is mandatory  | [optional]  |
| **webhookUrl** | **string?** | - It is the URL of your webhook URL, it starts with http:// or https:// and has to be urlencoded. - If &#x60;async&#x60; is set to &#x60;1&#x60;, then you have to specify the &#x60;webhook_url&#x60;.   #### Format of Webhook callback  Once the PDF is generated, we will initiate a HTTP/HTTPS GET call to the following URL:  https://&#x60;[yourwebserver.com]&#x60;?&amp;primary_url&#x3D;&#x60;[primary_url]&#x60;&amp;transaction_ref&#x3D;&#x60;[transaction_ref]&#x60;&amp;status&#x3D;&#x60;[status]&#x60;&amp;message&#x3D;&#x60;[message]&#x60;  - &#x60;[yourwebserver.com]&#x60;: The web services to handle the callback, which is the &#x60;webhook_url&#x60; - &#x60;[primary_url]&#x60;: The URL to the PDF document - &#x60;[transaction_ref]&#x60;: The transaction reference number - &#x60;[status]&#x60; : Status of the transaction, either &#x60;success&#x60; or &#x60;error&#x60; - &#x60;[message]&#x60; : Status message  ***The following is a sample webhook call back to your server***  https://yourwebserver.com?&amp;primary_url&#x3D;https%3A%2F%2Fpub-cdn.apitemplate.io%2F2021%2F06%2Fb692183d-46d7-3213-891a-460a5814ad3f.pdf&amp;transaction_ref&#x3D;b692183d-46d7-3213-891a-460a5814ad3f&amp;status&#x3D;success  | [optional]  |

### Return type

[**ResponseSuccessPDFFile**](ResponseSuccessPDFFile.md)

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

<a id="deleteobject"></a>
# **DeleteObject**
> ResponseSuccessDeleteObject DeleteObject (string transactionRef)

Delete an Object

Delete a PDF or an image from CDN and mark the transaction as deleted 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class DeleteObjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new APIIntegrationApi(config);
            var transactionRef = 1618d386-2343-3d234-b9c7-99c82bb9f104;  // string | Object transaction reference

            try
            {
                // Delete an Object
                ResponseSuccessDeleteObject result = apiInstance.DeleteObject(transactionRef);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIIntegrationApi.DeleteObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Object
    ApiResponse<ResponseSuccessDeleteObject> response = apiInstance.DeleteObjectWithHttpInfo(transactionRef);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIIntegrationApi.DeleteObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionRef** | **string** | Object transaction reference |  |

### Return type

[**ResponseSuccessDeleteObject**](ResponseSuccessDeleteObject.md)

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

<a id="listobjects"></a>
# **ListObjects**
> ResponseSuccessListObjects ListObjects (string? limit = null, string? offset = null, string? templateId = null, string? transactionType = null)

List Generated Objects

Retrieves all the generated PDFs and images 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using APITemplateio.Api;
using APITemplateio.Client;
using APITemplateio.Model;

namespace Example
{
    public class ListObjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.apitemplate.io";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new APIIntegrationApi(config);
            var limit = 300;  // string? | Retrieve only the number of records specified. Default to 300 (optional) 
            var offset = 0;  // string? | Offset is used to skip the number of records from the results. Default to 0 (optional) 
            var templateId = 00377b2b1e0ee394;  // string? | Filtered by template id (optional) 
            var transactionType = MERGE;  // string? | Filtered by transaction type, options are `PDF`, `JPEG` or `MERGE` (optional) 

            try
            {
                // List Generated Objects
                ResponseSuccessListObjects result = apiInstance.ListObjects(limit, offset, templateId, transactionType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIIntegrationApi.ListObjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListObjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Generated Objects
    ApiResponse<ResponseSuccessListObjects> response = apiInstance.ListObjectsWithHttpInfo(limit, offset, templateId, transactionType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIIntegrationApi.ListObjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **string?** | Retrieve only the number of records specified. Default to 300 | [optional]  |
| **offset** | **string?** | Offset is used to skip the number of records from the results. Default to 0 | [optional]  |
| **templateId** | **string?** | Filtered by template id | [optional]  |
| **transactionType** | **string?** | Filtered by transaction type, options are &#x60;PDF&#x60;, &#x60;JPEG&#x60; or &#x60;MERGE&#x60; | [optional]  |

### Return type

[**ResponseSuccessListObjects**](ResponseSuccessListObjects.md)

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

