using Newtonsoft.Json.Linq;
using System;
using System.Drawing;

namespace ProiectII.Clase
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Bitmap Image { get; set; }
        public Item() { }
        public Item(JToken jToken)
        {
            this.ID = Convert.ToInt32(jToken["ID"]);
            this.Name = jToken["Name"].ToString();
            this.Price = Convert.ToDouble(jToken["Price"]);
        }
        public bool IsEqual(Item target)
        {
            return this.ID == target.ID;
        }
        public double GetValue()
        {
            return this.Price * Convert.ToDouble(this.Quantity);
        }
        public override string ToString()
        {
            return this.Name+"  Quantity:"+this.Quantity.ToString()+"   Price:"+this.Price.ToString();
        }

        public void AddImage(string path)
        {
            try
            {
                Image = new Bitmap(path);
                Image = new Bitmap(Image, Resources.Constants.ItemPicture());
            }
            catch (Exception ex)
            { }
        }
    }
}
