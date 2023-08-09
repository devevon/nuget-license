using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NugetUtility
{
    /// <summary>
    /// More information at https://spdx.org/licenses/
    /// </summary>
    public class LicenseToUrlMappings : Dictionary<string, string>
    {
        private static readonly string Apache2_0 = "Apache License 2.0";
        private static readonly string GPL2_0 = "GPL-2.0";
        private static readonly string MIT = "MIT";
        private static readonly string GNU = "GNU";
        private static readonly string BSD_2_Clause = "BSD-2-Clause";
        private static readonly string BSD_3_Clause = "BSD-3-Clause";
        private static readonly string MS_PL = "MS-PL";
        private static readonly string MS_EULA = "MS-EULA";
        private static readonly string MS_EULA_Non_Redistributable = "MS-EULA-Non-Redistributable";
        private static readonly string Google_Copyright_2008 = "Copyright 2008 Google Inc.";

        public LicenseToUrlMappings() : base(ProtocolIgnorantOrdinalIgnoreCase.Default) { }

        public LicenseToUrlMappings(IDictionary<string, string> dictionary) : base(dictionary, ProtocolIgnorantOrdinalIgnoreCase.Default)
        {
        }

        private class ProtocolIgnorantOrdinalIgnoreCase : IEqualityComparer<string>
        {
            public static ProtocolIgnorantOrdinalIgnoreCase Default = new ProtocolIgnorantOrdinalIgnoreCase();

            public bool Equals([AllowNull] string x, [AllowNull] string y)
            {
                if (x is null || y is null) { return false; }

                return string.Compare(GetProtocolLessUrl(x), GetProtocolLessUrl(y), StringComparison.OrdinalIgnoreCase) == 0;
            }

            public int GetHashCode([DisallowNull] string obj) => GetProtocolLessUrl(obj).ToLower().GetHashCode();

            private static string GetProtocolLessUrl(string url)
            {
                if (string.IsNullOrEmpty(url)) return string.Empty;
                if (!url.Contains(":")) return string.Empty;
                return url[url.IndexOf(':')..];
            }
        }

        public static LicenseToUrlMappings Default { get; } = new LicenseToUrlMappings
        {
            { "http://www.apache.org/licenses/LICENSE-2.0.html", Apache2_0 },
            { "http://www.apache.org/licenses/LICENSE-2.0", Apache2_0 },
            { "http://opensource.org/licenses/Apache-2.0", Apache2_0 },
            { "http://aws.amazon.com/apache2.0/", Apache2_0 },
            { "http://logging.apache.org/log4net/license.html", Apache2_0 },
            { "https://github.com/owin-contrib/owin-hosting/blob/master/LICENSE.txt", Apache2_0 },
            { "https://raw.githubusercontent.com/aspnet/Home/2.0.0/LICENSE.txt", Apache2_0 },
            { "https://github.com/grpc/grpc/blob/master/LICENSE", Apache2_0 },
            { "https://licenses.nuget.org/Apache-2.0", Apache2_0 },
            { "https://raw.githubusercontent.com/aspnet/AspNetCore/2.0.0/LICENSE.txt", Apache2_0 },
            { "https://github.com/confluentinc/confluent-kafka-dotnet/blob/master/LICENSE", Apache2_0 },
            { "https://www.nuget.org/packages/RabbitMQ.Client/6.2.1/license", Apache2_0 },
            { "https://github.com/benaadams/Ben.Demystifier/blob/master/LICENSE", Apache2_0 },

            { "https://github.com/Microsoft/Microsoft.IO.RecyclableMemoryStream/blob/master/LICENSE", MIT },
            { "https://github.com/AutoMapper/AutoMapper/blob/master/LICENSE.txt", MIT },
            { "https://github.com/zzzprojects/html-agility-pack/blob/master/LICENSE", MIT },
            { "https://raw.githubusercontent.com/hey-red/markdownsharp/master/LICENSE", MIT },
            { "https://raw.github.com/JamesNK/Newtonsoft.Json/master/LICENSE.md", MIT },
            { "https://licenses.nuget.org/MIT", MIT },
            { "http://opensource.org/licenses/MIT", MIT },
            { "http://www.opensource.org/licenses/mit-license.php", MIT },
            { "http://max.mit-license.org/", MIT },
            { "https://github.com/dotnet/corefx/blob/master/LICENSE.TXT", MIT},
            { "https://opensource.org/licenses/mit-license.php", MIT},
            { "https://raw.githubusercontent.com/ControlzEx/ControlzEx/master/LICENSE", MIT},
            { "https://github.com/lbugnion/mvvmlight/blob/master/LICENSE", MIT},
            { "https://raw.githubusercontent.com/JamesNK/Newtonsoft.Json/master/LICENSE.md", MIT},
            { "https://github.com/dotnet/core/blob/main/LICENSE.TXT", MIT},
            { "https://github.com/dotnet/standard/blob/master/LICENSE.TXT", MIT},
            { "https://raw.githubusercontent.com/domaindrivendev/Swashbuckle.AspNetCore/master/LICENSE", MIT},
            { "https://raw.githubusercontent.com/bchavez/Bogus/master/LICENSE", MIT},
            { "https://github.com/fluentribbon/Fluent.Ribbon/blob/master/License.txt", MIT},
            { "https://github.com/MahApps/MahApps.Metro/blob/develop/LICENSE", MIT},
            { "https://www.nuget.org/packages/WindowsAPICodePack/1.1.3/License", MIT},
            { "https://github.com/AzureAD/azure-activedirectory-identitymodel-extensions-for-dotnet/blob/master/LICENSE.txt", MIT},
            { "https://raw.githubusercontent.com/Microsoft/dotnet/master/LICENSE", MIT},
            { "https://go.microsoft.com/fwlink/?linkid=841311", MIT},
            { "https://github.com/MahApps/MahApps.Metro/blob/master/LICENSE", MIT},
            { "http://www.pdfsharp.net/PDFsharp_License.ashx", MIT},

            { "http://www.gnu.org/licenses/lgpl.html", GNU },
            { "https://raw.githubusercontent.com/NetTopologySuite/ProjNet4GeoAPI/master/LICENSE", GNU },
            { "https://raw.githubusercontent.com/NetTopologySuite/GeoAPI/master/src/GeoAPI.CoordinateSystems/License.txt", GNU },
            { "https://licenses.nuget.org/LGPL-2.1-or-later", GNU },

            { "https://licenses.nuget.org/BSD-2-Clause", BSD_2_Clause },

            { "https://raw.githubusercontent.com/NetTopologySuite/GeoAPI/master/src/GeoAPI/License.txt", BSD_3_Clause },
            { "https://raw.githubusercontent.com/NetTopologySuite/GeoAPI/master/LICENSE.md", BSD_3_Clause },
            { "https://raw.githubusercontent.com/NetTopologySuite/NetTopologySuite.Features/master/LICENSE", BSD_3_Clause },
            { "https://licenses.nuget.org/BSD-3-Clause", BSD_3_Clause },
            { "https://github.com/NLog/NLog/blob/master/LICENSE.txt", BSD_3_Clause },

            { "http://www.gnu.org/licenses/old-licenses/gpl-2.0.html", GPL2_0 },

            { "http://opensource.org/licenses/MS-PL", MS_PL },
            { "http://www.opensource.org/licenses/ms-pl", MS_PL },
            { "https://licenses.nuget.org/MS-PL", MS_PL },
            { "https://github.com/YaccConstructor/QuickGraph/blob/master/LICENSE.txt", MS_PL },
            { "https://github.com/ClemensFischer/XAML-Map-Control/blob/master/license.md", MS_PL },
            { "https://raw.githubusercontent.com/haf/DotNetZip.Semverd/master/LICENSE", MS_PL },

            { "https://www.microsoft.com/web/webpi/eula/net_library_eula_ENU.htm", MS_EULA },
            { "https://www.nuget.org/packages/Microsoft.TeamFoundation.DistributedTask.Common.Contracts/16.170.0/License", MS_EULA },
            { "https://www.nuget.org/packages/Microsoft.TeamFoundationServer.Client/16.170.0/License", MS_EULA },
            { "https://www.nuget.org/packages/Microsoft.TeamFoundationServer.ExtendedClient/16.170.0/License", MS_EULA },
            { "https://www.nuget.org/packages/Microsoft.VisualStudio.Services.Client/16.170.0/License", MS_EULA },
            { "https://www.nuget.org/packages/Microsoft.VisualStudio.Services.InteractiveClient/16.170.0/License", MS_EULA },
            { "http://go.microsoft.com/fwlink/?LinkId=218949", MS_EULA },
            { "https://www.microsoft.com/web/webpi/eula/aspnetmvc3update-eula.htm", MS_EULA },
            { "http://go.microsoft.com/fwlink/?LinkID=214339", MS_EULA },
            { "http://go.microsoft.com/fwlink/?LinkId=329770", MS_EULA },
            { "http://go.microsoft.com/fwlink/?LinkId=529443", MS_EULA },

            { "https://www.microsoft.com/web/webpi/eula/dotnet_library_license_non_redistributable.htm", MS_EULA_Non_Redistributable },
            { "http://go.microsoft.com/fwlink/?LinkId=529444", MS_EULA_Non_Redistributable },

            { "https://github.com/protocolbuffers/protobuf/blob/master/LICENSE", Google_Copyright_2008 }
        };
    }
}
