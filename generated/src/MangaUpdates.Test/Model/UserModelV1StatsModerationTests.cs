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
    ///  Class for testing UserModelV1StatsModeration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserModelV1StatsModerationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserModelV1StatsModeration
        //private UserModelV1StatsModeration instance;

        public UserModelV1StatsModerationTests()
        {
            // TODO uncomment below to create an instance of UserModelV1StatsModeration
            //instance = new UserModelV1StatsModeration();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserModelV1StatsModeration
        /// </summary>
        [Fact]
        public void UserModelV1StatsModerationInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserModelV1StatsModeration
            //Assert.IsType<UserModelV1StatsModeration>(instance);
        }


        /// <summary>
        /// Test the property 'Releases'
        /// </summary>
        [Fact]
        public void ReleasesTest()
        {
            // TODO unit test for the property 'Releases'
        }
        /// <summary>
        /// Test the property 'Series'
        /// </summary>
        [Fact]
        public void SeriesTest()
        {
            // TODO unit test for the property 'Series'
        }
        /// <summary>
        /// Test the property 'Publishers'
        /// </summary>
        [Fact]
        public void PublishersTest()
        {
            // TODO unit test for the property 'Publishers'
        }
        /// <summary>
        /// Test the property 'Groups'
        /// </summary>
        [Fact]
        public void GroupsTest()
        {
            // TODO unit test for the property 'Groups'
        }
        /// <summary>
        /// Test the property 'Authors'
        /// </summary>
        [Fact]
        public void AuthorsTest()
        {
            // TODO unit test for the property 'Authors'
        }
        /// <summary>
        /// Test the property 'LastAction'
        /// </summary>
        [Fact]
        public void LastActionTest()
        {
            // TODO unit test for the property 'LastAction'
        }

    }

}