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
    ///  Class for testing WebReservationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WebReservationsApiTests
    {
        private WebReservationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new WebReservationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebReservationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<WebReservationsApi> (instance, "instance is a WebReservationsApi");
        }

        
        /// <summary>
        /// Test AddNewReservation
        /// </summary>
        [Test]
        public void AddNewReservationTest()
        {
            // TODO: add unit test for the method 'AddNewReservation'
            int? restaurantId = null; // TODO: replace null with proper value
CreateReservation value = null; // TODO: replace null with proper value
            var response = instance.AddNewReservation(restaurantId, value);
            Assert.IsInstanceOf<Reservation> (response, "response is Reservation"); 
        }
        
        /// <summary>
        /// Test FindRestaurants
        /// </summary>
        [Test]
        public void FindRestaurantsTest()
        {
            // TODO: add unit test for the method 'FindRestaurants'
            double? lat = null; // TODO: replace null with proper value
double? lon = null; // TODO: replace null with proper value
string name = null; // TODO: replace null with proper value
            var response = instance.FindRestaurants(lat, lon, name);
            Assert.IsInstanceOf<List<RestaurantInfo>> (response, "response is List<RestaurantInfo>"); 
        }
        
        /// <summary>
        /// Test GetReservationAvailability
        /// </summary>
        [Test]
        public void GetReservationAvailabilityTest()
        {
            // TODO: add unit test for the method 'GetReservationAvailability'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? date = null; // TODO: replace null with proper value
int? partySize = null; // TODO: replace null with proper value
int? rangeInMinutes = null; // TODO: replace null with proper value
string areas = null; // TODO: replace null with proper value
            var response = instance.GetReservationAvailability(restaurantId, date, partySize, rangeInMinutes, areas);
            Assert.IsInstanceOf<List<OnlineAvailability>> (response, "response is List<OnlineAvailability>"); 
        }
        
        /// <summary>
        /// Test GetRestaurantById
        /// </summary>
        [Test]
        public void GetRestaurantByIdTest()
        {
            // TODO: add unit test for the method 'GetRestaurantById'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetRestaurantById(restaurantId);
            Assert.IsInstanceOf<RestaurantInfo> (response, "response is RestaurantInfo"); 
        }
        
    }

}
