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
    ///  Class for testing SeriesModelV1Publishers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SeriesModelV1PublishersTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SeriesModelV1Publishers
        //private SeriesModelV1Publishers instance;

        public SeriesModelV1PublishersTests()
        {
            // TODO uncomment below to create an instance of SeriesModelV1Publishers
            //instance = new SeriesModelV1Publishers();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SeriesModelV1Publishers
        /// </summary>
        [Fact]
        public void SeriesModelV1PublishersInstanceTest()
        {
            // TODO uncomment below to test "IsType" SeriesModelV1Publishers
            //Assert.IsType<SeriesModelV1Publishers>(instance);
        }


        /// <summary>
        /// Test the property 'PublisherName'
        /// </summary>
        [Fact]
        public void PublisherNameTest()
        {
            // TODO unit test for the property 'PublisherName'
        }
        /// <summary>
        /// Test the property 'PublisherId'
        /// </summary>
        [Fact]
        public void PublisherIdTest()
        {
            // TODO unit test for the property 'PublisherId'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Fact]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }

    }

}
