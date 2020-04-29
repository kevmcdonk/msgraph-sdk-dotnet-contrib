using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Community
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class GetAssignmentCollectionResponse
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
		public CollectionPage<Assignment> Value { get; }

		public GetAssignmentCollectionResponse()
		{
			this.Value = new CollectionPage<Assignment>();
		}
	}
}
