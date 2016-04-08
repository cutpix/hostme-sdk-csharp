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
    ///  Class for testing WaitingSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WaitingSettingsTests
    {
        private WaitingSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WaitingSettings();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WaitingSettings
        /// </summary>
        [Test]
        public void WaitingSettingsInstanceTest()
        {
            Assert.IsInstanceOf<WaitingSettings> (instance, "instance is a WaitingSettings");
        }

        
        /// <summary>
        /// Test the property 'AcceptRemoteRegistration' 
        /// </summary>
        [Test]
        public void AcceptRemoteRegistrationTest()
        {
            // TODO: unit test for the property 'AcceptRemoteRegistration' 
        }
        
        /// <summary>
        /// Test the property 'EnableManualHold' 
        /// </summary>
        [Test]
        public void EnableManualHoldTest()
        {
            // TODO: unit test for the property 'EnableManualHold' 
        }
        
        /// <summary>
        /// Test the property 'MaximumHoldTime' 
        /// </summary>
        [Test]
        public void MaximumHoldTimeTest()
        {
            // TODO: unit test for the property 'MaximumHoldTime' 
        }
        
        /// <summary>
        /// Test the property 'PositionMessages' 
        /// </summary>
        [Test]
        public void PositionMessagesTest()
        {
            // TODO: unit test for the property 'PositionMessages' 
        }
        
        /// <summary>
        /// Test the property 'StatusMessages' 
        /// </summary>
        [Test]
        public void StatusMessagesTest()
        {
            // TODO: unit test for the property 'StatusMessages' 
        }
        

    }

}


