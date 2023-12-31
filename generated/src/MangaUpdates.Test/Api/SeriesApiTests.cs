/*
 * MangaUpdates API
 *
 * This API powers our website. Most API functions are public and do not require an account. For user-based functions, you must register an account. Currently, user registration must be done through our main website and is disabled via this API.  Download OpenAPI Specification: [openapi.yaml](openapi.yaml)  Please contact us at the following emails if you have questions:  * lambchopsil@mangaupdates.com * manick@mangaupdates.com  ## Warranties  MangaUpdates makes no warranties about service availability, correctness of the data, or anything else. The service is provided as is, and may change at any time.  ## Acceptable Use Policy  * You will credit MangaUpdates when using data provided by this API. * You will use reasonable spacing between requests so as not to overwhelm the MangaUpdates servers, and employ caching mechanisms when accessing data. * You will NOT use MangaUpdates data or API in a way that will:     * Deceive or defraud users     * Assist or perform an illegal action     * Create spam     * Damage the database  We reserve the right to change this policy at any time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using MangaUpdates.Client;
using MangaUpdates.Api;
// uncomment below to import models
//using MangaUpdates.Model;

namespace MangaUpdates.Test.Api
{
    /// <summary>
    ///  Class for testing SeriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SeriesApiTests : IDisposable
    {
        private SeriesApi instance;

        public SeriesApiTests()
        {
            instance = new SeriesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SeriesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SeriesApi
            //Assert.IsType<SeriesApi>(instance);
        }

        /// <summary>
        /// Test AddSeries
        /// </summary>
        [Fact]
        public void AddSeriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeriesModelUpdateV1 seriesModelUpdateV1 = null;
            //var response = instance.AddSeries(seriesModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddSeriesCategoryVote
        /// </summary>
        [Fact]
        public void AddSeriesCategoryVoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SeriesCategoryVoteModelV1 seriesCategoryVoteModelV1 = null;
            //var response = instance.AddSeriesCategoryVote(id, seriesCategoryVoteModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddSeriesComment
        /// </summary>
        [Fact]
        public void AddSeriesCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SeriesCommentModelUpdateV1 seriesCommentModelUpdateV1 = null;
            //var response = instance.AddSeriesComment(id, seriesCommentModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddSeriesCommentUsefulFlag
        /// </summary>
        [Fact]
        public void AddSeriesCommentUsefulFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //SeriesCommentUsefulModelV1 seriesCommentUsefulModelV1 = null;
            //var response = instance.AddSeriesCommentUsefulFlag(id, commentId, seriesCommentUsefulModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test CombineSeriesCategories
        /// </summary>
        [Fact]
        public void CombineSeriesCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1 = null;
            //var response = instance.CombineSeriesCategories(id, seriesCategoryUpdateModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteSeries
        /// </summary>
        [Fact]
        public void DeleteSeriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteSeries(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteSeriesCategory
        /// </summary>
        [Fact]
        public void DeleteSeriesCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //CategoriesModelUpdateV1 categoriesModelUpdateV1 = null;
            //var response = instance.DeleteSeriesCategory(id, categoriesModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteSeriesComment
        /// </summary>
        [Fact]
        public void DeleteSeriesCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //var response = instance.DeleteSeriesComment(id, commentId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteSeriesImage
        /// </summary>
        [Fact]
        public void DeleteSeriesImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.DeleteSeriesImage(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteUserSeriesRating
        /// </summary>
        [Fact]
        public void DeleteUserSeriesRatingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteUserSeriesRating(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test LockSeriesField
        /// </summary>
        [Fact]
        public void LockSeriesFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string item = null;
            //SeriesLockModelUpdateV1 seriesLockModelUpdateV1 = null;
            //var response = instance.LockSeriesField(id, item, seriesLockModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RemoveSeriesCategoryVote
        /// </summary>
        [Fact]
        public void RemoveSeriesCategoryVoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SeriesCategoryVoteDeleteModelV1 seriesCategoryVoteDeleteModelV1 = null;
            //var response = instance.RemoveSeriesCategoryVote(id, seriesCategoryVoteDeleteModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RemoveSeriesCommentUsefulFlag
        /// </summary>
        [Fact]
        public void RemoveSeriesCommentUsefulFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //var response = instance.RemoveSeriesCommentUsefulFlag(id, commentId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RenameSeriesCategory
        /// </summary>
        [Fact]
        public void RenameSeriesCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1 = null;
            //var response = instance.RenameSeriesCategory(id, seriesCategoryUpdateModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test ReportSeriesComment
        /// </summary>
        [Fact]
        public void ReportSeriesCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //SeriesCommentReportModelV1 seriesCommentReportModelV1 = null;
            //var response = instance.ReportSeriesComment(id, commentId, seriesCommentReportModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveMySeriesComment
        /// </summary>
        [Fact]
        public void RetrieveMySeriesCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveMySeriesComment(id, unrenderedFields);
            //Assert.IsType<SeriesCommentModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveSeries
        /// </summary>
        [Fact]
        public void RetrieveSeriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveSeries(id, unrenderedFields);
            //Assert.IsType<SeriesModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesCategoryVotes
        /// </summary>
        [Fact]
        public void RetrieveSeriesCategoryVotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveSeriesCategoryVotes(id);
            //Assert.IsType<List<SeriesCategoryVoteModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesComment
        /// </summary>
        [Fact]
        public void RetrieveSeriesCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long commentId = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveSeriesComment(id, commentId, unrenderedFields);
            //Assert.IsType<SeriesCommentModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesCommentLocation
        /// </summary>
        [Fact]
        public void RetrieveSeriesCommentLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long commentId = null;
            //var response = instance.RetrieveSeriesCommentLocation(id, commentId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesGroups
        /// </summary>
        [Fact]
        public void RetrieveSeriesGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveSeriesGroups(id);
            //Assert.IsType<SeriesGroupListResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesLocks
        /// </summary>
        [Fact]
        public void RetrieveSeriesLocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveSeriesLocks(id);
            //Assert.IsType<List<SeriesLockModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesRankLocation
        /// </summary>
        [Fact]
        public void RetrieveSeriesRankLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string type = null;
            //var response = instance.RetrieveSeriesRankLocation(id, type);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveSeriesRatingRainbow
        /// </summary>
        [Fact]
        public void RetrieveSeriesRatingRainbowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveSeriesRatingRainbow(id);
            //Assert.IsType<SeriesRatingRainbowModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveUserSeriesRating
        /// </summary>
        [Fact]
        public void RetrieveUserSeriesRatingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveUserSeriesRating(id);
            //Assert.IsType<SeriesRatingModelV1>(response);
        }

        /// <summary>
        /// Test SearchSeriesCommentsPost
        /// </summary>
        [Fact]
        public void SearchSeriesCommentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //SeriesCommentSearchRequestV1 seriesCommentSearchRequestV1 = null;
            //var response = instance.SearchSeriesCommentsPost(id, seriesCommentSearchRequestV1);
            //Assert.IsType<SeriesCommentSearchResponseV1>(response);
        }

        /// <summary>
        /// Test SearchSeriesHistoryPost
        /// </summary>
        [Fact]
        public void SearchSeriesHistoryPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //PerPageSearchRequestV1 perPageSearchRequestV1 = null;
            //var response = instance.SearchSeriesHistoryPost(id, perPageSearchRequestV1);
            //Assert.IsType<SeriesHistorySearchResponseV1>(response);
        }

        /// <summary>
        /// Test SearchSeriesPost
        /// </summary>
        [Fact]
        public void SearchSeriesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeriesSearchRequestV1 seriesSearchRequestV1 = null;
            //var response = instance.SearchSeriesPost(seriesSearchRequestV1);
            //Assert.IsType<SeriesSearchResponseV1>(response);
        }

        /// <summary>
        /// Test SeriesCommentsModerationPost
        /// </summary>
        [Fact]
        public void SeriesCommentsModerationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SeriesCommentSearchRequestV1 seriesCommentSearchRequestV1 = null;
            //var response = instance.SeriesCommentsModerationPost(seriesCommentSearchRequestV1);
            //Assert.IsType<SeriesCommentModerationResponseV1>(response);
        }

        /// <summary>
        /// Test SeriesReleaseRssFeed
        /// </summary>
        [Fact]
        public void SeriesReleaseRssFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.SeriesReleaseRssFeed(id);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UnlockSeriesField
        /// </summary>
        [Fact]
        public void UnlockSeriesFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string item = null;
            //var response = instance.UnlockSeriesField(id, item);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateSeries
        /// </summary>
        [Fact]
        public void UpdateSeriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SeriesModelUpdateV1 seriesModelUpdateV1 = null;
            //var response = instance.UpdateSeries(id, seriesModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateSeriesComment
        /// </summary>
        [Fact]
        public void UpdateSeriesCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //SeriesCommentModelUpdateV1 seriesCommentModelUpdateV1 = null;
            //var response = instance.UpdateSeriesComment(id, commentId, seriesCommentModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateSeriesImage
        /// </summary>
        [Fact]
        public void UpdateSeriesImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //System.IO.Stream image = null;
            //var response = instance.UpdateSeriesImage(id, image);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateUserSeriesRating
        /// </summary>
        [Fact]
        public void UpdateUserSeriesRatingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //SeriesRatingModelV1 seriesRatingModelV1 = null;
            //var response = instance.UpdateUserSeriesRating(id, seriesRatingModelV1);
            //Assert.IsType<ApiResponseV1>(response);
        }
    }
}
