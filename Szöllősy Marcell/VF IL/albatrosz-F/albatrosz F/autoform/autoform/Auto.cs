using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace autoform
{
    public class Auto
    {
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int Ar { get; set; }

        public static List<Auto> BetoltFajlbol(string fajlNev)
        {
            var lista = new List<Auto>();
            try
            {
                var sorok = File.ReadAllLines(fajlNev);
                foreach (var sor in sorok.Skip(1)) // Első sor: fejléc
                {
                    var mezok = sor.Split(';');
                    if (mezok.Length == 4)
                    {
                        lista.Add(new Auto
                        {
                            Marka = mezok[0],
                            Modell = mezok[1],
                            Evjarat = int.Parse(mezok[2]),
                            Ar = int.Parse(mezok[3])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hiba a fájl beolvasásakor: " + ex.Message);
            }
            return lista;
        }
    }
}
