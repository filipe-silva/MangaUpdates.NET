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
    /// AuthorsSeriesListResponseV1
    /// </summary>
    [DataContract(Name = "AuthorsSeriesListResponseV1")]
    public partial class AuthorsSeriesListResponseV1 : IEquatable<AuthorsSeriesListResponseV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsSeriesListResponseV1" /> class.
        /// </summary>
        /// <param name="totalSeries">totalSeries.</param>
        /// <param name="seriesList">seriesList.</param>
        /// <param name="genreList">genreList.</param>
        public AuthorsSeriesListResponseV1(long totalSeries = default(long), List<AuthorsSeriesListResponseV1SeriesList> seriesList = default(List<AuthorsSeriesListResponseV1SeriesList>), List<AuthorsSeriesListResponseV1GenreList> genreList = default(List<AuthorsSeriesListResponseV1GenreList>))
        {
            this.TotalSeries = totalSeries;
            this.SeriesList = seriesList;
            this.GenreList = genreList;
        }

        /// <summary>
        /// Gets or Sets TotalSeries
        /// </summary>
        [DataMember(Name = "total_series", EmitDefaultValue = false)]
        public long TotalSeries { get; set; }

        /// <summary>
        /// Gets or Sets SeriesList
        /// </summary>
        [DataMember(Name = "series_list", EmitDefaultValue = false)]
        public List<AuthorsSeriesListResponseV1SeriesList> SeriesList { get; set; }

        /// <summary>
        /// Gets or Sets GenreList
        /// </summary>
        [DataMember(Name = "genre_list", EmitDefaultValue = false)]
        public List<AuthorsSeriesListResponseV1GenreList> GenreList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorsSeriesListResponseV1 {\n");
            sb.Append("  TotalSeries: ").Append(TotalSeries).Append("\n");
            sb.Append("  SeriesList: ").Append(SeriesList).Append("\n");
            sb.Append("  GenreList: ").Append(GenreList).Append("\n");
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
            return this.Equals(input as AuthorsSeriesListResponseV1);
        }

        /// <summary>
        /// Returns true if AuthorsSeriesListResponseV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorsSeriesListResponseV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorsSeriesListResponseV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalSeries == input.TotalSeries ||
                    this.TotalSeries.Equals(input.TotalSeries)
                ) && 
                (
                    this.SeriesList == input.SeriesList ||
                    this.SeriesList != null &&
                    input.SeriesList != null &&
                    this.SeriesList.SequenceEqual(input.SeriesList)
                ) && 
                (
                    this.GenreList == input.GenreList ||
                    this.GenreList != null &&
                    input.GenreList != null &&
                    this.GenreList.SequenceEqual(input.GenreList)
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
                hashCode = (hashCode * 59) + this.TotalSeries.GetHashCode();
                if (this.SeriesList != null)
                {
                    hashCode = (hashCode * 59) + this.SeriesList.GetHashCode();
                }
                if (this.GenreList != null)
                {
                    hashCode = (hashCode * 59) + this.GenreList.GetHashCode();
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
