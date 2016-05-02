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
    ///  Class for testing Invitation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InvitationTests
    {
        private Invitation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Invitation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Invitation
        /// </summary>
        [Test]
        public void InvitationInstanceTest()
        {
            Assert.IsInstanceOf<Invitation> (instance, "instance is a Invitation");
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
        /// Test the property 'Role' 
        /// </summary>
        [Test]
        public void RoleTest()
        {
            // TODO: unit test for the property 'Role' 
        }
        

    }

}


