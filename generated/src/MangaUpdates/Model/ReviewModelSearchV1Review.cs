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
    /// ReviewModelSearchV1Review
    /// </summary>
    [DataContract(Name = "ReviewModelSearchV1Review")]
    public partial class ReviewModelSearchV1Review : IEquatable<ReviewModelSearchV1Review>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewModelSearchV1Review" /> class.
        /// </summary>
        /// <param name="plot">plot.</param>
        /// <param name="drawing">drawing.</param>
        /// <param name="characters">characters.</param>
        /// <param name="enjoy">enjoy.</param>
        /// <param name="overall">overall.</param>
        public ReviewModelSearchV1Review(decimal plot = default(decimal), decimal drawing = default(decimal), decimal characters = default(decimal), decimal enjoy = default(decimal), decimal overall = default(decimal))
        {
            this.Plot = plot;
            this.Drawing = drawing;
            this.Characters = characters;
            this.Enjoy = enjoy;
            this.Overall = overall;
        }

        /// <summary>
        /// Gets or Sets Plot
        /// </summary>
        [DataMember(Name = "plot", EmitDefaultValue = false)]
        public decimal Plot { get; set; }

        /// <summary>
        /// Gets or Sets Drawing
        /// </summary>
        [DataMember(Name = "drawing", EmitDefaultValue = false)]
        public decimal Drawing { get; set; }

        /// <summary>
        /// Gets or Sets Characters
        /// </summary>
        [DataMember(Name = "characters", EmitDefaultValue = false)]
        public decimal Characters { get; set; }

        /// <summary>
        /// Gets or Sets Enjoy
        /// </summary>
        [DataMember(Name = "enjoy", EmitDefaultValue = false)]
        public decimal Enjoy { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name = "overall", EmitDefaultValue = false)]
        public decimal Overall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewModelSearchV1Review {\n");
            sb.Append("  Plot: ").Append(Plot).Append("\n");
            sb.Append("  Drawing: ").Append(Drawing).Append("\n");
            sb.Append("  Characters: ").Append(Characters).Append("\n");
            sb.Append("  Enjoy: ").Append(Enjoy).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
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
            return this.Equals(input as ReviewModelSearchV1Review);
        }

        /// <summary>
        /// Returns true if ReviewModelSearchV1Review instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewModelSearchV1Review to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewModelSearchV1Review input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Plot == input.Plot ||
                    this.Plot.Equals(input.Plot)
                ) && 
                (
                    this.Drawing == input.Drawing ||
                    this.Drawing.Equals(input.Drawing)
                ) && 
                (
                    this.Characters == input.Characters ||
                    this.Characters.Equals(input.Characters)
                ) && 
                (
                    this.Enjoy == input.Enjoy ||
                    this.Enjoy.Equals(input.Enjoy)
                ) && 
                (
                    this.Overall == input.Overall ||
                    this.Overall.Equals(input.Overall)
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
                hashCode = (hashCode * 59) + this.Plot.GetHashCode();
                hashCode = (hashCode * 59) + this.Drawing.GetHashCode();
                hashCode = (hashCode * 59) + this.Characters.GetHashCode();
                hashCode = (hashCode * 59) + this.Enjoy.GetHashCode();
                hashCode = (hashCode * 59) + this.Overall.GetHashCode();
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
