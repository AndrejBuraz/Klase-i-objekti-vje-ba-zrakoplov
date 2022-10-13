using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjektiVjezbaZrakoplov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine("Prvi zrakoplov: \n" + x380.Ispis() + "\n");
            Console.WriteLine("Drugi zrakoplov: \n" + C162.Ispis() + "\n");
            Console.WriteLine("Treći zrakoplov: \n" + PC_21.Ispis() + "\n");

            Console.ReadKey(); 
        }
    }

    class Zrakoplov
    {
        //svojstva
        string naziv;
        double snagaMotora;
        int dosegLeta;

        //seteri
        public void SetNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void SetSnagaMotora(double snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public void SetDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }

        //geteri
        public string GetNaziv()
        {
            return this.naziv;
        }
        public double GetSnagaMotora()
        {
            return this.snagaMotora;
        }
        public int GetDosegLeta()
        {
            return this.dosegLeta;
        }

        //konstruktori
        public Zrakoplov()
        {

        }
        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }

        //metod za ispis
        public string Ispis()
        {
            string ispis = ("Naziv: " + this.GetNaziv() + "\nSnaga motora: "+ this.GetSnagaMotora() + " kW\nDoseg leta: "+this.GetDosegLeta() + " km");
            return ispis;
        }

    }
}
