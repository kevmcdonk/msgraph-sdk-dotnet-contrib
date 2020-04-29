using Microsoft.Graph;
using System.Threading;
using System.Threading.Tasks;

namespace Graph.Community
{
	public interface IAssignmentRequest : IBaseRequest
	{
		Task<ICollectionPage<Assignment>> GetAsync();
		Task<ICollectionPage<Assignment>> GetAsync(CancellationToken cancellationToken);
	}
}
