using System;

namespace AreaCalculator.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcs = new IAreaCalculator[]
            {
                new TriangleAreaCalculator(3, 4, 5),
                new CircleAreaCalculator(1),
                new TriangleAreaCalculator(5, 5, 5),
                new CircleAreaCalculator(3.8),
                new TriangleAreaCalculator(7, 3, 5)
            };

            foreach (var calc in calcs)
                Console.WriteLine(calc.CalcArea());

            Console.ReadKey();
        }
    }
}
