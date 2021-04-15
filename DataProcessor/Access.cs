using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using System.Configuration;
using System.Reflection;

namespace DataProcessor
{

    public class Access
    {
        private static string _connectionString;

        public static void setConnectionString(string _ConnectionString)
        {
            _connectionString = _ConnectionString;
        }

        public static string GetConnectionString()
        {
            return _connectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        public static Dictionary<string, object> LoadData(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return (Dictionary<string, object>)cnn.Query(sql);
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int UpdateData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int DeleteData<T>(string sql, T data)
        {

            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int ExecuteDataString(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql);
            }
        }

        //public static void something<C>(C ClassType)
        //{
        //    IDbConnection cnn = new SqlConnection(GetConnectionString());
        //    cnn.Open();

        //    var map = new CustomPropertyTypeMap(typeof(C), (type, columnName)
        //      => type.GetProperties().FirstOrDefault(prop => GetDescriptionFromAttribute(prop) == columnName.ToLower()));
        //    Dapper.SqlMapper.SetTypeMap(typeof(C), map);

        //    var sql = "SELECT * FROM Contact_Clients WHERE Contact_Cli_ID = 1234";
        //    var c = db.QueryFirst<Contact>(sql);
        //    Console.WriteLine(c.Nom + " " + c.Prenom);

        //    cnn.Close();
        //    Console.ReadLine();
        //}

        //static string GetDescriptionFromAttribute(MemberInfo member)
        //{
        //    if (member == null) return null;

        //    var attrib = (DescriptionAttribute)Attribute.GetCustomAttribute(member, typeof(DescriptionAttribute), false);
        //    return (attrib?.Description ?? member.Name).ToLower();
        //}
    }
}
