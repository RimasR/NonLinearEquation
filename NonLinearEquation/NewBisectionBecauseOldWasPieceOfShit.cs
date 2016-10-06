using System;

namespace NonLinearEquation
{
    public class NewBisectionBecauseOldWasPieceOfShit
    {
        private static double f(double x)
        {
            return Math.Log(x) + 2;
        }

        // NEED VERIFICATION

        public static double Solve()
        {
            int i = 1;
            double x = 10;
            double epsilon = 1e-9;
            double x0 = 0;
            double x1 = 0;
            double x2 = 0;
            double f0;
            double f1;
            double f2;
            int itermax = 200;
            
            Console.Write("Iveskite intervalo pradzios taska: ");
            if (!Double.TryParse(Console.ReadLine(), out x0))
            {


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas intervalo pradžios įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            Console.Write("Įveskite intervalo pabaigos taska: ");
            if (!Double.TryParse(Console.ReadLine(), out x1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas intervalo pabaigos įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            do
            {
                x2 = (x0 + x1)/2;
                f0 = f(x0);
                f1 = f(x1);
                if (f0*f1 > 0)
                {
                    Console.WriteLine("Cannot find root in this interval.");
                    break;
                }
                if (x1 - x0 < 2*epsilon)
                {
                    Console.WriteLine($"apytikslis sprendinys: {x2}");
                    Console.ReadKey();
                }
                f2 = f(x2);
                if (f2 == 0.0)
                {
                    Console.WriteLine($"Tikslus sprendinys: {x2}");
                    Console.ReadKey();
                    return x2;
                }
                Console.WriteLine($"Iteration: {i}, x0: {x0}, x1: {x1}, x2: {x2}, f0: {f0}, f1: {f1}, f2: {f2}");
                if (f0*f2 < 0)
                {
                    x1 = x2;
                }
                else
                {
                    x0 = x2;
                }
                i++;


            }
            while (Math.Abs(f(x1)) > epsilon && i < itermax);
            return x2;
        }
    }
}