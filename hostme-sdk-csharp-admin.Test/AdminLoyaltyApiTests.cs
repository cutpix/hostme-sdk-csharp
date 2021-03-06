using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using HostMe.Sdk.Client;
using HostMe.Sdk.Api;
using HostMe.Sdk.Model;

namespace HostMe.Sdk.Test
{
    /// <summary>
    ///  Class for testing AdminLoyaltyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminLoyaltyApiTests
    {
        private AdminLoyaltyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AdminLoyaltyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminLoyaltyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AdminLoyaltyApi> (instance, "instance is a AdminLoyaltyApi");
        }

        
        /// <summary>
        /// Test AddMember
        /// </summary>
        [Test]
        public void AddMemberTest()
        {
            // TODO: add unit test for the method 'AddMember'
            int? restaurantId = null; // TODO: replace null with proper value
MembershipCreate contract = null; // TODO: replace null with proper value
            var response = instance.AddMember(restaurantId, contract);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test AddNewReward
        /// </summary>
        [Test]
        public void AddNewRewardTest()
        {
            // TODO: add unit test for the method 'AddNewReward'
            int? restaurantId = null; // TODO: replace null with proper value
Reward reward = null; // TODO: replace null with proper value
            var response = instance.AddNewReward(restaurantId, reward);
            Assert.IsInstanceOf<Reward> (response, "response is Reward"); 
        }
        
        /// <summary>
        /// Test ApproveRedeemRequest
        /// </summary>
        [Test]
        public void ApproveRedeemRequestTest()
        {
            // TODO: add unit test for the method 'ApproveRedeemRequest'
            int? restaurantId = null; // TODO: replace null with proper value
string redeemId = null; // TODO: replace null with proper value
            var response = instance.ApproveRedeemRequest(restaurantId, redeemId);
            Assert.IsInstanceOf<RedeemRequest> (response, "response is RedeemRequest"); 
        }
        
        /// <summary>
        /// Test CloseMembership
        /// </summary>
        [Test]
        public void CloseMembershipTest()
        {
            // TODO: add unit test for the method 'CloseMembership'
            int? restaurantId = null; // TODO: replace null with proper value
int? memberId = null; // TODO: replace null with proper value
            var response = instance.CloseMembership(restaurantId, memberId);
            Assert.IsInstanceOf<Member> (response, "response is Member"); 
        }
        
        /// <summary>
        /// Test DeleteReward
        /// </summary>
        [Test]
        public void DeleteRewardTest()
        {
            // TODO: add unit test for the method 'DeleteReward'
            int? restaurantId = null; // TODO: replace null with proper value
string rewardId = null; // TODO: replace null with proper value
            instance.DeleteReward(restaurantId, rewardId);
             
        }
        
        /// <summary>
        /// Test ExportMembers
        /// </summary>
        [Test]
        public void ExportMembersTest()
        {
            // TODO: add unit test for the method 'ExportMembers'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.ExportMembers(restaurantId);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test Filter
        /// </summary>
        [Test]
        public void FilterTest()
        {
            // TODO: add unit test for the method 'Filter'
            int? restaurantId = null; // TODO: replace null with proper value
int? take = null; // TODO: replace null with proper value
string token = null; // TODO: replace null with proper value
            var response = instance.Filter(restaurantId, take, token);
            Assert.IsInstanceOf<List<CustomerProfile>> (response, "response is List<CustomerProfile>"); 
        }
        
        /// <summary>
        /// Test FindMemberByPhoneNumber
        /// </summary>
        [Test]
        public void FindMemberByPhoneNumberTest()
        {
            // TODO: add unit test for the method 'FindMemberByPhoneNumber'
            int? restaurantId = null; // TODO: replace null with proper value
string phoneNumber = null; // TODO: replace null with proper value
            var response = instance.FindMemberByPhoneNumber(restaurantId, phoneNumber);
            Assert.IsInstanceOf<Member> (response, "response is Member"); 
        }
        
        /// <summary>
        /// Test GetAlRewards
        /// </summary>
        [Test]
        public void GetAlRewardsTest()
        {
            // TODO: add unit test for the method 'GetAlRewards'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetAlRewards(restaurantId);
            Assert.IsInstanceOf<List<Reward>> (response, "response is List<Reward>"); 
        }
        
        /// <summary>
        /// Test GetAllMembers
        /// </summary>
        [Test]
        public void GetAllMembersTest()
        {
            // TODO: add unit test for the method 'GetAllMembers'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetAllMembers(restaurantId);
            Assert.IsInstanceOf<ODataPagedResult1MemberContract> (response, "response is ODataPagedResult1MemberContract"); 
        }
        
        /// <summary>
        /// Test GetAllRedeemRequests
        /// </summary>
        [Test]
        public void GetAllRedeemRequestsTest()
        {
            // TODO: add unit test for the method 'GetAllRedeemRequests'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetAllRedeemRequests(restaurantId);
            Assert.IsInstanceOf<List<RedeemRequest>> (response, "response is List<RedeemRequest>"); 
        }
        
        /// <summary>
        /// Test GetDefaultLoyaltySettings
        /// </summary>
        [Test]
        public void GetDefaultLoyaltySettingsTest()
        {
            // TODO: add unit test for the method 'GetDefaultLoyaltySettings'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetDefaultLoyaltySettings(restaurantId);
            Assert.IsInstanceOf<LoyaltySettings> (response, "response is LoyaltySettings"); 
        }
        
        /// <summary>
        /// Test GetLoyaltySettings
        /// </summary>
        [Test]
        public void GetLoyaltySettingsTest()
        {
            // TODO: add unit test for the method 'GetLoyaltySettings'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetLoyaltySettings(restaurantId);
            Assert.IsInstanceOf<LoyaltySettings> (response, "response is LoyaltySettings"); 
        }
        
        /// <summary>
        /// Test GetMemberAvatar
        /// </summary>
        [Test]
        public void GetMemberAvatarTest()
        {
            // TODO: add unit test for the method 'GetMemberAvatar'
            int? restaurantId = null; // TODO: replace null with proper value
int? memberId = null; // TODO: replace null with proper value
            var response = instance.GetMemberAvatar(restaurantId, memberId);
            Assert.IsInstanceOf<byte[]> (response, "response is byte[]"); 
        }
        
        /// <summary>
        /// Test GetMemberTransactions
        /// </summary>
        [Test]
        public void GetMemberTransactionsTest()
        {
            // TODO: add unit test for the method 'GetMemberTransactions'
            int? restaurantId = null; // TODO: replace null with proper value
int? memberId = null; // TODO: replace null with proper value
            var response = instance.GetMemberTransactions(restaurantId, memberId);
            Assert.IsInstanceOf<ODataPagedResult1TransactionContract> (response, "response is ODataPagedResult1TransactionContract"); 
        }
        
        /// <summary>
        /// Test GetMemberVisits
        /// </summary>
        [Test]
        public void GetMemberVisitsTest()
        {
            // TODO: add unit test for the method 'GetMemberVisits'
            int? restaurantId = null; // TODO: replace null with proper value
int? memberId = null; // TODO: replace null with proper value
            var response = instance.GetMemberVisits(restaurantId, memberId);
            Assert.IsInstanceOf<ODataPagedResult1MembershipVisitItemContract> (response, "response is ODataPagedResult1MembershipVisitItemContract"); 
        }
        
        /// <summary>
        /// Test GetMembershipInfo
        /// </summary>
        [Test]
        public void GetMembershipInfoTest()
        {
            // TODO: add unit test for the method 'GetMembershipInfo'
            int? restaurantId = null; // TODO: replace null with proper value
int? memberId = null; // TODO: replace null with proper value
            var response = instance.GetMembershipInfo(restaurantId, memberId);
            Assert.IsInstanceOf<Member> (response, "response is Member"); 
        }
        
        /// <summary>
        /// Test GetRewardById
        /// </summary>
        [Test]
        public void GetRewardByIdTest()
        {
            // TODO: add unit test for the method 'GetRewardById'
            int? restaurantId = null; // TODO: replace null with proper value
string rewardId = null; // TODO: replace null with proper value
            var response = instance.GetRewardById(restaurantId, rewardId);
            Assert.IsInstanceOf<Reward> (response, "response is Reward"); 
        }
        
        /// <summary>
        /// Test PublishReward
        /// </summary>
        [Test]
        public void PublishRewardTest()
        {
            // TODO: add unit test for the method 'PublishReward'
            int? restaurantId = null; // TODO: replace null with proper value
string rewardId = null; // TODO: replace null with proper value
            var response = instance.PublishReward(restaurantId, rewardId);
            Assert.IsInstanceOf<Reward> (response, "response is Reward"); 
        }
        
        /// <summary>
        /// Test RejectRedeemRequest
        /// </summary>
        [Test]
        public void RejectRedeemRequestTest()
        {
            // TODO: add unit test for the method 'RejectRedeemRequest'
            int? restaurantId = null; // TODO: replace null with proper value
string redeemId = null; // TODO: replace null with proper value
RedeemRequestReject reject = null; // TODO: replace null with proper value
            var response = instance.RejectRedeemRequest(restaurantId, redeemId, reject);
            Assert.IsInstanceOf<RedeemRequest> (response, "response is RedeemRequest"); 
        }
        
        /// <summary>
        /// Test SetLoyaltySettings
        /// </summary>
        [Test]
        public void SetLoyaltySettingsTest()
        {
            // TODO: add unit test for the method 'SetLoyaltySettings'
            int? restaurantId = null; // TODO: replace null with proper value
LoyaltySettings settings = null; // TODO: replace null with proper value
            instance.SetLoyaltySettings(restaurantId, settings);
             
        }
        
        /// <summary>
        /// Test UnpublishReward
        /// </summary>
        [Test]
        public void UnpublishRewardTest()
        {
            // TODO: add unit test for the method 'UnpublishReward'
            int? restaurantId = null; // TODO: replace null with proper value
string rewardId = null; // TODO: replace null with proper value
            var response = instance.UnpublishReward(restaurantId, rewardId);
            Assert.IsInstanceOf<Reward> (response, "response is Reward"); 
        }
        
        /// <summary>
        /// Test UpdateMember
        /// </summary>
        [Test]
        public void UpdateMemberTest()
        {
            // TODO: add unit test for the method 'UpdateMember'
            int? restaurantId = null; // TODO: replace null with proper value
int? memberId = null; // TODO: replace null with proper value
MembershipUpdate contract = null; // TODO: replace null with proper value
            var response = instance.UpdateMember(restaurantId, memberId, contract);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test UpdateReward
        /// </summary>
        [Test]
        public void UpdateRewardTest()
        {
            // TODO: add unit test for the method 'UpdateReward'
            int? restaurantId = null; // TODO: replace null with proper value
string rewardId = null; // TODO: replace null with proper value
Reward reward = null; // TODO: replace null with proper value
            var response = instance.UpdateReward(restaurantId, rewardId, reward);
            Assert.IsInstanceOf<Reward> (response, "response is Reward"); 
        }
        
    }

}
