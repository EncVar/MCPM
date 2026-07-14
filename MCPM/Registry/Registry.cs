using MCPM.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Registry;

public class Registry
{
    private static Registry RegistryInstance { get; set; } = new();

    private Dictionary<string, IMcPackage> _registry = [];
}
