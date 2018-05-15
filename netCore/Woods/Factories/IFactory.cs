// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Linq;
// using Woods.Models;
// using MySql.Data.MySqlClient;
// using Dapper;

// namespace Woods.Factories 
// {
//     public class TrailFactory
//     {
//         string Server = "localhost";
//         string Port = "8889";
//         string Database = "mydb";
//         string UserId = "root";
//         string Password = "root";
    
//     internal IDbConnection Connection
//     {
//         get{
//             return new MySqlConnection($"Server={Server};Port={Port};Database={Database};");
//         }
//     }
// }
 
// namespace DapperApp.Factory
// {
//     public interface IFactory<T> where T: IFactory<Trail>
//     {
//         private string connectionString;
//         public UserFactory()
//         {
//             connectionString = "server=localhost;userid=root;password=root;port=8889;database=mydb;SslMode=None";
//         }
//         internal IDbConnection Connection
//         {
//             get {
//                 return new MySqlConnection(connectionString);
//             }
//         }
//     }
// }
// }