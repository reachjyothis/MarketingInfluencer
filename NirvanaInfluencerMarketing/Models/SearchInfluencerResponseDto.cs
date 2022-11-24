using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NirvanaInfluencerMarketing.Models
{
    public class SearchInfluencerResponseDto
    {
        public bool error { get; set; }
        public int total { get; set; }
        public Lookalike[] lookalikes { get; set; }
        public Direct[] directs { get; set; }
        public bool isExactMatch { get; set; }
    }

    public class Lookalike
    {
        public string userId { get; set; }
        public UserProfile profile { get; set; }
    }

    public class UserProfile
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
        public float engagementRate { get; set; }
    }

    public class Direct
    {
        public string userId { get; set; }
        public UserProfile profile { get; set; }
    }

}