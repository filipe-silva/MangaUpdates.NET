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
    /// ForumForumModelListV1Stats
    /// </summary>
    [DataContract(Name = "ForumForumModelListV1Stats")]
    public partial class ForumForumModelListV1Stats : IEquatable<ForumForumModelListV1Stats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumForumModelListV1Stats" /> class.
        /// </summary>
        /// <param name="topics">topics.</param>
        /// <param name="posts">posts.</param>
        public ForumForumModelListV1Stats(long topics = default(long), long posts = default(long))
        {
            this.Topics = topics;
            this.Posts = posts;
        }

        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name = "topics", EmitDefaultValue = false)]
        public long Topics { get; set; }

        /// <summary>
        /// Gets or Sets Posts
        /// </summary>
        [DataMember(Name = "posts", EmitDefaultValue = false)]
        public long Posts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumForumModelListV1Stats {\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Posts: ").Append(Posts).Append("\n");
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
            return this.Equals(input as ForumForumModelListV1Stats);
        }

        /// <summary>
        /// Returns true if ForumForumModelListV1Stats instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumForumModelListV1Stats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumForumModelListV1Stats input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Topics == input.Topics ||
                    this.Topics.Equals(input.Topics)
                ) && 
                (
                    this.Posts == input.Posts ||
                    this.Posts.Equals(input.Posts)
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
                hashCode = (hashCode * 59) + this.Topics.GetHashCode();
                hashCode = (hashCode * 59) + this.Posts.GetHashCode();
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
