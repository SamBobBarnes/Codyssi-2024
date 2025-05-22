namespace Codyssi2024;

public class Helpers
{
    public static string LoadInputFile(string fileName)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(),"../../../Inputs", fileName);
        if (!File.Exists(path))
        {
            File.Create(path).Close();
            File.WriteAllText(path, "Replace me with your input");
        }
        return File.ReadAllText(path);
    }
}