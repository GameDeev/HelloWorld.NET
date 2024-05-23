// using System;
// using System.Data;
// using System.Text.RegularExpressions;
// using Dapper;
// using Microsoft.Data.SqlClient;

// namespace HelloWorld
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
//             IDbConnection dbConnection= new SqlConnection(connectionString);
//             string sqlCommand = "SELECT GETDATE()";
//             DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
//             Console.WriteLine(rightNow);
//         }

//     }
// }