using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulation.Tests.MS.DDT
{
    [TestClass]
    public class GreetingTests
    {
        [TestClass()]
        public class UserModelTest
        {
            public TestContext TestContext { get; set; }

            [DataSource(
                "Microsoft.VisualStudio.TestTools.DataSource.XML",
                "|DataDirectory|\\Users.xml",
                "TestCase",
                DataAccessMethod.Sequential)]
            [DeploymentItem("StringManipulation.Tests.MS.DDT\\Users.xml")]
            [TestMethod]
            public void SayHello_HelloConcatWithConcreteUserName()
            {
                string userName = Convert.ToString(TestContext.DataRow["UserName"]);

                string expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

                string actual = StringManipulation.Greeting.SayHello(userName);

                Assert.AreEqual(expected,actual);

            }

            [TestMethod]
            public void SayHello_HelloConcatWithEmptyString_Return_HelloUnknown()
            {
                string userName = string.Empty;

                string expected = "Hello, unknown!";

                string actual = Greeting.SayHello(userName);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SayHello_HelloConcatWithNull_Throw_ArgumentNullException()
            {
                string userName = null;

                Greeting.SayHello(userName);
            }
        }
    }
}
