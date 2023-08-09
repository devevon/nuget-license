using System.Diagnostics;

namespace NugetUtility
{
    [DebuggerDisplay("{Name} {Version}")]
    public class PackageNameAndVersion
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }
}