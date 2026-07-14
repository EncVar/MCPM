using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Registry;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class RegisterAttribute : Attribute
{
    public required string Namespace { get; set; }

    public required bool IdRequired { get; set; }
}
