using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Register.Models
{
    public class Plant
    {
        public string Type { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string Subspecies { get; set; }
        public string FieldNumber { get; set; }
        public string Habitat { get; set; }
        public string Synonym { get; set; }
        public string Source { get; set; }
        public string Replanted { get; set; }
        public string Notes { get; set; }
        public int Id { get; set; }


        public Plant(string type, string genus, string species, int id)
        {
            Type = type;
            Genus = genus;
            Species = species;
            Id = id;
        }

        public Plant(string type, string genus, string species, string subspecies, string fieldNumber, string habitat, string synonym, string source, string replanted, string notes, int id)
        {
            Type = type;
            Genus = genus;
            Species = species;
            Subspecies = subspecies;
            FieldNumber = fieldNumber;
            Habitat = habitat;
            Synonym = synonym;
            Source = source;
            Replanted = replanted;
            Notes = notes;
            Id = id;
        }
    }  
}
