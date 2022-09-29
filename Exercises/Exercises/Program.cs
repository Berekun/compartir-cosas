namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 29;
            bool solution;

            solution = Exercises.IsPrime(number);
            Console.WriteLine(solution);

            Console.WriteLine("---------------");

            {
                double radio, x;
                radio = 8;

                x = Exercises.GetCircleArea(radio);
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------");

            {
                double height, weight, x;
                height = 7.2;
                weight = 5.3;

                x = Exercises.GetRectangleArea(height,weight);
                Console.WriteLine(x);
            }
        }
    }
}