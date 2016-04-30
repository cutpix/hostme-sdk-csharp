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
    ///  Class for testing ManageInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ManageInfoTests
    {
        private ManageInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ManageInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ManageInfo
        /// </summary>
        [Test]
        public void ManageInfoInstanceTest()
        {
            Assert.IsInstanceOf<ManageInfo> (instance, "instance is a ManageInfo");
        }

        /// <summary>
        /// Test the property 'LocalLoginProvider' 
        /// </summary>
        [Test]
        public void LocalLoginProviderTest()
        {
            // TODO: unit test for the property 'LocalLoginProvider' 
        }
        /// <summary>
        /// Test the property 'UserName' 
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO: unit test for the property 'UserName' 
        }
        /// <summary>
        /// Test the property 'Logins' 
        /// </summary>
        [Test]
        public void LoginsTest()
        {
            // TODO: unit test for the property 'Logins' 
        }
        /// <summary>
        /// Test the property 'ExternalLoginProviders' 
        /// </summary>
        [Test]
        public void ExternalLoginProvidersTest()
        {
            // TODO: unit test for the property 'ExternalLoginProviders' 
        }

    }

}