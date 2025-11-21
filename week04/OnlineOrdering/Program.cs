using System;

class Program
{
    static void Main(string[] args)

    {
         //CREATING ADDRESSESS (AFTER THAT ASSOCIATING THEM TO THE CUSTOMERS)   
        Address addressClient1 = new("Miami st 500", "Miami", "Florida", "United States");
        Address addressClient2 = new("Brown st 55", "Washingtong DC", "Columbia", "USA");
        Address addressClient3 = new("San Julian st 1204", "Cancun", "Yucatán", "Mexico");


        //CREATING CUSTOMERS TO GET THE SHIPPING LABEL INFORMATION

        Customer customer1 = new("John Doe", addressClient1);
        Customer customer2 = new("Julia Doe", addressClient2);
        Customer customer3 = new("Juan Ramirez", addressClient3);
        


        //PROGRAM CREATES PRODUCTS 
        Product product1 = new("Soap", "AH34566", 30, 5);
        Product product2 = new("Shampoo", "AH34500", 10, 3);
        Product product3 = new("Comb", "AH11116", 5, 10);
        Product product4 = new("Toothpaste", "AH3006", 2, 20);   
        Product product5 = new("Toothbrush", "AH01D66", 1, 10);      

        //CREATING PRODUCT LISTS FOR EACH ORDER
        List<Product>order1ProductList = new();
        order1ProductList.Add(product1);
        order1ProductList.Add(product2);
        order1ProductList.Add(product3);

        List<Product>order2ProductList = new();
        order2ProductList.Add(product1);
        order2ProductList.Add(product4);
        order2ProductList.Add(product5);

        List<Product>order3ProductList = new();
        order3ProductList.Add(product3);
        order3ProductList.Add(product1);
        order3ProductList.Add(product5);

        
        

        //PROGRAM CREATES 3 NEW ORDERS
        Order order1 = new(customer1,order1ProductList);
        Order order2 = new(customer2,order2ProductList);
        Order order3 = new(customer3,order3ProductList);

        //ADDING ORDERS TO AN ORDER LIST TO ITERATE IN THE NEXT STEP OF THE PROGRAM
        List<Order>myOrderList = new();
        myOrderList.Add(order1);
        myOrderList.Add(order2);
        myOrderList.Add(order3); 


        //DISPLAY PACKING LABEL, SHIPPING LABEL , TOTAL PRICE PER ORDER
        Console.WriteLine("****************");
        foreach (Order myOrder in myOrderList)
        {
           myOrder.GetShippingLabel();
           myOrder.GetPackingLabel();
           
           myOrder.GetTotalCost();
           Console.WriteLine("***************"); 



        }    


        


        
    }


}