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
    /// ForumForumModelListV1Admin
    /// </summary>
    [DataContract(Name = "ForumForumModelListV1Admin")]
    public partial class ForumForumModelListV1Admin : IEquatable<ForumForumModelListV1Admin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumForumModelListV1Admin" /> class.
        /// </summary>
        /// <param name="locked">locked.</param>
        /// <param name="hidden">hidden.</param>
        /// <param name="verifyAge">verifyAge.</param>
        public ForumForumModelListV1Admin(bool locked = default(bool), bool hidden = default(bool), bool verifyAge = default(bool))
        {
            this.Locked = locked;
            this.Hidden = hidden;
            this.VerifyAge = verifyAge;
        }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name = "hidden", EmitDefaultValue = true)]
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or Sets VerifyAge
        /// </summary>
        [DataMember(Name = "verify_age", EmitDefaultValue = true)]
        public bool VerifyAge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumForumModelListV1Admin {\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  VerifyAge: ").Append(VerifyAge).Append("\n");
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
            return this.Equals(input as ForumForumModelListV1Admin);
        }

        /// <summary>
        /// Returns true if ForumForumModelListV1Admin instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumForumModelListV1Admin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumForumModelListV1Admin input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    this.Hidden.Equals(input.Hidden)
                ) && 
                (
                    this.VerifyAge == input.VerifyAge ||
                    this.VerifyAge.Equals(input.VerifyAge)
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
                hashCode = (hashCode * 59) + this.Locked.GetHashCode();
                hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
                hashCode = (hashCode * 59) + this.VerifyAge.GetHashCode();
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
