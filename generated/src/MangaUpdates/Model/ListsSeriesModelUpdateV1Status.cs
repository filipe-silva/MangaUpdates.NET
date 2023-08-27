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
    /// ListsSeriesModelUpdateV1Status
    /// </summary>
    [DataContract(Name = "ListsSeriesModelUpdateV1Status")]
    public partial class ListsSeriesModelUpdateV1Status : IEquatable<ListsSeriesModelUpdateV1Status>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListsSeriesModelUpdateV1Status" /> class.
        /// </summary>
        /// <param name="volume">volume.</param>
        /// <param name="chapter">chapter.</param>
        /// <param name="incrementVolume">incrementVolume.</param>
        /// <param name="incrementChapter">incrementChapter.</param>
        public ListsSeriesModelUpdateV1Status(long volume = default(long), long chapter = default(long), long incrementVolume = default(long), long incrementChapter = default(long))
        {
            this.Volume = volume;
            this.Chapter = chapter;
            this.IncrementVolume = incrementVolume;
            this.IncrementChapter = incrementChapter;
        }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public long Volume { get; set; }

        /// <summary>
        /// Gets or Sets Chapter
        /// </summary>
        [DataMember(Name = "chapter", EmitDefaultValue = false)]
        public long Chapter { get; set; }

        /// <summary>
        /// Gets or Sets IncrementVolume
        /// </summary>
        [DataMember(Name = "increment_volume", EmitDefaultValue = false)]
        public long IncrementVolume { get; set; }

        /// <summary>
        /// Gets or Sets IncrementChapter
        /// </summary>
        [DataMember(Name = "increment_chapter", EmitDefaultValue = false)]
        public long IncrementChapter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListsSeriesModelUpdateV1Status {\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Chapter: ").Append(Chapter).Append("\n");
            sb.Append("  IncrementVolume: ").Append(IncrementVolume).Append("\n");
            sb.Append("  IncrementChapter: ").Append(IncrementChapter).Append("\n");
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
            return this.Equals(input as ListsSeriesModelUpdateV1Status);
        }

        /// <summary>
        /// Returns true if ListsSeriesModelUpdateV1Status instances are equal
        /// </summary>
        /// <param name="input">Instance of ListsSeriesModelUpdateV1Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListsSeriesModelUpdateV1Status input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
                ) && 
                (
                    this.Chapter == input.Chapter ||
                    this.Chapter.Equals(input.Chapter)
                ) && 
                (
                    this.IncrementVolume == input.IncrementVolume ||
                    this.IncrementVolume.Equals(input.IncrementVolume)
                ) && 
                (
                    this.IncrementChapter == input.IncrementChapter ||
                    this.IncrementChapter.Equals(input.IncrementChapter)
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
                hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                hashCode = (hashCode * 59) + this.Chapter.GetHashCode();
                hashCode = (hashCode * 59) + this.IncrementVolume.GetHashCode();
                hashCode = (hashCode * 59) + this.IncrementChapter.GetHashCode();
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
