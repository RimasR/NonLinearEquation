using System;
using System.CodeDom;

namespace NonLinearEquation
{
    internal class Program
    {
        private static void Main()
        {
            LogarithmBisectionMethod();
            //NewtonRaphson();
        }

        private static double LogarithmBisectionMethod()
        {
            double min = 1;
            double max = 500;
            double err = 0.000001;
            double e = max - min;
            double fa = Equation(min);
            double x = 0;
            double fx = 0;
            int itermax = 100;
            var iter = 0;
            if (Equation(min)*Equation(max) > 0)
            {
                Console.WriteLine($"Nėra sprendinių, initial guess: {e}");
            }
            else
            {
                while (e > err)
                {
                    iter += 1;
                    x = 0.5*(min + max);
                    e = Math.Abs(max - x);
                    fx = Equation(x);
                    if (fx == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (fx*Equation(min) > 0)
                        {
                            min = x;
                            fa = fx;
                        }
                        else
                        {
                            max = x;
                        }
                    }
                    if (iter == itermax)
                    {
                        break;
                    }

                    Console.WriteLine($"Possible middle: {x}");
                }
            }

            return x;
        }

        private static double Equation(double x)
        {
            return Math.Log(x) - 2;
        }

        private static double EquationDetivative(double x)
        {
            return 1/x + 2;
        }

        private static double NewtonRaphson()
        {
            double x0 = 500;
            double tolerance = 0.00000001;
            int itermax = 2000;
            int iter = 0;
            double x = 0;

            for (iter = 0; (Math.Abs(Equation(x0)) > tolerance) && (iter < itermax); iter++)
            {
                x0 = x0 - Equation(x0)/EquationDetivative(x0);
                Console.WriteLine($"Step: {iter}, x: {x0}, Value: {Equation(x0)}");
            }

            if (Math.Abs(Equation(x0)) <= tolerance)
            {
                Console.WriteLine($"Zeroed at {x0}");
            }
            else
            {
                Console.WriteLine("Could not zero.");
            }

            return x0;

        }
    }
}