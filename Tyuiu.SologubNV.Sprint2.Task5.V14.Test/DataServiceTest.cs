using Tyuiu.SologubNV.Sprint2.Task5.V14.Lib;
namespace Tyuiu.SologubNV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int x = 200;
            int y = 2;
            string res = ds.FindDayName(x, y);
            string wait = "Пятница";
            Assert.AreEqual(wait, res);
        }
    }
}
