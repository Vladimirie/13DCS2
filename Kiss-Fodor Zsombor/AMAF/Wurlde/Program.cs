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
            Console.WriteLine(megfejtes);

            List<char> megjeftesBontott = new List<char>();
            foreach (char resz in megfejtes)
            {
                megjeftesBontott.Add(resz);
            }

            int talalatok = 0;
            int pontossag = 0;
            bool talalt = false;

            Console.WriteLine("Adjon meg egy hat betűs szót!");
            Console.WriteLine("______");
            while (!talalt && talalatok != 5)
            {
                string guessDisplay = "";
                string guess = Console.ReadLine();
                if (guess.Length != 6)
                {
                    Console.WriteLine("Kérem egy HAT betűs szót adjon meg!");
                }
                else
                {
                    for (int i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == megjeftesBontott[i])
                        {
                            guessDisplay += guess[i];
                            pontossag++;
                        }
                        else
                        {
                            guessDisplay += "_";
                        }
                    }
                }

                Console.WriteLine(guessDisplay);
            }
        }
    }
}
