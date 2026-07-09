using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Registry;

public class Identifier(string ns, string version)
{
    public string Namespace { get; } = ns;
    public string Version { get; } = version;
}
