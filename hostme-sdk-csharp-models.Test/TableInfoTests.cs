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
    ///  Class for testing TableInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TableInfoTests
    {
        private TableInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TableInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TableInfo
        /// </summary>
        [Test]
        public void TableInfoInstanceTest()
        {
            Assert.IsInstanceOf<TableInfo> (instance, "instance is a TableInfo");
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
        /// Test the property 'IsComb' 
        /// </summary>
        [Test]
        public void IsCombTest()
        {
            // TODO: unit test for the property 'IsComb' 
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
        

    }

}


