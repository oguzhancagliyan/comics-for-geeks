﻿using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Proletarians.Utility
{
    public static class Extensions
    {
        public static string GetMd5HashData(this string yourString)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(yourString)).Select(s => s.ToString("x2")));
        }
        public static string GetTimeStamp(this DateTime date)
        {
            return date.ToString("yyyyMMddHHmmssfff");
        }
    }
}
