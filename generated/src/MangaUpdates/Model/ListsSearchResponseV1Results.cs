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
    /// ListsSearchResponseV1Results
    /// </summary>
    [DataContract(Name = "ListsSearchResponseV1Results")]
    public partial class ListsSearchResponseV1Results : IEquatable<ListsSearchResponseV1Results>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListsSearchResponseV1Results" /> class.
        /// </summary>
        /// <param name="record">record.</param>
        /// <param name="metadata">metadata.</param>
        public ListsSearchResponseV1Results(ListsSeriesModelV1 record = default(ListsSeriesModelV1), ListsSearchResponseV1ResultsMetadata metadata = default(ListsSearchResponseV1ResultsMetadata))
        {
            this.Record = record;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name = "record", EmitDefaultValue = false)]
        public ListsSeriesModelV1 Record { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public ListsSearchResponseV1ResultsMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListsSearchResponseV1Results {\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as ListsSearchResponseV1Results);
        }

        /// <summary>
        /// Returns true if ListsSearchResponseV1Results instances are equal
        /// </summary>
        /// <param name="input">Instance of ListsSearchResponseV1Results to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListsSearchResponseV1Results input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Record != null)
                {
                    hashCode = (hashCode * 59) + this.Record.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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