namespace KyhOopChristmas;

public class ChristmasPresent
{
    private readonly string _name;
    private readonly int _price;

    public ChristmasPresent(string name, int price)
    {
        _name = name;
        _price = price;
    }

    public int Price
    {
        get { return _price; }
    }
}