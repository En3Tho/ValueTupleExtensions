using System;
using System.Runtime.CompilerServices;

namespace En3Tho.ValueTupleExtensions.StringExtensions
{
    public static partial class StringToValueTupleExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equals(this (string?, string?, string?, string?, string?, string?, string?) tuple, (string?, string?, string?, string?, string?, string?, string?) tuple2, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(tuple.Item1, tuple2.Item1, comparison)
            && string.Equals(tuple.Item2, tuple2.Item2, comparison)
            && string.Equals(tuple.Item3, tuple2.Item3, comparison)
            && string.Equals(tuple.Item4, tuple2.Item4, comparison)
            && string.Equals(tuple.Item5, tuple2.Item5, comparison)
            && string.Equals(tuple.Item6, tuple2.Item6, comparison)
            && string.Equals(tuple.Item7, tuple2.Item7, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equals(this (string?, string?, string?, string?, string?, string?) tuple, (string?, string?, string?, string?, string?, string?) tuple2, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(tuple.Item1, tuple2.Item1, comparison)
            && string.Equals(tuple.Item2, tuple2.Item2, comparison)
            && string.Equals(tuple.Item3, tuple2.Item3, comparison)
            && string.Equals(tuple.Item4, tuple2.Item4, comparison)
            && string.Equals(tuple.Item5, tuple2.Item5, comparison)
            && string.Equals(tuple.Item6, tuple2.Item6, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equals(this (string?, string?, string?, string?, string?) tuple, (string?, string?, string?, string?, string?) tuple2, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(tuple.Item1, tuple2.Item1, comparison)
            && string.Equals(tuple.Item2, tuple2.Item2, comparison)
            && string.Equals(tuple.Item3, tuple2.Item3, comparison)
            && string.Equals(tuple.Item4, tuple2.Item4, comparison)
            && string.Equals(tuple.Item5, tuple2.Item5, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equals(this (string?, string?, string?, string?) tuple, (string?, string?, string?, string?) tuple2, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(tuple.Item1, tuple2.Item1, comparison)
            && string.Equals(tuple.Item2, tuple2.Item2, comparison)
            && string.Equals(tuple.Item3, tuple2.Item3, comparison)
            && string.Equals(tuple.Item4, tuple2.Item4, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equals(this (string?, string?, string?) tuple, (string?, string?, string?) tuple2, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(tuple.Item1, tuple2.Item1, comparison)
            && string.Equals(tuple.Item2, tuple2.Item2, comparison)
            && string.Equals(tuple.Item3, tuple2.Item3, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equals(this (string?, string?) tuple, (string?, string?) tuple2, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(tuple.Item1, tuple2.Item1, comparison)
            && string.Equals(tuple.Item2, tuple2.Item2, comparison);
    }
}