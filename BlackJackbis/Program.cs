using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackbis
{
    //Ogólnie myślę że bardzo fajnie sobie z tym poradziłeś jak na razie. Serio wygląda to dobrze, poprawiłem to trochę, żebyś wiedział jak to powinno wg mnie wyglądać
    //Najważniejsze moi zdaniem było dodanie klasy Cards - z tym możesz już jechać spokojnie dalej i sobie poradzisz.
    
    //Polecam ci pisać kod po angielsku, na początku jest dziwnie ale po prostu nikt już nie pisze kodu po polsku to totalny standard, żeby używać angielskiego
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tutaj możemy spokojnie stworzyć te klasy, które są pierwotnie statyczne i zapakować je jedne w drugie jeżeli jest to uzasadnione
            //np. klasa KartySercice nie będzie potrzebna nigdzie poza stołem, więc niech Stół pobiera instancję KartyService do konstruktora
            var kartyService = new KartyService();
            var countPointsService = new CountPointsService();
            Stol stol = new Stol(kartyService, countPointsService);
           
            //(Figury figura, Kolory kolor) = Karty.LosujKarte(); na razie zmienne figura i kolor nie są nigdzie przypisane. Możliwe, że ta instrukcja bedzie usunięta.



            for (int i = 0; i < 2; i++)
            {
                stol.DodajKarte();
            }
            stol.PokazKarty();

            //nie rozumiem czemu te metody są poza stołem. Wpakujmy to i zwróćmy ze stołu
            //var karta = KartyService.LosujKarte();
            //CountPointsService.WyswietlanieWartosciKart(stol.ZwrocKarty()); 

            stol.DodajKarte();
            stol.DisplayCardsValue();

            //Co tu tyle enterów? 





        }

    }
}
