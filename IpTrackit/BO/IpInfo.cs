using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpTrackit.BO
{
    public class IpInfo
    {
        public string Query { get; set; }
        public string Country { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Isp { get; set; }
        public string Org { get; set; }
        public string As { get; set; }

    }
}
