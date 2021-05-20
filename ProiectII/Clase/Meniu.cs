using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectII.Clase
{
    public class Meniu
    {
        SortedList<int, Item> Items { get; set; }
        private string Path;
        public Meniu(string path)
        {
            this.Path = path;
            Items = new SortedList<int, Item>();
        }
        public void AddItem(Item item)
        {
            if (item.Image == null)
                item.AddImage(this.Path + "//" + item.Name + ".jpg");
            this.Items.Add(item.ID, item);
        }
        public void RemoveItem(Item item)
        {
            this.Items.Remove(item.ID);
        }
        public void RemoveId(int id)
        {
            this.Items.Remove(id);
        }
        public SortedList<int,Item> GetItems()
        {
            return this.Items;
        }
    }
}
