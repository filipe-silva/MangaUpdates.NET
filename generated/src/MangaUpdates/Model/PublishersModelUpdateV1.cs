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
    /// PublishersModelUpdateV1
    /// </summary>
    [DataContract(Name = "PublishersModelUpdateV1")]
    public partial class PublishersModelUpdateV1 : IEquatable<PublishersModelUpdateV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NA for value: N/A
            /// </summary>
            [EnumMember(Value = "N/A")]
            NA = 1,

            /// <summary>
            /// Enum Japanese for value: Japanese
            /// </summary>
            [EnumMember(Value = "Japanese")]
            Japanese = 2,

            /// <summary>
            /// Enum English for value: English
            /// </summary>
            [EnumMember(Value = "English")]
            English = 3,

            /// <summary>
            /// Enum Korean for value: Korean
            /// </summary>
            [EnumMember(Value = "Korean")]
            Korean = 4,

            /// <summary>
            /// Enum Taiwanese for value: Taiwanese
            /// </summary>
            [EnumMember(Value = "Taiwanese")]
            Taiwanese = 5,

            /// <summary>
            /// Enum Chinese for value: Chinese
            /// </summary>
            [EnumMember(Value = "Chinese")]
            Chinese = 6,

            /// <summary>
            /// Enum Thai for value: Thai
            /// </summary>
            [EnumMember(Value = "Thai")]
            Thai = 7,

            /// <summary>
            /// Enum Indonesian for value: Indonesian
            /// </summary>
            [EnumMember(Value = "Indonesian")]
            Indonesian = 8,

            /// <summary>
            /// Enum Filipino for value: Filipino
            /// </summary>
            [EnumMember(Value = "Filipino")]
            Filipino = 9,

            /// <summary>
            /// Enum Vietnamese for value: Vietnamese
            /// </summary>
            [EnumMember(Value = "Vietnamese")]
            Vietnamese = 10,

            /// <summary>
            /// Enum Malaysian for value: Malaysian
            /// </summary>
            [EnumMember(Value = "Malaysian")]
            Malaysian = 11,

            /// <summary>
            /// Enum Nordic for value: Nordic
            /// </summary>
            [EnumMember(Value = "Nordic")]
            Nordic = 12,

            /// <summary>
            /// Enum French for value: French
            /// </summary>
            [EnumMember(Value = "French")]
            French = 13,

            /// <summary>
            /// Enum Spanish for value: Spanish
            /// </summary>
            [EnumMember(Value = "Spanish")]
            Spanish = 14

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishersModelUpdateV1" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="associated">associated.</param>
        /// <param name="type">type.</param>
        /// <param name="info">info.</param>
        /// <param name="site">site.</param>
        /// <param name="admin">admin.</param>
        public PublishersModelUpdateV1(string name = default(string), List<PublishersModelUpdateV1Associated> associated = default(List<PublishersModelUpdateV1Associated>), TypeEnum? type = default(TypeEnum?), string info = default(string), string site = default(string), PublishersModelUpdateV1Admin admin = default(PublishersModelUpdateV1Admin))
        {
            this.Name = name;
            this.Associated = associated;
            this.Type = type;
            this.Info = info;
            this.Site = site;
            this.Admin = admin;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Associated
        /// </summary>
        [DataMember(Name = "associated", EmitDefaultValue = false)]
        public List<PublishersModelUpdateV1Associated> Associated { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public string Info { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        public string Site { get; set; }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public PublishersModelUpdateV1Admin Admin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishersModelUpdateV1 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Associated: ").Append(Associated).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
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
            return this.Equals(input as PublishersModelUpdateV1);
        }

        /// <summary>
        /// Returns true if PublishersModelUpdateV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PublishersModelUpdateV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishersModelUpdateV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Associated == input.Associated ||
                    this.Associated != null &&
                    input.Associated != null &&
                    this.Associated.SequenceEqual(input.Associated)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Associated != null)
                {
                    hashCode = (hashCode * 59) + this.Associated.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
                }
                if (this.Site != null)
                {
                    hashCode = (hashCode * 59) + this.Site.GetHashCode();
                }
                if (this.Admin != null)
                {
                    hashCode = (hashCode * 59) + this.Admin.GetHashCode();
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