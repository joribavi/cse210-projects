public class Product
{
    
    private string _productName;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product (string productName, string productID, int price, int quantity )
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;


    }

    public int GetTotalCost()
    {
        int totalCost = _price*_quantity;

        return totalCost;


    }
    
}