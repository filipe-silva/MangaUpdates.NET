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
    /// ReleaseModerateResponseV1ResultsMetadata
    /// </summary>
    [DataContract(Name = "ReleaseModerateResponseV1ResultsMetadata")]
    public partial class ReleaseModerateResponseV1ResultsMetadata : IEquatable<ReleaseModerateResponseV1ResultsMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseModerateResponseV1ResultsMetadata" /> class.
        /// </summary>
        /// <param name="series">series.</param>
        /// <param name="likeReleases">likeReleases.</param>
        public ReleaseModerateResponseV1ResultsMetadata(long series = default(long), List<ReleaseModelV1> likeReleases = default(List<ReleaseModelV1>))
        {
            this.Series = series;
            this.LikeReleases = likeReleases;
        }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public long Series { get; set; }

        /// <summary>
        /// Gets or Sets LikeReleases
        /// </summary>
        [DataMember(Name = "like_releases", EmitDefaultValue = false)]
        public List<ReleaseModelV1> LikeReleases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReleaseModerateResponseV1ResultsMetadata {\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  LikeReleases: ").Append(LikeReleases).Append("\n");
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
            return this.Equals(input as ReleaseModerateResponseV1ResultsMetadata);
        }

        /// <summary>
        /// Returns true if ReleaseModerateResponseV1ResultsMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseModerateResponseV1ResultsMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseModerateResponseV1ResultsMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Series == input.Series ||
                    this.Series.Equals(input.Series)
                ) && 
                (
                    this.LikeReleases == input.LikeReleases ||
                    this.LikeReleases != null &&
                    input.LikeReleases != null &&
                    this.LikeReleases.SequenceEqual(input.LikeReleases)
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
                hashCode = (hashCode * 59) + this.Series.GetHashCode();
                if (this.LikeReleases != null)
                {
                    hashCode = (hashCode * 59) + this.LikeReleases.GetHashCode();
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
