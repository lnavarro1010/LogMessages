using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidConfiguration()
        {
            //assembly
            JobLogger mytestjoblogger = new JobLogger(false,false,false,false,false,false);
            //act
            String result= JobLogger.LogMessage("mensaje", false, false, false);
            //assert
            

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMessageWarningErrorNotEspecified()
        {
            //assembly
            JobLogger mytestjoblogger = new JobLogger(true, false, false, false, false, false);
            //act
            String result = JobLogger.LogMessage("mensaje", false, false, false);
            //assert
           

        }
        [TestMethod]
        public void TestLogMessagenull()
        {
            //assembly
            JobLogger mytestjoblogger = new JobLogger(true, false, false, false, false, false);
            //act
            String result = JobLogger.LogMessage("", false, false, false);
            //assert
            Assert.AreEqual("",result);

        }
        [TestMethod]
        public void TestLogMessageTofile()
        {
            //assembly
            JobLogger mytestjoblogger = new JobLogger(true, false, false, true, false, false);
            //act
            String result = JobLogger.LogMessage("test mensaje to file", true, false, false);
            //assert
            Assert.AreEqual("fTrue", result);

        }
        [TestMethod]
        public void TestLogMessageToDatabase()
        {
            //assembly
            JobLogger mytestjoblogger = new JobLogger(false, false, true, true, false, false);
            //act
            String result = JobLogger.LogMessage("test mensaje to database", true, false, false);
            //assert
            Assert.AreEqual("", result);

        }
    }
}
