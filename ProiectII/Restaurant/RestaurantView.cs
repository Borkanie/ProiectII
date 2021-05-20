using ProiectII.Clase;
using ProiectII.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ProiectII.Restaurant
{
    //View of the restaurant
    //aici reprezentam scaunele si mesele la scara
    class RestaurantView : Panel
    {
        //este ultima masa pe care am aleso
        static public Table FocusTable { get; set; }
        //lista de mese
        List<Table> tables = new List<Table>();
        //ratia pe latime
        Ratio ratioXAxis=new Ratio();
        //ratia pe inaltime
        Ratio ratioYAxis = new Ratio();
        //constructor
        public RestaurantView(double totalHeight, double totalWidth,Size size,string restaurant) :base()
        {
            ratioXAxis.Meters = totalWidth;
            ratioXAxis.Pixels = size.Width*7/10;
            ratioYAxis.Meters = totalHeight;
            ratioYAxis.Pixels = size.Height*9/10;
            base.Width = ratioXAxis.PixelsFromMeters(ratioXAxis.Meters);
            base.Height = ratioYAxis.PixelsFromMeters(ratioYAxis.Meters);
            Bitmap imagine = new Bitmap(restaurant+"\\"+ restaurant+".png");
            base.BackgroundImage = Util.ResizeBitmap(imagine, this.Width, this.Height);
            base.Location = new Point(10, 10);
            base.Show();
        }
        public Ratio GetXRatio()
        {
            return ratioXAxis;
        }
        public Ratio GetYRatio()
        {
            return ratioYAxis;
        }
        public List<Table> GetTables()
        {
            return this.tables;
        }
        public void SetTables(List<Table> list)
        {
            this.tables = list;
        }
        //adaugam o masa in lista
        //scaunele sunt in interiorul mesei sub forma de lista
        public void AddTable(Table table)
        {
            tables.Add(table);
            this.Controls.Add(table);
            foreach(var chair in table.GetChairs())
            {
                this.Controls.Add(chair);
            }
            table.Show();
        }
       
       
    }
}
