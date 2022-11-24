using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NirvanaInfluencerMarketing.Models
{
    public class AdzuHttpClient
    {

        public async Task<string> HttpGetAsync(string baseUrl, string accessToken)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            var response = await httpClient.GetAsync(baseUrl);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> HttpPostAsync(HttpContent requestContent, string accessToken, string baseUrl)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            HttpResponseMessage response = httpClient.PostAsync(baseUrl, requestContent).GetAwaiter().GetResult();
            var data = "";
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                data = await response.Content.ReadAsStringAsync();
            }

            return data;
        }

        public async Task<string> HttpPostAsyncwithoutBody(string accessToken, string baseUrl)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            HttpResponseMessage response = httpClient.PostAsync(baseUrl,null).GetAwaiter().GetResult();
            var data = "";
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                data = await response.Content.ReadAsStringAsync();
            }

            return data;
        }

    }
}
