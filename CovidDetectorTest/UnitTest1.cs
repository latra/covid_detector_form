using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CovidDetector.Modules;
using CovidDetector.Models;
namespace CovidDetectorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AutoMLModule autoML = new AutoMLModule();
            autoML.autoMLAPI.getPredict(new NewPatientModel());
        }
    }
}
