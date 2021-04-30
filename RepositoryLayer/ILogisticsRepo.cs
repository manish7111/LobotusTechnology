using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public interface ILogisticsRepo
    {
        int GetParcelRate(DataRequest request);
    }
}
