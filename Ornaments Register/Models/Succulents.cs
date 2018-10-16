using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Register.Models
{
    class Succulents : Plant
    {
        public Succulents(string type, string genus, string species, int id) : base(type, genus, species, id)
        {
            this.Type = "succulent";

        }

        public Succulents(string type, string genus, string species, string subspecies, string fieldNumber, string habitat, string synonym, string source, string replanted, string notes, int id) : base(type, genus, species, subspecies, fieldNumber, habitat, synonym, source, replanted, notes, id)
        {
            this.Type = "succulent";
        }


    }
}
