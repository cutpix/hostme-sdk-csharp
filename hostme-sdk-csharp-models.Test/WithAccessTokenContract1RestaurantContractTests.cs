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
    ///  Class for testing WithAccessTokenContract1RestaurantContract
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WithAccessTokenContract1RestaurantContractTests
    {
        private WithAccessTokenContract1RestaurantContract instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WithAccessTokenContract1RestaurantContract();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WithAccessTokenContract1RestaurantContract
        /// </summary>
        [Test]
        public void WithAccessTokenContract1RestaurantContractInstanceTest()
        {
            Assert.IsInstanceOf<WithAccessTokenContract1RestaurantContract> (instance, "instance is a WithAccessTokenContract1RestaurantContract");
        }

        /// <summary>
        /// Test the property 'Data' 
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data' 
        }
        /// <summary>
        /// Test the property 'AccessToken' 
        /// </summary>
        [Test]
        public void AccessTokenTest()
        {
            // TODO: unit test for the property 'AccessToken' 
        }

    }

}
