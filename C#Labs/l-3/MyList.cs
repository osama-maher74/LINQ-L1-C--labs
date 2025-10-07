using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	internal class MyList<T> where T : IComparable<T>
	{
		T[] arr;
		int size;
		int top; 

		public MyList(int _size = 5) 
		{
			size = _size;
			arr = new T[size];
			top = -1;
		}
		public T this[int index]
		{
			get
			{
				if (top != -1 && index <= top)
				{
					return arr[index];
				}
				else
				{
					Console.WriteLine("There is No Data");
					throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (top != -1 && index <= top)
				{
					arr[index] = value;
				}
				else
				{
					Console.WriteLine("There is No Data");
					throw new IndexOutOfRangeException();
				}
			}
		}

		public void Add(T item)
		{
			if (top < size - 1)
			{
				top++;
				arr[top] = item;
			}
			else
			{
				T[] arr1 = new T[size * 2];
				for (int i = 0; i < size; i++)
				{
					arr1[i] = arr[i];
				}
				top++;
				arr1[top] = item;
				size = size * 2;
				arr = arr1;
			}
		}
		public T Get(int item)
		{
			if (top != -1 && item <= top)
			{
				return arr[item];
			}
			Console.WriteLine("There is No Data");
			throw new IndexOutOfRangeException();
		}
        public bool Remove(T item)
        {
            int index = -1;
            for (int i = 0; i <= top; i++)
            {
				if (arr[i].CompareTo(item) == 0)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                return false; 
            }

            for (int i = index; i < top; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[top] = default(T); // or null 
            top--;
            return true;
        }
	}
}
