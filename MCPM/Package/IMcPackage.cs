using System;
using System.Collections.Generic;
using System.Text;

namespace MCPM.Package;

public interface IMcPackage
{
    public McPackageType Type { get; }
    public string Version { get; }

    public Task Install();
    public Task Uninstall();
    public Task Fix();
}