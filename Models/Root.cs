using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MTR.Models
{
    public class Geometry
    {
        [JsonPropertyName("SWEREF99TM")]
        public string SWEREF99TM { get; set; }

        [JsonPropertyName("WGS84")]
        public string WGS84 { get; set; }
    }

    public class TrainStation
    {
        [JsonIgnore]
        [JsonPropertyName("Advertised")]
        public bool Advertised { get; set; }

        [JsonPropertyName("AdvertisedLocationName")]
        public string AdvertisedLocationName { get; set; }

        [JsonIgnore]
        [JsonPropertyName("AdvertisedShortLocationName")]
        public string AdvertisedShortLocationName { get; set; }

        [JsonIgnore]
        [JsonPropertyName("CountryCode")]
        public string CountryCode { get; set; }

        [JsonIgnore]
        [JsonPropertyName("CountyNo")]
        public List<int> CountyNo { get; set; }

        [JsonIgnore]
        [JsonPropertyName("Deleted")]
        public bool Deleted { get; set; }

        [JsonIgnore]
        [JsonPropertyName("Geometry")]
        public Geometry Geometry { get; set; }

        [JsonIgnore]
        [JsonPropertyName("LocationInformationText")]
        public string LocationInformationText { get; set; }

        [JsonIgnore]
        [JsonPropertyName("LocationSignature")]
        public string LocationSignature { get; set; }

        [JsonIgnore]
        [JsonPropertyName("ModifiedTime")]
        public DateTime ModifiedTime { get; set; }

        [JsonIgnore]
        [JsonPropertyName("PlatformLine")]
        public List<string> PlatformLine { get; set; }

        [JsonIgnore]
        [JsonPropertyName("Prognosticated")]
        public bool Prognosticated { get; set; }
    }

    public class RESULT
    {
        [JsonPropertyName("TrainStation")]
        public List<TrainStation> TrainStation { get; set; }
    }

    public class RESPONSE
    {
        [JsonPropertyName("RESULT")]
        public List<RESULT> RESULT { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("RESPONSE")]
        public RESPONSE RESPONSE { get; set; }
    }


}
