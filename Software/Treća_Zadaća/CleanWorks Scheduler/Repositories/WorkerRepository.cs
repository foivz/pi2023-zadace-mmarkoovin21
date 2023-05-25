using CleanWorks_Scheduler.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace CleanWorks_Scheduler.Repositories
{
    public class WorkerRepository
    {
        public static Worker GetWorker(int id)
        {
            Worker worker = null;
            string sql = $"SELECT * FROM Workers WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                worker = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return worker;
        }

        public static List<Worker> GetWorkers()
        {
            List<Worker> workers = new List<Worker>();
            string sql = "SELECT * FROM Workers";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Worker worker = CreateObject(reader);
                workers.Add(worker);
            }
            reader.Close();
            DB.CloseConnection();
            return workers;
        }
        public static List<Worker> GetWorkerByName(string name, string surname)
        {
            string sql = $"SELECT * FROM Workers WHERE Ime='{name}' OR Prezime='{surname}'";
            List <Worker> workers = new List<Worker>();
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Worker worker = CreateObject(reader);
                workers.Add(worker);
            }
            reader.Close();
            DB.CloseConnection();
            return workers;
        }
        private static Worker CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();
            string adresa = reader["Adresa"].ToString();
            string mail = reader["Mail"].ToString();
            string oib = reader["OIB"].ToString();
            string broj = reader["Broj_mobitela"].ToString();
            int sifra = int.Parse(reader["Sifra"].ToString());
            var worker = new Worker
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Adress = adresa,
                MailWorker = mail,
                OIB = oib,
                PhoneNumber = broj,
                Password = sifra
            };
            return worker;
        }

    }
}
