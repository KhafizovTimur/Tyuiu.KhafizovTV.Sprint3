using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhafizovTV.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
                    for (int divisor = 1; divisor <= x; divisor++)
                    if (x % divisor == 0 && divisor > 5)
                        sum++;
            return sum;
        }
    }
}
