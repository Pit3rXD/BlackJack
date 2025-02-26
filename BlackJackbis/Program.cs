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
    internal class Program
    {
        static void Main(string[] args)
        {
            Stol stol = new Stol();
           
            //(Figury figura, Kolory kolor) = Karty.LosujKarte(); na razie zmienne figura i kolor nie są nigdzie przypisane. Możliwe, że ta instrukcja bedzie usunięta.



            for (int i = 0; i < 2; i++)
            {
                stol.DodajKarte();
                
            }
            stol.PokazKarty();

            var (figura, kolor) = Karty.LosujKarte();
            LiczeniePunktow.WyswietlanieWartosciKart(stol.ZwrocKarty()); 







        }

    }
}
