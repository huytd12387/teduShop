using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Tedu.Common.Ultils
{
    public class StringHelper
    {
        /// <summary>
        /// Return MD5 Cryption
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Md5Hash(string text)
        {
            var md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(text);
            bs = md5Hasher.ComputeHash(bs);
            var s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }

        /// <summary>
        /// Convert Name string to MetaTitle
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToUnsignString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            input = input.Replace(".", "-");
            input = input.Replace(" ", "-");
            input = input.Replace(",", "-");
            input = input.Replace(";", "-");
            input = input.Replace(":", "-");
            input = input.Replace("  ", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?", StringComparison.Ordinal) >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?", StringComparison.Ordinal), 1);
            }
            while (str2.Contains("--"))
            {
                str2 = str2.Replace("--", "-").ToLower();
            }
            return str2;
        }
    }
}