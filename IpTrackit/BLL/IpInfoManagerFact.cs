using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpTrackit.BLL
{
    class IpInfoManagerFact
    {
        public static IIpInfoManager GetInstance()
        {
            return new IpInfoManagerImpl();
        }
    }
}
