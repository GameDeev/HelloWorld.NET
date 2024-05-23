// using System;
// using System.Data;
// using System.Text.RegularExpressions;
// using Dapper;
// using HelloWorld.Models;
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
//             // Console.WriteLine(rightNow);

//             Computer myComputer =new Computer()
//             {
//                 Motherboard = "Z690",
//                 HasWifi = true,
//                 HasLTE = false,
//                 ReleaseDate = DateTime.Now,
//                 Price = 943.86m,
//                 VideoCard = "RTX 2060"
//             };
//             string sql = @"INSERT INTO TutorialAppSchema.Computer
//             (
//                 Motherboard,
//                 HasWifi,
//                 HasLTE,
//                 ReleaseDate,
//                 Price,
//                 VideoCard
//             ) VALUES ('"+myComputer.Motherboard
//                     +"','"+myComputer.HasWifi
//                     +"','"+myComputer.HasLTE
//                     +"','"+myComputer.ReleaseDate
//                     +"','"+myComputer.Price
//                     +"','"+myComputer.VideoCard

//             + "')";
//             // Console.WriteLine(sql);
//             int result =dbConnection.Execute(sql);
//             // Console.WriteLine(result);

//             string sqlSelect = @"SELECT Motherboard,
//                 HasWifi,
//                 HasLTE,
//                 ReleaseDate,
//                 Price,
//                 VideoCard 
//                 From TutorialAppSchema.Computer";
//             IEnumerable<Computer> computers = dbConnection.Query<Computer>(sqlSelect);
 
 
//             Console.WriteLine("'Motherboard','HasWifi,'HasLTE,'"
//                 +"'ReleaseDate,'Price,'VideoCard'");
//             foreach(Computer singleComputer in computers)
//             {   
//               Console.WriteLine(
//                      "','"+myComputer.Motherboard
//                     +"','"+myComputer.HasWifi
//                     +"','"+myComputer.HasLTE
//                     +"','"+myComputer.ReleaseDate
//                     +"','"+myComputer.Price
//                     +"','"+myComputer.VideoCard
//                     );
              
//             }

//         }

//     }
// }