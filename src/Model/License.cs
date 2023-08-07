using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NugetUtility.Model
{
    [DebuggerDisplay("{Type} {Text}")]
    [XmlRoot(ElementName = "license")]
    public class License
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }

        public bool IsLicenseFile()
        {
            return string.Compare(Type, "file", StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}
