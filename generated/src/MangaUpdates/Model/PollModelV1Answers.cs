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
    /// PollModelV1Answers
    /// </summary>
    [DataContract(Name = "PollModelV1Answers")]
    public partial class PollModelV1Answers : IEquatable<PollModelV1Answers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollModelV1Answers" /> class.
        /// </summary>
        /// <param name="answerId">answerId.</param>
        /// <param name="answer">answer.</param>
        /// <param name="total">total.</param>
        public PollModelV1Answers(long answerId = default(long), string answer = default(string), long total = default(long))
        {
            this.AnswerId = answerId;
            this.Answer = answer;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets AnswerId
        /// </summary>
        [DataMember(Name = "answer_id", EmitDefaultValue = false)]
        public long AnswerId { get; set; }

        /// <summary>
        /// Gets or Sets Answer
        /// </summary>
        [DataMember(Name = "answer", EmitDefaultValue = false)]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public long Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollModelV1Answers {\n");
            sb.Append("  AnswerId: ").Append(AnswerId).Append("\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as PollModelV1Answers);
        }

        /// <summary>
        /// Returns true if PollModelV1Answers instances are equal
        /// </summary>
        /// <param name="input">Instance of PollModelV1Answers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PollModelV1Answers input)
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
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
