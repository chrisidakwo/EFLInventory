using System;

namespace Inventory.Helpers {
    public static class StringHelpers {
        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// It's insensitive to case and not culture-aware.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <param name="stringComparison"></param>
        /// <returns></returns>
        public static bool CaseInsensitiveContains(this string source, string value, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase) {
            return source.IndexOf(value, stringComparison) >= 0;
        }
    }
}