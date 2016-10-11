using System;
using System.Collections.Generic;

namespace KBCommonExtensions
{
    public static class NumericExtensions
    {
        /// <summary>
        /// Seperates the number with comma (Thousand Seperator)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static string ThousandSeparator<T>(T obj)
        {
            string seperator = string.Empty;
            if(obj != null) { 
                seperator = string.Format("{0:n}", obj);
            }
            return seperator;
        }
    }
}
