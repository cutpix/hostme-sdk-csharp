using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HostMe.Sdk.Api;
using HostMe.Sdk.Model;
using HostMe.Sdk.Client;
using System.Reflection;



namespace HostMe.Sdk.Test
{
    /// <summary>
    ///  Class for testing RestaurantInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RestaurantInfoTests
    {
        private RestaurantInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RestaurantInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RestaurantInfo
        /// </summary>
        [Test]
        public void RestaurantInfoInstanceTest()
        {
            Assert.IsInstanceOf<RestaurantInfo> (instance, "instance is a RestaurantInfo");
        }

        
        /// <summary>
        /// Test the property 'HoursInterval' 
        /// </summary>
        [Test]
        public void HoursIntervalTest()
        {
            // TODO: unit test for the property 'HoursInterval' 
        }
        
        /// <summary>
        /// Test the property 'MaxPartySize' 
        /// </summary>
        [Test]
        public void MaxPartySizeTest()
        {
            // TODO: unit test for the property 'MaxPartySize' 
        }
        
        /// <summary>
        /// Test the property 'MinPartySize' 
        /// </summary>
        [Test]
        public void MinPartySizeTest()
        {
            // TODO: unit test for the property 'MinPartySize' 
        }
        
        /// <summary>
        /// Test the property 'OpeningHours' 
        /// </summary>
        [Test]
        public void OpeningHoursTest()
        {
            // TODO: unit test for the property 'OpeningHours' 
        }
        
        /// <summary>
        /// Test the property 'ReservationHours' 
        /// </summary>
        [Test]
        public void ReservationHoursTest()
        {
            // TODO: unit test for the property 'ReservationHours' 
        }
        
        /// <summary>
        /// Test the property 'SeatingZones' 
        /// </summary>
        [Test]
        public void SeatingZonesTest()
        {
            // TODO: unit test for the property 'SeatingZones' 
        }
        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Address' 
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address' 
        }
        
        /// <summary>
        /// Test the property 'ImageUrl' 
        /// </summary>
        [Test]
        public void ImageUrlTest()
        {
            // TODO: unit test for the property 'ImageUrl' 
        }
        
        /// <summary>
        /// Test the property 'FacebookId' 
        /// </summary>
        [Test]
        public void FacebookIdTest()
        {
            // TODO: unit test for the property 'FacebookId' 
        }
        
        /// <summary>
        /// Test the property 'TwitterAccount' 
        /// </summary>
        [Test]
        public void TwitterAccountTest()
        {
            // TODO: unit test for the property 'TwitterAccount' 
        }
        
        /// <summary>
        /// Test the property 'WebsiteUrl' 
        /// </summary>
        [Test]
        public void WebsiteUrlTest()
        {
            // TODO: unit test for the property 'WebsiteUrl' 
        }
        
        /// <summary>
        /// Test the property 'FoursquareId' 
        /// </summary>
        [Test]
        public void FoursquareIdTest()
        {
            // TODO: unit test for the property 'FoursquareId' 
        }
        
        /// <summary>
        /// Test the property 'Phone' 
        /// </summary>
        [Test]
        public void PhoneTest()
        {
            // TODO: unit test for the property 'Phone' 
        }
        
        /// <summary>
        /// Test the property 'TimeOffSet' 
        /// </summary>
        [Test]
        public void TimeOffSetTest()
        {
            // TODO: unit test for the property 'TimeOffSet' 
        }
        
        /// <summary>
        /// Test the property 'TimeZone' 
        /// </summary>
        [Test]
        public void TimeZoneTest()
        {
            // TODO: unit test for the property 'TimeZone' 
        }
        
        /// <summary>
        /// Test the property 'Lat' 
        /// </summary>
        [Test]
        public void LatTest()
        {
            // TODO: unit test for the property 'Lat' 
        }
        
        /// <summary>
        /// Test the property 'Lon' 
        /// </summary>
        [Test]
        public void LonTest()
        {
            // TODO: unit test for the property 'Lon' 
        }
        
        /// <summary>
        /// Test the property 'HasHostmeSystem' 
        /// </summary>
        [Test]
        public void HasHostmeSystemTest()
        {
            // TODO: unit test for the property 'HasHostmeSystem' 
        }
        
        /// <summary>
        /// Test the property 'Distance' 
        /// </summary>
        [Test]
        public void DistanceTest()
        {
            // TODO: unit test for the property 'Distance' 
        }
        
        /// <summary>
        /// Test the property 'Rating' 
        /// </summary>
        [Test]
        public void RatingTest()
        {
            // TODO: unit test for the property 'Rating' 
        }
        
        /// <summary>
        /// Test the property 'HasLoyaltyProgram' 
        /// </summary>
        [Test]
        public void HasLoyaltyProgramTest()
        {
            // TODO: unit test for the property 'HasLoyaltyProgram' 
        }
        
        /// <summary>
        /// Test the property 'AcceptRemouteLine' 
        /// </summary>
        [Test]
        public void AcceptRemouteLineTest()
        {
            // TODO: unit test for the property 'AcceptRemouteLine' 
        }
        
        /// <summary>
        /// Test the property 'AcceptReservation' 
        /// </summary>
        [Test]
        public void AcceptReservationTest()
        {
            // TODO: unit test for the property 'AcceptReservation' 
        }
        
        /// <summary>
        /// Test the property 'AllowManualHold' 
        /// </summary>
        [Test]
        public void AllowManualHoldTest()
        {
            // TODO: unit test for the property 'AllowManualHold' 
        }
        
        /// <summary>
        /// Test the property 'CurrentLineStats' 
        /// </summary>
        [Test]
        public void CurrentLineStatsTest()
        {
            // TODO: unit test for the property 'CurrentLineStats' 
        }
        
        /// <summary>
        /// Test the property 'IsFavorite' 
        /// </summary>
        [Test]
        public void IsFavoriteTest()
        {
            // TODO: unit test for the property 'IsFavorite' 
        }
        
        /// <summary>
        /// Test the property 'NumberOfDeals' 
        /// </summary>
        [Test]
        public void NumberOfDealsTest()
        {
            // TODO: unit test for the property 'NumberOfDeals' 
        }
        
        /// <summary>
        /// Test the property 'NumberOfVotes' 
        /// </summary>
        [Test]
        public void NumberOfVotesTest()
        {
            // TODO: unit test for the property 'NumberOfVotes' 
        }
        
        /// <summary>
        /// Test the property 'ReservationIncomeEmail' 
        /// </summary>
        [Test]
        public void ReservationIncomeEmailTest()
        {
            // TODO: unit test for the property 'ReservationIncomeEmail' 
        }
        

    }

}


