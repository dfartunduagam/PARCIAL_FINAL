using System;
using System.Collections.Generic;
using System.Text;

namespace DATA
{
    public class Asciimage
    {
        public static string[] Load (    String Imgname)
        {
            string filename = "img/" + Imgname + ".png";
            return File.ReadAllLines(filename);
        }
    }
}
