using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NugetUtility.Model
{
    [DebuggerDisplay("{TargetFramework} Count={Dependency.Count}")]
    [XmlRoot(ElementName = "group")]
    public class Group
    {
        [XmlAttribute(AttributeName = "targetFramework")]
        public string TargetFramework { get; set; }
        [XmlElement(ElementName = "dependency")]
        public List<Dependency> Dependency { get; set; }
    }
}
