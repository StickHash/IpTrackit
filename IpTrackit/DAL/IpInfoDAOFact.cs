namespace IpTrackit.BLL
{
    class IpInfoDAOFact
    {
        public static IIpInfoDAO GetInstance()
        {
            return new IpInfoDAOImpl();
        }
    }
}