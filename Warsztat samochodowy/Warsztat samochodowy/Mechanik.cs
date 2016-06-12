using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat_samochodowy
{
    public class Mechanik:IMechanik
    {
        enum Nazwa
        {
            Zdzisiek,
            Heniek,
            Wladek
        }

        private Nazwa Imie { get; set; } 
        private string PrzydzieloneAuto { get; set; }
        private List<string> Auta;

        public Mechanik()
        {
            Auta = new List<string>();
        }

        public void ZmienImie()
        {
            Console.WriteLine("Imie mechanika");
            Console.WriteLine("1. Zdzisiek");
            Console.WriteLine("2. Heniek");
            Console.WriteLine("3. Wladek");
            var ktory = int.Parse(Console.ReadLine());

            switch (ktory)
            {
                case 1: Imie = Nazwa.Zdzisiek;
                    break;
                case 2:
                    Imie = Nazwa.Heniek;
                    break;
                case 3:
                    Imie = Nazwa.Wladek;
                    break;
                default: Console.WriteLine("Cos nie tak");
                    break;

            }

            Console.WriteLine("Ktore auta przypisac? Podaj rejestracje i potwierdz zerem");
            string nowe = Console.ReadLine();
            while (nowe != "0")
            {
                Auta.Add(nowe);
                nowe = Console.ReadLine();
            }

        }

        public void Wypisz(ListaAut DaneAuta)
        {
            Console.WriteLine(this.Imie);
            foreach (var pozycja in this.Auta)
            {
                DaneAuta.ZwrocPoRejestracji(pozycja);
            }




        }

    }
}
