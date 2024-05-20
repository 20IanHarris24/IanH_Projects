using System.Diagnostics;


internal class Program
{
    private static void Main(string[] args)
    {
        /*
        int x;
        int y;

        x = 7;
        y = x + 3;
        Console.WriteLine(y);
        Console.ReadLine();
        */


        Console.WriteLine("What's your name?");
        Console.Write("Please type your forename: ");
        string myForename = Console.ReadLine() ?? " ";  // the end format is needed due to CS8600 - Converting null literal or possible null value to non-nullable type.

        Console.Write("Please type your Surname: ");
        string mySurname = Console.ReadLine() ?? " ";

        Console.WriteLine("Hello " + myForename + " " + mySurname);
        Console.ReadLine();


    }

    
}