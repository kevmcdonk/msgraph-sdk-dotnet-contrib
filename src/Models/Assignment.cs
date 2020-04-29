using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Community
{
#pragma warning disable CA1056 // Uri properties should not be strings
#pragma warning disable CA2227 // Collection properties should be read only

    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Assignment : BaseItem
    {
        /*
         public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string AssignmentId { get; set; }
        public string TimeByDay { get; set; }
         */
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ProjectId", Required = Newtonsoft.Json.Required.Default)]
        public Guid ProjectId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ProjectName", Required = Newtonsoft.Json.Required.Default)]
        public string ProjectName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "TaskId", Required = Newtonsoft.Json.Required.Default)]
        public Guid TaskId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "TaskName", Required = Newtonsoft.Json.Required.Default)]
        public string TaskName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "AssignmentId", Required = Newtonsoft.Json.Required.Default)]
        public Guid AssignmentId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "TimeByDay", Required = Newtonsoft.Json.Required.Default)]
        public DateTime TimeByDay { get; set; }

    }

#pragma warning restore CA1056 // Uri properties should not be strings
#pragma warning restore CA2227 // Collection properties should be read only
}
