using System;

namespace Prueba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h;
            double g;
            h = Tests.GetMinor(1, 2);
            Console.WriteLine("---------");
            Console.WriteLine(h);

            g = Tests.GetMajor(1, 2);
            Console.WriteLine("---------");
            Console.WriteLine(g);

            {
                int a, b, c;
                a = 3 + 5;
                b = a * 2 + 3;
                c = b * b;
                c = c + 2;
                a = Tests.GetMinor(a, b);
                a = Tests.GetMinor(a + 1, Tests.GetMinor(b, c));
                Console.WriteLine("---------");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            {
                double a, b, x;
                a = -468;
                b = 456;
                x = Tests.SolveEquiation(a, b);
                Console.WriteLine("---------");
                Console.WriteLine(x);
            }

            {
                double a, b, c, x;

                a = 3;
                b = 20;
                c = 7;

                x = Tests.SolveEquation2(a, b, c, true);
                Console.WriteLine("---------");
                Console.WriteLine(x);
            }

            {
                double a, b, c, s1, s2;

                a = 3;
                b = 20;
                c = 7;

                (s1, s2) = Tests.SolveEquation3(a, b, c);
                Console.WriteLine("---------");
                Console.WriteLine(s1);
                Console.WriteLine(s2);
            }

            {
                double a, b, c;
                EquationSolution x;

                x = new EquationSolution();

                a = 3;
                b = 20;
                c = 7;

                (x) = Tests.SolveEquation4(a, b, c);
                Console.WriteLine("---------");
                Console.WriteLine(x.result1);
                Console.WriteLine(x.result2);
            }

            {
                double a, b, x;
                a = 7;
                b = 5;

                x = Tests.GetMultiplication(a, b);
                Console.WriteLine("---------");
                Console.WriteLine(x);
            }

            {
                int a, b, x;
                a = 7;
                b = 3;

                x = Tests.GetRest(a, b);
                Console.WriteLine("---------");
                Console.WriteLine(x);
            }

            {
                int a, x;
                a = 8;

                x = Tests.GetEveorOdd(a);
                Console.WriteLine("---------");

                if (x == 0)
                {
                    Console.WriteLine("El numero es Par");
                }
                else
                {
                    Console.WriteLine("El numero es Impar");
                }
            }


            {
                double weight, height, IMC;
                string result1;
                weight = 71;
                height = 1.70;

                (result1,IMC) = Tests.GetIMC(weight, height);
                Console.WriteLine("---------");
                Console.WriteLine(result1);
                Console.WriteLine(IMC);
            }

            {
                double capital, interests, quota;
                int time;
                capital = 200000;
                interests = 6;
                time = 360;

                quota = Tests.Getmortgage(capital, interests, time);
                Console.WriteLine("---------");
                Console.WriteLine(quota);
            }

            {
                int number;
                string x;
                number = 5;

                x = Tests.GetBeforeNumbers(number);
                Console.WriteLine("---------");
                Console.WriteLine(x);
            }

            {
                int number;
                string x;
                number = 8;

                x = Tests.GetEveofsequency(number);
                Console.WriteLine("---------");
                Console.WriteLine(x);
            }
        }
    }
}