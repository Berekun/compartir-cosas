using System;
using System.Runtime.ExceptionServices;

namespace Exercises
{
    internal class Exercises
    {
        public static bool GetEveOrOdd(double a)
        {
            return ((a % 2) == 0);
        }

        public static bool IsPrime(int number)
        {
            double solution = 0;

            for (int i = 2; i < number; i++)
            {
                solution += number % i;

                if (solution == 0)
                {
                    return false;
                }
            }

            return true;
        }


        public static double GetCircleArea(double radio)
        {
            double pi = Math.PI;

            return pi * (radio * radio);
        }

        public static double GetRectangleArea(double height, double weight)
        {
            return weight * height;
        }

        public static double GetDistance2points(double x1,double x2, double y1, double y2)
        {
            double firstparent =


            return 


        }

    }
}
