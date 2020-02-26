using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Infrastructure
{
    public class ServiceHelpers
    {
#if DEBUG
        public const string SchoolService = "localhost:57801";
        public const string IncomeService = "localhost:57802";
#else
        public const string SchoolService = "school_service";
        public const string IncomeService = "income_service";
#endif

        public static async Task<T> GetServiceData<T>(string service, string action)
        {
            var restClient = new RestSharp.RestClient($"http://{service}/");
            var restRequest = new RestSharp.RestRequest(action, RestSharp.Method.GET, RestSharp.DataFormat.Json);
            var restResponse = await restClient.ExecuteAsync<T>(restRequest);
            if (restResponse.IsSuccessful)
            {
                return restResponse.Data;
            }
            return default(T);
        }
    }
}
