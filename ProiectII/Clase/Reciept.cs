using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectII.Clase
{
    public class Reciept
    {
        public List<Item> Items { get; set; }
        public Reciept()
        {
            Items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            foreach(var itm in Items)
            {
                if(item.IsEqual(itm))
                {
                    itm.Quantity+=item.Quantity;
                    return;
                }
            }
            Items.Add(item);
        }
        public double CloseReciept()
        {
            double total = 0.0;
            foreach(var item in Items)
            {
                total = item.GetValue();
            }
           
            return total;
        }
        public override string ToString()
        {
            string result = "";
            foreach(var item in Items)
            {
                result = result + item + ",";
            }
            return result;
        }
    }
}
