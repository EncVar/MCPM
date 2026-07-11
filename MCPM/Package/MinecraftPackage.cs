using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Package;

public class MinecraftPackage(string version) : IMcPackage
{
    public McPackageType Type => McPackageType.Minecraft;

    public string Version { get; } = version;
    
    public Task Install()
    {
        throw new NotImplementedException();
    }

    public Task Uninstall()
    {
        throw new NotImplementedException();
    }

    public Task Fix()
    {
        throw new NotImplementedException();
    }
}
