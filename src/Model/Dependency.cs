using System.Diagnostics;
using System.Xml.Serialization;

namespace NugetUtility.Model
{
    [DebuggerDisplay("{Id} {Version}")]
    [XmlRoot(ElementName = "dependency")]
    public class Dependency
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "exclude")]
        public string Exclude { get; set; }
    }
}
