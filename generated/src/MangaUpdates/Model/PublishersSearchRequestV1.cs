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
    /// PublishersSearchRequestV1
    /// </summary>
    [DataContract(Name = "PublishersSearchRequestV1")]
    public partial class PublishersSearchRequestV1 : IEquatable<PublishersSearchRequestV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Orderby
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderbyEnum
        {
            /// <summary>
            /// Enum Score for value: score
            /// </summary>
            [EnumMember(Value = "score")]
            Score = 1,

            /// <summary>
            /// Enum Name for value: name
            /// </summary>
            [EnumMember(Value = "name")]
            Name = 2,

            /// <summary>
            /// Enum Series for value: series
            /// </summary>
            [EnumMember(Value = "series")]
            Series = 3,

            /// <summary>
            /// Enum Publications for value: publications
            /// </summary>
            [EnumMember(Value = "publications")]
            Publications = 4,

            /// <summary>
            /// Enum Type for value: type
            /// </summary>
            [EnumMember(Value = "type")]
            Type = 5

        }


        /// <summary>
        /// Gets or Sets Orderby
        /// </summary>
        [DataMember(Name = "orderby", EmitDefaultValue = false)]
        public OrderbyEnum? Orderby { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishersSearchRequestV1" /> class.
        /// </summary>
        /// <param name="search">search.</param>
        /// <param name="addedBy">addedBy.</param>
        /// <param name="page">page.</param>
        /// <param name="perpage">perpage.</param>
        /// <param name="letter">letter.</param>
        /// <param name="orderby">orderby.</param>
        /// <param name="pending">pending.</param>
        public PublishersSearchRequestV1(string search = default(string), long addedBy = default(long), long page = default(long), long perpage = default(long), string letter = default(string), OrderbyEnum? orderby = default(OrderbyEnum?), bool pending = default(bool))
        {
            this.Search = search;
            this.AddedBy = addedBy;
            this.Page = page;
            this.Perpage = perpage;
            this.Letter = letter;
            this.Orderby = orderby;
            this.Pending = pending;
        }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name = "search", EmitDefaultValue = false)]
        public string Search { get; set; }

        /// <summary>
        /// Gets or Sets AddedBy
        /// </summary>
        [DataMember(Name = "added_by", EmitDefaultValue = false)]
        public long AddedBy { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public long Page { get; set; }

        /// <summary>
        /// Gets or Sets Perpage
        /// </summary>
        [DataMember(Name = "perpage", EmitDefaultValue = false)]
        public long Perpage { get; set; }

        /// <summary>
        /// Gets or Sets Letter
        /// </summary>
        [DataMember(Name = "letter", EmitDefaultValue = false)]
        public string Letter { get; set; }

        /// <summary>
        /// Gets or Sets Pending
        /// </summary>
        [DataMember(Name = "pending", EmitDefaultValue = true)]
        public bool Pending { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishersSearchRequestV1 {\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Perpage: ").Append(Perpage).Append("\n");
            sb.Append("  Letter: ").Append(Letter).Append("\n");
            sb.Append("  Orderby: ").Append(Orderby).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
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
            return this.Equals(input as PublishersSearchRequestV1);
        }

        /// <summary>
        /// Returns true if PublishersSearchRequestV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PublishersSearchRequestV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishersSearchRequestV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.AddedBy == input.AddedBy ||
                    this.AddedBy.Equals(input.AddedBy)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.Perpage == input.Perpage ||
                    this.Perpage.Equals(input.Perpage)
                ) && 
                (
                    this.Letter == input.Letter ||
                    (this.Letter != null &&
                    this.Letter.Equals(input.Letter))
                ) && 
                (
                    this.Orderby == input.Orderby ||
                    this.Orderby.Equals(input.Orderby)
                ) && 
                (
                    this.Pending == input.Pending ||
                    this.Pending.Equals(input.Pending)
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
                if (this.Search != null)
                {
                    hashCode = (hashCode * 59) + this.Search.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddedBy.GetHashCode();
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.Perpage.GetHashCode();
                if (this.Letter != null)
                {
                    hashCode = (hashCode * 59) + this.Letter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Orderby.GetHashCode();
                hashCode = (hashCode * 59) + this.Pending.GetHashCode();
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
