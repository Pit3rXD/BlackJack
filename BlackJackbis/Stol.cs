using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackbis
{
    class Stol
    {
        List<(Figury, Kolory)> listaKart = new List<(Figury, Kolory)>();

        public void DodajKarte()
        {
            var nowaKarta = Karty.LosujKarte();
            if (!listaKart.Contains(nowaKarta))
            {
                listaKart.Add(nowaKarta);
            }
        }

        public void PokazKarty()
        {
            foreach (var karta in listaKart)
            {
                Console.WriteLine($"{karta.Item1} {karta.Item2}");

            }
        }
        public List<Figury> ZwrocKarty()
        {
            return listaKart.Select(k => k.Item1).ToList();
        }
    }
}
