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
    /// ConvoMessageModelV1
    /// </summary>
    [DataContract(Name = "ConvoMessageModelV1")]
    public partial class ConvoMessageModelV1 : IEquatable<ConvoMessageModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvoMessageModelV1" /> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="convoId">convoId.</param>
        /// <param name="authorId">authorId.</param>
        /// <param name="authorName">authorName.</param>
        /// <param name="isAdmin">isAdmin.</param>
        /// <param name="content">content.</param>
        /// <param name="timeAdded">timeAdded.</param>
        /// <param name="lastEdit">lastEdit.</param>
        public ConvoMessageModelV1(long messageId = default(long), long convoId = default(long), long authorId = default(long), string authorName = default(string), bool isAdmin = default(bool), string content = default(string), TimeV1 timeAdded = default(TimeV1), TimeV1 lastEdit = default(TimeV1))
        {
            this.MessageId = messageId;
            this.ConvoId = convoId;
            this.AuthorId = authorId;
            this.AuthorName = authorName;
            this.IsAdmin = isAdmin;
            this.Content = content;
            this.TimeAdded = timeAdded;
            this.LastEdit = lastEdit;
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "message_id", EmitDefaultValue = false)]
        public long MessageId { get; set; }

        /// <summary>
        /// Gets or Sets ConvoId
        /// </summary>
        [DataMember(Name = "convo_id", EmitDefaultValue = false)]
        public long ConvoId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorId
        /// </summary>
        [DataMember(Name = "author_id", EmitDefaultValue = false)]
        public long AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "author_name", EmitDefaultValue = false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name = "is_admin", EmitDefaultValue = true)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets TimeAdded
        /// </summary>
        [DataMember(Name = "time_added", EmitDefaultValue = false)]
        public TimeV1 TimeAdded { get; set; }

        /// <summary>
        /// Gets or Sets LastEdit
        /// </summary>
        [DataMember(Name = "last_edit", EmitDefaultValue = false)]
        public TimeV1 LastEdit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConvoMessageModelV1 {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ConvoId: ").Append(ConvoId).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  TimeAdded: ").Append(TimeAdded).Append("\n");
            sb.Append("  LastEdit: ").Append(LastEdit).Append("\n");
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
            return this.Equals(input as ConvoMessageModelV1);
        }

        /// <summary>
        /// Returns true if ConvoMessageModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvoMessageModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvoMessageModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    this.MessageId.Equals(input.MessageId)
                ) && 
                (
                    this.ConvoId == input.ConvoId ||
                    this.ConvoId.Equals(input.ConvoId)
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    this.AuthorId.Equals(input.AuthorId)
                ) && 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    this.IsAdmin.Equals(input.IsAdmin)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.TimeAdded == input.TimeAdded ||
                    (this.TimeAdded != null &&
                    this.TimeAdded.Equals(input.TimeAdded))
                ) && 
                (
                    this.LastEdit == input.LastEdit ||
                    (this.LastEdit != null &&
                    this.LastEdit.Equals(input.LastEdit))
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
                hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                hashCode = (hashCode * 59) + this.ConvoId.GetHashCode();
                hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                if (this.AuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAdmin.GetHashCode();
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.TimeAdded != null)
                {
                    hashCode = (hashCode * 59) + this.TimeAdded.GetHashCode();
                }
                if (this.LastEdit != null)
                {
                    hashCode = (hashCode * 59) + this.LastEdit.GetHashCode();
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
