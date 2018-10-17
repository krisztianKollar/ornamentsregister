using Ornaments_Register.Dao.Interface;
using Ornaments_Register.Dao.Simple;
using Ornaments_Register.Models;
using Ornaments_Register.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Register.Service.Simple
{
    class SimplePlantService : IPlantService
    {
        IPlantDao plantDao;

        public SimplePlantService(IConnectionCreater connectionCreater)
        {
            plantDao = new SimplePlantDao(connectionCreater);
        }


        public void DeletePlantById(int id)
        {
            plantDao.DeletePlantById(id);
        }

        public List<Plant> GetAll()
        {
            return plantDao.GetAll();
        }

        public List<Plant> GetAllByType(string type)
        {
            return plantDao.GetAllByType(type);
        }

        public Plant GetPlantById(int id)
        {
            return plantDao.GetPlantById(id);
        }

        public void InsertPlant(Plant plant)
        {
            plantDao.InsertPlant(plant);
        }

        public void UpdatePlant(Plant plant)
        {
            plantDao.UpdatePlant(plant);
        }
    }
}
