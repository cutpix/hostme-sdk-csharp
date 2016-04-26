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
    ///  Class for testing CreateRestaurantCustomer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateRestaurantCustomerTests
    {
        private CreateRestaurantCustomer instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreateRestaurantCustomer();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CreateRestaurantCustomer
        /// </summary>
        [Test]
        public void CreateRestaurantCustomerInstanceTest()
        {
            Assert.IsInstanceOf<CreateRestaurantCustomer> (instance, "instance is a CreateRestaurantCustomer");
        }

        /// <summary>
        /// Test the property 'FullName' 
        /// </summary>
        [Test]
        public void FullNameTest()
        {
            // TODO: unit test for the property 'FullName' 
        }
        /// <summary>
        /// Test the property 'PhoneNumber' 
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber' 
        }

    }

}
