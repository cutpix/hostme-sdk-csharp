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
    ///  Class for testing ReservationsDaypartStats
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservationsDaypartStatsTests
    {
        private ReservationsDaypartStats instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReservationsDaypartStats();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReservationsDaypartStats
        /// </summary>
        [Test]
        public void ReservationsDaypartStatsInstanceTest()
        {
            Assert.IsInstanceOf<ReservationsDaypartStats> (instance, "instance is a ReservationsDaypartStats");
        }

        /// <summary>
        /// Test the property 'Total' 
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO: unit test for the property 'Total' 
        }
        /// <summary>
        /// Test the property 'Current' 
        /// </summary>
        [Test]
        public void CurrentTest()
        {
            // TODO: unit test for the property 'Current' 
        }

    }

}
