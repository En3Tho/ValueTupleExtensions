using System.Threading.Tasks;

namespace En3Tho.ValueTupleExtensions.TaskExtensions
{
    public static partial class TaskToValueTupleExtensions
    {
        public static async Task<(T1, T2)> WhenAll<T1, T2>(this (Task<T1>, Task<T2>) tasks)
        {
            var (task1, task2) = tasks;

#if NETSTANDARD2_0
            await Task.WhenAll(task1, task2);
#else
            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());

#endif

            return (task1.Result, task2.Result);
        }

        public static async Task<(T1, T2, T3)> WhenAll<T1, T2, T3>(this (Task<T1>, Task<T2>, Task<T3>) tasks)
        {
            var (task1, task2, task3) = tasks;
#if NETSTANDARD2_0
            await Task.WhenAll(task1, task2);
#else
            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());
#endif
            return (task1.Result, task2.Result, task3.Result);
        }

        public static async Task<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>) tasks)
        {
            var (task1, task2, task3, task4) = tasks;
#if NETSTANDARD2_0
            await Task.WhenAll(task1, task2);
#else
            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());
#endif
            return (task1.Result, task2.Result, task3.Result, task4.Result);
        }

        public static async Task<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>) tasks)
        {
            var (task1, task2, task3, task4, task5) = tasks;
#if NETSTANDARD2_0
            await Task.WhenAll(task1, task2);
#else
            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);
            whenAllHelper.Add(task5);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());
#endif
            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>) tasks)
        {
            var (task1, task2, task3, task4, task5, task6) = tasks;
#if NETSTANDARD2_0
            await Task.WhenAll(task1, task2);
#else
            var whenAllHelper = new WhenAllHelper2();

            whenAllHelper.Add(task1);
            whenAllHelper.Add(task2);
            whenAllHelper.Add(task3);
            whenAllHelper.Add(task4);
            whenAllHelper.Add(task5);
            whenAllHelper.Add(task6);

            if (!whenAllHelper.IsEmpty)
                await Task.WhenAll(whenAllHelper.ToArray());
#endif
            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>) tasks)
        {
            var (task1, task2, task3, task4, task5, task6, task7) = tasks;
#if NETSTANDARD2_0
            await Task.WhenAll(task1, task2);
#else
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
#endif
            return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result);
        }
    }
}