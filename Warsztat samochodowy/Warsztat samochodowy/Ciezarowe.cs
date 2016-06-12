using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat_samochodowy
{
    class Ciezarowe:Pojazd
    {
        public int DMC { get; set; }
        public int Ladownosc { get; set; }

        public override void Wypisz(ListaUslug Lista)
        {
            int suma_cen = 0;
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| " + Id + ". " + Marka + " " + Model + "   " + Rejestracja + "    Ciezarowe");
            Console.WriteLine("|------------------------------------|");
            //Console.WriteLine("");
            Console.WriteLine("| Wykonywane uslugi:                 |");

            foreach (var pozycja in UslugiNaAucie)
            {
                Console.WriteLine("| -> " + Lista.PodajNazwe(pozycja));
                suma_cen += Lista.PodajCene(pozycja);
            }
            Console.WriteLine("|                                    |");
            Console.WriteLine("| Cena wykonywanych uslug: " + suma_cen + " PLN   |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }


    }
}
