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
            Logger logger = new Logger();
            logger.Log(s);
            //PluginLogger.OpenLogFile();
            Debug.WriteLine(logger.LogFilePath);
            Assert.Pass();
        }
    }
}