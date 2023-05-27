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
        /*summary GetAdmin(string username)
         * Ova metoda dohvaća podatke o administratoru iz baze podataka na temelju korisničkog imena. Koristi se SQL upit koji traži redak u tablici "Admins" koji ima zadano korisničko ime. Nakon toga se poziva metoda FetchAdmin s SQL upitom kao argumentom koja izvršava upit, dohvaća podatke iz SqlDataReader objekta i kreira objekt administratora na temelju tih podataka. Na kraju se vraća objekt administratora kao rezultat metode.
         */
        public static Admin GetAdmin(string username)
        {
            string sql = $"SELECT * FROM Admins WHERE Username = '{username}'";
            return FetchAdmin(sql);


        }
        /*summary GetAdmin(int id)
         * Ova metoda dohvaća podatke o administratoru iz baze podataka na temelju ID-a. Koristi se SQL upit koji traži redak u tablici "Admins" koji ima zadani ID. Nakon toga se poziva metoda FetchAdmin s SQL upitom kao argumentom koja izvršava upit, dohvaća podatke iz SqlDataReader objekta i kreira objekt administratora na temelju tih podataka. Na kraju se vraća objekt administratora kao rezultat metode.
         */
        public static Admin GetAdmin(int id)
        {
            string sql = $"SELECT * FROM Admins WHERE Id = {id}";
            return FetchAdmin(sql);
        }
        /*summary GetAdmin
         * Ova metoda dohvaća podatke o administratoru iz baze podataka na temelju ID-a. Koristi se SQL upit koji traži redak u tablici "Admins" koji ima zadani ID. Nakon toga se poziva metoda FetchAdmin s SQL upitom kao argumentom koja izvršava upit, dohvaća podatke iz SqlDataReader objekta i kreira objekt administratora na temelju tih podataka. Na kraju se vraća objekt administratora kao rezultat metode.
         */
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
        /*summary CreateObject
         * Ova metoda kreira objekt administratora na temelju podataka koji su pročitani iz SqlDataReader objekta. Metoda čita vrijednosti iz SqlDataReader objekta za svako polje administratora (Id, Ime, Prezime, Username, Password) i pridružuje ih odgovarajućim svojstvima objekta admin. Nakon toga, stvara se objekt admin koristeći očitane vrijednosti, te se vraća kao rezultat metode.
         */
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
