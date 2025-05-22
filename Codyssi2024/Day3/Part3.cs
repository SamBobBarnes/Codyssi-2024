using System.Text;

namespace Codyssi2024.Day3;

public class Part3() : BasePart(3,3)
{
    public override string Run()
    {
        var input = Input().Select(line =>
        {
            var data = line.Split(' ');
            var number = Convert.ToInt64(data[0], int.Parse(data[1]));
            return number;
        }).Sum();


        var base65Sum = new StringBuilder();

        var base65 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#".ToCharArray();
        var remainder = input;
        while (remainder > 0)
        {
            var digit = remainder % 65;
            base65Sum.Insert(0,base65[digit]);
            remainder /= 65;
        }

        return base65Sum.ToString();
    }
}