using System;
using System.Collections.Generic;

namespace Warsztat_samochodowy
{
    public class ListaUslug
    {
        private List<Usluga> Uslugi;
        private int ObecneId { get; set; } = 1;

        


        public int ZwrocId()
        {
            return ObecneId;
        }

        public ListaUslug()
        {
            this.Uslugi = new List<Usluga>
            {
                new Usluga() {Nazwa = "Wymiana opon", Cena = 150, Czas = 4, Id = ObecneId++},
                new Usluga() {Nazwa = "Przeglad techniczny", Cena = 250, Czas = 2, Id = ObecneId++},
                new Usluga() {Nazwa = "Chip Tuning", Cena = 300, Czas = 36, Id = ObecneId++},
                new Usluga() {Nazwa = "Wymiana klockow hamulcowych", Cena = 100, Czas = 65, Id = ObecneId++}
            };
        }

        public void Wypisz()
        {
            foreach (var pozycja in Uslugi)
            {
                Console.WriteLine(pozycja.Id + ". " + pozycja.Nazwa);
                Console.WriteLine("Cena uslugi: " + pozycja.Cena + " PLN");
                Console.WriteLine("Czas potrzebny na realizacje: ");

                if (pozycja.Czas >= 24 && pozycja.Czas < 48)
                {
                    Console.WriteLine("1 dzien");
                }
                else if (pozycja.Czas > 48)
                {
                    Console.WriteLine(pozycja.Czas / 24 + " dni");
                }
                else
                {
                    Console.WriteLine(pozycja.Czas + " godziny");
                }

                Console.WriteLine("");

            }
        }

        public string PodajNazwe(int numer)
        {
            return Uslugi[numer - 1].Nazwa;
        }

        public int PodajCene(int numer)
        {
            return Uslugi[numer - 1].Cena;
        }

        public void DodajPozycje()
        {

            Usluga nowa = new Usluga();

            Console.WriteLine("Podaj nazwe uslugi");
            nowa.Nazwa = Console.ReadLine();

            Console.WriteLine("Podaj cene nowej uslugi");
            nowa.Cena = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj czas wykonania uslugi (w godzinach)");
            nowa.Czas = int.Parse(Console.ReadLine());

            nowa.Id = ObecneId++;

            Uslugi.Add(nowa);


        }

        

    }
}
