#region

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SleepwareG3Reader;

#endregion

namespace SleepEditTest
{
    [TestClass]
    public class SleepwareG3Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sleepWareG3 = new SleepwareG3(@"DataFiles/00010077-101178-report.txt");
            Assert.AreEqual("45", sleepWareG3.PatientAge);
            Assert.AreEqual("11.0", sleepWareG3.SleepLatency);
            Assert.AreEqual("71.0", sleepWareG3.REMLatency);
            Assert.AreEqual("90.8", sleepWareG3.SleepEfficiency);
            Assert.AreEqual("0.5", sleepWareG3.PLMIndex);
            Assert.AreEqual("0.2", sleepWareG3.PLMArousalIndex);
        }
    }
}