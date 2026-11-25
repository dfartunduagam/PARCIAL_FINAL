using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DATA
{
    public class Asciimage
    {
        public static Bitmap Load (String Imgname)
        {
            string rutaImagen = @"C:\Users\Estudiantes.LABING412-11\source\repos\PARCIAL_FINAL\DATA\img\"+Imgname+".png";
            Bitmap miBitmap = new Bitmap(rutaImagen);
            return miBitmap;
        }
    }
}
