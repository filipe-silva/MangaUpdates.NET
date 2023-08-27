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
    /// ReleaseModerateResponseV1
    /// </summary>
    [DataContract(Name = "ReleaseModerateResponseV1")]
    public partial class ReleaseModerateResponseV1 : IEquatable<ReleaseModerateResponseV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseModerateResponseV1" /> class.
        /// </summary>
        /// <param name="totalHits">totalHits.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">perPage.</param>
        /// <param name="results">results.</param>
        /// <param name="groupInfo">groupInfo.</param>
        public ReleaseModerateResponseV1(long totalHits = default(long), long page = default(long), long perPage = default(long), List<ReleaseModerateResponseV1Results> results = default(List<ReleaseModerateResponseV1Results>), List<ReleaseModerateResponseV1GroupInfo> groupInfo = default(List<ReleaseModerateResponseV1GroupInfo>))
        {
            this.TotalHits = totalHits;
            this.Page = page;
            this.PerPage = perPage;
            this.Results = results;
            this.GroupInfo = groupInfo;
        }

        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name = "total_hits", EmitDefaultValue = false)]
        public long TotalHits { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public long Page { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name = "per_page", EmitDefaultValue = false)]
        public long PerPage { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<ReleaseModerateResponseV1Results> Results { get; set; }

        /// <summary>
        /// Gets or Sets GroupInfo
        /// </summary>
        [DataMember(Name = "group_info", EmitDefaultValue = false)]
        public List<ReleaseModerateResponseV1GroupInfo> GroupInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReleaseModerateResponseV1 {\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  GroupInfo: ").Append(GroupInfo).Append("\n");
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
            return this.Equals(input as ReleaseModerateResponseV1);
        }

        /// <summary>
        /// Returns true if ReleaseModerateResponseV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseModerateResponseV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseModerateResponseV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalHits == input.TotalHits ||
                    this.TotalHits.Equals(input.TotalHits)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    this.PerPage.Equals(input.PerPage)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.GroupInfo == input.GroupInfo ||
                    this.GroupInfo != null &&
                    input.GroupInfo != null &&
                    this.GroupInfo.SequenceEqual(input.GroupInfo)
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
                hashCode = (hashCode * 59) + this.TotalHits.GetHashCode();
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PerPage.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.GroupInfo != null)
                {
                    hashCode = (hashCode * 59) + this.GroupInfo.GetHashCode();
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
