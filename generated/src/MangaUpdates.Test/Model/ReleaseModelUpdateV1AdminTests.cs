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
    ///  Class for testing ReleaseModelUpdateV1Admin
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReleaseModelUpdateV1AdminTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReleaseModelUpdateV1Admin
        //private ReleaseModelUpdateV1Admin instance;

        public ReleaseModelUpdateV1AdminTests()
        {
            // TODO uncomment below to create an instance of ReleaseModelUpdateV1Admin
            //instance = new ReleaseModelUpdateV1Admin();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReleaseModelUpdateV1Admin
        /// </summary>
        [Fact]
        public void ReleaseModelUpdateV1AdminInstanceTest()
        {
            // TODO uncomment below to test "IsType" ReleaseModelUpdateV1Admin
            //Assert.IsType<ReleaseModelUpdateV1Admin>(instance);
        }


        /// <summary>
        /// Test the property 'Approved'
        /// </summary>
        [Fact]
        public void ApprovedTest()
        {
            // TODO unit test for the property 'Approved'
        }
        /// <summary>
        /// Test the property 'Archived'
        /// </summary>
        [Fact]
        public void ArchivedTest()
        {
            // TODO unit test for the property 'Archived'
        }

    }

}
