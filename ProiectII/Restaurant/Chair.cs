using Org.BouncyCastle.Asn1.X509;
using ProiectII.Resources;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectII.Restaurant
{
    //View of a chair
    class Chair : PictureBox
    {
      
        private ChairModel model;
        public Chair(ChairModel model) : base()
        {
            this.model = model;
            base.Location = new System.Drawing.Point(model.X, model.Y);
            //base.BackColor = Color.Green;
            base.Height = model.RatioY.PixelsFromMeters(0.5);
            base.Width = model.RatioX.PixelsFromMeters(0.5);
            Bitmap imagine = new Bitmap("Scaun.png");
            imagine.MakeTransparent();
            imagine.MakeTransparent(Color.White);
            base.Image = Util.ResizeBitmap(imagine,this.Width,this.Height);
            
            base.Visible = true;
            this.MouseClick += Chair_MouseClick;

        }

        private void Chair_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You clicked on a Chair:"+model.Id.ToString());
        }

        public bool IsOccupied()
        {
            return this.model.isOccupied;
        }
        public void Occupy()
        {
            this.model.isOccupied = true;
        }
        public void Free()
        {
            this.model.isOccupied = false;
        }
    }
}
