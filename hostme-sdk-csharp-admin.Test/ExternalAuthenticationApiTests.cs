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
    ///  Class for testing ExternalAuthenticationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExternalAuthenticationApiTests
    {
        private ExternalAuthenticationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ExternalAuthenticationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalAuthenticationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ExternalAuthenticationApi> (instance, "instance is a ExternalAuthenticationApi");
        }

        
        /// <summary>
        /// Test GetExternalFacebookLogin
        /// </summary>
        [Test]
        public void GetExternalFacebookLoginTest()
        {
            // TODO: add unit test for the method 'GetExternalFacebookLogin'
            string accessToken = null; // TODO: replace null with proper value
            instance.GetExternalFacebookLogin(accessToken);
             
        }
        
        /// <summary>
        /// Test GetExternalLogin
        /// </summary>
        [Test]
        public void GetExternalLoginTest()
        {
            // TODO: add unit test for the method 'GetExternalLogin'
            string provider = null; // TODO: replace null with proper value
string error = null; // TODO: replace null with proper value
            instance.GetExternalLogin(provider, error);
             
        }
        
        /// <summary>
        /// Test GetExternalLogins
        /// </summary>
        [Test]
        public void GetExternalLoginsTest()
        {
            // TODO: add unit test for the method 'GetExternalLogins'
            string returnUrl = null; // TODO: replace null with proper value
bool? generateState = null; // TODO: replace null with proper value
            var response = instance.GetExternalLogins(returnUrl, generateState);
            Assert.IsInstanceOf<List<ExternalLogin>> (response, "response is List<ExternalLogin>"); 
        }
        
    }

}
