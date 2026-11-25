using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DATA
{
    public class Asciimage
    {
        public static Bitmap Load (    String Imgname)
        {
            string rutaImagen = @"C:\Imagenes\"+Imgname+".jpg";
            Bitmap miBitmap = new Bitmap(rutaImagen);
            return miBitmap;
        }
    }
}
