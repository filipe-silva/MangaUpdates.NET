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
    ///  Class for testing PollApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PollApiTests : IDisposable
    {
        private PollApi instance;

        public PollApiTests()
        {
            instance = new PollApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PollApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PollApi
            //Assert.IsType<PollApi>(instance);
        }

        /// <summary>
        /// Test AddPoll
        /// </summary>
        [Fact]
        public void AddPollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PollModelUpdateV1 pollModelUpdateV1 = null;
            //var response = instance.AddPoll(pollModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test ArchivePoll
        /// </summary>
        [Fact]
        public void ArchivePollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ArchivePoll();
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveOldPolls
        /// </summary>
        [Fact]
        public void RetrieveOldPollsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RetrieveOldPolls();
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrievePoll
        /// </summary>
        [Fact]
        public void RetrievePollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RetrievePoll();
            //Assert.IsType<PollModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveVoteStatus
        /// </summary>
        [Fact]
        public void RetrieveVoteStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RetrieveVoteStatus();
            //Assert.IsType<PollVoteStatusModelV1>(response);
        }

        /// <summary>
        /// Test VotePollAnswer
        /// </summary>
        [Fact]
        public void VotePollAnswerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int answerId = null;
            //var response = instance.VotePollAnswer(answerId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test VotePollNoAnswer
        /// </summary>
        [Fact]
        public void VotePollNoAnswerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.VotePollNoAnswer();
            //Assert.IsType<ApiResponseV1>(response);
        }
    }
}
