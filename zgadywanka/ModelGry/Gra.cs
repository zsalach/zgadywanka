using System;
using System.Collections.Generic;

namespace ModelGry
{
    public class Gra
    {
        //dane stan gry.
        private readonly int wylosowana = 0; //zmienna może mieć tylko raz przypisać wartość. Jesdmnorazowy set. 
        public StanGry Stan // każdy z zewnątrz będzie mógł się dowiedzieć jaki jest stan gry. Nie będzie mozna zmienić tego z zewnątrz. 
        // Enum StanGry jako typ danych.
        {
            get;
            private set;
        }

        //public int Wylosowana => wylosowana;    //properties get;
        public int Wylosowana
        {
            get
            {
                if (Stan == StanGry.Zakoncona)
                    return wylosowana;
                else
                    throw new NotSupportedException("W trakcie gry nie dostaniesz tej informacji");
            }
        }

        public Gra(int a = 1, int b = 100) //Konstruktor
        {

            Random rnd = new Random();
            wylosowana = rnd.Next(a, b + 1);
            Stan = StanGry.Trwa;
            HistoriaGry = new List<Ruch>();

        }

        public void Poddaj()
        {
            Stan = StanGry.Zakoncona;
        }

        public List<Ruch> HistoriaGry { get; } // Listy generyczne - generyki programowanie uogulnione.. 

        public Odp Odpowiedz(int propozycja) // Enum jest typem danych Odp
        {
            if (propozycja < wylosowana)
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.ZaMalo));
                return Odp.ZaMalo;
            }
            else if (propozycja > wylosowana)
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.ZaDuzo));
                return Odp.ZaDuzo;
            }
            else
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.Trafiono));
                return Odp.Trafiono;
                Stan = StanGry.Zakoncona;
            }
        }
    }

    public enum StanGry // wymienienie elementów - typ danych 
    {
        Rozpoczeta,
        Trwa,
        Zapauzowana,
        Zakoncona,

    }
    public enum Odp // ten enum jest taką przykrywką na inta
    {
        ZaMalo = -1,
        Trafiono = 0,
        ZaDuzo = 1
    }
}
