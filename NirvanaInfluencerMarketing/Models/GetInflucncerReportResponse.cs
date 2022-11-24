using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NirvanaMarketingInfluencer.Models
{
    public class GetInflucncerReportResponse
    {

        public bool error { get; set; }
        public InfluencerProfile profile { get; set; }
    }
    public class ReportInfluencerPDF
    {
        public bool error { get; set; }
        public string url { get; set; }
    }


    public class InfluencerProfile
    {
        public string userId { get; set; }
        public InfluencerProfileDetails profile { get; set; }
        public Hashtag[] hashtags { get; set; }
        public Mention[] mentions { get; set; }
        public Audience audience { get; set; }
        public Recentpost[] recentPosts { get; set; }
        public Popularpost[] popularPosts { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public Stathistory[] statHistory { get; set; }
        public Contact[] contacts { get; set; }
        public string country { get; set; }
        public string ageGroup { get; set; }
        public int postsCount { get; set; }
        public Interest2[] interests { get; set; }
        public Audiencecommenters audienceCommenters { get; set; }
        public Lookalikesbytopic[] lookalikesByTopics { get; set; }
    }

    public class InfluencerProfileDetails
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
        public float engagementRate { get; set; }
        public int averageViews { get; set; }
    }

    public class Audience
    {
        public float credibility { get; set; }
        public float notable { get; set; }
        public Gender[] genders { get; set; }
        public Geocity[] geoCities { get; set; }
        public Geocountry[] geoCountries { get; set; }
        public Age[] ages { get; set; }
        public Gendersperage[] gendersPerAge { get; set; }
        public Brandaffinity[] brandAffinity { get; set; }
        public Interest[] interests { get; set; }
        public Language[] languages { get; set; }
        public Notableuser[] notableUsers { get; set; }
        public Audiencelookalike[] audienceLookalikes { get; set; }
        public Ethnicity[] ethnicities { get; set; }
    }

    public class Gender
    {
        public string code { get; set; }
        public float weight { get; set; }
    }

    public class Geocity
    {
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Geocountry
    {
        public string name { get; set; }
        public float weight { get; set; }
        public string code { get; set; }
    }

    public class Age
    {
        public string code { get; set; }
        public float weight { get; set; }
    }

    public class Gendersperage
    {
        public string code { get; set; }
        public float male { get; set; }
        public float female { get; set; }
    }

    public class Brandaffinity
    {
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Interest
    {
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Language
    {
        public string code { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Notableuser
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
    }

    public class Audiencelookalike
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
    }

    public class Ethnicity
    {
        public string code { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Audiencecommenters
    {
        public float credibility { get; set; }
        public float notable { get; set; }
        public Gender1[] genders { get; set; }
        public Geocity1[] geoCities { get; set; }
        public Geocountry1[] geoCountries { get; set; }
        public Age1[] ages { get; set; }
        public Gendersperage1[] gendersPerAge { get; set; }
        public Brandaffinity1[] brandAffinity { get; set; }
        public Interest1[] interests { get; set; }
        public Language1[] languages { get; set; }
        public Notableuser1[] notableUsers { get; set; }
        public Audiencelookalike1[] audienceLookalikes { get; set; }
        public Ethnicity1[] ethnicities { get; set; }
    }

    public class Gender1
    {
        public string code { get; set; }
        public float weight { get; set; }
    }

    public class Geocity1
    {
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Geocountry1
    {
        public string name { get; set; }
        public float weight { get; set; }
        public string code { get; set; }
    }

    public class Age1
    {
        public string code { get; set; }
        public float weight { get; set; }
    }

    public class Gendersperage1
    {
        public string code { get; set; }
        public float male { get; set; }
        public float female { get; set; }
    }

    public class Brandaffinity1
    {
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Interest1
    {
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Language1
    {
        public string code { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Notableuser1
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
    }

    public class Audiencelookalike1
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
    }

    public class Ethnicity1
    {
        public string code { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
    }

    public class Hashtag
    {
        public string tag { get; set; }
        public float weight { get; set; }
    }

    public class Mention
    {
        public string tag { get; set; }
        public float weight { get; set; }
    }

    public class Recentpost
    {
        public string id { get; set; }
        public string text { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
        public int views { get; set; }
        public string video { get; set; }
        public string thumbnail { get; set; }
    }

    public class Popularpost
    {
        public string id { get; set; }
        public string text { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
        public int views { get; set; }
        public string video { get; set; }
        public string thumbnail { get; set; }
    }

    public class Stathistory
    {
        public string month { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public int avgLikes { get; set; }
        public int avgViews { get; set; }
        public int avgComments { get; set; }
    }

    public class Contact
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Interest2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Lookalikesbytopic
    {
        public string userId { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string url { get; set; }
        public string picture { get; set; }
        public int followers { get; set; }
        public int engagements { get; set; }
    }

}
