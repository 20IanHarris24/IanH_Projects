internal class Program
{
    private static void Main(string[] args)
    {

/* Ingrid is the founder of a company that sells bicycle parts. 
She used to set the prices of products quite arbitrarily, but now she has decided that it would be more profitable if the prices end in 99.

You are given a positive integer N, the price of a product. 
Your task is to find the nearest positive integer to N which ends in 99. 
If there are two such numbers that are equally close, find the bigger one.

INPUT

The input contains one integer N (1 <= N <= 10000), the price of a product.
It is guaranteed that the number N does not end in 99.

OUTPUT

Print one integer, the closest positive integer that ends in 99. 
In case of a tie, print the bigger one.
*/



        //Picking up the price to update

        Console.Write("Please enter price of the item be updated: ");
        int oldPrice = Convert.ToInt32(Console.ReadLine());
    
            
             int checkedPrice = InputCheck(oldPrice); 

             int newPrice = PriceChange(checkedPrice);
        
             Console.WriteLine("Price = " + checkedPrice + " is changed to = " + newPrice);
    
         
    }



        private static int InputCheck(int oldPrice){ // Checking if the price entered is valid i.e. not a 99 value or 0
            
            bool valid = false;
                    
            while (valid == false) {


                        if(oldPrice % 100 == 0 && oldPrice == 0){

                        Console.WriteLine("The price " + oldPrice + " entered is not valid.");
                        Console.WriteLine("Please re-enter the price of the item to be updated: ");
                        oldPrice = Convert.ToInt32(Console.ReadLine());

                        }

                        else if (oldPrice % 100 == 99){

                        Console.WriteLine("The price entered is already adjusted to x99 price.");
                        Console.WriteLine("Please re-enter the price of the item to be updated: ");
                        oldPrice = Convert.ToInt32(Console.ReadLine());
                        }
                        else {

                            valid = true;
                        }
           

            }
            

            return oldPrice;
        }


        private static int PriceChange(int oldPrice){
        
        int nearest100Multiple;
        int remainder = oldPrice % 100;
       
    
        if (remainder < 50 && oldPrice == 10000){

            nearest100Multiple = oldPrice - 100;

        }
        else {

            nearest100Multiple = oldPrice - remainder;

        }

        return nearest100Multiple + 99;
    }





}