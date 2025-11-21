public class Order
{
    private Customer _myCostumer;
    private List<Product>_myProductList= new();



    public Order(Customer customer, List<Product>myList )
    {
        _myCostumer = customer;
        _myProductList = myList;
    }

    public void GetTotalCost()
    { 
        int subTotal = 0;
        foreach (Product product in _myProductList)
        {

          subTotal += product.GetTotalCost();   
          
        }
        int shippingCost = _myCostumer.InUsa() ? 5 : 35;  //using ternary operator to get the conditional value of shipping Cost
        int totalPrice = subTotal + shippingCost;
        Console.WriteLine($"Total price: {totalPrice}");
    }
    

    public void GetPackingLabel() //turned into void //change made to the program design
    
    {
       foreach (Product product in _myProductList)
        {
            string productID = product.GetProductID();
            string productName = product.GetProductName();
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product ID: {productID}");

        }
    }
      public void GetShippingLabel() //turned into void //change made to the program design
    {
       string customerName = _myCostumer.GetCustomerName();
       Address customerAddress = _myCostumer.GetCustomerAddress();
       string customerAddressString =  customerAddress.GetDisplayAddress();
       
       Console.WriteLine($"Customer Name: {customerName}");
         Console.WriteLine($"Customer Address: {customerAddressString}");

      


    }



}