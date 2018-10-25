using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

        public Plant CreatePlant(SQLiteDataReader reader, SQLiteCommand command)
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
                using (SQLiteConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM plants", conn);
                    using (SQLiteDataReader reader = command.ExecuteReader())
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
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return plants; 
        }

        public List<Plant> GetAllByType(string type)
        {
            List<Plant> plants = new List<Plant>();
            try
            {
                using (SQLiteConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM plants WHERE type = @0", conn);
                    command.Parameters.Add(new SqlParameter("0", type));
                    using (SQLiteDataReader reader = command.ExecuteReader())
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
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return plants;
        }

        public Plant GetPlantById(int id)
        {
            Plant plant = null;
            try
            {
                using (SQLiteConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM plants WHERE id = @0", conn);
                    command.Parameters.Add(new SqlParameter("0", id));
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    return CreatePlant(reader, command);
                   
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return plant;
        }

        public void InsertPlant(Plant plant)
        {
            try
            {
                using (SQLiteConnection conn = ConnectionCreater.connect())
                {
                    conn.Open();
                    string sql = "INSERT INTO plants (Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type)" +
                        " VALUES (@genus, @species, @subspecies, @fieldnumber, @habitat, @synonym, @source, @replanted, @notes, @type)";
                    SQLiteCommand insertCommand = new SQLiteCommand(sql, conn);

                    insertCommand.Parameters.Add(new SqlParameter("genus", plant.Genus));
                    insertCommand.Parameters.Add(new SqlParameter("species", plant.Species));
                    insertCommand.Parameters.Add(new SqlParameter("subspecies", plant.Subspecies));
                    insertCommand.Parameters.Add(new SqlParameter("fieldnumber", plant.FieldNumber));
                    insertCommand.Parameters.Add(new SqlParameter("habitat", plant.Habitat));
                    insertCommand.Parameters.Add(new SqlParameter("synonym", plant.Synonym));
                    insertCommand.Parameters.Add(new SqlParameter("source", plant.Source));
                    insertCommand.Parameters.Add(new SqlParameter("replanted", plant.Replanted));
                    insertCommand.Parameters.Add(new SqlParameter("notes", plant.Notes));
                    insertCommand.Parameters.Add(new SqlParameter("type", plant.Type));
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            };
        }

        public void UpdatePlant(Plant plant)
        {
            throw new NotImplementedException();
        }
    }
}
