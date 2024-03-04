public class Person
{
    string _name;
    string _address;

    public Person(string name, string address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public override string ToString()
    {
        return $"{_name}({_address})";
    }
}