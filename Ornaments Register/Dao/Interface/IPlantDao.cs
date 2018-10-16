using Ornaments_Register.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Register.Dao.Interface
{
    interface IPlantDao
    {
        void InsertPlant(Plant plant);
        void UpdatePlant(Plant plant);
        void DeletePlantById(int id);
        Plant GetPlantById(int id);
        List<Plant> GetAll();
        List<Plant> GetAllByType(String type);
    }
}
