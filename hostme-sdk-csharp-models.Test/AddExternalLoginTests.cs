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
    ///  Class for testing AddExternalLogin
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AddExternalLoginTests
    {
        private AddExternalLogin instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddExternalLogin();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AddExternalLogin
        /// </summary>
        [Test]
        public void AddExternalLoginInstanceTest()
        {
            Assert.IsInstanceOf<AddExternalLogin> (instance, "instance is a AddExternalLogin");
        }

        /// <summary>
        /// Test the property 'ExternalAccessToken' 
        /// </summary>
        [Test]
        public void ExternalAccessTokenTest()
        {
            // TODO: unit test for the property 'ExternalAccessToken' 
        }

    }

}
