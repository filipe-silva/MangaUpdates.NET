/*
 * MangaUpdates API
 *
 * This API powers our website. Most API functions are public and do not require an account. For user-based functions, you must register an account. Currently, user registration must be done through our main website and is disabled via this API.  Download OpenAPI Specification: [openapi.yaml](openapi.yaml)  Please contact us at the following emails if you have questions:  * lambchopsil@mangaupdates.com * manick@mangaupdates.com  ## Warranties  MangaUpdates makes no warranties about service availability, correctness of the data, or anything else. The service is provided as is, and may change at any time.  ## Acceptable Use Policy  * You will credit MangaUpdates when using data provided by this API. * You will use reasonable spacing between requests so as not to overwhelm the MangaUpdates servers, and employ caching mechanisms when accessing data. * You will NOT use MangaUpdates data or API in a way that will:     * Deceive or defraud users     * Assist or perform an illegal action     * Create spam     * Damage the database  We reserve the right to change this policy at any time.
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = MangaUpdates.Client.OpenAPIDateConverter;

namespace MangaUpdates.Model
{
    /// <summary>
    /// PublishersPublicationResponseV1Publisher
    /// </summary>
    [DataContract(Name = "PublishersPublicationResponseV1Publisher")]
    public partial class PublishersPublicationResponseV1Publisher : IEquatable<PublishersPublicationResponseV1Publisher>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishersPublicationResponseV1Publisher" /> class.
        /// </summary>
        /// <param name="publisherName">publisherName.</param>
        /// <param name="publisherId">publisherId.</param>
        public PublishersPublicationResponseV1Publisher(string publisherName = default(string), long publisherId = default(long))
        {
            this.PublisherName = publisherName;
            this.PublisherId = publisherId;
        }

        /// <summary>
        /// Gets or Sets PublisherName
        /// </summary>
        [DataMember(Name = "publisher_name", EmitDefaultValue = false)]
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets or Sets PublisherId
        /// </summary>
        [DataMember(Name = "publisher_id", EmitDefaultValue = false)]
        public long PublisherId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishersPublicationResponseV1Publisher {\n");
            sb.Append("  PublisherName: ").Append(PublisherName).Append("\n");
            sb.Append("  PublisherId: ").Append(PublisherId).Append("\n");
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
            return this.Equals(input as PublishersPublicationResponseV1Publisher);
        }

        /// <summary>
        /// Returns true if PublishersPublicationResponseV1Publisher instances are equal
        /// </summary>
        /// <param name="input">Instance of PublishersPublicationResponseV1Publisher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishersPublicationResponseV1Publisher input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PublisherName == input.PublisherName ||
                    (this.PublisherName != null &&
                    this.PublisherName.Equals(input.PublisherName))
                ) && 
                (
                    this.PublisherId == input.PublisherId ||
                    this.PublisherId.Equals(input.PublisherId)
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
                if (this.PublisherName != null)
                {
                    hashCode = (hashCode * 59) + this.PublisherName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PublisherId.GetHashCode();
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
