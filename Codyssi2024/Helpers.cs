namespace Codyssi2024;

public class Helpers
{
    public static string LoadInputFile(string fileName)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(),"../../../../inputs", fileName);
        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }
        return File.ReadAllText(path);
    }
}