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
    /// MiscSlowTransactionStatusResponseV1
    /// </summary>
    [DataContract(Name = "MiscSlowTransactionStatusResponseV1")]
    public partial class MiscSlowTransactionStatusResponseV1 : IEquatable<MiscSlowTransactionStatusResponseV1>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum InProgress for value: in progress
            /// </summary>
            [EnumMember(Value = "in progress")]
            InProgress = 2,

            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 3,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4

        }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscSlowTransactionStatusResponseV1" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="error">error.</param>
        /// <param name="percent">percent.</param>
        /// <param name="done">done.</param>
        /// <param name="total">total.</param>
        /// <param name="_return">_return.</param>
        public MiscSlowTransactionStatusResponseV1(StateEnum? state = default(StateEnum?), string error = default(string), decimal percent = default(decimal), long done = default(long), long total = default(long), string _return = default(string))
        {
            this.State = state;
            this.Error = error;
            this.Percent = percent;
            this.Done = done;
            this.Total = total;
            this.Return = _return;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal Percent { get; set; }

        /// <summary>
        /// Gets or Sets Done
        /// </summary>
        [DataMember(Name = "done", EmitDefaultValue = false)]
        public long Done { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public long Total { get; set; }

        /// <summary>
        /// Gets or Sets Return
        /// </summary>
        [DataMember(Name = "return", EmitDefaultValue = false)]
        public string Return { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiscSlowTransactionStatusResponseV1 {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Done: ").Append(Done).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Return: ").Append(Return).Append("\n");
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
            return this.Equals(input as MiscSlowTransactionStatusResponseV1);
        }

        /// <summary>
        /// Returns true if MiscSlowTransactionStatusResponseV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of MiscSlowTransactionStatusResponseV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiscSlowTransactionStatusResponseV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.Done == input.Done ||
                    this.Done.Equals(input.Done)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Return == input.Return ||
                    (this.Return != null &&
                    this.Return.Equals(input.Return))
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
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percent.GetHashCode();
                hashCode = (hashCode * 59) + this.Done.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Return != null)
                {
                    hashCode = (hashCode * 59) + this.Return.GetHashCode();
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