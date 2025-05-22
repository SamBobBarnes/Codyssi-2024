namespace Codyssi2024.Day2;

public class Part2() : BasePart(2,2)
{
    public override string Run()
    {
        var input = Input().Select((l, i) => l == "TRUE").ToArray();

        var total = 0;
        var andGate = true;
        for(int i = 0; i < input.Length; i+=2)
        {
            if (andGate)
            {
                total += input[i] && input[i + 1] ? 1 : 0;
            }
            else
            {
                total += input[i] || input[i + 1] ? 1 : 0;
            }
            andGate = !andGate;
        }

        return total.ToString();
    }
}