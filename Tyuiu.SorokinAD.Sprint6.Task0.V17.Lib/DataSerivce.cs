using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SorokinAD.Sprint6.Task0.V17.Lib
{
    public class DataSerivce : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            double res = Math.Pow(Math.E, x) / x;
            return Math.Round(res, 3);
        }
    }
}
