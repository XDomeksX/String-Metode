using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo s klasom string";

            //broj znakova (.Length)
            Console.WriteLine("Broj znakova u recenici je: " + recenica.Length);

            //ispis s malim slovima (.ToLower)
            Console.WriteLine(recenica.ToLower());

            //ispis s velikim slovima (.ToUpper)
            Console.WriteLine(recenica.ToUpper());

            //Metoda SubString
            Console.WriteLine(recenica.Substring(6));
            Console.WriteLine(recenica.Substring(0,5));

            //Metoda Replace
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            //Metoda Split
            Console.WriteLine("Metoda Split: ");
            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            //Metode IndexOf i Insert
            Console.WriteLine("Metode InsertOf i Insert: ");
            int pozicija = recenica.IndexOf("radimo");
            if (pozicija >= 0)
            {
                Console.WriteLine(recenica.Insert(pozicija, "intenzivno "));
            }


            Console.ReadKey();
        }
    }
}
