using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace En3Tho.ValueTupleExtensions.LinqToValueTuple
{
    public static partial class ValueTupleLinqLikeExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MaybeNull]
        public static T? FirstOrDefault<T>(in this (T v1, T v2, T v3, T v4, T v5, T v6, T v7) tuple, Func<T, bool> func)
        {
            if (func(tuple.v1)) return tuple.v1;
            if (func(tuple.v2)) return tuple.v2;
            if (func(tuple.v3)) return tuple.v3;
            if (func(tuple.v4)) return tuple.v4;
            if (func(tuple.v5)) return tuple.v5;
            if (func(tuple.v6)) return tuple.v6;
            if (func(tuple.v7)) return tuple.v7;
#pragma warning disable CS8653
            return default;
#pragma warning restore
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MaybeNull]
        public static T? FirstOrDefault<T>(in this (T v1, T v2, T v3, T v4, T v5, T v6) tuple, Func<T, bool> func)
        {
            if (func(tuple.v1)) return tuple.v1;
            if (func(tuple.v2)) return tuple.v2;
            if (func(tuple.v3)) return tuple.v3;
            if (func(tuple.v4)) return tuple.v4;
            if (func(tuple.v5)) return tuple.v5;
            if (func(tuple.v6)) return tuple.v6;
#pragma warning disable CS8653
            return default;
#pragma warning restore
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MaybeNull]
        public static T? FirstOrDefault<T>(in this (T v1, T v2, T v3, T v4, T v5) tuple, Func<T, bool> func)
        {
            if (func(tuple.v1)) return tuple.v1;
            if (func(tuple.v2)) return tuple.v2;
            if (func(tuple.v3)) return tuple.v3;
            if (func(tuple.v4)) return tuple.v4;
            if (func(tuple.v5)) return tuple.v5;
#pragma warning disable CS8653
            return default;
#pragma warning restore
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MaybeNull]
        public static T? FirstOrDefault<T>(in this (T v1, T v2, T v3, T v4) tuple, Func<T, bool> func)
        {
            if (func(tuple.v1)) return tuple.v1;
            if (func(tuple.v2)) return tuple.v2;
            if (func(tuple.v3)) return tuple.v3;
            if (func(tuple.v4)) return tuple.v4;
#pragma warning disable CS8653
            return default;
#pragma warning restore
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MaybeNull]
        public static T? FirstOrDefault<T>(in this (T v1, T v2, T v3) tuple, Func<T, bool> func)
        {
            if (func(tuple.v1)) return tuple.v1;
            if (func(tuple.v2)) return tuple.v2;
            if (func(tuple.v3)) return tuple.v3;
#pragma warning disable CS8653
            return default;
#pragma warning restore
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MaybeNull]
        public static T? FirstOrDefault<T>(in this (T v1, T v2) tuple, Func<T, bool> func)
        {
            if (func(tuple.v1)) return tuple.v1;
            if (func(tuple.v2)) return tuple.v2;
#pragma warning disable CS8653
            return default;
#pragma warning restore
        }
    }
}