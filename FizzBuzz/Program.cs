
internal class Program
{/*
According to Wikipedia, FizzBuzz is a group word game for children to teach them about division. 
This may or may not be true, but this question is generally used to torture screen young computer science graduates during programming interviews.
Basically, this is how it works: 
you print the integers from 1 to N, replacing any of them divisible by X with Fizz 
or, if they are divisible by Y, with Buzz. 
If the number is divisible by both X and Y, you print FizzBuzz instead.

INPUT

Input contains a single test case. 
Each test case contains three integers on a single line, X ,Y and N(1 <= X < Y <= N <= 100).


OUTPUT

Print integers from 1 to N in order, each on its own line, 
replacing the
 - ones divisible by X with Fizz, 
 - ones divisible by Y with Buzz and
 - ones divisible by both X and Y with FizzBuzz.



*/
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to FizzBuzz");
        Console.WriteLine("You will be asked to enter 2 integer dividers and a number range no greater than 100");
        Console.WriteLine("NOTE: The 1st divider entered should not be greater than the 2nd and both dividers should not be greater than 100\n");
        Console.Write("Please enter the desired parameters: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            FizzBuzz(x,y,i);
        }

        Console.ReadLine();
        
    }

    private static int Toint32(string? v)
    {
        throw new NotImplementedException();
    }


    private static void FizzBuzz (int x, int y, int i){


            if (i % x == 0 && i % y == 0)
            {
                Console.WriteLine("FizzBuzz");
            } else if (i % x == 0){

                Console.WriteLine("Fizz");

            } else if (i % y == 0){

                Console.WriteLine("Buzz");
            } else {

                Console.WriteLine(i);
            }

    }




}