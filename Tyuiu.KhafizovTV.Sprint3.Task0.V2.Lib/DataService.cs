using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhafizovTV.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MS = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MS = MS * Math.Pow(i / (Math.Pow(Math.Sin(1), -7)), -2);
            }
            return Math.Round(MS, 3);
        }
    }
}