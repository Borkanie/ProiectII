using ProiectII.Resources;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectII.Restaurant
{
    //interfata pentru mese
    class Table : PictureBox
    {
        //lista de imagini de scaune
        List<Chair> Chairs = new List<Chair>();
        public TableModel Model { get; set; }
        public Table(TableModel model) : base()
        {
            this.Model = model;
            foreach (var chair in model.GetChairslist())
            {
                Chairs.Add(new Chair(chair));
            }
            base.Location = model.Location;

            base.Height = model.Height;
            base.Width = model.Width;
            Bitmap imagine = new Bitmap("Table.jpg");
            imagine.MakeTransparent();
            imagine.MakeTransparent(Color.White);
            base.Image = Util.ResizeBitmap(imagine, this.Width, this.Height);
            base.Visible = true;
            this.MouseClick += Table_MouseClick;
            
        }
        private void Table_MouseClick(object sender, MouseEventArgs e)
        {
            Model.List.Items.Clear();
            foreach (var item in  Model.Reciept.Items)
            {
                Model.List.Items.Add(item);
            }
            RestaurantView.FocusTable = this;
        }
        public List<Chair> GetChairs()
        {
            return this.Chairs;
        }
        public bool IsOccupied()
        {
            return this.Model.isOccupied;
        }
        public void Occupy()
        {
            this.Model.isOccupied = true;
        }
        public void Free()
        {
            this.Model.isOccupied = false;
        }
    }
}
