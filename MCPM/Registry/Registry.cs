using MCPM.Package;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MCPM.Registry;

public sealed class Registry : IDisposable
{
    public static Registry Instance { get; set; } = new();

    private Dictionary<RegisterAttribute, Type> _registry = [];

    public void Register(Type package)
    {
        var attribute = package.GetCustomAttribute<RegisterAttribute>();
        _registry.Add(attribute!, package);
    }

    public Type Query(RegisterAttribute attribute)
        => _registry[attribute];

    public void Remove(RegisterAttribute attribute)
        => _registry.Remove(attribute);

    public void Dispose()
    {
        _registry.Clear();
        GC.SuppressFinalize(this);
    }
}
