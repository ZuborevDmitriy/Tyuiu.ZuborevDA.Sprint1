﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZuborevDA.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double lengthCathetus1, double lengthCathetus2)
        {
            return 1.0 / 2 * lengthCathetus1 * lengthCathetus2;
        }
    }
}
