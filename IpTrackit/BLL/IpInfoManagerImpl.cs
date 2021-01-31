using IpTrackit.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpTrackit.BLL
{
    class IpInfoManagerImpl : IIpInfoManager
    {
        IIpInfoDAO Dao = IpInfoDAOFact.GetInstance();
        public IpInfo GetIpInfo(string ip)
        {
            try
            {
                return Dao.GetByIp(ip);
            }
            catch (Exception)
            {

                throw new Exception();
            } 

        }
    }
}
