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
    /// SeriesRecommendationsModelV1
    /// </summary>
    [DataContract(Name = "SeriesRecommendationsModelV1")]
    public partial class SeriesRecommendationsModelV1 : IEquatable<SeriesRecommendationsModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesRecommendationsModelV1" /> class.
        /// </summary>
        /// <param name="seriesName">seriesName.</param>
        /// <param name="seriesId">seriesId.</param>
        /// <param name="weight">weight.</param>
        public SeriesRecommendationsModelV1(string seriesName = default(string), long seriesId = default(long), long weight = default(long))
        {
            this.SeriesName = seriesName;
            this.SeriesId = seriesId;
            this.Weight = weight;
        }

        /// <summary>
        /// Gets or Sets SeriesName
        /// </summary>
        [DataMember(Name = "series_name", EmitDefaultValue = false)]
        public string SeriesName { get; set; }

        /// <summary>
        /// Gets or Sets SeriesId
        /// </summary>
        [DataMember(Name = "series_id", EmitDefaultValue = false)]
        public long SeriesId { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public long Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeriesRecommendationsModelV1 {\n");
            sb.Append("  SeriesName: ").Append(SeriesName).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as SeriesRecommendationsModelV1);
        }

        /// <summary>
        /// Returns true if SeriesRecommendationsModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesRecommendationsModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesRecommendationsModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SeriesName == input.SeriesName ||
                    (this.SeriesName != null &&
                    this.SeriesName.Equals(input.SeriesName))
                ) && 
                (
                    this.SeriesId == input.SeriesId ||
                    this.SeriesId.Equals(input.SeriesId)
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
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
                if (this.SeriesName != null)
                {
                    hashCode = (hashCode * 59) + this.SeriesName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SeriesId.GetHashCode();
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
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
