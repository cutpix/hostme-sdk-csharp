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
    ///  Class for testing Table
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TableTests
    {
        private Table instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Table();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Table
        /// </summary>
        [Test]
        public void TableInstanceTest()
        {
            Assert.IsInstanceOf<Table> (instance, "instance is a Table");
        }

        /// <summary>
        /// Test the property 'TableNumber' 
        /// </summary>
        [Test]
        public void TableNumberTest()
        {
            // TODO: unit test for the property 'TableNumber' 
        }
        /// <summary>
        /// Test the property 'TableTopSize' 
        /// </summary>
        [Test]
        public void TableTopSizeTest()
        {
            // TODO: unit test for the property 'TableTopSize' 
        }
        /// <summary>
        /// Test the property 'Area' 
        /// </summary>
        [Test]
        public void AreaTest()
        {
            // TODO: unit test for the property 'Area' 
        }
        /// <summary>
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        /// <summary>
        /// Test the property 'Reservability' 
        /// </summary>
        [Test]
        public void ReservabilityTest()
        {
            // TODO: unit test for the property 'Reservability' 
        }
        /// <summary>
        /// Test the property 'Waitability' 
        /// </summary>
        [Test]
        public void WaitabilityTest()
        {
            // TODO: unit test for the property 'Waitability' 
        }

    }

}
