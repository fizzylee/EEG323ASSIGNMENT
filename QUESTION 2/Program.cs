using System;

namespace TEST_ANSWER
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Enter your values for a, b, c, d, e, f");

            Console.WriteLine("a : ");
            double a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("b : ");
            double b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("c : ");
            double c = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("d : ");
          double d = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("e : ");
            double e = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("f : ");
            double f = Convert.ToInt32(Console.ReadLine()); 


            double X = (e * d - b * f )/(a * d - b * c);
            double Y = (a * f - e * c) / (a * d - b * c);

            if (a * d - b * c == 0) {
                Console.WriteLine("The Equation has no solution");
            } else {
                Console.WriteLine("X is " + X);
                Console.WriteLine("Y is " + Y);
            }

        }
    }
}
