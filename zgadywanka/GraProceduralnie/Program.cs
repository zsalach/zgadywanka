using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProceduralnie
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gra za dużo, za mało");
            int wylosowana = Losuj(1, 100);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif

            while (true)
            {
                //2. człowiek proponuje.
                Console.WriteLine("Podaj swoją propozycję");
                int propozycja = WczytajLiczbę();
            }
        }

        /// <summary>
        /// Losuje liczbę z podanego zakresy włacznie
        /// </summary>
        /// <param name="min">Dolne ograniczenie</param>
        /// <param name="max">Górne ograniczenie</param>
        /// <returns></returns>

        static int Losuj(int min, int max)
        {
            var rnd = new Random();
            var los = rnd.Next(min, max + 1);

            return los;
        }

        static int WczytajLiczbę()
        {
            string wczytano = Console.ReadLine();
            if(wczytano == "X"|| wczytano == "x")
            
                Environment.Exit(0);
                return 0;
            
            int wynik = 0;          
            
            try
            {  
                wynik = int.Parse(wczytano);   
            }
            catch (FormatException)
            {
                Console.WriteLine("Nie podano liczby");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Przekroczono zakres");
            }
            catch (Exception)
            {
                Console.WriteLine("Błąd nieobsługiwany");
            }
            return wynik;
        }
    }
}
