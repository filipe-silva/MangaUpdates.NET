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
    /// ForumPollAnswerModelV1
    /// </summary>
    [DataContract(Name = "ForumPollAnswerModelV1")]
    public partial class ForumPollAnswerModelV1 : IEquatable<ForumPollAnswerModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumPollAnswerModelV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForumPollAnswerModelV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumPollAnswerModelV1" /> class.
        /// </summary>
        /// <param name="answerId">answerId (required).</param>
        /// <param name="answer">answer (required).</param>
        /// <param name="votes">votes.</param>
        /// <param name="image">image.</param>
        public ForumPollAnswerModelV1(long answerId = default(long), string answer = default(string), long votes = default(long), ForumPollAnswerModelV1Image image = default(ForumPollAnswerModelV1Image))
        {
            this.AnswerId = answerId;
            // to ensure "answer" is required (not null)
            if (answer == null)
            {
                throw new ArgumentNullException("answer is a required property for ForumPollAnswerModelV1 and cannot be null");
            }
            this.Answer = answer;
            this.Votes = votes;
            this.Image = image;
        }

        /// <summary>
        /// Gets or Sets AnswerId
        /// </summary>
        [DataMember(Name = "answer_id", IsRequired = true, EmitDefaultValue = true)]
        public long AnswerId { get; set; }

        /// <summary>
        /// Gets or Sets Answer
        /// </summary>
        [DataMember(Name = "answer", IsRequired = true, EmitDefaultValue = true)]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or Sets Votes
        /// </summary>
        [DataMember(Name = "votes", EmitDefaultValue = false)]
        public long Votes { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public ForumPollAnswerModelV1Image Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumPollAnswerModelV1 {\n");
            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Votes: ").Append(Votes).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as ForumPollAnswerModelV1);
        }

        /// <summary>
        /// Returns true if ForumPollAnswerModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumPollAnswerModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumPollAnswerModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnswerId == input.AnswerId ||
                    this.AnswerId.Equals(input.AnswerId)
                ) && 
                (
                    this.Answer == input.Answer ||
                    (this.Answer != null &&
                    this.Answer.Equals(input.Answer))
                ) && 
                (
                    this.Votes == input.Votes ||
                    this.Votes.Equals(input.Votes)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                hashCode = (hashCode * 59) + this.AnswerId.GetHashCode();
                if (this.Answer != null)
                {
                    hashCode = (hashCode * 59) + this.Answer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Votes.GetHashCode();
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
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