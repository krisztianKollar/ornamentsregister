using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornaments_Register.Dao.Interface;
using Ornaments_Register.Service.Interface;
using Ornaments_Register.Models;
using System.Data.SqlClient;

namespace Ornaments_Register.Dao.Simple
{
    class SimplePlantDao : IPlantDao
    {
        private IConnectionCreater ConnectionCreater;

        public SimplePlantDao(IConnectionCreater connectionCreater)
        {
            this.ConnectionCreater = connectionCreater;
        }

        public void DeletePlantById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Plant> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Plant> GetAllByType(string type)
        {
            throw new NotImplementedException();
        }

        public Plant GetPlantById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertPlant(Plant plant)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlant(Plant plant)
        {
            throw new NotImplementedException();
        }
    }
}
