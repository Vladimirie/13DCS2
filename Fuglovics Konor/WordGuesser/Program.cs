namespace WordGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = ["fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska","farkas", "almafa", "babona", "gerinc", "dervis", "bagoly", "ecetes", "angyal", "boglya"];
			Random rnd = new Random();
			int num = rnd.Next(0,16);
			int pos = num;
			string identical = words[num];
			string user = Console.ReadLine();
			if(user.Length > 0)
			{
				if(user.Length > identical.Length)
				{
					while(user.Length > identical.Length)
					{
						user = user.
					}
				}
				while(user.Length < identical.Length)
				{
					user += " ";
				}
				for(int i = 0; i < identical.Length; i++)
				{
					if(user[i] == identical[i])
					{
						Console.Write(user[i]);
					}
					else
					{
						Console.Write(".");
					}
				}
			}
			else
			{
				Console.WriteLine("Nem írtál semmit!");
			}
			Console.ReadKey();
        }
    }
}
