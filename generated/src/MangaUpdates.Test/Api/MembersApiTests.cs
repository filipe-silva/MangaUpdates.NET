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
    ///  Class for testing MembersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MembersApiTests : IDisposable
    {
        private MembersApi instance;

        public MembersApiTests()
        {
            instance = new MembersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MembersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MembersApi
            //Assert.IsType<MembersApi>(instance);
        }

        /// <summary>
        /// Test AddMember
        /// </summary>
        [Fact]
        public void AddMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserModelUpdateV1 userModelUpdateV1 = null;
            //var response = instance.AddMember(userModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddMemberAvatar
        /// </summary>
        [Fact]
        public void AddMemberAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //System.IO.Stream image = null;
            //string title = null;
            //var response = instance.AddMemberAvatar(id, image, title);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddMemberChangeRequest
        /// </summary>
        [Fact]
        public void AddMemberChangeRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //UserChangeRequestModelUpdateV1 userChangeRequestModelUpdateV1 = null;
            //var response = instance.AddMemberChangeRequest(id, userChangeRequestModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddMemberGenreFilter
        /// </summary>
        [Fact]
        public void AddMemberGenreFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int genreId = null;
            //var response = instance.AddMemberGenreFilter(id, genreId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddMemberGenreHighlight
        /// </summary>
        [Fact]
        public void AddMemberGenreHighlightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int genreId = null;
            //UserGenreHighlightModelUpdateV1 userGenreHighlightModelUpdateV1 = null;
            //var response = instance.AddMemberGenreHighlight(id, genreId, userGenreHighlightModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddOrUpdateUserGroup
        /// </summary>
        [Fact]
        public void AddOrUpdateUserGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UserGroupModelUpdateV1 userGroupModelUpdateV1 = null;
            //var response = instance.AddOrUpdateUserGroup(id, userGroupModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddUserGroupFilter
        /// </summary>
        [Fact]
        public void AddUserGroupFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int groupId = null;
            //var response = instance.AddUserGroupFilter(id, groupId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test AddUserTopicSubscription
        /// </summary>
        [Fact]
        public void AddUserTopicSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int topicId = null;
            //var response = instance.AddUserTopicSubscription(id, topicId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test ApproveMemberUpgrade
        /// </summary>
        [Fact]
        public void ApproveMemberUpgradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ApproveMemberUpgrade(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteMember
        /// </summary>
        [Fact]
        public void DeleteMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteMember(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteMemberAvatar
        /// </summary>
        [Fact]
        public void DeleteMemberAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long avatarId = null;
            //var response = instance.DeleteMemberAvatar(id, avatarId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteMemberChangeRequest
        /// </summary>
        [Fact]
        public void DeleteMemberChangeRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long requestId = null;
            //var response = instance.DeleteMemberChangeRequest(id, requestId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test DeleteUserGroup
        /// </summary>
        [Fact]
        public void DeleteUserGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DeleteUserGroup(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RejectMemberUpgrade
        /// </summary>
        [Fact]
        public void RejectMemberUpgradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.RejectMemberUpgrade(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RemoveMemberGenreFilter
        /// </summary>
        [Fact]
        public void RemoveMemberGenreFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int genreId = null;
            //var response = instance.RemoveMemberGenreFilter(id, genreId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RemoveMemberGenreHighlight
        /// </summary>
        [Fact]
        public void RemoveMemberGenreHighlightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int genreId = null;
            //var response = instance.RemoveMemberGenreHighlight(id, genreId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RemoveUserGroupFilter
        /// </summary>
        [Fact]
        public void RemoveUserGroupFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int groupId = null;
            //var response = instance.RemoveUserGroupFilter(id, groupId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RemoveUserTopicSubscription
        /// </summary>
        [Fact]
        public void RemoveUserTopicSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int topicId = null;
            //var response = instance.RemoveUserTopicSubscription(id, topicId);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test ResetGenreSettings
        /// </summary>
        [Fact]
        public void ResetGenreSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.ResetGenreSettings(id);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test RetrieveMember
        /// </summary>
        [Fact]
        public void RetrieveMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveMember(id, unrenderedFields);
            //Assert.IsType<UserModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveMemberAvatars
        /// </summary>
        [Fact]
        public void RetrieveMemberAvatarsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveMemberAvatars(id);
            //Assert.IsType<List<AvatarModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveMemberChangeRequest
        /// </summary>
        [Fact]
        public void RetrieveMemberChangeRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long requestId = null;
            //var response = instance.RetrieveMemberChangeRequest(id, requestId);
            //Assert.IsType<UserChangeRequestModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveMemberGenreFilters
        /// </summary>
        [Fact]
        public void RetrieveMemberGenreFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveMemberGenreFilters(id);
            //Assert.IsType<List<UserGenreFilterModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveMemberGenreHighlights
        /// </summary>
        [Fact]
        public void RetrieveMemberGenreHighlightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveMemberGenreHighlights(id);
            //Assert.IsType<List<UserGenreHighlightModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveMemberGroupFilters
        /// </summary>
        [Fact]
        public void RetrieveMemberGroupFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveMemberGroupFilters(id);
            //Assert.IsType<List<UserGroupFilterModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveMemberTopicSubscription
        /// </summary>
        [Fact]
        public void RetrieveMemberTopicSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long topicId = null;
            //var response = instance.RetrieveMemberTopicSubscription(id, topicId);
            //Assert.IsType<UserSubscribedTopicModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveMemberTopicSubscriptions
        /// </summary>
        [Fact]
        public void RetrieveMemberTopicSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.RetrieveMemberTopicSubscriptions(id);
            //Assert.IsType<List<UserSubscribedTopicModelV1>>(response);
        }

        /// <summary>
        /// Test RetrieveUserGroupById
        /// </summary>
        [Fact]
        public void RetrieveUserGroupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? unrenderedFields = null;
            //var response = instance.RetrieveUserGroupById(id, unrenderedFields);
            //Assert.IsType<UserGroupModelV1>(response);
        }

        /// <summary>
        /// Test RetrieveUserGroups
        /// </summary>
        [Fact]
        public void RetrieveUserGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RetrieveUserGroups();
            //Assert.IsType<List<UserGroupModelV1>>(response);
        }

        /// <summary>
        /// Test SearchMemberChangeRequests
        /// </summary>
        [Fact]
        public void SearchMemberChangeRequestsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int? page = null;
            //int? perpage = null;
            //string orderby = null;
            //string asc = null;
            //var response = instance.SearchMemberChangeRequests(id, page, perpage, orderby, asc);
            //Assert.IsType<UserChangeRequestSearchResponseV1>(response);
        }

        /// <summary>
        /// Test SearchMembersPost
        /// </summary>
        [Fact]
        public void SearchMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSearchRequestV1 userSearchRequestV1 = null;
            //var response = instance.SearchMembersPost(userSearchRequestV1);
            //Assert.IsType<UserSearchResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateMember
        /// </summary>
        [Fact]
        public void UpdateMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //UserModelUpdateV1 userModelUpdateV1 = null;
            //var response = instance.UpdateMember(id, userModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }

        /// <summary>
        /// Test UpdateMemberChangeRequest
        /// </summary>
        [Fact]
        public void UpdateMemberChangeRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //long requestId = null;
            //UserChangeRequestModelUpdateV1 userChangeRequestModelUpdateV1 = null;
            //var response = instance.UpdateMemberChangeRequest(id, requestId, userChangeRequestModelUpdateV1);
            //Assert.IsType<ApiResponseV1>(response);
        }
    }
}
