﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SorokinAD.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((x + 2) == 0)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;

                }
                else
                {
                    y = Math.Round(Math.Cos(x) + ((Math.Cos(x)) / (x + 2)) - (3 * x), 2);
                    valueArray[count] = y;
                    count++;
                }

            }
            return valueArray;
        }
    }
}
