using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static En3Tho.ValueTupleExtensions.ThrowHelper;

namespace En3Tho.ValueTupleExtensions.Linq
{
    public static partial class IEnumerableToValueTupleExtensions
    {
        private const string ThrowNoMatchExceptionFormat = "Sequence contains no matching element ({0})";
        private const string ThrowMoreThanOneMatchExceptionFormat = "Sequence contains more than one matching element ({0})";

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void ThrowNoMatchException(string predicate) => ThrowInvalidOperationException(string.Format(ThrowNoMatchExceptionFormat, predicate));

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void ThrowMoreThanOneMatchException(string predicate) => ThrowInvalidOperationException(string.Format(ThrowMoreThanOneMatchExceptionFormat, predicate));

        public static (TSource, TSource) SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            return SingleOrDefaultInternal(source, predicate1, predicate2, false);
        }

        public static (TSource, TSource, TSource) SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, false);
        }

        public static (TSource, TSource, TSource, TSource) SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, false);
        }

        public static (TSource, TSource, TSource, TSource, TSource) SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            predicate5 ??= ThrowArgumentNullException(predicate5, nameof(predicate5));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, predicate5, false);
        }

        public static (TSource, TSource, TSource, TSource, TSource, TSource) SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5, Func<TSource, bool> predicate6)
        {
            source ??= ThrowArgumentNullException(source, nameof(source));
            predicate1 ??= ThrowArgumentNullException(predicate1, nameof(predicate1));
            predicate2 ??= ThrowArgumentNullException(predicate2, nameof(predicate2));
            predicate3 ??= ThrowArgumentNullException(predicate3, nameof(predicate3));
            predicate4 ??= ThrowArgumentNullException(predicate4, nameof(predicate4));
            predicate5 ??= ThrowArgumentNullException(predicate5, nameof(predicate5));
            predicate6 ??= ThrowArgumentNullException(predicate6, nameof(predicate6));
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, predicate5, predicate6, false);
        }

        public static (TSource, TSource, TSource, TSource, TSource, TSource, TSource) SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate1,
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
            return SingleOrDefaultInternal(source, predicate1, predicate2, predicate3, predicate4, predicate5, predicate6, predicate7, false);
        }

        private static (TSource, TSource) SingleOrDefaultInternal<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate1, Func<TSource, bool> predicate2, bool checkValidity)
        {
            bool found1 = false;
            bool found2 = false;
            var (result1, result2) = (default(TSource)!, default(TSource)!);

            if (source is IList<TSource> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var current = list[i];
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }
                }
            }
            else
            {
                using var e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    var current = e.Current;
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }
                }
            }

            if (checkValidity)
            {
                if (!found1) ThrowNoMatchException(nameof(predicate1));
                if (!found2) ThrowNoMatchException(nameof(predicate2));
            }

            return (result1, result2);
        }

        private static (TSource, TSource, TSource) SingleOrDefaultInternal<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, bool checkValidity)
        {
            bool found1 = false;
            bool found2 = false;
            bool found3 = false;
            var (result1, result2, result3) =
                (default(TSource)!, default(TSource)!, default(TSource)!);

            if (source is IList<TSource> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var current = list[i];
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }
                }
            }
            else
            {
                using var e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    var current = e.Current;
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }
                }
            }

            if (checkValidity)
            {
                if (!found1) ThrowNoMatchException(nameof(predicate1));
                if (!found2) ThrowNoMatchException(nameof(predicate2));
                if (!found3) ThrowNoMatchException(nameof(predicate3));
            }

            return (result1, result2, result3);
        }

        private static (TSource, TSource, TSource, TSource) SingleOrDefaultInternal<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, bool checkValidity)
        {
            bool found1 = false;
            bool found2 = false;
            bool found3 = false;
            bool found4 = false;
            var (result1, result2, result3, result4) =
                (default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!);

            if (source is IList<TSource> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var current = list[i];
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }
                }
            }
            else
            {
                using var e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    var current = e.Current;
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }
                }
            }

            if (checkValidity)
            {
                if (!found1) ThrowNoMatchException(nameof(predicate1));
                if (!found2) ThrowNoMatchException(nameof(predicate2));
                if (!found3) ThrowNoMatchException(nameof(predicate3));
                if (!found4) ThrowNoMatchException(nameof(predicate4));
            }

            return (result1, result2, result3, result4);
        }

        private static (TSource, TSource, TSource, TSource, TSource) SingleOrDefaultInternal<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5, bool checkValidity)
        {
            bool found1 = false;
            bool found2 = false;
            bool found3 = false;
            bool found4 = false;
            bool found5 = false;
            var (result1, result2, result3, result4, result5) =
                (default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!);

            if (source is IList<TSource> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var current = list[i];
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }

                    if (predicate5(current))
                    {
                        if (found5) ThrowMoreThanOneMatchException(nameof(predicate5));
                        found5 = true;
                        result5 = current;
                    }
                }
            }
            else
            {
                using var e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    var current = e.Current;
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }

                    if (predicate5(current))
                    {
                        if (found5) ThrowMoreThanOneMatchException(nameof(predicate5));
                        found5 = true;
                        result5 = current;
                    }
                }
            }

            if (checkValidity)
            {
                if (!found1) ThrowNoMatchException(nameof(predicate1));
                if (!found2) ThrowNoMatchException(nameof(predicate2));
                if (!found3) ThrowNoMatchException(nameof(predicate3));
                if (!found4) ThrowNoMatchException(nameof(predicate4));
                if (!found5) ThrowNoMatchException(nameof(predicate5));
            }

            return (result1, result2, result3, result4, result5);
        }

        private static (TSource, TSource, TSource, TSource, TSource, TSource) SingleOrDefaultInternal<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5, Func<TSource, bool> predicate6, bool checkValidity)
        {
            bool found1 = false;
            bool found2 = false;
            bool found3 = false;
            bool found4 = false;
            bool found5 = false;
            bool found6 = false;
            var (result1, result2, result3, result4, result5, result6) =
                (default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!);

            if (source is IList<TSource> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var current = list[i];
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }

                    if (predicate5(current))
                    {
                        if (found5) ThrowMoreThanOneMatchException(nameof(predicate5));
                        found5 = true;
                        result5 = current;
                    }

                    if (predicate6(current))
                    {
                        if (found6) ThrowMoreThanOneMatchException(nameof(predicate6));
                        found6 = true;
                        result6 = current;
                    }
                }
            }
            else
            {
                using var e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    var current = e.Current;
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }

                    if (predicate5(current))
                    {
                        if (found5) ThrowMoreThanOneMatchException(nameof(predicate5));
                        found5 = true;
                        result5 = current;
                    }

                    if (predicate6(current))
                    {
                        if (found6) ThrowMoreThanOneMatchException(nameof(predicate6));
                        found6 = true;
                        result6 = current;
                    }
                }
            }

            if (checkValidity)
            {
                if (!found1) ThrowNoMatchException(nameof(predicate1));
                if (!found2) ThrowNoMatchException(nameof(predicate2));
                if (!found3) ThrowNoMatchException(nameof(predicate3));
                if (!found4) ThrowNoMatchException(nameof(predicate4));
                if (!found5) ThrowNoMatchException(nameof(predicate5));
                if (!found6) ThrowNoMatchException(nameof(predicate6));
            }

            return (result1, result2, result3, result4, result5, result6);
        }

        private static (TSource, TSource, TSource, TSource, TSource, TSource, TSource) SingleOrDefaultInternal<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate1,
            Func<TSource, bool> predicate2, Func<TSource, bool> predicate3, Func<TSource, bool> predicate4, Func<TSource, bool> predicate5, Func<TSource, bool> predicate6,
            Func<TSource, bool> predicate7, bool checkValidity)
        {
            bool found1 = false;
            bool found2 = false;
            bool found3 = false;
            bool found4 = false;
            bool found5 = false;
            bool found6 = false;
            bool found7 = false;
            var (result1, result2, result3, result4, result5, result6, result7) =
                (default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!, default(TSource)!);

            if (source is IList<TSource> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var current = list[i];
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }

                    if (predicate5(current))
                    {
                        if (found5) ThrowMoreThanOneMatchException(nameof(predicate5));
                        found5 = true;
                        result5 = current;
                    }

                    if (predicate6(current))
                    {
                        if (found6) ThrowMoreThanOneMatchException(nameof(predicate6));
                        found6 = true;
                        result6 = current;
                    }

                    if (predicate7(current))
                    {
                        if (found7) ThrowMoreThanOneMatchException(nameof(predicate7));
                        found7 = true;
                        result7 = current;
                    }
                }
            }
            else
            {
                using var e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    var current = e.Current;
                    if (predicate1(current))
                    {
                        if (found1) ThrowMoreThanOneMatchException(nameof(predicate1));
                        found1 = true;
                        result1 = current;
                    }

                    if (predicate2(current))
                    {
                        if (found2) ThrowMoreThanOneMatchException(nameof(predicate2));
                        found2 = true;
                        result2 = current;
                    }

                    if (predicate3(current))
                    {
                        if (found3) ThrowMoreThanOneMatchException(nameof(predicate3));
                        found3 = true;
                        result3 = current;
                    }

                    if (predicate4(current))
                    {
                        if (found4) ThrowMoreThanOneMatchException(nameof(predicate4));
                        found4 = true;
                        result4 = current;
                    }

                    if (predicate5(current))
                    {
                        if (found5) ThrowMoreThanOneMatchException(nameof(predicate5));
                        found5 = true;
                        result5 = current;
                    }

                    if (predicate6(current))
                    {
                        if (found6) ThrowMoreThanOneMatchException(nameof(predicate6));
                        found6 = true;
                        result6 = current;
                    }

                    if (predicate7(current))
                    {
                        if (found7) ThrowMoreThanOneMatchException(nameof(predicate7));
                        found7 = true;
                        result7 = current;
                    }
                }
            }

            if (checkValidity)
            {
                if (!found1) ThrowNoMatchException(nameof(predicate1));
                if (!found2) ThrowNoMatchException(nameof(predicate2));
                if (!found3) ThrowNoMatchException(nameof(predicate3));
                if (!found4) ThrowNoMatchException(nameof(predicate4));
                if (!found5) ThrowNoMatchException(nameof(predicate5));
                if (!found6) ThrowNoMatchException(nameof(predicate6));
                if (!found7) ThrowNoMatchException(nameof(predicate7));
            }

            return (result1, result2, result3, result4, result5, result6, result7);
        }
    }
}