using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BL.Helpers
{
    internal static class RemoteDataGrabHelper
    {
        public static async Task<IEnumerable<T>> GrabRemoteEndpoint<T>(string url, int count)
        {
            using (var client = new HttpClient())
            {
                var str = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<IEnumerable<T>>
                    (str).Take(count);
            }
        }
    }
}
