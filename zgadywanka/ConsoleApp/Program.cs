using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gra za dużo za mało");

            //1.  komputer losuje.

            Random los = new Random(); // deklaruję zmienną los i przypisuje do typu Random jednocześnie tworzę obiekt.
            int wylosowana = los.Next(1, 100+1);  // losuje z przedziału 
            Console.WriteLine(wylosowana);
            Console.WriteLine("Wylosowano liczbę od 1 do 100. \nOdgadnij ją");

            //2. człowiek proponuje.
            Console.WriteLine("Podaj swoją propozycję");
            // int propozycja = int.Parse(Console.ReadLine()); // Parsujemy dane wprowadzone z klawiatury na INT32
            int propozycja = Convert.ToInt32(Console.ReadLine());

            //3. komputer ocenia.

            if (propozycja < wylosowana)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Za mało");
                Console.ResetColor();
            }
            else if (propozycja > wylosowana)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Za dużo ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; //aby wyłączyć konsole musimu ją zresetować.
                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Trafiono!!!");
                Console.ResetColor(); // resetujemy kolor konsoli.
            }
            //4. 2 i 3 zapętlamy.
        }
    }
}
