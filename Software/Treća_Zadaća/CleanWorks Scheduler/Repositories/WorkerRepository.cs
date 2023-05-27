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
    {   /*summary GetWorker
         * Ova metoda dohvaća radnika iz baze podataka na temelju njegovog identifikacijskog broja (ID). Prvo se stvara varijabla "worker" koja je inicijalno postavljena na null. Zatim se konstruira SQL upit koji traži retke iz tablice "Workers" koji imaju odgovarajući ID. Nakon toga se otvara veza s bazom podataka, izvršava upit i dobiva se SqlDataReader objekt koji sadrži rezultate upita. Ako SqlDataReader ima redove (HasRows), čita se prvi red, stvara se objekt radnika pomoću metode CreateObject i dodjeljuje se varijabli "worker". Na kraju se zatvara SqlDataReader, zatvara se veza s bazom podataka i vraća se objekt radnika.
         */
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
        /*summary GetWorkers
         * Ova metoda dohvaća sve radnike iz baze podataka. Prvo se stvara prazna lista "workers" za pohranjivanje radnika. Zatim se konstruira SQL upit koji dohvaća sve retke iz tablice "Workers". Nakon toga se otvara veza s bazom podataka, izvršava upit i dobiva se SqlDataReader objekt koji sadrži rezultate upita. U petlji se čita svaki red SqlDataReader-a, stvara se objekt radnika pomoću metode CreateObject i dodaje se u listu "workers". Nakon što su svi radnici dohvaćeni, SqlDataReader se zatvara, veza s bazom podataka se zatvara i vraća se lista radnika.
         */
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
        /*summary GetWorkersByName
         * Ova metoda dohvaća radnike iz baze podataka koji se podudaraju s imenom ili prezimenom. Izvršava se SQL upit koji traži retke iz tablice "Workers" gdje je Ime jednak zadanim imenom ili Prezime jednak zadanim prezimenom. Stvara se prazna lista "workers" za pohranjivanje radnika. Otvara se veza s bazom podataka, izvršava se upit i dobiva se SqlDataReader objekt s rezultatima. U petlji se čita svaki red SqlDataReader-a, stvara se objekt radnika pomoću metode CreateObject i dodaje se u listu "workers". Nakon čitanja svih radnika, SqlDataReader se zatvara, veza s bazom podataka se zatvara i vraća se lista radnika.
         */
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
        /*summary CreateObject
         * Ova metoda stvara objekt radnika na temelju podataka dobivenih iz SqlDataReader objekta. Iz SqlDataReader-a se čitaju vrijednosti za svako polje radnika (Id, Ime, Prezime, Adresa, Mail, OIB, Broj_mobitela, Sifra). Te vrijednosti se zatim koriste za inicijalizaciju svojstava objekta radnika. Nakon inicijalizacije, objekt radnika se vraća kao rezultat metode.
         */
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
        public static void UpdateWorker(Worker worker)
        {
            string sql = $"UPDATE Workers SET Ime='{worker.FirstName}', Prezime='{worker.LastName}', Adresa='{worker.Adress}', Mail='{worker.MailWorker}', OIB='{worker.OIB}', Broj_mobitela='{worker.PhoneNumber}', Sifra='{worker.Password}' WHERE Id={worker.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
