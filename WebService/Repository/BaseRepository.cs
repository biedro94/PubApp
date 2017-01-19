using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Data.Model;
using System.Reflection;
using System.IO;

namespace BaseRepository
{
    public class BaseRepository
    {
        private static readonly string _sConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + bingPathToAppDir("Repository\\DataBase\\Pub.mdf") + ";Integrated Security=True;Connect Timeout=30";

        public static string bingPathToAppDir(string localPath)
        {
            string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            currentDir = currentDir.Remove(0, 6);
            DirectoryInfo directory = new DirectoryInfo(
                Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + localPath)));
            return directory.ToString();
        }

        public static T GetObject<T>(string storedProcedure, object args)
        where T : class, new()
        {
            T result = default(T);

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult.HasValue())
                {
                    result = queryResult.AsEnumerable().FirstOrDefault();
                }
            }
            return result;
        }

        public static List<T> GetCollection<T>(string storedProcedure, object args)
        where T : class, new()
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult.HasValue())
                {
                    result = queryResult.AsEnumerable().ToList<T>();
                }
            }
            return result;
        }

        public static List<T> GetCollection<T>(string storedProcedure)
        where T : class, new()
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, commandType: CommandType.StoredProcedure);

                if (queryResult.HasValue())
                {
                    result = queryResult.AsEnumerable().ToList<T>();
                }
            }
            return result;
        }

        public static T GetScalar<T>(string storedProcedure, object args)
        where T : struct
        {
            T result = default(T);

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult.HasValue())
                {
                    result = queryResult.FirstOrDefault<T>();
                }
            }
            return result;
        }

        public static List<string> GetListOfString(string storedProcedure, object args)
        {
            List<string> result = new List<string>();

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<string>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult.HasValue())
                {
                    result = queryResult.AsEnumerable().ToList<string>();
                }
            }
            return result;
        }

        public static List<T> GetDMLClassesCollection<T>(string query)
        where T : class, new()
        {

            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<T>(query, commandType: CommandType.Text);

                if (queryResult.HasValue())
                {
                    result = queryResult.AsEnumerable<T>().ToList<T>();
                }
            }
            return result;
        }

        public static DMLResult SimpleDML(string storedProcedure, object args)
        {
            DMLResult result = new DMLResult(0, 0, 0);

            using (SqlConnection connection = new SqlConnection(BaseRepository._sConnectionString))
            {

                var queryResult = connection.Query<DMLResult>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult.HasValue())
                {
                    result = queryResult.FirstOrDefault();
                }
            }
            return result;
        }

    }
}