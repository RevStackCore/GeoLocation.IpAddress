using System;
using System.Threading.Tasks;
using RevStackCore.Extensions.GeoLocation;
using RevStackCore.Net;
using Json = RevStackCore.Extensions.Serialization.SnakeCase.Json;

namespace RevStackCore.GeoLocation.IpAddress
{
    public class GeoIpV4Service : IGeoIpV4Service
    {
        private string GEO_IP_JSON_URL = "http://api.ipstack.com/";
        private string _apiKey;
        public GeoIpV4Service(string apiKey)
        {
            _apiKey = apiKey;
        }
        public async Task<GeoCoordinate> GetAsync(string ipAddress)
        {
            string url = GEO_IP_JSON_URL + ipAddress + "?access_key=" + _apiKey;
            string result = await Http.GetAsync(url);
            var geoResult = Json.DeserializeObject<ResultLocationData>(result);
            var geoCoordinate =new GeoCoordinate(geoResult.Latitude, geoResult.Longitude);
            geoCoordinate.City = geoResult.City;
            geoCoordinate.CountryCode = geoResult.CountryCode;
            geoCoordinate.State = geoResult.RegionCode;
            geoCoordinate.ZipCode = geoResult.Zip;
            return geoCoordinate;
        }
    }

    public class SecureGeoIpV4Service : IGeoIpV4Service
    {
        private string GEO_IP_JSON_URL = "http://api.ipstack.com/";
        private string _apiKey;
        public SecureGeoIpV4Service(string apiKey)
        {
            _apiKey = apiKey;
        }
        public async Task<GeoCoordinate> GetAsync(string ipAddress)
        {
            string url = GEO_IP_JSON_URL + ipAddress + "?access_key=" + _apiKey + "&security=1";
            string result = await Http.GetAsync(url);
            var geoResult = Json.DeserializeObject<ResultLocationData>(result);
            var geoCoordinate = new GeoCoordinate(geoResult.Latitude, geoResult.Longitude);
            geoCoordinate.City = geoResult.City;
            geoCoordinate.CountryCode = geoResult.CountryCode;
            geoCoordinate.State = geoResult.RegionCode;
            geoCoordinate.ZipCode = geoResult.Zip;
            if (geoResult.Security != null)
            {
                geoCoordinate.IsBot = geoResult.Security.IsCrawler;
                geoCoordinate.IsProxy = geoResult.Security.IsProxy;
            }

            return geoCoordinate;
        }
    }
}
