using System;
using System.Collections.Generic;
using System.Linq;

namespace core
{
    public static class Iterating
    {
        public static void Each<T>(this IEnumerable<T> items, Action<T> visitor)
        {
            foreach (var item in items ?? Enumerable.Empty<T>()) visitor(item);
        }
    }
}