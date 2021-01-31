using IpTrackit.BLL;
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
            var IpInfoManager = IpInfoManagerFact.GetInstance();
            Console.WriteLine("Hello");
            var info = IpInfoManager.GetIpInfo("2.10.214.247");
            var city = info.City;
            var query = info.Query;
            Console.WriteLine("Ip: " + query);
            Console.WriteLine("Ville: " + city);
            Console.ReadKey();
        }

    }
}
