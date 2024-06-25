using System.Diagnostics;

namespace SimplePluginLogger.nUnitTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("test1")]
        public void Test1(string s)
        {
            PluginLogger.Log(s);
            //PluginLogger.OpenLogFile();
            Debug.WriteLine(PluginLogger.LogFilePath);
            Assert.Pass();
        }
    }
}