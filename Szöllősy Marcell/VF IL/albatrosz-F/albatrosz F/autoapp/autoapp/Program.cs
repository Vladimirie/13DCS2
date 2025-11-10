using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace autoapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Feladat – fájl beolvasása
            var autok = Auto.Beolvasas("autok.csv");

            // 5. feladat
            Console.WriteLine("5. feladat");
            Console.WriteLine($"Az autók száma: {autok.Count}");

            // 6. feladat
            Console.WriteLine("6. feladat");
            double atlagEladas = autok.Average(a => a.EladottDarabszam);
            Console.WriteLine($"Átlagosan {atlagEladas:F1} darabot adtak el az autókból.");

            // 7. feladat – Elmúlt 5 év
            Console.WriteLine("7. feladat");
            int aktualisEv = DateTime.Now.Year;
            var ujAutok = autok.Where(a => a.GyartasiEv >= aktualisEv - 5);
            Console.WriteLine("Az elmúlt 5 évben gyártott autók:");
            foreach (var auto in ujAutok)
            {
                Console.WriteLine($"{auto.Marka} {auto.Modell} ({auto.GyartasiEv})");
            }

            // 8. feladat – Márkákhoz tartozó eladott darabszám
            Console.WriteLine("8. feladat");
            var markaStat = autok
                .GroupBy(a => a.Marka)
                .Select(g => new { Marka = g.Key, OsszesEladas = g.Sum(a => a.EladottDarabszam) });

            foreach (var stat in markaStat)
            {
                Console.WriteLine($"{stat.Marka}: {stat.OsszesEladas} db");
            }
        }
    }
}
