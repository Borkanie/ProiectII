using Newtonsoft.Json.Linq;
using ProiectII.Clase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectII.Restaurant
{
    class TableModel
    {
        public Reciept Reciept { get; set; }
        public ListBox List { get; set; }
        public int Id { get; set; }
        public bool isOccupied = false;
        List<ChairModel> scaune = new List<ChairModel>();
        public Point Location { get; set; }
        public Ratio RatioX { get; set; }
        public Ratio RatioY { get; set; }
        public Point MiddlePoint { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public TableModel(JToken tableTokenJson,Ratio ratioX,Ratio ratioY,int id,ListBox list)
        {
            this.List = list;
            this.Reciept = new Reciept();
            this.Reciept.AddItem(new Item() { ID = 0,Name="Bere",Quantity=19,Price=13.2 });
            this.Id = id;
            this.RatioX = ratioX;
            this.RatioY = ratioY;
            string tablecoordinates = tableTokenJson.ToString().Split('"')[1];

            if (tablecoordinates.Split(':').Length > 1)
            {
                this.Location=new Point(ratioX.PixelsFromMeters(Convert.ToDouble(tablecoordinates.Split(':')[1])), ratioY.PixelsFromMeters(Convert.ToDouble(tablecoordinates.Split(':')[0])));
                this.Height = this.RatioY.PixelsFromMeters(0.5);
                this.Width = this.RatioX.PixelsFromMeters(0.5);
                MiddlePoint = new Point(this.Location.X + this.Width / 4, this.Location.Y + this.Height / 4);
                int i = 1;
                foreach (var chairToken in tableTokenJson.Children().Children<JToken>())
                {
                    ChairModel chair = new ChairModel(chairToken.ToString(),this.MiddlePoint,ratioX,ratioY,i++);
                    scaune.Add(chair);
                }
            }
            else
            {
                throw new Exception("The table needs coordinates aswell");
            }
        }
        public override string ToString()
        {
            return "Table with coordinates: X:" + this.MiddlePoint.X.ToString() + " Y:" + this.MiddlePoint.Y.ToString();
        }
        public List<ChairModel> GetChairslist()
        {
            return this.scaune;
        }
    }
}
