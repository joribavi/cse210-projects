using System;

class Program
{
    static void Main(string[] args)


    {
        Fraction myFraction = new Fraction();

         //trying formula with the default values
        string _stringFraction = myFraction.GetFractionString(); 
        double _fraction = myFraction.GetDecimalValue();  

        Console.WriteLine($"{_stringFraction}");
        Console.WriteLine($"{_fraction}");
        // trying different values with function setters , after that calling the functions to get result with new values
        myFraction.SetTop(5);
        _stringFraction = myFraction.GetFractionString();
        _fraction = myFraction.GetDecimalValue();
        Console.WriteLine($"{_stringFraction}");
        Console.WriteLine($"{_fraction}");
        myFraction.SetTop(3);
        myFraction.SetBottom(4);
        _stringFraction = myFraction.GetFractionString();
        _fraction = myFraction.GetDecimalValue();
        Console.WriteLine($"{_stringFraction}");
        Console.WriteLine($"{_fraction}");
           myFraction.SetTop(1);
        myFraction.SetBottom(3);
        _stringFraction = myFraction.GetFractionString();
        _fraction = myFraction.GetDecimalValue();
        Console.WriteLine($"{_stringFraction}");
        Console.WriteLine($"{_fraction}");





        
    }
}