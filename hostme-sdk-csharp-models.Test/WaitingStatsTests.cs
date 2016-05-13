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
    ///  Class for testing WaitingStats
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WaitingStatsTests
    {
        private WaitingStats instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WaitingStats();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WaitingStats
        /// </summary>
        [Test]
        public void WaitingStatsInstanceTest()
        {
            Assert.IsInstanceOf<WaitingStats> (instance, "instance is a WaitingStats");
        }

        /// <summary>
        /// Test the property 'WaitByGroup' 
        /// </summary>
        [Test]
        public void WaitByGroupTest()
        {
            // TODO: unit test for the property 'WaitByGroup' 
        }

    }

}
