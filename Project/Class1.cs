using System;

namespace MyCustomSpace
{
    public class CustomGenList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public CustomGenList()
        {
            items = new T[0];
            count = 0;
            capacity = 0;
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                if (capacity == 0)
                    capacity = 4;
                else
                    capacity *= 2;

                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }

            items[count] = item;
            count++;
        }

        public T Find(Predicate<T> match)
        {
            return Array.Find(items, match);
        }

        public CustomGenList<T> FindAll(Predicate<T> match)
        {
            T[] foundItems = Array.FindAll(items, match);
            CustomGenList<T> resultList = new CustomGenList<T>();

            foreach (T item in foundItems)
            {
                resultList.Add(item);
            }

            return resultList;
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(items, item) >= 0;
        }

        public bool Exists(Predicate<T> match)
        {
            return Array.Exists(items, match);
        }

        public void Remove(Predicate<T> match)
        {
            int newIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if (!match(items[i]))
                {
                    items[newIndex] = items[i];
                    newIndex++;
                }
            }

            count = newIndex;
        }
    }
}

