namespace Codyssi2024.Day1;

public class Part3():BasePart(1,3)
{
    public override string Run()
    {
        var input = Input().Select(int.Parse).ToList();

        var total = 0;

        var subtract = false;
        foreach(var line in input)
        {
            if(subtract) total -= line;
            else total += line;
            subtract = !subtract;
        }

        return total.ToString();
    }
}