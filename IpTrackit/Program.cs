using IpTrackit.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IpTrackit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            var infos = GetInfosAsync().Result;
            Console.WriteLine(infos.Query);

            Console.ReadKey();
        }

        private static async Task<IpInfo> GetInfosAsync()
        {
            var infos = await httpClient.GetFromJsonAsync<IpInfo>("2.10.214.247");
            

            return infos;
        }

        

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://ip-api.com/json/")
        };

        private static readonly JsonSerializerOptions jsonSerializerOptions
            = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

    }
}
