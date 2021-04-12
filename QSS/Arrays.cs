using System;
using System.Linq;
using System.Reflection;

namespace QSS.Array
{
    /// <summary>
    /// This class contains helper functions for arrays
    /// some might be outdated or can be made better, ow well..
    /// </summary>
    public static class Arrays
    {
        public static bool[] ContainsArray(this string[] arrayA, string[] arrayB)
        {
            bool[] returnArray = new bool[arrayA.Length];

            for (int a = 0; a < arrayA.Length; a++)
            {
                returnArray[a] = arrayB.Contains(arrayA[a]);
            }
            return returnArray;
        }

        public static bool[] ContainsArray(this PropertyInfo[] sourceArray, string[] lookForArray)
        {
            bool[] returnArray = new bool[lookForArray.Length];

            for (int a = 0; a < lookForArray.Length; a++)
            {
                returnArray[a] = lookForArray.Contains(sourceArray[a].Name);
            }
            return returnArray;
        }

    }



}
