using ModelLayer;
using RepositoryLayer;
using System;

namespace ManagerLayer
{
    public class LogisticsManager : ILogisticsManager
    {
        public readonly ILogisticsRepo repository;
        public LogisticsManager(ILogisticsRepo repository)
        {
            this.repository = repository;
        }
        public int GetParcelRate(DataRequest request)
        {
            try
            {
                var result=this.repository.GetParcelRate(request);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
    }
}
