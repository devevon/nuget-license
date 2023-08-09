using System.IO;
using System.Xml;

namespace NugetUtility.Helper
{
    // helper class to ignore namespaces when de-serializing
    public class NamespaceIgnorantXmlTextReader : XmlTextReader
    {
        public NamespaceIgnorantXmlTextReader(TextReader reader) 
            : base(reader) 
        { 

        }

        public override string NamespaceURI => string.Empty;
    }
}
