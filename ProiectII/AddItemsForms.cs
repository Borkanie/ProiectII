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
        private Item SelectedItem;
        private Meniu Menu;
        private Reciept OldReciept;
        private List<Item> ItemList;
        private BindingSource bs = new BindingSource();
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

     

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(SelectedItem!=null)
            {
                SelectedItem.Quantity = Convert.ToInt32(numericUpDown1.Value);
                OldReciept.AddItem(SelectedItem);
                bs.ResetBindings(false);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstReciept.SelectedItem!=null)
            {
                OldReciept.Items.RemoveAt(lstReciept.SelectedIndex);
                bs.ResetBindings(false);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            RestaurantView.FocusTable.Model.Reciept = OldReciept;
            this.Close();
        }

        private void lstReciept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                this.numericUpDown1.Value = OldReciept.Items[lstReciept.SelectedIndex].Quantity;
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers bine!");
            }

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
