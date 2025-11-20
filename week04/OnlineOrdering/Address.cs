public class Address
{
    private string _myCity;
    private string _myState;

    private string _myCountry;

    public Address(string city,string state,string country)
    {
        _myCity = city;
        _myState = state;
        _myCountry = country;

    }

    public bool IsFromUsa()
    {
        if(_myCountry != "USA" || _myCountry != "United States")
        {
          bool IsFromUsa = false; 
          return IsFromUsa;
        }
        return true; //if last condition is not met , than bool is true

    }

    public string GetDisplayAddress()
    {
        string fullAddress = _myCity + ", " + _myState + ", "+ _myCountry;
        return fullAddress;

    }

}