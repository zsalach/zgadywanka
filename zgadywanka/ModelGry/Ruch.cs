﻿
using System;
namespace ModelGry
{
    public class Ruch
    {
        public readonly int Propozycja;
        public readonly Odp Odpowiedz;
        public readonly DateTime Kiedy;

        public Ruch(int prop, Odp odp)
        {
            Propozycja = prop;
            Odpowiedz = odp;
            Kiedy = DateTime.UtcNow;
        }

        public override string ToString()
        => $"{Propozycja} | {Odpowiedz} | {Kiedy}";


    }
}