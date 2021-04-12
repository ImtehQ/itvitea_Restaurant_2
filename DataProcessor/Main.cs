using QSS.sqls;
using QSS.Attributes;
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

        public static List<R> ListT<R,D>(D Data, string databaseTable, string[] excludeStrings = null)
        {
            if (Data == null || databaseTable == null || databaseTable.Length == 0)
                return null;
            return Access.LoadData<R>($"from dbo.select {SQLs.FormatString(Data.GetType().GetProperties(), excludeStrings)}");
        }

        public static R One<R, D>(D Data, string databaseTable, string[] excludeStrings = null)
        {
            return ListT<R, D>(Data, databaseTable, excludeStrings)[0];
        }

        public static int Update<D>(D Data, string databaseTable, string[] wheres, string[] wheresValues, string[] excludeStrings = null)
        {
            if (Data == null || databaseTable == null || databaseTable.Length == 0)
                return 0;


            return Access.ExecuteDataString($"update dbo.{databaseTable} set " +
                $"{SQLs.FormatString(Data.GetType().GetProperties(), excludeStrings)} " +
                $"{SQLs.WhereFormat(Data.GetType().GetProperties(), wheres, wheresValues)}");
        }
    }

}
