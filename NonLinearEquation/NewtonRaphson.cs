using System;

#pragma warning disable 1587
/// <summary>
/// Niutono Rapsono metodas:
/// 1. Pasirenkame pradinį artinį ir epselon tikslumą
/// 2. Apskaičiuojame naują artinį su niutono algoritmu
/// 3. Tikriname tikslumą: jei naujo artinio ir paskutinės iteracijos artinio atimtis yra mažesnė, nei epselon - radome sprendinį.
/// 4. Jei daugiau nei epselon grįžtame į 2 žingsnį su nauju artiniu.
/// </summary>
#pragma warning restore 1587

namespace NonLinearEquation
{
    public class NewtonRaphson
    {
        public static double NewtonRaphsonMethod()
        {
            double pradinisArtinys;
            double epselon;

            Console.Write("Įveskite pradinį artinį");
            if (!Double.TryParse(Console.ReadLine(), out pradinisArtinys))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas pradinio artinio įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            Console.Write("Įveskite norimą epseloną");
            if (!Double.TryParse(Console.ReadLine(), out epselon))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas epselon įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            double galimasAtsakymas = 0;
            var maksimalusIteracijuSkaicius = 1000;

            // Pasileidžiame ciklą iki maksimalaus iteracijų skaičiaus, kad nebūtų begalinis.
            for (var iteracija = 0; iteracija < maksimalusIteracijuSkaicius; iteracija++)
            {
                // Susirandame naują artinį pagal niutono algoritmą. lygties sprendimą ir lygties išvestinės dalybą atimame iš pradinio artinio.
                galimasAtsakymas = pradinisArtinys - LygtiesSprendimas(pradinisArtinys) / LygtiesIsvestinesSprendimas(pradinisArtinys);

                // Jei gauto atsakymo ir pradinio artinio atimtis yra mažesnė, nei epselon, tada radome atsakymą.
                if (Math.Abs(galimasAtsakymas - pradinisArtinys) < epselon)
                {
                    return galimasAtsakymas;
                }

                //Jei nemažiau nei epselon, prisiskiriame galimą artinį į pradinį artinį ir sukame ciklą iš naujo.
                pradinisArtinys = galimasAtsakymas;

                Console.WriteLine($"Iteracija: {iteracija}, galimas artinys: {pradinisArtinys}, Artinio lygties sprendimas: {LygtiesSprendimas(pradinisArtinys)}");
            }

            Console.WriteLine($"Pasiektas iteracijų maksimumas, paskutinės iteracijos galimas atsakymas: {galimasAtsakymas}");

            return galimasAtsakymas;
        }

        // Lygties sprendinio metodas, galima apsirašyti ir kitokią lygtį.
        private static double LygtiesSprendimas(double x)
        {
            return Math.Log(x) - 2;
        }

        // Lygties sprendinio išvetinės metodas, galima apsirašyti ir kitokią išvestinę.
        private static double LygtiesIsvestinesSprendimas(double x)
        {
            return 1 / x + 2;
        }
    }
}