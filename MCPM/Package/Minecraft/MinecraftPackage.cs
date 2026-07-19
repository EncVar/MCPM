using MCPM.Registry;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using MCPM.Exceptions;

namespace MCPM.Package.Minecraft;

[Register(Namespace = "minecraft", IdRequired = false)]
public class MinecraftPackage(string version) : IMcPackage
{
    public McPackageType Type => McPackageType.Minecraft;

    public string Version { get; } = version;
    
    private readonly HttpClient _httpClient = new();
}
