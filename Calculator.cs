﻿using System;
using System.Globalization;

namespace Static_Class
{
    internal class Calculator
    {
        public static double Pi = 3.14;

        public static double Circunference(double r)
        {
            return 2 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
