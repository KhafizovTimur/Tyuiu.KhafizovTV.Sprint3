using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhafizovTV.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                valueArray[i] = Math.Round((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7*x - 2, 2);
            }
            return valueArray;
        }
    }
}