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
    /// SeriesHistoryModelV1
    /// </summary>
    [DataContract(Name = "SeriesHistoryModelV1")]
    public partial class SeriesHistoryModelV1 : IEquatable<SeriesHistoryModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesHistoryModelV1" /> class.
        /// </summary>
        /// <param name="changeId">changeId.</param>
        /// <param name="username">username.</param>
        /// <param name="action">action.</param>
        /// <param name="changed">changed.</param>
        /// <param name="timeAdded">timeAdded.</param>
        public SeriesHistoryModelV1(long changeId = default(long), string username = default(string), string action = default(string), string changed = default(string), TimeV1 timeAdded = default(TimeV1))
        {
            this.ChangeId = changeId;
            this.Username = username;
            this.Action = action;
            this.Changed = changed;
            this.TimeAdded = timeAdded;
        }

        /// <summary>
        /// Gets or Sets ChangeId
        /// </summary>
        [DataMember(Name = "change_id", EmitDefaultValue = false)]
        public long ChangeId { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Changed
        /// </summary>
        [DataMember(Name = "changed", EmitDefaultValue = false)]
        public string Changed { get; set; }

        /// <summary>
        /// Gets or Sets TimeAdded
        /// </summary>
        [DataMember(Name = "time_added", EmitDefaultValue = false)]
        public TimeV1 TimeAdded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeriesHistoryModelV1 {\n");
            sb.Append("  ChangeId: ").Append(ChangeId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Changed: ").Append(Changed).Append("\n");
            sb.Append("  TimeAdded: ").Append(TimeAdded).Append("\n");
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
            return this.Equals(input as SeriesHistoryModelV1);
        }

        /// <summary>
        /// Returns true if SeriesHistoryModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesHistoryModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesHistoryModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChangeId == input.ChangeId ||
                    this.ChangeId.Equals(input.ChangeId)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Changed == input.Changed ||
                    (this.Changed != null &&
                    this.Changed.Equals(input.Changed))
                ) && 
                (
                    this.TimeAdded == input.TimeAdded ||
                    (this.TimeAdded != null &&
                    this.TimeAdded.Equals(input.TimeAdded))
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
                hashCode = (hashCode * 59) + this.ChangeId.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Changed != null)
                {
                    hashCode = (hashCode * 59) + this.Changed.GetHashCode();
                }
                if (this.TimeAdded != null)
                {
                    hashCode = (hashCode * 59) + this.TimeAdded.GetHashCode();
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