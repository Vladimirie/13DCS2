using static AutóVerseny.Program;

namespace AutóVerseny
{
    internal class Program
    {
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
            List<Versenyzo> versenyAdat = new List<Versenyzo>();
            string[] file = File.ReadAllLines("autoverseny.csv");

            for (int i = 1; i < file.Length; i++)
            {
                string[] splitInfo = file[i].Split(";");
                versenyAdat.Add(new Versenyzo(splitInfo[0], splitInfo[1], int.Parse(splitInfo[2]), splitInfo[3], splitInfo[4], int.Parse(splitInfo[5])));
            }

            Console.Write("3. feladat:\t");
            Console.WriteLine(versenyAdat.Count);

            Console.Write("4. feladat:\t");
            Console.WriteLine(TimeCalc(versenyAdat[2]));

            Console.WriteLine("5. feladat");
            Console.Write("Kérem egy versenyző nevét: ");
            string givenRacerName = Console.ReadLine();

            Console.Write("6. feladat: ");
            Console.WriteLine(RacerBestTime(givenRacerName, versenyAdat));
        }

        static string TimeCalc(Versenyzo versenyzo)
        {
            double seconds = TimeSpan.Parse(versenyzo.Time).TotalSeconds;
            return $"{seconds} másodperc";
        }

        static string RacerBestTime(string givenRacer, List<Versenyzo> racers)
        {
            bool foundracer = false;
            List<Versenyzo> ourRacer = new List<Versenyzo>();
            foreach (Versenyzo racer in racers)
            {
                if (racer.RacerName == givenRacer) 
                { 
                    foundracer = true;
                    ourRacer.Add(racer);
                }
            }
            if (!foundracer)
            {
                return "Nincs ilyen versenyző az állományban!";
            }
            else
            {
                double seconds = TimeSpan.Parse(ourRacer[0].Time).TotalSeconds;
                string secondsString = ourRacer[0].Time;
                string track = ourRacer[0].Track;
                foreach (Versenyzo data in ourRacer)
                {
                    if (TimeSpan.Parse(data.Time).TotalSeconds < seconds)
                    {
                        seconds = TimeSpan.Parse(data.Time).TotalSeconds;
                        secondsString = data.Time;
                        track = data.Track;
                    }
                }

                return $" {track} {secondsString}";
            }
        }
    }
}
