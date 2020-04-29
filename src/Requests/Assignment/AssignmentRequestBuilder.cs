using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Community
{
	public class AssignmentRequestBuilder : BaseRequestBuilder, IAssignmentRequestBuilder
	{
		private IEnumerable<Option> options;

#pragma warning disable CA1054 // URI parameters should not be strings
		public AssignmentRequestBuilder(
				string requestUrl,
				IBaseClient client,
				IEnumerable<Option> options = null)
				: base(requestUrl, client)
		{
			this.options = options;
		}
#pragma warning restore CA1054 // URI parameters should not be strings

		public IAssignmentRequest Request()
		{
			return this.Request(this.options);
		}

		public IAssignmentRequest Request(IEnumerable<Option> options)
		{
			return new Graph.Community.AssignmentRequest(this.RequestUrl, this.Client, options);
		}
	}
}
