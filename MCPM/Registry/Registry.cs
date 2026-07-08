using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Registry;

public class Registry<T>
{
    private static Registry<T> RegistryInstance { get; set; } = new();

    private Dictionary<string, T> _registry = [];
}
