namespace MCPM.Instance;

public class GameRoot
{
    public required string Path { get; set; }
    
    public required Config GlobalConfig { get; set; }
    
    public required List<Instance> Instances { get; set; }

    // public static GameRoot Load(string path)
    // {
    //     if (System.IO.Path.Exists(path))
    //     {
    //         
    //     }
    //     else
    //     {
    //         throw new ArgumentException($"The path '{path}' does not exist.");
    //     }
    // }
}