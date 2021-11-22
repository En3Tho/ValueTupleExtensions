#if !NETSTANDARD2_0
using System.Threading.Tasks;

namespace En3Tho.ValueTupleExtensions.TaskExtensions
{
    public static partial class TaskToValueTupleExtensions
    {
        public static async ValueTask<(T1, T2)> WhenAll<T1, T2>(this (ValueTask<T1>, ValueTask<T2>) tasks)
        {
            var (task1, task2) = tasks;

            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

            return (task1.Result, task2.Result);
        }

        public static async ValueTask<(T1, T2, T3)> WhenAll<T1, T2, T3>(this (ValueTask<T1>, ValueTask<T2>, ValueTask<T3>) tasks)
        {
            var (task1, task2, task3) = tasks;

            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

            return (task1.Result, task2.Result, task3.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(this (ValueTask<T1>, ValueTask<T2>, ValueTask<T3>, ValueTask<T4>) tasks)
        {
            var (task1, task2, task3, task4) = tasks;

            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

            return (task1.Result, task2.Result, task3.Result, task4.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(this (ValueTask<T1>, ValueTask<T2>, ValueTask<T3>, ValueTask<T4>, ValueTask<T5>) tasks)
        {
            var (task1, task2, task3, task4, task5) = tasks;

            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);
            whenAllHelper.Add(task5);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(this (ValueTask<T1>, ValueTask<T2>, ValueTask<T3>, ValueTask<T4>, ValueTask<T5>, ValueTask<T6>) tasks)
        {
            var (task1, task2, task3, task4, task5, task6) = tasks;

            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);
            whenAllHelper.Add(task5);
            whenAllHelper.Add(task6);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(this (ValueTask<T1>, ValueTask<T2>, ValueTask<T3>, ValueTask<T4>, ValueTask<T5>, ValueTask<T6>, ValueTask<T7>) tasks)
        {
            var (task1, task2, task3, task4, task5, task6, task7) = tasks;

            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);
            whenAllHelper.Add(task5);
            whenAllHelper.Add(task6);
            whenAllHelper.Add(task7);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result);
        }
    }
}
#endif