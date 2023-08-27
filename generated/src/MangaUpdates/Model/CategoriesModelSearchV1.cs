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
    /// CategoriesModelSearchV1
    /// </summary>
    [DataContract(Name = "CategoriesModelSearchV1")]
    public partial class CategoriesModelSearchV1 : IEquatable<CategoriesModelSearchV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesModelSearchV1" /> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="usage">usage.</param>
        /// <param name="votes">votes.</param>
        /// <param name="votesPlus">votesPlus.</param>
        /// <param name="votesMinus">votesMinus.</param>
        public CategoriesModelSearchV1(string category = default(string), long usage = default(long), long votes = default(long), long votesPlus = default(long), long votesMinus = default(long))
        {
            this.Category = category;
            this.Usage = usage;
            this.Votes = votes;
            this.VotesPlus = votesPlus;
            this.VotesMinus = votesMinus;
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        public long Usage { get; set; }

        /// <summary>
        /// Gets or Sets Votes
        /// </summary>
        [DataMember(Name = "votes", EmitDefaultValue = false)]
        public long Votes { get; set; }

        /// <summary>
        /// Gets or Sets VotesPlus
        /// </summary>
        [DataMember(Name = "votes_plus", EmitDefaultValue = false)]
        public long VotesPlus { get; set; }

        /// <summary>
        /// Gets or Sets VotesMinus
        /// </summary>
        [DataMember(Name = "votes_minus", EmitDefaultValue = false)]
        public long VotesMinus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CategoriesModelSearchV1 {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Votes: ").Append(Votes).Append("\n");
            sb.Append("  VotesPlus: ").Append(VotesPlus).Append("\n");
            sb.Append("  VotesMinus: ").Append(VotesMinus).Append("\n");
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
            return this.Equals(input as CategoriesModelSearchV1);
        }

        /// <summary>
        /// Returns true if CategoriesModelSearchV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoriesModelSearchV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoriesModelSearchV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Usage == input.Usage ||
                    this.Usage.Equals(input.Usage)
                ) && 
                (
                    this.Votes == input.Votes ||
                    this.Votes.Equals(input.Votes)
                ) && 
                (
                    this.VotesPlus == input.VotesPlus ||
                    this.VotesPlus.Equals(input.VotesPlus)
                ) && 
                (
                    this.VotesMinus == input.VotesMinus ||
                    this.VotesMinus.Equals(input.VotesMinus)
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Usage.GetHashCode();
                hashCode = (hashCode * 59) + this.Votes.GetHashCode();
                hashCode = (hashCode * 59) + this.VotesPlus.GetHashCode();
                hashCode = (hashCode * 59) + this.VotesMinus.GetHashCode();
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