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

        public Plant CreatePlant(SqlDataReader reader, SqlCommand command)
        {
            int id = reader.GetInt32(0);
            String genus = reader.GetString(1);
            String species = reader.GetString(2);
            String subspecies = reader.GetString(3);
            String fieldNumber = reader.GetString(4);
            String habitat = reader.GetString(5);
            String synonym = reader.GetString(6);
            String source = reader.GetString(7);
            String replanted = reader.GetString(8);
            String notes = reader.GetString(9);
            String type = reader.GetString(10);
            return new Plant(type, genus, species, subspecies, fieldNumber, habitat, synonym, source, replanted, notes, id);
        }

        public void DeletePlantById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Plant> GetAll()
        {
            List<Plant> plants = new List<Plant>();
            try
            {
                using (SqlConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM plants", conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Plant plant = CreatePlant(reader, command);
                            plants.Add(plant);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
            }
            return plants; 
        }

        public List<Plant> GetAllByType(string type)
        {
            List<Plant> plants = new List<Plant>();
            try
            {
                using (SqlConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM plants WHERE type = @0", conn);
                    command.Parameters.Add(new SqlParameter("0", type));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Plant plant = CreatePlant(reader, command);
                            plants.Add(plant);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
            }
            return plants;
        }

        public Plant GetPlantById(int id)
        {
            Plant plant = null;
            try
            {
                using (SqlConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM plants WHERE id = @0", conn);
                    command.Parameters.Add(new SqlParameter("0", id));
                    using (SqlDataReader reader = command.ExecuteReader())
                    return CreatePlant(reader, command);
                   
                }
            }
            catch (SqlException e)
            {
            }
            return plant;
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
