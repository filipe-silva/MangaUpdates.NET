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
    ///  Class for testing ReviewsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReviewsApiTests : IDisposable
    {
        private ReviewsApi instance;

        public ReviewsApiTests()
        {
            instance = new ReviewsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReviewsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReviewsApi
            //Assert.IsType<ReviewsApi>(instance);
        }

        /// <summary>
        /// Test AddReview
        /// </summary>
        [Fact]
        public void AddReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReviewModelUpdateV1 reviewModelUpdateV1 = null;
            //var response = instance.AddReview(reviewModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddReviewComment
        /// </summary>
        [Fact]
        public void AddReviewCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //ReviewCommentModelUpdateV1 reviewCommentModelUpdateV1 = null;
            //var response = instance.AddReviewComment(id, reviewCommentModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteReview
        /// </summary>
        [Fact]
        public void DeleteReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteReview(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteReviewComment
        /// </summary>
        [Fact]
        public void DeleteReviewCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //var response = instance.DeleteReviewComment(id, commentId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveReview
        /// </summary>
        [Fact]
        public void RetrieveReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveReview(id, unrenderedFields);
            //Assert.IsType<ReviewModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveReviewComment
        /// </summary>
        [Fact]
        public void RetrieveReviewCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long commentId = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveReviewComment(id, commentId, unrenderedFields);
            //Assert.IsType<ReviewCommentModelV1>(response);
        }

        /// <summary>
        /// Test ReviewCommentsModerationPost
        /// </summary>
        [Fact]
        public void ReviewCommentsModerationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReviewCommentSearchRequestV1 reviewCommentSearchRequestV1 = null;
            //var response = instance.ReviewCommentsModerationPost(reviewCommentSearchRequestV1);
            //Assert.IsType<ReviewCommentSearchResponseV1>(response);
        }

        /// <summary>
        /// Test SearchReviewCommentsPost
        /// </summary>
        [Fact]
        public void SearchReviewCommentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //ReviewCommentSearchRequestV1 reviewCommentSearchRequestV1 = null;
            //var response = instance.SearchReviewCommentsPost(id, reviewCommentSearchRequestV1);
            //Assert.IsType<ReviewCommentSearchResponseV1>(response);
        }

        /// <summary>
        /// Test SearchReviewsPost
        /// </summary>
        [Fact]
        public void SearchReviewsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReviewSearchRequestV1 reviewSearchRequestV1 = null;
            //var response = instance.SearchReviewsPost(reviewSearchRequestV1);
            //Assert.IsType<ReviewSearchResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateReview
        /// </summary>
        [Fact]
        public void UpdateReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //ReviewModelUpdateV1 reviewModelUpdateV1 = null;
            //var response = instance.UpdateReview(id, reviewModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateReviewComment
        /// </summary>
        [Fact]
        public void UpdateReviewCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int commentId = null;
            //ReviewCommentModelUpdateV1 reviewCommentModelUpdateV1 = null;
            //var response = instance.UpdateReviewComment(id, commentId, reviewCommentModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }
    }
}
