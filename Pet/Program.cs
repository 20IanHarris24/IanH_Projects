using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using static System.Formats.Asn1.AsnWriter;

internal class Program {

    /* In the popular show “Dinner for Five”, five contestants compete in preparing culinary delights. 
    Every evening one of them makes dinner and each of other four then grades it on a scale from 1 to 5. 
    The number of points a contestant gets is equal to the sum of grades they got. 
    The winner of the show is of course the contestant that gets the most points.

    Write a program that determines the winner and how many points they got.

    Input

    Five lines, each containing 4 integers, the grades a contestant got. 
    The contestants are numbered 1 to 5 in the order in which their grades were given.

    Output

    Output on a single line the winner’s number and their points, separated by a space. 
    The input data will guarantee that the solution is unique.


    NOTE. As the score card is generated randomly, the program written will not register if more than one contestant has the same score (a draw).
    It will print the first occurance where the high score is registered and the related contestant.


    */

    private static void Main(string[] args)
    {
        
             
            
            WhoWins(DoTheMaths(ScoreCard()));

            Console.ReadLine();


    }

        private static int[,] ScoreCard() {

         //Create a 2D array and initialize a contestant score card
        
            Random randomScore = new(); //Intialize random number method for contestant scores

            int [,] scores = new int [5,4]; // create a 2D Array

            Console.WriteLine(); //Line space

            for (int rows = 0; rows < scores.GetLength(0); rows++ ) { // populate the array with contestant scores

            for (int columns = 0; columns < scores.GetLength(1); columns++ ){

              scores[rows,columns] = randomScore.Next(1,5); //Create Random numbers in the range 1-5 
              Console.Write(scores[rows,columns]+ " ");
            }
            Console.WriteLine();  

        }
        Console.WriteLine();

        return scores;

        }


        private static int[,] DoTheMaths(int[,] scores) {

            int [,] totals = new int[5,2]; //Initialize a 2d-Array to store contestant totals and contestant index
        
            for (int rows = 0; rows < scores.GetLength(0); rows++ ) { 

                for (int columns = 0; columns < scores.GetLength(1); columns++ ){

                        totals[rows,1] += scores[rows,columns];                     // Calculate the totals
                              
                        }
            
            int index = rows + 1;       // contestant index
            totals[rows,0] = index;
            
            //Console.WriteLine(totals[rows,0] + " " + totals[rows,1]);  
            
            }

            return totals;


        }

        private static void WhoWins (int[,] totals){
            
            
            int winner = totals[0,1];               
            
            for (int rows = 1; rows <= (totals.GetLength(0)-1); rows++){        // Search totals array and find the highest score.

                if (winner < totals[rows,1]){

                    winner = totals[rows,1];
                    
                    
                } else {

                      continue;          

                }
                Console.WriteLine("The winner is contestant " + totals[rows,0] + " with " + winner + " points." );
            
            }



        }









}