using System;
using System.Collections.Generic;
using System.Text;

namespace QsScriptExtentions.Colors
{
    public static class Helper
    {
        /// <summary>
        /// Creates a random color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Color Random(this Color color)
        {
            Random R = new Random();
            return new Color(R.NextDouble(), R.NextDouble(), R.NextDouble());
        }

        /// <summary>
        /// Converts a float to colour, basec on channel
        /// </summary>
        /// <param name="value"></param>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static Color ToColor(this float value, ColorAssistChannel channel, bool alphaBlack = false)
        {
            if (channel == ColorAssistChannel.Red)
                return new Color(value, 0, 0, 1);
            else if (channel == ColorAssistChannel.Blue)
                return new Color(0, value, 0, 1);
            else if (channel == ColorAssistChannel.Green)
                return new Color(0, 0, value, 1);
            else if (channel == ColorAssistChannel.Alpha && alphaBlack)
                return new Color(0, 0, 0, value);
            else if (channel == ColorAssistChannel.Alpha)
                return new Color(1, 1, 1, value);
            return Color.black;
        }

        /// <summary>
        /// Creates a array of colors based on given perameters
        /// </summary>
        /// <param name="count"></param>
        /// <param name="minRange"></param>
        /// <param name="maxRange"></param>
        /// <param name="channel"></param>
        /// <param name="alphaBlack"></param>
        /// <returns></returns>
        public static Color[] ToColorArray(byte count, byte minRange, byte maxRange, ColorAssistChannel channel, bool alphaBlack = false)
        {
            if (maxRange <= minRange)
            {
                //Debug.LogErrorFormat("maxRange of {0} is smaller or equal to minRange of {1}", maxRange, minRange);
                return null;
            }
            Color[] colors = new Color[count];

            float value = (maxRange - minRange) / count;

            for (int i = 0; i < count; i++)
            {
                value *= i;
                value /= 256;
                colors[i] = value.ToColor(channel, alphaBlack);
            }
            return colors;
        }

        /// <summary>
        /// Creates a color basec of given values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Color ToColor(this float first, float second)
        {
            return new Color(first, second, 0, 1);
        }
        /// <summary>
        /// Creates a color basec of given values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Color ToColor(this float first, float second, float third)
        {
            return new Color(first, second, third, 1);
        }
        /// <summary>
        /// Creates a color basec of given values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Color ToColor(this float first, float second, float third, float fourth)
        {
            return new Color(first, second, third, fourth);
        }

        /// <summary>
        /// Convert ushort to color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color ToColor(this ushort value)
        {
            byte[] bytes = System.BitConverter.GetBytes(value);
            if (bytes.Length == 1)
                return new Color(((float)bytes[0]) / 256, 1, 1, 1);
            if (bytes.Length == 2)
                return new Color(((float)bytes[0]) / 256, (((float)bytes[1]) / 256), 1, 1);
            if (bytes.Length == 3)
                return new Color(((float)bytes[0]) / 256, (((float)bytes[1]) / 256), (((float)bytes[2]) / 256), 1);
            if (bytes.Length == 4)
                return new Color(((float)bytes[0]) / 256, (((float)bytes[1]) / 256), (((float)bytes[2]) / 256), (((float)bytes[3]) / 256));

            //Debug.LogErrorFormat("Value of {0} could not be converted to a color", value);
            return Color.black;

        }

        /// <summary>
        /// converts a number to a color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color ToColor(this float value)
        {
            return ((ushort)value).ToColor();
        }

        /// <summary>
        /// Return a int number containing 2 channels of the provided color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToUInt16(this Color value)
        {
            byte[] colorBytes = new byte[4];

            colorBytes[0] = (byte)(value.r * 256);
            colorBytes[1] = (byte)(value.g * 256);

            return System.BitConverter.ToUInt16(colorBytes, 0);
        }


        /// <summary>
        /// Return a Uint number containing 2 channels of the provided color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt16(this Color value)
        {
            byte[] colorBytes = new byte[4];

            colorBytes[0] = (byte)(value.r * 256);
            colorBytes[1] = (byte)(value.g * 256);

            return System.BitConverter.ToInt16(colorBytes, 0);
        }

        /// <summary>
        /// Return a short number containing 2 channels of the provided color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static short ToShort16(this Color value)
        {
            byte[] colorBytes = new byte[4];

            colorBytes[0] = (byte)(value.r * 256);
            colorBytes[1] = (byte)(value.g * 256);

            return System.BitConverter.ToInt16(colorBytes, 0);
        }

        /// <summary>
        /// Return a Ushort number containing 2 channels of the provided color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ushort ToUshort16(this Color value)
        {
            byte[] colorBytes = new byte[4];

            colorBytes[0] = (byte)(value.r * 256);
            colorBytes[1] = (byte)(value.g * 256);

            return System.BitConverter.ToUInt16(colorBytes, 0);
        }

        /// <summary>
        /// Return a int number containing 4 channels of the provided color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this Color value)
        {
            byte[] colorBytes = new byte[4];

            colorBytes[0] = (byte)(value.r * 256);
            colorBytes[1] = (byte)(value.g * 256);
            colorBytes[2] = (byte)(value.b * 256);
            colorBytes[3] = (byte)(value.a * 256);

            return System.BitConverter.ToInt32(colorBytes, 0);
        }

        /// <summary>
        /// Return a Uint number containing 4 channels of the provided color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static uint ToUInt32(this Color value)
        {
            byte[] colorBytes = new byte[4];

            colorBytes[0] = (byte)(value.r * 256);
            colorBytes[1] = (byte)(value.g * 256);
            colorBytes[2] = (byte)(value.b * 256);
            colorBytes[3] = (byte)(value.a * 256);

            return System.BitConverter.ToUInt32(colorBytes, 0);
        }

        /// <summary>
        /// Converts a float[,] array to a textue2D
        /// Where value * maxvalue, toColorValue
        /// </summary>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        //public static Texture2D ToTexture2D(this float[,] array, int width, int height, int maxValue)
        //{
        //    Texture2D t2D = new Texture2D(width, height);
        //    ushort value;

        //    for (int x = 0; x < width; x++)
        //    {
        //        for (int y = 0; y < height; y++)
        //        {
        //            value = (ushort)(array[x, y] * maxValue);
        //            if (maxValue <= 256)
        //                t2D.SetPixel(x, y, (value).ToColor());
        //        }
        //    }
        //    t2D.Apply();
        //    return t2D;
        //}

    }
}
