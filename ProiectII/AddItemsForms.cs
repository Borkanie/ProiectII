using ProiectII.Clase;
using ProiectII.Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectII
{
    public partial class AddItemsForms : Form
    {
        //item selectat din lista de iteme
        private Item SelectedItem;
        //meniul restaurantului
        private Meniu Menu;
        //bonul inainte de schimbare
        private Reciept OldReciept;
        //lista de iteme din bon
        private List<Item> ItemList;
        private BindingSource bs = new BindingSource();
        //adaugam toate itemele de pe meniu in interfata si incarcam datele de pe bon in listBox
        public AddItemsForms(Meniu menu,Reciept reciept)
        {
            ItemList = new List<Item>();
            OldReciept = reciept;
            this.Width = 600;
            this.Height = 400;
            InitializeComponent();
            this.Menu = menu;
            this.GenerateMenu();           
        }
        //generam itemele din meniu si le legam cu pozele aferente
        public void GenerateMenu()
        {
            bs.DataSource = OldReciept.Items;
            lstReciept.DataSource = bs;
            lstItems.LargeImageList = lstImages;
            lstItems.LargeImageList.ImageSize = Resources.Constants.ItemPicture();  
            foreach(var Item in Menu.GetItems())
            {
                ListViewItem uiItem = new ListViewItem();
                uiItem.Text = Item.Value.Name;
                Icon icon = Icon.FromHandle(Item.Value.Image.GetHicon());
                lstImages.Images.Add(Item.Value.Name, icon);
                uiItem.ImageKey = Item.Value.Name;
                lstItems.Items.Add(uiItem);
                ItemList.Add(Item.Value);
            }      
        }
        //adaugam iteme in bon
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(SelectedItem!=null)
            {
                SelectedItem.Quantity = Convert.ToInt32(numericUpDown1.Value);
                OldReciept.AddItem(SelectedItem);
                bs.ResetBindings(false);
            }
        }
        //stergem itemele din bon
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstReciept.SelectedItem!=null)
            {
                OldReciept.Items.RemoveAt(lstReciept.SelectedIndex);
                bs.ResetBindings(false);
            }
        }
        //salvam modificarile din bon
        private void btnDone_Click(object sender, EventArgs e)
        {
            RestaurantView.FocusTable.Model.Reciept = OldReciept;
            this.Close();
        }
        //schimbam cantitatea din numericUpDown
        private void lstReciept_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numericUpDown1.Value = OldReciept.Items[lstReciept.SelectedIndex].Quantity;
        }
        
        private void lstItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstItems.SelectedIndices.Count > 0)
                SelectedItem = ItemList[lstItems.SelectedIndices[0]];
            else
                SelectedItem = null;
            numericUpDown1.Value = 1;
        }
    }
}
