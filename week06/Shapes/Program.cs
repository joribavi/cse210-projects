using System;

class Program
{
    static void Main(string[] args)
    {

        Square square1 = new Square("blue", 40);
        /* 
        Testing Code
        double square1Area = square1.GetArea();

        Console.WriteLine($"{square1Area}");

           */
        Circle circle1 = new Circle("brown", 30);

        Rectangle rectangle1 = new Rectangle(20, 30, "red");

        List<Shape> myList = new List<Shape>();

        myList.Add(square1);
        myList.Add(circle1);
        myList.Add(rectangle1);

        foreach (Shape shapeListItem in myList)
        {
            double area = shapeListItem.GetArea();
            Console.WriteLine($"The area of {shapeListItem} is {area}");   
        }

     


    }
}