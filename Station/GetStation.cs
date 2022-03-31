using MTR.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MTR.Station
{
    public class GetStation : IGetStation
    {
        public async Task<Root> ReturnStationBasedOnCoordinate(string firstCoordinate)
        {
            const string mtrApiKey = "4bc086b3a6bb4e04bea58980265b0f1a";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("api-key", mtrApiKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var mtrApiUrl = new Uri($"https://datacache-test.trafikverket.se/v2/data.json");
                string request = "<REQUEST>" +
                $"<LOGIN authenticationkey='{mtrApiKey}' />" +
                  "<QUERY objecttype='TrainStation' schemaversion='1'>" +
                "<FILTER>" +
                    $"<WITHIN name='Geometry.SWEREF99TM' shape='center' value='{firstCoordinate}' radius='100'/>" +
                "</FILTER>" +
              "</QUERY>" +
            "</REQUEST>";

                try
                {
                    var response = await client.PostAsync(mtrApiUrl, new StringContent(request));
                    string json;
                    using (var content = response.Content)
                    {
                        json = await content.ReadAsStringAsync();
                    }

                    return JsonConvert.DeserializeObject<Root>(json);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}
