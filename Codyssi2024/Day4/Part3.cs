// ReSharper disable SuspiciousTypeConversion.Global

namespace Codyssi2024.Day4;

public class Part3() : BasePart(4, 3)
{
    public override string Run()
    {
        var input = Input().Select(x => x.Split(" <-> "));
        var locations = new List<Node>();
        foreach (var item in input)
        {
            var location0 = locations.Find(x => x.Equals(item[0]));
            var location1 = locations.Find(x => x.Equals(item[1]));
            if (location0 == null && location1 == null)
            {
                var node0 = new Node(item[0]);
                var node1 = new Node(item[1]);
                node0.Links.Add(node1);
                node1.Links.Add(node0);
                locations.Add(node0);
                locations.Add(node1);
            }
            else if (location0 != null && location1 == null)
            {
                var node1 = new Node(item[1]);
                location0.Links.Add(node1);
                node1.Links.Add(location0);
                locations.Add(node1);
            }
            else if (location0 == null && location1 != null)
            {
                var node0 = new Node(item[0]);
                location1.Links.Add(node0);
                node0.Links.Add(location1);
                locations.Add(node0);
            }
            else if (location0 != null && location1 != null)
            {
                location0.Links.Add(location1);
                location1.Links.Add(location0);
            }
        }

        var start = locations.Find(x => x.Equals("STT"))!;

        var q = new PriorityQueue<(Node node, int dist), int>(Comparer<int>.Create((a, b) => a - b));
        var distances = new Dictionary<string, int>();
        foreach (var location in locations)
            distances.Add(location.Name, int.MaxValue);
        q.Enqueue((start, 0), 0);
        while (q.Count > 0)
        {
            var (current, dist) = q.Dequeue();
            if (distances[current.Name] > dist)
                distances[current.Name] = dist;
            foreach (var path in current.Links)
                if (distances[path.Name] > dist + 1)
                    q.Enqueue((path, dist + 1), dist + 1);
        }

        return distances.Values.Sum().ToString();
    }
}