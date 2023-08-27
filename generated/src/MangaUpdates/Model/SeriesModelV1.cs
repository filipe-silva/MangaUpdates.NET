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
    /// SeriesModelV1
    /// </summary>
    [DataContract(Name = "SeriesModelV1")]
    public partial class SeriesModelV1 : IEquatable<SeriesModelV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Artbook for value: Artbook
            /// </summary>
            [EnumMember(Value = "Artbook")]
            Artbook = 1,

            /// <summary>
            /// Enum Doujinshi for value: Doujinshi
            /// </summary>
            [EnumMember(Value = "Doujinshi")]
            Doujinshi = 2,

            /// <summary>
            /// Enum DramaCD for value: Drama CD
            /// </summary>
            [EnumMember(Value = "Drama CD")]
            DramaCD = 3,

            /// <summary>
            /// Enum Filipino for value: Filipino
            /// </summary>
            [EnumMember(Value = "Filipino")]
            Filipino = 4,

            /// <summary>
            /// Enum Indonesian for value: Indonesian
            /// </summary>
            [EnumMember(Value = "Indonesian")]
            Indonesian = 5,

            /// <summary>
            /// Enum Manga for value: Manga
            /// </summary>
            [EnumMember(Value = "Manga")]
            Manga = 6,

            /// <summary>
            /// Enum Manhwa for value: Manhwa
            /// </summary>
            [EnumMember(Value = "Manhwa")]
            Manhwa = 7,

            /// <summary>
            /// Enum Manhua for value: Manhua
            /// </summary>
            [EnumMember(Value = "Manhua")]
            Manhua = 8,

            /// <summary>
            /// Enum Novel for value: Novel
            /// </summary>
            [EnumMember(Value = "Novel")]
            Novel = 9,

            /// <summary>
            /// Enum OEL for value: OEL
            /// </summary>
            [EnumMember(Value = "OEL")]
            OEL = 10,

            /// <summary>
            /// Enum Thai for value: Thai
            /// </summary>
            [EnumMember(Value = "Thai")]
            Thai = 11,

            /// <summary>
            /// Enum Vietnamese for value: Vietnamese
            /// </summary>
            [EnumMember(Value = "Vietnamese")]
            Vietnamese = 12,

            /// <summary>
            /// Enum Malaysian for value: Malaysian
            /// </summary>
            [EnumMember(Value = "Malaysian")]
            Malaysian = 13,

            /// <summary>
            /// Enum Nordic for value: Nordic
            /// </summary>
            [EnumMember(Value = "Nordic")]
            Nordic = 14,

            /// <summary>
            /// Enum French for value: French
            /// </summary>
            [EnumMember(Value = "French")]
            French = 15,

            /// <summary>
            /// Enum Spanish for value: Spanish
            /// </summary>
            [EnumMember(Value = "Spanish")]
            Spanish = 16

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModelV1" /> class.
        /// </summary>
        /// <param name="seriesId">seriesId.</param>
        /// <param name="title">title.</param>
        /// <param name="url">url.</param>
        /// <param name="associated">associated.</param>
        /// <param name="description">description.</param>
        /// <param name="image">image.</param>
        /// <param name="type">type.</param>
        /// <param name="year">year.</param>
        /// <param name="bayesianRating">bayesianRating.</param>
        /// <param name="ratingVotes">ratingVotes.</param>
        /// <param name="genres">genres.</param>
        /// <param name="categories">categories.</param>
        /// <param name="latestChapter">latestChapter.</param>
        /// <param name="forumId">forumId.</param>
        /// <param name="status">status.</param>
        /// <param name="licensed">licensed.</param>
        /// <param name="completed">completed.</param>
        /// <param name="anime">anime.</param>
        /// <param name="relatedSeries">relatedSeries.</param>
        /// <param name="authors">authors.</param>
        /// <param name="publishers">publishers.</param>
        /// <param name="publications">publications.</param>
        /// <param name="recommendations">recommendations.</param>
        /// <param name="categoryRecommendations">categoryRecommendations.</param>
        /// <param name="rank">rank.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="admin">admin.</param>
        public SeriesModelV1(long seriesId = default(long), string title = default(string), string url = default(string), List<SeriesModelV1Associated> associated = default(List<SeriesModelV1Associated>), string description = default(string), ImageModelV1 image = default(ImageModelV1), TypeEnum? type = default(TypeEnum?), string year = default(string), decimal bayesianRating = default(decimal), long ratingVotes = default(long), List<SeriesModelV1Genres> genres = default(List<SeriesModelV1Genres>), List<CategoriesModelV1> categories = default(List<CategoriesModelV1>), long latestChapter = default(long), long forumId = default(long), string status = default(string), bool licensed = default(bool), bool completed = default(bool), SeriesModelV1Anime anime = default(SeriesModelV1Anime), List<SeriesModelV1RelatedSeries> relatedSeries = default(List<SeriesModelV1RelatedSeries>), List<SeriesModelV1Authors> authors = default(List<SeriesModelV1Authors>), List<SeriesModelV1Publishers> publishers = default(List<SeriesModelV1Publishers>), List<SeriesModelV1Publications> publications = default(List<SeriesModelV1Publications>), List<SeriesRecommendationsModelV1> recommendations = default(List<SeriesRecommendationsModelV1>), List<SeriesRecommendationsModelV1> categoryRecommendations = default(List<SeriesRecommendationsModelV1>), SeriesModelV1Rank rank = default(SeriesModelV1Rank), TimeV1 lastUpdated = default(TimeV1), SeriesModelV1Admin admin = default(SeriesModelV1Admin))
        {
            this.SeriesId = seriesId;
            this.Title = title;
            this.Url = url;
            this.Associated = associated;
            this.Description = description;
            this.Image = image;
            this.Type = type;
            this.Year = year;
            this.BayesianRating = bayesianRating;
            this.RatingVotes = ratingVotes;
            this.Genres = genres;
            this.Categories = categories;
            this.LatestChapter = latestChapter;
            this.ForumId = forumId;
            this.Status = status;
            this.Licensed = licensed;
            this.Completed = completed;
            this.Anime = anime;
            this.RelatedSeries = relatedSeries;
            this.Authors = authors;
            this.Publishers = publishers;
            this.Publications = publications;
            this.Recommendations = recommendations;
            this.CategoryRecommendations = categoryRecommendations;
            this.Rank = rank;
            this.LastUpdated = lastUpdated;
            this.Admin = admin;
        }

        /// <summary>
        /// Gets or Sets SeriesId
        /// </summary>
        [DataMember(Name = "series_id", EmitDefaultValue = false)]
        public long SeriesId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Associated
        /// </summary>
        [DataMember(Name = "associated", EmitDefaultValue = false)]
        public List<SeriesModelV1Associated> Associated { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public ImageModelV1 Image { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets BayesianRating
        /// </summary>
        [DataMember(Name = "bayesian_rating", EmitDefaultValue = false)]
        public decimal BayesianRating { get; set; }

        /// <summary>
        /// Gets or Sets RatingVotes
        /// </summary>
        [DataMember(Name = "rating_votes", EmitDefaultValue = false)]
        public long RatingVotes { get; set; }

        /// <summary>
        /// Gets or Sets Genres
        /// </summary>
        [DataMember(Name = "genres", EmitDefaultValue = false)]
        public List<SeriesModelV1Genres> Genres { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<CategoriesModelV1> Categories { get; set; }

        /// <summary>
        /// Gets or Sets LatestChapter
        /// </summary>
        [DataMember(Name = "latest_chapter", EmitDefaultValue = false)]
        public long LatestChapter { get; set; }

        /// <summary>
        /// Gets or Sets ForumId
        /// </summary>
        [DataMember(Name = "forum_id", EmitDefaultValue = false)]
        public long ForumId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Licensed
        /// </summary>
        [DataMember(Name = "licensed", EmitDefaultValue = true)]
        public bool Licensed { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or Sets Anime
        /// </summary>
        [DataMember(Name = "anime", EmitDefaultValue = false)]
        public SeriesModelV1Anime Anime { get; set; }

        /// <summary>
        /// Gets or Sets RelatedSeries
        /// </summary>
        [DataMember(Name = "related_series", EmitDefaultValue = false)]
        public List<SeriesModelV1RelatedSeries> RelatedSeries { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<SeriesModelV1Authors> Authors { get; set; }

        /// <summary>
        /// Gets or Sets Publishers
        /// </summary>
        [DataMember(Name = "publishers", EmitDefaultValue = false)]
        public List<SeriesModelV1Publishers> Publishers { get; set; }

        /// <summary>
        /// Gets or Sets Publications
        /// </summary>
        [DataMember(Name = "publications", EmitDefaultValue = false)]
        public List<SeriesModelV1Publications> Publications { get; set; }

        /// <summary>
        /// Gets or Sets Recommendations
        /// </summary>
        [DataMember(Name = "recommendations", EmitDefaultValue = false)]
        public List<SeriesRecommendationsModelV1> Recommendations { get; set; }

        /// <summary>
        /// Gets or Sets CategoryRecommendations
        /// </summary>
        [DataMember(Name = "category_recommendations", EmitDefaultValue = false)]
        public List<SeriesRecommendationsModelV1> CategoryRecommendations { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public SeriesModelV1Rank Rank { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "last_updated", EmitDefaultValue = false)]
        public TimeV1 LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public SeriesModelV1Admin Admin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeriesModelV1 {\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Associated: ").Append(Associated).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  BayesianRating: ").Append(BayesianRating).Append("\n");
            sb.Append("  RatingVotes: ").Append(RatingVotes).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  LatestChapter: ").Append(LatestChapter).Append("\n");
            sb.Append("  ForumId: ").Append(ForumId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Licensed: ").Append(Licensed).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Anime: ").Append(Anime).Append("\n");
            sb.Append("  RelatedSeries: ").Append(RelatedSeries).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  Publishers: ").Append(Publishers).Append("\n");
            sb.Append("  Publications: ").Append(Publications).Append("\n");
            sb.Append("  Recommendations: ").Append(Recommendations).Append("\n");
            sb.Append("  CategoryRecommendations: ").Append(CategoryRecommendations).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as SeriesModelV1);
        }

        /// <summary>
        /// Returns true if SeriesModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SeriesId == input.SeriesId ||
                    this.SeriesId.Equals(input.SeriesId)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Associated == input.Associated ||
                    this.Associated != null &&
                    input.Associated != null &&
                    this.Associated.SequenceEqual(input.Associated)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.BayesianRating == input.BayesianRating ||
                    this.BayesianRating.Equals(input.BayesianRating)
                ) && 
                (
                    this.RatingVotes == input.RatingVotes ||
                    this.RatingVotes.Equals(input.RatingVotes)
                ) && 
                (
                    this.Genres == input.Genres ||
                    this.Genres != null &&
                    input.Genres != null &&
                    this.Genres.SequenceEqual(input.Genres)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.LatestChapter == input.LatestChapter ||
                    this.LatestChapter.Equals(input.LatestChapter)
                ) && 
                (
                    this.ForumId == input.ForumId ||
                    this.ForumId.Equals(input.ForumId)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Licensed == input.Licensed ||
                    this.Licensed.Equals(input.Licensed)
                ) && 
                (
                    this.Completed == input.Completed ||
                    this.Completed.Equals(input.Completed)
                ) && 
                (
                    this.Anime == input.Anime ||
                    (this.Anime != null &&
                    this.Anime.Equals(input.Anime))
                ) && 
                (
                    this.RelatedSeries == input.RelatedSeries ||
                    this.RelatedSeries != null &&
                    input.RelatedSeries != null &&
                    this.RelatedSeries.SequenceEqual(input.RelatedSeries)
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                ) && 
                (
                    this.Publishers == input.Publishers ||
                    this.Publishers != null &&
                    input.Publishers != null &&
                    this.Publishers.SequenceEqual(input.Publishers)
                ) && 
                (
                    this.Publications == input.Publications ||
                    this.Publications != null &&
                    input.Publications != null &&
                    this.Publications.SequenceEqual(input.Publications)
                ) && 
                (
                    this.Recommendations == input.Recommendations ||
                    this.Recommendations != null &&
                    input.Recommendations != null &&
                    this.Recommendations.SequenceEqual(input.Recommendations)
                ) && 
                (
                    this.CategoryRecommendations == input.CategoryRecommendations ||
                    this.CategoryRecommendations != null &&
                    input.CategoryRecommendations != null &&
                    this.CategoryRecommendations.SequenceEqual(input.CategoryRecommendations)
                ) && 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                hashCode = (hashCode * 59) + this.SeriesId.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Associated != null)
                {
                    hashCode = (hashCode * 59) + this.Associated.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Year != null)
                {
                    hashCode = (hashCode * 59) + this.Year.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BayesianRating.GetHashCode();
                hashCode = (hashCode * 59) + this.RatingVotes.GetHashCode();
                if (this.Genres != null)
                {
                    hashCode = (hashCode * 59) + this.Genres.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LatestChapter.GetHashCode();
                hashCode = (hashCode * 59) + this.ForumId.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Licensed.GetHashCode();
                hashCode = (hashCode * 59) + this.Completed.GetHashCode();
                if (this.Anime != null)
                {
                    hashCode = (hashCode * 59) + this.Anime.GetHashCode();
                }
                if (this.RelatedSeries != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedSeries.GetHashCode();
                }
                if (this.Authors != null)
                {
                    hashCode = (hashCode * 59) + this.Authors.GetHashCode();
                }
                if (this.Publishers != null)
                {
                    hashCode = (hashCode * 59) + this.Publishers.GetHashCode();
                }
                if (this.Publications != null)
                {
                    hashCode = (hashCode * 59) + this.Publications.GetHashCode();
                }
                if (this.Recommendations != null)
                {
                    hashCode = (hashCode * 59) + this.Recommendations.GetHashCode();
                }
                if (this.CategoryRecommendations != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryRecommendations.GetHashCode();
                }
                if (this.Rank != null)
                {
                    hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
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