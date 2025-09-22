namespace Name
{
    class Diak
    {
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }

        public Diak(string VezetekNev, string KeresztNev) 
        {
            this.VezetekNev = VezetekNev;
            this.KeresztNev = KeresztNev;
        }
        //ha hosszú a szöveg az Alt + Z jó cucc rá
        //függvény az ez csak van visszatérési érték azaz nem void hanem az amivel visszatér lol
        public void TeljesNev() //eljárás
        {
            string neve = VezetekNev + " " + KeresztNev;
            Console.WriteLine(neve);
        }

        public string TeljesNevReturn()
        {
            string neve = VezetekNev + " " + KeresztNev;
            return neve;
        }

        public override string ToString()
        {
            return $"A tanuló neve {VezetekNev} {KeresztNev}";
        }
    }

    class Kurzus {
        public string nev { get; set; }
        public int oraszam { get; set; }
        public string osztaly { get; set; }
        public string oktato { get; set; }

        public Kurzus(string nev, int oraszam, string osztaly, string oktato)
        {
            this.nev = nev;
            this.oraszam = oraszam;
            this.osztaly = osztaly;
            this.oktato = oktato;
        }

        public override string ToString()
        {
            return $"A kurzus az a {nev}, miből {oraszam} óra van. Tanárja az {oktato} és a {osztaly}-t tanítja.";
        }
    }

    class Program {

        struct Koordinata
        {
            public int x;
            public int y;

            public Koordinata(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"{x};{y}";
            }

            public void SetOrigo(int setX, int setY)
            {
                x = setX;
                y = setY;
            }
        }

        static void Main(string[] args)
        {
            Koordinata pont = new Koordinata();
            pont.SetOrigo(10, 2);
            Console.WriteLine(pont);
            pont.SetOrigo(0, 0);
            Console.WriteLine(pont);

            /*
            Diak v1 = new Diak("NewCity Gyatt Soldier", "Gébriel (from Bible(tm))");
            Kurzus AMAF = new Kurzus("AMAF", 4, "13X", "SHIGI"); //explicit
            var DBII = new Kurzus("DBII", 20, "13U", "Albert"); //implicit
             
            Console.WriteLine(v1);

            var b = false;
            var i = 10;
            var d = 10.20;
            var s = "szöveg";
            var c = 'c';
            var f = 10.12345f;
            //var t = new Array();

            Console.WriteLine(b.GetType());
            Console.WriteLine(i.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(s.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(f.GetType());
            //Console.WriteLine(t.GetType());

            char[] aznable = { 'a', 'l', 'm', 'a' };
            string john = new string(aznable);

            Console.WriteLine(john);

            foreach (var a in john)
            {
                Console.WriteLine(a);
            }*/

            Console.ReadLine();
        }
    }
}