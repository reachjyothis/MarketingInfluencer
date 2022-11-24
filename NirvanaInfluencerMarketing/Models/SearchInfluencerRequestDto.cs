using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NirvanaInfluencerMarketing.Models
{
    public class SearchInfluencerRequestDto
    {
        public SortSerachInfluencer sort { get; set; }
        public int page { get; set; }
        public FilterSerachInfluencer filter { get; set; }
    }

    public class SortSerachInfluencer
    {
        public string field { get; set; }
        public int id { get; set; }
        public string direction { get; set; }
    }

    public class FilterSerachInfluencer
    {
        public Influencer influencer { get; set; }
        public Audience audience { get; set; }
    }

    public class Influencer
    {
        public Followers followers { get; set; }
        public float engagementRate { get; set; }
        public int[] location { get; set; }
        public string language { get; set; }
        public int lastposted { get; set; }
        public string[] relevance { get; set; }
        public string gender { get; set; }
        public Followersgrowthrate followersGrowthRate { get; set; }
        public Views views { get; set; }
        public Hascontactdetail[] hasContactDetails { get; set; }
        public string keywords { get; set; }
    }

    public class Followers
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Followersgrowthrate
    {
        public string interval { get; set; }
        public int value { get; set; }
        public string _operator { get; set; }
    }

    public class Views
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Hascontactdetail
    {
        public string contactType { get; set; }
        public string filterAction { get; set; }
    }

    public class Audience
    {
        public int[] location { get; set; }
        public string language { get; set; }
        public string gender { get; set; }
        public string[] age { get; set; }
    }

}
