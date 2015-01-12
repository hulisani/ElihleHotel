using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Monitor.Entities
{
    public static class ExtentionMethods
    {
        public static void ForEach<T>(this IEnumerable<T> seq, Action<T> action)
        {
            foreach (T item in seq)
            {
                action(item);
            }
        }
    }
}
