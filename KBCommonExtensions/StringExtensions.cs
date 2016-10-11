//MIT License

//Copyright(c) 2016 Dheeraj Kumar G

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

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
