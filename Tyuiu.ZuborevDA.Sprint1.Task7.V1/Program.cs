using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint1.Task7.V1.Lib;

namespace Tyuiu.ZuborevDA.Sprint1.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #1                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным *");
            Console.WriteLine("* значениям данных, вводимых пользователем. Ответ округлите                  *");
            Console.WriteLine("* до 3 знаков после запятой.                                                 *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double a;
            Console.WriteLine("Введите значение переменной A:");
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            Console.WriteLine("Введите значение переменной B:");
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            Console.WriteLine("Введите значение переменной C:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadKey();
        }
    }
}
