using CleanWorks_Scheduler.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBLayer;
using System.Data.SqlClient;

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
            var reader = DB.GetDataReader(sql);
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
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string mail = reader["MailWorker"].ToString();
            var worker = new Worker
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                MailWorker = mail
            };
            return worker;
        }
        private void ShowStudents()
        {
            List<Worker> workers = WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;
        }

    }
}
