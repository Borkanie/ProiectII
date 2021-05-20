using ProiectII.Clase;
using System;
using System.Drawing;

namespace ProiectII.Restaurant
{
    //Model of chair
    class ChairModel
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Ratio RatioX { get; set; }
        public Ratio RatioY { get; set; }
        public ChairModel(string coordinatesString,Point tablepoint,Ratio ratioX,Ratio ratioY,int id)
        {
            Id = id;
            this.RatioX = ratioX;
            this.RatioY = ratioY;
            if (coordinatesString.Contains(":"))
            {
                this.X = tablepoint.X + ratioX.PixelsFromMeters(Convert.ToDouble(coordinatesString.Split(':')[0]));
                this.Y = tablepoint.Y + ratioY.PixelsFromMeters(Convert.ToDouble(coordinatesString.Split(':')[1]));
            }
            else
            {
                throw new Exception("Wrong Coordinates string in json");
            }
        }
        public override string ToString()
        {
            return "A chair with the left corner coordinates: X:" + this.X.ToString() + " Y:" + this.Y.ToString();
        }
        public bool isOccupied;
    }
}
