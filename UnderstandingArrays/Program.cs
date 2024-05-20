using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {


        /*
        
        int number1 = 4;
        int number2 = 8;
        int number3 = 15;
        int number4 = 16;
        int number5 = 23;

        if (number1 == 16){


        }
        else if (number2 == 16)
        {
            
        }
        else if (number3 == 16)
        {
            
        } */

        int [] numbers = new int [] {4, 8, 15, 16, 23, 42}; //simplified form
       
        /* for (int i =0; i < numbers.Length; i++){
            //Console.WriteLine(numbers[i]);
            if (numbers[i] == 16){

                Console.Write("Found Sixteen at array index: " + i + "." );
                break;

            }

        } 


            foreach (var number in numbers)
            {
                if (number == 16){

                 Console.Write("\nFound " + number + ".\n" );
                 break;
                }
            }


        Console.ReadLine(); */

            string zig = "You can get what you want out of life " + "if you help enough people get what they want.";
            char [] charArray = zig.ToCharArray();

            Array.Reverse(charArray);

            foreach (var zigChar in charArray)
            {
                Console.Write(zigChar);
            }

            /* for (int i = charArray.Length-1; i >=0 ; i--)
            {
                Console.Write(charArray[i]);
                //Console.WriteLine();
                //Console.Write(charArray[(charArray.Length) - 1]);
                
            }*/
            Console.ReadLine();
            




    }
}