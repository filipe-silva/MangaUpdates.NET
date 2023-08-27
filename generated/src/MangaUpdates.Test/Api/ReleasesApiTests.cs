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
    ///  Class for testing ReleasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReleasesApiTests : IDisposable
    {
        private ReleasesApi instance;

        public ReleasesApiTests()
        {
            instance = new ReleasesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReleasesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReleasesApi
            //Assert.IsType<ReleasesApi>(instance);
        }

        /// <summary>
        /// Test AddRelease
        /// </summary>
        [Fact]
        public void AddReleaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ReleaseModelUpdateV1> releaseModelUpdateV1 = null;
            //var response = instance.AddRelease(releaseModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteRelease
        /// </summary>
        [Fact]
        public void DeleteReleaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteRelease(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test ListReleasesByDay
        /// </summary>
        [Fact]
        public void ListReleasesByDayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //bool? includeMetadata = null;
            //var response = instance.ListReleasesByDay(page, includeMetadata);
            //Assert.IsType<ReleaseSearchResponseV1>(response);
        }

        /// <summary>
        /// Test ModerateReleasesPost
        /// </summary>
        [Fact]
        public void ModerateReleasesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReleaseModerateRequestV1 releaseModerateRequestV1 = null;
            //var response = instance.ModerateReleasesPost(releaseModerateRequestV1);
            //Assert.IsType<ReleaseModerateResponseV1>(response);
        }

        /// <summary>
        /// Test ReleaseRssFeed
        /// </summary>
        [Fact]
        public void ReleaseRssFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ReleaseRssFeed();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test RetrieveRelease
        /// </summary>
        [Fact]
        public void RetrieveReleaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveRelease(id, unrenderedFields);
            //Assert.IsType<ReleaseModelV1>(response);
        }

        /// <summary>
        /// Test SearchReleasesPost
        /// </summary>
        [Fact]
        public void SearchReleasesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReleaseSearchRequestV1 releaseSearchRequestV1 = null;
            //var response = instance.SearchReleasesPost(releaseSearchRequestV1);
            //Assert.IsType<ReleaseSearchResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateRelease
        /// </summary>
        [Fact]
        public void UpdateReleaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //ReleaseModelUpdateV1 releaseModelUpdateV1 = null;
            //var response = instance.UpdateRelease(id, releaseModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }
    }
}