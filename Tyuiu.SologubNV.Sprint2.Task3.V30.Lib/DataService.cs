using tyuiu.cources.programming.interfaces.Sprint2;
using static System.Math;
namespace Tyuiu.SologubNV.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1) y = x * Pow((x + 1) / (x - 1), x);
            else if (x == 0) y = (x * x - Pow(Cos(x), 2) - 3) / (x * x - Pow(Sin(x), 2) - 2);
            else if ((x > -34) && (x < 2)) y = (1 + Pow(1 / (x * x), 2));
            else if (x < -34) y = (x+ 10*x - (1/x));
            return Round(y, 3);
        }
    }
}
