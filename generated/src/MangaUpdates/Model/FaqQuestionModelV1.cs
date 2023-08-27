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
    /// FaqQuestionModelV1
    /// </summary>
    [DataContract(Name = "FaqQuestionModelV1")]
    public partial class FaqQuestionModelV1 : IEquatable<FaqQuestionModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaqQuestionModelV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FaqQuestionModelV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaqQuestionModelV1" /> class.
        /// </summary>
        /// <param name="questionId">questionId (required).</param>
        /// <param name="question">question.</param>
        /// <param name="answer">answer.</param>
        /// <param name="position">position.</param>
        public FaqQuestionModelV1(long questionId = default(long), string question = default(string), string answer = default(string), long position = default(long))
        {
            this.QuestionId = questionId;
            this.Question = question;
            this.Answer = answer;
            this.Position = position;
        }

        /// <summary>
        /// Gets or Sets QuestionId
        /// </summary>
        [DataMember(Name = "question_id", IsRequired = true, EmitDefaultValue = true)]
        public long QuestionId { get; set; }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [DataMember(Name = "question", EmitDefaultValue = false)]
        public string Question { get; set; }

        /// <summary>
        /// Gets or Sets Answer
        /// </summary>
        [DataMember(Name = "answer", EmitDefaultValue = false)]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public long Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FaqQuestionModelV1 {\n");
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as FaqQuestionModelV1);
        }

        /// <summary>
        /// Returns true if FaqQuestionModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of FaqQuestionModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaqQuestionModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuestionId == input.QuestionId ||
                    this.QuestionId.Equals(input.QuestionId)
                ) && 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
                ) && 
                (
                    this.Answer == input.Answer ||
                    (this.Answer != null &&
                    this.Answer.Equals(input.Answer))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
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
                hashCode = (hashCode * 59) + this.QuestionId.GetHashCode();
                if (this.Question != null)
                {
                    hashCode = (hashCode * 59) + this.Question.GetHashCode();
                }
                if (this.Answer != null)
                {
                    hashCode = (hashCode * 59) + this.Answer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
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