using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NirvanaInfluencerMarketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NirvanaInfluencerMarketing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchInfluencerController : ControllerBase
    {
        private readonly ILogger<SearchInfluencerController> _logger;
        private readonly IConfiguration _configuration;

        public SearchInfluencerController(ILogger<SearchInfluencerController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [Route("SearchInfluencer/{ChannelType}")]
        [HttpPost]
        public SearchInfluencerResponseDto SearchInfluencer(string ChannelType,SearchInfluencerRequestDto Requestdata)
        {
            AdzuHttpClient adzuHttpClient = new AdzuHttpClient();
            string baseUrl = _configuration["AppSettings:BaseUrl"] + ChannelType + "/search";
            string token = _configuration["AppSettings:Token"];

            var json = JsonConvert.SerializeObject(Requestdata);
            var requestContent = new StringContent(json, Encoding.UTF8, "application/json");
            var result = adzuHttpClient.HttpPostAsync(requestContent, token, baseUrl).GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<SearchInfluencerResponseDto>(result);

        }



    }
}
