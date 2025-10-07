using System;

namespace c__L3
{
    internal class Mylist<T> where T : IComparable<T>
    {
        T[] arr;
        int size;
        int top;
        public int Capacity { get => size; }
        public int Count{ get => top+1; }
        public Mylist(int _size = 5)
        {
            size = _size;
            arr = new T[size];
            top = -1;
        }

        public void Add(T _item)
        {
            if (top < size - 1)
            {
                top++;
                arr[top] = _item;
            }
            else
            {
                T[] temparr= new T[size*2];

                for (int i = 0; i < size; i++)
                {
                    temparr[i] = arr[i];
                }
                top++;
                temparr[top]= _item;
                size= temparr.Length;
                arr = temparr;

            }
        }

        public T Get(int i)
        {
            if (top != -1 && i <= top)
            {
                return arr[i];
            }
            else
            {
                Console.WriteLine("there is no data");
                throw new IndexOutOfRangeException();
            }
        }

        public T this[int i] {

            get
            {
                if (top != -1 && i <= top)
                {
                    return arr[i];
                }
                else
                {
                    Console.WriteLine("there is no data");
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (top != -1 && i <= top)
                    arr[i] = value;
                else
                {
                    throw new IndexOutOfRangeException();

                }
            
            }

        }
        public bool Remove(T value)
        {
            for (int i = 0; i <= top; i++)
            {
                if (arr[i].CompareTo(value) == 0)
                {
                    for (int j = i; j < top; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    top--;
                    arr[top + 1] = default(T)!;

                    return true;
                }

            }

            return false;
        }

        public void PrintAll()
        {
            if (top == -1)
            {
                Console.WriteLine("List is empty");
                return;
            }

            for (int i = 0; i <= top; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
