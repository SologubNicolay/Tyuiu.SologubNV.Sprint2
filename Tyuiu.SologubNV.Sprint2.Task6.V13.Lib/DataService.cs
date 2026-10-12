using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SologubNV.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int dni = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29,
                _ => 0
            };
            return (n == dni, m == 12) switch
            {
                (true, true) => $"01.01.{g + 1}",
                (true, false) => $"01.{m + 1:D2}.{g}",
                (false, _) => $"{n + 1:D2}.{m:D2}.{g}"
            };
        }
    }
}
