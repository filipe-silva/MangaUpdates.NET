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
    /// ReviewModelUpdateV1
    /// </summary>
    [DataContract(Name = "ReviewModelUpdateV1")]
    public partial class ReviewModelUpdateV1 : IEquatable<ReviewModelUpdateV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewModelUpdateV1" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="body">body.</param>
        /// <param name="seriesTitle">seriesTitle.</param>
        /// <param name="review">review.</param>
        /// <param name="admin">admin.</param>
        public ReviewModelUpdateV1(string title = default(string), string body = default(string), string seriesTitle = default(string), ReviewModelUpdateV1Review review = default(ReviewModelUpdateV1Review), ReviewModelUpdateV1Admin admin = default(ReviewModelUpdateV1Admin))
        {
            this.Title = title;
            this.Body = body;
            this.SeriesTitle = seriesTitle;
            this.Review = review;
            this.Admin = admin;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets SeriesTitle
        /// </summary>
        [DataMember(Name = "series_title", EmitDefaultValue = false)]
        public string SeriesTitle { get; set; }

        /// <summary>
        /// Gets or Sets Review
        /// </summary>
        [DataMember(Name = "review", EmitDefaultValue = false)]
        public ReviewModelUpdateV1Review Review { get; set; }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public ReviewModelUpdateV1Admin Admin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewModelUpdateV1 {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  SeriesTitle: ").Append(SeriesTitle).Append("\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
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
            return this.Equals(input as ReviewModelUpdateV1);
        }

        /// <summary>
        /// Returns true if ReviewModelUpdateV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewModelUpdateV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewModelUpdateV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.SeriesTitle == input.SeriesTitle ||
                    (this.SeriesTitle != null &&
                    this.SeriesTitle.Equals(input.SeriesTitle))
                ) && 
                (
                    this.Review == input.Review ||
                    (this.Review != null &&
                    this.Review.Equals(input.Review))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.SeriesTitle != null)
                {
                    hashCode = (hashCode * 59) + this.SeriesTitle.GetHashCode();
                }
                if (this.Review != null)
                {
                    hashCode = (hashCode * 59) + this.Review.GetHashCode();
                }
                if (this.Admin != null)
                {
                    hashCode = (hashCode * 59) + this.Admin.GetHashCode();
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
