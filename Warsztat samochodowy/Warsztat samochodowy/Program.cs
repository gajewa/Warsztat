using System;
using System.Collections.Generic;

namespace Warsztat_samochodowy
{
    class Program
    {
        static void Main()
        {
            ListaUslug WykonywaneUslugi = new ListaUslug();
            ListaAut AutaNaMiejscu = new ListaAut();
            List <Mechanik> Mechanicy = new List<Mechanik>();
            int option = 0;

            do
            {
                Console.Clear();

                WypiszMenu();

                Console.WriteLine("Co chcesz zrobic?");

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Musisz podac jakas liczbe");
                    Console.ReadKey();
                    continue;
                }

                switch (option)
                {
                    case 1:
                        AutaNaMiejscu.Wypisz(WykonywaneUslugi);
                        Console.ReadKey();
                        break;
                    case 2:
                        AutaNaMiejscu.Wprowadz(WykonywaneUslugi);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Podaj indeks auta do oddania");
                        int doOddania = int.Parse(Console.ReadLine());
                        AutaNaMiejscu.OddajAuto(doOddania);
                        AutaNaMiejscu.ZredukujID();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Hello");
                        break;
                    case 5:
                        WykonywaneUslugi.Wypisz();
                        Console.ReadKey();
                        break;
                    case 6:
                        WykonywaneUslugi.DodajPozycje();
                        break;
                    case 7:
                        AutaNaMiejscu.Szukaj_po_rejestracji(WykonywaneUslugi);
                        break;
                    case 8:
                        Console.WriteLine("Dziekujemy za prace z programem Mechanic Database");
                        Console.ReadKey();
                        break;
                    case 9: 
                        AutaNaMiejscu.WypiszCiezarowe(WykonywaneUslugi);
                        Console.ReadKey();
                        break;
                    case 10:
                        AutaNaMiejscu.WypiszOsobowe(WykonywaneUslugi);
                        Console.ReadKey();
                        break;
                    case 11:
                        Mechanik nowyMechanik = new Mechanik();
                        nowyMechanik.ZmienImie();
                        nowyMechanik.Wypisz(AutaNaMiejscu);
                        Mechanicy.Add(nowyMechanik);
                        Console.ReadKey();
                        break;
                    case 12:
                        foreach (var czlowiek in Mechanicy)
                        {
                            czlowiek.Wypisz(AutaNaMiejscu);
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Zla opcja!");
                        Console.ReadKey();
                        break;
                }
            } while (option != 8);


        }

        public static void WypiszMenu()
        {
            Console.WriteLine("***     ***     ***     ***     ***     ***     ***");
            Console.WriteLine("");
            Console.WriteLine("  System zarzadzania warsztatem samochodowym");
            Console.WriteLine("  Wybierz opcje");
            Console.WriteLine("  1. Pokaz auta w warsztacie");
            Console.WriteLine("  2. Wprowadz auto do warsztatu");
            Console.WriteLine("  3. Oddaj auto wlascicielowi");
            Console.WriteLine("  4. Zmodyfikuj prace przy aucie");
            Console.WriteLine("  5. Pokaz wykonywane uslugi");
            Console.WriteLine("  6. Dodaj usluge wykonywana");
            Console.WriteLine("  7. Szukaj auta po rejestracji");
            Console.WriteLine("  8. Wyjdz z programu");
            Console.WriteLine("  9. Wypisz auta ciezarowe");
            Console.WriteLine("  10. Wypisz auta osobowe");
            Console.WriteLine("  11. Dodaj mechanika?");
            Console.WriteLine("  12. Wypisz mechanikow");
            Console.WriteLine("");
            Console.WriteLine("***     ***     ***     ***     ***     ***     ***");

        }
    }
}
