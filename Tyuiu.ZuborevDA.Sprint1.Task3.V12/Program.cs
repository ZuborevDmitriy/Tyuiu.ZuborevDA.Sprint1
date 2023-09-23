using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.ZuborevDA.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #12                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника      *");
            Console.WriteLine("* по длинам двух катетов.                                                    *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double a;
            Console.WriteLine("Введите значение первого катета:");
            a = Convert.ToDouble(Console.ReadLine());

            double b;
            Console.WriteLine("Введите значение второго катета:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.TriangleArea(a, b));

            Console.ReadLine();
        }
    }
}
