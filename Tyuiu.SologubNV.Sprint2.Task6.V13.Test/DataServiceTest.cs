using Tyuiu.SologubNV.Sprint2.Task6.V13.Lib;
namespace Tyuiu.SologubNV.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int x = 2024;
            int y = 2;
            int z = 27;
            string res = ds.FindDateOfNextDay(x, y, z);
            string wait = "28.02.2024";
            Assert.AreEqual(wait,res);
        }
    }
}
