using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackbis
{
    enum Figury
    {
        Dwójka = 2,
        Trójka = 3,
        Czwórka = 4,
        Piątka = 5,
        Szóstka = 6,
        Siódemka = 7,
        Ósemka = 8,
        Dziewiątka = 9,
        Dziesiątka = 10,
        Walet = 10,
        Dama = 10,
        Król = 10,
        As = 11
    }
    enum Kolory
    {
        Pik,
        Kier,
        Trefl,
        Karo
    }

    class Karty
    {
        private static Random rnd = new Random();

        public static (Figury, Kolory) LosujKarte()
        {
            Array wartoscFigury = Enum.GetValues(typeof(Figury));
            Array kolorKarty = Enum.GetValues(typeof(Kolory));

            Figury wylosowanaFigura = (Figury)wartoscFigury.GetValue(rnd.Next(wartoscFigury.Length));
            Kolory wylosowanyKolor = (Kolory)kolorKarty.GetValue(rnd.Next(kolorKarty.Length));


            return (wylosowanaFigura, wylosowanyKolor);
        }
    }
}

