using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SologubNV.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x,2) + Math.Pow(y,2) <=1) && (x>=0) || (x >= 0) && (y<=1) && (x - 1 <= y))
            {
                return true;
            }
            else return false;
        }
    }
}
