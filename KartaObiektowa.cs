using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;
        public string getNazwa()
        {
            return this.nazwa;
        }
        public double getCena()
        {
            return this.cena;
        }
        public string getOpis()
        {
            return this.opis;
        }
        public void showProdukt()
        {
            Console.WriteLine($"To jest {this.nazwa} za {this.cena} jest ono {this.opis}");
        }
    }
    class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        public int getId()
        {
            return this.id;
        }
        public void operation()
        {
            Console.WriteLine("Udanych zakupów");
        }
        public Koszyk(int id, Produkt produkt)
        {
            this.id = id;
            this.produkt = produkt;
        }
        public void setUzytkownik(Uzytkownik uzytkownik)
        {
            this.uzytkownik = uzytkownik;
        }
    }
    class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil;
        public void loguj()
        {
            Console.WriteLine("Zalogowano");
        }
        public Uzytkownik(string login, string haslo, Profil profil)
        {
            this.login = login;
            this.haslo = haslo;
            this.profil = profil;
        }
    }
    class Profil
    {
        private string imie;
        private string drugieImie;
        private string nazwisko;
        public string getImie()
        {
            return this.imie;
        }
        public string getNazwisko()
        {
            return this.nazwisko;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt = new Produkt();
            produkt.getNazwa();
            produkt.getCena();
            produkt.getOpis();
            produkt.showProdukt();
            Koszyk koszyk = new Koszyk(1, produkt);
            koszyk.operation();
            koszyk.getId();
            Profil profil = new Profil();
            Uzytkownik user = new Uzytkownik("alamakota", "Alamakota123", profil);
            profil.getImie();
            profil.getNazwisko();
            user.loguj();
            Console.ReadKey();
        }
    }
}
