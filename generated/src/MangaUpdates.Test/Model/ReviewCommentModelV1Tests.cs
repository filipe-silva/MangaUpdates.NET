/*
 * MangaUpdates API
 *
 * This API powers our website. Most API functions are public and do not require an account. For user-based functions, you must register an account. Currently, user registration must be done through our main website and is disabled via this API.  Download OpenAPI Specification: [openapi.yaml](openapi.yaml)  Please contact us at the following emails if you have questions:  * lambchopsil@mangaupdates.com * manick@mangaupdates.com  ## Warranties  MangaUpdates makes no warranties about service availability, correctness of the data, or anything else. The service is provided as is, and may change at any time.  ## Acceptable Use Policy  * You will credit MangaUpdates when using data provided by this API. * You will use reasonable spacing between requests so as not to overwhelm the MangaUpdates servers, and employ caching mechanisms when accessing data. * You will NOT use MangaUpdates data or API in a way that will:     * Deceive or defraud users     * Assist or perform an illegal action     * Create spam     * Damage the database  We reserve the right to change this policy at any time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MangaUpdates.Model;
using MangaUpdates.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace MangaUpdates.Test.Model
{
    /// <summary>
    ///  Class for testing ReviewCommentModelV1
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReviewCommentModelV1Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReviewCommentModelV1
        //private ReviewCommentModelV1 instance;

        public ReviewCommentModelV1Tests()
        {
            // TODO uncomment below to create an instance of ReviewCommentModelV1
            //instance = new ReviewCommentModelV1();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReviewCommentModelV1
        /// </summary>
        [Fact]
        public void ReviewCommentModelV1InstanceTest()
        {
            // TODO uncomment below to test "IsType" ReviewCommentModelV1
            //Assert.IsType<ReviewCommentModelV1>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'ReviewId'
        /// </summary>
        [Fact]
        public void ReviewIdTest()
        {
            // TODO unit test for the property 'ReviewId'
        }
        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }
        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }
        /// <summary>
        /// Test the property 'Author'
        /// </summary>
        [Fact]
        public void AuthorTest()
        {
            // TODO unit test for the property 'Author'
        }
        /// <summary>
        /// Test the property 'Rating'
        /// </summary>
        [Fact]
        public void RatingTest()
        {
            // TODO unit test for the property 'Rating'
        }
        /// <summary>
        /// Test the property 'TimeAdded'
        /// </summary>
        [Fact]
        public void TimeAddedTest()
        {
            // TODO unit test for the property 'TimeAdded'
        }
        /// <summary>
        /// Test the property 'TimeUpdated'
        /// </summary>
        [Fact]
        public void TimeUpdatedTest()
        {
            // TODO unit test for the property 'TimeUpdated'
        }

    }

}
