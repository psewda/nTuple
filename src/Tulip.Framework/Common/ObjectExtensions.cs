using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Common
{
    internal static class ObjectExtensions
    {
        /// <summary>
        /// Converts the specified value into string representation.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <param name="useQuote">A boolean true to use quotation; false to ignore.</param>
        /// <returns>The converted value in string representation.</returns>
        public static string ToString<T>(this T value, bool useQuote = true)
        {
            if (value != null)
            {
                var format = useQuote ? "'{0}'" : "{0}";
                return string.Format(format, value);
            }
            else
            {
                return "null";
            }
        }

        /// <summary>
        /// Converts the specified value to lowercase.
        /// </summary>
        /// <param name="value">The value to be converted to lowercase.</param>
        /// <returns>The value converted to lowercase.</returns>
        public static string ToLower<T>(this T value)
        {
            return value != null ? value.ToString().ToLower() : null;
        }

        /// <summary>
        /// Converts the specified value to uppercase.
        /// </summary>
        /// <param name="value">The value to be converted to uppercase.</param>
        /// <returns>The value converted to uppercase.</returns>
        public static string ToUpper<T>(this T value)
        {
            return value != null ? value.ToString().ToUpper() : null;
        }
    }
}
