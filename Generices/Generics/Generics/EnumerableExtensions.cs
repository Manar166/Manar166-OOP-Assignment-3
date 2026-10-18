using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class EnumerableExtensions
    {

        public static IEnumerable<T> Page<T>(this IEnumerable<T>source ,  int pageNumber, int pageSize)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (pageNumber < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be greater than or equal to 1.");
            }
            if (pageSize < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be greater than or equal to 1.");
            }

            int skipCount = (pageNumber - 1) * pageSize;
            int skipped = 0;
            int taken = 0;

            foreach (var item in source)
            {
                if (skipped < skipCount)
                {
                    skipped++;
                    continue;
                }

                if (taken < pageSize)
                {
                    yield return item;
                    taken++;
                }
                else
                {
                    break;
                }

            }



        }



        public static T FindById<T>(this IEnumerable<T> value ,int id) where T : class, IHasId
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            foreach (var item in value)
            {
                if (item.Id == id)
                    return item;
            }
            return default(T);
        }

        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> value)where T :class ,IHasId
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            Dictionary<int, T > result =new Dictionary<int, T>() ;
            foreach (var item in value)
            {
                if(item!=null)
                result.Add(item.Id, item);
            }

            return result;
        }
    }
}
