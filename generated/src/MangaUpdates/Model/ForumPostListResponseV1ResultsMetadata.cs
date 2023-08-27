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
    /// ForumPostListResponseV1ResultsMetadata
    /// </summary>
    [DataContract(Name = "ForumPostListResponseV1ResultsMetadata")]
    public partial class ForumPostListResponseV1ResultsMetadata : IEquatable<ForumPostListResponseV1ResultsMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumPostListResponseV1ResultsMetadata" /> class.
        /// </summary>
        /// <param name="userWarn">userWarn.</param>
        /// <param name="reported">reported.</param>
        /// <param name="isModerator">isModerator.</param>
        /// <param name="isForumAdmin">isForumAdmin.</param>
        public ForumPostListResponseV1ResultsMetadata(ForumWarnModelPublicV1 userWarn = default(ForumWarnModelPublicV1), bool reported = default(bool), bool isModerator = default(bool), bool isForumAdmin = default(bool))
        {
            this.UserWarn = userWarn;
            this.Reported = reported;
            this.IsModerator = isModerator;
            this.IsForumAdmin = isForumAdmin;
        }

        /// <summary>
        /// Gets or Sets UserWarn
        /// </summary>
        [DataMember(Name = "user_warn", EmitDefaultValue = false)]
        public ForumWarnModelPublicV1 UserWarn { get; set; }

        /// <summary>
        /// Gets or Sets Reported
        /// </summary>
        [DataMember(Name = "reported", EmitDefaultValue = true)]
        public bool Reported { get; set; }

        /// <summary>
        /// Gets or Sets IsModerator
        /// </summary>
        [DataMember(Name = "is_moderator", EmitDefaultValue = true)]
        public bool IsModerator { get; set; }

        /// <summary>
        /// Gets or Sets IsForumAdmin
        /// </summary>
        [DataMember(Name = "is_forum_admin", EmitDefaultValue = true)]
        public bool IsForumAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumPostListResponseV1ResultsMetadata {\n");
            sb.Append("  UserWarn: ").Append(UserWarn).Append("\n");
            sb.Append("  Reported: ").Append(Reported).Append("\n");
            sb.Append("  IsModerator: ").Append(IsModerator).Append("\n");
            sb.Append("  IsForumAdmin: ").Append(IsForumAdmin).Append("\n");
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
            return this.Equals(input as ForumPostListResponseV1ResultsMetadata);
        }

        /// <summary>
        /// Returns true if ForumPostListResponseV1ResultsMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumPostListResponseV1ResultsMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumPostListResponseV1ResultsMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserWarn == input.UserWarn ||
                    (this.UserWarn != null &&
                    this.UserWarn.Equals(input.UserWarn))
                ) && 
                (
                    this.Reported == input.Reported ||
                    this.Reported.Equals(input.Reported)
                ) && 
                (
                    this.IsModerator == input.IsModerator ||
                    this.IsModerator.Equals(input.IsModerator)
                ) && 
                (
                    this.IsForumAdmin == input.IsForumAdmin ||
                    this.IsForumAdmin.Equals(input.IsForumAdmin)
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
                if (this.UserWarn != null)
                {
                    hashCode = (hashCode * 59) + this.UserWarn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reported.GetHashCode();
                hashCode = (hashCode * 59) + this.IsModerator.GetHashCode();
                hashCode = (hashCode * 59) + this.IsForumAdmin.GetHashCode();
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
