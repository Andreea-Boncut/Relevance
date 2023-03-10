using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relevance_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ghiozdan ghiozdan = new Ghiozdan(5, 10f, 15f);

            while (true)
            {
                Console.WriteLine("1. Sageata");
                Console.WriteLine("2. Arc");
                Console.WriteLine("3. Franghie");
                Console.WriteLine("4. Apa");
                Console.WriteLine("5. Portie de mancare");
                Console.WriteLine("6. Sabie");
                Console.WriteLine("7. Afiseaza articole");
                Console.WriteLine("0. Iesire");

                Console.Write("Alege un articol: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        Sageata sageata = new Sageata();
                        AdaugaArticol(ghiozdan, sageata);
                        break;
                    case "2":
                        Arc arc = new Arc();
                        AdaugaArticol(ghiozdan, arc);
                        break;
                    case "3":
                        Franghie franghie = new Franghie();
                        AdaugaArticol(ghiozdan, franghie);
                        break;
                    case "4":
                        Apa apa = new Apa();
                        AdaugaArticol(ghiozdan, apa);
                        break;
                    case "5":
                        PortieMancare mancare = new PortieMancare();
                        AdaugaArticol(ghiozdan, mancare);
                        break;
                    case "6":
                        Sabie sabie = new Sabie();
                        AdaugaArticol(ghiozdan, sabie);
                        break;
                    case "7":
                        ghiozdan.AfiseazaArticole();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;
                }
            }
        }

        static void AdaugaArticol(Ghiozdan ghiozdan, ArticolInventar articol)
        {
            bool rezultat = ghiozdan.Adauga(articol);

            if (rezultat)
            {
                Console.WriteLine("Articol adaugat cu succes\n");
                Console.WriteLine($"Numarul total de articole: {ghiozdan.NumarArticole}\n");
                Console.WriteLine($"Greutatea totala: {ghiozdan.Greutate}\n");
                Console.WriteLine($"Volumul total: {ghiozdan.Volum}\n");
            }
            else
            {
                Console.WriteLine("Nu s-a putut adauga articolul\n");
            }
        }
    }
}
