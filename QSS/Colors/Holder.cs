using System;
using System.Collections.Generic;
using System.Text;

namespace QsScriptExtentions.Colors
{
    /// <summary>
    /// Holds a Dictionary of colors
    /// </summary>
    public class ColorHolder
    {
        private Color nullColor;
        private Color holderColor;

        public Dictionary<string, Color> Collection =
            new Dictionary<string, Color>();

        private int countLimit;
        public int Limit
        {
            get { return countLimit; }
            set { countLimit = value; }
        }

        public ColorHolder(int limit = 1000)
        {
            countLimit = limit;

            nullColor = Color.black;
            holderColor = Color.black;
        }

        public bool IsNull()
        {
            if (Collection.Count > 0)
                return false;
            return true;
        }

        /// <summary>
        /// Adds a color to the Dictionary where key will be color number
        /// </summary>
        /// <param name="color"></param>
        public void Add(ref Color color)
        {
            try
            {
                Collection.Add(Helper.ToInt32(color).ToString(), color);
            }
            catch (System.ArgumentException)
            {
                //Debug.LogErrorFormat("Add: An element with Key = {0} already exists.", ColorAssist.ToInt32(color).ToString());
            }
        }
        /// <summary>
        /// Adds a color to the Dictionary where key will be color number
        /// </summary>
        /// <param name="color"></param>
        public void Add(Color color)
        {
            try
            {
                Collection.Add(Helper.ToInt32(color).ToString(), color);
            }
            catch (System.ArgumentException)
            {
                //Debug.LogErrorFormat("Add: An element with Key = {0} already exists.", ColorAssist.ToInt32(color).ToString());
            }
        }

        /// <summary>
        /// Add a color to the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="color"></param>
        public void Add(ref string key, ref Color color)
        {
            if (Collection.Count + 1 > countLimit)
            {
                //Debug.LogError("Add exceeds maximum count of the set");
            }
            try
            {
                Collection.Add(key, color);
            }
            catch (System.ArgumentException)
            {
                //Debug.LogErrorFormat("Add: An element with Key = {0} already exists.", key);
            }
        }

        /// <summary>
        /// Add a color to the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="color"></param>
        public void Add(string key, Color color)
        {
            try
            {
                Collection.Add(key, color);
            }
            catch (System.ArgumentException)
            {
                //Debug.LogErrorFormat("Add: An element with Key = {0} already exists.", key);
            }
        }

        /// <summary>
        /// Adds a color array to the Dictionary
        /// </summary>
        /// <param name="colors"></param>
        public void Add(ref Color[] colors)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                Add(colors[i].ToUInt32().ToString(), colors[i]);
            }
        }

        /// <summary>
        /// Adds a list of colors to the Dictionary
        /// </summary>
        /// <param name="Count"></param>
        public void Add(ref int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Add(i.ToString(), Helper.ToColor((float)i));
            }
        }
        /// <summary>
        /// Adds a list of colors to the Dictionary
        /// </summary>
        /// <param name="Count"></param>
        public void Add(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Add(i.ToString(), Helper.ToColor((float)i));
            }
        }
        /// <summary>
        /// Gets a color from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Color Get(ref string key)
        {
            try
            {
                return Collection[key];
            }
            catch (KeyNotFoundException)
            {
                //Debug.LogErrorFormat("Get: An element with Key = {0} does not exists.", key);
                return nullColor;
            }
        }
        /// <summary>
        /// Gets a color from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Color Get(string key)
        {
            try
            {
                return Collection[key];
            }
            catch (KeyNotFoundException)
            {
                //Debug.LogErrorFormat("Get: An element with Key = {0} does not exists.", key);
                return nullColor;
            }
        }

        /// <summary>
        /// Trys to get a color from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Color TryGet(ref string key)
        {

            if (Collection.TryGetValue(key, out holderColor))
            {
                return holderColor;
            }
            else
            {
                //Debug.LogErrorFormat("TryGet: An element with Key = {0} is not found.", key);
                return nullColor;
            }
        }
        /// <summary>
        /// Trys to get a color from the Dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Color TryGet(string key)
        {

            if (Collection.TryGetValue(key, out holderColor))
            {
                return holderColor;
            }
            else
            {
                //Debug.LogErrorFormat("TryGet: An element with Key = {0} is not found.", key);
                return nullColor;
            }
        }

        /// <summary>
        /// Set a colors value directly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public void Set(ref string key, ref int r, ref int g, ref int b, ref int a)
        {
            holderColor = Collection[key];
            holderColor.r = r; holderColor.g = g; holderColor.b = b; holderColor.a = a;
        }
        /// <summary>
        /// Set a colors value directly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public void Set(ref string key, int r, int g, int b, int a)
        {
            holderColor = Collection[key];
            holderColor.r = r; holderColor.g = g; holderColor.b = b; holderColor.a = a;
        }
        /// <summary>
        /// Set a colors value directly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public void Set(string key, int r, int g, int b, int a)
        {
            holderColor = Collection[key];
            holderColor.r = r; holderColor.g = g; holderColor.b = b; holderColor.a = a;
        }

        /// <summary>
        /// Try to set a colors value directly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public void TrySet(ref string key, ref int r, ref int g, ref int b, ref int a)
        {
            if (Collection.TryGetValue(key, out holderColor))
            {
                holderColor.r = r; holderColor.g = g; holderColor.b = b; holderColor.a = a;
            }
            else
            {
                //Debug.LogErrorFormat("TrySet: An element with Key = {0} is not found.", key);
            }
        }
        /// <summary>
        /// Try to set a colors value directly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public void TrySet(ref string key, int r, int g, int b, int a)
        {
            if (Collection.TryGetValue(key, out holderColor))
            {
                holderColor.r = r; holderColor.g = g; holderColor.b = b; holderColor.a = a;
            }
            else
            {
                //Debug.LogErrorFormat("TrySet: An element with Key = {0} is not found.", key);
            }
        }
        /// <summary>
        /// Try to set a colors value directly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public void TrySet(string key, int r, int g, int b, int a)
        {
            if (Collection.TryGetValue(key, out holderColor))
            {
                holderColor.r = r; holderColor.g = g; holderColor.b = b; holderColor.a = a;
            }
            else
            {
                //Debug.LogErrorFormat("TrySet: An element with Key = {0} is not found.", key);
            }
        }

        /// <summary>
        /// Removes the 
        /// </summary>
        /// <param name="key"></param>
        public void Remove(ref string key)
        {
            Collection.Remove(key);
        }
        /// <summary>
        /// Removes the 
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            Collection.Remove(key);
        }
    }
}
