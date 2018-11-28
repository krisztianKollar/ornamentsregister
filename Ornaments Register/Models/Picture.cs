using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Register.Models
{
    class Picture
    {
        public int PicID { get; set; }
        public string PicLocation { get; set; }
        public byte[] Data { get; set; }

        public Picture(int picID, string picLocation, byte[] data)
        {
            PicID = picID;
            PicLocation = picLocation;
            Data = data;
        }

        public Picture(int picID, string picLocation)
        {
            PicID = picID;
            PicLocation = picLocation;
        }

        public Picture(string picLocation, byte[] data) : this(picLocation)
        {
            Data = data;
        }

        public Picture(string picLocation)
        {
            PicLocation = picLocation;
        }

        public override string ToString()
        {
            return "Piclocation = " + this.PicLocation.ToString() + " Data = " + this.Data.ToString();
        }
    }
}

