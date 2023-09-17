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
    /// ResponseSuccessTemplate
    /// </summary>
    [DataContract(Name = "ResponseSuccessTemplate")]
    public partial class ResponseSuccessTemplate : IEquatable<ResponseSuccessTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessTemplate" /> class.
        /// </summary>
        /// <param name="status">Status.</param>
        /// <param name="templateId">Template ID.</param>
        /// <param name="body">HTML body of the template.</param>
        /// <param name="css">CSS of the template.</param>
        /// <param name="settings">Print settings of the template.</param>
        public ResponseSuccessTemplate(string status = default(string), string templateId = default(string), string body = default(string), string css = default(string), string settings = default(string))
        {
            this.Status = status;
            this.TemplateId = templateId;
            this.Body = body;
            this.Css = css;
            this.Settings = settings;
        }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        /// <example>success</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Template ID
        /// </summary>
        /// <value>Template ID</value>
        /// <example>cd890b2b199c5c42</example>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// HTML body of the template
        /// </summary>
        /// <value>HTML body of the template</value>
        /// <example>&lt;h1&gt;Title&lt;/h1&gt;</example>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// CSS of the template
        /// </summary>
        /// <value>CSS of the template</value>
        /// <example>body{background: white}</example>
        [DataMember(Name = "css", EmitDefaultValue = false)]
        public string Css { get; set; }

        /// <summary>
        /// Print settings of the template
        /// </summary>
        /// <value>Print settings of the template</value>
        /// <example>{&quot;paper_size&quot;:&quot;A4&quot;,&quot;orientation&quot;:&quot;1&quot;,&quot;print_background&quot;:&quot;1&quot;,&quot;margin_top&quot;:&quot;40&quot;,&quot;margin_bottom&quot;:&quot;40&quot;,&quot;margin_right&quot;:&quot;40&quot;,&quot;margin_left&quot;:&quot;40&quot;,&quot;header_right&quot;:&quot;{{pageNumber}}/{{totalPages}}&quot;,&quot;footer_center&quot;:&quot;{{pageNumber}}/{{totalPages}}&quot;,&quot;header_center&quot;:&quot;Sample Invoice&quot;,&quot;header_font_size&quot;:&quot;11px&quot;,&quot;header_left&quot;:&quot;{{date}}&quot;,&quot;footer_left&quot;:&quot;{{date}}&quot;,&quot;custom_header&quot;:&quot;&quot;,&quot;footer_font_size&quot;:&quot;11px&quot;}</example>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public string Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseSuccessTemplate {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Css: ").Append(Css).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as ResponseSuccessTemplate);
        }

        /// <summary>
        /// Returns true if ResponseSuccessTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseSuccessTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseSuccessTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Css == input.Css ||
                    (this.Css != null &&
                    this.Css.Equals(input.Css))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Css != null)
                {
                    hashCode = (hashCode * 59) + this.Css.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
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
