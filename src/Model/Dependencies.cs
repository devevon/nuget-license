using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NugetUtility.Model
{
    [DebuggerDisplay("Count={Group.Count}")]
    [XmlRoot(ElementName = "dependencies")]
    public class Dependencies
    {
        [XmlElement(ElementName = "group")]
        public List<Group> Group { get; set; }
    }
}
