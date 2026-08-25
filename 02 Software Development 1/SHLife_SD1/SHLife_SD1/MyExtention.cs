using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SHLife_SD1 {
    // Summary:
    // an extention for DateTimeOffset
    public static class DateTimeOffsetExtention {
        // Summary:
        // Represent a yyyy-MM-dd HH:mm:ss(z) format time string.
        public static string ToStdString(this DateTimeOffset time) {
            return time.ToString("yyyy-MM-dd HH:mm:ss(z)");
        }

        // Summary:
        // Represent a yyyy-MM-dd HH:mm:ss(z) format time string auto replaced with "-" when null.
        public static string ToStdString(this DateTimeOffset? time) {
            return time?.ToString("yyyy-MM-dd HH:mm:ss(z)") ?? "-";
        }
    }

    // Summary:
    // an extention for Array
    public static class ArrayExtention {
        // Summary:
        // Directly return the target value from an array,
        // if the index is out of range, return the default value.
        public static T TryGet<T>(this T[] array, int index) {
            if (index < 0 || index >= array.Length) {
                return default;
            }

            return array[index];
        }
    }
}
