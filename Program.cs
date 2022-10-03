using System;

namespace pipesInPool_extraConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double firstPipe = P1 * H;
            double secondPipe = P2 * H;

            double sumPipes = firstPipe + secondPipe;

            if (sumPipes <= V)
            {
                double percentage = sumPipes / V * 100;
                double percentage1 = firstPipe / sumPipes * 100;
                double percentage2 = secondPipe / sumPipes * 100;
                
                Console.WriteLine($"The pool is {percentage:f2}% full. Pipe 1: {percentage1:f2}%. Pipe 2: {percentage2:f2}%.");
            }
            else
            {
                double overflownWater = V - sumPipes;
                Console.WriteLine($"For {H:f2} hours the pool overflows with {Math.Abs(overflownWater):f2} liters.");
            }
        }
    }
}

