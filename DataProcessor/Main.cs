using QsScriptExtentions.SQL;
using QsScriptExtentions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DataProcessor
{

    public enum ValueSelectType
    {
        NamesAndValues,
        Names,
        Values
    }

    public enum CmdType
    {
        [StringValue("select")]
        Select,
        [StringValue("update")]
        Update,
        [StringValue("delete")]
        Delete,
        [StringValue("insert into")]
        Insert
    }

    public static class Connection
    {
        public static object GetType(string type)
        {
            return System.Type.GetType(type);
        }

        public static Dictionary<string, object> ListDictionary(string databaseTable)
        {
            Dictionary<string, object> keyValues = new Dictionary<string, object>();

            var result = Access.LoadData<object>($"select * from [{databaseTable}]");

            return null;
        }

        public static Dictionary<string, object> List(string databaseTable, string[] excludeStrings = null)
        {
            if (databaseTable == null || databaseTable.Length == 0)
                return null;
            return Access.LoadData($"select * from [{databaseTable}]");
        }
        public static List<R> List<R>(string databaseTable, string[] excludeStrings = null)
        {
            if (databaseTable == null || databaseTable.Length == 0)
                return null;
            return Access.LoadData<R>($"select * from [{databaseTable}]");
        }

        public static List<R> List<R, D>(D Data, string databaseTable, string[] excludeStrings = null)
        {
            if (Data == null || databaseTable == null || databaseTable.Length == 0)
                return null;
            return Access.LoadData<R>($"select {Data.GetType().GetProperties().SelectFormatPropertysInfo(excludeStrings)} from {databaseTable}");
        }

        public static R ListOne<R>(string databaseTable, string[] excludeStrings = null)
        {
            return List<R>(databaseTable, excludeStrings)[0];
        }

        public static R ListOne<R, D>(D Data, string databaseTable, string[] excludeStrings = null)
        {
            return List<R, D>(Data, databaseTable, excludeStrings)[0];
        }

        //Update without where possible ?
        public static int Update<D>(D Data, string databaseTable, string[] wheres, string[] wheresValues, string[] excludeStrings = null)
        {
            if (Data == null || databaseTable == null || databaseTable.Length == 0)
                return 0;

            if(wheres != null && wheres.Length > 0)
                return Access.ExecuteDataString(
                    $"update dbo.{databaseTable} set " +
                    $"{Data.GetType().GetProperties().SelectFormatPropertysInfo(excludeStrings)} " +
                    $"{Data.GetType().GetProperties().WhereFormatPropertysInfo(wheres, wheresValues)}");

            return Access.ExecuteDataString(
                $"update dbo.{databaseTable} set " +
                $"{Data.GetType().GetProperties().SelectFormatPropertysInfo(excludeStrings)} ");
        }
        public static int Update<D>(D Data, string databaseTable)
        {
           return Update<D>(Data, databaseTable, null, null, null);
        }

    }

}
