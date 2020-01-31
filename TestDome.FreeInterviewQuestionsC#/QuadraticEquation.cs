using System;

namespace TestDome.FreeInterviewQuestionsC
{
    public class QuadraticEquation
    {
        /*
        Implement the function FindRoots to find the roots of the quadratic equation: ax2 + bx + c = 0.

        The roots of the quadratic equation can be found with the following formula: A quadratic equation.

        For example, the roots of the equation 2x2 + 10x + 8 = 0 are -1 and -4.
        */
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            var formula = (Math.Pow(b, 2) - 4*a*c);
            var result1 = (-b + Math.Sqrt(formula))/(2*a);
            var result2 = (-b - Math.Sqrt(formula))/(2*a);
                
            return new Tuple<double, double>(result1, result2);
        }

        public static void Main(string[] args)
        {
            Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
            Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
        }
    }
}