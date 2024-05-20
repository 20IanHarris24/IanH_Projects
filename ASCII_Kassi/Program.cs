internal class Program
{
    private static void Main(string[] args)
    {
        
    /* Today the High School Programming Contest of Iceland is hosted on Kattis, which reviews the solutions from contestants upon their submission. 
    Most of the process has been automated, but it wasn’t always this way. Some years ago, judges walked from contestant to contestant, to check whether the outputs from each team were correct.
    This was done by asking contestants to put a piece of paper on their monitor so the judges could see the contestant thought they had solved a task. 
    The judge then asked the contestant to start up the program and enter a specific input which the judge had carefully selected and then the judge verified the correctness.

    The head judge in these days, Algrímur, requires your assistance with judging a particular task. 
    Algrímur usually writes his own solutions for the tasks and then prints on a paper a few outputs for specific inputs. 
    But Algrímur has been too busy to write his own solution.

    The task at hand involves drawing a square in the output, using only the symbols |, -, + and spaces.
    The left and right sides of the square should be drawn using the symbol |, while the top and bottom sides of the should be drawn using the symbol -. 
    Corners should be drawn using the symbol + and the interior of the square should be made up of spaces.

    Can you write a solution for Algrímur so he can print the output on paper?

    INPUT

    The first and only line in the input contains a single integer N , representing the interior sidelength of the square.

    OUTPUT

    Output a square of size N x N. Note that the number of spaces in the output must be exactly correct. 
    If there are any spaces outside the square then your solution will be considered incorrect. */
        
        
        Console.Write("Please enter and integer value (between 0 & 1000) for the size of square :");
        double side = Convert.ToDouble(Console.ReadLine());

        
        int sideCount = CalculateSides(side);
        char[,] square = PrepareSquareArray(sideCount);
        FixTheForm(square);
        PrintSquare(square,sideCount);

        Console.ReadLine();
        
 }





    private static int CalculateSides(double side){

        double sqrInput = Math.Pow(side + 2,2);
        double calSqrSize = Math.Sqrt(sqrInput);
        int sideCount = (int)calSqrSize;

        return sideCount;

    }


    private static char[,] PrepareSquareArray(int sideCount){

           char [,] square = new char[sideCount, sideCount]; //Create 2d Array for square printing
            for (int i = 0; i < square.GetLength(0); i++){ // Fill square array with crosses
             for (int j = 0; j < sideCount; j++){

                square[i, j] = '+';

                //Console.Write(square[i,j]);
                }

            }

        return square;

    }





    private static char[,] FixTheForm(char[,] square){

        // replacing the '+'s from top & bottom sides
        
        for (int outer = square.GetLowerBound(0); outer <= square.GetUpperBound(0); outer++){

            for (int inner = square.GetLowerBound(1)+1; inner <= square.GetUpperBound(1)-1; inner++){
                 
                 square[outer, inner] = '-';
                 //Console.Write(square[outer, inner]);
            
            }

           }
        
   
        // replacing the '+'s from left & right sides
        
        for (int outer = square.GetLowerBound(0)+1; outer <= square.GetUpperBound(0)-1; outer++){

            for (int inner = square.GetLowerBound(1); inner <= square.GetUpperBound(1); inner++){
                 
                 square[outer, inner] = '|';
                 //Console.Write(square[outer, inner]);
            
            }

           }


           // replacing the '+'s from middle of the square
        
        for (int outer = square.GetLowerBound(0)+1; outer <= square.GetUpperBound(0)-1; outer++){

            for (int inner = square.GetLowerBound(1)+1; inner <= square.GetUpperBound(1)-1; inner++){
                 
                 square[outer, inner] = ' ';
                 //Console.Write(square[outer, inner]);
            
            }

           }

            return square;
    }


    private static void PrintSquare(char[,] square, int sideCount){
        
         for (int i = 0; i < square.GetLength(0); i++){ // Make a full square with crossess
            for (int j = 0; j < sideCount; j++){

                Console.Write(square[i,j]);
            }

                Console.WriteLine();


        }




    }





        
        
}
