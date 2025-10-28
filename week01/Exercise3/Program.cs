using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        bool match = true;
        
       
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int count = 0; 
   


        do

        {

         

                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                int userGuess = int.Parse(guessNumber);
                if (userGuess < magicNumber)
                {
                    match = true;
                    Console.WriteLine("Higher");

                }
                else if (userGuess > magicNumber)
                {
                    match = true;
                    Console.WriteLine("Lower");
                }
                else
                {
                
                count++;
                Console.WriteLine("You guessed it! ");
                Console.WriteLine("Do you want to keep playing? yes/no");
                string response = Console.ReadLine();
                if (response == "no")
                {
                    match = false;
                    Console.WriteLine($"You have played {count} times");
                }
                else if (response == "yes")
                {
                    match = true;
                    magicNumber = randomGenerator.Next(1, 100);

                }


                }






            



            } while (match == true);
      
         

        
 
    }

}