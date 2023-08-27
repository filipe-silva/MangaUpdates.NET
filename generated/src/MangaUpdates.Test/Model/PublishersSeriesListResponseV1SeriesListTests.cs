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
    ///  Class for testing PublishersSeriesListResponseV1SeriesList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PublishersSeriesListResponseV1SeriesListTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PublishersSeriesListResponseV1SeriesList
        //private PublishersSeriesListResponseV1SeriesList instance;

        public PublishersSeriesListResponseV1SeriesListTests()
        {
            // TODO uncomment below to create an instance of PublishersSeriesListResponseV1SeriesList
            //instance = new PublishersSeriesListResponseV1SeriesList();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublishersSeriesListResponseV1SeriesList
        /// </summary>
        [Fact]
        public void PublishersSeriesListResponseV1SeriesListInstanceTest()
        {
            // TODO uncomment below to test "IsType" PublishersSeriesListResponseV1SeriesList
            //Assert.IsType<PublishersSeriesListResponseV1SeriesList>(instance);
        }


        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'SeriesId'
        /// </summary>
        [Fact]
        public void SeriesIdTest()
        {
            // TODO unit test for the property 'SeriesId'
        }
        /// <summary>
        /// Test the property 'Year'
        /// </summary>
        [Fact]
        public void YearTest()
        {
            // TODO unit test for the property 'Year'
        }
        /// <summary>
        /// Test the property 'LastUpdated'
        /// </summary>
        [Fact]
        public void LastUpdatedTest()
        {
            // TODO unit test for the property 'LastUpdated'
        }

    }

}