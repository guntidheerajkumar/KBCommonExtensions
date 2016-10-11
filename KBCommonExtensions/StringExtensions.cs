
using System;
using System.Linq;

namespace KBCommonExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Generates random password based on length
        /// </summary>
        /// <param name="value">String Length</param>
        /// <returns></returns>
        public static string RandomPassword(int value)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*(){}[]";
            return new string(Enumerable.Repeat(chars, value)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Randoms the Fake paragraph text.
        /// </summary>
        /// <param name="value">Number of lines to count. default is 1.</param>
        /// <returns></returns>
        public static string RandomParagraphText(int value = 1)
        {
            string repeatedString = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.";
            return String.Join(Environment.NewLine, Enumerable.Repeat(repeatedString, value));
        }
    }
}
