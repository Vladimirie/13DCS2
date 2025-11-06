namespace Kiadás
{
	internal class Book
	{
		public int RelYear
		{
			get;
			set;
		}
		public int QYear
		{
			get;
			set;
		}
		public string Origin
		{
			get;
			set;
		}
		public string Desc
		{
			get;
			set;
		}
		public int Copies
		{
			get;
			set;
		}
		public Book(int relyear, int qyear, string origin, string desc, int copies)
		{
			RelYear = relyear;
			QYear = qyear;
			Origin = origin;
			Desc = desc;
			Copies = copies;
		}
		public override string ToString()
		{
			return $"Release year: {RelYear}, Quarter year: {QYear}, Origin: {Origin}, Description: {Desc}, Copies: {Copies}";
		}
	}
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> mem = [];
			foreach(var line in File.ReadAllLines("kiadas.txt"))
			{
				string[] scan = line.Split(";");
				mem.Add(new Book(int.Parse(scan[0]), int.Parse(scan[1]), scan[2], scan[3], int.Parse(scan[4])));
			}
			/*foreach(var book in mem)
			{
				Console.WriteLine(book);
			}*/
			Console.WriteLine("2.");
			Console.Write("Keresés: ");
			string auth = Console.ReadLine();
			if(auth != "")
			{
				int chance = 0;
				foreach(var book in mem)
				{
					if(book.Desc.Contains(auth))
					{
						chance++;
					}
				}
				if(chance>0)
				{
					Console.WriteLine($"{chance} copies were released.");
				}
				else
				{
					Console.WriteLine("Didn't.");
				}
			}
				Console.ReadKey();
        }
    }
}
