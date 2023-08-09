using System.Diagnostics;
using System.Xml.Serialization;

namespace NugetUtility.Model
{
    [DebuggerDisplay("{Metadata.Id} {Metadata.Version}")]
	[XmlRoot(ElementName="package", Namespace = "")]
	public class Package 
	{
		[XmlElement(ElementName="metadata")]
		public Metadata Metadata { get; set; }
	}
}
