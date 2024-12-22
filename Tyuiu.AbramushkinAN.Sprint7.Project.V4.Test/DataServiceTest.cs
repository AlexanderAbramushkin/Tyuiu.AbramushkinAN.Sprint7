using Tyuiu.AbramushkinAN.Sprint7.Project.V4.Lib;

namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestInputJson()
        {
            DataService ds = new DataService();
            Assert.AreEqual(11, ds.GetLibraries().Count());
        }
    }
}