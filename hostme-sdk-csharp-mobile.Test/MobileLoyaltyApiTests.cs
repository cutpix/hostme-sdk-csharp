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
    ///  Class for testing MobileLoyaltyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MobileLoyaltyApiTests
    {
        private MobileLoyaltyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new MobileLoyaltyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MobileLoyaltyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<MobileLoyaltyApi> (instance, "instance is a MobileLoyaltyApi");
        }

        
        /// <summary>
        /// Test CancelMembershipAtRestaurant
        /// </summary>
        [Test]
        public void CancelMembershipAtRestaurantTest()
        {
            // TODO: add unit test for the method 'CancelMembershipAtRestaurant'
            int? restaurantId = null; // TODO: replace null with proper value
            instance.CancelMembershipAtRestaurant(restaurantId);
             
        }
        
        /// <summary>
        /// Test EnrollIntoLoyaltyProgram
        /// </summary>
        [Test]
        public void EnrollIntoLoyaltyProgramTest()
        {
            // TODO: add unit test for the method 'EnrollIntoLoyaltyProgram'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.EnrollIntoLoyaltyProgram(restaurantId);
            Assert.IsInstanceOf<Membership> (response, "response is Membership"); 
        }
        
        /// <summary>
        /// Test GetAllUserMemberships
        /// </summary>
        [Test]
        public void GetAllUserMembershipsTest()
        {
            // TODO: add unit test for the method 'GetAllUserMemberships'
                        var response = instance.GetAllUserMemberships();
            Assert.IsInstanceOf<List<Membership>> (response, "response is List<Membership>"); 
        }
        
        /// <summary>
        /// Test GetCustomerRedeemRequests
        /// </summary>
        [Test]
        public void GetCustomerRedeemRequestsTest()
        {
            // TODO: add unit test for the method 'GetCustomerRedeemRequests'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetCustomerRedeemRequests(restaurantId);
            Assert.IsInstanceOf<List<RedeemRequestInfo>> (response, "response is List<RedeemRequestInfo>"); 
        }
        
        /// <summary>
        /// Test GetMemberRewardOptions
        /// </summary>
        [Test]
        public void GetMemberRewardOptionsTest()
        {
            // TODO: add unit test for the method 'GetMemberRewardOptions'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetMemberRewardOptions(restaurantId);
            Assert.IsInstanceOf<List<RewardInfo>> (response, "response is List<RewardInfo>"); 
        }
        
        /// <summary>
        /// Test GetMemberTransactions
        /// </summary>
        [Test]
        public void GetMemberTransactionsTest()
        {
            // TODO: add unit test for the method 'GetMemberTransactions'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetMemberTransactions(restaurantId);
            Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>"); 
        }
        
        /// <summary>
        /// Test GetMembershipByRestaurantId
        /// </summary>
        [Test]
        public void GetMembershipByRestaurantIdTest()
        {
            // TODO: add unit test for the method 'GetMembershipByRestaurantId'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetMembershipByRestaurantId(restaurantId);
            Assert.IsInstanceOf<Membership> (response, "response is Membership"); 
        }
        
        /// <summary>
        /// Test GetRedeemRequestInfo
        /// </summary>
        [Test]
        public void GetRedeemRequestInfoTest()
        {
            // TODO: add unit test for the method 'GetRedeemRequestInfo'
            int? restaurantId = null; // TODO: replace null with proper value
string redeemId = null; // TODO: replace null with proper value
            var response = instance.GetRedeemRequestInfo(restaurantId, redeemId);
            Assert.IsInstanceOf<RedeemRequestInfo> (response, "response is RedeemRequestInfo"); 
        }
        
        /// <summary>
        /// Test SubmitRequestForRedeem
        /// </summary>
        [Test]
        public void SubmitRequestForRedeemTest()
        {
            // TODO: add unit test for the method 'SubmitRequestForRedeem'
            int? restaurantId = null; // TODO: replace null with proper value
string rewardId = null; // TODO: replace null with proper value
            var response = instance.SubmitRequestForRedeem(restaurantId, rewardId);
            Assert.IsInstanceOf<RedeemRequestInfo> (response, "response is RedeemRequestInfo"); 
        }
        
    }

}
