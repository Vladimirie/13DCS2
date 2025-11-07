namespace Wurlde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> talalandoSzo = new List<string>()
            {
                "fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska", "farkas", "almafa", "babona", "gerinc", "dervis", "bagoly", "ecetes", "angyal", "boglya"
            };

            Random r = new Random();
            string megfejtes = talalandoSzo[r.Next(talalandoSzo.Count)];
            //Console.WriteLine(megfejtes);

            List<char> megjeftesBontott = new List<char>();
            foreach (char resz in megfejtes)
            {
                megjeftesBontott.Add(resz);
            }

            int talalatok = 0;     
            bool talalt = false;

            Console.WriteLine("Adjon meg egy hat betűs szót!");
            Console.WriteLine("______");
            while (!talalt && talalatok != 5)
            {
                int pontossag = 0;
                string guess = Console.ReadLine();

                if (guess.Length != 6)
                {
                    Console.Write("Kérem egy HAT betűs szót adjon meg!");
                }
                else
                {
                    for (int i = 0; i < guess.Length; i++)
                    {
                        if (!megjeftesBontott.Contains(guess[i])) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(guess[i]);
                        }
                        else if (guess[i] == megjeftesBontott[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(guess[i]);
                            pontossag++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(guess[i]);
                        }
                    }
                    if (pontossag == 6)
                    {
                        talalt = true;
                    }
                    else
                    {
                        talalatok++;
                    }
                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (talalt == true)
            {
                Console.WriteLine($"Gratulálunk! Eltaláltad a szót {talalatok} próbán belül!");
            }
            else
            {
                Console.WriteLine($"Sajnálom, nem találtad el ezt! A megfejtés: {megfejtes} volt.");
            }
        }
    }
}
