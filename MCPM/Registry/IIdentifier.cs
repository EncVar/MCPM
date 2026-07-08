using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Registry;

public interface IIdentifier
{
    public string Namespace { get; }
    public string Version { get;}
}
