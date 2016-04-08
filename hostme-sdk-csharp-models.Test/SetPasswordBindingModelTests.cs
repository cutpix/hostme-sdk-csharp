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
    ///  Class for testing SetPasswordBindingModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SetPasswordBindingModelTests
    {
        private SetPasswordBindingModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SetPasswordBindingModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SetPasswordBindingModel
        /// </summary>
        [Test]
        public void SetPasswordBindingModelInstanceTest()
        {
            Assert.IsInstanceOf<SetPasswordBindingModel> (instance, "instance is a SetPasswordBindingModel");
        }

        
        /// <summary>
        /// Test the property 'NewPassword' 
        /// </summary>
        [Test]
        public void NewPasswordTest()
        {
            // TODO: unit test for the property 'NewPassword' 
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


