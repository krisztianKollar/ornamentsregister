using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Register.Models
{
    class Picture
    {
        public int PicID { get; set; }
        public int PlantID { get; set; }
        public Image Image { get; set; }

        public Picture(int picID, int plantID, Image image)
        {
            PicID = picID;
            PlantID = plantID;
            Image = image;
        }

        public Picture(int picID, Image image)
        {
            PicID = picID;
            Image = image;
        }
    }
}

