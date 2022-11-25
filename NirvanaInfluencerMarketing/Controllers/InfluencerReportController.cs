using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NirvanaInfluencerMarketing.Models;
using NirvanaMarketingInfluencer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NirvanaMarketingInfluencer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfluencerReportController : ControllerBase
    {
        private readonly ILogger<InfluencerReportController> _logger;
        private readonly IConfiguration _configuration;

        public InfluencerReportController(ILogger<InfluencerReportController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet]
        public string GetReport(string ChannelType, string UserId)
        {
            try
            {
                AdzuHttpClient adzuHttpClient = new AdzuHttpClient();
                string baseUrl = _configuration["AppSettings:BaseUrl"] + ChannelType + "/profile/" + UserId + "/report";
                string token = _configuration["AppSettings:Token"];

                var result = adzuHttpClient.HttpGetAsync(baseUrl, token).GetAwaiter().GetResult();
                //return JsonConvert.DeserializeObject<GetInflucncerReportResponse>(result);
            }
            catch (Exception)
            {

            }

            return "Test";
        }
        [HttpPost]
        public ReportInfluencerPDF GenerateReport(string ChannelType, string UserId)
        {
            AdzuHttpClient adzuHttpClient = new AdzuHttpClient();
            string baseUrl = _configuration["AppSettings:BaseUrl"] + ChannelType + "/profile/" + UserId + "/report/pdf";
            string token = _configuration["AppSettings:Token"];

            var result = adzuHttpClient.HttpPostAsyncwithoutBody( token, baseUrl).GetAwaiter().GetResult();
            return JsonConvert.DeserializeObject<ReportInfluencerPDF>(result);
        }
    }
}
