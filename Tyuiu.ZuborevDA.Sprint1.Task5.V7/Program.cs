using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint1.Task5.V7.Lib;

// Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня), когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).

namespace Tyuiu.ZuborevDA.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                 *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #7                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: Определить            *");
            Console.WriteLine("* h – полное количество часов прошедших от начала суток до того момента      *");
            Console.WriteLine("* (в первой половине дня), когда часовая стрелка повернулась на              *");
            Console.WriteLine("* f градусов (0<f<360, f – вещественное число).                              *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double f;
            Console.WriteLine("Введите значение угла, на который отклониться стрелка часов:");
            f = Convert.ToInt32(Console.ReadLine());
            if (f <= 360 & f > 0)
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine(ds.AngleToHoursMinutes(f));
            }
            else
            {
                Console.WriteLine("Недопустимые значения!");
            }

            Console.ReadKey();
        }
    }
}
