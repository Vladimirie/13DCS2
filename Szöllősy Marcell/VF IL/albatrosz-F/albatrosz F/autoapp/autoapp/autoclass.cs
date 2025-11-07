using System;

namespace autoapp
{
    class Auto
    {
        public int Sorszam { get; set; }
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int GyartasiEv { get; set; }
        public string Szin { get; set; }
        public int EladottDarabszam { get; set; }
        public int AtlagAr { get; set; }

        // 3. Feladat – konstruktor egy CSV sorból
        public Auto(string csvSor)
        {
            var mezok = csvSor.Split(';');
            Sorszam = int.Parse(mezok[0]);
            Marka = mezok[1];
            Modell = mezok[2];
            GyartasiEv = int.Parse(mezok[3]);
            Szin = mezok[4];
            EladottDarabszam = int.Parse(mezok[5]);
            AtlagAr = int.Parse(mezok[6]);
        }

        // 4. Feladat – fájl beolvasása és Auto objektumok létrehozása
        public static List<Auto> Beolvasas(string fajlNev)
        {
            var autok = new List<Auto>();
            var sorok = File.ReadAllLines(fajlNev);
            for (int i = 1; i < sorok.Length; i++) // első sor: fejléc
            {
                autok.Add(new Auto(sorok[i]));
            }
            return autok;
        }
    }
}
