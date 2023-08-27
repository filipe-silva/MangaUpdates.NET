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
    /// UserModelUpdateV1
    /// </summary>
    [DataContract(Name = "UserModelUpdateV1")]
    public partial class UserModelUpdateV1 : IEquatable<UserModelUpdateV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Gender
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            /// <summary>
            /// Enum NA for value: N/A
            /// </summary>
            [EnumMember(Value = "N/A")]
            NA = 1,

            /// <summary>
            /// Enum Male for value: Male
            /// </summary>
            [EnumMember(Value = "Male")]
            Male = 2,

            /// <summary>
            /// Enum Female for value: Female
            /// </summary>
            [EnumMember(Value = "Female")]
            Female = 3,

            /// <summary>
            /// Enum Alien for value: Alien
            /// </summary>
            [EnumMember(Value = "Alien")]
            Alien = 4,

            /// <summary>
            /// Enum Hermaphrodite for value: Hermaphrodite
            /// </summary>
            [EnumMember(Value = "Hermaphrodite")]
            Hermaphrodite = 5

        }


        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserModelUpdateV1" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="newAvatarId">newAvatarId.</param>
        /// <param name="gender">gender.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="signature">signature.</param>
        /// <param name="location">location.</param>
        /// <param name="forumTitle">forumTitle.</param>
        /// <param name="foldingAtHome">foldingAtHome.</param>
        /// <param name="profile">profile.</param>
        /// <param name="admin">admin.</param>
        /// <param name="userGroup">userGroup.</param>
        public UserModelUpdateV1(string username = default(string), string email = default(string), string password = default(string), long newAvatarId = default(long), GenderEnum? gender = default(GenderEnum?), BirthdayModelV1 birthday = default(BirthdayModelV1), long timezone = default(long), string signature = default(string), string location = default(string), string forumTitle = default(string), bool foldingAtHome = default(bool), UserModelUpdateV1Profile profile = default(UserModelUpdateV1Profile), UserModelUpdateV1Admin admin = default(UserModelUpdateV1Admin), string userGroup = default(string))
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.NewAvatarId = newAvatarId;
            this.Gender = gender;
            this.Birthday = birthday;
            this.Timezone = timezone;
            this.Signature = signature;
            this.Location = location;
            this.ForumTitle = forumTitle;
            this.FoldingAtHome = foldingAtHome;
            this.Profile = profile;
            this.Admin = admin;
            this.UserGroup = userGroup;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets NewAvatarId
        /// </summary>
        [DataMember(Name = "new_avatar_id", EmitDefaultValue = false)]
        public long NewAvatarId { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = false)]
        public BirthdayModelV1 Birthday { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public long Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets ForumTitle
        /// </summary>
        [DataMember(Name = "forum_title", EmitDefaultValue = false)]
        public string ForumTitle { get; set; }

        /// <summary>
        /// Gets or Sets FoldingAtHome
        /// </summary>
        [DataMember(Name = "folding_at_home", EmitDefaultValue = true)]
        public bool FoldingAtHome { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public UserModelUpdateV1Profile Profile { get; set; }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public UserModelUpdateV1Admin Admin { get; set; }

        /// <summary>
        /// Gets or Sets UserGroup
        /// </summary>
        [DataMember(Name = "user_group", EmitDefaultValue = false)]
        public string UserGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserModelUpdateV1 {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  NewAvatarId: ").Append(NewAvatarId).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ForumTitle: ").Append(ForumTitle).Append("\n");
            sb.Append("  FoldingAtHome: ").Append(FoldingAtHome).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  UserGroup: ").Append(UserGroup).Append("\n");
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
            return this.Equals(input as UserModelUpdateV1);
        }

        /// <summary>
        /// Returns true if UserModelUpdateV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserModelUpdateV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserModelUpdateV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.NewAvatarId == input.NewAvatarId ||
                    this.NewAvatarId.Equals(input.NewAvatarId)
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    this.Timezone.Equals(input.Timezone)
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ForumTitle == input.ForumTitle ||
                    (this.ForumTitle != null &&
                    this.ForumTitle.Equals(input.ForumTitle))
                ) && 
                (
                    this.FoldingAtHome == input.FoldingAtHome ||
                    this.FoldingAtHome.Equals(input.FoldingAtHome)
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.UserGroup == input.UserGroup ||
                    (this.UserGroup != null &&
                    this.UserGroup.Equals(input.UserGroup))
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
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NewAvatarId.GetHashCode();
                hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.ForumTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ForumTitle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FoldingAtHome.GetHashCode();
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.Admin != null)
                {
                    hashCode = (hashCode * 59) + this.Admin.GetHashCode();
                }
                if (this.UserGroup != null)
                {
                    hashCode = (hashCode * 59) + this.UserGroup.GetHashCode();
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