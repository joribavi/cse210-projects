using System;
using System.Net;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished ");

        bool keepOn = true;
        //   string response = Console.ReadLine();

        do
        {

            string response = Console.ReadLine();

            int num = int.Parse(response);
            if (num != 0)
            {

                numList.Add(num);
                keepOn = true;
            }

            else if (num == 0)
            {
                keepOn = false;
            }

    

        } while (keepOn);



        
        double amountOfNumbers = numList.Count();
        double sum = numList.Sum();
        double average = sum / amountOfNumbers;
        int biggestNum = numList.Max();

       
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest mumber is: {biggestNum}");  
       

    }
}