using System;

namespace NonLinearEquation
{
    public class Program
    {

        static double f(double x)
        {
            return Math.Log(x) + 2;
        }

        public static void Main()
        {
            var isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("Pasirinkite, kurį algoritmą norėsite naudoti: " +
                              "\r\n1. Pusiaukirtos metodas" +
                              "\r\n2. Niutono - Rapsono metodas" +
                              "\r\n3. Išeiti iš programos");
                Console.Write("Jūsų pasirikimas: ");
                var pasirinkimas = Console.ReadLine();
                switch (pasirinkimas)
                {
                    case "1":
                        double computed = NewBisectionBecauseOldWasPieceOfShit.Solve();
                        //BisectionMethod.BisectionMethodAlgorithm();
                        break;

                    case "2":
                        NewtonRaphson.NewtonRaphsonMethod();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Blogas pasirinkimas!");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}