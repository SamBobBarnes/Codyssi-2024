// ReSharper disable SuspiciousTypeConversion.Global

namespace Codyssi2024.Day4;

public class Part2() : BasePart(4, 2)
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
        var reachableLocations = new List<string>();

        void Recurse(int depth, List<string> path, Node currentNode)
        {
            if (depth == 4) return;
            reachableLocations.Add(currentNode.Name);
            var roads = currentNode.Links.Where(x => !path.Any(p => p.Equals(x.Name))).ToList();
            foreach (var road in roads)
            {
                var newPath = new List<string>(path);
                newPath.Add(road.Name);
                Recurse(depth + 1, newPath, road);
            }
        };

        Recurse(0, [start.Name], start);

        reachableLocations = reachableLocations.Distinct().ToList();

        return reachableLocations.Count.ToString();
    }
}

internal class Node(string name)
{
    public readonly string Name = name;
    public List<Node> Links { get; set; } = new();

    public override bool Equals(object? obj)
    {
        if (obj is Node node)
            return Equals(node);
        if (obj is string str)
            return Name == str;
        return false;
    }

    protected bool Equals(Node other)
    {
        return Name == other.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return Name;
    }
}