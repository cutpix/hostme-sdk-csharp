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
    ///  Class for testing IEdmDirectValueAnnotationsManager
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IEdmDirectValueAnnotationsManagerTests
    {
        private IEdmDirectValueAnnotationsManager instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IEdmDirectValueAnnotationsManager();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of IEdmDirectValueAnnotationsManager
        /// </summary>
        [Test]
        public void IEdmDirectValueAnnotationsManagerInstanceTest()
        {
            Assert.IsInstanceOf<IEdmDirectValueAnnotationsManager> (instance, "instance is a IEdmDirectValueAnnotationsManager");
        }


    }

}
