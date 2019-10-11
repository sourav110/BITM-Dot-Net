using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleInfoWebApp
{
    [Serializable]

    public class Vehicle
    {
        public string VehicleName;
        public string RegNo;

        public List<double> speedList = new List<double>();

        public double GetMaxSpeed()
        {
            double MaxSpeed = speedList.Max();
            return MaxSpeed;
        }

        public double GetMinSpeed()
        {
            double MinSpeed = speedList.Min();
            return MinSpeed;
        }

        public double GetAverageSpeed()
        {
            double AvgSpeed = speedList.Average();
            return AvgSpeed;
        }

        public string GetDetail()
        {
            string Detail = VehicleName + "(" + RegNo + ")";
            return Detail;
        }
    }
}