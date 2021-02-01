using IpTrackit.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace IpTrackit.BLL
{
    internal class IpInfoDAOImpl : IIpInfoDAO
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://ip-api.com/json/")
        };

        private static  Task<IpInfo> GetInfosAsync(string query)
        {
            return httpClient.GetFromJsonAsync<IpInfo>(query);
        }

        public IpInfo GetByIp(string ip)
        {
            try
            {
                return GetInfosAsync(ip).Result;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }


    }
}