using MCPM.Package;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MCPM.Registry;

public sealed class Registry : IDisposable
{
    private static Registry RegistryInstance { get; set; } = new();

    private Dictionary<RegisterAttribute, Type> _registry = [];

    private void RegisterForSingleton(Type package)
    {
        var attribute = package.GetCustomAttribute<RegisterAttribute>();
        _registry.Add(attribute!, package);
    }

    public static void Register(Type package)
        => RegistryInstance.RegisterForSingleton(package);

    public void Dispose()
    {
        _registry.Clear();
        GC.SuppressFinalize(this);
    }
}
