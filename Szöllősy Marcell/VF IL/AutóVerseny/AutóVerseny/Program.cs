using System;
using System.Collections.Generic;
using System.IO;

namespace AutóVerseny
{
    internal class Program
    {
        // Versenyző osztály adatok tárolásához
        public class Versenyzo
        {
            public string TeamName { get; set; }
            public string RacerName { get; set; }
            public int RacerAge { get; set; }
            public string Track { get; set; }
            public string Time { get; set; }
            public int Lap { get; set; }

            public Versenyzo(string teamName, string racerName, int racerAge, string track, string time, int lap)
            {
                TeamName = teamName;
                RacerName = racerName;
                RacerAge = racerAge;
                Track = track;
                Time = time;
                Lap = lap;
            }
        }

        static void Main(string[] args)
        {
            List<Versenyzo> versenyAdatok = new List<Versenyzo>();
            string[] sorok = File.ReadAllLines("autoverseny.csv");

            // Adatok beolvasása
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] mezok = sorok[i].Split(';');
                string team = mezok[0];
                string name = mezok[1];
                int age = int.Parse(mezok[2]);
                string track = mezok[3];
                string time = mezok[4];
                int lap = int.Parse(mezok[5]);

                Versenyzo v = new Versenyzo(team, name, age, track, time, lap);
                versenyAdatok.Add(v);
            }

            // 3. feladat
            Console.Write("3. feladat:\t");
            Console.WriteLine(versenyAdatok.Count);

            // 4. feladat
            Console.Write("4. feladat:\t");
            Console.WriteLine(IdoMasodpercben(versenyAdatok[2]));

            // 5. feladat
            Console.WriteLine("5. feladat");
            Console.Write("Kérem egy versenyző nevét: ");
            string keresettNev = Console.ReadLine();

            // 6. feladat
            Console.Write("6. feladat: ");
            Console.WriteLine(LegjobbKorido(keresettNev, versenyAdatok));
        }

        // 4. feladathoz - idő átváltása másodpercre
        static string IdoMasodpercben(Versenyzo versenyzo)
        {
            double masodperc = TimeSpan.Parse(versenyzo.Time).TotalSeconds;
            return $"{masodperc} másodperc";
        }

        // 6. feladathoz - adott versenyző legjobb körideje
        static string LegjobbKorido(string nev, List<Versenyzo> lista)
        {
            List<Versenyzo> adottVersenyzo = new List<Versenyzo>();
            
            foreach (var v in lista)
            {
                if (v.RacerName == nev)
                {
                    adottVersenyzo.Add(v);
                }
            }

            if (adottVersenyzo.Count == 0)
            {
                return "Nincs ilyen versenyző az állományban!";
            }

            Versenyzo legjobb = adottVersenyzo[0];
            double legjobbIdo = TimeSpan.Parse(legjobb.Time).TotalSeconds;

            foreach (var v in adottVersenyzo)
            {
                double ido = TimeSpan.Parse(v.Time).TotalSeconds;
                if (ido < legjobbIdo)
                {
                    legjobb = v;
                    legjobbIdo = ido;
                }
            }

            return $"{legjobb.Track} {legjobb.Time}";
        }
    }
}
