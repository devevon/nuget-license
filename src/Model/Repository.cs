using System.Diagnostics;
using System.Xml.Serialization;

namespace NugetUtility.Model
{
    [DebuggerDisplay("{Type} {Url} @{Commit}")]
    [XmlRoot(ElementName = "repository")]
    public class Repository
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
        [XmlAttribute(AttributeName = "commit")]
        public string Commit { get; set; }
    }
}
