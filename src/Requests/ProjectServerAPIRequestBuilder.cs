using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Community
{
	public class ProjectServerAPIRequestBuilder : BaseRequestBuilder, IProjectServerAPIRequestBuilder
	{

		public ProjectServerAPIRequestBuilder(
			string siteUrl,
			IBaseClient client)
			: base(siteUrl, client)
		{
		}

		public IAssignmentRequestBuilder Assignments
		{
			get
			{
				return new AssignmentRequestBuilder(this.AppendSegmentToRequestUrl("_api/ProjectData"), this.Client);
			}
		}
	}
}
