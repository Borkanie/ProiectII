using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectII.Clase
{
    //folosim aceasta clasa ca sa putem da display la orice rezolutie a oricarei marimi
    //practic generam un raport intre metri in realitate si pixeli pnlRestaurantView
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
