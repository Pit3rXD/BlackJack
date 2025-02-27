using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackbis
{
    //W programowaniu jest coś takiego jak wzorce projektowe - nie musisz na razie ich znać, po prostu dobrze żebyś wiedział że istnieją - są to takie "schematy" które
    // bardzo często się powtarzają i mają już swoje nazwy. Np. decorator - bierze istniejącą już klasę, pobiera ją w konstruktor i na jej podstawie
    //w swoich własnych metodach rozszerza jej funkcje. To jest klasa która coś tam liczy i wyświetla wartość. Takie klasy które robią coś konkretnego (np. coś liczą)
    //często nazywamy po prostu Service
    public class CountPointsService
    {
        //te metody i lista mogłyby też nie być statyczne. Ale w tym wypadku wydaje mi się że mogłyby zostać
        //Po co wgl ta lista? nie jest nigdzie używana
        private static List<Figury> ListaPunktow = new List<Figury>();

        //Wyrzuciłem jednak static bo chciałem to zapakować w stół
        //Zmieniłem też parametr nad Card - będize tak mi łatwiej, bez sensu wyciągać te listę figur w obecnej sytuacji
        public int WyswietlanieWartosciKart(List<Card> figuryNaStole)
        {
            //ListaPunktow.Add(figury);
            int punkty = figuryNaStole.Sum(f => (int)f.Figure);
            Console.WriteLine($"Punkty  {punkty}");
            return punkty;
        }
    }
}
