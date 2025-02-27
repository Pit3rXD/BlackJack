using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackbis
{
    internal class Stol
    {
        private readonly KartyService kartyService;
        private readonly CountPointsService countPointsService;

        //Bardo fajnie że zrobiłeś prywatną listę i metodę zwracającą zawartość. Gdyby była publiczna ktoś mógłby zedytować tę listę albo coś tu nagrzebać (np. wyciągnąć info, 
        //którego nie chcemy żeby wyciągał).

        //Podkreśla ci na zielono listaKart - jak najedziesz kursorem to możesz przeczytać, że chcę zrobić readonly - wprowadzaj takie rzeczy, zazwyczaj podpowiada dobrze
        private List<Card> listaKart = new List<Card>();

        public Stol(KartyService kartyService, CountPointsService countPointsService)
        {
            this.kartyService = kartyService;
            this.countPointsService = countPointsService;
        }

        //Tą metodę bym nazwał "DrawCard" ale nie wiemm jak to będzie po polsku haha
        public void DodajKarte()
        {
            var nowaKarta = kartyService.LosujKarte();
            if (!listaKart.Contains(nowaKarta))
            {
                listaKart.Add(nowaKarta);
            }
        }

        public void PokazKarty()
        {
            foreach (var karta in listaKart)
            {
                //Dzięki temu że stworzyliśmy Card nie masz już tych dziwnych Item1 i Item2, zamiast tego masz parametry, które rzeczywiście coś znaczą
                Console.WriteLine($"{karta.Figure} {karta.Color}");
            }
        }

        public List<Figury> ZwrocKarty()
        {
            return listaKart.Select(k => k.Figure).ToList();
        }

        public void DisplayCardsValue()
        {
            DodajKarte();
            countPointsService.WyswietlanieWartosciKart(listaKart);
        }
    }
}