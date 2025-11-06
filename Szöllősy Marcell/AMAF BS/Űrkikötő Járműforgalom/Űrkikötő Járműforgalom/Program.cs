using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Jarmu
{
    public string Azonosito { get; set; }
    public string Tipus { get; set; }
    public int ErkezesNap { get; set; }
    public Jarmu(string azonosito, string tipus, int erkezesNap)
    {
        Azonosito = azonosito;
        Tipus = tipus;
        ErkezesNap = erkezesNap;
    }
    public override string ToString()
    {
        return $"Azonosító: {Azonosito}, Típus: {Tipus}, Érkezés napja: {ErkezesNap}";
    }
}
public class Program
{
    public static void Main()
    {
        List<Jarmu> jarmuvek = new List<Jarmu>();
        HashSet<string> tipusok = new HashSet<string>();
        Dictionary<string, int> tipusStat = new Dictionary<string, int>();
        // --- CSV beolvasása ---
        string fajlNev = "jarmuvek.csv";
        if (!File.Exists(fajlNev))
        {
            Console.WriteLine($"❌ A fájl nem található: {fajlNev}");
            return;
        }
        string[] sorok = File.ReadAllLines(fajlNev);
        foreach (var sor in sorok.Skip(1))
        {
            if (string.IsNullOrWhiteSpace(sor))
                continue;

            string[] mezok = sor.Split(';');
            if (mezok.Length != 3)
                continue;

            string azonosito = mezok[0];
            string tipus = mezok[1];
            if (!int.TryParse(mezok[2], out int erkezesNap))
            {
                Console.WriteLine($"⚠️ Hibás érkezési nap: {mezok[2]} (sor: {sor})");
                continue;
            }

            Jarmu j = new Jarmu(azonosito, tipus, erkezesNap);
            jarmuvek.Add(j);

            tipusok.Add(tipus);

            if (tipusStat.ContainsKey(tipus))
                tipusStat[tipus]++;
            else
                tipusStat[tipus] = 1;
        }

        Console.WriteLine("✅ Fájl beolvasva.\n");

        // Kiíratás (ellenőrzésképp)
        Console.WriteLine("Összes jármű:");
        foreach (var j in jarmuvek)
            Console.WriteLine(j);

        Console.WriteLine("\nJárműtípusok:");
        foreach (var t in tipusok)
            Console.WriteLine(t);

        Console.WriteLine("\nTípusonként érkezett járművek száma:");
        foreach (var kvp in tipusStat)
            Console.WriteLine($"{kvp.Key}: {kvp.Value} db");

        Console.WriteLine("\n--- Statisztikák ---");
    }
}
    