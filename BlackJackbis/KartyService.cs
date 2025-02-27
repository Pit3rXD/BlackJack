using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//To jak jest wyszarzone to znaczy, że nie jest używane - klikasz prawy i jest opcja "Remove and Sort Usings", która robi porządek za ciebie
using System.Threading.Tasks;

namespace BlackJackbis
{
    //Enumy jak najbardziej super
    public enum Figury
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
    public enum Kolory
    {
        Pik,
        Kier,
        Trefl,
        Karo
    }
    //Zróbmy z tego service i wywalmy słówka STATIC - nie są nam potrzebne a nie będzie można tego przetestować. Teraz jescze nic nie wiesz o testowaniu,
    //ale zaufaj mi - nie chcesz mieć zbyt wielu statycznych klas/metod
    public class KartyService
    {
        private Random rnd = new Random();

        public Card LosujKarte()
        {
            Array wartoscFigury = Enum.GetValues(typeof(Figury));
            Array kolorKarty = Enum.GetValues(typeof(Kolory));

            Figury wylosowanaFigura = (Figury)wartoscFigury.GetValue(rnd.Next(wartoscFigury.Length));
            Kolory wylosowanyKolor = (Kolory)kolorKarty.GetValue(rnd.Next(kolorKarty.Length));

            //Nie chcemy zwracać krotek - ciężko się z nimi pracuje. Jeżeli chcesz zwrócić krotkę to znaczy że prawdopodobnie powinieneś stworzyć klasę modelową, która to opakuje
            //W tym przypadku potrzebujesz klasy Karta (Card) a to będize serwis, który coś z nimi robi (tutaj losuje)
            ////return (wylosowanaFigura, wylosowanyKolor);
            
            return new Card(wylosowanaFigura, wylosowanyKolor);
        }
    }
}

