using System;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] agrs)
        {
            Samochód samochód1 = new Samochód("BMW", "Czarny mat", 5000000, 2000);

            samochód1.zmienkolor("Czarny mat");
            samochód1.zmienpred(100);

            Osoba własciciel1 = new Osoba();
            samochód1.własciciel = własciciel1;
            samochód1.własciciel = new Osoba() { imię = "Adam", nazwisko = "Kowalski" };
        }
    }
    class Osoba
    {
        public string imię;
        public string nazwisko;

    }
    class Samochód
    {
        public string Marka;
        public string Kolor;
        public int Cena;
        public int Dataprodukcji;
        public int Prędkość;
        public Osoba własciciel;


        public Samochód(string mar, int cen)
        {
            this.Marka = mar;
            this.Cena = cen;

            Console.WriteLine($"Marka to {mar}");
            Console.WriteLine($"Cena to {cen}");
        }
        public Samochód(string mar, string kol, int cen, int dataprod)
        {
            this.Marka = mar;
            this.Kolor = kol;
            this.Cena = cen;

            this.Dataprodukcji = dataprod;

            Console.WriteLine($"Marka to {mar}");
            Console.WriteLine($"Kolor to {kol}");
            Console.WriteLine($"Cena to {cen}");
            Console.WriteLine($"Data produkcji to {dataprod}");
        }
        public void zmienkolor(string kol)
        {
            this.Kolor = kol;
            Console.WriteLine($"Teraz kolor auta to {kol}");
        }
        public void zmienpred(int pred)
        {
            this.Prędkość = this.Prędkość + pred;


            if (Prędkość < 0)
            {
                Console.WriteLine("Nie możesz jechać mniej niż zero km/h więc się zatrzymałeś");
                this.Prędkość = 0;
                Console.WriteLine("Prędkość to " + Prędkość + "km/h");
            }

            if (Prędkość > 350)
            {
                Console.WriteLine("jedziesz za szybko zwolnij!");
                Console.WriteLine("teraz jedziesz 350 km/h");
                this.Prędkość = 350;
            }

            if (Prędkość > 0 && Prędkość < 350)
                Console.WriteLine("Prędkość to " + Prędkość + "km/h");
        }
    }
}


