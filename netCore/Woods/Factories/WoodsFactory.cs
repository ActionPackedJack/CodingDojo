using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using Woods.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
//using Woods.Factories;
 
namespace DapperApp.Factory
{
    public class WoodsFactory
    {
        private string connectionString;
        public object ViewBag { get; }
        public List<Trail> AllTrails;
        public WoodsFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=woods;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
            public void Add(Trail item)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO woods (Name, Length, Elevation) VALUES (@Name, @Length, @Elevation)";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }
        public IEnumerable<Trail> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM woods");
            }
        }
        public Trail FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM woods WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
        public IEnumerable<Trail> all()
        {
            System.Console.WriteLine("CONNECTION IS" + Connection);
            using (IDbConnection dbConnection = Connection){
            string query = "SELECT * from woods";
            dbConnection.Open();
            AllTrails= dbConnection.Query<Trail>("SELECT * FROM woods").ToList();
            System.Console.WriteLine(AllTrails);
            return dbConnection.Query<Trail>("SELECT * FROM woods");
            //List<Trail>these = (List<Trail>) dbConnection.Query(query);
            //return these;
            }
            // public List <Trail> TrailList= new List<Trail>();
            // foreach (var trails in all)
            // {
            //     TrailList.Add(trails);
            // }
            
        }
    }
}