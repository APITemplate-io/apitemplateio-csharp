/*
 * APITemplate.io API Reference
 *
 * # Introduction   Welcome to the [APITemplate.io](https://apitemplate.io) API v2!  APITemplate.io provides PDF generation services including [Template-based PDF generation](https://apitemplate.io/pdf-generation-api/), [HTML to PDF](https://apitemplate.io/html-to-pdf-api/), and [URL to PDF conversions](https://apitemplate.io/create-pdf-from-url/), as well as an [image generation API](https://apitemplate.io/image-generation-api/).  This page contains the documentation on how to use APITemplate.io through API calls. With the APITemplate.io API, you can create PDF documents and images, as well as manage your templates.  Our API is built on RESTful HTTP, so you can utilize any HTTP/REST library of your choice in your preferred programming language to interact with APITemplate.io's API.  **Steps to produce PDFs/Images** 1. Design your template(s) using our intuitive drag-and-drop template editor or the HTML editor and save it. 2. Integrate your workflow, either with platforms like Zapier, Make.com/Integromat, Bubble.io, or any programming languages that support REST API, to send us the JSON data along with the template ID/URL/or HTML content. 3. Our REST API will then return a download URL for the images (in PNG and JPEG formats) or PDFs.  # Authentication Upon signing up for an account, an API key will be generated for you. If needed, you can reset this API key via the web console (under the \"API Integration\" section).  To integrate with our services, you need to authenticate with the APITemplate.io API. Provide your secret key in the request header using the X-API-KEY field.   # Content Type and CORS  **Request Content-Type** The Content-Type for POST and GET requests is set to application/json.  **Cross-Origin Resource Sharing** This API features Cross-Origin Resource Sharing (CORS) implemented in compliance with  [W3C spec](https://www.w3.org/TR/cors/). And that allows cross-domain communication from the browser. All responses have a wildcard same-origin which makes them completely public and accessible to everyone, including any code on any site.    # Regional API endpoint(s) A regional API endpoint is intended for customers in the same region. The data for the request and generated PDFs/images are processed and stored within the region.  The regions are:  | Region               | Endpoint                            | Max Timeout (Seconds) | Max Payload Size(MB)** | |- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- --| | Default (Singapore)  | https://rest.apitemplate.io         | 100                   | 1                       | | Europe (Frankfurt)   | https://rest-de.apitemplate.io      | 100                   | 1                       | | US East (N. Virginia)| https://rest-us.apitemplate.io      | 100                   | 1                       | | Australia (Sydney)   | https://rest-au.apitemplate.io      | 30                    | 6                       |   Alternative Regions: | Region               | Endpoint                            | Max Timeout (Seconds) | Max Payload Size(MB)** | |- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- --| | Default (Singapore)  | https://rest-alt.apitemplate.io     | 30                    | 6                       | | Europe (Frankfurt)   | https://rest-alt-de.apitemplate.io  | 30                    | 6                       | | US East (N. Virginia)| https://rest-alt-us.apitemplate.io  | 30                    | 6                       |  ** Note: - Payload size applies to request and response - If \"export_type\" is set to `json` which output file that on AWS S3 doesn't have the limitation - If the \"export_type\" is set to `file` which returns binary data of the generated PDF, the file size of the generated PDF is limited to either 6MB or 1MB based on the region    Other regions are available on request, contact us at hello@apitemplate.io for more information  # Rate limiting Our API endpoints use IP-based rate limiting to ensure fair usage and prevent abuse. Users are allowed to make up to **100 requests per 10 seconds**. This rate limit is designed to accommodate a reasonable volume of requests while maintaining optimal performance for all users.  However, if you exceed this limit and make additional requests, you will receive a response with HTTP code 429. This status code indicates that you have reached the rate limit and need to wait before making further requests. 
 *
 * The version of the OpenAPI document: Version 2.0
 * Contact: hello@apitemplate.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = APITemplateio.Client.OpenAPIDateConverter;

namespace APITemplateio.Model
{
    /// <summary>
    /// MergePdfsRequest
    /// </summary>
    [DataContract(Name = "merge_pdfs_request")]
    public partial class MergePdfsRequest : IEquatable<MergePdfsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergePdfsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergePdfsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergePdfsRequest" /> class.
        /// </summary>
        /// <param name="urls">URL array. We support normal http/https URLs and data URLs - Normal URLs: URLs start with http/https, e.g: \&quot;https://fileserver.com/a1.pdf\&quot;) - Data URLs: URLs prefixed with the \&quot;data:\&quot; scheme, e.g \&quot;data:application/pdf;base64,JVBERi0xLjIg...[truncated]\&quot;  (required).</param>
        /// <param name="exportType">- Either &#x60;file&#x60; or &#x60;json&#x60;(Default).   - The option &#x60;json&#x60; returns a JSON object, and the output PDF is stored on a CDN.   - The option &#x60;file&#x60; returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB. .</param>
        /// <param name="expiration">- Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;43200&#x60; minutes(30 days) to specify the expiration of the generated PDF .</param>
        /// <param name="cloudStorage">- Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;. .</param>
        public MergePdfsRequest(List<Object> urls = default(List<Object>), string exportType = default(string), int expiration = default(int), int cloudStorage = default(int))
        {
            // to ensure "urls" is required (not null)
            if (urls == null)
            {
                throw new ArgumentNullException("urls is a required property for MergePdfsRequest and cannot be null");
            }
            this.Urls = urls;
            this.ExportType = exportType;
            this.Expiration = expiration;
            this.CloudStorage = cloudStorage;
        }

        /// <summary>
        /// URL array. We support normal http/https URLs and data URLs - Normal URLs: URLs start with http/https, e.g: \&quot;https://fileserver.com/a1.pdf\&quot;) - Data URLs: URLs prefixed with the \&quot;data:\&quot; scheme, e.g \&quot;data:application/pdf;base64,JVBERi0xLjIg...[truncated]\&quot; 
        /// </summary>
        /// <value>URL array. We support normal http/https URLs and data URLs - Normal URLs: URLs start with http/https, e.g: \&quot;https://fileserver.com/a1.pdf\&quot;) - Data URLs: URLs prefixed with the \&quot;data:\&quot; scheme, e.g \&quot;data:application/pdf;base64,JVBERi0xLjIg...[truncated]\&quot; </value>
        /// <example>[&quot;https://fileserver.com/a1.pdf&quot;,&quot;https://fileserver.com/b2.pdf&quot;,&quot;data:application/pdf;base64,JVBERi0xLjIg...[truncated]&quot;]</example>
        [DataMember(Name = "urls", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> Urls { get; set; }

        /// <summary>
        /// - Either &#x60;file&#x60; or &#x60;json&#x60;(Default).   - The option &#x60;json&#x60; returns a JSON object, and the output PDF is stored on a CDN.   - The option &#x60;file&#x60; returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB. 
        /// </summary>
        /// <value>- Either &#x60;file&#x60; or &#x60;json&#x60;(Default).   - The option &#x60;json&#x60; returns a JSON object, and the output PDF is stored on a CDN.   - The option &#x60;file&#x60; returns binary data of the generated PDF(Secure and completely private) and the response HTTP header Content-Disposition is set to attachment. It has a file size limit of 6MB. </value>
        /// <example>json</example>
        [DataMember(Name = "export_type", EmitDefaultValue = false)]
        public string ExportType { get; set; }

        /// <summary>
        /// - Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;43200&#x60; minutes(30 days) to specify the expiration of the generated PDF 
        /// </summary>
        /// <value>- Expiration of the generated PDF in minutes(default to &#x60;0&#x60;, store permanently)   - Use &#x60;0&#x60; to store on cdn permanently   - Or use the range between &#x60;1&#x60; minute and &#x60;43200&#x60; minutes(30 days) to specify the expiration of the generated PDF </value>
        /// <example>5</example>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public int Expiration { get; set; }

        /// <summary>
        /// - Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;. 
        /// </summary>
        /// <value>- Upload the generated PDFs/images to our storage CDN, default to &#x60;1&#x60;. If you have configured &#x60;Post Action&#x60; to upload the PDFs/Images to your own S3, please set it to &#x60;0&#x60;. </value>
        /// <example>1</example>
        [DataMember(Name = "cloud_storage", EmitDefaultValue = false)]
        public int CloudStorage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MergePdfsRequest {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  ExportType: ").Append(ExportType).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  CloudStorage: ").Append(CloudStorage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergePdfsRequest);
        }

        /// <summary>
        /// Returns true if MergePdfsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MergePdfsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergePdfsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.ExportType == input.ExportType ||
                    (this.ExportType != null &&
                    this.ExportType.Equals(input.ExportType))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    this.Expiration.Equals(input.Expiration)
                ) && 
                (
                    this.CloudStorage == input.CloudStorage ||
                    this.CloudStorage.Equals(input.CloudStorage)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Urls != null)
                {
                    hashCode = (hashCode * 59) + this.Urls.GetHashCode();
                }
                if (this.ExportType != null)
                {
                    hashCode = (hashCode * 59) + this.ExportType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                hashCode = (hashCode * 59) + this.CloudStorage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
