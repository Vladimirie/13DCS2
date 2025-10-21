using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Konyvkiadas
{


    class Kiadas
    {
        public int Ev { get; set; }
        public int Negyedev { get; set; }
        public string Eredet { get; set; }
        public  string Leiras { get; set; }
        public int Peldanyszam { get; set; }

        public Kiadas(int ev, int negyedev, string eredet, string leiras, int peldanyszam)
        {
            Ev = ev;
            Negyedev = negyedev;
            Eredet = eredet;
            Leiras = leiras;
            Peldanyszam = peldanyszam;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            string[] fileread = File.ReadAllLines("kiadas.txt");
            List<Kiadas> Kiadasok = new List<Kiadas>();

            foreach (string line in fileread) {


                string[] split = line.Split(';');

                Kiadasok.Add(new Kiadas(int.Parse(split[0]), int.Parse(split[1]), split[2], split[3], int.Parse(split[4])));


            }
            Console.WriteLine("Melyk szerzőre szeretne rá keresni?");
            string userInput = Console.ReadLine();
            int szerzoCount = 0;
            foreach (Kiadas kiadas in Kiadasok)
            {
                //     string leir = kiadas[Ev];

                if (kiadas.Leiras.Contains(userInput))
                {
                    szerzoCount++;
                }

            }
            if (szerzoCount > 0) {
                Console.WriteLine($"{szerzoCount} alkalomal adtak ki ettől a szerzőtöl");
            } else
            {
                Console.WriteLine("Nem adtak ki");
            }

            int maxkiadas = Kiadasok[0].Peldanyszam;

            foreach (Kiadas kiadas1 in Kiadasok) {

                if (maxkiadas < kiadas1.Peldanyszam) {

                    maxkiadas = kiadas1.Peldanyszam;
                }


            }
            int maxcount = 0;
            foreach (Kiadas kiadas2 in Kiadasok) {
                if (maxkiadas == kiadas2.Peldanyszam)
                {
                    maxcount++;
                }

            }

            Console.WriteLine($"A legnagyobb példányszám:{maxkiadas} ammi {maxcount} szer fordult elő.");


            int kulfindex = 0;
            bool found = false;
            while (!found && kulfindex < Kiadasok.Count())
            {
                if (Kiadasok[kulfindex].Eredet == "kf" && Kiadasok[kulfindex].Peldanyszam >= 40000) {

                    found = true;
                    Console.WriteLine($"{Kiadasok[kulfindex].Ev}/{Kiadasok[kulfindex].Negyedev}. {Kiadasok[kulfindex].Leiras}");
                }
                kulfindex++;
            }
            Console.WriteLine("Év \tMagyar kiadás\t  Magyar példányszám\t Külföldi kiadás\t Külföldi példányszám");




            Console.ReadLine();
    

    }

        public static void AdatkiIras(int evszam, List<Kiadas> Kiadasoklist)
        {


            int magyarkiadas = 0;
            int magyarpeldanyszam = 0;
            int kulfoldikiadas = 0;
            int kulfoldipeldanyszam = 0;

            foreach (Kiadas kiadas in Kiadasoklist)
            {
                if(kiadas.Ev == evszam)
                {
                    if (kiadas.Eredet == "ma")
                    {

                    } else
                    {

                    }

                }
            }
        }


    }

    }

