using ModelLayer;
using RepositoryLayer.UserContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class LogisticsRepo: ILogisticsRepo
    {
        public readonly ProblemDBContext context;
        public LogisticsRepo(ProblemDBContext context)
        {
            this.context = context;
        }
        public int GetParcelRate(DataRequest request)
        {
            var result = this.GetZone(request.FromCity, request.DropCity);
            var rate = this.GetRateOfParcel(request.Kg, result);
            return rate;
        }
        public string GetDirection(string city)
        {
            try
            {
                var direction = this.context.City.Where<City>(option => option.CityName == city).FirstOrDefault();
                if (direction != null)
                {
                    var data = this.context.Direction.Where<Direction>(option => option.DirectionId == direction.DirectionId).FirstOrDefault();
                    return data.DirectionName;
                }
                return null;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string GetZone(string fromCity,string dropCity)
        {
            try
            {
                var rowDirection = this.GetDirection(fromCity);
                var columnDirection = this.GetDirection(dropCity);
                var result = this.context.Zone.Where<Zone>(option => option.ZoneName == rowDirection).FirstOrDefault();
                if (result != null)
                {
                    if (columnDirection.Equals("North"))
                    {
                        return result.North;
                    }
                    if (columnDirection.Equals("South"))
                    {
                        return result.South;
                    }
                    if (columnDirection.Equals("East"))
                    {
                        return result.East;
                    }
                    if (columnDirection.Equals("West"))
                    {
                        return result.West;
                    }
                }
                return null;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int GetRateOfParcel(int kg,string zone)
        {
            try
            {
                var rate = this.context.Rate.Where<Rate>(option => option.Kg == kg).FirstOrDefault();
                if (rate != null)
                {
                    if (zone.Equals("Z1"))
                    {
                        return rate.Z1;
                    }
                    if (zone.Equals("Z2"))
                    {
                        return rate.Z2;
                    }
                    if (zone.Equals("Z3"))
                    {
                        return rate.Z3;
                    }
                    if (zone.Equals("Z4"))
                    {
                        return rate.Z4;
                    }
                }
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
