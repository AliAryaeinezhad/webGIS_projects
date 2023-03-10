using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzimuthCalculator
{
    class Calculation
    {
        static public double azimuth(double lat1, double long1, double lat2, double long2)
        {
            // https://www.omnicalculator.com/other/azimuth
            // θ = atan2[(sin Δλ * cos φ₂), (cos φ₁ * sin φ₂ − sin φ₁ * cos φ₂ * cos Δλ)]

            double delta_long = long2 - long1;

            double azimuth = Math.Atan2((Math.Sin(delta_long) * Math.Cos(lat2)), (Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(delta_long)));

            // azimuth rad to deg 
            azimuth = azimuth * (180 / Math.PI);

            if (azimuth < 0)
            {
                azimuth = azimuth + 360;
            }

            return azimuth;
        }
    }
}
