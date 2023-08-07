using System;
using System.Collections.Generic;

namespace NugetUtility.Model
{
    public sealed class Project : Dictionary<string, Package>
    {
        public Project(string projectFile, int capacity = 50)
            : base(capacity)
        {
            if (string.IsNullOrWhiteSpace(projectFile))
                throw new ArgumentNullException(nameof(projectFile));

            ProjectFile = projectFile.Trim();
        }

        public string ProjectFile { get; }
    }
}