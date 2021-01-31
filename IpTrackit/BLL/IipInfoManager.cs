using IpTrackit.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpTrackit.BLL
{
    interface IIpInfoManager
    {
        IpInfo GetIpInfo(string ip);
    }
}
