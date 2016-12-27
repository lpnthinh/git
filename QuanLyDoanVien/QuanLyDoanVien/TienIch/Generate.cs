﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien.TienIch
{
    public class Generate
    {
        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public static string Random(bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, lowerCase));
            builder.Append(RandomNumber(1000, 9999));
            // builder.Append(RandomString(2, false));
            return builder.ToString();
        }
    }
}
