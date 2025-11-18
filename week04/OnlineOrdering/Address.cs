public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string Street { get => _street; set => _street = value; }
    public string City { get => _city; set => _city = value; }
    public string State { get => _state; set => _state = value; }
    public string Country { get => _country; set => _country = value; }

    public Address() {}

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string InformUSA()
    {
        return _country.ToLower() == "usa" ? "Yes" : "No";
    }

    public string ShowAddress()
    {
        return $"{_street} { Environment.NewLine} {_city}, {_state} { Environment.NewLine} {_country}";
    }
}