using System;
using System.Collections.Generic;




namespace Warsztat_samochodowy
{
    public abstract class Pojazd
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Rejestracja { get; set; }
        public bool Benzyna { get; set; }
        public int Id { get; set; }
        public bool CzyOsobowe { get; set; }

        public List<int> UslugiNaAucie;


        public Pojazd()
        {
            UslugiNaAucie = new List<int>();
        }

        public virtual void Wypisz()
        {
            Console.WriteLine(Id + ". " + Marka + " " + Model);

        }

        public virtual void Wypisz(ListaUslug Lista)
        {
            int suma_cen = 0;
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| " + Id + ". " + Marka + " " + Model + "   " + Rejestracja);
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
