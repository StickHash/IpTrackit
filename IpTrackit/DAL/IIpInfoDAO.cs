using IpTrackit.BO;

namespace IpTrackit.BLL
{
    internal interface IIpInfoDAO
    {
        IpInfo GetByIp(string ip);
    }
}