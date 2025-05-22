namespace Codyssi2024;

public abstract class BasePart
{
    private readonly int _day;
    private readonly int _part;
    private readonly bool _test;

    public BasePart(int day,int part, bool test = false)
    {
        _day = day;
        _test = test;
        _part = part;

        Console.WriteLine($"Running day {_day} part {_part}{(_test ? " example" : "")}");
    }

    protected string[] Input()
    {
        string filename = $"day{_day,2:D2}";
        if (_test)
        {
            filename += "_test";
        }
        filename += ".txt";
        return Helpers.LoadInputFile(filename).Split("\n");
    }

    protected char[] InputChars()
    {
        string filename = $"day{_day,2:D2}";
        if (_test)
        {
            filename += "_test";
        }
        filename += ".txt";
        return Helpers.LoadInputFile(filename).ToCharArray();
    }

    public abstract void Run();
}