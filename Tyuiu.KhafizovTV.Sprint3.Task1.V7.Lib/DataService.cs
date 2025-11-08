using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhafizovTV.Sprint3.Task1.V7.Lib
{
    public class DataService : ISprint3Task1V7
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MS = 1;
            do
            {
                MS *= Math.Pow(value, startValue) * Math.Sin(5);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(MS, 3);
        }
    }
}