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
    /// ConvoModelV1
    /// </summary>
    [DataContract(Name = "ConvoModelV1")]
    public partial class ConvoModelV1 : IEquatable<ConvoModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvoModelV1" /> class.
        /// </summary>
        /// <param name="convoId">convoId.</param>
        /// <param name="topic">topic.</param>
        /// <param name="authorId">authorId.</param>
        /// <param name="authorName">authorName.</param>
        /// <param name="timeAdded">timeAdded.</param>
        /// <param name="lastEdit">lastEdit.</param>
        public ConvoModelV1(long convoId = default(long), string topic = default(string), long authorId = default(long), string authorName = default(string), TimeV1 timeAdded = default(TimeV1), TimeV1 lastEdit = default(TimeV1))
        {
            this.ConvoId = convoId;
            this.Topic = topic;
            this.AuthorId = authorId;
            this.AuthorName = authorName;
            this.TimeAdded = timeAdded;
            this.LastEdit = lastEdit;
        }

        /// <summary>
        /// Gets or Sets ConvoId
        /// </summary>
        [DataMember(Name = "convo_id", EmitDefaultValue = false)]
        public long ConvoId { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

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
            sb.Append("class ConvoModelV1 {\n");
            sb.Append("  ConvoId: ").Append(ConvoId).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
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
            return this.Equals(input as ConvoModelV1);
        }

        /// <summary>
        /// Returns true if ConvoModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvoModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvoModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConvoId == input.ConvoId ||
                    this.ConvoId.Equals(input.ConvoId)
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
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
                hashCode = (hashCode * 59) + this.ConvoId.GetHashCode();
                if (this.Topic != null)
                {
                    hashCode = (hashCode * 59) + this.Topic.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                if (this.AuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorName.GetHashCode();
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
