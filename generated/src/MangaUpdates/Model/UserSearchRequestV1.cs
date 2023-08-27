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
    /// UserSearchRequestV1
    /// </summary>
    [DataContract(Name = "UserSearchRequestV1")]
    public partial class UserSearchRequestV1 : IEquatable<UserSearchRequestV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Orderby
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderbyEnum
        {
            /// <summary>
            /// Enum Username for value: username
            /// </summary>
            [EnumMember(Value = "username")]
            Username = 1,

            /// <summary>
            /// Enum TimeAdded for value: time_added
            /// </summary>
            [EnumMember(Value = "time_added")]
            TimeAdded = 2,

            /// <summary>
            /// Enum ForumPosts for value: forum_posts
            /// </summary>
            [EnumMember(Value = "forum_posts")]
            ForumPosts = 3,

            /// <summary>
            /// Enum AddedAuthors for value: added_authors
            /// </summary>
            [EnumMember(Value = "added_authors")]
            AddedAuthors = 4,

            /// <summary>
            /// Enum AddedReleases for value: added_releases
            /// </summary>
            [EnumMember(Value = "added_releases")]
            AddedReleases = 5,

            /// <summary>
            /// Enum AddedGroups for value: added_groups
            /// </summary>
            [EnumMember(Value = "added_groups")]
            AddedGroups = 6,

            /// <summary>
            /// Enum AddedPublishers for value: added_publishers
            /// </summary>
            [EnumMember(Value = "added_publishers")]
            AddedPublishers = 7,

            /// <summary>
            /// Enum AddedSeries for value: added_series
            /// </summary>
            [EnumMember(Value = "added_series")]
            AddedSeries = 8

        }


        /// <summary>
        /// Gets or Sets Orderby
        /// </summary>
        [DataMember(Name = "orderby", EmitDefaultValue = false)]
        public OrderbyEnum? Orderby { get; set; }
        /// <summary>
        /// Defines Asc
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AscEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2

        }


        /// <summary>
        /// Gets or Sets Asc
        /// </summary>
        [DataMember(Name = "asc", EmitDefaultValue = false)]
        public AscEnum? Asc { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchRequestV1" /> class.
        /// </summary>
        /// <param name="search">search.</param>
        /// <param name="page">page.</param>
        /// <param name="perpage">perpage.</param>
        /// <param name="letter">letter.</param>
        /// <param name="orderby">orderby.</param>
        /// <param name="asc">asc.</param>
        public UserSearchRequestV1(string search = default(string), long page = default(long), long perpage = default(long), string letter = default(string), OrderbyEnum? orderby = default(OrderbyEnum?), AscEnum? asc = default(AscEnum?))
        {
            this.Search = search;
            this.Page = page;
            this.Perpage = perpage;
            this.Letter = letter;
            this.Orderby = orderby;
            this.Asc = asc;
        }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name = "search", EmitDefaultValue = false)]
        public string Search { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSearchRequestV1 {\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Perpage: ").Append(Perpage).Append("\n");
            sb.Append("  Letter: ").Append(Letter).Append("\n");
            sb.Append("  Orderby: ").Append(Orderby).Append("\n");
            sb.Append("  Asc: ").Append(Asc).Append("\n");
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
            return this.Equals(input as UserSearchRequestV1);
        }

        /// <summary>
        /// Returns true if UserSearchRequestV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSearchRequestV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchRequestV1 input)
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
                    this.Asc == input.Asc ||
                    this.Asc.Equals(input.Asc)
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
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.Perpage.GetHashCode();
                if (this.Letter != null)
                {
                    hashCode = (hashCode * 59) + this.Letter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Orderby.GetHashCode();
                hashCode = (hashCode * 59) + this.Asc.GetHashCode();
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
