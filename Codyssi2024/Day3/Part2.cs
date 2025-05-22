namespace Codyssi2024.Day3;

public class Part2() : BasePart(3,2)
{
    public override string Run()
    {
        var input = Input().Select(line =>
        {
            var data = line.Split(' ');
            var number = Convert.ToInt64(data[0], int.Parse(data[1]));
            return number;
        });

        return input.Sum().ToString();
    }
}