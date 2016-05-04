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
    ///  Class for testing Profile
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProfileTests
    {
        private Profile instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Profile();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Profile
        /// </summary>
        [Test]
        public void ProfileInstanceTest()
        {
            Assert.IsInstanceOf<Profile> (instance, "instance is a Profile");
        }

        /// <summary>
        /// Test the property 'Allergy' 
        /// </summary>
        [Test]
        public void AllergyTest()
        {
            // TODO: unit test for the property 'Allergy' 
        }
        /// <summary>
        /// Test the property 'Vegetarian' 
        /// </summary>
        [Test]
        public void VegetarianTest()
        {
            // TODO: unit test for the property 'Vegetarian' 
        }

    }

}
