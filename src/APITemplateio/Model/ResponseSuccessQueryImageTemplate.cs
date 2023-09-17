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
    /// ResponseSuccessQueryImageTemplate
    /// </summary>
    [DataContract(Name = "ResponseSuccessQueryImageTemplate")]
    public partial class ResponseSuccessQueryImageTemplate : IEquatable<ResponseSuccessQueryImageTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessQueryImageTemplate" /> class.
        /// </summary>
        /// <param name="status">Status.</param>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        /// <param name="layers">Array of layers.</param>
        public ResponseSuccessQueryImageTemplate(string status = default(string), int width = default(int), int height = default(int), List<Object> layers = default(List<Object>))
        {
            this.Status = status;
            this.Width = width;
            this.Height = height;
            this.Layers = layers;
        }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        /// <example>success</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        /// <value>Width</value>
        /// <example>1024</example>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        /// <value>Height</value>
        /// <example>1024</example>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Array of layers
        /// </summary>
        /// <value>Array of layers</value>
        /// <example>[
{
    &quot;name&quot;: &quot;text_1&quot;,
    &quot;type&quot;: &quot;textbox&quot;,
    &quot;subtype&quot;: &quot;textbox&quot;,
    &quot;y&quot;: 50,
    &quot;x&quot;: 50,
    &quot;width&quot;: 629.82,
    &quot;height&quot;: 406.8,
    &quot;fontSize&quot;: 120,
    &quot;fontWeight&quot;: &quot;normal&quot;,
    &quot;fontFamily&quot;: &quot;Anton&quot;,
    &quot;fontStyle&quot;: &quot;normal&quot;,
    &quot;text&quot;: &quot;Type ~something~ ::here::&quot;,
    &quot;stroke&quot;: null,
    &quot;strokeWidth&quot;: 0,
    &quot;opacity&quot;: 1,
    &quot;backgroundColor&quot;: &quot;&quot;,
    &quot;textAlign&quot;: &quot;left&quot;,
    &quot;splitByGrapheme&quot;: false,
    &quot;textBackgroundColor&quot;: &quot;rgba(246, 243, 243, 0)&quot;,
    &quot;color&quot;: &quot;#FFB029&quot;
},
{
    &quot;name&quot;: &quot;rect_1&quot;,
    &quot;type&quot;: &quot;rect&quot;,
    &quot;subtype&quot;: &quot;rect&quot;,
    &quot;y&quot;: 101.9,
    &quot;x&quot;: 708.82,
    &quot;width&quot;: 300,
    &quot;height&quot;: 300,
    &quot;stroke&quot;: &quot;grey&quot;,
    &quot;strokeWidth&quot;: 3,
    &quot;opacity&quot;: 1,
    &quot;backgroundColor&quot;: &quot;&quot;,
    &quot;color&quot;: &quot;#BEF4FF&quot;
}
]
</example>
        [DataMember(Name = "layers", EmitDefaultValue = false)]
        public List<Object> Layers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseSuccessQueryImageTemplate {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
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
            return this.Equals(input as ResponseSuccessQueryImageTemplate);
        }

        /// <summary>
        /// Returns true if ResponseSuccessQueryImageTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseSuccessQueryImageTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseSuccessQueryImageTemplate input)
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
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Layers == input.Layers ||
                    this.Layers != null &&
                    input.Layers != null &&
                    this.Layers.SequenceEqual(input.Layers)
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
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                if (this.Layers != null)
                {
                    hashCode = (hashCode * 59) + this.Layers.GetHashCode();
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
