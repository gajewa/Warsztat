namespace Warsztat_samochodowy
{
    class Usluga
    {
        public string Nazwa { get; set; } //nazwa uslugi np wymiana opon
        public int Cena { get; set; } //cena uslugi w zl
        public int Id { get; set; } // id uslugi
        public int Czas { get; set; } //czas potrzebny na wykonanie ulugi w godzinach

        public void ZmienCene(int nowaCena)
        {
            this.Cena = nowaCena;
        }

        public void ZmienCzas(int nowyCzas)
        {
            this.Czas = nowyCzas;
        }
    }
}
