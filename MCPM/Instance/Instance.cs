using MCPM.Package;

namespace MCPM.Instance;

public class Instance
{
    public required string InstanceName { get; set; }
    
    public required string AbsolutePath { get; set; }
    
    public required List<IMcPackage> Packages { get; set; }
    
    public required GameRoot GameRoot { get; set; }
    
    public required Config LocalConfig { get; set; }
}