using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HomeWork_3_6
{
    internal class Program
    {
        [Flags]
        public enum MyDays
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }

        static void Main(string[] args)
        {
            //Решение задания № 3
            Console.WriteLine("---- Урок 2, задание № 3 ----");
            Console.WriteLine(); Console.WriteLine("Задание № 3");
            Console.Write("Введите целое число: ");
            int nNumber = Convert.ToInt32(Console.ReadLine()); //считывание числа
            string sResult = (nNumber % 2 == 0) ? $"Число {nNumber} четное" : $"Число {nNumber} нечетное";
            Console.WriteLine(sResult);
            Console.WriteLine();

            //Решение задания № 6
            Console.WriteLine("---- Урок 2, задание № 6 ----");
            Console.WriteLine();

            //все дни недели
            MyDays allWeekDay = (MyDays)0b_1111111;

            //для офиса 1: исключаем из всех дней недели выходные: субботу и восресенье
            MyDays workDaysOffic1 = allWeekDay ^ MyDays.Saturday ^ MyDays.Sunday;
            Console.WriteLine($"Рабочие дни офиса 1: {workDaysOffic1}");

            //для офиса 2: исключаем из всех дней недели выходные: среду и субботу
            MyDays workDaysOffic2 = allWeekDay ^ MyDays.Wednesday ^ MyDays.Saturday;
            Console.WriteLine($"Рабочие дни офиса 2: {workDaysOffic2}");

            //для офиса 3: исключаем из всех дней недели выходные: нет выходных
            MyDays workDaysOffic3 = allWeekDay;
            Console.WriteLine($"Рабочие дни офиса 3: {workDaysOffic3}");

            //для офиса 4: исключаем из всех дней недели выходные: понедельник и восресенье
            MyDays workDaysOffic4 = allWeekDay ^ MyDays.Monday ^ MyDays.Sunday;
            Console.WriteLine($"Рабочие дни офиса 4: {workDaysOffic4}");

            //
            Console.ReadLine();
        }
    }
}
