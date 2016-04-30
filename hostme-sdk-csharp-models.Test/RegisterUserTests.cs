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
    ///  Class for testing RegisterUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RegisterUserTests
    {
        private RegisterUser instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RegisterUser();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RegisterUser
        /// </summary>
        [Test]
        public void RegisterUserInstanceTest()
        {
            Assert.IsInstanceOf<RegisterUser> (instance, "instance is a RegisterUser");
        }

        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
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
        /// <summary>
        /// Test the property 'Password' 
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO: unit test for the property 'Password' 
        }
        /// <summary>
        /// Test the property 'ConfirmPassword' 
        /// </summary>
        [Test]
        public void ConfirmPasswordTest()
        {
            // TODO: unit test for the property 'ConfirmPassword' 
        }

    }

}
