using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.XPath;

internal class Program
{       

    /*


    STATUS: WORK IN PROGRESS

    You’ve intercepted encrypted communications between Martian diplomats. 
    Since Martian diplomats are often spies, you decide to decrypt the messages. 
    While the Martians have skilled rocket tech, they lag behind in number theory considerably, which compromises their encryption protocol.

    Fortunately for you, spies friendly to you have reverse engineered the Martian protocol. 
    It turns out that the Martians are using a shift-based cipher combined with a very long one-time pad. 
    More specifically, the decryption procedure works as follows:


    Step 1: Define the function F(x) = (33x + 1) mod 2^20.

    Further define F^1(x) = F(x), F^2(x) = F(F(x)), F^3(x) = F(F(F(x))) , and so on.

    Step 2: Create a X by X size grid, fill the upper left corner with F^1(0), the next cell to the right with F^2(0), F^3(0)etc. 
    Once the top row is filled, continue to the cell below the upper left cell, and fill with F^x+1(0). Continue this process until all rows are filled.

    Step 3: Sum all the values in every column, and take those values mod 2^20 .

    Step 4: Concatenate the base-10 representations of the column sums together, to get a very long base-10 number. 
    For instance, if you had column sums of 10 and 12 for the first and second column, the leftmost four digits of the resulting value would be 1012.

    Step 5: Convert the result of step 4 from base 10  to base 27. This will yield the one-time pad the Martians used.

    Step 6: For each letter l of the intercepted message, shift the letter by the amount given by the corresponding digit of step 5, base 27. 
    “Shifting” means to add the digit at the corresponding position of the pad to the value of the letter in the encrypted message and then to compute its remainder modulo 27.
    You may assume that both the encrypted and the decrypted message consist of only uppercase English characters ‘A’ through ‘Z’ and spaces, which are assigned values  (A = 0, B = 1, ... Z = 25, SPACE = 26).
    Thus, if the encrypted message has letter ‘D’ in position 3, and the 3rd base-27 digit of the pad is 25, then the decrypted letter after shifting would be 3 + 25 = 1 mod 27 which is ‘B’.

    Step 7: Output the decrypted message.

    INPUT

    The first line of the input contains two positive integers, N (1 <= N <= 10^6), and X (1 <= N <= 2.5 x 10^6). 
    It is guaranteed that the base 27 result of step 5 will be longer or equal to the length of the intercepted message.
    The second line of the input contains a string consisting of uppercase letters and spaces of length N, the encrypted text.

    OUTPUT

    Output the decrypted text.

*/






    private static void Main(string[] args)
    {
         


        int size = 4;
        string N = "JQ IRKEYFG EXQ";
        //string N = "BLNAMOTPRRNIXRNMPIWHXDZTRQJXRKIAIEEIIPJLGZ";
        //string filename =
        
        


        

        int[,] table = GridandBuild(size);
        int[] tableSums = CalculateColumns(table,size);
        ConvertB27andDecrypt(string.Concat(tableSums),N);

        
                

            
            

        




        Console.ReadLine();
             
             
    }




    
    
    
    
    
    
    
    
    
    
    
    private static int [,] GridandBuild(int size){

                int [,] table = new int [size , size];
                int t = 0;
        
        
                        while (t != table.Length){
                            for (int i = 0; i < size; i++){
                                for (int j = 0; j < size; j++){

                                    table [i, j] = Fn(F(0),t);
                                    //Console.Write(table[i,j] + " ");
                                    t++;

                                 }
                            //Console.Write("\n");
                            }
                        }

                return table;

    }





    private static int F(int x){
    

                double fx = (33 * x + 1) % Math.Pow(2,20);
                 
                return (int)fx;

        } 


    private static int Fn(int x, int n){

                if (n == 0)
                {
                    return x;
                }
                else
                { 
                   return F(Fn(x, n - 1));
                }
            }

    private static int[] CalculateColumns(int[,] table, int size){

                int [] columnTotals = new int [size];

                for (int i = 0; i < size; i++){
                    for (int j = 0; j < size; j++){
                        columnTotals[i] += table[j,i];
                        double mod = columnTotals[i] % Math.Pow(2,20);
                        columnTotals[i] = (int) mod;

                    } 
                    
                    //Console.Write(columnTotals[i] + " ");

                } 
                return columnTotals;
            } 

    private static void ConvertB27andDecrypt(string concatTablesums, string N){

                //create the one-time pad in numbers
                var base27Array = new List<int>();
                
                Int128 base10 = Int128.Parse(concatTablesums);
      

           
                    while ((base10 / 27) > 0){

                        Int128 result = base10 / 27;
                        Int128 resultMod = base10 % 27;

                        base27Array.Add((int)resultMod);
                        base10 = result;

                    } 
                
                        if ((base10 / 27) == 0) {
                            Int128 result = base10 / 27;
                            Int128 resultMod = base10 % 27;

                            base27Array.Add((int)resultMod);

                    }

                    base27Array.Reverse();
           
                    
        
            
                    char[] message = N.ToCharArray();
                    char[] charset = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',' '};
                    var decryptedMessage = new List<char>();
                    
                    //Start decrypting 


                    for (int i = 0; i < message.Length; i++){
                        for (int j = 0; j < charset.Length; j++){
                                if (message[i] == charset[j]){ // Comparing the message symbol with the base character set
                                    int newIndex = (base27Array[i] + j)%27; //Perform decryption 'shift'
                                    decryptedMessage.Add(charset[newIndex]); //add new symbol to array for printing

                                }




                        }


                    }
            
     
            
                    decryptedMessage.ForEach(Console.Write);
                    
        


                
            }

        
    } 









    
























