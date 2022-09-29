namespace Prueba_2
{
    internal class Tests
    {
        public static int GetMinor(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;

        }

        public static double GetMajor(double c, double d)
        {
            if (c > d)
                return c;
            else
                return d;
        }

        public static double SolveEquiation(double a, double b)
        {
            if (a < 0 || a > 0)

                return -b / a;

            else
            {
                return Double.NaN;
            }
        }

        public static double SolveEquation2(double a, double b, double c, bool usePositiveSolution)
        {
            if (a == 0)

                return Double.NaN;

            double root = Math.Sqrt(b * b - 4 * a * c);

            if (root < 0)

                return Double.NaN;

            double result1 = (-b - root) / (2 * a);
            double result2 = (-b + root) / (2 * a);

            if (usePositiveSolution)

                return result2;
            else

                return result1;



        }

        public static (double, double) SolveEquation3(double a, double b, double c)
        {
            if (a == 0)

                return (Double.NaN, Double.NaN);

            double root = Math.Sqrt(b * b - 4 * a * c);

            if (root < 0)

                return (Double.NaN, Double.NaN);

            double result1 = (-b - root) / (2 * a);
            double result2 = (-b + root) / (2 * a);

            return (result1, result2);
        }

        public static EquationSolution SolveEquation4(double a, double b, double c)
        {
            if (a == 0)

                return null;

            double root = Math.Sqrt(b * b - 4 * a * c);

            if (root < 0)

                return null;

            double result1 = (-b - root) / (2 * a);
            double result2 = (-b + root) / (2 * a);

            EquationSolution solution;

            solution = new EquationSolution();
            solution.result1 = result1;
            solution.result2 = result2;
            return solution;
        }

        public static double GetMultiplication(double a, double b)
        {
            return a * b;
        }

        public static int GetRest(int a, int b)
        {
            if (b == 0)

                return 0;

            return a % b;
        }

        public static int GetEveorOdd(int a)
        {
            if ((a % 2) == 0)

                return 0;

            return 1;
        }

        public static bool IsEven(int a, int b)
        {
            return (a % b) == 0;
        }

        public static (string, double) GetIMC(double weigth, double height)
        {
            if (height <= 0)
                return ("", double.NaN);

            double IMC = weigth / (height * height);

            if (IMC < 18.5)
                return ("Por debajo de lo normal", IMC);
            if (IMC < 24.9)
                return ("Estas en la media", IMC);

            return ("Estas por encima de la media", IMC);
        }

        public static double Getmortgage(double capital, double interests, int time)
        {
            if (capital <= 0)
                return double.NaN;
            if (interests <= 0)
                return double.NaN;
            if (time <= 0)
                return double.NaN;

            double numerator = (capital * (interests / 12));
            double powerbase = (1 + (interests / 100));
            double power = Math.Pow(powerbase, -time);
            double parentesis = 1 - power;

            if (parentesis == 0)
                return double.NaN;

            double quota = numerator / (100 * parentesis);

            return quota;
        }

        public static int GetSumatory(int number)
        {
            number = 5;
            int result = 0;
            int i = 0;

            while (i <= number)
            {
                result = result + i;
                i++;
            }

            return result;
        }

        public static int GetSumatory2(int number)
        {
            int result = 0;

            for (int i = 0; i <= number; i++)
            {
                result += i;
            }

            return result;
        }

        public static string GetCompostName(string pepe, string juan)
        {
            pepe = "pepe";
            juan = "juan";

            return pepe + "," + juan;
        }

        public static string GetBeforeNumbers(int number)
        {
            string result = "";

            for (int i = number; i >= 0; i--)
            {
                result = result + "," + i;
            }

            return result;
        }

        public static string GetEveofsequency(int number)
        {
            string result = "0";
            double menor = 1;

            for (int i = 2; i <= number; i += 2)
            {
                if (menor % 2 != 0)
                {
                    result = result + "," + i;
                    menor += 1;
                }
                else
                {
                    result = result + "," + "-" + i;
                    menor += 1;
                }
            }

            return result;
        }
    }
}
