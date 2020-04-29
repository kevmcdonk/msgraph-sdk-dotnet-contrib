using Microsoft.Graph;

namespace Graph.Community
{
	public interface IProjectServerAPIRequestBuilder : IBaseRequestBuilder
	{
		IAssignmentRequestBuilder Assignments { get; }

		//ISiteScriptRequestBuilder Projects { get; }
	}
}
