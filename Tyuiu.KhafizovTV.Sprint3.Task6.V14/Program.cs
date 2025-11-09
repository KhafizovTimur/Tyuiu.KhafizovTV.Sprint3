using Tyuiu.KhafizovTV.Sprint3.Task6.V14.Lib;

namespace Tyuiu.KhafizovTV.Sprint3.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Хафизов Т.В | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #14                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т.В | ИСПб-25-1                                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел,принадлежащих       *");
            Console.WriteLine("* числовому отрезку [7, 16] сумму всех делителей больше 5                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            int startValue = 7;
            int stopValue = 16;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}