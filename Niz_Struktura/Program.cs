using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niz_Struktura
{
    internal class Program
    {
        struct Ucenik
        {
           public string Ime;
            public double Prosek;
            public Ucenik(string ime, double prosek)
            {
                this.Ime = ime;
                this.Prosek = prosek;
            }

            public void PrikaziPodatke()
            {
                Console.WriteLine($"Ucenik: {Ime, - 15} Prosek: {Prosek:f2}");
            }

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj ucenika: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Ucenik[] odeljenje = new Ucenik[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n Unos za {i + 1}. ucenika:");
                Console.Write("Ime: ");
                string ime = Console.ReadLine();
                Console.Write("Prosek: ");
                double prosek = Convert.ToDouble(Console.ReadLine());
                odeljenje[i] = new Ucenik(ime, prosek);
            }
            Console.WriteLine("\n--- SPISAK UCENKIKA ---");
            foreach (Ucenik i in odeljenje)
            {
                i.PrikaziPodatke();
            }
           
        }
    }
}
