using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectII.Resources
{
    static public class Util
    {
        static public string GetDirectoryOfFile(string path)
        {
            string directory = "";
            string[] elements = path.Split('/');
            if(elements.Length<2)
                elements=path.Split('\\');
            for(int i=0;i<elements.Length-1;i++)
            {
                directory = directory + elements[i] + '\\';
            }
            return directory;
        }
        static public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
    }
}
