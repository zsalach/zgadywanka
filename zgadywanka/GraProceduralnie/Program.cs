using System;
using System.Diagnostics;

namespace GraProceduralnie
{
    class Program
    {
        const string ZADUZO = "Za dużo";
        const string ZAMALO = "Za mało";
        const string TRAFIONO = "Trafiono!";


        static void Main(string[] args)
        {
            bool poprawnie = false;

            Console.WriteLine("Gra za dużo, za mało");
            int a = WczytajLiczbę("Podaj dolny zakres losowania:");
            int b = WczytajLiczbę("Podaj górny zakres losowania:");
            int wylosowana = Losuj(a, b); // losuje liczby wskazane przez usera.
#if DEBUG
            //Console.WriteLine(wylosowana);
#endif
            int counter = 0;
            var stoper = new Stopwatch();
            stoper.Start();
            while (true)
            {
                //2. człowiek proponuje.
                ++counter;
                int propozycja = WczytajLiczbę("Podaj swoją propozycję lub x aby zakończyć.");
                string wynik = Ocena(wylosowana, propozycja);
                Console.WriteLine(wynik);
                if (wynik == TRAFIONO)
                {
                    break;
                }
            }
            stoper.Stop();
            Console.WriteLine("Koniec gry");
            Console.WriteLine($"Odnalazłeś liczbę w {counter} strzałach");
            Console.WriteLine($"czas gry {stoper.Elapsed.TotalSeconds}"); // stoper.Elapsed - wskazuje czas w sekundach. TimeSpan - formatowanie daty i czasu.
        }

        /// <summary>
        /// Losuje liczbę z podanego zakresy włacznie
        /// </summary>
        /// <param name="min">Dolne ograniczenie</param>
        /// <param name="max">Górne ograniczenie</param>
        /// <returns></returns>
        static int Losuj(int min = 1, int max = 100)
        {
            var min1 = Math.Min(min, max);
            var max1 = Math.Max(min, max);

            var rnd = new Random();
            var los = rnd.Next(min1, max1 + 1);

            return los;
        }


        static int WczytajLiczbę(string prompt = "")
        {
            bool poprawnie = false;
            int wynik = 0;

            do
            {
                Console.WriteLine(prompt); // s
                string wczytano = Console.ReadLine();
                if (wczytano == "X" || wczytano == "x")

                    Environment.Exit(0);

                try//       stosować na małych kawałkach kodu, bo spowalnia. i to znacznie.
                {
                    wynik = int.Parse(wczytano);
                    poprawnie = true;
                }
                catch (FormatException) // catch aby były umieszczane szczegółowego do ogólnego. 
                {
                    Console.WriteLine("Niepoprawny zapis liczby. Spróbój jeszcze raz. ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przekroczono zakres");
                }
                catch (Exception)
                {
                    Console.WriteLine("Błąd nieobsługiwany");
                }
            } while (!poprawnie);

            return wynik;
        }

        static string Ocena(int wylosowana, int propozycja)
        {
            if (wylosowana < propozycja)
            {
                return ZADUZO;
            }
            else if (wylosowana > propozycja)
            {
                return ZAMALO;
            }
            else //if(wylosowana == propozycja)
                return TRAFIONO;
        }
    }
}
