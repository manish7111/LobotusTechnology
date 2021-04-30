using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerLayer
{
    public interface ILogisticsManager
    {
        int GetParcelRate(DataRequest request);
    }
}
