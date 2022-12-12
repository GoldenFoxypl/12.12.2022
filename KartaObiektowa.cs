using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Producent
    {
        private string nazwa;
        private string nip;

        public string getNazwa()
        {
            return nazwa;
        }
        public string getNip()
        {
            return nip;
        }
        public void setNazwa(string nazwa)
        {
            this.nazwa = nazwa;
        }
    }
    class Material
    {
        private string typ;
        private int id;
        private double cena;
        
        public void setTyp(string setTyp)
        {
            this.typ = setTyp;
        }
        public string getTyp()
        {
            return this.typ;
        }
        public double getCena()
        {
            return this.cena;
        }
        public void setId(int setId)
        {
            this.id = setId;
        }
    }
    class Rower
    {
        private string producent;
        private string kolor;
        private Material material;
        public void jedz()
        {

        }
        public void setColor(string kolor)
        {
            kolor = "czarny";
        }
        public void getColor(string kolor)
        {
            this.kolor = kolor;
        }
        public void setMaterial(Material amaterial)
        {
            this.material = amaterial;
        }
        public Rower(Producent producent, string kolor)
        {
            this.producent = producent.getNazwa();
            this.kolor = kolor;
        }
        public void showRower()
        {
            Console.WriteLine($"Ten rower zosta³ wyprodukowany przez {this.producent}, rower jest koloru {this.kolor} stworzony z {this.material.getTyp()}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Material a = new Material();
            a.setTyp("karbon");
            Producent a1 = new Producent();
            a1.setNazwa("TRAXXAS");
            Rower a2 = new Rower(a1, "czarny");
            a2.setMaterial(a);
            a2.showRower();
            Console.ReadKey();
        }
    }
}
