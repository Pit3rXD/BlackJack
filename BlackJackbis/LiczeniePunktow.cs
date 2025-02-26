using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackbis
{
    class LiczeniePunktow
    {
        private static List<Figury> ListaPunktow = new List<Figury>();

        public static int WyswietlanieWartosciKart(List<Figury> figuryNaStole)
        {
            //ListaPunktow.Add(figury);
            int punkty = figuryNaStole.Sum(f => (int)f);
            Console.WriteLine($"Punkty  {punkty}");
            return punkty;
        }
    }
}
