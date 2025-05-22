namespace Codyssi2024.Day2;

public class Part3() : BasePart(2,3)
{
    public override string Run()
    {
        var input = Input().Select((l, i) => l == "TRUE").ToArray();
        var total = 0;

        var gates = new List<bool>(input);
        total = gates.Sum(x => x ? 1 : 0);
        while (gates.Count > 1)
        {
            var tempGates = new List<bool>();

            var andGate = true;
            for (int i = 0; i < gates.Count; i+=2)
            {
                if (andGate)
                {
                    tempGates.Add(gates[i] && gates[i + 1]);
                }
                else
                {
                    tempGates.Add(gates[i] || gates[i + 1]);
                }
                andGate = !andGate;
            }

            gates = tempGates;
            total += gates.Sum(x => x ? 1 : 0);
        }

        return total.ToString();
    }
}