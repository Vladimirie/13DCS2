class program
{
    static void Main(string[] args)
    {
        List<string> orszagok = new List<string>();

        orszagok.Add("Magyarország");
        orszagok.Add("Nemetorszag");
        orszagok.Add("Franciaorszag");

        foreach (var item in orszagok)
        {
            System.Console.WriteLine(item)
        }
    }
}