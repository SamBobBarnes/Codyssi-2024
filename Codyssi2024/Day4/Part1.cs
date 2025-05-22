namespace Codyssi2024.Day4;

public class Part1() : BasePart(4, 1)
{
    public override string Run()
    {
        var input = Input().Select(x => x.Split(" <-> "));
        var locations = new List<string>();
        foreach (var item in input)
        {
            if (!locations.Contains(item[0])) locations.Add(item[0]);
            if (!locations.Contains(item[1])) locations.Add(item[1]);
        }

        return locations.Count.ToString();
    }
}