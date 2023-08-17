﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NugetUtility.Filters
{
    internal class PackageFilters : ICollection<string>
    {
        private List<string> _packages = new List<string>();
        public PackageFilters() { }

        public static PackageFilters Default { get; } = new PackageFilters
        {
            "OpGui.ControlModel.Core",
            "OpGui.ControlModel.Infrastructure",
            "OpGui.GeoImporter.Infrastructure",
            "OpGui.Incident.Core",
            "OpGui.Incident.UI.Details",
            "OpGui.KernsystemClient",
            "OpGui.MeasureClient.Core",
            "OpGui.MeasureClient.Services",
            "OpGui.MeasureSignSimulation",
            "OpGui.MeasureSignSimulation.Infrastructure",
            "OpGui.MeasureTreeView",
            "OpGui.RoadControl.ControlModelDetails",
            "OpGui.RoadControl.Core",
            "OpGui.RoadControl.Infrastructure",
            "OpGui.RoadControl.Situations",
            "OpGui.RoadControl.Ticketing",
            "OpGui.RoadControlView",
            "OpGui.SituationClient.Core",
            "OpGui.SituationClient.Services",
            "OpGui.VmisServices.Proto",

            "OperatingResources",
            "SymbolViewer",
            "MultiEditorLib",

            "OpGui.MirrorUniverse.DataService",
            "OpGui.MirrorUniverse.VIACommons",
            "OpGui.MirrorUniverse.VIAModel",
            "OpGui.MirrorUniverse.VIAProtobuf",
            "OpGui.MirrorUniverse.VIAServiceCommons",

            "MongoDB.Bson",
            "MongoDb.Bson.NodaTime",
            "MongoDB.Driver",
            "MongoDB.Driver.Core",

            "Syncfusion.Compression.Base",
            "Syncfusion.Data.WPF",
            "Syncfusion.Diagram.WPF",
            "Syncfusion.DocIO.Wpf",
            "Syncfusion.Edit.WPF",
            "Syncfusion.Gantt.WPF",
            "Syncfusion.Grid.WPF",
            "Syncfusion.GridCommon.Wpf",
            "Syncfusion.Licensing",
            "Syncfusion.Linq.Base",
            "Syncfusion.OfficeChart.Base",
            "Syncfusion.ProjIO.Base",
            "Syncfusion.PropertyGrid.WPF",
            "Syncfusion.SfBusyIndicator.WPF",
            "Syncfusion.SfChart.WPF",
            "Syncfusion.SfDiagram.WPF",
            "Syncfusion.SfGauge.WPF",
            "Syncfusion.SfGrid.WPF",
            "Syncfusion.SfInput.WPF",
            "Syncfusion.SfRichTextBoxAdv.WPF",
            "Syncfusion.SfShared.WPF",
            "Syncfusion.Shared.WPF",
            "Syncfusion.Tools.WPF",

            "Microsoft.Maps.MapControl.WPF",

            "VMIS2.Transfer.Interface",
            "VMIS2.ConfigService.Interface.Proto",
            "VMIS2.Control.Datamodel.Proto",
            "VMIS2.Control.Service.Interface",
            "VMIS2.GeomanagerService.Interface.Proto",
            "VMIS2.GLAVIA.Interface.Proto",
            "VMIS2.IF31.Interface.Proto",
            "VMIS2.OpGui.Service",
            "VMIS2.ParameterService.Interface.Proto",
            "VMIS2.ReceivingProcessingDatamodel.Proto",
            "VMIS2.ReceivingProcessingDatamodel.Proto",
            "VMIS2.Tunnel.Datamodel.Proto",
            "VMIS2.VersionNotifier.Datamodel.Proto",
            "TLS.Resources.Proto",
            "VMIS2.AutarkyService.Interface.Proto",
            "VMIS2.TLS.Resources.Proto",

            "VMIS2Commons.Auth.Clients",
            "VMIS2Commons.Auth.Clients.UI",
            "VMIS2Commons.Core",

            "XAMCommon.Communication.Diagnostics",
            "XAMCommon.Extension.Caching.Memory",
            "XAMCommon.XAMBACnet.RestClient",
            "XAMCommon.XAMBACnet.RestObjects",

            "XAMControl.3DTools",
            "XAMControl.Abstraction",
            "XAMControl.Common.Base",
            "XAMControl.Common.ClientCallback",
            "XAMControl.Common.Diagnostics",
            "XAMControl.Common.Http",
            "XAMControl.Common.Localize",
            "XAMControl.Common.Maintenance",
            "XAMControl.Common.Maintenance.Abstractions",
            "XAMControl.Common.Store.Abstractions",
            "XAMControl.Common.Trace",
            "XAMControl.Common.UI",
            "XAMControl.Common.UI.Style",
            "XAMControl.Common.UI.Style.Syncfusion",
            "XAMControl.DataGridFilter",
            "XAMControl.Domain",
            "XAMControl.Syncfusion",
            "XAMControl.Ticketing.Core",
            "XAMControl.Ticketing.Infrastructure",
            "XAMControl.Ticketing.Lib",
            "XAMControl.Ticketing.UI",
            "XAMControl.Ticketing.UI.Abstractions",
            "XAMControl.XAMCommon",
            "XAMControl.XAMCommon.NLogTargets",
            "XAMControl.XAMControl",
            "XAMControl.XAMControl.Plugin",
            "XAMControl.XAMControls",
            "XAMControl.XAMIO.BACnet",
            "XAMControl.XAMIO.BACnet.Abstractions",
            "XAMControl.XAMIO.Common",
            "XAMControl.XAMIOBase",
            "XAMControl.XAMOffice",
            "XAMControl.XAMPDFViewer",
            "XAMControl.XAMTouch",
            "XAMControl.XAMWeb.CodeEditor",
            "XAMControl.XAMWeb.WebBrowser",

            "XAMLocalizeExtension",
            "XAMSyntaxEditorLib",

            "XAMServices.Alarming.Client",
            "XAMServices.AlarmingHistory.Client",
            "XAMServices.AutomationControlContainer.Client",
            "XAMServices.ClientRemoteControl.Client",
            "XAMServices.ControlData.Client",
            "XAMServices.Incident.Client",
            "XAMServices.Instance.Client",
            "XAMServices.Kernsystem.Client",
            "XAMServices.Measures.Client",
            "XAMServices.RoadConfigurations.Client",
            "XAMServices.Situations.Client",
            "XAMServices.Tagging.Client",
            "XAMServices.Ticketing.Client",
            "XAMServices.UserInteraction.Client",

            "XAMServices.BuildingBlocks.AspNetCore.EntityFramework",
            "XAMServices.BuildingBlocks.AspNetCore.Grpc",
            "XAMServices.BuildingBlocks.AspNetCore.SignalR",
            "XAMServices.BuildingBlocks.AspNetCore.Swagger",
            "XAMServices.BuildingBlocks.Client.SignalR",
            "XAMServices.BuildingBlocks.Controller.ErrorHandling",
            "XAMServices.BuildingBlocks.Controller.Versioning",
            "XAMServices.BuildingBlocks.Domain",
            "XAMServices.BuildingBlocks.EventBus",
            "XAMServices.BuildingBlocks.EventBus.ApacheKafka",
            "XAMServices.BuildingBlocks.EventBus.Extensions.DependencyInjection",
            "XAMServices.BuildingBlocks.EventBus.Extensions.DependencyInjection.Autofac",
            "XAMServices.BuildingBlocks.EventBus.InMemory",
            "XAMServices.BuildingBlocks.EventBus.Prometheus",
            "XAMServices.BuildingBlocks.EventBus.RabbitMQ",
            "XAMServices.BuildingBlocks.EventBus.Serialization.Json",
            "XAMServices.BuildingBlocks.EventBus.Serialization.Proto",
            "XAMServices.BuildingBlocks.HealthCheck",
            "XAMServices.BuildingBlocks.Infrastructure",
            "XAMServices.BuildingBlocks.Logging.Nlog",
            "XAMServices.BuildingBlocks.Security",
            "XAMServices.BuildingBlocks.Security.Oidc",
            "XAMServices.BuildingBlocks.XAMControlX4.DB.Model",

            "XAMServices.Interfaces.Messaging.Proto"
        };

        public int Count => _packages.Count;

        public bool IsReadOnly => true;

        public void Add(string item)
        {
            _packages.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(string item)
        {
            return _packages.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _packages.GetEnumerator();
        }

        public bool Remove(string item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _packages.GetEnumerator();
        }
    }
}
