public class Customer
{

   private string _name;
   private Address _myAddress;

   public Customer(string name, Address address)
    {
        _name = name;

        _myAddress = address;

    }

    public bool InUsa()
    {
        bool FromUsa = _myAddress.IsFromUsa();

        if(FromUsa == false)
        {
            return false;
        }
        return true;
    }

}