namespace Codyssi2024;

public abstract class BasePart(int day, bool test = false)

{
    protected string[] Input()
    {
        string filename = $"day{day,2:D2}";
        if (test)
        {
            filename += "_test";
        }
        filename += ".txt";
        return Helpers.LoadInputFile(filename).Split(Environment.NewLine);
    }

    protected char[] InputChars()
    {
        string filename = $"day{day,2:D2}";
        if (test)
        {
            filename += "_test";
        }
        filename += ".txt";
        return Helpers.LoadInputFile(filename).ToCharArray();
    }
}