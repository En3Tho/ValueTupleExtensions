using System;
using System.Collections.Generic;
using static En3Tho.ValueTupleExtensions.ThrowHelper;

namespace En3Tho.ValueTupleExtensions.Linq
{
    public static partial class IEnumerableToValueTupleExtensions
    {
        public static (TSource, TSource) Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            return SingleOrDefaultInternal(source, predicate1, predicate2, true);
        }

        public static (TSource, TSource, TSource) Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, true);
        }

        public static (TSource, TSource, TSource, TSource) Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, true);
        }

        public static (TSource, TSource, TSource, TSource, TSource) Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            predicate5 ??= ThrowArgumentNullException(predicate5, nameof(predicate5));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, predicate5, true);
        }

        public static (TSource, TSource, TSource, TSource, TSource, TSource) Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5, Func<TSource, bool> predicate6)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            predicate5 ??= ThrowArgumentNullException(predicate5, nameof(predicate5));
            predicate6 ??= ThrowArgumentNullException(predicate6, nameof(predicate6));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, predicate5, predicate6, true);
        }

        public static (TSource, TSource, TSource, TSource, TSource, TSource, TSource) Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5, Func<TSource, bool> predicate6,
            Func<TSource, bool> predicate7)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            predicate5 ??= ThrowArgumentNullException(predicate5, nameof(predicate5));
            predicate6 ??= ThrowArgumentNullException(predicate6, nameof(predicate6));
            predicate7 ??= ThrowArgumentNullException(predicate7, nameof(predicate7));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, predicate5, predicate6, predicate7, true);
        }
    }
}