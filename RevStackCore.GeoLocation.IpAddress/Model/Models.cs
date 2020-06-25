using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RevStackCore.GeoLocation.IpAddress
{

    public class ResultLocationData
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        [JsonProperty("continent_name")]
        public string ContinentName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("location")]
        public ResultLocation Location { get; set; }

        [JsonProperty("time_zone")]
        public ResultTimeZone TimeZone { get; set; }

        [JsonProperty("currency")]
        public ResultCurrency Currency { get; set; }

        [JsonProperty("connection")]
        public ResultConnection Connection { get; set; }

        [JsonProperty("security")]
        public ResultSecurity Security { get; set; }
    }


    public class ResultConnection
    {
        [JsonProperty("asn")]
        public long Asn { get; set; }

        [JsonProperty("isp")]
        public string Isp { get; set; }
    }

    public class ResultCurrency
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("symbol_native")]
        public string SymbolNative { get; set; }
    }


    public class ResultLocation
    {
        [JsonProperty("geoname_id")]
        public long GeonameId { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("languages")]
        public ResultLanguage[] Languages { get; set; }

        [JsonProperty("country_flag")]
        public Uri CountryFlag { get; set; }

        [JsonProperty("country_flag_emoji")]
        public string CountryFlagEmoji { get; set; }

        [JsonProperty("country_flag_emoji_unicode")]
        public string CountryFlagEmojiUnicode { get; set; }

        [JsonProperty("calling_code")]
        public string CallingCode { get; set; }

        [JsonProperty("is_eu")]
        public bool IsEu { get; set; }
    }

    public class ResultLanguage
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("native")]
        public string Native { get; set; }
    }

    public class ResultSecurity
    {
        [JsonProperty("is_proxy")]
        public bool IsProxy { get; set; }

        [JsonProperty("proxy_type")]
        public string ProxyType { get; set; }

        [JsonProperty("is_crawler")]
        public bool IsCrawler { get; set; }

        [JsonProperty("crawler_name")]
        public string CrawlerName { get; set; }

        [JsonProperty("crawler_type")]
        public string CrawlerType { get; set; }

        [JsonProperty("is_tor")]
        public bool IsTor { get; set; }

        [JsonProperty("threat_level")]
        public string ThreatLevel { get; set; }

        [JsonProperty("threat_types")]
        public string ThreatTypes { get; set; }
    }

    public class ResultTimeZone
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("current_time")]
        public DateTimeOffset CurrentTime { get; set; }

        [JsonProperty("gmt_offset")]
        public long GmtOffset { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("is_daylight_saving")]
        public bool IsDaylightSaving { get; set; }
    }
}
