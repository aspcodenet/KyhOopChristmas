using Microsoft.Win32.SafeHandles;

namespace KyhOopChristmas;

public class App
{
    public void Run()
    {
        var personList = new List<Person>();
        var stefan = new Person("Stefan");
        var oliver = new Person("Oliver");
        var kerstin = new Person("Kerstin");
        personList.Add(stefan);
        personList.Add(oliver);
        personList.Add(kerstin);

        stefan.AddPresent(new ChristmasPresent("PS5", 4500));
        stefan.AddPresent(new ChristmasPresent("Dator", 14500));
        oliver.AddPresent(new ChristmasPresent("Telefon", 5000));
        oliver.AddPresent(new ChristmasPresent("Lego", 1000));
        oliver.AddPresent(new ChristmasPresent("Spel", 2000));
        kerstin.AddPresent(new ChristmasPresent("Penna", 15));

        foreach (var person in personList)
        {
            Console.WriteLine($"{person.Name} ska få julklappar för {person.Total} kr");
        }
    }
}