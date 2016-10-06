using System;

#pragma warning disable 1587
/// <summary>
/// Pusiaukirtos metodas:
/// 1. Pasirenkame norimą intervalą ir epseloną
/// 2. Pasitikriname, ar su duotais duomenimis galima išspręsti uždavinį
/// 3. Apsiskaičiuojame vidurio tašką.
/// 4. Tikriname tikslumą: jei |viršus - apačia| yra mažiau nei epselonas, turime apytikslį sprendinį
/// 5. Jei lygties atsakymas su nauju vidurio tašku yra apytiksliai lygus nuliui - turime atsakymą.
/// 6. Jei nelygus nuliui randame naują intervalą:
///     Jei lygties atsakymas us vidurio tašku ir lygties atsakymas su intervalo apačia yra daugiau nei nulis, tada intervalo apačia bus vidurio taškas.
///     Kitu atvėju, itervalo viršus bus vidurio taškas.
/// 7. Einame į 3 žingsnį
/// </summary>
#pragma warning restore 1587

namespace NonLinearEquation
{
    public class BisectionMethod
    {
        public static double BisectionMethodAlgorithm()
        {
            Console.Clear();
            Console.WriteLine("Pusiaukirtos metodas.");
            double intervaloApacia;
            double intervaloVirsus;
            double epselon;

            Console.Write("Įveskite intervalo pradžią: ");
            if (!Double.TryParse(Console.ReadLine(), out intervaloApacia))
            {
                

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas intervalo pradžios įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            Console.Write("Įveskite intervalo pabaigos: ");
            if (!Double.TryParse(Console.ReadLine(), out intervaloVirsus))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas intervalo pabaigos įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            Console.Write("Įveskite norimą epseloną: ");
            if (!Double.TryParse(Console.ReadLine(), out epselon))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blogas epselono įvedimas! Patikrinkite įvedimą!");
                Console.ResetColor();
                Console.ReadLine();
                return 0;
            }

            // Tiklsumo tikrinimui skirtas kintamasis
            double apytikslis = intervaloVirsus - intervaloApacia;
            // Vidurio taško kintamasis
            double vidurioTaskas = 0;
            // Norimų iteracijų skaičius
            int itermax = 1000;
            // Dabartinė itercija
            var iter = 0;

            // Algoritmo pradžia

            // Patikriname, ar galima rasti atsakymą su duotais duomenimis. 
            // Jei nėra sprendinių, parašome pirmą spėjimą ir išeiname iš algoritmo skaičiavimo

            if (RastiLygtiesSprendini(intervaloApacia) * RastiLygtiesSprendini(intervaloVirsus) > 0)
            {
                Console.WriteLine($"Nėra sprendinių, pirmas spėjimas: {apytikslis}");
                return apytikslis;
            }

            // Sukame ciklą, kol apytikslis sprendinys yra didesnis už norimą epseloną

            while (iter < itermax && (intervaloVirsus - intervaloApacia > epselon))
            {

                // Randame vidurio tašką sudedant intervalo apačią ir viršų, ir padalinant iš 2
                vidurioTaskas = 0.5 * (intervaloApacia + intervaloVirsus);

                // Ieškome naujo apytikslio sprendinio
                apytikslis = Math.Abs(intervaloVirsus - vidurioTaskas);

                // Randame naują lygties sprendinį su vidurio tašku
                var sprendinioAtsakymas = RastiLygtiesSprendini(vidurioTaskas);

                // Jei lygties sprendinys lygus nuliui - turime atsakymą, vidurioTaskas bus mūsų atsakymas
                //if (sprendinioAtsakymas < epselon)
                //{
                //    Console.WriteLine($"Sprendinio atsakymas : {sprendinioAtsakymas}");
                //    break;
                //}

                // Jei visgi lygties sprendinys nėra lygus nuliui, žiūrime koks bus mūsų naujas intervalas.

                //Pagal algoritmą: Jei vidurio taško lygties sprendinio ir intervalo apačios lygties sprendinio daugyba yra didesnė už nulį:
                // intervalo apačia bus mūsų nustatytas naujas vidurio taškas.
                // Jei didesnis už nulį - intervalo viršus bus vidurio taškas.
                if (sprendinioAtsakymas * RastiLygtiesSprendini(intervaloApacia) > 0)
                {
                    intervaloApacia = vidurioTaskas;
                }
                else
                {
                    intervaloVirsus = vidurioTaskas;
                }

                // Tikriname, ar iteracijų skaičius dar nesiekia maksimalaus iteracijų skaičiaus. Jei taip, išeiname iš užsukto ciklo.
                if (iter == itermax)
                {
                    Console.WriteLine("Pasiektas maksimalus iteracijų skaičius, išeinama iš algoritmo skaičiavimo");
                    break;
                }

                Console.WriteLine($"Iteracija: {iter}, galimas atsakymas: {vidurioTaskas},intervalo apacia {intervaloApacia}, intervalo virsus: {intervaloVirsus}, lygties sprendinys: {sprendinioAtsakymas}");

                // Didiname iteraciją per vieną.
                iter += 1;
            }


            //Jei išėjome iš ciklo, grąžiname galimą vidurio tašką.
            return vidurioTaskas;
        }

        // Lygties sprendinio metodas, galima apsirašyti ir kitokią lygtį.
        private static double RastiLygtiesSprendini(double x)
        {
            return Math.Log(x) + 2;
        }
    }
}