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
    /// SeriesCommentModelUpdateV1Admin
    /// </summary>
    [DataContract(Name = "SeriesCommentModelUpdateV1Admin")]
    public partial class SeriesCommentModelUpdateV1Admin : IEquatable<SeriesCommentModelUpdateV1Admin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesCommentModelUpdateV1Admin" /> class.
        /// </summary>
        /// <param name="moderated">moderated.</param>
        /// <param name="reported">reported.</param>
        public SeriesCommentModelUpdateV1Admin(bool moderated = default(bool), bool reported = default(bool))
        {
            this.Moderated = moderated;
            this.Reported = reported;
        }

        /// <summary>
        /// Gets or Sets Moderated
        /// </summary>
        [DataMember(Name = "moderated", EmitDefaultValue = true)]
        public bool Moderated { get; set; }

        /// <summary>
        /// Gets or Sets Reported
        /// </summary>
        [DataMember(Name = "reported", EmitDefaultValue = true)]
        public bool Reported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeriesCommentModelUpdateV1Admin {\n");
            sb.Append("  Moderated: ").Append(Moderated).Append("\n");
            sb.Append("  Reported: ").Append(Reported).Append("\n");
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
            return this.Equals(input as SeriesCommentModelUpdateV1Admin);
        }

        /// <summary>
        /// Returns true if SeriesCommentModelUpdateV1Admin instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesCommentModelUpdateV1Admin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesCommentModelUpdateV1Admin input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Moderated == input.Moderated ||
                    this.Moderated.Equals(input.Moderated)
                ) && 
                (
                    this.Reported == input.Reported ||
                    this.Reported.Equals(input.Reported)
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
                hashCode = (hashCode * 59) + this.Moderated.GetHashCode();
                hashCode = (hashCode * 59) + this.Reported.GetHashCode();
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