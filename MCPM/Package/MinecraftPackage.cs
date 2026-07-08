using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Package;

public class MinecraftPackage(string identifier) : IMcPackage
{
    public McPackageType Type => McPackageType.Minecraft;

    public string Namespace => "minecraft";

    public string Identifier { get; set; } = identifier;
}
