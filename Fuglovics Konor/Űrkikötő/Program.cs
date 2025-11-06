namespace Űrkikötő
{
	internal class Vehicle
	{
		public string LicensePlate
		{
			get;
			set;
		}
		public string Type
		{
			get;
			set;
		}
		public int ArrivesInDays
		{
			get;
			set;
		}
		public override string ToString()
		{
			return $"Rendszám: {LicensePlate}, Típus: {Type}, Érkezés (nap): {ArrivesInDays}";
		}
		public Vehicle(string licenseplate, string type, int arrive)
		{
			LicensePlate = licenseplate;
			Type = type;
			ArrivesInDays = arrive;
		}
	}
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allcars = [];
			HashSet<string> alltypes = [];
			Dictionary<string, int> allstats = [];
			string[] data = File.ReadAllLines("jarmuvek.csv");
			foreach (var file in data.Skip(1))
			{
				string[] line = file.Split(";");
				allcars.Add(new Vehicle(line[0], line[1], int.Parse(line[2])));
				alltypes.Add(line[1]);
			}
			int ambulamt = 0;
			int carrieramt = 0;
			int searchamt = 0;
			int casualamt = 0;
			List<int> amount = [];
			foreach(var amt in allcars)
			{
				if (amt.Type == "Mentő")
				{
					ambulamt++;
				}
				else if (amt.Type == "Személy")
				{
					casualamt++;
				}
				else if (amt.Type == "Kutató")
				{
					searchamt++;
				}
				else if (amt.Type == "Teher")
				{
					carrieramt++;
				}
			}
			amount.Add(ambulamt);
			amount.Add(searchamt);
			amount.Add(casualamt);
			amount.Add(carrieramt);
			int i = 0;
			foreach(var tip in alltypes)
			{ 
				allstats.Add(tip, amount[i]);
				i++;
			}
			//---------------------------------------
			void Days()
			{
				Dictionary<int, int> daycheck = [];
				int count = 1;
				foreach (var item in allcars)
				{
					int cars = 0;
					foreach (var day in allcars)
					{
						if (day.ArrivesInDays == count)
						{
							cars++;
						}
					}
					daycheck.Add(count, cars);
					count++;
					if(count == 31)
					{
						break;
					}
				}
				Console.WriteLine(string.Join("\n", daycheck));
			}
			void CarType()
			{
				Console.WriteLine(string.Join("\n", allstats));
			}
			void SortTypes()
			{
				//Ötletem sincs hogyan csináljam meg ezt...
				//Dictionary<int, List<Vehicle>> collection = [];
				//Console.WriteLine(string.Join("\n", collection));
			}
			Days();
			CarType();
			//SortTypes();
			//Console.WriteLine(string.Join("\n",allstats));
			Console.ReadKey();
        }
    }
}
