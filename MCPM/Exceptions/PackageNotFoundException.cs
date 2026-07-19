using MCPM.Package;
using MCPM.Registry;

namespace MCPM.Exceptions;

public class PackageNotFoundException(IMcPackage package) : Exception(
    $"Package not found: {((RegisterAttribute?)package.GetType().GetCustomAttributes(typeof(RegisterAttribute), false).FirstOrDefault())?.Namespace} {package.Version}");