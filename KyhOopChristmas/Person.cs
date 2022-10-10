namespace KyhOopChristmas;

public class Person
{
    private readonly string _name;
    public List<ChristmasPresent> _presents = new List<ChristmasPresent>();

    public Person(string name)
    {
        _name = name;
    }

    public void AddPresent(ChristmasPresent present)
    {
        _presents.Add(present);
    }

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public int Total
    {
        get
        {
            var sum = 0;
            foreach (var present in _presents)
                sum += present.Price;
            return sum;
        }
    }
}