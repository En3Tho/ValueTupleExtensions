#if !NETSTANDARD2_0

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace En3Tho.ValueTupleExtensions.TaskExtensions
{
    internal struct WhenAllHelper2
    {
        private Task _task1;
        private Task _task2;
        private int _count;

        private void AddInternal(Task task)
        {
            Debug.Assert(_count < 2);

            if (!task.IsCompleted)
            {
                switch (_count)
                {
                    case 0:
                        _task1 = task;
                        break;
                    case 1:
                        _task2 = task;
                        break;
                }

                _count++;
            }
        }

        public void Add(Task task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(Task<T> task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(ValueTask<T> task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public void Add(ValueTask task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public Task[] ToArray() => MemoryMarshal.CreateSpan(ref _task1, _count).ToArray();

        public bool IsEmpty => _count == 0;
    }

    internal struct WhenAllHelper3
    {
        private Task _task1;
        private Task _task2;
        private Task _task3;
        private int _count;

        private void AddInternal(Task task)
        {
            Debug.Assert(_count < 3);

            if (!task.IsCompleted)
            {
                switch (_count)
                {
                    case 0:
                        _task1 = task;
                        break;
                    case 1:
                        _task2 = task;
                        break;
                    case 2:
                        _task3 = task;
                        break;
                }

                _count++;
            }
        }

        public void Add(Task task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(Task<T> task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(ValueTask<T> task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public void Add(ValueTask task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public Task[] ToArray() => MemoryMarshal.CreateSpan(ref _task1, _count).ToArray();

        public bool IsEmpty => _count == 0;
    }

    internal struct WhenAllHelper4
    {
        private Task _task1;
        private Task _task2;
        private Task _task3;
        private Task _task4;
        private int _count;

        private void AddInternal(Task task)
        {
            Debug.Assert(_count < 4);

            if (!task.IsCompleted)
            {
                switch (_count)
                {
                    case 0:
                        _task1 = task;
                        break;
                    case 1:
                        _task2 = task;
                        break;
                    case 2:
                        _task3 = task;
                        break;
                    case 3:
                        _task4 = task;
                        break;
                }

                _count++;
            }
        }

        public void Add(Task task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(Task<T> task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(ValueTask<T> task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public void Add(ValueTask task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public Task[] ToArray() => MemoryMarshal.CreateSpan(ref _task1, _count).ToArray();

        public bool IsEmpty => _count == 0;
    }

    internal struct WhenAllHelper5
    {
        private Task _task1;
        private Task _task2;
        private Task _task3;
        private Task _task4;
        private Task _task5;
        private int _count;

        private void AddInternal(Task task)
        {
            Debug.Assert(_count < 5);

            if (!task.IsCompleted)
            {
                switch (_count)
                {
                    case 0:
                        _task1 = task;
                        break;
                    case 1:
                        _task2 = task;
                        break;
                    case 2:
                        _task3 = task;
                        break;
                    case 3:
                        _task4 = task;
                        break;
                    case 4:
                        _task5 = task;
                        break;
                }

                _count++;
            }
        }

        public void Add(Task task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(Task<T> task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(ValueTask<T> task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public void Add(ValueTask task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public Task[] ToArray() => MemoryMarshal.CreateSpan(ref _task1, _count).ToArray();

        public bool IsEmpty => _count == 0;
    }

    internal struct WhenAllHelper6
    {
        private Task _task1;
        private Task _task2;
        private Task _task3;
        private Task _task4;
        private Task _task5;
        private Task _task6;
        private int _count;

        private void AddInternal(Task task)
        {
            Debug.Assert(_count < 6);

            if (!task.IsCompleted)
            {
                switch (_count)
                {
                    case 0:
                        _task1 = task;
                        break;
                    case 1:
                        _task2 = task;
                        break;
                    case 2:
                        _task3 = task;
                        break;
                    case 3:
                        _task4 = task;
                        break;
                    case 4:
                        _task5 = task;
                        break;
                    case 5:
                        _task6 = task;
                        break;
                }

                _count++;
            }
        }

        public void Add(Task task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(Task<T> task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(ValueTask<T> task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public void Add(ValueTask task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public Task[] ToArray() => MemoryMarshal.CreateSpan(ref _task1, _count).ToArray();

        public bool IsEmpty => _count == 0;
    }

    internal struct WhenAllHelper7
    {
        private Task _task1;
        private Task _task2;
        private Task _task3;
        private Task _task4;
        private Task _task5;
        private Task _task6;
        private Task _task7;
        private int _count;

        private void AddInternal(Task task)
        {
            Debug.Assert(_count < 7);

            if (!task.IsCompleted)
            {
                switch (_count)
                {
                    case 0:
                        _task1 = task;
                        break;
                    case 1:
                        _task2 = task;
                        break;
                    case 2:
                        _task3 = task;
                        break;
                    case 3:
                        _task4 = task;
                        break;
                    case 4:
                        _task5 = task;
                        break;
                    case 5:
                        _task6 = task;
                        break;
                    case 6:
                        _task7 = task;
                        break;
                }

                _count++;
            }
        }

        public void Add(Task task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(Task<T> task)
        {
            if (!task.IsCompleted) AddInternal(task);
        }

        public void Add<T>(ValueTask<T> task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public void Add(ValueTask task)
        {
            if (!task.IsCompleted) AddInternal(task.AsTask());
        }

        public Task[] ToArray() => MemoryMarshal.CreateSpan(ref _task1, _count).ToArray();

        public bool IsEmpty => _count == 0;
    }
}

#endif