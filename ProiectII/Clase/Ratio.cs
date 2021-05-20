using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectII.Clase
{
    class Ratio
    {
        public double Meters { get; set; }
        public int Pixels { get; set; }

        public int PixelsFromMeters(double meters)
        {
            return (int)(meters * Convert.ToDouble(Pixels) / Meters);
        }
        public double MetersFromPixels(int pixels)
        {
            return Convert.ToDouble(pixels) * Meters / Pixels;
        }
        public override string ToString()
        {
            return this.Meters.ToString()+":"+this.Pixels.ToString();
        }

    }
}
