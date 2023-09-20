using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZuborevDA.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return 4.0 / 3 * 3.14 * (r * r * r);
        }
    }
}