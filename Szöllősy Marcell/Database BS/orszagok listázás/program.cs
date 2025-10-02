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
            System.Console.WriteLine(item);
        }



































        System.Console.WriteLine("\n-------------------\n A verem elemei");
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        System.Console.WriteLine(string.Join(",", myStack));

        System.Console.WriteLine("A kivett elem: " + myStack.Pop());
        Console.WriteLine(string.Join(",", myStack));
    }
}