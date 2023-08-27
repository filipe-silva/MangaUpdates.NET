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
    /// FaqCategoryQuestionsModelV1
    /// </summary>
    [DataContract(Name = "FaqCategoryQuestionsModelV1")]
    public partial class FaqCategoryQuestionsModelV1 : IEquatable<FaqCategoryQuestionsModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaqCategoryQuestionsModelV1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FaqCategoryQuestionsModelV1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FaqCategoryQuestionsModelV1" /> class.
        /// </summary>
        /// <param name="categoryId">categoryId (required).</param>
        /// <param name="title">title.</param>
        /// <param name="questions">questions.</param>
        /// <param name="position">position.</param>
        public FaqCategoryQuestionsModelV1(long categoryId = default(long), string title = default(string), List<FaqQuestionOnlyModelV1> questions = default(List<FaqQuestionOnlyModelV1>), long position = default(long))
        {
            this.CategoryId = categoryId;
            this.Title = title;
            this.Questions = questions;
            this.Position = position;
        }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "category_id", IsRequired = true, EmitDefaultValue = true)]
        public long CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Questions
        /// </summary>
        [DataMember(Name = "questions", EmitDefaultValue = false)]
        public List<FaqQuestionOnlyModelV1> Questions { get; set; }

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
            sb.Append("class FaqCategoryQuestionsModelV1 {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Questions: ").Append(Questions).Append("\n");
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
            return this.Equals(input as FaqCategoryQuestionsModelV1);
        }

        /// <summary>
        /// Returns true if FaqCategoryQuestionsModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of FaqCategoryQuestionsModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaqCategoryQuestionsModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryId == input.CategoryId ||
                    this.CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Questions == input.Questions ||
                    this.Questions != null &&
                    input.Questions != null &&
                    this.Questions.SequenceEqual(input.Questions)
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
                hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Questions != null)
                {
                    hashCode = (hashCode * 59) + this.Questions.GetHashCode();
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
