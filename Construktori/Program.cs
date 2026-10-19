using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construktori
{
    internal class Program
    {
        // Deklaracija strukture
        struct Racionalan
        {
            public int Brojilac;
            public int Imenilac;

            //Konstruktor sa parametrima
            public Racionalan(int Brojilac, int Imenilac)
            {
                this.Brojilac = Brojilac;
                this.Imenilac = Imenilac;
            }
           // Metoda 
           public void Ispisi()
            {
                Console.WriteLine($"{Brojilac}/{Imenilac}");
            }
        }
        static void Main(string[] args)
        {
            Racionalan r1 = new Racionalan(); //Podrazumevani konstruktor postavlja polja na 0
            r1.Brojilac = 1;
            r1.Imenilac = 3;

            Console.WriteLine("Prikaz razlomaka:");

            Console.Write("r1 = "); 
            r1.Ispisi();

            Racionalan r2 = new Racionalan(1, 2); //konstruktor sa parametrima
            Console.Write("r2 = ");
            r2.Ispisi();

            Racionalan r3 = new Racionalan //Inicijalizator objekta 
            {
                Imenilac = 5
            };
            Console.Write("r3 = ");
            r3.Ispisi();

            Racionalan r4; //Rucna Inicijalizacija
            r4.Brojilac = 3;
            r4.Imenilac = 4;
            Console.Write("r4 = ");
            r4.Ispisi();
             //Rucna Inicijalizacija
            r4.Brojilac = 3;
            r4.Imenilac = 4;
            Console.Write("r4 = ");
            r4.Ispisi();
            Racionalan r5 = r1;
            Console.Write("Stari r5: ");
            r5.Ispisi();
            r5.Brojilac = 9;
            r5.Imenilac = 5;
            Console.Write("Novi r5: ");
            r5.Ispisi();

            
            

        }
    }
}
