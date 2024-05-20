internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Welcome to the Big C-sharp Giveaway");
        Console.Write("Choose a door number: 1 2 or 3 ");
        string door = Console.ReadLine() ?? " ";

        string message = "";

        if (door == "1" ){ message = "Congratulations you won a new boat!! ";
        }
       else if (door == "2"){ message = "Congratulations you won a new car!! ";
       }
       else if (door == "3"){ message = "Congratulations you won a fossil!! ";
       }
       else { message = "Sorry that was not a valid input. "; message += "You lose";
       }




        Console.WriteLine(message);
        Console.ReadLine();
        */

    Console.WriteLine("Welcome to the Big C-sharp Giveaway");
        Console.Write("Choose a door number: 1 2 or 3 ");
        string door = Console.ReadLine() ?? " ";

        string message = (door == "1") ? "boat" : "strand of lint";

        Console.WriteLine("You entered: {0}, therefore you win a {1}", door, message);

        Console.ReadLine();




    }

    //Console.Clear();

}