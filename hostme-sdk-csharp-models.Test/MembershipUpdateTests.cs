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
    ///  Class for testing MembershipUpdate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MembershipUpdateTests
    {
        private MembershipUpdate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MembershipUpdate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MembershipUpdate
        /// </summary>
        [Test]
        public void MembershipUpdateInstanceTest()
        {
            Assert.IsInstanceOf<MembershipUpdate> (instance, "instance is a MembershipUpdate");
        }

        /// <summary>
        /// Test the property 'Note' 
        /// </summary>
        [Test]
        public void NoteTest()
        {
            // TODO: unit test for the property 'Note' 
        }
        /// <summary>
        /// Test the property 'Profile' 
        /// </summary>
        [Test]
        public void ProfileTest()
        {
            // TODO: unit test for the property 'Profile' 
        }

    }

}
