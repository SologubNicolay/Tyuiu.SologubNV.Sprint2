using Tyuiu.SologubNV.Sprint2.Task4.V3.Lib;
namespace Tyuiu.SologubNV.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditions()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 3.667;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConditions2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1.500;
            Assert.AreEqual(wait, res);
        }
    }
}
