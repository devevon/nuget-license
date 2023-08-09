using System.Diagnostics;

namespace NugetUtility.Model
{
    [DebuggerDisplay("{Type} {Url} @{Commit}")]
    public class LibraryRepositoryInfo
    {
        public string Type { get; set; }
        public string Url { get; set; }
        public string Commit { get; set; }
    }
}
