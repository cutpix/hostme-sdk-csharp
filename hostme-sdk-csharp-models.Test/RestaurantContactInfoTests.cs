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
    ///  Class for testing RestaurantContactInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RestaurantContactInfoTests
    {
        private RestaurantContactInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RestaurantContactInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RestaurantContactInfo
        /// </summary>
        [Test]
        public void RestaurantContactInfoInstanceTest()
        {
            Assert.IsInstanceOf<RestaurantContactInfo> (instance, "instance is a RestaurantContactInfo");
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
        /// Test the property 'WebsiteUrl' 
        /// </summary>
        [Test]
        public void WebsiteUrlTest()
        {
            // TODO: unit test for the property 'WebsiteUrl' 
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
        /// Test the property 'TimeZone' 
        /// </summary>
        [Test]
        public void TimeZoneTest()
        {
            // TODO: unit test for the property 'TimeZone' 
        }

    }

}
