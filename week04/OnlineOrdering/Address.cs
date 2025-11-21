public class Address
{
    private string _streetAddress;
    private string _myCity;
    private string _myState;

    private string _myCountry;

    public Address(string streetAddress,string city,string state,string country)
    {
        _streetAddress = streetAddress;
        _myCity = city;
        _myState = state;
        _myCountry = country;

    }

    public bool IsFromUsa()
    {
        if(_myCountry == "USA" || _myCountry == "United States")
        {
          bool IsFromUsa = true; 
          return IsFromUsa;
        }
        return false; //if last condition is not met , than bool is false

    }

    public string GetDisplayAddress()
    {
        string fullAddress =  _streetAddress + ", " + _myCity + ", " + _myState + ", "+ _myCountry;
        return fullAddress;

    }

}