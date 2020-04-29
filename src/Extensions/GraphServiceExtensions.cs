using Microsoft.Graph;
using System;

namespace Graph.Community
{
	public static class GraphServiceExtensions
	{
		public static ISharePointAPIRequestBuilder SharePointAPI(this GraphServiceClient graphServiceClient, string siteUrl)
		{
			return new SharePointAPIRequestBuilder(siteUrl, graphServiceClient);
		}

        public static IProjectServerAPIRequestBuilder ProjectServerAPI(this GraphServiceClient graphServiceClient, string pwaUrl)
        {
            return new ProjectServerAPIRequestBuilder(pwaUrl, graphServiceClient);
        }
    }
}
