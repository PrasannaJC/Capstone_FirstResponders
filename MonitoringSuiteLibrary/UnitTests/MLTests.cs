using MonitoringSuiteLibrary.Models;
using MonitoringSuiteLibrary.MachineLearning;
using Xunit;

namespace UnitTests
{
    public class MLTests
    {

        [Fact]
        public void Test_NOT_Distress()
        {

            Vitals v = new Vitals()
            {
                BloodOxy = 94,
                HeartRate = 155,
                SysBP = 129,
                DiaBP = 82,
                RespRate = 11,
                TempF = (float)99.95,
            };

            char g = 'M';
            int a = 39;

            bool k = CheckDistress.GetDistressStatus(a, g, v);

            Assert.False(k);
        }

        [Fact]
        public void Test_IN_Distress()
        {

            Vitals v = new Vitals()
            {
                BloodOxy = 93,
                HeartRate = 185,
                SysBP = 157,
                DiaBP = 88,
                RespRate = 6,
                TempF = (float)103.24,
            };

            char g = 'F';
            int a = 59;

            bool k = CheckDistress.GetDistressStatus(a, g, v);

            Assert.True(k);

        }
    }
}