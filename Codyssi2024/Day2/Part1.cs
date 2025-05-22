namespace Codyssi2024.Day2;

public class Part1() : BasePart(2,1)
{
    public override string Run()
    {
        var input = Input().Select((l, i) => (Index: i+1,Value: l == "TRUE"))
            .Where(s => s.Value).ToArray();

        return input.Sum(x => x.Index).ToString();
    }
}