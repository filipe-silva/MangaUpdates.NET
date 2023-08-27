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
    /// SeriesModelSearchV1RankOldPosition
    /// </summary>
    [DataContract(Name = "SeriesModelSearchV1RankOldPosition")]
    public partial class SeriesModelSearchV1RankOldPosition : IEquatable<SeriesModelSearchV1RankOldPosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModelSearchV1RankOldPosition" /> class.
        /// </summary>
        /// <param name="week">week.</param>
        /// <param name="month">month.</param>
        /// <param name="threeMonths">threeMonths.</param>
        /// <param name="sixMonths">sixMonths.</param>
        /// <param name="year">year.</param>
        public SeriesModelSearchV1RankOldPosition(long week = default(long), long month = default(long), long threeMonths = default(long), long sixMonths = default(long), long year = default(long))
        {
            this.Week = week;
            this.Month = month;
            this.ThreeMonths = threeMonths;
            this.SixMonths = sixMonths;
            this.Year = year;
        }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name = "week", EmitDefaultValue = false)]
        public long Week { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public long Month { get; set; }

        /// <summary>
        /// Gets or Sets ThreeMonths
        /// </summary>
        [DataMember(Name = "three_months", EmitDefaultValue = false)]
        public long ThreeMonths { get; set; }

        /// <summary>
        /// Gets or Sets SixMonths
        /// </summary>
        [DataMember(Name = "six_months", EmitDefaultValue = false)]
        public long SixMonths { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public long Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeriesModelSearchV1RankOldPosition {\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  ThreeMonths: ").Append(ThreeMonths).Append("\n");
            sb.Append("  SixMonths: ").Append(SixMonths).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as SeriesModelSearchV1RankOldPosition);
        }

        /// <summary>
        /// Returns true if SeriesModelSearchV1RankOldPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesModelSearchV1RankOldPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesModelSearchV1RankOldPosition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Week == input.Week ||
                    this.Week.Equals(input.Week)
                ) && 
                (
                    this.Month == input.Month ||
                    this.Month.Equals(input.Month)
                ) && 
                (
                    this.ThreeMonths == input.ThreeMonths ||
                    this.ThreeMonths.Equals(input.ThreeMonths)
                ) && 
                (
                    this.SixMonths == input.SixMonths ||
                    this.SixMonths.Equals(input.SixMonths)
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
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
                hashCode = (hashCode * 59) + this.Week.GetHashCode();
                hashCode = (hashCode * 59) + this.Month.GetHashCode();
                hashCode = (hashCode * 59) + this.ThreeMonths.GetHashCode();
                hashCode = (hashCode * 59) + this.SixMonths.GetHashCode();
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
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
