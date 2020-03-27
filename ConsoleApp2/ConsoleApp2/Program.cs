using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Farmacie
    {
        public int medID;
        public string medNume;
        public int medPret;
        public int medNr;
        public int x;
    }


    class Program
    {
        static List<Farmacie> medList = new List<Farmacie>();
        static Farmacie m = new Farmacie();

        static void Main(string[] args)
        {

            bool close = true;
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
                "1)Adauga medicament\n" +
                "2)Sterge medicament\n" +
                "3)Cauta medicament\n" +
                "4)Afisare medicamente\n"+
                "5)Exit\n\n");
                Console.Write("Alegeti optiunea:");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AdaugareMed();
                }
                else if (option == 2)
                {
                   StergereMed();
                }
                else if (option == 3)
                {
                   CautareMed();
                }
                else if (option ==4)
                {
                    AfisareMed();
                }
                else if (option == 5)
                {
                    Console.WriteLine("Exit");
                    close = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Optiunea invalida!");
                }
            }


        }

 
        public static void AdaugareMed()
        {
            Farmacie m = new Farmacie();
            Console.WriteLine("Medicament Id:{0}", m.medID = medList.Count + 1);
            Console.Write("Numele medicamentului:");
            m.medNume = Console.ReadLine();
            Console.Write("Pretul:");
            m.medPret = int.Parse(Console.ReadLine());
            Console.Write("Numarul:");
            m.x = m.medNr = int.Parse(Console.ReadLine());
            medList.Add(m);
        }

 
        public static void StergereMed()
        {
            Farmacie m = new Farmacie();
            Console.Write("Introduceti ID-ul medicamentului ce doriti sa il stergeti: ");

            int Del = int.Parse(Console.ReadLine());

            if (medList.Exists(x => x.medID == Del))
            {
                medList.RemoveAt(Del - 1);
                Console.WriteLine("Medicament ID - {0} a fost sters", Del);
            }
            else
            {
                Console.WriteLine("ID invalid");
            }

            medList.Add(m);
        }


        public static void CautareMed()
        {
            Farmacie m = new Farmacie();
            Console.Write("Cautati prin ID:");
            int find = int.Parse(Console.ReadLine());

            if (medList.Exists(x => x.medID == find))
            {
                foreach (Farmacie searchId in medList)
                {
                    if (searchId.medID == find)
                    {
                        Console.WriteLine("Medicament ID :{0}\n" +
                        "Medicamentul :{1}\n" +
                        "Pretul :{2}\n" +
                        "Numarul :{3}", searchId.medID, searchId.medNume, searchId.medPret, searchId.medNr);
                    }
                }
            }
            else
            {
                Console.WriteLine("Medicamentul ID {0} nu a fost gasit", find);
            }
        }
        public static void AfisareMed()
        {
            Farmacie m = new Farmacie();
            foreach (Farmacie searchId in medList)
            {
               
                    Console.WriteLine("Medicament ID :{0}\n" +
                    "Medicamentul :{1}\n" +
                    "Pretul :{2}\n" +
                    "Numarul :{3}", searchId.medID, searchId.medNume, searchId.medPret, searchId.medNr);
                
            }
        }
    }
}

