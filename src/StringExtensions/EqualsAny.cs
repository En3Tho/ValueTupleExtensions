using System;
using System.Runtime.CompilerServices;

namespace En3Tho.ValueTupleExtensions.StringExtensions
{
    public static partial class StringToValueTupleExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(this string? s, (string?, string?, string?, string?, string?, string?, string?) tuple, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(s, tuple.Item1, comparison)
            || string.Equals(s, tuple.Item2, comparison)
            || string.Equals(s, tuple.Item3, comparison)
            || string.Equals(s, tuple.Item4, comparison)
            || string.Equals(s, tuple.Item5, comparison)
            || string.Equals(s, tuple.Item6, comparison)
            || string.Equals(s, tuple.Item7, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(this string? s, (string?, string?, string?, string?, string?, string?) tuple, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(s, tuple.Item1, comparison)
            || string.Equals(s, tuple.Item2, comparison)
            || string.Equals(s, tuple.Item3, comparison)
            || string.Equals(s, tuple.Item4, comparison)
            || string.Equals(s, tuple.Item5, comparison)
            || string.Equals(s, tuple.Item6, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(this string? s, (string?, string?, string?, string?, string?) tuple, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(s, tuple.Item1, comparison)
            || string.Equals(s, tuple.Item2, comparison)
            || string.Equals(s, tuple.Item3, comparison)
            || string.Equals(s, tuple.Item4, comparison)
            || string.Equals(s, tuple.Item5, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(this string? s, (string?, string?, string?, string?) tuple, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(s, tuple.Item1, comparison)
            || string.Equals(s, tuple.Item2, comparison)
            || string.Equals(s, tuple.Item3, comparison)
            || string.Equals(s, tuple.Item4, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(this string? s, (string?, string?, string?) tuple, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(s, tuple.Item1, comparison)
            || string.Equals(s, tuple.Item2, comparison)
            || string.Equals(s, tuple.Item3, comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(this string? s, (string?, string?) tuple, StringComparison comparison = StringComparison.Ordinal)
            => string.Equals(s, tuple.Item1, comparison)
            || string.Equals(s, tuple.Item2, comparison);
    }
}