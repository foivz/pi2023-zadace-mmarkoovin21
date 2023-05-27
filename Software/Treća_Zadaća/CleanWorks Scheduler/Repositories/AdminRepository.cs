using CleanWorks_Scheduler.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanWorks_Scheduler.Repositories
{
    public class AdminRepository
    {
        public static Admin GetAdmin(string username)
        {
            string sql = $"SELECT * FROM Admins WHERE Username = '{username}'";
            return FetchAdmin(sql);


        }
        public static Admin GetAdmin(int id)
        {
            string sql = $"SELECT * FROM Admins WHERE Id = {id}";
            return FetchAdmin(sql);
        }
        private static Admin FetchAdmin(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Admin admin = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                admin = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return admin;
        }
        private static Admin CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var admin = new Admin
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            return admin;
        }

    }
}
