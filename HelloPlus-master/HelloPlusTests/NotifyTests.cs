using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloPlusApi.Models;
using HelloPlusApi.Controllers;
using NUnit.Framework;
using HelloPlusApi.Resources;
using System.Globalization;
using System.Threading;
using System.Web.Http;
using System.Net.Http;
using HelloPlusApi;
using Moq;

namespace HelloPlusTests
{
    [TestFixture]
    public class NotifyTests
    {
         NotifyController notify = new NotifyController();
        private Mock<IConfigurationManager> _configurationManager;


        [SetUp]
        public void Setup()
        {
           // notify = new Mock<NotifyController>();
            _configurationManager = new Mock<IConfigurationManager>();
            //notify.Setup(_configurationManager);
        }

        [Test]
        public void NotifyTest()
        {
            _configurationManager.Setup(cm => cm.GetAppSetting("NotifierType")).Returns("none");
            string result = notify.Notify(_configurationManager.Object);
            
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(typeof(string),typeof(result));
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);

            var msgString = Language.GetFromResourceFile("BaseHelloMessage", "en-US");

            NUnit.Framework.Assert.AreSame(msgString, result);
            NUnit.Framework.Assert.IsNotNull(result);

            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(msgString, result);
            // Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);

          
           }

        [Test]
        public void GetBasicMessageTest_en()
        { // Assert.IsNotNull(variables);

            string response = notify.GetMessage();
            //  Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(typeof(string),typeof(response));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(response);

            var msgString = Language.GetFromResourceFile("BaseHelloMessage", "en-US");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(msgString, response);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(response);
        }

        [Test]
         public void GetMessageTest()
        { // Assert.IsNotNull(variables);
     
            string response = notify.GetMessageByLanguage("fr-CA");
          //  Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(typeof(string),typeof(response));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(response);

            var msgString = Language.GetFromResourceFile("BaseHelloMessage", "fr-CA");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(msgString, response);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(response);
        }


        //[TestMethod]
        //public void GetBasicMessageTest_fr()
        //{   string response = notify.GetMessage();
        //    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(response);

        //    var msgString = Language.GetFromResourceFile("BaseHelloMessage", "fr-CA");
        //    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreSame(msgString, response);

        //    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(response);
        //}

        //[Test]
        //[TestCase()]
        //public void GetBasicMessage_NUnitTest()
        //{ // Assert.IsNotNull(variables);

        //    string response = notify.GetMessage();
        //    NUnit.Framework.Assert.IsInstanceOf(typeof(string), response);
        //    NUnit.Framework.Assert.IsNotNull(response);
        //}



    }
}
