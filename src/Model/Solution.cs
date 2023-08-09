using System.Collections.Generic;

namespace NugetUtility.Model
{
    public sealed class Solution : Dictionary<string, Project>
    {
        public Solution(string solutionFile = null, int capacity = 0) 
            : base(capacity) 
        {
            SolutionFile = solutionFile ?? string.Empty;
        }

        public string SolutionFile { get; }
    }
}