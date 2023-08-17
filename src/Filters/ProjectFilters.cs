using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NugetUtility.Filters
{
    internal class ProjectFilters : ICollection<string>
    {
        private List<string> _projects = new List<string>();
        public ProjectFilters() { }

        public static ProjectFilters Default { get; } = new ProjectFilters
        {
            "/Demo/",
            "/Tests/",
            "/Test/",
            "/VIA/",

            ".Test.csproj",
            ".Tests.csproj",
            ".UnitTest.csproj",
            ".UnitTests.csproj",
            ".IntegrationTest.csproj",
            ".IntegrationTests.csproj"
        };

        public int Count => _projects.Count;

        public bool IsReadOnly => true;

        public void Add(string item)
        {
            _projects.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(string item)
        {
            return _projects.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _projects.GetEnumerator();
        }

        public bool Remove(string item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _projects.GetEnumerator();
        }
    }
}
