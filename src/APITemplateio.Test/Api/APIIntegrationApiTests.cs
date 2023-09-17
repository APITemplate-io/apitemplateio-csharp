/*
 * APITemplate.io API Reference
 *
 * # Introduction   Welcome to the APITemplate.io API v2!  APITemplate.io provides PDF generation services including [Template-based PDF generation](https://apitemplate.io/pdf-generation-api/), [HTML to PDF](https://apitemplate.io/html-to-pdf-api/), and [URL to PDF conversions](https://apitemplate.io/create-pdf-from-url/), as well as an [image generation API](https://apitemplate.io/image-generation-api/).  This page contains the documentation on how to use APITemplate.io through API calls. With the APITemplate.io API, you can create PDF documents and images, as well as manage your templates.  Our API is built on RESTful HTTP, so you can utilize any HTTP/REST library of your choice in your preferred programming language to interact with APITemplate.io's API.  **Steps to produce PDFs/Images** 1. Design your template(s) using our intuitive drag-and-drop template editor or the HTML editor and save it. 2. Integrate your workflow, either with platforms like Zapier, Make.com/Integromat, Bubble.io, or any programming languages that support REST API, to send us the JSON data along with the template ID/URL/or HTML content. 3. Our REST API will then return a download URL for the images (in PNG and JPEG formats) or PDFs.  # Authentication Upon signing up for an account, an API key will be generated for you. If needed, you can reset this API key via the web console (under the \"API Integration\" section).  To integrate with our services, you need to authenticate with the APITemplate.io API. Provide your secret key in the request header using the X-API-KEY field.   # Content Type and CORS  **Request Content-Type** The Content-Type for POST and GET requests is set to application/json.  **Cross-Origin Resource Sharing** This API features Cross-Origin Resource Sharing (CORS) implemented in compliance with  [W3C spec](https://www.w3.org/TR/cors/). And that allows cross-domain communication from the browser. All responses have a wildcard same-origin which makes them completely public and accessible to everyone, including any code on any site.    # Regional API endpoint(s) A regional API endpoint is intended for customers in the same region. The data for the request and generated PDFs/images are processed and stored within the region.  The regions are:  | Region               | Endpoint                            | Max Timeout (Seconds) | Max Payload Size(MB)** | |- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- --| | Default (Singapore)  | https://rest.apitemplate.io         | 100                   | 1                       | | Europe (Frankfurt)   | https://rest-de.apitemplate.io      | 100                   | 1                       | | US East (N. Virginia)| https://rest-us.apitemplate.io      | 100                   | 1                       | | Australia (Sydney)   | https://rest-au.apitemplate.io      | 30                    | 6                       |   Alternative Regions: | Region               | Endpoint                            | Max Timeout (Seconds) | Max Payload Size(MB)** | |- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- --| | Default (Singapore)  | https://rest-alt.apitemplate.io     | 30                    | 6                       | | Europe (Frankfurt)   | https://rest-alt-de.apitemplate.io  | 30                    | 6                       | | US East (N. Virginia)| https://rest-alt-us.apitemplate.io  | 30                    | 6                       |  ** Note: - Payload size applies to request and response - If \"export_type\" is set to `json` which output file that on AWS S3 doesn't have the limitation - If the \"export_type\" is set to `file` which returns binary data of the generated PDF, the file size of the generated PDF is limited to either 6MB or 1MB based on the region    Other regions are available on request, contact us at hello@apitemplate.io for more information  # Rate limiting Our API endpoints use IP-based rate limiting to ensure fair usage and prevent abuse. Users are allowed to make up to **100 requests per 10 seconds**. This rate limit is designed to accommodate a reasonable volume of requests while maintaining optimal performance for all users.  However, if you exceed this limit and make additional requests, you will receive a response with HTTP code 429. This status code indicates that you have reached the rate limit and need to wait before making further requests. 
 *
 * The version of the OpenAPI document: Version 2.0
 * Contact: hello@apitemplate.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using APITemplateio.Client;
using APITemplateio.Api;
// uncomment below to import models
//using APITemplateio.Model;

namespace APITemplateio.Test.Api
{
    /// <summary>
    ///  Class for testing APIIntegrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class APIIntegrationApiTests : IDisposable
    {
        private APIIntegrationApi instance;

        public APIIntegrationApiTests()
        {
            instance = new APIIntegrationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APIIntegrationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' APIIntegrationApi
            //Assert.IsType<APIIntegrationApi>(instance);
        }

        /// <summary>
        /// Test CreateImage
        /// </summary>
        [Fact]
        public void CreateImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //Object body = null;
            //string? outputImageType = null;
            //int? expiration = null;
            //int? cloudStorage = null;
            //string? postactionS3Filekey = null;
            //string? postactionS3Bucket = null;
            //string? meta = null;
            //var response = instance.CreateImage(templateId, body, outputImageType, expiration, cloudStorage, postactionS3Filekey, postactionS3Bucket, meta);
            //Assert.IsType<ResponseSuccessImageFile>(response);
        }

        /// <summary>
        /// Test CreatePdf
        /// </summary>
        [Fact]
        public void CreatePdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //Object body = null;
            //string? exportType = null;
            //int? expiration = null;
            //string? outputHtml = null;
            //string? outputFormat = null;
            //string? filename = null;
            //string? imageResampleRes = null;
            //string? isCmyk = null;
            //int? cloudStorage = null;
            //string? pdfStandard = null;
            //string? postactionS3Filekey = null;
            //string? postactionS3Bucket = null;
            //string? meta = null;
            //string? async = null;
            //string? webhookUrl = null;
            //var response = instance.CreatePdf(templateId, body, exportType, expiration, outputHtml, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
            //Assert.IsType<ResponseSuccessPDFFile>(response);
        }

        /// <summary>
        /// Test CreatePdfFromHtml
        /// </summary>
        [Fact]
        public void CreatePdfFromHtmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreatePdfFromHtmlRequest createPdfFromHtmlRequest = null;
            //string? exportType = null;
            //int? expiration = null;
            //string? outputFormat = null;
            //string? filename = null;
            //string? imageResampleRes = null;
            //string? isCmyk = null;
            //int? cloudStorage = null;
            //string? pdfStandard = null;
            //string? postactionS3Filekey = null;
            //string? postactionS3Bucket = null;
            //string? meta = null;
            //string? async = null;
            //string? webhookUrl = null;
            //var response = instance.CreatePdfFromHtml(createPdfFromHtmlRequest, exportType, expiration, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
            //Assert.IsType<ResponseSuccessPDFFile>(response);
        }

        /// <summary>
        /// Test CreatePdfFromUrl
        /// </summary>
        [Fact]
        public void CreatePdfFromUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreatePdfFromUrlRequest createPdfFromUrlRequest = null;
            //string? exportType = null;
            //int? expiration = null;
            //string? outputFormat = null;
            //string? filename = null;
            //string? imageResampleRes = null;
            //string? isCmyk = null;
            //int? cloudStorage = null;
            //string? pdfStandard = null;
            //string? postactionS3Filekey = null;
            //string? postactionS3Bucket = null;
            //string? meta = null;
            //string? async = null;
            //string? webhookUrl = null;
            //var response = instance.CreatePdfFromUrl(createPdfFromUrlRequest, exportType, expiration, outputFormat, filename, imageResampleRes, isCmyk, cloudStorage, pdfStandard, postactionS3Filekey, postactionS3Bucket, meta, async, webhookUrl);
            //Assert.IsType<ResponseSuccessPDFFile>(response);
        }

        /// <summary>
        /// Test DeleteObject
        /// </summary>
        [Fact]
        public void DeleteObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string transactionRef = null;
            //var response = instance.DeleteObject(transactionRef);
            //Assert.IsType<ResponseSuccessDeleteObject>(response);
        }

        /// <summary>
        /// Test ListObjects
        /// </summary>
        [Fact]
        public void ListObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? limit = null;
            //string? offset = null;
            //string? templateId = null;
            //string? transactionType = null;
            //var response = instance.ListObjects(limit, offset, templateId, transactionType);
            //Assert.IsType<ResponseSuccessListObjects>(response);
        }
    }
}
