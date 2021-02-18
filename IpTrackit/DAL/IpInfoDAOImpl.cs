
using IpTrackit.BO;
using LiteDB;
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
            using (var db = new LiteDatabase(@"C:\Temp\Data.db"))
            {
                try
                {
                    var col = db.GetCollection<IpInfo>("ipInfos");
                    var ipInfo = col.FindOne(x => x.Query == ip);
                    if(ipInfo == null)
                    {
                        ipInfo = GetInfosAsync(ip).Result;
                        col.Insert(ipInfo);
                    }

                    return ipInfo;
                }
                catch (Exception)
                {

                    throw new Exception();
                }
            }
        }


    }
}