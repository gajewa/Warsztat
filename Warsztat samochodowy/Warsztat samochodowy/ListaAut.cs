using System;
using System.Collections.Generic;

namespace Warsztat_samochodowy
{
    public class ListaAut
    {
        private readonly List<Pojazd> Auta;
        private int ObecneId { get; set; } = 1;

        public ListaAut()
        {
            this.Auta = new List<Pojazd>
            {
                new Osobowe()
                {
                    Marka = "Ford",
                    Model = "Focus",
                    Benzyna = false,
                    IloscMiejsc = 5,
                    Nadwozie = "Kombi 5d",         
                    Rejestracja = "GA 63920",
                    Id = ObecneId++
                    
                },
                new Osobowe()
                {
                    Marka = "Toyota",
                    Model = "Avensis",
                    Benzyna = true,
                    IloscMiejsc = 5,
                    Nadwozie = "Sedan 5d",
                    Rejestracja = "GA 7380R",
                    Id = ObecneId++
                },
                new Osobowe()
                {
                    Marka = "Opel",
                    Model = "Astra",
                    Benzyna = true,
                    IloscMiejsc = 5,
                    Nadwozie = "Hatchback 5d",
                    Rejestracja = "GD 87726",
                    Id = ObecneId++
                }
            };


            Auta[0].UslugiNaAucie.Add(1);
            Auta[0].UslugiNaAucie.Add(2);
            Auta[0].CzyOsobowe = true;

            Auta[1].UslugiNaAucie.Add(3);
            Auta[1].CzyOsobowe = true;

            Auta[2].UslugiNaAucie.Add(2);
            Auta[2].CzyOsobowe = true;
        }

        public void Wypisz(ListaUslug lista)
        {
            foreach (var pozycja in Auta)
            {
                pozycja.Wypisz(lista);


            }
        }

        public void ZredukujID()
        {
            int licznik = 0;

            foreach (var pozycja in Auta)
            {
                pozycja.Id = ++licznik;
            }

            ObecneId--;
        }

        public void OddajAuto(int indeks)
        {
            Auta.RemoveAt(indeks - 1);
        }

        public void Wprowadz(ListaUslug uslugi)
        {
            Console.WriteLine("Jakie auto chcesz dodac, osobowe czy ciezarowe? [O/C]");
            string rodzajAuta = Console.ReadLine();

            //this.Auta.


            if (rodzajAuta == "O")
            {
                Osobowe nowe = new Osobowe();
                int usluga = 0;
                nowe.CzyOsobowe = true;

                Console.WriteLine("Podaj marke");
                nowe.Marka = Console.ReadLine();

                Console.WriteLine("Podaj model");
                nowe.Model = Console.ReadLine();

                Console.WriteLine("Podaj rodzaj nadwozia");
                nowe.Nadwozie = Console.ReadLine();

                Console.WriteLine("Podaj ilosc miejsc w aucie");
                nowe.IloscMiejsc = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj rejestracje aua:");
                nowe.Rejestracja = Console.ReadLine();

                Console.WriteLine("Podaj ktore z operacji beda wykonywane na aucie: (wpisywanie zakoncz zerem)");
                uslugi.Wypisz();
                do
                {
                    usluga = int.Parse(Console.ReadLine());
                    if (usluga > uslugi.ZwrocId())
                    {
                        Console.WriteLine("Zly numer uslugi");
                    }
                    else
                    {
                        if (usluga != 0)
                            nowe.UslugiNaAucie.Add(usluga);
                    }
                } while (usluga != 0);

                nowe.Id = ObecneId++;

                this.Auta.Add(nowe);

            }
            else
            {
                Ciezarowe nowe = new Ciezarowe();
                int usluga = 0;
                nowe.CzyOsobowe = false;

                Console.WriteLine("Podaj marke");
                nowe.Marka = Console.ReadLine();

                Console.WriteLine("Podaj model");
                nowe.Model = Console.ReadLine();

                Console.WriteLine("Podaj rejestracje aua:");
                nowe.Rejestracja = Console.ReadLine();

                Console.WriteLine("Podaj ktore z operacji beda wykonywane na aucie: (wpisywanie zakoncz zerem)");
                uslugi.Wypisz();
                do
                {
                    usluga = int.Parse(Console.ReadLine());
                    if (usluga > uslugi.ZwrocId())
                    {
                        Console.WriteLine("Zly numer uslugi");
                    }
                    else
                    {
                        if (usluga != 0)
                            nowe.UslugiNaAucie.Add(usluga);
                    }
                } while (usluga != 0);

                nowe.Id = ObecneId++;

                this.Auta.Add(nowe);
            }
        }


        public void Szukaj_po_rejestracji(ListaUslug uslugi)
        {
            Console.WriteLine("Podaj rejestracje");
            string rejestracja = Console.ReadLine();
            foreach (var pozycja in this.Auta)
            {
                if (pozycja.Rejestracja == rejestracja)
                {
                    pozycja.Wypisz(uslugi);
                }
            }

            Console.ReadKey();
        }

        public void WypiszCiezarowe(ListaUslug uslugi)
        {
            foreach (var pozycja in Auta)
            {
                if (!pozycja.CzyOsobowe)
                    pozycja.Wypisz(uslugi);

            }
        }

        public void WypiszOsobowe(ListaUslug uslugi)
        {
            foreach (var pozycja in Auta)
            {
                if (pozycja.CzyOsobowe)
                    pozycja.Wypisz(uslugi);

            }
        }

        public void ZwrocPoRejestracji(string rejestracja)
        {
            foreach (var pozycja in Auta)
            {
                if(pozycja.Rejestracja == rejestracja)
                    pozycja.Wypisz();
            } 
        }

    }
}
